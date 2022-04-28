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
    public partial class Form6 : Form
    {
        string gender;

        public Form6()
        {
            InitializeComponent();
        }

        DBAccess con = new DBAccess();
        private void bsubmit8_Click(object sender, EventArgs e)
        {
            string variables = "Dname, Daddress, Dcontact, Demail, Dpass, Dgender"; // Database Column Names
            string values = "'" + tname8.Text + "','" + taddress8.Text + "','" + tcontact8.Text + "','" + tmail8.Text + "','" + tpass8.Text + "','" + gender + "'"; // Text Boxes

            con.dataSend(" INSERT INTO userinfo(" + variables + ")  values ( " + values + " )");


            MessageBox.Show("Registration Succesful");
            ClearData();

            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void ClearData()
        {
            tname8.Clear();
            taddress8.Clear();
            tcontact8.Clear();
            tmail8.Clear();
            tpass8.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
