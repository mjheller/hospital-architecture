using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scheduler;

namespace Hospital
{
    public abstract class Person
    {
        public ContactInformation contactInformation;
        protected CalendarGenerator generator;
        public List<Appointment> calendar;
        public List<Schedule> schedules;

        public Person(ContactInformation contactInformation)
        {
            this.contactInformation = contactInformation;
            this.generator = new CalendarGenerator();
            this.calendar = new List<Appointment>();
            this.schedules = new List<Schedule>();
        }

        public void CreateNewSingleSchedule(string Name, TimeSpan TimeOfDay, DateTime Date)
        {
            SingleSchedule scheduleToAdd = new SingleSchedule
            {
                Name = Name,
                TimeOfDay = TimeOfDay,
                Date = Date
            };

            schedules.Add(scheduleToAdd);
        }

        public void GenerateCalendar()
        {
            Period period = new Period(new DateTime(2015, 1, 1), new DateTime(2016, 12, 31));
            calendar = generator.GenerateCalendar(period, schedules);
        }

        public Appointment GetAppointmentByID(int id)
        {
            return calendar.Find(item => item.ID == id);
        }

    }
}