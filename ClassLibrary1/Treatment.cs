using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Treatment
    {
        public string icd10;
        public string name;

        public Treatment()
        {

        }

        public Treatment(string icd10, string name)
        {
            this.icd10 = icd10;
            this.name = name;
        }
    }
}
