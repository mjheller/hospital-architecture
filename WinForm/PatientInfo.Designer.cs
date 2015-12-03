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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FNametextBox = new System.Windows.Forms.TextBox();
            this.LNametextBox = new System.Windows.Forms.TextBox();
            this.InsuranceListBox = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.setApptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.MWizardLabel.AutoSize = true;
            this.MWizardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MWizardLabel.Location = new System.Drawing.Point(168, 23);
            this.MWizardLabel.Name = "MWizardLabel";
            this.MWizardLabel.Size = new System.Drawing.Size(244, 29);
            this.MWizardLabel.TabIndex = 2;
            this.MWizardLabel.Text = "Medical Clinic Wizard";
            // 
            // PatientInfoLabel
            // 
            this.PatientInfoLabel.AutoSize = true;
            this.PatientInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientInfoLabel.Location = new System.Drawing.Point(191, 64);
            this.PatientInfoLabel.Name = "PatientInfoLabel";
            this.PatientInfoLabel.Size = new System.Drawing.Size(191, 25);
            this.PatientInfoLabel.TabIndex = 3;
            this.PatientInfoLabel.Text = "Patient Information";
            this.PatientInfoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(111, 127);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(90, 20);
            this.FNameLabel.TabIndex = 4;
            this.FNameLabel.Text = "First Name:";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(111, 156);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(90, 20);
            this.LNameLabel.TabIndex = 5;
            this.LNameLabel.Text = "Last Name:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(216, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 43);
            this.listBox1.TabIndex = 6;
            // 
            // FNametextBox
            // 
            this.FNametextBox.Location = new System.Drawing.Point(216, 127);
            this.FNametextBox.Name = "FNametextBox";
            this.FNametextBox.Size = new System.Drawing.Size(200, 20);
            this.FNametextBox.TabIndex = 7;
            // 
            // LNametextBox
            // 
            this.LNametextBox.Location = new System.Drawing.Point(216, 156);
            this.LNametextBox.Name = "LNametextBox";
            this.LNametextBox.Size = new System.Drawing.Size(200, 20);
            this.LNametextBox.TabIndex = 8;
            // 
            // InsuranceListBox
            // 
            this.InsuranceListBox.AutoSize = true;
            this.InsuranceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceListBox.Location = new System.Drawing.Point(66, 186);
            this.InsuranceListBox.Name = "InsuranceListBox";
            this.InsuranceListBox.Size = new System.Drawing.Size(135, 20);
            this.InsuranceListBox.TabIndex = 9;
            this.InsuranceListBox.Text = "Insurance Carrier:";
            this.InsuranceListBox.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(102, 282);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 23);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(245, 282);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(137, 23);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // setApptLabel
            // 
            this.setApptLabel.AutoSize = true;
            this.setApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setApptLabel.Location = new System.Drawing.Point(66, 236);
            this.setApptLabel.Name = "setApptLabel";
            this.setApptLabel.Size = new System.Drawing.Size(133, 20);
            this.setApptLabel.TabIndex = 13;
            this.setApptLabel.Text = "Set Appointment:";
            // 
            // PatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 329);
            this.Controls.Add(this.setApptLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.InsuranceListBox);
            this.Controls.Add(this.LNametextBox);
            this.Controls.Add(this.FNametextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.PatientInfoLabel);
            this.Controls.Add(this.MWizardLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PatientInfo";
            this.Text = "PatientInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MWizardLabel;
        private System.Windows.Forms.Label PatientInfoLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox FNametextBox;
        private System.Windows.Forms.TextBox LNametextBox;
        private System.Windows.Forms.Label InsuranceListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label setApptLabel;
    }
}