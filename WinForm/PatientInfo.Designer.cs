namespace WinForm
{
    partial class PatientInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MWizardLabel = new System.Windows.Forms.Label();
            this.PatientInfoLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.insuranceListBox = new System.Windows.Forms.ListBox();
            this.FNametextBox = new System.Windows.Forms.TextBox();
            this.LNametextBox = new System.Windows.Forms.TextBox();
            this.InsuranceListBoxLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.setApptLabel = new System.Windows.Forms.Label();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.availableTimesList = new System.Windows.Forms.ListBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.chooseDocLabel = new System.Windows.Forms.Label();
            this.drListBox = new System.Windows.Forms.ListBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.patientInfoSublabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageUpDown = new System.Windows.Forms.NumericUpDown();
            this.symptomsLabel = new System.Windows.Forms.Label();
            this.symptomsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 102);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MWizardLabel
            // 
            this.MWizardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MWizardLabel.Location = new System.Drawing.Point(538, 9);
            this.MWizardLabel.Name = "MWizardLabel";
            this.MWizardLabel.Size = new System.Drawing.Size(244, 29);
            this.MWizardLabel.TabIndex = 2;
            this.MWizardLabel.Text = "Medical Clinic Wizard";
            // 
            // PatientInfoLabel
            // 
            this.PatientInfoLabel.AutoSize = true;
            this.PatientInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientInfoLabel.Location = new System.Drawing.Point(299, 50);
            this.PatientInfoLabel.Name = "PatientInfoLabel";
            this.PatientInfoLabel.Size = new System.Drawing.Size(242, 31);
            this.PatientInfoLabel.TabIndex = 3;
            this.PatientInfoLabel.Text = "Patient Information";
            this.PatientInfoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(92, 159);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(90, 20);
            this.FNameLabel.TabIndex = 4;
            this.FNameLabel.Text = "First Name:";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(92, 188);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(90, 20);
            this.LNameLabel.TabIndex = 5;
            this.LNameLabel.Text = "Last Name:";
            // 
            // insuranceListBox
            // 
            this.insuranceListBox.FormattingEnabled = true;
            this.insuranceListBox.Items.AddRange(new object[] {
            "Select No Insurance",
            "Aetna Group",
            "Assurant Health",
            "BlueCross BlueShield",
            "DanCare",
            "Humana",
            "IHC Group",
            "Kaiser Permanente",
            "ObamaCare",
            "TrumpCare",
            "UnitedHealthOne"});
            this.insuranceListBox.Location = new System.Drawing.Point(197, 250);
            this.insuranceListBox.Name = "insuranceListBox";
            this.insuranceListBox.Size = new System.Drawing.Size(200, 43);
            this.insuranceListBox.TabIndex = 6;
            // 
            // FNametextBox
            // 
            this.FNametextBox.Location = new System.Drawing.Point(197, 160);
            this.FNametextBox.Name = "FNametextBox";
            this.FNametextBox.Size = new System.Drawing.Size(200, 20);
            this.FNametextBox.TabIndex = 7;
            // 
            // LNametextBox
            // 
            this.LNametextBox.Location = new System.Drawing.Point(197, 190);
            this.LNametextBox.Name = "LNametextBox";
            this.LNametextBox.Size = new System.Drawing.Size(200, 20);
            this.LNametextBox.TabIndex = 8;
            // 
            // InsuranceListBoxLabel
            // 
            this.InsuranceListBoxLabel.AutoSize = true;
            this.InsuranceListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceListBoxLabel.Location = new System.Drawing.Point(47, 250);
            this.InsuranceListBoxLabel.Name = "InsuranceListBoxLabel";
            this.InsuranceListBoxLabel.Size = new System.Drawing.Size(135, 20);
            this.InsuranceListBoxLabel.TabIndex = 9;
            this.InsuranceListBoxLabel.Text = "Insurance Carrier:";
            this.InsuranceListBoxLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy ";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(553, 181);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(441, 372);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 23);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(598, 372);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(137, 23);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Schedule";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // setApptLabel
            // 
            this.setApptLabel.AutoSize = true;
            this.setApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setApptLabel.Location = new System.Drawing.Point(414, 161);
            this.setApptLabel.Name = "setApptLabel";
            this.setApptLabel.Size = new System.Drawing.Size(133, 20);
            this.setApptLabel.TabIndex = 13;
            this.setApptLabel.Text = "Set Appointment:";
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Location = new System.Drawing.Point(209, 133);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(48, 17);
            this.MaleRadio.TabIndex = 14;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "Male";
            this.MaleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(263, 133);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 15;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // availableTimesList
            // 
            this.availableTimesList.FormattingEnabled = true;
            this.availableTimesList.Location = new System.Drawing.Point(553, 209);
            this.availableTimesList.Name = "availableTimesList";
            this.availableTimesList.ScrollAlwaysVisible = true;
            this.availableTimesList.Size = new System.Drawing.Size(200, 147);
            this.availableTimesList.TabIndex = 16;
            this.availableTimesList.SelectedIndexChanged += new System.EventHandler(this.availableTimesList_SelectedIndexChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(507, 181);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(40, 16);
            this.dateLabel.TabIndex = 17;
            this.dateLabel.Text = "Date:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(438, 209);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(109, 16);
            this.timeLabel.TabIndex = 18;
            this.timeLabel.Text = "Available Times:";
            // 
            // chooseDocLabel
            // 
            this.chooseDocLabel.AutoSize = true;
            this.chooseDocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDocLabel.Location = new System.Drawing.Point(60, 301);
            this.chooseDocLabel.Name = "chooseDocLabel";
            this.chooseDocLabel.Size = new System.Drawing.Size(120, 20);
            this.chooseDocLabel.TabIndex = 19;
            this.chooseDocLabel.Text = "Choose Doctor:";
            // 
            // drListBox
            // 
            this.drListBox.FormattingEnabled = true;
            this.drListBox.Location = new System.Drawing.Point(197, 301);
            this.drListBox.Name = "drListBox";
            this.drListBox.Size = new System.Drawing.Size(200, 56);
            this.drListBox.TabIndex = 20;
            this.drListBox.SelectedIndexChanged += new System.EventHandler(this.drListBox_SelectedIndexChanged);
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.Location = new System.Drawing.Point(141, 129);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(40, 20);
            this.sexLabel.TabIndex = 21;
            this.sexLabel.Text = "Sex:";
            // 
            // patientInfoSublabel
            // 
            this.patientInfoSublabel.AutoSize = true;
            this.patientInfoSublabel.Location = new System.Drawing.Point(329, 81);
            this.patientInfoSublabel.Name = "patientInfoSublabel";
            this.patientInfoSublabel.Size = new System.Drawing.Size(176, 13);
            this.patientInfoSublabel.TabIndex = 22;
            this.patientInfoSublabel.Text = "Enter the required information below";
            this.patientInfoSublabel.CursorChanged += new System.EventHandler(this.nextButton_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(138, 218);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(42, 20);
            this.ageLabel.TabIndex = 23;
            this.ageLabel.Text = "Age:";
            // 
            // ageUpDown
            // 
            this.ageUpDown.Location = new System.Drawing.Point(197, 219);
            this.ageUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ageUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(120, 20);
            this.ageUpDown.TabIndex = 24;
            this.ageUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // symptomsLabel
            // 
            this.symptomsLabel.AutoSize = true;
            this.symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsLabel.Location = new System.Drawing.Point(459, 133);
            this.symptomsLabel.Name = "symptomsLabel";
            this.symptomsLabel.Size = new System.Drawing.Size(88, 20);
            this.symptomsLabel.TabIndex = 25;
            this.symptomsLabel.Text = "Symptoms:";
            // 
            // symptomsComboBox
            // 
            this.symptomsComboBox.FormattingEnabled = true;
            this.symptomsComboBox.Items.AddRange(new object[] {
            "No Symptoms - Checkup",
            "Bronchitis",
            "Common Cold",
            "Death-Like Symptoms",
            "Explosive Diahrea",
            "Flu-Like Symptoms",
            "Overdose",
            "Rash",
            "Vomiting",
            ""});
            this.symptomsComboBox.Location = new System.Drawing.Point(553, 136);
            this.symptomsComboBox.Name = "symptomsComboBox";
            this.symptomsComboBox.Size = new System.Drawing.Size(200, 21);
            this.symptomsComboBox.TabIndex = 26;
            this.symptomsComboBox.SelectedIndexChanged += new System.EventHandler(this.symptomsComboBox_SelectedIndexChanged);
            // 
            // PatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 405);
            this.Controls.Add(this.symptomsComboBox);
            this.Controls.Add(this.symptomsLabel);
            this.Controls.Add(this.ageUpDown);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.patientInfoSublabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.drListBox);
            this.Controls.Add(this.chooseDocLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.availableTimesList);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.MaleRadio);
            this.Controls.Add(this.setApptLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.InsuranceListBoxLabel);
            this.Controls.Add(this.LNametextBox);
            this.Controls.Add(this.FNametextBox);
            this.Controls.Add(this.insuranceListBox);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.PatientInfoLabel);
            this.Controls.Add(this.MWizardLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PatientInfo";
            this.Text = "PatientInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MWizardLabel;
        private System.Windows.Forms.Label PatientInfoLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.ListBox insuranceListBox;
        private System.Windows.Forms.TextBox FNametextBox;
        private System.Windows.Forms.TextBox LNametextBox;
        private System.Windows.Forms.Label InsuranceListBoxLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label setApptLabel;
        private System.Windows.Forms.RadioButton MaleRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.ListBox availableTimesList;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label chooseDocLabel;
        private System.Windows.Forms.ListBox drListBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label patientInfoSublabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown ageUpDown;
        private System.Windows.Forms.Label symptomsLabel;
        private System.Windows.Forms.ComboBox symptomsComboBox;
    }
}