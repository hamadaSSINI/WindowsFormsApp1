using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class DiagnoseForm : Form
    {
        Patientclass patients = new Patientclass();
        DoctorsClass doctors = new DoctorsClass();
        DiagnoseClass diagnose = new DiagnoseClass();
        public DiagnoseForm()
        {
            InitializeComponent();
        }
            //create a function to show  data on datagridview diagnose
            private void showDiag()
        {
            DataGridView_patients.DataSource = diagnose.getList(new MySqlCommand("SELECT * FROM `diagnose`"));
        }

        private void DiagnoseForm_Load(object sender, EventArgs e)
        {
            // populate  the combobox with the doctors name
            comboBox_doctors.DataSource = doctors.getdoctors(new MySqlCommand("SELECT * FROM `doctors`"));
            comboBox_doctors.DisplayMember = "DoctorsName";
            comboBox_doctors.ValueMember = "DoctorsName";
            // to show data on diagnose datagridview 
            
            // to display the Patients list on DataGridView
            DataGridView_patients.DataSource = patients.getList(new MySqlCommand("SELECT `PTId`,`PtFirstName`,`PtLastNmame`FROM `patients`"));

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_patientsid.Text == "" || textBox_diagnose.Text == "")
            {
                MessageBox.Show("Need Doctors data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ptid = Convert.ToInt32(textBox_patientsid.Text);
                string dn = comboBox_doctors.Text;
                string diag = textBox_diagnose.Text;
                string desc = textBox_description.Text;
                if (!diagnose.checkdiagnose(ptid, dn))
                {


                    if (diagnose.insertdiagnose(ptid, dn, diag, desc))
                    {
                        showDiag();
                        button_clear.PerformClick();
                        MessageBox.Show("New diagnose added", "Add diagnose", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Diagnose not added", "Add Diagnose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The record for this are already exists", "Add Diagnose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_patientsid.Clear();
            textBox_diagnose.Clear();
            textBox_description.Clear();
            comboBox_doctors.SelectedIndex = 0;
        }

        private void DataGridView_patients_Click(object sender, EventArgs e)
        {
            textBox_patientsid.Text = DataGridView_patients.CurrentRow.Cells[0].Value.ToString();
        }

        private void DataGridView_diagnose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showDiag();
        }

        private void button_spatients_Click(object sender, EventArgs e)
        {
            DataGridView_patients.DataSource = patients.getList(new MySqlCommand("SELECT `PTId`,`PtFirstName`,`PtLastNmame`FROM `patients`"));
        }
    }
 
}
