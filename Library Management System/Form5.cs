using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DatabaseProject;

namespace Library_Management_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tuser_Click(object sender, EventArgs e)
        {
            tuser.Clear();
        }

        private void tpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpass_Click(object sender, EventArgs e)
        {
            tpass.Clear();
            tpass.PasswordChar = '*';
        }

        public static string username;
        private void bloginu_Click(object sender, EventArgs e)
        {
            username = tuser.Text;

            DBAccess con = new DBAccess();
            con.dataGet("Select * from userinfo where Dname ='" + tuser.Text + "' and Dpass = '" + tpass.Text + "' ");
            DataTable dt = new DataTable();

            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bregisteru_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
