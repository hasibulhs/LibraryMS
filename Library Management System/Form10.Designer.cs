
namespace Library_Management_System
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.richt = new System.Windows.Forms.RichTextBox();
            this.bok = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.bprint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richt
            // 
            this.richt.BackColor = System.Drawing.Color.White;
            this.richt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richt.ForeColor = System.Drawing.Color.Black;
            this.richt.Location = new System.Drawing.Point(40, 36);
            this.richt.Name = "richt";
            this.richt.Size = new System.Drawing.Size(433, 460);
            this.richt.TabIndex = 0;
            this.richt.Text = "";
            // 
            // bok
            // 
            this.bok.BackColor = System.Drawing.Color.Black;
            this.bok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bok.FlatAppearance.BorderSize = 0;
            this.bok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bok.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.bok.Location = new System.Drawing.Point(40, 520);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(198, 46);
            this.bok.TabIndex = 12;
            this.bok.TabStop = false;
            this.bok.Text = "OK";
            this.bok.UseVisualStyleBackColor = false;
            this.bok.Click += new System.EventHandler(this.bok_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // bprint
            // 
            this.bprint.BackColor = System.Drawing.Color.Black;
            this.bprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bprint.FlatAppearance.BorderSize = 0;
            this.bprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bprint.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.bprint.Location = new System.Drawing.Point(275, 520);
            this.bprint.Name = "bprint";
            this.bprint.Size = new System.Drawing.Size(198, 46);
            this.bprint.TabIndex = 13;
            this.bprint.TabStop = false;
            this.bprint.Text = "PRINT";
            this.bprint.UseVisualStyleBackColor = false;
            this.bprint.Click += new System.EventHandler(this.bprint_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(519, 606);
            this.Controls.Add(this.bprint);
            this.Controls.Add(this.bok);
            this.Controls.Add(this.richt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richt;
        private System.Windows.Forms.Button bok;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button bprint;
    }
}