using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Product.Controls
{
    public partial class ctrlProductInfo : UserControl
    {
        private clsProduct _Product;
        public clsProduct ProductInfo
        {
            get { return _Product; }
        }

        public ctrlProductInfo()
        {
            InitializeComponent();
        }

        public bool LoadPersonInfo(int personID)
        {
            _Product = clsProduct.Find(personID);

            if (_Product == null)
            {
                _ResetInfo();
                MessageBox.Show("Invalid product info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            lblProductName.Text = _Product.ProductName;
            lblCategory.Text = _Product.CategoryInfo.CategoryName;
            lblQuantity.Text = _Product.Quantity.ToString();
            lblPrice.Text = _Product.Price.ToString();

            return true;
        }

        private void _ResetInfo()
        {
            this._Product = null;
            lblProductName.Text = "[????]";
            lblPrice.Text = "[????]";
            lblCategory.Text = "[????]";
            lblQuantity.Text = "[????]";
        }
    }
}
