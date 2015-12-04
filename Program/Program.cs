using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scheduler;
using Hospital;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>();

            Doctor Phil = new Doctor("Phil", 40);

            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(Phil);

            //Patient Bob = new Patient("Bob", 32, new List<Symptom>() { new Symptom("Explosive diarrhea") }, new Insurance("X3564354", "1234678", "Good Insurance", "Blue Cross/Blue Shield"), Phil);

            //Patient Jane = new Patient("Jane", 45, new List<Symptom>() { new Symptom("Spontaneous combustion") }, new Insurance("T3243DSE", "46833693", "Bad Insurance", "Insurance That Dan Provided"), Phil);

            //patients.Add(Bob);
            //patients.Add(Jane);

            DoctorsOffice doctorsOffice = new DoctorsOffice(doctors);

            foreach (Patient patient in patients)
            {
                doctorsOffice.ReceiveAppointment(patient);
            }

            Appointment apt = Phil.getAppointmentByID(1);

            Console.WriteLine(apt.Name);
            Console.WriteLine(apt.Patient);
            Console.WriteLine(apt.Doctor);
            Console.WriteLine(apt.ID);
            Console.WriteLine(apt.Time.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}