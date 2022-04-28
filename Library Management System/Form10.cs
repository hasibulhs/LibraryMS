using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            //richt.Clear();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            richt.Clear();

            richt.Text += "**************************************\n";
            richt.Text += "******       User Receipt       ******\n";
            richt.Text += "**************************************\n";
            richt.Text += "Date : " + DateTime.Now + "\n\n";

            richt.Text += "User Id : " + Issue_Book_UserControl.uid + "\n";
            richt.Text += "User Name : " + Issue_Book_UserControl.uname + "\n";
            richt.Text += "Book Id : " + Issue_Book_UserControl.bid + "\n";
            richt.Text += "Book Name : " + Issue_Book_UserControl.bname + "\n";
            richt.Text += "Issue Date : " + Issue_Book_UserControl.idate + "\n";
            richt.Text += "Due Date : " + Issue_Book_UserControl.ddate + "\n\n\n\n";

            richt.Text += "------------------------------------------\n";
            richt.Text += "                  Signature";
        }

        private void bok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richt.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(260, 10));
        }

        private void bprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
