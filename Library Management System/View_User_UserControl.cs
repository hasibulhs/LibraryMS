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
    public partial class View_User_UserControl : UserControl
    {
        DBAccess con = new DBAccess();

        private static View_User_UserControl obj1;

        public static View_User_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new View_User_UserControl();
                }

                return obj1;
            }
        }

        public View_User_UserControl()
        {
            InitializeComponent();
        }

        private void View_User_UserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadData()
        {
            con.dataGet("Select * from [userinfo]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells["dgid"].Value = row["Did"].ToString();
                dataGridView1.Rows[n].Cells["dgname"].Value = row["Dname"].ToString();
                dataGridView1.Rows[n].Cells["dgaddress"].Value = row["Daddress"].ToString();
                dataGridView1.Rows[n].Cells["dgcontact"].Value = row["Dcontact"].ToString();
                dataGridView1.Rows[n].Cells["dgemail"].Value = row["Demail"].ToString();
                dataGridView1.Rows[n].Cells["dggender"].Value = row["Dgender"].ToString();
            }
        }

        private void bview_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
