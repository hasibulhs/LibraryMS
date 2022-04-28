
namespace Library_Management_System
{
    partial class Search_Admin_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsearch
            // 
            this.bsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bsearch.BackColor = System.Drawing.Color.Snow;
            this.bsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsearch.FlatAppearance.BorderSize = 0;
            this.bsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsearch.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsearch.ForeColor = System.Drawing.Color.Black;
            this.bsearch.Location = new System.Drawing.Point(154, 68);
            this.bsearch.Name = "bsearch";
            this.bsearch.Size = new System.Drawing.Size(211, 42);
            this.bsearch.TabIndex = 9;
            this.bsearch.TabStop = false;
            this.bsearch.Text = "Search";
            this.bsearch.UseVisualStyleBackColor = false;
            this.bsearch.Click += new System.EventHandler(this.bsearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin Id :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgname,
            this.dgaddress,
            this.dgcontact,
            this.dgemail,
            this.dggender});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 276);
            this.dataGridView1.TabIndex = 10;
            // 
            // dgid
            // 
            this.dgid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgid.HeaderText = "Id";
            this.dgid.Name = "dgid";
            // 
            // dgname
            // 
            this.dgname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgname.HeaderText = "Name";
            this.dgname.Name = "dgname";
            // 
            // dgaddress
            // 
            this.dgaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgaddress.HeaderText = "Address";
            this.dgaddress.Name = "dgaddress";
            // 
            // dgcontact
            // 
            this.dgcontact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcontact.HeaderText = "Contact No";
            this.dgcontact.Name = "dgcontact";
            // 
            // dgemail
            // 
            this.dgemail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgemail.HeaderText = "E-Mail";
            this.dgemail.Name = "dgemail";
            // 
            // dggender
            // 
            this.dggender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dggender.HeaderText = "Gender";
            this.dggender.Name = "dggender";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Lucida Fax", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Snow;
            this.title.Location = new System.Drawing.Point(48, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(228, 34);
            this.title.TabIndex = 3;
            this.title.Text = "Search Admin";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(217, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 82);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.textBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bsearch);
            this.panel3.Location = new System.Drawing.Point(113, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 127);
            this.panel3.TabIndex = 12;
            // 
            // textBox
            // 
            this.textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(123, 28);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(341, 22);
            this.textBox.TabIndex = 60;
            // 
            // Search_Admin_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Search_Admin_UserControl";
            this.Size = new System.Drawing.Size(753, 581);
            this.Load += new System.EventHandler(this.Search_Admin_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggender;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox;
    }
}
