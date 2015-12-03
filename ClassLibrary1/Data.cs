using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital;
using Scheduler;

namespace Hospital
{
    [Serializable()]
    public class Data
    {
        public string name;
        public string doctor;
        public Appointment appointment;
        public Insurance insurance;

        public Data()
        {

        }

        public Data(string patientName, string patientDoctor, Appointment appointment, Insurance insure)
        {
            this.name = patientName;
            this.doctor = patientDoctor;
            this.appointment = appointment;
            this.insurance = insure;
        }

        public void updateFields()
        {
            throw new NotImplementedException();
        }
    }
}
