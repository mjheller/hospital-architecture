using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class WaitingRoom
    {
        public List<Patient> patients;

        public WaitingRoom()
        {

        }

        public WaitingRoom(List<Patient> waitingPatients)
        {
            this.patients = waitingPatients;
        }

    }
}
