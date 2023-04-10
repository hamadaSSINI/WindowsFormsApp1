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

    public partial class ManageDoctors : Form
    {
        DoctorsClass doctors = new DoctorsClass();  
        public ManageDoctors()
        {
            InitializeComponent();
        }

        private void ManageDoctors_Load(object sender, EventArgs e)
        {
            showData();

        }
        // Show data of the course 
        private void showData()
        {
            //to show course list on datagridview
            DataGridView_doctors.DataSource = doctors.getdoctors(new MySqlCommand("SELECT * FROM `doctors`"));
        }




        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Dname.Clear();
            textBox_Dhour.Clear();
            textBox_description.Clear();
        }

        private void button_Update_Click_1(object sender, EventArgs e)
        {
            if (textBox_Dname.Text == "" || textBox_Dhour.Text == "" || textBox_id.Text.Equals(""))
            {
                MessageBox.Show("Need Doctors data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string Dname = textBox_Dname.Text;
                int dh = Convert.ToInt32(textBox_Dhour.Text);
                string desc = textBox_description.Text;


                if (doctors.updateDoctors(id, Dname, dh, desc))
                {
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("Doctors update successfuly", "Update Doctors", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error-Doctors not Edit", "Update Doctors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            if (textBox_id.Text.Equals(""))
            {
                MessageBox.Show("Need Course Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    if (doctors.deletedoctors(id))
                    {
                        showData();
                        button_clear.PerformClick();
                        MessageBox.Show("Doctors Deleted", "Removed Doctors", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Removed Doctors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView_doctors_Click_1(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_doctors.CurrentRow.Cells[0].Value.ToString();
            textBox_Dname.Text = DataGridView_doctors.CurrentRow.Cells[1].Value.ToString();
            textBox_Dhour.Text = DataGridView_doctors.CurrentRow.Cells[2].Value.ToString();
            textBox_description.Text = DataGridView_doctors.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_search_Click_1(object sender, EventArgs e)
        {
            //To Search Doctors and show on datagridview
            DataGridView_doctors.DataSource = doctors.getdoctors(new MySqlCommand("SELECT * FROM `doctors` WHERE CONCAT(`DoctorsName`)LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }

        
    }
}
