using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Users
{
    public partial class frmChangePassword : CrownForm
    {
        private int? UserID;
        public clsUser UserInfo 
        { 
            get
            {
                return ctrlUserInfo1.UserInfo;
            }
        }

        public frmChangePassword(int? userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);

            if (UserID == null || UserID <= 0)
            {
                MessageBox.Show("Invalid user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlUserInfo1.LoadUserInfo(UserID);

            if (UserInfo == null)
            {
                MessageBox.Show("Invalid user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblUserName.Text = UserInfo.Username;
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Password can not be empty!");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError(tbPassword, null);
                e.Cancel = false;
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = tbPassword.Text.Trim();
            string confirmPassword = tbConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                errorProvider1.SetError(tbConfirmPassword, "Password can not be empty!");
                e.Cancel = true;
            } else if (password != confirmPassword)
            {
                errorProvider1.SetError(tbConfirmPassword, "Password does not match!");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError(tbConfirmPassword, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            UserInfo.Password = tbPassword.Text.Trim();

            if (UserInfo.Save())
            {
                clsCurrentUser.UserInfo.Password = tbPassword.Text.Trim();
                clsUtil.SaveUsernameAndPassword(clsCurrentUser.UserInfo.Username, tbPassword.Text.Trim());
                MessageBox.Show("Password changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}