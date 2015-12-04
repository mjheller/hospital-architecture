using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Scheduler;

namespace Hospital
{
    public class DoctorsOffice
    {
        public List<Doctor> doctors;
        public static int appointmentNumber = 0;
        public FileWriter fileWriter = new FileWriter();
        public List<TimeSpan> initialTimeIntervals;

        public DoctorsOffice(List<Doctor> doctors)
        {
            this.doctors = doctors;
            this.initialTimeIntervals = GetInitialTimeIntervals();
        }

        public Doctor SearchDoctors(string name)
        {
            return doctors.Find(item => item.contactInformation.Name == name);
        }

        public List<TimeSpan> GetInitialTimeIntervals()
        {
            DateTime exampleDate = new DateTime(2015, 12, 1);

            DateTime startTime = exampleDate.Add(new TimeSpan(8, 0, 0));
            DateTime endTime = exampleDate.Add(new TimeSpan(17, 0, 0));

            List<TimeSpan> times = new List<TimeSpan>();

            for (DateTime time = startTime; time < endTime; time = time.AddMinutes(30))
            {
                times.Add(time.TimeOfDay);
            }

            return times;
        }

        public List<DateTime> GetFreeTimes(DateTime search, string doctorName)
        {
            Doctor doctor = SearchDoctors(doctorName);
            Trace.WriteLine(doctor.contactInformation.Name);
            List<DateTime> output = new List<DateTime>();
            List<TimeSpan> remainingTimes = initialTimeIntervals;
            foreach (Appointment appointment in doctor.calendar)
            {
                DateTime date = appointment.Time.Date;
                if (date == search)
                {
                    remainingTimes.Remove(appointment.Time.TimeOfDay);
                }
            }

            foreach (TimeSpan time in remainingTimes)
            {
                output.Add(search.Add(time));
            }

            return output;
        }

        public void ReceiveAppointment(Patient patient)
        {
            Doctor doctor = patient.preferredDoctor;
            DateTime requestedTime = patient.preferredDate.Add(patient.preferredTime);

            if (CheckInsurance(patient.insurance))
            {
                if (CheckScheduleConflictions(requestedTime, doctor))
                {
                    throw new CustomExceptions.AppointmentException("Doctor has a conflicting appointemnt.");
                }
            } else
            {
                throw new CustomExceptions.AppointmentException("Patient does not have insurance.");
            }

            AddAppointmentToCalendar(patient, doctor);
            WriteAppointmentToDatafile(patient, doctor);
        }

        public void AddAppointmentToCalendar(Patient patient, Doctor doctor)
        {
            SingleSchedule newScheduleItem = new SingleSchedule
            {
                Name = String.Format("Appointment for {0} with Dr. {1}", patient.contactInformation.Name, doctor.contactInformation.Name),
                TimeOfDay = patient.preferredTime,
                Date = patient.preferredDate,
                Patient = patient.contactInformation.Name,
                Doctor = doctor.contactInformation.Name,
                ID = GetAppointmentNumber()
            };

            doctor.schedules.Add(newScheduleItem);
            doctor.GenerateCalendar();
            doctor.updateCalendar();
        }

        public void WriteAppointmentToDatafile(Patient patient, Doctor doctor)
        {
            Data patientData = BuildDataObject(patient, doctor);
            string fileText = File.ReadAllText(fileWriter.path);
            if (fileText.Length == 0)
            {
                List<Data> dataEntries = new List<Data>() { patientData };
                fileWriter.WriteAllText(dataEntries);
            } else if (!fileWriter.RecordExists(patient.contactInformation.Name))
            {
                List<Data> dataFile = fileWriter.GetAllData();
                dataFile.Add(patientData);
                fileWriter.WriteAllText(dataFile);
            } else
            {
                List<Data> existingData = fileWriter.GetAllData();
                foreach (Data patientObject in existingData)
                {
                    if (patientObject.name == patient.contactInformation.Name)
                    {
                        patientObject.appointment = patientData.appointment;
                    }
                }
                fileWriter.WriteAllText(existingData);
            }
        }

        public Data BuildDataObject(Patient patient, Doctor doctor)
        {
            Appointment apt = doctor.getAppointmentByPatient(patient.contactInformation.Name);
            return new Data(patient.contactInformation.Name, doctor.contactInformation.Name, apt, patient.insurance);
        }

        public int GetAppointmentNumber()
        {
            int returnNumer = appointmentNumber + 1;
            appointmentNumber += 1;
            return returnNumer;
        }

        public bool CheckScheduleConflictions(DateTime requestedTime, Doctor doctor)
        {
            if (doctor.calendar.Count() != 0)
            {
                foreach (Appointment appointment in doctor.calendar)
                {
                    if (requestedTime == appointment.Time)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CheckInsurance(Insurance insurance)
        {
            if (insurance.id != null)
            {
                return true;
            }
            return false;
        }
    }
}