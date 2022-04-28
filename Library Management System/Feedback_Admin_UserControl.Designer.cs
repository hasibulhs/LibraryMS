
namespace Library_Management_System
{
    partial class Feedback_Admin_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsatisfaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgimprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bview = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(208, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 82);
            this.panel1.TabIndex = 73;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Lucida Fax", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Snow;
            this.title.Location = new System.Drawing.Point(75, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(172, 34);
            this.title.TabIndex = 3;
            this.title.Text = "Feedbacks";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgfid,
            this.dgid,
            this.dgsatisfaction,
            this.dgimprove});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 374);
            this.dataGridView1.TabIndex = 75;
            // 
            // dgfid
            // 
            this.dgfid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgfid.HeaderText = "Feedback Id";
            this.dgfid.Name = "dgfid";
            // 
            // dgid
            // 
            this.dgid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgid.HeaderText = "User Id";
            this.dgid.Name = "dgid";
            // 
            // dgsatisfaction
            // 
            this.dgsatisfaction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgsatisfaction.HeaderText = "Satisfaction";
            this.dgsatisfaction.Name = "dgsatisfaction";
            // 
            // dgimprove
            // 
            this.dgimprove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgimprove.HeaderText = "Improvement";
            this.dgimprove.Name = "dgimprove";
            // 
            // bview
            // 
            this.bview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bview.BackColor = System.Drawing.Color.Black;
            this.bview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bview.FlatAppearance.BorderSize = 0;
            this.bview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bview.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.bview.Location = new System.Drawing.Point(309, 156);
            this.bview.Name = "bview";
            this.bview.Size = new System.Drawing.Size(121, 34);
            this.bview.TabIndex = 76;
            this.bview.TabStop = false;
            this.bview.Text = "View";
            this.bview.UseVisualStyleBackColor = false;
            this.bview.Click += new System.EventHandler(this.bview_Click);
            // 
            // Feedback_Admin_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.bview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Feedback_Admin_UserControl";
            this.Size = new System.Drawing.Size(753, 581);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsatisfaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgimprove;
        private System.Windows.Forms.Button bview;
    }
}
