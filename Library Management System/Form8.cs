﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using DatabaseProject;

namespace Library_Management_System
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            //label1.Text = Add_Book_UserControl.name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form4 f4 = new Form4();
            //f4.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=localhost;Initial Catalog=lms;Integrated Security=True");

            string sql = "Select * from admininfo where Dname ='" + Form2.username + "' and Dpass = '" + Form2.pass + "' ";

            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    label5.Text = dr["Did"].ToString();
                    label6.Text = dr["Dname"].ToString();
                    label7.Text = dr["Daddress"].ToString();
                    label8.Text = dr["Dcontact"].ToString();
                    label12.Text = dr["Demail"].ToString();
                    label13.Text = dr["Dgender"].ToString();
                    label14.Text = dr["Dpass"].ToString();
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
