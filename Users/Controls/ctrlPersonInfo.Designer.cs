namespace Cafe_Management_System.Users.Controls
{
    partial class ctrlPersonInfo
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
            this.components = new System.ComponentModel.Container();
            this.gbPersonInfo = new ReaLTaiizor.Controls.CrownGroupBox();
            this.tbPhone = new ReaLTaiizor.Controls.SmallTextBox();
            this.crownLabel6 = new ReaLTaiizor.Controls.CrownLabel();
            this.rbFemale = new ReaLTaiizor.Controls.CrownRadioButton();
            this.rbMale = new ReaLTaiizor.Controls.CrownRadioButton();
            this.crownLabel5 = new ReaLTaiizor.Controls.CrownLabel();
            this.tbLastName = new ReaLTaiizor.Controls.SmallTextBox();
            this.tbSecondName = new ReaLTaiizor.Controls.SmallTextBox();
            this.tbThirdName = new ReaLTaiizor.Controls.SmallTextBox();
            this.tbFirstName = new ReaLTaiizor.Controls.SmallTextBox();
            this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbPersonInfo.Controls.Add(this.tbPhone);
            this.gbPersonInfo.Controls.Add(this.crownLabel6);
            this.gbPersonInfo.Controls.Add(this.rbFemale);
            this.gbPersonInfo.Controls.Add(this.rbMale);
            this.gbPersonInfo.Controls.Add(this.crownLabel5);
            this.gbPersonInfo.Controls.Add(this.tbLastName);
            this.gbPersonInfo.Controls.Add(this.tbSecondName);
            this.gbPersonInfo.Controls.Add(this.tbThirdName);
            this.gbPersonInfo.Controls.Add(this.tbFirstName);
            this.gbPersonInfo.Controls.Add(this.crownLabel4);
            this.gbPersonInfo.Controls.Add(this.crownLabel3);
            this.gbPersonInfo.Controls.Add(this.crownLabel1);
            this.gbPersonInfo.Controls.Add(this.crownLabel2);
            this.gbPersonInfo.Location = new System.Drawing.Point(0, 0);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(653, 196);
            this.gbPersonInfo.TabIndex = 5;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Person Info";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.Transparent;
            this.tbPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbPhone.CustomBGColor = System.Drawing.Color.White;
            this.tbPhone.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbPhone.ForeColor = System.Drawing.Color.DimGray;
            this.tbPhone.Location = new System.Drawing.Point(469, 135);
            this.tbPhone.MaxLength = 25;
            this.tbPhone.Multiline = false;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = false;
            this.tbPhone.Size = new System.Drawing.Size(127, 28);
            this.tbPhone.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.tbPhone.TabIndex = 7;
            this.tbPhone.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPhone.UseSystemPasswordChar = false;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // crownLabel6
            // 
            this.crownLabel6.AutoSize = true;
            this.crownLabel6.BackColor = System.Drawing.Color.Transparent;
            this.crownLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel6.ForeColor = System.Drawing.Color.White;
            this.crownLabel6.Location = new System.Drawing.Point(345, 140);
            this.crownLabel6.Name = "crownLabel6";
            this.crownLabel6.Size = new System.Drawing.Size(55, 18);
            this.crownLabel6.TabIndex = 14;
            this.crownLabel6.Text = "Phone:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.ForeColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(196, 141);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.Text = "Female";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(117, 141);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 5;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            // 
            // crownLabel5
            // 
            this.crownLabel5.AutoSize = true;
            this.crownLabel5.BackColor = System.Drawing.Color.Transparent;
            this.crownLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel5.ForeColor = System.Drawing.Color.White;
            this.crownLabel5.Location = new System.Drawing.Point(26, 140);
            this.crownLabel5.Name = "crownLabel5";
            this.crownLabel5.Size = new System.Drawing.Size(61, 18);
            this.crownLabel5.TabIndex = 11;
            this.crownLabel5.Text = "Gender:";
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.Transparent;
            this.tbLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbLastName.CustomBGColor = System.Drawing.Color.White;
            this.tbLastName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbLastName.ForeColor = System.Drawing.Color.DimGray;
            this.tbLastName.Location = new System.Drawing.Point(469, 78);
            this.tbLastName.MaxLength = 50;
            this.tbLastName.Multiline = false;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = false;
            this.tbLastName.Size = new System.Drawing.Size(127, 28);
            this.tbLastName.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.tbLastName.TabIndex = 4;
            this.tbLastName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLastName.UseSystemPasswordChar = false;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // tbSecondName
            // 
            this.tbSecondName.BackColor = System.Drawing.Color.Transparent;
            this.tbSecondName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbSecondName.CustomBGColor = System.Drawing.Color.White;
            this.tbSecondName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbSecondName.ForeColor = System.Drawing.Color.DimGray;
            this.tbSecondName.Location = new System.Drawing.Point(469, 23);
            this.tbSecondName.MaxLength = 50;
            this.tbSecondName.Multiline = false;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.ReadOnly = false;
            this.tbSecondName.Size = new System.Drawing.Size(127, 28);
            this.tbSecondName.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.tbSecondName.TabIndex = 2;
            this.tbSecondName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSecondName.UseSystemPasswordChar = false;
            this.tbSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.tbSecondName_Validating);
            // 
            // tbThirdName
            // 
            this.tbThirdName.BackColor = System.Drawing.Color.Transparent;
            this.tbThirdName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbThirdName.CustomBGColor = System.Drawing.Color.White;
            this.tbThirdName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbThirdName.ForeColor = System.Drawing.Color.DimGray;
            this.tbThirdName.Location = new System.Drawing.Point(117, 78);
            this.tbThirdName.MaxLength = 50;
            this.tbThirdName.Multiline = false;
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.ReadOnly = false;
            this.tbThirdName.Size = new System.Drawing.Size(127, 28);
            this.tbThirdName.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.tbThirdName.TabIndex = 3;
            this.tbThirdName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbThirdName.UseSystemPasswordChar = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.tbFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbFirstName.CustomBGColor = System.Drawing.Color.White;
            this.tbFirstName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.tbFirstName.Location = new System.Drawing.Point(117, 23);
            this.tbFirstName.MaxLength = 50;
            this.tbFirstName.Multiline = false;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = false;
            this.tbFirstName.Size = new System.Drawing.Size(127, 28);
            this.tbFirstName.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFirstName.UseSystemPasswordChar = false;
            // 
            // crownLabel4
            // 
            this.crownLabel4.AutoSize = true;
            this.crownLabel4.BackColor = System.Drawing.Color.Transparent;
            this.crownLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel4.ForeColor = System.Drawing.Color.White;
            this.crownLabel4.Location = new System.Drawing.Point(345, 83);
            this.crownLabel4.Name = "crownLabel4";
            this.crownLabel4.Size = new System.Drawing.Size(84, 18);
            this.crownLabel4.TabIndex = 5;
            this.crownLabel4.Text = "Last Name:";
            // 
            // crownLabel3
            // 
            this.crownLabel3.AutoSize = true;
            this.crownLabel3.BackColor = System.Drawing.Color.Transparent;
            this.crownLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel3.ForeColor = System.Drawing.Color.White;
            this.crownLabel3.Location = new System.Drawing.Point(345, 28);
            this.crownLabel3.Name = "crownLabel3";
            this.crownLabel3.Size = new System.Drawing.Size(107, 18);
            this.crownLabel3.TabIndex = 4;
            this.crownLabel3.Text = "Second Name:";
            // 
            // crownLabel1
            // 
            this.crownLabel1.AutoSize = true;
            this.crownLabel1.BackColor = System.Drawing.Color.Transparent;
            this.crownLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel1.ForeColor = System.Drawing.Color.White;
            this.crownLabel1.Location = new System.Drawing.Point(26, 83);
            this.crownLabel1.Name = "crownLabel1";
            this.crownLabel1.Size = new System.Drawing.Size(85, 18);
            this.crownLabel1.TabIndex = 3;
            this.crownLabel1.Text = "ThirdName:";
            // 
            // crownLabel2
            // 
            this.crownLabel2.AutoSize = true;
            this.crownLabel2.BackColor = System.Drawing.Color.Transparent;
            this.crownLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crownLabel2.ForeColor = System.Drawing.Color.White;
            this.crownLabel2.Location = new System.Drawing.Point(26, 28);
            this.crownLabel2.Name = "crownLabel2";
            this.crownLabel2.Size = new System.Drawing.Size(85, 18);
            this.crownLabel2.TabIndex = 2;
            this.crownLabel2.Text = "First Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPersonInfo);
            this.Name = "ctrlPersonInfo";
            this.Size = new System.Drawing.Size(653, 196);
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.CrownGroupBox gbPersonInfo;
        private ReaLTaiizor.Controls.SmallTextBox tbPhone;
        private ReaLTaiizor.Controls.CrownLabel crownLabel6;
        private ReaLTaiizor.Controls.CrownRadioButton rbFemale;
        private ReaLTaiizor.Controls.CrownRadioButton rbMale;
        private ReaLTaiizor.Controls.CrownLabel crownLabel5;
        private ReaLTaiizor.Controls.SmallTextBox tbLastName;
        private ReaLTaiizor.Controls.SmallTextBox tbSecondName;
        private ReaLTaiizor.Controls.SmallTextBox tbThirdName;
        private ReaLTaiizor.Controls.SmallTextBox tbFirstName;
        private ReaLTaiizor.Controls.CrownLabel crownLabel4;
        private ReaLTaiizor.Controls.CrownLabel crownLabel3;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
