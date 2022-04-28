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
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Change_Pass_User_UserControl : UserControl
    {
        DBAccess con = new DBAccess();

        private static Change_Pass_User_UserControl obj1;

        public static Change_Pass_User_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new Change_Pass_User_UserControl();
                }

                return obj1;
            }
        }

        public Change_Pass_User_UserControl()
        {
            InitializeComponent();
            panel.Hide();
        }

        private void bgo_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from userinfo where Did ='" + tid.Text + "' and  Dpass = '" + toldpass.Text + "' ");
            DataTable dt = new DataTable();

            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                panel.Show();
                bgo.Hide();
                label4.Enabled = false;
                label1.Enabled = false;
                tid.Enabled = false;
                toldpass.Enabled = false;
            }
            else
            {
                MessageBox.Show("Wrong Id Or Password....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bchangepass_Click(object sender, EventArgs e)
        {
            if(Tnewpass.Text == tconfirmpass.Text)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Change Password ?", "Change Password", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    con.dataSend("UPDATE userinfo SET Dpass = '" + tconfirmpass.Text + "' WHERE Did =' " + tid.Text + "'");
                    MessageBox.Show("Password Changed Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tnewpass.Clear();
                    tconfirmpass.Clear();
                }
            }

            else
            {
                MessageBox.Show("Passwords Do Not Match...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tconfirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Tnewpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
