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
    public partial class frmProductInfo : CrownForm
    {
        private int _ProductID;
        public clsProduct ProductInfo
        {
            get
            {
                return ctrlProductInfo1.ProductInfo;
            }
        }

        public frmProductInfo(int productID)
        {
            InitializeComponent();
            _ProductID = productID;
        }

        private void frmProductInfo_Load(object sender, EventArgs e)
        {
            clsUtil.ApplyRoundedCorners(20, this);
            ctrlProductInfo1.LoadPersonInfo(_ProductID);
        }
    }
}
