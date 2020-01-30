//Dave Minkowski 9/8/17
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS2
{
    public partial class frmCS2 : Form
    {
        public frmCS2()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmCS2_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerRelations_Click(object sender, EventArgs e)
        {
            lblDepartmentName.Text = "Customer Relations";
            lblContactName.Text = "Tricia Smith";
            lblPhoneNumber.Text = "500-1111";
        }

        private void btnOrderProcessing_Click(object sender, EventArgs e)
        {
            lblDepartmentName.Text = "Order Processing";
            lblContactName.Text = "Kenna Ross";
            lblPhoneNumber.Text = "500-3333";
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            lblDepartmentName.Text = "Marketing";
            lblContactName.Text = "Michelle Tyler";
            lblPhoneNumber.Text = "500-2222";
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            lblDepartmentName.Text = "Shipping";
            lblContactName.Text = "Eric Johnson";
            lblPhoneNumber.Text = "500-4444";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
