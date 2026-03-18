namespace Cafe_Management_System.Users
{
    partial class frmAddUpdateUser
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
            this.controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbUserInfo = new ReaLTaiizor.Controls.CrownGroupBox();
            this.tbConfirmPassword = new ReaLTaiizor.Controls.SmallTextBox();
            this.crownLabel9 = new ReaLTaiizor.Controls.CrownLabel();
            this.tbPassword = new ReaLTaiizor.Controls.SmallTextBox();
            this.crownLabel8 = new ReaLTaiizor.Controls.CrownLabel();
            this.tbUsername = new ReaLTaiizor.Controls.SmallTextBox();
            this.crownLabel7 = new ReaLTaiizor.Controls.CrownLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonInfo1 = new Cafe_Management_System.Users.Controls.ctrlPersonInfo();
            this.gbUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.controlBox1.Location = new System.Drawing.Point(584, 0);
            this.controlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.controlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(90, 25);
            this.controlBox1.TabIndex = 0;
            this.controlBox1.Text = "controlBox1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(265, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Add User";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(584, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbUserInfo.Controls.Add(this.tbConfirmPassword);
            this.gbUserInfo.Controls.Add(this.crownLabel9);
            this.gbUserInfo.Controls.Add(this.tbPassword);
            this.gbUserInfo.Controls.Add(this.crownLabel8);
            this.gbUserInfo.Controls.Add(this.tbUsername);
            this.gbUserInfo.Controls.Add(this.crownLabel7);
            this.gbUserInfo.Location = new System.Drawing.Point(12, 373);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(650, 176);
            this.gbUserInfo.TabIndex = 14;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User Info";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbConfirmPassword.CustomBGColor = System.Drawing.Color.White;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbConfirmPassword.Location = new System.Drawing.Point(469, 113);
            this.tbConfirmPassword.MaxLength = 20;
            this.tbConfirmPassword.Multiline = false;
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.ReadOnly = false;
            this.tbConfirmPassword.Size = new System.Drawing.Size(127, 28);
            this.tbConfirmPassword.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.tbConfirmPassword.TabIndex = 10;
            this.tbConfirmPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbConfirmPassword.UseSystemPasswordChar = false;
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // crownLabel9
            // 
            this.crownLabel9.AutoSize = true;
            this.crownLabel9.BackColor = System.Drawing.Color.Transparent;
            this.crownLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel9.ForeColor = System.Drawing.Color.White;
            this.crownLabel9.Location = new System.Drawing.Point(319, 118);
            this.crownLabel9.Name = "crownLabel9";
            this.crownLabel9.Size = new System.Drawing.Size(136, 18);
            this.crownLabel9.TabIndex = 11;
            this.crownLabel9.Text = "Confirm Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbPassword.CustomBGColor = System.Drawing.Color.White;
            this.tbPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbPassword.Location = new System.Drawing.Point(469, 36);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = false;
            this.tbPassword.Size = new System.Drawing.Size(127, 28);
            this.tbPassword.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.tbPassword.TabIndex = 9;
            this.tbPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.UseSystemPasswordChar = false;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // crownLabel8
            // 
            this.crownLabel8.AutoSize = true;
            this.crownLabel8.BackColor = System.Drawing.Color.Transparent;
            this.crownLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel8.ForeColor = System.Drawing.Color.White;
            this.crownLabel8.Location = new System.Drawing.Point(378, 41);
            this.crownLabel8.Name = "crownLabel8";
            this.crownLabel8.Size = new System.Drawing.Size(79, 18);
            this.crownLabel8.TabIndex = 9;
            this.crownLabel8.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbUsername.CustomBGColor = System.Drawing.Color.White;
            this.tbUsername.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbUsername.ForeColor = System.Drawing.Color.DimGray;
            this.tbUsername.Location = new System.Drawing.Point(108, 36);
            this.tbUsername.MaxLength = 125;
            this.tbUsername.Multiline = false;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = false;
            this.tbUsername.Size = new System.Drawing.Size(127, 28);
            this.tbUsername.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.tbUsername.TabIndex = 8;
            this.tbUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsername.UseSystemPasswordChar = false;
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // crownLabel7
            // 
            this.crownLabel7.AutoSize = true;
            this.crownLabel7.BackColor = System.Drawing.Color.Transparent;
            this.crownLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel7.ForeColor = System.Drawing.Color.White;
            this.crownLabel7.Location = new System.Drawing.Point(17, 41);
            this.crownLabel7.Name = "crownLabel7";
            this.crownLabel7.Size = new System.Drawing.Size(81, 18);
            this.crownLabel7.TabIndex = 7;
            this.crownLabel7.Text = "Username:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(12, 143);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(653, 196);
            this.ctrlPersonInfo1.TabIndex = 15;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(674, 623);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.controlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateUser";
            this.Text = "frmAddUpdateUser";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private ReaLTaiizor.Controls.CrownGroupBox gbUserInfo;
        private ReaLTaiizor.Controls.SmallTextBox tbConfirmPassword;
        private ReaLTaiizor.Controls.CrownLabel crownLabel9;
        private ReaLTaiizor.Controls.SmallTextBox tbPassword;
        private ReaLTaiizor.Controls.CrownLabel crownLabel8;
        private ReaLTaiizor.Controls.SmallTextBox tbUsername;
        private ReaLTaiizor.Controls.CrownLabel crownLabel7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controls.ctrlPersonInfo ctrlPersonInfo1;
    }
}