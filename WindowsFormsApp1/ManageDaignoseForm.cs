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
    public partial class ManageDaignoseForm : Form
    {
        Patientclass patients = new Patientclass();
        DiagnoseClass diagnose = new DiagnoseClass();
        DoctorsClass doctors = new DoctorsClass();
        public ManageDaignoseForm()
        {
            InitializeComponent();
        }

        private void ManageDaignoseForm_Load(object sender, EventArgs e)
        {
            // populate  the combobox with the doctors name
            comboBox_doctors.DataSource = doctors.getdoctors(new MySqlCommand("SELECT * FROM `doctors`"));
            comboBox_doctors.DisplayMember = "DoctorsName";
            comboBox_doctors.ValueMember = "DoctorsName";
            // tp to show diagnose on datagridview
            showdiagnose();
        }
        public void showdiagnose()
        {
            DataGridView_doctors.DataSource = diagnose.getList(new MySqlCommand("SELECT * FROM `diagnose`"));
        }

        private void button_Update_Click(object sender, EventArgs e)
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
               


                    if (diagnose.updatediagnose(ptid, dn,diag, desc))
                    {
                        showdiagnose();
                        button_clear.PerformClick();
                        MessageBox.Show("Diagnose Edited Complete", "Update diagnose", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Diagnose not added", "Add Diagnose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_patientsid.Text == "")
            {
                MessageBox.Show("Field error we need paients id", "delete diagnose", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int pid = Convert.ToInt32(textBox_patientsid.Text);
                if (MessageBox.Show("You want to delete the diagnose?", "delete diagnose", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (diagnose.deletediagnose(pid))
                    {
                        showdiagnose();
                        MessageBox.Show("diagnose Removed", "Remove diagnose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_patientsid.Clear();
            textBox_diagnose.Clear();
            textBox_description.Clear();
            textBox_search.Clear();
        }

        private void DataGridView_doctors_Click(object sender, EventArgs e)
        {
            
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_doctors.DataSource = diagnose.getList(new MySqlCommand("SELECT * FROM `diagnose`"));
        }
    }
}
