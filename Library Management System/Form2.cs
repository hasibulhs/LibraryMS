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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bregistera_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        public static string username;
        public static string pass;
        private void blogina_Click(object sender, EventArgs e)
        {
            if(comboBox.Text == "Admin")
            {
                username = tuser.Text;
                pass = tpass.Text;

                DBAccess con = new DBAccess();
                con.dataGet("Select * from admininfo where Dname ='" + tuser.Text + "' and Dpass = '" + tpass.Text + "' ");
                DataTable dt = new DataTable();

                con.sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    Form4 f4 = new Form4();
                    f4.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if(comboBox.Text == "User")
            {
                username = tuser.Text;
                pass = tpass.Text;

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

            else
            {
                MessageBox.Show("Please Select Sign In as", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tuser_TextChanged(object sender, EventArgs e)
        {
            //if (tuser.Text == "")
            //{
            //    tpass.Enabled = false;
            //}

            //else
            //{
            //    tpass.Enabled = true;
            //}
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //tpass.Enabled = false;
            //blogina.Enabled = false;
        }

        private void tpass_TextChanged(object sender, EventArgs e)
        {
            //if (tpass.Text == "")
            //{
            //    blogina.Enabled = false;
            //}

            //else
            //{
            //    blogina.Enabled = true;
            //}
        }

        private void tuser_Click(object sender, EventArgs e)
        {
            tuser.Clear();
        }

        private void tpass_Click(object sender, EventArgs e)
        {
            tpass.Clear();
            tpass.PasswordChar = '*';
        }

        private void blogina_TextChanged(object sender, EventArgs e)
        {
            //if (tuser.Text == "" | tpass.Text == "")
            //{
            //    blogina.Enabled = false;
            //}

            //else
            //{
            //    blogina.Enabled = true;
            //}
        }

        private void busersignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if(tpass.PasswordChar == '*')
            {
                b2.BringToFront();
                tpass.PasswordChar = '\0';
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (tpass.PasswordChar == '\0')
            {
                b1.BringToFront();
                tpass.PasswordChar = '*';
            }
        }
    }
}
