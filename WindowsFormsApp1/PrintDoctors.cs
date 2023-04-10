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
    
    public partial class PrintDoctors : Form
    {
        DGVPrinter printer = new DGVPrinter();
        DoctorsClass doctors = new DoctorsClass();
        public PrintDoctors()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            //To Search Doctors and show on datagridview
            DataGridView_doctors.DataSource = doctors.getdoctors(new MySqlCommand("SELECT * FROM `doctors` WHERE CONCAT(`DoctorsName`)LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }

        private void PrintDoctors_Load(object sender, EventArgs e)
        {
            DataGridView_doctors.DataSource = doctors.getdoctors(new MySqlCommand("SELECT * FROM `doctors`"));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper for print pdf file
            printer.Title = "Olga Doctors List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Olga";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_doctors);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_doctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
