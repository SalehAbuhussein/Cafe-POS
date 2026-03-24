using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using Cafe_Management_System.Orders.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Management_System.Orders
{
    public partial class frmOrderRefunds : CrownForm
    {
        private int? _OrderID;
        private clsOrder _Order;
        private DataTable _OrderRemainingItems;

        public frmOrderRefunds(int orderID)
        {
            InitializeComponent();
            _OrderID = orderID;
        }

        private void frmOrderPartialRefunds_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);

            if (_OrderID == null || _OrderID <= 0)
            {
                MessageBox.Show("Invalid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            _Order = clsOrder.Find(_OrderID ?? -1);
            _OrderRemainingItems = _Order.GetItemsRemainingQuantities();

            foreach (DataRow row in _OrderRemainingItems.Rows)
            {
                int remainingQty = (int)row["RemainingQty"];

                if (remainingQty == 0)
                {
                    continue;
                }

                ctrlOrderItem ctrl = new ctrlOrderItem();
                clsProduct product = clsProduct.FindByOrderItemID(Convert.ToInt16(row["OrderItemID"]));

                if (product == null)
                {
                    MessageBox.Show("Invalid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                ctrl.Mode = ctrlOrderItem.enMode.RefundOrder;
                ctrl.OrderItemID = Convert.ToInt32(row["OrderItemID"]);
                ctrl.SetForeColor(Color.White);
                ctrl.InitComponent();

                flowLayoutPanel1.Controls.Add(ctrl);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsRefundValid())
            {
                DataTable refundItems = _GetOrderRefundsTable();
                int refundID = clsOrder.RefundOrder(_OrderID ?? -1, clsCurrentUser.UserInfo.UserID ?? -1, refundItems);
                MessageBox.Show($"Order has been filled with id of {refundID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } else
            {
                MessageBox.Show($"Something went wrong with refunding process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private bool _IsRefundValid()
        {
            bool isValid = false;

            foreach (ctrlOrderItem ctrl in flowLayoutPanel1.Controls)
            {
                isValid = false;

                if (ctrl.IsValid)
                {
                    isValid = true;
                    break;
                }
            }

            return isValid;
        }

        private DataTable _GetOrderRefundsTable()
        {
            DataTable dt = new DataTable();

            List<Types.DTOOrderItem> lst = flowLayoutPanel1.Controls
                .OfType<ctrlOrderItem>()
                .Select(c => c.SelectedItem)
                .ToList();

            dt.Columns.Add("OrderItemID", typeof(Int32));
            dt.Columns.Add("Quantity", typeof(Int32));

            for (int i = 0; i < lst.Count; i++)
            {
                Types.DTOOrderItem item = lst[i];

                if (item.Qty > 0)
                {
                    dt.Rows.Add(item.ID, item.Qty);
                }
            }

            return dt;
        }
    }
}
