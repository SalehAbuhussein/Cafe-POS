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
    public partial class frmProductManagement : CrownForm
    {
        private DataTable _productData;

        public frmProductManagement()
        {
            InitializeComponent();
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);
            _InitProductDgv();
            _InitCategories();
            _UpdateAddBtnPermission();
            cbFilter.SelectedIndex = 0;
        }

        private void _InitProductDgv()
        {
            _productData = clsProduct.FindAll();
            dgvProducts.DataSource = _productData;

            dgvProducts.Columns["ProductID"].HeaderText = "ID";
            dgvProducts.Columns["ProductName"].HeaderText = "Name";
            dgvProducts.Columns["Quantity"].HeaderText = "Qty";
            dgvProducts.Columns["IsRestockable"].HeaderText = "Restockable";
            dgvProducts.Columns["CreatedAt"].HeaderText = "Creation Date";

            lblCount.Text = _productData.Rows.Count.ToString();
        }

        private void _UpdateAddBtnPermission()
        {
            btnAdd.Enabled = clsCurrentUser.UserInfo.HasRole("owner") || clsCurrentUser.UserInfo.HasRole("cashier");
        }

        private void dgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            clsUtil.SetupGrid(dgvProducts);
        }

        private void _InitCategories()
        {
            DataTable categories = clsCategory.FindAll();

            cbCategory.Items.Add("All");

            foreach (DataRow dataRow in categories.Rows)
            {
                cbCategory.Items.Add(dataRow["CategoryName"]);
            }

            cbCategory.SelectedIndex = 0;
            cbCategory.Visible = false;
        }

        private string _FieldsMapper(string field)
        {
            switch (field)
            {
                case "Product ID":
                    return "ProductID";
                case "Name":
                    return "ProductName";
                case "Category":
                    return "CategoryID";
                default:
                    return "";
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Text = string.Empty;
            _productData.DefaultView.RowFilter = "";
            lblCount.Text = "0";
            tbFilter.Visible = cbFilter.SelectedItem.ToString() != "Category";
            cbCategory.Visible = cbFilter.SelectedItem.ToString() == "Category";
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem.ToString() != "All")
            {
                _productData.DefaultView.RowFilter = "[CategoryID] = " + clsCategory.FindByName(cbCategory.SelectedItem.ToString()).CategoryID;
            } else
            {
                _productData.DefaultView.RowFilter = "";
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                switch (_FieldsMapper(cbFilter.Text))
                {
                    case "ProductName":
                        _productData.DefaultView.RowFilter = "[ProductName] like '%" + tbFilter.Text.Trim() + "%'";
                        break;
                    case "ProductID":
                        _productData.DefaultView.RowFilter = "[ProductID] = " + tbFilter.Text.Trim();
                        break;
                    case "":
                        _productData.DefaultView.RowFilter = "";
                        break;
                }
            } else
            {
                _productData.DefaultView.RowFilter = "";
            }

            lblCount.Text = _productData.DefaultView.Count.ToString();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilter.Text)
            {
                case "Product ID":
                    e.Handled = !clsUtil.IsNumberInput(e, tbFilter.Text);
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frm = new frmAddEditProduct(-1);
            frm.ShowDialog();
            frmProductManagement_Load(null, null);
        }

        private void restockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
            frmRestockProduct frm = new frmRestockProduct(productID);
            frm.ShowDialog();
            frmProductManagement_Load(null, null);
        }

        private void productInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
            frmProductInfo frm = new frmProductInfo(productID);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);

            if (
                MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) 
                ==
                DialogResult.OK
            )
            {
                if (clsProduct.DeleteProduct(productID))
                {
                    frmProductManagement_Load(null, null);
                    MessageBox.Show("Product Deleted Successfully", "Success", MessageBoxButtons.OK);
                } else
                {
                    MessageBox.Show("Something went wrong with delete operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}