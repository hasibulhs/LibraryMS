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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            title.Text = Form2.username;
            customizeDesign();

            // Sliding Panel Initializations Start
            isSlidingPanelExpanded = true;
            expandSlidingPanel();
            // Sliding Panel Initializations End
        }

        //SubMenu Start
        private void customizeDesign()
        {
            paneladmin.Visible = false;
            paneluser.Visible = false;
            panelbook.Visible = false;
        }

        private void hideSubMenu()
        {
            if (paneladmin.Visible == true)
                paneladmin.Visible = false;

            if (paneluser.Visible == true)
                paneluser.Visible = false;

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

        private void badmin_Click(object sender, EventArgs e)
        {
            showSubMenu(paneladmin);
        }

        private void bviewadmin_Click(object sender, EventArgs e)
        {
            //title.Text = "View Admin";

            if (!contentpanel.Controls.Contains(View_Admin_UserControl.obj2))
            {
                contentpanel.Controls.Add(View_Admin_UserControl.obj2);
                View_Admin_UserControl.obj2.Dock = DockStyle.Fill;
                View_Admin_UserControl.obj2.BringToFront();
            }

            else
            {
                View_Admin_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void beditadmin_Click(object sender, EventArgs e)
        {
            //title.Text = "Edit Admin";

            if (!contentpanel.Controls.Contains(Edit_Admin_UserControl.obj2))
            {
                contentpanel.Controls.Add(Edit_Admin_UserControl.obj2);
                Edit_Admin_UserControl.obj2.Dock = DockStyle.Fill;
                Edit_Admin_UserControl.obj2.BringToFront();
            }

            else
            {
                Edit_Admin_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bsearchadmin_Click(object sender, EventArgs e)
        {
            //title.Text = "Search Admin";

            if (!contentpanel.Controls.Contains(Search_Admin_UserControl.obj2))
            {
                contentpanel.Controls.Add(Search_Admin_UserControl.obj2);
                Search_Admin_UserControl.obj2.Dock = DockStyle.Fill;
                Search_Admin_UserControl.obj2.BringToFront();
            }

            else
            {
                Search_Admin_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void buser_Click(object sender, EventArgs e)
        {
            showSubMenu(paneluser);
        }

        private void bviewuser_Click(object sender, EventArgs e)
        {
            //title.Text = "View User";

            if (!contentpanel.Controls.Contains(View_User_UserControl.obj2))
            {
                contentpanel.Controls.Add(View_User_UserControl.obj2);
                View_User_UserControl.obj2.Dock = DockStyle.Fill;
                View_User_UserControl.obj2.BringToFront();
            }

            else
            {
                View_User_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bedituser_Click(object sender, EventArgs e)
        {
            //title.Text = "Edit User";

            if (!contentpanel.Controls.Contains(Edit_User_UserControl.obj2))
            {
                contentpanel.Controls.Add(Edit_User_UserControl.obj2);
                Edit_User_UserControl.obj2.Dock = DockStyle.Fill;
                Edit_User_UserControl.obj2.BringToFront();
            }

            else
            {
                Edit_User_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bsearchuser_Click(object sender, EventArgs e)
        {
            //title.Text = "Search User";

            if (!contentpanel.Controls.Contains(Search_User_UserControl.obj2))
            {
                contentpanel.Controls.Add(Search_User_UserControl.obj2);
                Search_User_UserControl.obj2.Dock = DockStyle.Fill;
                Search_User_UserControl.obj2.BringToFront();
            }

            else
            {
                Search_User_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bbook_Click(object sender, EventArgs e)
        {
            showSubMenu(panelbook);
        }

        private void bviewbook_Click(object sender, EventArgs e)
        {
            //title.Text = "View Book";

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

        private void baddbook_Click(object sender, EventArgs e)
        {
            //title.Text = "Add Book";

            if (!contentpanel.Controls.Contains(Add_Book_UserControl.obj2))
            {
                contentpanel.Controls.Add(Add_Book_UserControl.obj2);
                Add_Book_UserControl.obj2.Dock = DockStyle.Fill;
                Add_Book_UserControl.obj2.BringToFront();
            }

            else
            {
                Add_Book_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void beditbook_Click(object sender, EventArgs e)
        {
            //title.Text = "Edit Book";

            if (!contentpanel.Controls.Contains(Edit_Books_UserControl.obj2))
            {
                contentpanel.Controls.Add(Edit_Books_UserControl.obj2);
                Edit_Books_UserControl.obj2.Dock = DockStyle.Fill;
                Edit_Books_UserControl.obj2.BringToFront();
            }

            else
            {
                Edit_Books_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bsearchbook_Click(object sender, EventArgs e)
        {
            //title.Text = "Search Book";

            if (!contentpanel.Controls.Contains(Search_Book_UserControl.obj2))
            {
                contentpanel.Controls.Add(Search_Book_UserControl.obj2);
                Search_Book_UserControl.obj2.Dock = DockStyle.Fill;
                Search_Book_UserControl.obj2.BringToFront();
            }

            else
            {
                Search_Book_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bissuebook_Click(object sender, EventArgs e)
        {
            //title.Text = "Issue Book";

            if (!contentpanel.Controls.Contains(Issue_Book_UserControl.obj2))
            {
                contentpanel.Controls.Add(Issue_Book_UserControl.obj2);
                Issue_Book_UserControl.obj2.Dock = DockStyle.Fill;
                Issue_Book_UserControl.obj2.BringToFront();
            }

            else
            {
                Issue_Book_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bissuelist_Click(object sender, EventArgs e)
        {
            //title.Text = "Issue List";

            if (!contentpanel.Controls.Contains(Issue_List_UserControl.obj2))
            {
                contentpanel.Controls.Add(Issue_List_UserControl.obj2);
                Issue_List_UserControl.obj2.Dock = DockStyle.Fill;
                Issue_List_UserControl.obj2.BringToFront();
            }

            else
            {
                Issue_List_UserControl.obj2.BringToFront();
            }

            //hideSubMenu();
        }

        private void bsetting_Click(object sender, EventArgs e)
        {
            //title.Text = "Change Password";

            if (!contentpanel.Controls.Contains(Change_Pass_Admin_UserControl.obj2))
            {
                contentpanel.Controls.Add(Change_Pass_Admin_UserControl.obj2);
                Change_Pass_Admin_UserControl.obj2.Dock = DockStyle.Fill;
                Change_Pass_Admin_UserControl.obj2.BringToFront();
            }

            else
            {
                Change_Pass_Admin_UserControl.obj2.BringToFront();
            }

            hideSubMenu();
        }

        // Sliding Panel Start
        public void expandSlidingPanel()
        {
            badmin.Text = "Admin Section";
            bviewadmin.Text = "View Admin";
            beditadmin.Text = "Edit Admin";
            bsearchadmin.Text = "Search Admin";

            buser.Text = "User Section";
            bviewuser.Text = "View User";
            bedituser.Text = "Edit User";
            bsearchuser.Text = "Search User";

            bbook.Text = "Book Section";
            bviewbook.Text = "View Book";
            baddbook.Text = "Add Book";
            beditbook.Text = "Edit Book";
            bsearchbook.Text = "Search Book";
            bissuebook.Text = "Issue Book";
            bissuelist.Text = "Issue List";

            bsetting.Text = "Reset Password";

            slidingbutton.Image = Properties.Resources.Left1;

            badmin.Image = null;
            bviewadmin.Image = null;
            beditadmin.Image = null;
            bsearchadmin.Image = null;

            buser.Image = null;
            bviewuser.Image = null;
            bedituser.Image = null;
            bsearchuser.Image = null;

            bbook.Image = null;
            bviewbook.Image = null;
            baddbook.Image = null;
            beditbook.Image = null;
            bsearchbook.Image = null;
            bissuebook.Image = null;
            bissuelist.Image = null;

            bsetting.Image = null;
        }
        public void retractSlidingPanel()
        {
            badmin.Text = "";
            bviewadmin.Text = "";
            beditadmin.Text = "";
            bsearchadmin.Text = "";

            buser.Text = "";
            bviewuser.Text = "";
            bedituser.Text = "";
            bsearchuser.Text = "";

            bbook.Text = "";
            bviewbook.Text = "";
            baddbook.Text = "";
            beditbook.Text = "";
            bsearchbook.Text = "";
            bissuebook.Text = "";
            bissuelist.Text = "";

            bsetting.Text = "";

            slidingbutton.Image = Properties.Resources.Right1;

            badmin.Image = Properties.Resources.admin1;
            bviewadmin.Image = Properties.Resources.admin2;
            beditadmin.Image = Properties.Resources.editadmin2;
            bsearchadmin.Image = Properties.Resources.search4;

            buser.Image = Properties.Resources.user11;
            bviewuser.Image = Properties.Resources.user2;
            bedituser.Image = Properties.Resources.edituser21;
            bsearchuser.Image = Properties.Resources.search4;

            bbook.Image = Properties.Resources.book3;
            bviewbook.Image = Properties.Resources.books4;
            baddbook.Image = Properties.Resources.bookadd4;
            beditbook.Image = Properties.Resources.bookedit4;
            bsearchbook.Image = Properties.Resources.search4;
            bissuebook.Image = Properties.Resources.issuebook4;
            bissuelist.Image = Properties.Resources.issuelist2;

            bsetting.Image = Properties.Resources.setting3;
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

        private void bhome_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
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

        private void title_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void bmore_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void date_Click(object sender, EventArgs e)
        {

        }
    }
}
