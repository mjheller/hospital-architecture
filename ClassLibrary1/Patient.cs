using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Patient : Person
    {
        public Symptom symptom;
        public Insurance insurance;
        public Doctor preferredDoctor;
        public DateTime preferredDate;
        public TimeSpan preferredTime;

        public Patient(ContactInformation contactInformation, Symptom symptom, Insurance insurance, Doctor preferredDoctor, DateTime preferredDate, TimeSpan preferredTime) : base(contactInformation)
        {
            this.symptom = symptom;
            this.insurance = insurance;
            this.preferredDoctor = preferredDoctor;
            this.preferredDate = preferredDate;
            this.preferredTime = preferredTime;
        }
    }
}