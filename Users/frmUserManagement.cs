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
    public partial class frmUserManagement : CrownForm
    {
        private DataTable _usersInfo;

        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);
            _InitUsersTable();

            lblCount.Text = _usersInfo.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
        }

        private void _InitUsersTable()
        {
            _usersInfo = clsUser.GetUsersData();
            dgvUsers.DataSource = _usersInfo;

            dgvUsers.Columns["UserID"].HeaderText = "ID";
        }

        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            clsUtil.SetupGrid(dgvUsers);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _usersInfo.DefaultView.RowFilter = string.Empty;
            cbIsActive.Visible = cbFilter.SelectedItem.ToString() == "Active";
            tbFilter.Visible = cbFilter.SelectedItem.ToString() == "Name";
            lblCount.Text = _usersInfo.DefaultView.Count.ToString();
            cbIsActive.SelectedIndex = 0;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            switch (cbFilter.SelectedItem.ToString().Trim())
            {
                case "Name":
                    _usersInfo.DefaultView.RowFilter = string.Format("[Name] LIKE '%{0}%'", tbFilter.Text.Trim());
                    break;
                default:
                    _usersInfo.DefaultView.RowFilter = string.Empty;
                    break;
            }

            lblCount.Text = _usersInfo.DefaultView.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsActive.SelectedItem.ToString())
            {
                case "All":
                    _usersInfo.DefaultView.RowFilter = string.Empty;
                    break;
                case "Yes":
                    _usersInfo.DefaultView.RowFilter = "[Active] = 'Yes'";
                    break;
                case "No":
                    _usersInfo.DefaultView.RowFilter = "[Active] = 'No'";
                    break;
            }

            lblCount.Text = _usersInfo.DefaultView.Count.ToString();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedFilter = cbFilter.SelectedItem.ToString();

            switch (selectedFilter)
            {
                case "Name":
                    e.Handled = clsUtil.IsSpecialCharacter(e);
                    break;
            }
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            frmAddUpdateUser frm = new frmAddUpdateUser(userID);
            frm.ShowDialog();
            frmUserManagement_Load(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            frmUserManagement_Load(null, null);
        }

        private void userInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
            frmUserInfo frm = new frmUserInfo(userID);
            frm.ShowDialog();
            frmUserManagement_Load(null, null);
        }
    }
}
