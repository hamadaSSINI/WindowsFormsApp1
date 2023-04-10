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
    public partial class DoctorsForm : Form
    {
        DoctorsClass doctors = new DoctorsClass();
        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_Dname.Text == "" || textBox_Dhour.Text == "")
            {
                MessageBox.Show("Need Doctors data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string DName = textBox_Dname.Text;
                int Dh = Convert.ToInt32(textBox_Dhour.Text);
                string desc = textBox_description.Text;


                if (doctors.insertdoctors(DName, Dh, desc))
                {
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("New doctors inserted", "Add doctors", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Doctors not insert", "Add Doctors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Dname.Clear();
            textBox_Dhour.Clear();
            textBox_description.Clear();
        }

        
        
        private void DoctorsForm_Load_1(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            // to show doctors list on datagridview
            DataGridView_doctors.DataSource = doctors.getdoctors(new MySqlCommand("SELECT * FROM `doctors`"));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView_doctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Dhour_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Dname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}