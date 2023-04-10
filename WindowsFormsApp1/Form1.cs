using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Patientclass Patients = new Patientclass();
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PatientsCount();
        }
        // create a function  to display patients count
        private void PatientsCount()
        {
            //Display the values
            label_totalpatients.Text = "Total Patients :" + Patients.totalpatients();
            label_malepatients.Text = "Male : " + Patients.malepatients();
            label_femalepatients.Text = "Female : " + Patients.femalepatients();
        }
        private void customizeDesign()
        {
            panel_patientsubmenu.Visible = false;
            panel_Doctorsubmenu.Visible = false;    
            panel_Diagnosisubmenu.Visible = false;  
        }
        private void hideSubmenu()
        {
            if (panel_patientsubmenu.Visible == true)
                panel_patientsubmenu.Visible=false;
            if (panel_Doctorsubmenu.Visible == true)
                panel_Doctorsubmenu.Visible=false;
            if (panel_Diagnosisubmenu.Visible == true)
                panel_Diagnosisubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible=true;   
            }
            else
                submenu.Visible=false; 
        }

        private void button_patients_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_patientsubmenu);  
        }
        #region patientsubmenu
        private void button_Registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistrationForm());
            // . . .
            //. .Your Code
            //. . .
            hideSubmenu();
        }

        private void button_managePatient_Click(object sender, EventArgs e)
        {
            openChildForm(new ManagePatients());
            // . . .
            //. .Your Code
            //. . .
            hideSubmenu();
        }

        private void button_Status_Click(object sender, EventArgs e)
        {
            // . . .
            //. .Your Code
            //. . .
            hideSubmenu();
        }

        private void button_Printpatient_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintPatients());
            // . . .
            //. .Your Code
            //. . .
            hideSubmenu();
        }
        #endregion patientsubmenu
        private void button_Doctors_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Doctorsubmenu);
        }
        #region Doctorsubmenu
        private void button_NewDoctors_Click(object sender, EventArgs e)
        {
            openChildForm(new DoctorsForm());
            // . . .
            //. .Your Code
            //. . .
            hideSubmenu();
        }

        private void button_manageDoctors_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageDoctors());
            // . . .
            //. .Your Code
            //. . .
            hideSubmenu();
        }

        private void button_PrintDoctors_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintDoctors());
            // . . .
            //. .Your Code
            //. . .
            hideSubmenu();
        }
        #endregion Doctorsubmenu
        private void button_Diagnosis_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Diagnosisubmenu);
        }
        #region Diagnosisubmenu
        private void button_newDiagnose_Click(object sender, EventArgs e)
        {
            openChildForm(new DiagnoseForm());
            // . . .
            //. .Your Code
            //. . .
            hideSubmenu();
        }

        private void button_manageDiagnose_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageDaignoseForm());
            // . . .
            //. .Your Code
            //. . .
            hideSubmenu();
        }

        private void button_printDiagnose_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintDiagnoseForm());
            // . . .
            //. .Your Code
            //. . .
            hideSubmenu();
        }
        #endregion Diagnosisubmenu
        // to show register in form1
        private Form activeForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(ChildForm);
            panel_main.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            PatientsCount();
        }
    }
}
