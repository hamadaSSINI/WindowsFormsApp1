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
    
    public partial class PrintDiagnoseForm : Form
    {
        DGVPrinter printer = new DGVPrinter();
        DiagnoseClass diagnose = new DiagnoseClass();
        public PrintDiagnoseForm()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_diagnose.DataSource = diagnose.getList(new MySqlCommand("SELECT * FROM `diagnose`"));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper for print pdf file
            printer.Title = "Olga Diagnosis List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Olga";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_diagnose);
        }

        private void PrintDiagnoseForm_Load(object sender, EventArgs e)
        {
            showdiagnose();
        }
        // to show diagnose list
        public void showdiagnose()
        {
            DataGridView_diagnose.DataSource = diagnose.getList(new MySqlCommand("SELECT * FROM `diagnose`"));
        }
    }
}
