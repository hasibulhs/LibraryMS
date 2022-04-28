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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            label.Text = Form2.username;
            customizeDesign();

            // Sliding Panel Initializations Start
            isSlidingPanelExpanded = true;
            expandSlidingPanel();
            // Sliding Panel Initializations End
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        //SubMenu Start
        private void customizeDesign()
        {
            panelbook.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelbook.Visible == true)
                panelbook.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        //SubMenu End

        // Sliding Panel Start
        public void expandSlidingPanel()
        {
            badmin.Text = "Admins";

            bbook.Text = "Book Section";
            bviewbooks.Text = "View Books";
            bissuedbooks.Text = "Issued Books";
            breturnbook.Text = "Return Book";

            bsetting.Text = "Reset Password";

            bcom.Text = "Feedback";
            babout.Text = "About Us";

            slidingbutton.Image = Properties.Resources.Left1;

            badmin.Image = null;

            bbook.Image = null;
            bviewbooks.Image = null;
            bissuedbooks.Image = null;
            breturnbook.Image = null;

            bsetting.Image = null;

            bcom.Image = null;
            babout.Image = null;
        }
        public void retractSlidingPanel()
        {
            badmin.Text = "";

            bbook.Text = "";
            bviewbooks.Text = "";
            bissuedbooks.Text = "";
            breturnbook.Text = "";

            bsetting.Text = "";

            bcom.Text = "";
            babout.Text = "";

            slidingbutton.Image = Properties.Resources.Right1;

            badmin.Image = Properties.Resources.admin1;

            bbook.Image = Properties.Resources.book3;
            bviewbooks.Image = Properties.Resources.books4;
            bissuedbooks.Image = Properties.Resources.issuelist2;
            breturnbook.Image = Properties.Resources.returnbook1;

            bsetting.Image = Properties.Resources.setting3;

            bcom.Image = Properties.Resources.feedback1;
            babout.Image = Properties.Resources.aboutus1;
        }

        bool isSlidingPanelExpanded;
        const int maxSliderWidth = 240;
        const int minSliderWidth = 90;

        private void slidingbutton_Click(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //retractSlidingPanel();
            }
            slidingpaneltimer.Start();
        }

        private void slidingpaneltimer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                // retract panel
                slidingpanel.Width -= 30;

                if (slidingpanel.Width <= minSliderWidth)
                {
                    // stop retracting
                    isSlidingPanelExpanded = false;
                    slidingpaneltimer.Stop();
                    retractSlidingPanel();
                    slidingbutton.Width = 90;

                    this.Refresh();
                }
            }

            else
            {
                // expand panel
                slidingbutton.Width = 240;
                slidingpanel.Width += 30;

                if (slidingpanel.Width >= maxSliderWidth)
                {
                    // stop expanding
                    isSlidingPanelExpanded = true;
                    slidingpaneltimer.Stop();
                    expandSlidingPanel();

                    this.Refresh();
                }
            }
        }
        // Sliding Panel End

        private void timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:mm:ss");
            date.Text = DateTime.Now.ToString("dddd, dd MMM yyyy");
        }

        private void badmin_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            //title.Text = "Admins";

            if (!contentpanel.Controls.Contains(Admins_UserControl.obj2))
            {
                contentpanel.Controls.Add(Admins_UserControl.obj2);
                Admins_UserControl.obj2.Dock = DockStyle.Fill;
                Admins_UserControl.obj2.BringToFront();
            }

            else
            {
                Admins_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bbook_Click(object sender, EventArgs e)
        {
            showSubMenu(panelbook);
        }

        private void bviewbooks_Click(object sender, EventArgs e)
        {
            //title.Text = "View Books";

            if (!contentpanel.Controls.Contains(View_Book_UserControl1.obj2))
            {
                contentpanel.Controls.Add(View_Book_UserControl1.obj2);
                View_Book_UserControl1.obj2.Dock = DockStyle.Fill;
                View_Book_UserControl1.obj2.BringToFront();
            }

            else
            {
                View_Book_UserControl1.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bissuedbooks_Click(object sender, EventArgs e)
        {
            //title.Text = "Issued Books";

            if (!contentpanel.Controls.Contains(Issued_Books_UserControl.obj2))
            {
                contentpanel.Controls.Add(Issued_Books_UserControl.obj2);
                Issued_Books_UserControl.obj2.Dock = DockStyle.Fill;
                Issued_Books_UserControl.obj2.BringToFront();
            }

            else
            {
                Issued_Books_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void breturnbook_Click(object sender, EventArgs e)
        {
            //title.Text = "Return Book";

            if (!contentpanel.Controls.Contains(Return_Book_UserControl.obj2))
            {
                contentpanel.Controls.Add(Return_Book_UserControl.obj2);
                Return_Book_UserControl.obj2.Dock = DockStyle.Fill;
                Return_Book_UserControl.obj2.BringToFront();
            }

            else
            {
                Return_Book_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bsetting_Click(object sender, EventArgs e)
        {
            //title.Text = "Change Password";

            if (!contentpanel.Controls.Contains(Change_Pass_User_UserControl.obj2))
            {
                contentpanel.Controls.Add(Change_Pass_User_UserControl.obj2);
                Change_Pass_User_UserControl.obj2.Dock = DockStyle.Fill;
                Change_Pass_User_UserControl.obj2.BringToFront();
            }

            else
            {
                Change_Pass_User_UserControl.obj2.BringToFront();
            }

            hideSubMenu();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private void bhome_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void blogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Log Out ?", "Log Out", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void bcom_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Feedback_User_UserControl.obj2))
            {
                contentpanel.Controls.Add(Feedback_User_UserControl.obj2);
                Feedback_User_UserControl.obj2.Dock = DockStyle.Fill;
                Feedback_User_UserControl.obj2.BringToFront();
            }

            else
            {
                Feedback_User_UserControl.obj2.BringToFront();
            }

            hideSubMenu();
        }

        private void babout_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(About2_UserControl.obj2))
            {
                contentpanel.Controls.Add(About2_UserControl.obj2);
                About2_UserControl.obj2.Dock = DockStyle.Fill;
                About2_UserControl.obj2.BringToFront();
            }

            else
            {
                About2_UserControl.obj2.BringToFront();
            }
        }
    }
}
