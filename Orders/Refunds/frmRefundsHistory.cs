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
    }
}
