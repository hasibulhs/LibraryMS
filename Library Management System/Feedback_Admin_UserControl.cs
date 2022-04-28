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
    public partial class Feedback_Admin_UserControl : UserControl
    {
        DBAccess con = new DBAccess();

        private static Feedback_Admin_UserControl obj1;

        public static Feedback_Admin_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new Feedback_Admin_UserControl();
                }

                return obj1;
            }
        }

        public Feedback_Admin_UserControl()
        {
            InitializeComponent();
        }

        private void bview_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from [feedback]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells["dgfid"].Value = row["Feedbackid"].ToString();
                dataGridView1.Rows[n].Cells["dgid"].Value = row["Did"].ToString();
                dataGridView1.Rows[n].Cells["dgsatisfaction"].Value = row["Satisfaction"].ToString();
                dataGridView1.Rows[n].Cells["dgimprove"].Value = row["Improve"].ToString();
            }
        }
    }
}
