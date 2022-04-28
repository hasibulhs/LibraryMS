
namespace Library_Management_System
{
    partial class Issued_Books_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgissueid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgissuedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgduedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgissueid,
            this.dgbookid,
            this.dgbookname,
            this.dgissuedate,
            this.dgduedate});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgissueid
            // 
            this.dgissueid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgissueid.HeaderText = "Issue Id";
            this.dgissueid.Name = "dgissueid";
            // 
            // dgbookid
            // 
            this.dgbookid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgbookid.HeaderText = "Book Id";
            this.dgbookid.Name = "dgbookid";
            // 
            // dgbookname
            // 
            this.dgbookname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgbookname.HeaderText = "Book Name";
            this.dgbookname.Name = "dgbookname";
            // 
            // dgissuedate
            // 
            this.dgissuedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgissuedate.HeaderText = "Issue Date";
            this.dgissuedate.Name = "dgissuedate";
            // 
            // dgduedate
            // 
            this.dgduedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgduedate.HeaderText = "Due Date";
            this.dgduedate.Name = "dgduedate";
            // 
            // bview
            // 
            this.bview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bview.BackColor = System.Drawing.Color.Black;
            this.bview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bview.FlatAppearance.BorderSize = 0;
            this.bview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bview.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.bview.Location = new System.Drawing.Point(338, 163);
            this.bview.Name = "bview";
            this.bview.Size = new System.Drawing.Size(121, 34);
            this.bview.TabIndex = 1;
            this.bview.TabStop = false;
            this.bview.Text = "VIEW";
            this.bview.UseVisualStyleBackColor = false;
            this.bview.Click += new System.EventHandler(this.bview_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(235, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 82);
            this.panel1.TabIndex = 5;
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
            this.title.Size = new System.Drawing.Size(210, 34);
            this.title.TabIndex = 3;
            this.title.Text = "Issued Books";
            // 
            // Issued_Books_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bview);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Issued_Books_UserControl";
            this.Size = new System.Drawing.Size(753, 581);
            this.Load += new System.EventHandler(this.Issued_Books_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgissueid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgissuedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgduedate;
        private System.Windows.Forms.Button bview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
    }
}
