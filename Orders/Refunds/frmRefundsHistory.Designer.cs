namespace Cafe_Management_System.Refunds
{
    partial class frmRefundsHistory
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
            this.components = new System.ComponentModel.Container();
            this.parrotFormHandle1 = new ReaLTaiizor.Controls.ParrotFormHandle();
            this.dgvRefunds = new System.Windows.Forms.DataGridView();
            this.cmsRefundHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefunds)).BeginInit();
            this.cmsRefundHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // parrotFormHandle1
            // 
            this.parrotFormHandle1.DockAtTop = true;
            this.parrotFormHandle1.HandleControl = this;
            // 
            // dgvRefunds
            // 
            this.dgvRefunds.AllowUserToAddRows = false;
            this.dgvRefunds.AllowUserToDeleteRows = false;
            this.dgvRefunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefunds.ContextMenuStrip = this.cmsRefundHistory;
            this.dgvRefunds.Location = new System.Drawing.Point(12, 185);
            this.dgvRefunds.Name = "dgvRefunds";
            this.dgvRefunds.ReadOnly = true;
            this.dgvRefunds.Size = new System.Drawing.Size(776, 229);
            this.dgvRefunds.TabIndex = 0;
            this.dgvRefunds.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRefunds_DataBindingComplete);
            // 
            // cmsRefundHistory
            // 
            this.cmsRefundHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem});
            this.cmsRefundHistory.Name = "cmsRefundHistory";
            this.cmsRefundHistory.Size = new System.Drawing.Size(110, 26);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Refunds History";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(127, 425);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(15, 16);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Rows:";
            // 
            // controlBox1
            // 
            this.controlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBox1.DefaultLocation = true;
            this.controlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBox1.EnableHoverHighlight = true;
            this.controlBox1.EnableMaximizeButton = false;
            this.controlBox1.EnableMinimizeButton = false;
            this.controlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.controlBox1.Location = new System.Drawing.Point(710, 0);
            this.controlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.controlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(90, 25);
            this.controlBox1.TabIndex = 9;
            this.controlBox1.Text = "controlBox1";
            // 
            // dpEnd
            // 
            this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEnd.Location = new System.Drawing.Point(290, 148);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(104, 20);
            this.dpEnd.TabIndex = 22;
            // 
            // dpStart
            // 
            this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStart.Location = new System.Drawing.Point(180, 148);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(104, 20);
            this.dpStart.TabIndex = 21;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "All",
            "Today",
            "Yesterday",
            "Last 7 Days",
            "Last 30 Days",
            "Custom"});
            this.cbFilter.Location = new System.Drawing.Point(15, 148);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(145, 21);
            this.cbFilter.TabIndex = 20;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // frmRefundsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.dpStart);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.controlBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRefunds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRefundsHistory";
            this.Text = "frmRefundsManagement";
            this.Load += new System.EventHandler(this.frmRefundsHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefunds)).EndInit();
            this.cmsRefundHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
        private System.Windows.Forms.DataGridView dgvRefunds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private System.Windows.Forms.ContextMenuStrip cmsRefundHistory;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}