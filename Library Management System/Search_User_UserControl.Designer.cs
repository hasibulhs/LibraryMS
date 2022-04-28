
namespace Library_Management_System
{
    partial class Search_User_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
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
            this.bsearch.Location = new System.Drawing.Point(157, 63);
            this.bsearch.Name = "bsearch";
            this.bsearch.Size = new System.Drawing.Size(211, 42);
            this.bsearch.TabIndex = 13;
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
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Id :";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 275);
            this.dataGridView1.TabIndex = 14;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(224, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 82);
            this.panel2.TabIndex = 15;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Lucida Fax", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Snow;
            this.title.Location = new System.Drawing.Point(62, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(198, 34);
            this.title.TabIndex = 3;
            this.title.Text = "Search User";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.textBox);
            this.panel3.Controls.Add(this.bsearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(125, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 123);
            this.panel3.TabIndex = 16;
            // 
            // textBox
            // 
            this.textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(104, 25);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(372, 22);
            this.textBox.TabIndex = 61;
            // 
            // Search_User_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Search_User_UserControl";
            this.Size = new System.Drawing.Size(753, 581);
            this.Load += new System.EventHandler(this.Search_User_UserControl_Load);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox;
    }
}
