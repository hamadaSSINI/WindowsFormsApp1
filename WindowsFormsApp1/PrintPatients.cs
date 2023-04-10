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
using DGVPrinterHelper;

namespace WindowsFormsApp1
{
    public partial class PrintPatients : Form
    {
        Patientclass Patients = new Patientclass();
        DGVPrinter printer = new DGVPrinter();
        public PrintPatients()
        {
            InitializeComponent();
        }

        private void PrintPatients_Load(object sender, EventArgs e)
        {
            showdata(new MySqlCommand("SELECT * FROM `patients`"));
            
        }
        //create a function to show patientslist in datagridview
        public void showdata(MySqlCommand command)
        {
            DataGridView_patients.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //DataGridView_patients.Height = 80;
            DataGridView_patients.DataSource = Patients.getList(command);
            // column 7 is the image column index
            imageColumn = (DataGridViewImageColumn)DataGridView_patients.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // check Radio buttom
            string selectQuery;
            if  (radioButton_all .Checked)
            {
                selectQuery = "SELECT * FROM `patients`";
            }
            else if(radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM `patients` WHERE `Gender`='Male'";

            }
            else
            {
                selectQuery = "SELECT * FROM `patients` WHERE `Gender`='Female'";
            }
            showdata(new MySqlCommand(selectQuery));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper for print pdf file
            printer.Title = "Olga Clinic";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "olga";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_patients);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView_patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
   
}
