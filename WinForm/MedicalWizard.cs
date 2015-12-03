using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class MedicalWizard : Form
    {
        public MedicalWizard()
        {
            InitializeComponent();
        }

        private void ScheduleAppointment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing 123");
        }
    }
}
