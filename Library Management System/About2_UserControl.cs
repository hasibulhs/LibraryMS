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
    public partial class About2_UserControl : UserControl
    {
        List<Panel> lp = new List<Panel>();
        int index;

        private static About2_UserControl obj1;

        public static About2_UserControl obj2
        {
            get
            {
                if (obj1 == null)
                {
                    obj1 = new About2_UserControl();
                }

                return obj1;
            }
        }

        public About2_UserControl()
        {
            InitializeComponent();
        }

        private void bnext_Click(object sender, EventArgs e)
        {
            if(index < lp.Count-1)
            {
                lp[++index].BringToFront();
            }
        }

        private void About2_UserControl_Load(object sender, EventArgs e)
        {
            lp.Add(panel2);
            lp.Add(panel3);
            lp.Add(panel4);
            lp[index].BringToFront();
        }

        private void bpre_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                lp[--index].BringToFront();
            }
        }
    }
}
