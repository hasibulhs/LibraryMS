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
    public partial class Return_Book_UserControl : UserControl
    {
        DBAccess con = new DBAccess();

        private static Return_Book_UserControl obj1;

        public static Return_Book_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new Return_Book_UserControl();
                }

                return obj1;
            }
        }

        public Return_Book_UserControl()
        {
            InitializeComponent();
        }

        private void breturn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Return ?", "Message", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Delete from bookissue where Dissueid = '" + textBox.Text + "'");
                MessageBox.Show("Return Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox.Clear();
            }
        }
    }
}
