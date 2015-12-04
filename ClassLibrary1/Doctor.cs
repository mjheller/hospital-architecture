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
        public List<TimeSpan> initialTimeIntervals;
        public CalendarFileWriter scheduleWriter;

        public Doctor(ContactInformation contactInformation) : base(contactInformation)
        {
            this.scheduleWriter = new CalendarFileWriter(contactInformation.FirstName + "_" + contactInformation.LastName);
            this.calendar = scheduleWriter.GetCurrentCalendar();
        }

        public override string ToString()
        {
            return base.contactInformation.Name;
        }

        public Appointment getAppointmentByPatient(string name)
        {
            return calendar.Find(item => item.Patient == name);
        }

        public void updateCalendar()
        {
            scheduleWriter.WriteSchedule(calendar);
        }
    }
}