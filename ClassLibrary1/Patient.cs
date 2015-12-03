using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Patient : Person
    {
        public List<Symptom> symptoms;
        public Insurance insurance;
        public bool covered;
        public Doctor preferredDoctor;
        public DateTime preferredDate;
        public TimeSpan preferredTime;
        public Random random;

        public Patient(string name, int age, List<Symptom> symptoms, Insurance insurance, Doctor preferredDoctor) : base(name, age)
        {
            this.symptoms = symptoms;
            this.insurance = insurance;
            this.preferredDoctor = preferredDoctor;
            this.random = new Random(DateTime.Now.Millisecond);
            this.preferredDate = generateRandomDate();
            this.preferredTime = generateRandomTime();
        }

        #region Date Time Generators
        private DateTime generateRandomDate()
        {
            int year = 2015;
            int month = 12;
            int day = random.Next(1, 31);

            return new DateTime(year, month, day);
        }

        private TimeSpan generateRandomTime()
        {
            int hour = random.Next(8, 17);
            int halfHour;
            int halfHourRandom = random.Next(0, 1);
            if (halfHourRandom == 0)
            {
                halfHour = 0;
            } else
            {
                halfHour = 30;
            }
            return new TimeSpan(hour, halfHour, 0);
        }
        #endregion

    }
}
