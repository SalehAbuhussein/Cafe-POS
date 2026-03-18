using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Orders.Refunds
{
    public partial class frmRefundItemDetails : CrownForm
    {
        private DataTable _refundItemDetails;
        private int _RefundID;

        public frmRefundItemDetails(int refundID)
        {
            InitializeComponent();
            _RefundID = refundID;
        }

        private void frmRefundItemDetails_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);
            _InitRefundItemDetailsTable();
        }

        private void _InitRefundItemDetailsTable()
        {
            _refundItemDetails = clsOrderRefundItem.GetRefundItemsByRefundID(_RefundID);
            dgvRefundDetails.DataSource = _refundItemDetails;
            lblCount.Text = _refundItemDetails.DefaultView.Count.ToString();
        }

        private void dgvRefundDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            clsUtil.SetupGrid(dgvRefundDetails);
        }
    }
}
