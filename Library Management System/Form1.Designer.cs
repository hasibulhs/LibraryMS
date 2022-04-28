
namespace Library_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.badmin = new System.Windows.Forms.Button();
            this.buser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // badmin
            // 
            this.badmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.badmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.badmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badmin.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badmin.ForeColor = System.Drawing.Color.Black;
            this.badmin.Image = ((System.Drawing.Image)(resources.GetObject("badmin.Image")));
            this.badmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.badmin.Location = new System.Drawing.Point(158, 173);
            this.badmin.Name = "badmin";
            this.badmin.Size = new System.Drawing.Size(167, 66);
            this.badmin.TabIndex = 0;
            this.badmin.TabStop = false;
            this.badmin.Text = "Admin";
            this.badmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.badmin.UseVisualStyleBackColor = false;
            this.badmin.Click += new System.EventHandler(this.badmin_Click);
            // 
            // buser
            // 
            this.buser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buser.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buser.ForeColor = System.Drawing.Color.Black;
            this.buser.Image = ((System.Drawing.Image)(resources.GetObject("buser.Image")));
            this.buser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buser.Location = new System.Drawing.Point(175, 245);
            this.buser.Name = "buser";
            this.buser.Size = new System.Drawing.Size(133, 66);
            this.buser.TabIndex = 1;
            this.buser.TabStop = false;
            this.buser.Text = "User";
            this.buser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buser.UseVisualStyleBackColor = false;
            this.buser.Click += new System.EventHandler(this.buser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(-6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(0, 411);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "\"A ROOM WITHOUT BOOKS IS LIKE A BODY WTHOUT A SOUL\" - CICERO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(488, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buser);
            this.Controls.Add(this.badmin);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button badmin;
        private System.Windows.Forms.Button buser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

