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

namespace Cafe_Management_System.Product
{
    public partial class frmAddEditProduct : CrownForm
    {
        public enum enMode
        {
            Add,
            Update,
        }

        private clsProduct _Product;
        private int _ProductID;
        private enMode _Mode;
        
        public frmAddEditProduct(int productID)
        {
            InitializeComponent();

            if (productID != -1)
            {
                _ProductID = productID;
                _Mode = enMode.Update;
            } else
            {
                _ProductID = -1;
                _Mode = enMode.Add;
            }
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);
            _InitCategoriesCombo();

            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add Product";
                return;
            } else
            {
                lblTitle.Text = "Update Product";
            }

            _Product = clsProduct.Find(_ProductID);

            if (_Product != null)
            {
                MessageBox.Show("Invalid person data!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            tbName.Text = _Product.ProductName;
            tbQuantity.Text = _Product.Quantity.ToString();
            cbCategory.SelectedIndex = cbCategory.FindString(_Product.ProductName);
            cbIsRestockable.Checked = _Product.IsRestockable;
        }

        private void _InitCategoriesCombo()
        {
            DataTable categories = clsCategory.FindAll();

            foreach (DataRow row in categories.Rows)
            {
                cbCategory.Items.Add(row["CategoryName"]);
            }

            cbCategory.SelectedIndex = 0;
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsUtil.IsNumberInput(e, tbQuantity.Text);
        }

        private void tbQuantity_Validating(object sender, CancelEventArgs e)
        {
            string quantity = tbQuantity.Text.Trim();
            if (string.IsNullOrEmpty(quantity))
            {
                errorProvider1.SetError(tbQuantity, "Qunatity can not be empty!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbQuantity, null);
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            string name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(tbName, "Product name can not be empty!");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            string price = tbPrice.Text.Trim();
            e.Handled = !clsUtil.IsNumberInput(e, price, true);
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            string price = tbPrice.Text.Trim();
            if (string.IsNullOrEmpty(price))
            {
                errorProvider1.SetError(tbPrice, "Qunatity can not be empty!");
                e.Cancel = true;
            }
            else if (price.StartsWith("."))
            {
                errorProvider1.SetError(tbPrice, "Price can not start with decimal point!");
                e.Cancel = true;
            }
            else if (price.Count(c => c == '.') > 1 || price.EndsWith("."))
            {
                errorProvider1.SetError(tbPrice, "Price format is invalid!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPrice, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if (_Product == null)
            {
                _Product = new clsProduct();
            }

            string name = tbName.Text.Trim();
            string quantity = tbQuantity.Text.Trim();
            string category = cbCategory.SelectedItem.ToString();
            string price = tbPrice.Text.Trim();

            _Product.ProductName = name;
            _Product.Quantity = Convert.ToInt32(quantity);
            _Product.CategoryID = clsCategory.FindByName(cbCategory.SelectedItem.ToString()).CategoryID;
            _Product.IsRestockable = cbIsRestockable.Checked;
            _Product.Price = Convert.ToDecimal(price);

            if (_Product.Save())
            {
                lblTitle.Text = "Update Product";
                MessageBox.Show("Product Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
