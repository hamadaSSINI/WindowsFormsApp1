using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        Patientclass Patients = new Patientclass();
        public RegistrationForm()
        { 
            InitializeComponent();
        }



        //create a function to verify
        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_contact.Text == "") || (textBox_address.Text == "") ||
                (pictureBox_patients.Image == null))
            {
                return false;
            }
            else
                return true;
        }


        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        // To show Patients list in DatagridView
        public void showTable()
        {
            dataGridView_patients.DataSource = Patients.GetPatientslist(new MySqlCommand("SELECT * FROM `patients`"));
            dataGridView_patients.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_patients.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            // browse photo from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_patients.Image = Image.FromFile(opf.FileName);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // add new patients
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string contact = textBox_contact.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";


            //we need to check patients age between 10 and 100

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The patients age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    // to get photo from picture box
                    MemoryStream ms = new MemoryStream();
                    pictureBox_patients.Image.Save(ms, pictureBox_patients.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (Patients.insertpatients(fname, lname, bdate, gender, contact, address, img))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_contact.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_patients.Image = null;
        }
    }
}

