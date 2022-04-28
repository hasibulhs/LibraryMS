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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            title.Text = Form2.username;

            // Sliding Panel Initializations Start
            isSlidingPanelExpanded = true;
            expandSlidingPanel();
            // Sliding Panel Initializations End
        }

        // Sliding Panel Start
        public void expandSlidingPanel()
        {
            bcom.Text = "Feedbacks";
            babout.Text = "About Us";

            slidingbutton.Image = Properties.Resources.Left1;

            bcom.Image = null;
            babout.Image = null;
        }
        public void retractSlidingPanel()
        {
            bcom.Text = "";
            babout.Text = "";

            slidingbutton.Image = Properties.Resources.Right1;

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

        private void bhome_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form12 f12 = new Form12();
            f12.Show();
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

        private void bmore_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void bcom_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Feedback_Admin_UserControl.obj2))
            {
                contentpanel.Controls.Add(Feedback_Admin_UserControl.obj2);
                Feedback_Admin_UserControl.obj2.Dock = DockStyle.Fill;
                Feedback_Admin_UserControl.obj2.BringToFront();
            }

            else
            {
                Feedback_Admin_UserControl.obj2.BringToFront();
            }
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

        private void title_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }
    }
}
