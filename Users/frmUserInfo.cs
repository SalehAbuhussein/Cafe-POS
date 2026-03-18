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
    public partial class frmUserInfo : CrownForm
    {
        private int? _UserID;
        public clsUser User
        {
            get
            {
                return ctrlUserInfo1.UserInfo;
            }
        }

        public frmUserInfo(int? userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);

            if (_UserID <= 0)
            {
                MessageBox.Show("Invalid user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlUserInfo1.LoadUserInfo(_UserID);
        }
    }
}
