using System;
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
    public partial class Edit_User_UserControl : UserControl
    {
        string gender;

        DBAccess con = new DBAccess();

        private static Edit_User_UserControl obj1;

        public static Edit_User_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new Edit_User_UserControl();
                }

                return obj1;
            }
        }

        public Edit_User_UserControl()
        {
            InitializeComponent();
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show( "Are You Sure You Want To Update", "Update", MessageBoxButtons.YesNo );

            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend( "UPDATE userinfo SET Dname = '" + bname.Text + "', Daddress = '" + baddress.Text + "', Dcontact = '" + bcontact.Text + "', Demail = '" + bemail.Text + "', Dgender = '" + gender + "' where Did =' " + bid.Text + "'" );
                MessageBox.Show( "Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information );
                ClearData();
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show( "Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo );

            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend( "Delete from userinfo where Did ='" + bid.Text + "'" );
                MessageBox.Show( "Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information );
                ClearData();
            }
        }

        public void ClearData()
        {
            bname.Clear();
            bid.Clear();
            baddress.Clear();
            bcontact.Clear();
            bemail.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
    }
}
