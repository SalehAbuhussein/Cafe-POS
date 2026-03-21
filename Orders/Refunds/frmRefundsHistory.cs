using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using Cafe_Management_System.Orders.Refunds;
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

namespace Cafe_Management_System.Refunds
{
    public partial class frmRefundsHistory : CrownForm
    {
        private int? _OrderID;
        private DataTable _refundItemsInfo;

        public frmRefundsHistory(int? orderID = null)
        {
            InitializeComponent();
            _OrderID = orderID;
        }

        private void frmRefundsHistory_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);
            _InitRefundHistoryTable();
            cbFilter.SelectedIndex = 0;
        }

        private void _InitRefundHistoryTable()
        {
            _refundItemsInfo = _OrderID != null ? clsOrderRefund.GetRefundHistory(_OrderID ?? -1) : clsOrderRefund.GetRefundHistory();
            dgvRefunds.DataSource = _refundItemsInfo;
            dgvRefunds.Columns["OrderRefundID"].HeaderText = "ID";
            dgvRefunds.Columns["CreatedAt"].HeaderText = "Creation Date";
            dgvRefunds.Columns["CreatedByUser"].HeaderText = "Created By ID";

            lblCount.Text = _refundItemsInfo.DefaultView.Count.ToString();
        }

        private void dgvRefunds_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            clsUtil.SetupGrid(dgvRefunds);
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int refundID = (int)dgvRefunds.CurrentRow.Cells["OrderRefundID"].Value;

            frmRefundItemDetails frm = new frmRefundItemDetails(refundID);
            frm.ShowDialog();
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
                    _refundItemsInfo.DefaultView.RowFilter = "";
                    break;
                case "Today":
                    string todayFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1:M/dd/yyyy}#", today, tomorrow);
                    _refundItemsInfo.DefaultView.RowFilter = todayFilter;
                    break;
                case "Yesterday":
                    string yesterdayFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1:M/dd/yyyy}#", yesterday, today);
                    _refundItemsInfo.DefaultView.RowFilter = yesterdayFilter;
                    break;
                case "Last 7 Days":
                    string lastWeekFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1: M/dd/yyyy}#", last7Days, today);
                    _refundItemsInfo.DefaultView.RowFilter = lastWeekFilter;
                    break;
                case "Last 30 Days":
                    string last30DaysFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1: M/dd/yyyy}#", last30Days, today);
                    _refundItemsInfo.DefaultView.RowFilter = last30DaysFilter;
                    break;
                case "Custom":
                    string customDateFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1:M/dd/yyyy}#", today, tomorrow);
                    _refundItemsInfo.DefaultView.RowFilter = customDateFilter;
                    dpStart.Visible = true;
                    dpEnd.Visible = true;
                    break;
                default:
                    _refundItemsInfo.DefaultView.RowFilter = "";
                    break;
            }

            lblCount.Text = _refundItemsInfo.DefaultView.Count.ToString();
        }

        private void dp_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtStart = dpStart.Value;
            DateTime dtEnd = dpEnd.Value;

            if (dtStart > dtEnd)
            {
                string customFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1: M/dd/yyyy}#", dtStart, dtEnd);
                _refundItemsInfo.DefaultView.RowFilter = string.Format(customFilter);
            }
            else
            {
                string customFilter = string.Format("CreatedAt >= #{0:M/dd/yyyy}# AND CreatedAt < #{1: M/dd/yyyy}#", dtEnd, dtStart);
                _refundItemsInfo.DefaultView.RowFilter = string.Format(customFilter);
            }
        }
    }
}
