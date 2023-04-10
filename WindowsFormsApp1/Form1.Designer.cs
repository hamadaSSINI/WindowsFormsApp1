namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_slide = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.panel_Diagnosisubmenu = new System.Windows.Forms.Panel();
            this.button_printDiagnose = new System.Windows.Forms.Button();
            this.button_manageDiagnose = new System.Windows.Forms.Button();
            this.button_newDiagnose = new System.Windows.Forms.Button();
            this.button_Diagnosis = new System.Windows.Forms.Button();
            this.panel_Doctorsubmenu = new System.Windows.Forms.Panel();
            this.button_PrintDoctors = new System.Windows.Forms.Button();
            this.button_manageDoctors = new System.Windows.Forms.Button();
            this.button_NewDoctors = new System.Windows.Forms.Button();
            this.button_Doctors = new System.Windows.Forms.Button();
            this.panel_patientsubmenu = new System.Windows.Forms.Panel();
            this.button_Printpatient = new System.Windows.Forms.Button();
            this.button_managePatient = new System.Windows.Forms.Button();
            this.button_Registration = new System.Windows.Forms.Button();
            this.button_patients = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label_cfemale = new System.Windows.Forms.Label();
            this.label_cmale = new System.Windows.Forms.Label();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.label_femalepatients = new System.Windows.Forms.Label();
            this.label_malepatients = new System.Windows.Forms.Label();
            this.label_totalpatients = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_slide.SuspendLayout();
            this.panel_Diagnosisubmenu.SuspendLayout();
            this.panel_Doctorsubmenu.SuspendLayout();
            this.panel_patientsubmenu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_slide
            // 
            this.panel_slide.AutoScroll = true;
            this.panel_slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_slide.Controls.Add(this.button_exit);
            this.panel_slide.Controls.Add(this.button_dashboard);
            this.panel_slide.Controls.Add(this.panel_Diagnosisubmenu);
            this.panel_slide.Controls.Add(this.button_Diagnosis);
            this.panel_slide.Controls.Add(this.panel_Doctorsubmenu);
            this.panel_slide.Controls.Add(this.button_Doctors);
            this.panel_slide.Controls.Add(this.panel_patientsubmenu);
            this.panel_slide.Controls.Add(this.button_patients);
            this.panel_slide.Controls.Add(this.panel_logo);
            this.panel_slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_slide.Location = new System.Drawing.Point(0, 0);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(176, 550);
            this.panel_slide.TabIndex = 0;
            // 
            // button_exit
            // 
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(0, 552);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_exit.Size = new System.Drawing.Size(159, 33);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Exit";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dashboard.FlatAppearance.BorderSize = 0;
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashboard.Location = new System.Drawing.Point(0, 519);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_dashboard.Size = new System.Drawing.Size(159, 33);
            this.button_dashboard.TabIndex = 8;
            this.button_dashboard.Text = "Dashboard";
            this.button_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dashboard.UseVisualStyleBackColor = true;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // panel_Diagnosisubmenu
            // 
            this.panel_Diagnosisubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_Diagnosisubmenu.Controls.Add(this.button_printDiagnose);
            this.panel_Diagnosisubmenu.Controls.Add(this.button_manageDiagnose);
            this.panel_Diagnosisubmenu.Controls.Add(this.button_newDiagnose);
            this.panel_Diagnosisubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Diagnosisubmenu.Location = new System.Drawing.Point(0, 414);
            this.panel_Diagnosisubmenu.Name = "panel_Diagnosisubmenu";
            this.panel_Diagnosisubmenu.Size = new System.Drawing.Size(159, 105);
            this.panel_Diagnosisubmenu.TabIndex = 7;
            // 
            // button_printDiagnose
            // 
            this.button_printDiagnose.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_printDiagnose.FlatAppearance.BorderSize = 0;
            this.button_printDiagnose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_printDiagnose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_printDiagnose.Location = new System.Drawing.Point(0, 70);
            this.button_printDiagnose.Name = "button_printDiagnose";
            this.button_printDiagnose.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_printDiagnose.Size = new System.Drawing.Size(159, 35);
            this.button_printDiagnose.TabIndex = 3;
            this.button_printDiagnose.Text = "Print";
            this.button_printDiagnose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_printDiagnose.UseVisualStyleBackColor = true;
            this.button_printDiagnose.Click += new System.EventHandler(this.button_printDiagnose_Click);
            // 
            // button_manageDiagnose
            // 
            this.button_manageDiagnose.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_manageDiagnose.FlatAppearance.BorderSize = 0;
            this.button_manageDiagnose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageDiagnose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manageDiagnose.Location = new System.Drawing.Point(0, 35);
            this.button_manageDiagnose.Name = "button_manageDiagnose";
            this.button_manageDiagnose.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_manageDiagnose.Size = new System.Drawing.Size(159, 35);
            this.button_manageDiagnose.TabIndex = 2;
            this.button_manageDiagnose.Text = "Manage Diagnosis";
            this.button_manageDiagnose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_manageDiagnose.UseVisualStyleBackColor = true;
            this.button_manageDiagnose.Click += new System.EventHandler(this.button_manageDiagnose_Click);
            // 
            // button_newDiagnose
            // 
            this.button_newDiagnose.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newDiagnose.FlatAppearance.BorderSize = 0;
            this.button_newDiagnose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newDiagnose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newDiagnose.Location = new System.Drawing.Point(0, 0);
            this.button_newDiagnose.Name = "button_newDiagnose";
            this.button_newDiagnose.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_newDiagnose.Size = new System.Drawing.Size(159, 35);
            this.button_newDiagnose.TabIndex = 1;
            this.button_newDiagnose.Text = "Diagnose";
            this.button_newDiagnose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newDiagnose.UseVisualStyleBackColor = true;
            this.button_newDiagnose.Click += new System.EventHandler(this.button_newDiagnose_Click);
            // 
            // button_Diagnosis
            // 
            this.button_Diagnosis.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Diagnosis.FlatAppearance.BorderSize = 0;
            this.button_Diagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Diagnosis.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Diagnosis.Location = new System.Drawing.Point(0, 381);
            this.button_Diagnosis.Name = "button_Diagnosis";
            this.button_Diagnosis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Diagnosis.Size = new System.Drawing.Size(159, 33);
            this.button_Diagnosis.TabIndex = 6;
            this.button_Diagnosis.Text = "Diagnosis";
            this.button_Diagnosis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Diagnosis.UseVisualStyleBackColor = true;
            this.button_Diagnosis.Click += new System.EventHandler(this.button_Diagnosis_Click);
            // 
            // panel_Doctorsubmenu
            // 
            this.panel_Doctorsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_Doctorsubmenu.Controls.Add(this.button_PrintDoctors);
            this.panel_Doctorsubmenu.Controls.Add(this.button_manageDoctors);
            this.panel_Doctorsubmenu.Controls.Add(this.button_NewDoctors);
            this.panel_Doctorsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Doctorsubmenu.Location = new System.Drawing.Point(0, 279);
            this.panel_Doctorsubmenu.Name = "panel_Doctorsubmenu";
            this.panel_Doctorsubmenu.Size = new System.Drawing.Size(159, 102);
            this.panel_Doctorsubmenu.TabIndex = 5;
            // 
            // button_PrintDoctors
            // 
            this.button_PrintDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_PrintDoctors.FlatAppearance.BorderSize = 0;
            this.button_PrintDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PrintDoctors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PrintDoctors.Location = new System.Drawing.Point(0, 70);
            this.button_PrintDoctors.Name = "button_PrintDoctors";
            this.button_PrintDoctors.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_PrintDoctors.Size = new System.Drawing.Size(159, 35);
            this.button_PrintDoctors.TabIndex = 3;
            this.button_PrintDoctors.Text = "Print";
            this.button_PrintDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PrintDoctors.UseVisualStyleBackColor = true;
            this.button_PrintDoctors.Click += new System.EventHandler(this.button_PrintDoctors_Click);
            // 
            // button_manageDoctors
            // 
            this.button_manageDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_manageDoctors.FlatAppearance.BorderSize = 0;
            this.button_manageDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageDoctors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manageDoctors.Location = new System.Drawing.Point(0, 35);
            this.button_manageDoctors.Name = "button_manageDoctors";
            this.button_manageDoctors.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_manageDoctors.Size = new System.Drawing.Size(159, 35);
            this.button_manageDoctors.TabIndex = 1;
            this.button_manageDoctors.Text = "Manage Doctors";
            this.button_manageDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_manageDoctors.UseVisualStyleBackColor = true;
            this.button_manageDoctors.Click += new System.EventHandler(this.button_manageDoctors_Click);
            // 
            // button_NewDoctors
            // 
            this.button_NewDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_NewDoctors.FlatAppearance.BorderSize = 0;
            this.button_NewDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewDoctors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NewDoctors.Location = new System.Drawing.Point(0, 0);
            this.button_NewDoctors.Name = "button_NewDoctors";
            this.button_NewDoctors.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_NewDoctors.Size = new System.Drawing.Size(159, 35);
            this.button_NewDoctors.TabIndex = 0;
            this.button_NewDoctors.Text = "Doctors";
            this.button_NewDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_NewDoctors.UseVisualStyleBackColor = true;
            this.button_NewDoctors.Click += new System.EventHandler(this.button_NewDoctors_Click);
            // 
            // button_Doctors
            // 
            this.button_Doctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Doctors.FlatAppearance.BorderSize = 0;
            this.button_Doctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Doctors.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Doctors.Location = new System.Drawing.Point(0, 246);
            this.button_Doctors.Name = "button_Doctors";
            this.button_Doctors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Doctors.Size = new System.Drawing.Size(159, 33);
            this.button_Doctors.TabIndex = 4;
            this.button_Doctors.Text = "Doctors";
            this.button_Doctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Doctors.UseVisualStyleBackColor = true;
            this.button_Doctors.Click += new System.EventHandler(this.button_Doctors_Click);
            // 
            // panel_patientsubmenu
            // 
            this.panel_patientsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_patientsubmenu.Controls.Add(this.button_Printpatient);
            this.panel_patientsubmenu.Controls.Add(this.button_managePatient);
            this.panel_patientsubmenu.Controls.Add(this.button_Registration);
            this.panel_patientsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_patientsubmenu.Location = new System.Drawing.Point(0, 133);
            this.panel_patientsubmenu.Name = "panel_patientsubmenu";
            this.panel_patientsubmenu.Size = new System.Drawing.Size(159, 113);
            this.panel_patientsubmenu.TabIndex = 3;
            // 
            // button_Printpatient
            // 
            this.button_Printpatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Printpatient.FlatAppearance.BorderSize = 0;
            this.button_Printpatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Printpatient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Printpatient.Location = new System.Drawing.Point(0, 70);
            this.button_Printpatient.Name = "button_Printpatient";
            this.button_Printpatient.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_Printpatient.Size = new System.Drawing.Size(159, 35);
            this.button_Printpatient.TabIndex = 3;
            this.button_Printpatient.Text = "Print";
            this.button_Printpatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Printpatient.UseVisualStyleBackColor = true;
            this.button_Printpatient.Click += new System.EventHandler(this.button_Printpatient_Click);
            // 
            // button_managePatient
            // 
            this.button_managePatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_managePatient.FlatAppearance.BorderSize = 0;
            this.button_managePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managePatient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_managePatient.Location = new System.Drawing.Point(0, 35);
            this.button_managePatient.Name = "button_managePatient";
            this.button_managePatient.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_managePatient.Size = new System.Drawing.Size(159, 35);
            this.button_managePatient.TabIndex = 1;
            this.button_managePatient.Text = "Manage Patient";
            this.button_managePatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_managePatient.UseVisualStyleBackColor = true;
            this.button_managePatient.Click += new System.EventHandler(this.button_managePatient_Click);
            // 
            // button_Registration
            // 
            this.button_Registration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Registration.FlatAppearance.BorderSize = 0;
            this.button_Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Registration.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Registration.Location = new System.Drawing.Point(0, 0);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_Registration.Size = new System.Drawing.Size(159, 35);
            this.button_Registration.TabIndex = 0;
            this.button_Registration.Text = "Registration";
            this.button_Registration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Registration.UseVisualStyleBackColor = true;
            this.button_Registration.Click += new System.EventHandler(this.button_Registration_Click);
            // 
            // button_patients
            // 
            this.button_patients.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_patients.FlatAppearance.BorderSize = 0;
            this.button_patients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_patients.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_patients.Location = new System.Drawing.Point(0, 100);
            this.button_patients.Name = "button_patients";
            this.button_patients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_patients.Size = new System.Drawing.Size(159, 33);
            this.button_patients.TabIndex = 2;
            this.button_patients.Text = "Patients";
            this.button_patients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_patients.UseVisualStyleBackColor = true;
            this.button_patients.Click += new System.EventHandler(this.button_patients_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pictureBox3);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(159, 100);
            this.panel_logo.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(176, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(903, 550);
            this.panel_main.TabIndex = 1;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.pictureBox2);
            this.panel_cover.Controls.Add(this.panel3);
            this.panel_cover.Controls.Add(this.panel2);
            this.panel_cover.Controls.Add(this.panel1);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(903, 550);
            this.panel_cover.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(897, 339);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label_cfemale);
            this.panel3.Controls.Add(this.label_cmale);
            this.panel3.Controls.Add(this.comboBox_course);
            this.panel3.Controls.Add(this.label_femalepatients);
            this.panel3.Controls.Add(this.label_malepatients);
            this.panel3.Controls.Add(this.label_totalpatients);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 66);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(549, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Select Class :";
            // 
            // label_cfemale
            // 
            this.label_cfemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cfemale.AutoSize = true;
            this.label_cfemale.ForeColor = System.Drawing.Color.White;
            this.label_cfemale.Location = new System.Drawing.Point(777, 51);
            this.label_cfemale.Name = "label_cfemale";
            this.label_cfemale.Size = new System.Drawing.Size(47, 13);
            this.label_cfemale.TabIndex = 8;
            this.label_cfemale.Text = "Female :";
            // 
            // label_cmale
            // 
            this.label_cmale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cmale.AutoSize = true;
            this.label_cmale.ForeColor = System.Drawing.Color.White;
            this.label_cmale.Location = new System.Drawing.Point(671, 51);
            this.label_cmale.Name = "label_cmale";
            this.label_cmale.Size = new System.Drawing.Size(36, 13);
            this.label_cmale.TabIndex = 9;
            this.label_cmale.Text = "Male :";
            // 
            // comboBox_course
            // 
            this.comboBox_course.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(666, 10);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(211, 21);
            this.comboBox_course.TabIndex = 7;
            // 
            // label_femalepatients
            // 
            this.label_femalepatients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_femalepatients.AutoSize = true;
            this.label_femalepatients.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_femalepatients.Location = new System.Drawing.Point(155, 41);
            this.label_femalepatients.Name = "label_femalepatients";
            this.label_femalepatients.Size = new System.Drawing.Size(56, 16);
            this.label_femalepatients.TabIndex = 3;
            this.label_femalepatients.Text = "Female :";
            // 
            // label_malepatients
            // 
            this.label_malepatients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_malepatients.AutoSize = true;
            this.label_malepatients.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_malepatients.Location = new System.Drawing.Point(17, 41);
            this.label_malepatients.Name = "label_malepatients";
            this.label_malepatients.Size = new System.Drawing.Size(43, 16);
            this.label_malepatients.TabIndex = 2;
            this.label_malepatients.Text = "Male :";
            // 
            // label_totalpatients
            // 
            this.label_totalpatients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_totalpatients.AutoSize = true;
            this.label_totalpatients.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalpatients.Location = new System.Drawing.Point(10, 14);
            this.label_totalpatients.Name = "label_totalpatients";
            this.label_totalpatients.Size = new System.Drawing.Size(91, 16);
            this.label_totalpatients.TabIndex = 1;
            this.label_totalpatients.Text = "Total Patients :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 66);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(791, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctors";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 67);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(101, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(427, 32);
            this.label12.TabIndex = 2;
            this.label12.Text = "\"A Maternity Clinic attending Normal Deliveries, Can do Pre-Natal, \r\n            " +
    "       Post Natal, Well Baby, Family Planning and Health Counselling\"";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "OLGA Maternity Care Clinic and Lying-In";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 550);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_slide);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_slide.ResumeLayout(false);
            this.panel_Diagnosisubmenu.ResumeLayout(false);
            this.panel_Doctorsubmenu.ResumeLayout(false);
            this.panel_patientsubmenu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Panel panel_Diagnosisubmenu;
        private System.Windows.Forms.Button button_printDiagnose;
        private System.Windows.Forms.Button button_manageDiagnose;
        private System.Windows.Forms.Button button_newDiagnose;
        private System.Windows.Forms.Button button_Diagnosis;
        private System.Windows.Forms.Panel panel_Doctorsubmenu;
        private System.Windows.Forms.Button button_PrintDoctors;
        private System.Windows.Forms.Button button_manageDoctors;
        private System.Windows.Forms.Button button_NewDoctors;
        private System.Windows.Forms.Button button_Doctors;
        private System.Windows.Forms.Panel panel_patientsubmenu;
        private System.Windows.Forms.Button button_Printpatient;
        private System.Windows.Forms.Button button_managePatient;
        private System.Windows.Forms.Button button_Registration;
        private System.Windows.Forms.Button button_patients;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_femalepatients;
        private System.Windows.Forms.Label label_malepatients;
        private System.Windows.Forms.Label label_totalpatients;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_cfemale;
        private System.Windows.Forms.Label label_cmale;
        private System.Windows.Forms.ComboBox comboBox_course;
    }
}

