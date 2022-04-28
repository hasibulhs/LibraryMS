
namespace Library_Management_System
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.bmore = new System.Windows.Forms.Button();
            this.blogout = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bhome = new System.Windows.Forms.Button();
            this.title2 = new System.Windows.Forms.Label();
            this.slidingpanel = new System.Windows.Forms.Panel();
            this.babout = new System.Windows.Forms.Button();
            this.bcom = new System.Windows.Forms.Button();
            this.slidingbutton = new System.Windows.Forms.Button();
            this.slidingpaneltimer = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contentpanel = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.paneltitle.SuspendLayout();
            this.slidingpanel.SuspendLayout();
            this.contentpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(132)))), ((int)(((byte)(127)))));
            this.paneltitle.Controls.Add(this.bmore);
            this.paneltitle.Controls.Add(this.blogout);
            this.paneltitle.Controls.Add(this.title);
            this.paneltitle.Controls.Add(this.panel2);
            this.paneltitle.Controls.Add(this.panel1);
            this.paneltitle.Controls.Add(this.bhome);
            this.paneltitle.Controls.Add(this.title2);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(993, 80);
            this.paneltitle.TabIndex = 1;
            // 
            // bmore
            // 
            this.bmore.BackColor = System.Drawing.Color.Transparent;
            this.bmore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmore.FlatAppearance.BorderSize = 0;
            this.bmore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmore.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmore.ForeColor = System.Drawing.Color.Black;
            this.bmore.Location = new System.Drawing.Point(847, 25);
            this.bmore.Name = "bmore";
            this.bmore.Size = new System.Drawing.Size(99, 25);
            this.bmore.TabIndex = 10;
            this.bmore.TabStop = false;
            this.bmore.Text = "More";
            this.bmore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bmore.UseVisualStyleBackColor = false;
            this.bmore.Click += new System.EventHandler(this.bmore_Click);
            // 
            // blogout
            // 
            this.blogout.BackColor = System.Drawing.Color.Transparent;
            this.blogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blogout.FlatAppearance.BorderSize = 0;
            this.blogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blogout.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blogout.ForeColor = System.Drawing.Color.Black;
            this.blogout.Location = new System.Drawing.Point(848, 50);
            this.blogout.Name = "blogout";
            this.blogout.Size = new System.Drawing.Size(99, 25);
            this.blogout.TabIndex = 9;
            this.blogout.TabStop = false;
            this.blogout.Text = "Log Out";
            this.blogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blogout.UseVisualStyleBackColor = false;
            this.blogout.Click += new System.EventHandler(this.blogout_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(850, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(37, 15);
            this.title.TabIndex = 7;
            this.title.Text = "title";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(840, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 60);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(238, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 60);
            this.panel1.TabIndex = 7;
            // 
            // bhome
            // 
            this.bhome.BackColor = System.Drawing.Color.Transparent;
            this.bhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bhome.FlatAppearance.BorderSize = 0;
            this.bhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bhome.Image = global::Library_Management_System.Properties.Resources.home2;
            this.bhome.Location = new System.Drawing.Point(3, 3);
            this.bhome.Name = "bhome";
            this.bhome.Size = new System.Drawing.Size(229, 74);
            this.bhome.TabIndex = 3;
            this.bhome.TabStop = false;
            this.bhome.UseVisualStyleBackColor = false;
            this.bhome.Click += new System.EventHandler(this.bhome_Click);
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.ForeColor = System.Drawing.Color.Snow;
            this.title2.Location = new System.Drawing.Point(306, 20);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(497, 38);
            this.title2.TabIndex = 2;
            this.title2.Text = "Library Management System";
            // 
            // slidingpanel
            // 
            this.slidingpanel.BackColor = System.Drawing.Color.CadetBlue;
            this.slidingpanel.Controls.Add(this.babout);
            this.slidingpanel.Controls.Add(this.bcom);
            this.slidingpanel.Controls.Add(this.slidingbutton);
            this.slidingpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingpanel.Location = new System.Drawing.Point(0, 80);
            this.slidingpanel.Name = "slidingpanel";
            this.slidingpanel.Size = new System.Drawing.Size(240, 581);
            this.slidingpanel.TabIndex = 2;
            // 
            // babout
            // 
            this.babout.BackColor = System.Drawing.Color.Transparent;
            this.babout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.babout.Dock = System.Windows.Forms.DockStyle.Top;
            this.babout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.babout.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babout.Image = global::Library_Management_System.Properties.Resources.aboutus1;
            this.babout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.babout.Location = new System.Drawing.Point(0, 105);
            this.babout.Name = "babout";
            this.babout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.babout.Size = new System.Drawing.Size(240, 45);
            this.babout.TabIndex = 3;
            this.babout.TabStop = false;
            this.babout.Text = "About Us";
            this.babout.UseVisualStyleBackColor = false;
            this.babout.Click += new System.EventHandler(this.babout_Click);
            // 
            // bcom
            // 
            this.bcom.BackColor = System.Drawing.Color.Transparent;
            this.bcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcom.Dock = System.Windows.Forms.DockStyle.Top;
            this.bcom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcom.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcom.Image = global::Library_Management_System.Properties.Resources.feedback1;
            this.bcom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcom.Location = new System.Drawing.Point(0, 60);
            this.bcom.Name = "bcom";
            this.bcom.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bcom.Size = new System.Drawing.Size(240, 45);
            this.bcom.TabIndex = 2;
            this.bcom.TabStop = false;
            this.bcom.Text = "Feedbacks";
            this.bcom.UseVisualStyleBackColor = false;
            this.bcom.Click += new System.EventHandler(this.bcom_Click);
            // 
            // slidingbutton
            // 
            this.slidingbutton.BackColor = System.Drawing.Color.Transparent;
            this.slidingbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidingbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.slidingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slidingbutton.Image = global::Library_Management_System.Properties.Resources.Left1;
            this.slidingbutton.Location = new System.Drawing.Point(0, 0);
            this.slidingbutton.Name = "slidingbutton";
            this.slidingbutton.Size = new System.Drawing.Size(240, 60);
            this.slidingbutton.TabIndex = 1;
            this.slidingbutton.TabStop = false;
            this.slidingbutton.UseVisualStyleBackColor = false;
            this.slidingbutton.Click += new System.EventHandler(this.slidingbutton_Click);
            // 
            // slidingpaneltimer
            // 
            this.slidingpaneltimer.Interval = 50;
            this.slidingpaneltimer.Tick += new System.EventHandler(this.slidingpaneltimer_Tick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // contentpanel
            // 
            this.contentpanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.contentpanel.BackgroundImage = global::Library_Management_System.Properties.Resources.backg1;
            this.contentpanel.Controls.Add(this.date);
            this.contentpanel.Controls.Add(this.time);
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(240, 80);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(753, 581);
            this.contentpanel.TabIndex = 3;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Snow;
            this.date.Location = new System.Drawing.Point(459, 471);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(79, 29);
            this.date.TabIndex = 11;
            this.date.Text = "label1";
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Snow;
            this.time.Location = new System.Drawing.Point(513, 437);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 37);
            this.time.TabIndex = 10;
            this.time.Text = "label1";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(993, 661);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.slidingpanel);
            this.Controls.Add(this.paneltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form12";
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.slidingpanel.ResumeLayout(false);
            this.contentpanel.ResumeLayout(false);
            this.contentpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Button bmore;
        private System.Windows.Forms.Button blogout;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bhome;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Panel slidingpanel;
        private System.Windows.Forms.Button slidingbutton;
        private System.Windows.Forms.Button bcom;
        private System.Windows.Forms.Button babout;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Timer slidingpaneltimer;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer;
    }
}