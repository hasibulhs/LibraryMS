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
    public partial class Add_Book_UserControl : UserControl
    {
        private static Add_Book_UserControl obj1;
        
        public static Add_Book_UserControl obj2
        {
            get
            {
                if(obj1 == null)
                {
                    obj1 = new Add_Book_UserControl();
                }

                return obj1;
            }
        }

        public Add_Book_UserControl()
        {
            InitializeComponent();
        }

        private void Add_Book_UserControl_Load(object sender, EventArgs e)
        {

        }

        DBAccess con = new DBAccess();
        private void benter5_Click(object sender, EventArgs e)
        {
            string variables = "Bname, Bauthor, Bgenre, Bprice"; // Database Column Names
            string values = "'" + tname5.Text + "','" + tauthor5.Text + "','" + comboBox1.Text + "','" + tprice5.Text + "'"; // Text Boxes

            con.dataSend( "INSERT INTO books(" + variables + ")  values ( " + values + " )" );
            MessageBox.Show( "Book Added !" );

            tname5.Clear();
            tauthor5.Clear();
            comboBox1.Text = string.Empty;
            tprice5.Clear();
        }
    }
}
