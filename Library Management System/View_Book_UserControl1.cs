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
    public partial class View_Book_UserControl1 : UserControl
    {
        DBAccess con = new DBAccess();

        private static View_Book_UserControl1 obj1;

        public static View_Book_UserControl1 obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new View_Book_UserControl1();
                }

                return obj1;
            }
        }

        public View_Book_UserControl1()
        {
            InitializeComponent();
        }

        private void View_Book_UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from [books] Where bgenre = 'Science'");
            //con.dataGet("Select * from [books]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells["bgid"].Value = row["bid"].ToString();
                dataGridView1.Rows[n].Cells["bgname"].Value = row["bname"].ToString();
                dataGridView1.Rows[n].Cells["bgauthor"].Value = row["bauthor"].ToString();
                //dataGridView1.Rows[n].Cells["bggenre"].Value = row["bgenre"].ToString();
                dataGridView1.Rows[n].Cells["bgprice"].Value = row["bprice"].ToString();
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from [books] Where bgenre = 'Mystery'");
            //con.dataGet("Select * from [books]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells["bgid"].Value = row["bid"].ToString();
                dataGridView1.Rows[n].Cells["bgname"].Value = row["bname"].ToString();
                dataGridView1.Rows[n].Cells["bgauthor"].Value = row["bauthor"].ToString();
                //dataGridView1.Rows[n].Cells["bggenre"].Value = row["bgenre"].ToString();
                dataGridView1.Rows[n].Cells["bgprice"].Value = row["bprice"].ToString();
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from [books] Where bgenre = 'Story'");
            //con.dataGet("Select * from [books]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells["bgid"].Value = row["bid"].ToString();
                dataGridView1.Rows[n].Cells["bgname"].Value = row["bname"].ToString();
                dataGridView1.Rows[n].Cells["bgauthor"].Value = row["bauthor"].ToString();
                //dataGridView1.Rows[n].Cells["bggenre"].Value = row["bgenre"].ToString();
                dataGridView1.Rows[n].Cells["bgprice"].Value = row["bprice"].ToString();
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from [books] Where bgenre = 'Educational'");
            //con.dataGet("Select * from [books]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells["bgid"].Value = row["bid"].ToString();
                dataGridView1.Rows[n].Cells["bgname"].Value = row["bname"].ToString();
                dataGridView1.Rows[n].Cells["bgauthor"].Value = row["bauthor"].ToString();
                //dataGridView1.Rows[n].Cells["bggenre"].Value = row["bgenre"].ToString();
                dataGridView1.Rows[n].Cells["bgprice"].Value = row["bprice"].ToString();
            }
        }
    }
}
