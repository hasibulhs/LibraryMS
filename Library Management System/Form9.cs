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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

            label5.Text = Issue_Book_UserControl.uid;
            label6.Text = Issue_Book_UserControl.uname;
            label7.Text = Issue_Book_UserControl.bid;
            label8.Text = Issue_Book_UserControl.bname;
            label10.Text = Issue_Book_UserControl.idate;
            label11.Text = Issue_Book_UserControl.ddate;
        }

        private void bok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
