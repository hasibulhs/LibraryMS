
namespace Library_Management_System
{
    partial class Change_Pass_User_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.bchangepass = new System.Windows.Forms.Button();
            this.tconfirmpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tnewpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toldpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgo = new System.Windows.Forms.Button();
            this.tid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.Controls.Add(this.bchangepass);
            this.panel.Controls.Add(this.tconfirmpass);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.Tnewpass);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(96, 342);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(566, 180);
            this.panel.TabIndex = 5;
            // 
            // bchangepass
            // 
            this.bchangepass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bchangepass.BackColor = System.Drawing.Color.Snow;
            this.bchangepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bchangepass.FlatAppearance.BorderSize = 0;
            this.bchangepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bchangepass.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bchangepass.Location = new System.Drawing.Point(224, 114);
            this.bchangepass.Name = "bchangepass";
            this.bchangepass.Size = new System.Drawing.Size(219, 42);
            this.bchangepass.TabIndex = 6;
            this.bchangepass.TabStop = false;
            this.bchangepass.Text = "Change Passward";
            this.bchangepass.UseVisualStyleBackColor = false;
            this.bchangepass.Click += new System.EventHandler(this.bchangepass_Click);
            // 
            // tconfirmpass
            // 
            this.tconfirmpass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tconfirmpass.Location = new System.Drawing.Point(224, 60);
            this.tconfirmpass.Name = "tconfirmpass";
            this.tconfirmpass.Size = new System.Drawing.Size(329, 22);
            this.tconfirmpass.TabIndex = 5;
            this.tconfirmpass.TextChanged += new System.EventHandler(this.tconfirmpass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm New Passward :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Tnewpass
            // 
            this.Tnewpass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnewpass.Location = new System.Drawing.Point(224, 25);
            this.Tnewpass.Name = "Tnewpass";
            this.Tnewpass.Size = new System.Drawing.Size(329, 22);
            this.Tnewpass.TabIndex = 3;
            this.Tnewpass.TextChanged += new System.EventHandler(this.Tnewpass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter New Passward :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toldpass
            // 
            this.toldpass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toldpass.Location = new System.Drawing.Point(224, 59);
            this.toldpass.Name = "toldpass";
            this.toldpass.Size = new System.Drawing.Size(323, 22);
            this.toldpass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Current Passward :";
            // 
            // bgo
            // 
            this.bgo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bgo.BackColor = System.Drawing.Color.Snow;
            this.bgo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bgo.FlatAppearance.BorderSize = 0;
            this.bgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgo.ForeColor = System.Drawing.Color.Black;
            this.bgo.Location = new System.Drawing.Point(224, 102);
            this.bgo.Name = "bgo";
            this.bgo.Size = new System.Drawing.Size(99, 26);
            this.bgo.TabIndex = 6;
            this.bgo.Text = "GO";
            this.bgo.UseVisualStyleBackColor = false;
            this.bgo.Click += new System.EventHandler(this.bgo_Click);
            // 
            // tid
            // 
            this.tid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tid.Location = new System.Drawing.Point(224, 24);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(323, 22);
            this.tid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(14, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(226, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 82);
            this.panel1.TabIndex = 12;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Lucida Fax", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Snow;
            this.title.Location = new System.Drawing.Point(21, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(285, 34);
            this.title.TabIndex = 3;
            this.title.Text = "Change Password";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bgo);
            this.panel2.Controls.Add(this.tid);
            this.panel2.Controls.Add(this.toldpass);
            this.panel2.Location = new System.Drawing.Point(96, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 158);
            this.panel2.TabIndex = 13;
            // 
            // Change_Pass_User_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Name = "Change_Pass_User_UserControl";
            this.Size = new System.Drawing.Size(753, 581);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button bchangepass;
        private System.Windows.Forms.TextBox tconfirmpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tnewpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toldpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bgo;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
    }
}
