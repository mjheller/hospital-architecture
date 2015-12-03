namespace WinForm
{
    partial class MedicalWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalWizard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MWizardLabel = new System.Windows.Forms.Label();
            this.MwInfoLabel = new System.Windows.Forms.Label();
            this.ScheduleAppointment = new System.Windows.Forms.Button();
            this.ChangeAppointment = new System.Windows.Forms.Button();
            this.ChangeDoctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MWizardLabel
            // 
            this.MWizardLabel.AutoSize = true;
            this.MWizardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MWizardLabel.Location = new System.Drawing.Point(132, 27);
            this.MWizardLabel.Name = "MWizardLabel";
            this.MWizardLabel.Size = new System.Drawing.Size(244, 29);
            this.MWizardLabel.TabIndex = 1;
            this.MWizardLabel.Text = "Medical Clinic Wizard";
            // 
            // MwInfoLabel
            // 
            this.MwInfoLabel.AutoSize = true;
            this.MwInfoLabel.Location = new System.Drawing.Point(164, 60);
            this.MwInfoLabel.Name = "MwInfoLabel";
            this.MwInfoLabel.Size = new System.Drawing.Size(175, 13);
            this.MwInfoLabel.TabIndex = 2;
            this.MwInfoLabel.Text = "Welcome. Choose an option below.";
            // 
            // ScheduleAppointment
            // 
            this.ScheduleAppointment.Location = new System.Drawing.Point(82, 131);
            this.ScheduleAppointment.Name = "ScheduleAppointment";
            this.ScheduleAppointment.Size = new System.Drawing.Size(239, 29);
            this.ScheduleAppointment.TabIndex = 3;
            this.ScheduleAppointment.Text = "Schedule Appointment";
            this.ScheduleAppointment.UseVisualStyleBackColor = true;
            this.ScheduleAppointment.Click += new System.EventHandler(this.ScheduleAppointment_Click);
            // 
            // ChangeAppointment
            // 
            this.ChangeAppointment.Location = new System.Drawing.Point(82, 166);
            this.ChangeAppointment.Name = "ChangeAppointment";
            this.ChangeAppointment.Size = new System.Drawing.Size(239, 29);
            this.ChangeAppointment.TabIndex = 4;
            this.ChangeAppointment.Text = "Change Appointment";
            this.ChangeAppointment.UseVisualStyleBackColor = true;
            // 
            // ChangeDoctor
            // 
            this.ChangeDoctor.Location = new System.Drawing.Point(82, 201);
            this.ChangeDoctor.Name = "ChangeDoctor";
            this.ChangeDoctor.Size = new System.Drawing.Size(239, 29);
            this.ChangeDoctor.TabIndex = 5;
            this.ChangeDoctor.Text = "Change Doctor";
            this.ChangeDoctor.UseVisualStyleBackColor = true;
            // 
            // MedicalWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 257);
            this.Controls.Add(this.ChangeDoctor);
            this.Controls.Add(this.ChangeAppointment);
            this.Controls.Add(this.ScheduleAppointment);
            this.Controls.Add(this.MwInfoLabel);
            this.Controls.Add(this.MWizardLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MedicalWizard";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MWizardLabel;
        private System.Windows.Forms.Label MwInfoLabel;
        private System.Windows.Forms.Button ScheduleAppointment;
        private System.Windows.Forms.Button ChangeAppointment;
        private System.Windows.Forms.Button ChangeDoctor;
    }
}

