using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using Cafe_Management_System.Refunds;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Cafe_Management_System.Orders
{
    public partial class frmOrderManagement : CrownForm
    {
        private DataTable _ordersInfo;

        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);
            _InitOrdersTable();

            lblCount.Text = _ordersInfo.DefaultView.Count.ToString();
            cbFilter.SelectedIndex = 0;
        }

        private void _InitOrdersTable()
        {
            _ordersInfo = clsOrder.GetOrdersSummary();
            dgvOrders.DataSource = _ordersInfo;

            dgvOrders.Columns["OrderID"].HeaderText = "ID";
            dgvOrders.Columns["CreatedAt"].HeaderText = "Creation Date";
        }

        private void dgvOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            clsUtil.SetupGrid(dgvOrders);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrder frm = new frmAddOrder();
            frm.ShowDialog();
            frmOrderManagement_Load(null, null);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cbFilter.SelectedItem.ToString();
            DateTime today = DateTime.Today;
            DateTime yesterday = DateTime.Today.AddDays(-1);
            DateTime last7Days = DateTime.Today.AddDays(-7);
            DateTime last30Days = DateTime.Today.AddDays(-30);
            DateTime tomorrow = DateTime.Today.AddDays(1);

            dpStart.Visible = false;
            dpEnd.Visible = false;
            dpStart.Value = DateTime.Today;
            dpEnd.Value = DateTime.Today;

            switch (selectedFilter)
            {
                case "All":
                    _ordersInfo.DefaultView.RowFilter = "";
                    break;
                case "Today":
                    string todayFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1:M/dd/yyyy}#", today, tomorrow);
                    _ordersInfo.DefaultView.RowFilter = todayFilter;
                    break;
                case "Yesterday":
                    string yesterdayFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1:M/dd/yyyy}#", yesterday, today);
                    _ordersInfo.DefaultView.RowFilter = yesterdayFilter;
                    break;
                case "Last 7 Days":
                    string lastWeekFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1: M/dd/yyyy}#", last7Days, today);
                    _ordersInfo.DefaultView.RowFilter = lastWeekFilter;
                    break;
                case "Last 30 Days":
                    string last30DaysFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1: M/dd/yyyy}#", last30Days, today);
                    _ordersInfo.DefaultView.RowFilter = last30DaysFilter;
                    break;
                case "Custom":
                    string customDateFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1:M/dd/yyyy}#", today, tomorrow);
                    dpStart.Visible = true;
                    dpEnd.Visible = true;
                    break;
                default:
                    _ordersInfo.DefaultView.RowFilter = "";
                    break;
            }

            lblCount.Text = _ordersInfo.DefaultView.Count.ToString();
            _UpdateTotalSalesLabel();
        }

        private void dp_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtStart = dpStart.Value;
            DateTime dtEnd = dpEnd.Value;

            if (dtStart > dtEnd)
            {
                string customFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1: M/dd/yyyy}#", dtStart, dtEnd);
                _ordersInfo.DefaultView.RowFilter = string.Format(customFilter);
            } else
            {
                string customFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1: M/dd/yyyy}#", dtEnd, dtStart);
                _ordersInfo.DefaultView.RowFilter = string.Format(customFilter);
            }
        }

        private void _UpdateTotalSalesLabel()
        {
            decimal TotalPrice = 0;

            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                TotalPrice += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
            }

            lblTotalSales.Text = string.Format("{0:N2}", TotalPrice) + " $";
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
            frmOrderManagement_Load(null, null);
        }

        private void cmsOrders_Opening(object sender, CancelEventArgs e)
        {
            string status = dgvOrders.CurrentRow.Cells["Status"].Value.ToString();
            int orderID = (int)dgvOrders.CurrentRow.Cells["OrderID"].Value;

            refundToolStripMenuItem.Enabled = status != "Refunded";
            refundHistoryToolStripMenuItem.Enabled = clsOrderRefund.HaveRefundHistory(orderID);
        }

        private void refundHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int orderID = (int)dgvOrders.CurrentRow.Cells["OrderID"].Value;

            frmRefundsHistory frm = new frmRefundsHistory(orderID);
            frm.ShowDialog();
        }
    }
}
