using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.CustomExceptions
{
    public class AppointmentException : Exception
    {
        public AppointmentException() { }
        public AppointmentException(string message) { }
        public AppointmentException(string message, Exception innerException) { }
    }
}
