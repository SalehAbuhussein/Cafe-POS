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
    public partial class frmAddUpdateUser : CrownForm
    {
        public enum enMode
        {
            Add,
            Update,
        }

        private int? _UserID;
        private clsUser _User;
        private enMode _Mode;

        public frmAddUpdateUser(int? userID = null)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);

            if (_UserID is null)
            {
                lblTitle.Text = "Add User";
                _Mode = enMode.Add;
                return;
            }

            _User = clsUser.Find(_UserID);

            if (_User is null)
            {
                MessageBox.Show("Invalid User data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            _FillExistingUserData();
            _DisableNonEditableInputs();
            _Mode = enMode.Update;
            lblTitle.Text = "Update User";
        }

        private void _FillExistingUserData()
        {
            if (_User.PersonInfo == null)
            {
                return;
            }

            ctrlPersonInfo1.LoadPersonInfo(_User.PersonID);
            tbUsername.Text = _User.Username;
        }

        private void _DisableNonEditableInputs()
        {
            ctrlPersonInfo1.DisableNonEditableInputs();
            tbUsername.Enabled = false;
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                return;
            }

            string userName = tbUsername.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                errorProvider1.SetError(tbUsername, "Username can not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbUsername, null);
            }
        }
        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                errorProvider1.SetError(tbPassword, "Password can not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPassword, null);
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = tbPassword.Text.Trim();
            string confirmPassword = tbConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(confirmPassword))
            {
                errorProvider1.SetError(tbConfirmPassword, "Password can not be empty!");
                e.Cancel = true;
            } else if (password != confirmPassword)
            {
                errorProvider1.SetError(tbConfirmPassword, "Passwords does not match");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            string firstName = ctrlPersonInfo1.FirstNameField;
            string secondName = ctrlPersonInfo1.SecondNameField;
            string thirdName =  string.IsNullOrEmpty(ctrlPersonInfo1.ThirdNameField) ? null : ctrlPersonInfo1.ThirdNameField;
            string lastName = ctrlPersonInfo1.LastNameField;
            string phone = ctrlPersonInfo1.PhoneField;
            byte gender = ctrlPersonInfo1.GenderField;

            string userName = tbUsername.Text.Trim();
            string confirmPassword = tbConfirmPassword.Text.Trim();
            string passwordHash = clsUtil.ComputeHash(confirmPassword);

            if (_Mode == enMode.Add)
            {
                _User = new clsUser();
                _User.PersonInfo = new clsPeople();
                _User.PersonInfo.FirstName = firstName;
                _User.PersonInfo.SecondName = secondName;
                _User.PersonInfo.ThirdName = thirdName;
                _User.PersonInfo.LastName = lastName;
                _User.PersonInfo.Gender = gender;
                _User.PersonInfo.Phone = phone;

                if (_User.PersonInfo.Save())
                {
                    _User.PersonID = _User.PersonInfo.PersonID;
                    MessageBox.Show("User Person info was created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }

            _User.Username = userName;
            _User.Password = passwordHash;

            if (_User.Save())
            {
                clsUtil.SaveUsernameAndPassword(userName, confirmPassword);

                string textStatus = _Mode == enMode.Add ? "Added" : "Updated";
                MessageBox.Show($"User {textStatus} Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } else
            {
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}
