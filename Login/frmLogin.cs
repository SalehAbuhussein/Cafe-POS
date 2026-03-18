using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using ReaLTaiizor.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class frmLogin : CrownForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void LoadLoginData()
        {
            string username = string.Empty;
            string password = string.Empty;

            if (clsUtil.GetStoredUsernameAndPassword(ref username, ref password))
            {
                cbRememberMe.Checked = true;
                tbUsername.Text = username;
                tbPassword.Text = password;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);
            LoadLoginData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            string username = tbUsername.Text.Trim();
            string passwordHash = clsUtil.ComputeHash(tbPassword.Text.Trim());
            clsUser user = clsUser.FindByUsernameAndPassword(username, passwordHash);

            if (user != null)
            {
                if (!user.IsActive)
                {
                    MessageBox.Show("user is not active, please contact an admin!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbRememberMe.Checked)
                {
                    clsUtil.SaveUsernameAndPassword(username, tbPassword.Text.Trim());
                }

                clsCurrentUser.UserInfo = user;

                frmMain frm = new frmMain(this);
                this.Hide();
                frm.Show();
            } else
            {
                MessageBox.Show("Username or password is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            string username = tbUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                errorProvider1.SetError(tbUsername, "Username can not be empty!");
            } else
            {
                errorProvider1.SetError(tbPassword, null);
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = tbPassword.Text.Trim();

            if (clsValidation.IsPassword(password))
            {
                errorProvider1.SetError(tbPassword, "Passoword is invalid!");
            } else
            {
                errorProvider1.SetError(tbPassword, null);
            }
        }
    }
}
