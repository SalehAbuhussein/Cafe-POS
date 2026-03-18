using BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Users.Controls
{
    public partial class ctrlPersonInfo : UserControl
    {
        public enum enMode
        {
            Add,
            Update,
        };

        private enMode _Mode = enMode.Add;
        private clsPeople _Person = new clsPeople();
        public clsPeople PersonInfo
        {
            get { return _Person; }
        }
        public string FirstNameField
        {
            get { return tbFirstName.Text.Trim(); }
        }
        public string SecondNameField
        {
            get { return tbSecondName.Text.Trim(); }
        }
        public string ThirdNameField
        {
            get { return tbThirdName.Text.Trim(); }
        }
        public string LastNameField
        {
            get { return tbLastName.Text.Trim(); }
        }
        public string PhoneField
        {
            get { return tbPhone.Text.Trim(); }
        }
        public byte GenderField
        {
            get { return Convert.ToByte(rbMale.Checked ? 0 : 1); }
        }

        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int personID)
        {
            _Person = clsPeople.Find(personID);

            if (_Person != null)
            {
                _Mode = enMode.Update;
            }

            tbFirstName.Text = _Person.FirstName;
            tbSecondName.Text = _Person.SecondName;
            tbThirdName.Text = _Person.ThirdName;
            tbLastName.Text = _Person.LastName;
            tbPhone.Text = _Person.Phone;
            rbMale.Checked = _Person.GenderText == "Male";
            rbFemale.Checked = _Person.GenderText == "Female";
        }

        public void DisableNonEditableInputs()
        {
            tbFirstName.Enabled = false;
            rbFemale.Enabled = false;
            rbMale.Enabled = false;
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                return;
            }

            string firstName = tbFirstName.Text.Trim();

            if (string.IsNullOrEmpty(firstName))
            {
                errorProvider1.SetError(tbFirstName, "First name can not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbFirstName, null);
            }
        }

        private void tbSecondName_Validating(object sender, CancelEventArgs e)
        {
            string secondName = tbSecondName.Text.Trim();

            if (string.IsNullOrEmpty(secondName))
            {
                errorProvider1.SetError(tbSecondName, "Second name can not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbSecondName, null);
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            string lastName = tbLastName.Text.Trim();

            if (string.IsNullOrEmpty(lastName))
            {
                errorProvider1.SetError(tbLastName, "Last name can not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbLastName, null);
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                return;
            }

            string phone = tbPhone.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                errorProvider1.SetError(tbPhone, "Phone can not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPhone, null);
            }
        }

    }
}
