using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Symptom
    {
        string description;       
        string severity;

        public Symptom(string description)
        {
            this.description = description;
        }

        public Symptom(string description, string severity)
        {
            this.description = description;
            this.severity = severity;
        }
    }
}
