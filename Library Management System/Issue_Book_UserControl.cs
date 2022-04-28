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
    public partial class Issue_Book_UserControl : UserControl
    {
        public static string uid;
        public static string uname;
        public static string bname;
        public static string bid;
        public static string idate;
        public static string ddate;

        private static Issue_Book_UserControl obj1;

        public static Issue_Book_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new Issue_Book_UserControl();
                }

                return obj1;
            }
        }

        public Issue_Book_UserControl()
        {
            InitializeComponent();
        }

        DBAccess con = new DBAccess();
        private void bissue_Click(object sender, EventArgs e)
        {
            uid = t1.Text;
            uname = t2.Text;
            bid = t3.Text;
            bname = t4.Text;
            idate = date.Text;
            ddate = duedate.Text;

            string variables = "Duserid, Dusername, Dbookid, Dbookname, Dissuedate, Dduedate"; // Database Column Names
            string values = "'" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "','" + date.Text + "','" + duedate.Text + "'"; // Text Boxes

            con.dataSend("INSERT INTO bookissue(" + variables + ") values ( " + values + ")");
            //MessageBox.Show( "Book Issued !" );

            Form10 f10 = new Form10();
            f10.Show();

            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
        }

            private void timer_Tick(object sender, EventArgs e)
            {
                date.Text = DateTime.Now.ToString("yyyy.MM.dd");
            }

        private void duedate_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Today > duedate.Value)
            {
                MessageBox.Show("Your Due Date Is Invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                duedate.Value = DateTime.Today;
            }
        }
    }
}
