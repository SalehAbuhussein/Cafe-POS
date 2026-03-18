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

namespace Cafe_Management_System.Orders
{
    public partial class frmOrderDetails : CrownForm
    {
        private int? _OrderID;

        public frmOrderDetails(int? orderId)
        {
            InitializeComponent();
            _OrderID = orderId;
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);

            if (_OrderID == null || _OrderID == -1)
            {
                MessageBox.Show("Invalid order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            DataTable orderInfo = clsOrder.GetOrderDetails(_OrderID ?? -1);

            if (orderInfo.Rows.Count == 0)
            {
                MessageBox.Show("Invalid order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            dgvOrderItems.DataSource = orderInfo;
            _UpdateTotalPriceLabel();
        }

        private void dgvOrderItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            clsUtil.SetupGrid(dgvOrderItems);
        }

        private void _UpdateTotalPriceLabel()
        {
            decimal TotalPrice = 0;

            foreach (DataGridViewRow row in dgvOrderItems.Rows)
            {
                TotalPrice += Convert.ToDecimal(row.Cells["UnitPrice"].Value) * Convert.ToInt32(row.Cells["Quantity"].Value);
            }

            lblTotalItemsPrice.Text = string.Format("{0:N2}", TotalPrice) + " $";
        }
    }
}
