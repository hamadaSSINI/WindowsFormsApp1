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
    public partial class ManagePatients : Form
    {
        Patientclass Patients = new Patientclass();
        public ManagePatients()
        {
            InitializeComponent();
        }

        private void ManagePatients_Load(object sender, EventArgs e)
        {
            showTable();
        }
        // To show Patients list in DatagridView
        public void showTable()
        {
            dataGridView_patients.DataSource = Patients.GetPatientslist(new MySqlCommand("SELECT * FROM `patients`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_patients.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        // Display Patients data from Patients to textbox
        private void dataGridView_patients_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_patients.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text = dataGridView_patients.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text = dataGridView_patients.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker1.Value = (DateTime)dataGridView_patients.CurrentRow.Cells[3].Value;
            if (dataGridView_patients.CurrentRow.Cells[4].Value.ToString() == "Male")
                radioButton_male.Checked = true;

            textBox_contactnumber.Text = dataGridView_patients.CurrentRow.Cells[5].Value.ToString();
            textBox_address.Text = dataGridView_patients.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])dataGridView_patients.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_patients.Image = Image.FromStream(ms);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_contactnumber.Clear();
            textBox_address.Clear();
            textBox_id.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_patients.Image = null;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            // browse photo from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_patients.Image = Image.FromFile(opf.FileName);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            dataGridView_patients.DataSource = Patients.searchPatients(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_patients.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        //create a function to verify
        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_contactnumber.Text == "") || (textBox_address.Text == "") ||
                (pictureBox_patients.Image == null))
            {
                return false;
            }
            else
                return true;
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            // update patients record
            int id = Convert.ToInt32(textBox_id.Text);
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_contactnumber.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";


            //we need to check patients age between 10 and 100

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    // to get photo from picture box
                    MemoryStream ms = new MemoryStream();
                    pictureBox_patients.Image.Save(ms, pictureBox_patients.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (Patients.UpdatePatients(id, fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("Student data update", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_Clear.PerformClick();
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //remove the selected patients
            int id = Convert.ToInt32(textBox_id.Text);
            //Show a confirmation message before delete the student
            if (MessageBox.Show("You want to delete the patients?", "Remove Patients", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Patients.deletePatients(id))
                {
                    showTable();
                    MessageBox.Show("Patients Removed", "Remove Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_Clear.PerformClick();
                }
            }

        }

        private void ManagePatients_Click(object sender, EventArgs e)
        {

        }
    }
    
}
