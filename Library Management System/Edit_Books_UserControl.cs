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
    public partial class Edit_Books_UserControl : UserControl
    {
        DBAccess con = new DBAccess();

        private static Edit_Books_UserControl obj1;

        public static Edit_Books_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new Edit_Books_UserControl();
                }

                return obj1;
            }
        }

        public Edit_Books_UserControl()
        {
            InitializeComponent();
        }

        private void Edit_Books_UserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show( "Are You Sure You Want To Update", "Update", MessageBoxButtons.YesNo );

            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend( "UPDATE books SET bname = '" + tname6.Text + "', bauthor = '" + tauthor6.Text + "', bgenre = '" + comboBox1.Text + "', bprice = '" + tprice6.Text + "' where bid = '" + tid6.Text + "'" );
                MessageBox.Show( "Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information );
                ClearData();
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show( "Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo );

            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend( "Delete from books where bid = '" + tid6.Text + "'" );
                MessageBox.Show( "Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information );
                ClearData();
            }
        }

        public void ClearData()
        {
            tname6.Clear();
            tid6.Clear();
            tauthor6.Clear();
            comboBox1.Text = string.Empty;
            tprice6.Clear();
        }
    }
}
