using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Cafe_Management_System.Orders.Controls
{
    public partial class ctrlOrderItem : UserControl
    {
        public event Action<int> OnItemAdded;
        public void RaiseOnItemAdded()
        {
            OnItemAdded?.Invoke(OrderItemID ?? -1);
        }

        public enum enMode
        {
            AddOrder,
            RefundOrder,
        }

        public int? OrderItemID;
        private enMode _Mode = enMode.AddOrder;
        public enMode Mode
        {
            get
            {
                return _Mode;
            }
            set
            {
                if (value == enMode.RefundOrder)
                {
                    cbProduct.Enabled = false;
                    btnAdd.Visible = false;
                }

                _Mode = value;
            }
        }
        public bool IsValid
        {
            get
            {
                int tbQty = string.IsNullOrEmpty(tbQuantity.Text.Trim()) ? 0 : Convert.ToInt32(tbQuantity.Text.Trim());
                int totalQty = Convert.ToInt32(lblQty.Text.Trim());

                return tbQty != 0 && tbQty <= totalQty;
            }
        }
        public Types.DTOOrderItem SelectedItem
        {
            get
            {
                if (OrderItemID == null)
                {
                    clsProduct product = clsProduct.FindByName(cbProduct.SelectedItem.ToString());
                    int qty = string.IsNullOrEmpty(tbQuantity.Text.Trim()) ? 0 : Convert.ToInt32(tbQuantity.Text.Trim());

                    return new Types.DTOOrderItem(-1, product.ProductID ?? -1, qty, product.Price, (Types.DTOOrderItem.enMode)_Mode);
                } else
                {
                    if (!clsOrderItem.IsOrderItemExist(OrderItemID ?? -1))
                    {
                        return null;
                    }

                    clsProduct product = clsProduct.FindByOrderItemID(OrderItemID ?? -1);
                    int qty = string.IsNullOrEmpty(tbQuantity.Text.Trim()) ? 0 : Convert.ToInt32(tbQuantity.Text.Trim());
                    decimal unitPrice = clsOrderItem.GetPriceSnapShot(OrderItemID ?? -1);

                    return new Types.DTOOrderItem(OrderItemID ?? -1, product.ProductID ?? -1, qty, unitPrice, (Types.DTOOrderItem.enMode)_Mode);
                }
            }
        }

        public ctrlOrderItem()
        {
            InitializeComponent();
        }

        public void InitComponent()
        {
            SetProducts();

            if (OrderItemID != null && _Mode == enMode.RefundOrder)
            {
                _InitRefundInfo();
            }
        }

        /**
         * Init Products Have 2 modes:
         * 1- Refund => Get products related to the order being refunded.
         * 2- Add Order => Get Available Orders that have quantity
         */
        public void SetProducts()
        {
            if (_Mode == enMode.RefundOrder)
            {
                _InitProductForRefund();
            } else
            {
                _InitProductForOrder();
            }
        }

        private void _InitProductForOrder()
        {
            DataTable products = clsProduct.FindAvailableProducts();

            for (int i = 0; i < products.Rows.Count; i++)
            {
                cbProduct.Items.Add(products.Rows[i]["ProductName"]);

                if (i == 0 && _Mode == enMode.AddOrder)
                {
                    lblQty.Text = products.Rows[i]["Quantity"].ToString();
                    cbProduct.SelectedIndex = 0;
                }
            }
        }

        private void _InitProductForRefund()
        {
            clsProduct product = clsProduct.FindByOrderItemID(OrderItemID ?? -1);
            cbProduct.Items.Add(product.ProductName);
            cbProduct.SelectedIndex = 0;
        }

        private void _InitRefundInfo()
        {
            DataTable refundItemInfo = clsOrder.GetOrderRemainingItem(OrderItemID ?? -1);

            if (refundItemInfo.Rows.Count == 0) {
                return;
            }

            int productID = Convert.ToInt32(refundItemInfo.Rows[0]["ProductID"]);
            decimal unitPrice = Convert.ToDecimal(refundItemInfo.Rows[0]["UnitPrice"]);
            decimal quantity = Convert.ToInt32(refundItemInfo.Rows[0]["Quantity"]);
            clsProduct product = clsProduct.Find(productID);

            lblQty.Text = quantity.ToString();
            cbProduct.SelectedItem = product.ProductName;
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsProduct product = clsProduct.FindByName(cbProduct.SelectedItem.ToString().ToString());
            lblQty.Text = product.Quantity.ToString();

            if (_Mode == enMode.RefundOrder)
            {
                _InitRefundInfo();
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsUtil.IsNumberInput(e, tbQuantity.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                RaiseOnItemAdded();
            }
        }

        public void SetForeColor(Color value)
        {
            label1.ForeColor = value;
            label2.ForeColor = value;
            lblQty.ForeColor = value;
        }
    }
}
