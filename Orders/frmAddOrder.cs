using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using Cafe_Management_System.Orders.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
            clsUtil.ApplyRoundedCorners(20, this);
            ctrlOrderItem1.InitComponent();
            ctrlOrderItem1.SetForeColor(Color.White);
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

        private Dictionary<string, Types.DTOOrderItem> _GetOrderItems()
        {
            Dictionary<string, Types.DTOOrderItem> items = new Dictionary<string, Types.DTOOrderItem>();

            foreach (ctrlOrderItem ctrl in flowLayoutPanel1.Controls)
            {
                Types.DTOOrderItem item = ctrl.SelectedItem;

                if (items.TryGetValue(item.ProductID.ToString(), out Types.DTOOrderItem insertedItem))
                {
                    item.Qty += insertedItem.Qty;
                    items[item.ID.ToString()] = item;
                }
                else
                {
                    items.Add(item.ProductID.ToString(), item);
                }
            }

            return items;
        }

        private bool _IsOrderValid()
        {
            bool isValid = true;

            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                ctrlOrderItem ctrl = (ctrlOrderItem)flowLayoutPanel1.Controls[i];

                if (!ctrl.IsValid)
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

            if (!_IsOrderValid())
            {
                MessageBox.Show("Valid order");
                return;
            }

            Dictionary<string, Types.DTOOrderItem> orderItems = _GetOrderItems();
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

        private void ctrlOrderItem1_OnItemAdded(int orderItemID)
        {
            ctrlOrderItem ctrl = new ctrlOrderItem();
            ctrl.InitComponent();
            ctrl.SetForeColor(Color.White);
            ctrl.OnItemAdded += ctrlOrderItem1_OnItemAdded;
            flowLayoutPanel1.Controls.Add(ctrl);
        }
    }
}
