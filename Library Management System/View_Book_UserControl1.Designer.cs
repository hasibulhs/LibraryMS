
namespace Library_Management_System
{
    partial class View_Book_UserControl1
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
            this.bgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgauthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
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
            this.bgid,
            this.bgname,
            this.bgauthor,
            this.bgprice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 346);
            this.dataGridView1.TabIndex = 1;
            // 
            // bgid
            // 
            this.bgid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bgid.HeaderText = "Book Id";
            this.bgid.Name = "bgid";
            // 
            // bgname
            // 
            this.bgname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bgname.HeaderText = "Book Name";
            this.bgname.Name = "bgname";
            // 
            // bgauthor
            // 
            this.bgauthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bgauthor.HeaderText = "Author";
            this.bgauthor.Name = "bgauthor";
            // 
            // bgprice
            // 
            this.bgprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bgprice.HeaderText = "Price";
            this.bgprice.Name = "bgprice";
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.Black;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.b1.Location = new System.Drawing.Point(73, 171);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(152, 45);
            this.b1.TabIndex = 2;
            this.b1.TabStop = false;
            this.b1.Text = "Science";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b2.BackColor = System.Drawing.Color.Black;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.b2.Location = new System.Drawing.Point(231, 171);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(152, 45);
            this.b2.TabIndex = 3;
            this.b2.TabStop = false;
            this.b2.Text = "Mystery";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b3.BackColor = System.Drawing.Color.Black;
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.b3.Location = new System.Drawing.Point(389, 171);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(152, 45);
            this.b3.TabIndex = 4;
            this.b3.TabStop = false;
            this.b3.Text = "Story";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b4.BackColor = System.Drawing.Color.Black;
            this.b4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b4.FlatAppearance.BorderSize = 0;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.b4.Location = new System.Drawing.Point(547, 171);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(152, 45);
            this.b4.TabIndex = 5;
            this.b4.TabStop = false;
            this.b4.Text = "Educational";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(230, 19);
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
            this.title.Location = new System.Drawing.Point(73, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(171, 34);
            this.title.TabIndex = 3;
            this.title.Text = "View Book";
            // 
            // View_Book_UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Book_UserControl1";
            this.Size = new System.Drawing.Size(753, 581);
            this.Load += new System.EventHandler(this.View_Book_UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgauthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgprice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
    }
}
