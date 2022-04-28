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
    public partial class Search_Book_UserControl : UserControl
    {
        DBAccess con = new DBAccess();

        private static Search_Book_UserControl obj1;

        public static Search_Book_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new Search_Book_UserControl();
                }

                return obj1;
            }
        }

        public Search_Book_UserControl()
        {
            InitializeComponent();
        }

        private void Search_Book_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            textBox.Clear();
        }

        private void LoadData()
        {
            con.dataGet( "Select * from [books] Where bid = '" + textBox.Text + "'" );
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView2.Rows.Clear();

            if(dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();

                    dataGridView2.Rows[n].Cells["dgid"].Value = row["bid"].ToString();
                    dataGridView2.Rows[n].Cells["dgname"].Value = row["bname"].ToString();
                    dataGridView2.Rows[n].Cells["dgauthor"].Value = row["bauthor"].ToString();
                    dataGridView2.Rows[n].Cells["dggenre"].Value = row["bgenre"].ToString();
                    dataGridView2.Rows[n].Cells["dgprice"].Value = row["bprice"].ToString();
                }
            }

            else
            {
                MessageBox.Show( "Invalid Book Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
