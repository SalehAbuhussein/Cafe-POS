using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using Cafe_Management_System.Orders;
using Cafe_Management_System.Product;
using Cafe_Management_System.Refunds;
using Cafe_Management_System.Users;
using ReaLTaiizor.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class frmMain : CrownForm
    {
        private frmLogin _frmLogin;

        public frmMain(frmLogin form)
        {
            InitializeComponent();
            this._frmLogin = form;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _LoadTodaySummary();
            _HandlePermission();
        }

        private void _LoadTodaySummary()
        {
            dgvOrders.DataSource = clsOrder.GetOrdersSummary();
            lblSales.Text = String.Format("${0}", clsOrder.GetTotalOrdersPriceToday());
            lblOrders.Text = String.Format("{0}", clsOrder.GetOrdersCountToday());
            lblRefunds.Text = String.Format("${0}", clsOrderRefund.GetTotalRefundsToday());
        }

        private void _HandlePermission()
        {
            _HandleUsersFormPermission();
            _HandleRefundHistoryPermission();
        }

        private void _HandleUsersFormPermission()
        {
            usersToolStripMenuItem.Visible = clsCurrentUser.UserInfo.HasRole("owner");
        }

        private void _HandleRefundHistoryPermission()
        {
            usersToolStripMenuItem.Visible = clsCurrentUser.UserInfo.HasRole("owner");
        }

        private void dgvOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            clsUtil.SetupGrid(dgvOrders);
        }

        private void refundHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRefundsHistory frm = new frmRefundsHistory();
            frm.ShowDialog();
        }

        private void dgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].Name == "Status")
            {
                string status = e.Value?.ToString();

                if (status == "Paid")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(100, 200, 120);
                }

                if (status == "Partial Refunded")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(150, 200, 210);
                }

                if (status == "Refunded")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(230, 160, 80);
                }
            }
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductManagement frm = new frmProductManagement();
            frm.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderManagement frm = new frmOrderManagement();
            frm.ShowDialog();
            frmMain_Load(null, null);
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCurrentUser.UserInfo = null;
            Hide();
            _frmLogin.LoadLoginData();
            _frmLogin.Show();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? userID = clsCurrentUser.UserInfo.UserID;
            frmUserInfo frm = new frmUserInfo(userID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? userID = clsCurrentUser.UserInfo.UserID;
            frmChangePassword frm = new frmChangePassword(userID);
            frm.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManagement frm = new frmUserManagement();
            frm.ShowDialog();
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderID = (int)dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value;
            frmOrderDetails frm = new frmOrderDetails(orderID);
            frm.ShowDialog();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int orderID = (int)dgvOrders.CurrentRow.Cells["OrderID"].Value;
            frmOrderDetails frm = new frmOrderDetails(orderID);
            frm.ShowDialog();
        }

        private void refundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int orderID = (int)dgvOrders.CurrentRow.Cells["OrderID"].Value;
            frmOrderRefunds frm = new frmOrderRefunds(orderID);
            frm.ShowDialog();
            dgvOrders.DataSource = clsOrder.GetOrdersSummary();
        }

        private void cmsOrders_Opening(object sender, CancelEventArgs e)
        {
            string status = dgvOrders.CurrentRow.Cells["Status"].Value.ToString();
            int orderID = (int)dgvOrders.CurrentRow.Cells["OrderID"].Value;

            refundToolStripMenuItem.Enabled = status != "Refunded";
            refundHistoryToolStripMenuItem1.Enabled = clsOrderRefund.HaveRefundHistory(orderID);
        }

        private void refundHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int orderID = (int)dgvOrders.CurrentRow.Cells["OrderID"].Value;

            frmRefundsHistory frm = new frmRefundsHistory(orderID);
            frm.ShowDialog();
        }
    }
}
