using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class About1_UserControl : UserControl
    {
        private static About1_UserControl obj1;

        public static About1_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new About1_UserControl();
                }

                return obj1;
            }
        }

        public About1_UserControl()
        {
            InitializeComponent();
        }
    }
}
