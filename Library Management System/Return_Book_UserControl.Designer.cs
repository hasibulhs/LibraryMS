
namespace Library_Management_System
{
    partial class Return_Book_UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.breturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(80, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Id :";
            // 
            // textBox
            // 
            this.textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(164, 78);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(381, 22);
            this.textBox.TabIndex = 1;
            // 
            // breturn
            // 
            this.breturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.breturn.BackColor = System.Drawing.Color.Snow;
            this.breturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.breturn.FlatAppearance.BorderSize = 0;
            this.breturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.breturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breturn.ForeColor = System.Drawing.Color.Black;
            this.breturn.Location = new System.Drawing.Point(224, 136);
            this.breturn.Name = "breturn";
            this.breturn.Size = new System.Drawing.Size(211, 42);
            this.breturn.TabIndex = 2;
            this.breturn.TabStop = false;
            this.breturn.Text = "Return";
            this.breturn.UseVisualStyleBackColor = false;
            this.breturn.Click += new System.EventHandler(this.breturn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(232, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 82);
            this.panel1.TabIndex = 6;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Lucida Fax", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Snow;
            this.title.Location = new System.Drawing.Point(54, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(203, 34);
            this.title.TabIndex = 3;
            this.title.Text = "Return Book";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.textBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.breturn);
            this.panel2.Location = new System.Drawing.Point(54, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 233);
            this.panel2.TabIndex = 7;
            // 
            // Return_Book_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Return_Book_UserControl";
            this.Size = new System.Drawing.Size(753, 581);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button breturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
    }
}
