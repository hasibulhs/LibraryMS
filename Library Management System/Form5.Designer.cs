
namespace Library_Management_System
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tpass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bregisteru = new System.Windows.Forms.Button();
            this.bloginu = new System.Windows.Forms.Button();
            this.tuser = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "User Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(48, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 27;
            // 
            // tpass
            // 
            this.tpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tpass.BackColor = System.Drawing.Color.CadetBlue;
            this.tpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tpass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpass.HideSelection = false;
            this.tpass.Location = new System.Drawing.Point(77, 244);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(221, 19);
            this.tpass.TabIndex = 25;
            this.tpass.TabStop = false;
            this.tpass.Text = "Password";
            this.tpass.Click += new System.EventHandler(this.tpass_Click);
            this.tpass.TextChanged += new System.EventHandler(this.tpass_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(48, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 24;
            // 
            // bregisteru
            // 
            this.bregisteru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bregisteru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bregisteru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bregisteru.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bregisteru.Location = new System.Drawing.Point(48, 363);
            this.bregisteru.Name = "bregisteru";
            this.bregisteru.Size = new System.Drawing.Size(250, 47);
            this.bregisteru.TabIndex = 20;
            this.bregisteru.TabStop = false;
            this.bregisteru.Text = "Register";
            this.bregisteru.UseVisualStyleBackColor = false;
            this.bregisteru.Click += new System.EventHandler(this.bregisteru_Click);
            // 
            // bloginu
            // 
            this.bloginu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bloginu.BackColor = System.Drawing.Color.Black;
            this.bloginu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bloginu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bloginu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloginu.ForeColor = System.Drawing.Color.CadetBlue;
            this.bloginu.Location = new System.Drawing.Point(48, 310);
            this.bloginu.Name = "bloginu";
            this.bloginu.Size = new System.Drawing.Size(250, 47);
            this.bloginu.TabIndex = 21;
            this.bloginu.TabStop = false;
            this.bloginu.Text = "Sign In";
            this.bloginu.UseVisualStyleBackColor = false;
            this.bloginu.Click += new System.EventHandler(this.bloginu_Click);
            // 
            // tuser
            // 
            this.tuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tuser.BackColor = System.Drawing.Color.CadetBlue;
            this.tuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tuser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuser.HideSelection = false;
            this.tuser.Location = new System.Drawing.Point(77, 196);
            this.tuser.Name = "tuser";
            this.tuser.Size = new System.Drawing.Size(221, 19);
            this.tuser.TabIndex = 19;
            this.tuser.TabStop = false;
            this.tuser.Text = "Username";
            this.tuser.Click += new System.EventHandler(this.tuser_Click);
            this.tuser.TextChanged += new System.EventHandler(this.tuser_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(48, 241);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(349, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bregisteru);
            this.Controls.Add(this.bloginu);
            this.Controls.Add(this.tuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bregisteru;
        private System.Windows.Forms.Button bloginu;
        private System.Windows.Forms.TextBox tuser;
    }
}