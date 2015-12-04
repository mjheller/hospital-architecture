using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Hospital;

namespace WinForm
{
    public partial class PatientInfo : Form
    {

        
        List<Symptom> symptomList;
        DoctorsOffice doctorsOffice;
        DateTime date;
        
        public PatientInfo()
        {
            InitializeComponent();
            Doctor Phil = new Doctor(new ContactInformation { FirstName = "Phil", LastName = "Steele" });
            Doctor Jane = new Doctor(new ContactInformation { FirstName = "Jane", LastName = "Alexander" });
            Doctor Barry = new Doctor(new ContactInformation { FirstName = "Barry", LastName = "Hall" });
            Doctor Jennifer = new Doctor(new ContactInformation { FirstName = "Jennifer", LastName = "Dock" });
            Doctor Benjamin = new Doctor(new ContactInformation { FirstName = "Benjamin", LastName = "Franklyn" });
            Doctor Luv = new Doctor(new ContactInformation { FirstName = "Luv", LastName = "DocTa" });
            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(Phil); doctors.Add(Jane); doctors.Add(Barry); doctors.Add(Jennifer); doctors.Add(Benjamin);  doctors.Add(Luv);
            this.doctorsOffice = new DoctorsOffice(doctors);
            this.date = DateTime.Now.Date;
            
            //this.drListBox.SelectedIndexChanged -= this.drListBox_SelectedIndexChanged;
            this.drListBox.DataSource = doctorsOffice.doctors;
            //this.drListBox.SelectedIndex = -1; //Keeps item from automatically being selected on bootup
                  
            this.symptomList = new List<Symptom>{ };

        }
        private void label1_Click(object sender, EventArgs e){}
        private void label1_Click_1(object sender, EventArgs e){}

        private void nextButton_Click(object sender, EventArgs e)
        {
            //try:
            string firstName = FNametextBox.Text;
            string lastName = LNametextBox.Text;
            int age = Convert.ToInt32(ageUpDown.Value);
            string insuranceProvider = InsuranceComboBox.Text;
            string insuranceID = insuranceIDTextBox.Text;
            string docName = drListBox.Text;
            Symptom symptom = new Symptom(symptomsComboBox.SelectedItem.ToString());
            DateTime appointmentDate = dateTimePicker.Value;
            DateTime appointmentdateTime = Convert.ToDateTime(availableTimesList.Text);
            TimeSpan appointmentTime = appointmentdateTime.TimeOfDay;
            Doctor preferredDoc = this.doctorsOffice.SearchDoctors(docName);

            // while (firstName == "" || lastName == "" || appointmentTime == null)
            //    {
            //   MessageBox.Show("Cannot proceed, please enter all the required information");
            //  }
            ContactInformation contactInformation = new ContactInformation()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age
                // Gender = haventBindedYet
            };

            Patient user = new Patient(contactInformation, symptom, new Insurance(insuranceProvider,insuranceID), preferredDoc,appointmentDate,appointmentTime);
            //Need to now read from file for available times to make sure that taken appointment times do not show 
            doctorsOffice.ReceiveAppointment(user);


            MessageBox.Show("Success!!");
        }

        private void availableTimesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox dr = (ListBox)sender;
            List<DateTime> freeTimes = doctorsOffice.GetFreeTimes(this.date, dr.Text);
            availableTimesList.DataSource = freeTimes;
            //MessageBox.Show(dateTimePicker.Text);
            //send to availableTimesList to display the times for that doctor on the specific Date
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(dateTimePicker.Text);
            this.date = date;
            List<DateTime> freeTimes = doctorsOffice.GetFreeTimes(this.date, drListBox.Text);
            availableTimesList.DataSource = freeTimes;

        }

        private void symptomsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            
            //PatientInfo.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

