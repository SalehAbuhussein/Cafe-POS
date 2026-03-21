namespace Cafe_Management_System.Orders
{
    partial class frmOrderManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.cmsOrders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.refundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refundHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.parrotFormHandle1 = new ReaLTaiizor.Controls.ParrotFormHandle();
            this.controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.cmsOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders Management";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(127, 384);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(15, 16);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of Rows:";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Cafe_Management_System.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(742, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.cbFilter.Location = new System.Drawing.Point(12, 130);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(145, 21);
            this.cbFilter.TabIndex = 9;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.ContextMenuStrip = this.cmsOrders;
            this.dgvOrders.Location = new System.Drawing.Point(12, 163);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(793, 211);
            this.dgvOrders.TabIndex = 8;
            this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick);
            this.dgvOrders.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrders_DataBindingComplete);
            // 
            // cmsOrders
            // 
            this.cmsOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.refundToolStripMenuItem,
            this.refundHistoryToolStripMenuItem});
            this.cmsOrders.Name = "cmsOrders";
            this.cmsOrders.Size = new System.Drawing.Size(154, 76);
            this.cmsOrders.Opening += new System.ComponentModel.CancelEventHandler(this.cmsOrders_Opening);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // refundToolStripMenuItem
            // 
            this.refundToolStripMenuItem.Name = "refundToolStripMenuItem";
            this.refundToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.refundToolStripMenuItem.Text = "Refund";
            this.refundToolStripMenuItem.Click += new System.EventHandler(this.refundToolStripMenuItem_Click);
            // 
            // refundHistoryToolStripMenuItem
            // 
            this.refundHistoryToolStripMenuItem.Name = "refundHistoryToolStripMenuItem";
            this.refundHistoryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.refundHistoryToolStripMenuItem.Text = "Refund History";
            this.refundHistoryToolStripMenuItem.Click += new System.EventHandler(this.refundHistoryToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(611, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Sales:";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.White;
            this.lblTotalSales.Location = new System.Drawing.Point(692, 384);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(15, 16);
            this.lblTotalSales.TabIndex = 15;
            this.lblTotalSales.Text = "0";
            // 
            // parrotFormHandle1
            // 
            this.parrotFormHandle1.DockAtTop = true;
            this.parrotFormHandle1.HandleControl = this;
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
            this.controlBox1.Location = new System.Drawing.Point(727, 0);
            this.controlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.controlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(90, 25);
            this.controlBox1.TabIndex = 16;
            this.controlBox1.Text = "controlBox1";
            // 
            // dpStart
            // 
            this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStart.Location = new System.Drawing.Point(177, 130);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(104, 20);
            this.dpStart.TabIndex = 18;
            this.dpStart.ValueChanged += new System.EventHandler(this.dp_ValueChanged);
            // 
            // dpEnd
            // 
            this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEnd.Location = new System.Drawing.Point(287, 130);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(104, 20);
            this.dpEnd.TabIndex = 19;
            this.dpEnd.ValueChanged += new System.EventHandler(this.dp_ValueChanged);
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 410);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.dpStart);
            this.Controls.Add(this.controlBox1);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderManagement";
            this.Text = "Orders Management";
            this.Load += new System.EventHandler(this.frmOrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.cmsOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.ContextMenuStrip cmsOrders;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refundToolStripMenuItem;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private System.Windows.Forms.ToolStripMenuItem refundHistoryToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.DateTimePicker dpStart;
    }
}