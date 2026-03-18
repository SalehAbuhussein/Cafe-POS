using BusinessLayer;
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
    public partial class ctrlUserInfo : UserControl
    {
        private clsUser _user;
        public clsUser UserInfo { get { return _user; } }

        public ctrlUserInfo()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int? userID)
        {
            if (userID == null)
            {
                return;
            }

            _user = clsUser.Find(userID ?? -1);

            if (_user == null)
            {
                _ResetData();
                MessageBox.Show("invalid user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblFullName.Text = _user.PersonInfo.FullName;
            lblGender.Text = _user.PersonInfo.GenderText;
            lblPhone.Text = _user.PersonInfo.Phone;
            lblUsername.Text = _user.Username;
            lblIsActive.Text = _user.IsActiveName;
        }

        private void _ResetData()
        {
            _user = null;
            lblFullName.Text = "[????]";
            lblGender.Text = "????";
            lblPhone.Text = "????";
            lblUsername.Text = "????";
            lblIsActive.Text = "????";
        }
    }
}
