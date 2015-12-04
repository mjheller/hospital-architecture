using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Scheduler;

namespace Hospital
{
    public class CalendarFileWriter
    {
        public string path;
        public string fileName;
        JsonSerializer serializer = new JsonSerializer();

        public CalendarFileWriter(string doctorName)
        {
            this.fileName = String.Format(@"{0}.json", doctorName);
            this.path = Path.Combine(Environment.CurrentDirectory, fileName);
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
        }

        public void WriteSchedule(List<Appointment> appointments)
        {
            string input = JsonConvert.SerializeObject(appointments, Formatting.Indented);
            File.WriteAllText(path, input);
        }

        public List<Appointment> GetCurrentCalendar()
        {
            string json = File.ReadAllText(fileName);
            if (json.Length == 0)
            {
                return new List<Appointment>();
            } else
            {
                return JsonConvert.DeserializeObject<List<Appointment>>(json);
            }
        }

     
    }
}