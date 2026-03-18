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
    public partial class frmRestockProduct : CrownForm
    {
        private clsProduct _Product;
        private int _ProductId;

        public frmRestockProduct(int productID)
        {
            InitializeComponent();
            _ProductId = productID;
        }

        private void frmRestockProduct_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);

            _Product = clsProduct.Find(_ProductId);

            if (_Product == null)
            {
                MessageBox.Show("Invalid Product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //clsUtil.DisableCharactersInput(e);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            int quantity = Convert.ToInt32(tbQuantity.Text.Trim());
            
            if (_Product.RestockProduct(quantity))
            {
                MessageBox.Show("Product Restocked Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } else
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
