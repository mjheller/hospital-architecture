using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Scheduler;
using System.Diagnostics;

namespace Hospital
{
    public class DoctorsOffice
    {
        public List<Doctor> doctors;
        //public List<Doctor> Doctors{ get { return doctors; } }
        public List<TimeSpan> initialTimeIntervals;
        //public WaitingRoom waitingRoom;
        public static int appointmentNumber = 0;
        public FileWriter fileWriter = new FileWriter();

        public DoctorsOffice(List<Doctor> doctors)
        {
            this.doctors = doctors;
            this.initialTimeIntervals = GetInitialTimeIntervals();
            //this.waitingRoom = new WaitingRoom();
        }

        public Doctor SearchDoctors(string name)
        {
            return doctors.Find(item => item.name == name);
        }

        public List<TimeSpan> GetInitialTimeIntervals()
        {
            DateTime exampleDate = new DateTime(2015, 12, 1);

            DateTime startTime = exampleDate.Add(new TimeSpan(8, 0, 0));
            DateTime endTime = exampleDate.Add(new TimeSpan(17, 0, 0));

            List<TimeSpan> times = new List<TimeSpan>();

            for (DateTime time = startTime; time < endTime; time = time.AddMinutes(30))
            {
                Trace.Write(time);
                times.Add(time.TimeOfDay);
            }

            return times;
        }

        public List<DateTime> GetFreeTimes(DateTime search, string doctorName)
        {
            Doctor doctor = SearchDoctors(doctorName);
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
                    throw new CustomExceptions.AppointmentException();
                }
            } else
            {
                throw new CustomExceptions.AppointmentException("Patient does not have insurance.");
            }
            AddAppointmentToCalendar(patient, doctor);
            WriteAppointmentToDatafile(patient, doctor);
        }

        public void WriteAppointmentToDatafile(Patient patient, Doctor doctor)
        {
            Data patientData = BuildDataObject(patient, doctor);
            string fileText = File.ReadAllText(fileWriter.path);
            if (fileText.Length == 0)
            {
                List<Data> dataEntries = new List<Data>() { patientData };
                fileWriter.WriteAllText(dataEntries);
            } else if (!fileWriter.RecordExists(patient.name))
            {
                List<Data> dataFile = fileWriter.GetAllData();
                dataFile.Add(patientData);
                fileWriter.WriteAllText(dataFile);
            } else
            {
                List<Data> existingData = fileWriter.GetAllData();
                foreach (Data patientObject in existingData)
                {
                    if (patientObject.name == patient.name)
                    {
                        patientObject.appointment = patientData.appointment;
                    }
                }
                fileWriter.WriteAllText(existingData);
            }
        }

        public void AddAppointmentToCalendar(Patient patient, Doctor doctor)
        {
            SingleSchedule newScheduleItem = new SingleSchedule
            {
                Name = String.Format("Appointment for {0} with Dr. {1}", patient.name, doctor.name),
                TimeOfDay = patient.preferredTime,
                Date = patient.preferredDate,
                Patient = patient.name,
                Doctor = doctor.name,
                ID = GetAppointmentNumber()
            };

            doctor.schedules.Add(newScheduleItem);
            doctor.GenerateCalendar();

            patient.schedules.Add(newScheduleItem);
            patient.GenerateCalendar();
        }

        public Data BuildDataObject(Patient patient, Doctor doctor)
        {
            Appointment apt = doctor.getAppointmentByPatient(patient.name);
            return new Data(patient.name, doctor.name, apt, patient.insurance);
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