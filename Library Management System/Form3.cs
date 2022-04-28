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
    public partial class Form3 : Form
    {
        string gender;

        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tname3_TextChanged(object sender, EventArgs e)
        {

        }

        DBAccess con = new DBAccess();
        private void bsubmit3_Click(object sender, EventArgs e)
        {
            string variables = "Dname, Daddress, Dcontact, Demail, Dpass, Dgender"; // Database Column Names
            string values = "'" + tname3.Text + "','" + taddress3.Text + "','" + tcontact3.Text + "','" + tmail3.Text + "','" + tpass3.Text + "','" + gender + "'"; // Text Boxes

            con.dataSend( "INSERT INTO admininfo(" + variables + ")  values (" + values + ")");


            MessageBox.Show( "Registration Succesful" );
            ClearData();

            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void ClearData()
        {
            tname3.Clear();
            taddress3.Clear();
            tcontact3.Clear();
            tmail3.Clear();
            tpass3.Clear();
        }

        private void tpass3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tmail3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tcontact3_TextChanged(object sender, EventArgs e)
        {

        }

        private void taddress3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tid3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //tid3.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void tid3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
