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

        //List<Doctor> doctors;
        List<Symptom> symptomList;
        DoctorsOffice doctorsOffice;
        //Doctor preferredDoc;
        public PatientInfo()
        {

            InitializeComponent();
            Doctor Phil = new Doctor("Phil MD", 40);
            Doctor Oz = new Doctor("Oz MD", 60);
            Doctor Jennifer = new Doctor("Jennifer MD", 35);
            Doctor Benjamin = new Doctor("Benjamin MD", 50);
            Doctor Dave = new Doctor("Dave MD", 30);
            Doctor Andrew = new Doctor("Andrew MD", 40);
            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(Phil); doctors.Add(Oz); doctors.Add(Jennifer); doctors.Add(Benjamin); doctors.Add(Dave);  doctors.Add(Andrew);
            this.doctorsOffice = new DoctorsOffice(doctors);
            this.drListBox.DataSource = doctorsOffice.doctors;
            this.symptomList = new List<Symptom>{ };

        }
        private void label1_Click(object sender, EventArgs e){}
        private void label1_Click_1(object sender, EventArgs e){}

        private void nextButton_Click(object sender, EventArgs e)
        {
            string firstName = FNametextBox.Text;
            string lastName = LNametextBox.Text;
            int age = Convert.ToInt32(ageUpDown.Value);
            string provider = insuranceListBox.Text;
            string docName = drListBox.Text;
            Symptom symptom = new Symptom(symptomsComboBox.SelectedItem.ToString());
            DateTime appointmentDate = dateTimePicker.Value;
            object appointmentTime = availableTimesList.SelectedItem;
            Doctor preferredDoc = this.doctorsOffice.SearchDoctors(docName);
            

            /* if (firstName == null || lastName == null)
             {
                 MessageBox.Show("Cannot proceed, please enter all the required information");
             }*/


            Patient New = new Patient(firstName + " " + lastName, age, symptom, new Insurance(provider), preferredDoc);
            //changed symptom List into single symptom for debugging
            /*foreach (Doctor doc in doctorsOffice.doctors)
            {
                if (doc.name == docName)
                {
                    Patient New = new Patient(firstName + " " + lastName, age, symptom, new Insurance(provider), doc);
                }
            }
            */
            MessageBox.Show("Success!!");
        }

        private void availableTimesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox dr = (ListBox)sender;
            //send to availableTimesList to display the times for that doctor on the specific Date
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateItem = (DateTimePicker)sender;
            string date = dateItem.Text;

        }

        private void symptomsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}

