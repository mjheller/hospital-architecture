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
        public string name;
        public int age;
        protected CalendarGenerator generator = new CalendarGenerator();
        public List<Appointment> calendar = new List<Appointment>();
        public List<Schedule> schedules = new List<Schedule>();

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
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
            Period period = new Period(new DateTime(2015, 1, 1), new DateTime(2015, 12, 31));
            calendar = generator.GenerateCalendar(period, schedules);
        }

        public Appointment getAppointmentByID(int id)
        {
            return calendar.Find(item => item.ID == id);
        }

    }
}
