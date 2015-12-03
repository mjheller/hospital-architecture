using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Insurance
    {
        public string id;
        public string groupId;
        public string type;
        public string provider;

        public Insurance()
        {

        }

        public Insurance(string id, string groupId, string type, string provider)
        {
            this.id = id;
            this.groupId = groupId;
            this.type = type;
            this.provider = provider;
        }
    }
}
