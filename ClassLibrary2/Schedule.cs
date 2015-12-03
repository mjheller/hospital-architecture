using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public abstract class Schedule
    {
        public TimeSpan TimeOfDay { get; set; }
        public string Name { get; set; }
        public string Patient { get; set; }
        public string Doctor { get; set; }
        public int ID { get; set; }

        public abstract bool OccursOnDate(DateTime date);
    }
}
