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
    public partial class Feedback_User_UserControl : UserControl
    {
        string satisfaction;

        private static Feedback_User_UserControl obj1;

        public static Feedback_User_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new Feedback_User_UserControl();
                }

                return obj1;
            }
        }

        public Feedback_User_UserControl()
        {
            InitializeComponent();
        }

        DBAccess con = new DBAccess();
        private void submit_Click(object sender, EventArgs e)
        {
            string variables = "Did, Dpass, Satisfaction, Improve"; // Database Column Names
            string values = "'" + id.Text + "','" + pass.Text + "','" + satisfaction + "','" + improve.Text + "'"; // Text Boxes

            con.dataSend("INSERT INTO feedback(" + variables + ")  values ( " + values + " )");
            MessageBox.Show("Feedback recorded.");

            id.Clear();
            pass.Clear();
            improve.Clear();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            satisfaction = "Very Satisfied";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            satisfaction = "Satisfied";
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            satisfaction = "Normal";
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            satisfaction = "Unsatisfied";
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            satisfaction = "Very Unsatisfied";
        }

        private void pass_Click(object sender, EventArgs e)
        {
            pass.PasswordChar = '*';
        }
    }
}
