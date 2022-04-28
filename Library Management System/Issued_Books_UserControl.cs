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
    public partial class Issued_Books_UserControl : UserControl
    {
        
        DBAccess con = new DBAccess();

        private static Issued_Books_UserControl obj1;

        public static Issued_Books_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new Issued_Books_UserControl();
                }

                return obj1;
            }
        }

        public Issued_Books_UserControl()
        {
            InitializeComponent();
            //LoadData();
        }

        private void LoadData()
        {
            con.dataGet("Select * from [bookissue] Where Dusername = '" + Form2.username + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells["dgissueid"].Value = row["Dissueid"].ToString();
                dataGridView1.Rows[n].Cells["dgbookid"].Value = row["Dbookid"].ToString();
                dataGridView1.Rows[n].Cells["dgbookname"].Value = row["Dbookname"].ToString();
                dataGridView1.Rows[n].Cells["dgissuedate"].Value = row["Dissuedate"].ToString();
                dataGridView1.Rows[n].Cells["dgduedate"].Value = row["Dduedate"].ToString();
            }
        }

        private void Issued_Books_UserControl_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void bview_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
