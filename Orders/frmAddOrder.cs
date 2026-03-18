using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using Cafe_Management_System.Orders.Controls;
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

using OrderTypes = Types.OrderTypes;

namespace Cafe_Management_System.Orders
{
    public partial class frmAddOrder : CrownForm
    {
        public frmAddOrder()
        {
            InitializeComponent();
        }

        private void frmAddOrder_Load(object sender, EventArgs e)
        {
            ctrlOrderItem1.ForeColor = Color.White;
            clsUtil.ApplyRoundedCorners(20, this);
        }

        public bool IsOrderItemValid()
        {
            bool isValid = false;
            ctrlOrderItem firstCtrl = (ctrlOrderItem)flowLayoutPanel1.Controls[0];

            if (flowLayoutPanel1.Controls.Count == 1 && !firstCtrl.IsValid)
            {
                return false;
            }

            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                ctrlOrderItem ctrl = (ctrlOrderItem)flowLayoutPanel1.Controls[i];

                if (!ctrl.IsValid)
                {
                    isValid = false;
                    break;
                }

                isValid = true;
            }

            return isValid;
        }

        private void ctrlOrderItem1_OnItemAdded(OrderTypes.stOrderItem obj)
        {
            ctrlOrderItem ctrl = new ctrlOrderItem();
            ctrl.ForeColor = Color.White;
            ctrl.OnItemAdded += ctrlOrderItem1_OnItemAdded;
            flowLayoutPanel1.Controls.Add(ctrl);
        }

        private Dictionary<string, OrderTypes.stOrderItem> _GetOrderItems()
        {
            Dictionary<string, OrderTypes.stOrderItem> items = new Dictionary<string, OrderTypes.stOrderItem>();

            foreach (ctrlOrderItem ctrl in flowLayoutPanel1.Controls)
            {
                if (items.TryGetValue(ctrl.Item.ProductText, out OrderTypes.stOrderItem item))
                {
                    items[ctrl.Item.ProductText] = new OrderTypes.stOrderItem(ctrl.Item.ProductText, ctrl.Item.ProductID, ctrl.Item.RemainingQuantity + item.RemainingQuantity, item.PricePerUnit);
                } else
                {
                    items.Add(ctrl.Item.ProductText, ctrl.Item);
                }
            }

            return items;
        }

        private bool _IsOrderValid(Dictionary<string, OrderTypes.stOrderItem> orderItems)
        {
            bool isValid = true;

            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                ctrlOrderItem ctrl = (ctrlOrderItem)flowLayoutPanel1.Controls[i];

                int remainingQty = ctrl.Item.RemainingQuantity;

                if (ctrl.Quantity > remainingQty)
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsOrderItemValid())
            {
                MessageBox.Show("Order is invalid!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, OrderTypes.stOrderItem> orderItems = _GetOrderItems();
            if (!_IsOrderValid(orderItems))
            {
                MessageBox.Show("Valid order");
                return;
            }

            if (clsOrder.MakeOrder(orderItems, clsCurrentUser.UserInfo.UserID ?? -1))
            {
                MessageBox.Show("Order has been ordered successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
