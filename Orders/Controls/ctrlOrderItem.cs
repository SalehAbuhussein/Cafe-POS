using BusinessLayer;
using Cafe_Management_System.Global_Classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using OrderTypes = Types.OrderTypes;

namespace Cafe_Management_System.Orders.Controls
{
    public partial class ctrlOrderItem : UserControl
    {
        public event Action<OrderTypes.stOrderItem> OnItemAdded;
        public void RaiseOnItemAdded()
        {
            OnItemAdded?.Invoke(Item);
        }

        private OrderTypes.stOrderItem _item = new OrderTypes.stOrderItem("", 0, 0, 0);

        public OrderTypes.stOrderItem Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
                lblRemainingQty.Text = value.RemainingQuantity.ToString();
                cbProduct.SelectedItem = value.ProductText;
            }
        }

        public string SelectedItem {
            get { return cbProduct.SelectedItem.ToString(); }
        }
        public int Quantity {
            get 
            {
                if (string.IsNullOrEmpty(tbQuantity.Text.Trim()))
                {
                    return 0;
                }

                return Convert.ToInt32(tbQuantity.Text.Trim());
            }
        }
        public Color ForeColor
        {
            set
            {
                label1.ForeColor = value;
                label2.ForeColor = value;
                lblRemainingQty.ForeColor = value;
            }
        }
        public bool EnableAdding
        {
            get
            {
                return !tbQuantity.Enabled && !cbProduct.Enabled;
            }
            set
            {
                tbQuantity.Enabled = value;
                cbProduct.Enabled = value;
                btnAdd.Enabled = value;
            }
        }
        public bool IsValid
        {
            get
            {
                return (
                    cbProduct.SelectedIndex != -1 && 
                    !string.IsNullOrEmpty(tbQuantity.Text.Trim()) && 
                    Quantity > 0 && Quantity <= Item.RemainingQuantity
                );
            }
        }
        public bool IsAddVisible
        {
            set
            {
                btnAdd.Visible = value;
            }
        }
        public bool ComboboxEnable
        {
            set
            {
                cbProduct.Enabled = value;
            }
        }

        public ctrlOrderItem()
        {
            InitializeComponent();
            _InitProductsCombo();
            _InitComboboxValue();
        }

        private void _InitProductsCombo()
        {
            DataTable products = clsProduct.FindAll();

            foreach (DataRow row in products.Rows)
            {
                cbProduct.Items.Add(row["ProductName"]);
            }

            cbProduct.SelectedIndex = 0;
        }

        private void _InitComboboxValue()
        {
            if (!string.IsNullOrEmpty(SelectedItem))
            {
                clsProduct product = clsProduct.FindByName(SelectedItem);
                Item = new OrderTypes.stOrderItem(product.ProductName, product.ProductID ?? -1, product.Quantity, product.Price);
            }
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsProduct product = clsProduct.FindByName(cbProduct.SelectedItem.ToString().ToString());

            if (product == null)
            {
                return;
            }

            lblRemainingQty.Text = product.Quantity.ToString();

            OrderTypes.stOrderItem tempItem = new OrderTypes.stOrderItem(Item.ProductText, product.ProductID ?? -1, Item.RemainingQuantity, product.Price);
            tempItem.ProductText = (cbProduct.SelectedItem != null) ? cbProduct.SelectedItem.ToString().Trim() : string.Empty;
            Item = tempItem;
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsUtil.IsNumberInput(e, tbQuantity.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                EnableAdding = false;
                RaiseOnItemAdded();
            }
        }
    }
}
