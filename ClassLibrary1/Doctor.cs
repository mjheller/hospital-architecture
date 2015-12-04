using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scheduler;

namespace Hospital
{

    public class Doctor : Person
    {

        public Doctor(string name, int age) : base(name, age)
        {

        }
        public override string ToString()
        {
            return base.name;//.ToString();
        }

        public Appointment getAppointmentByPatient(string name)
        {
            return calendar.Find(item => item.Patient == name);
        }

    }
}

