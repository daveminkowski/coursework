/*  David Minkowski
 *  CIS 162AD Fall 2017: Section 26696
 *  TCS7
 *  10/5/2017
 *  
 *  Definining classes (clsOrder and clsCustomer)
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS8
{
    public partial class frmCS8 : Form
    {
        public frmCS8()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strMailingLabel;

            try
            {
                //Create an instance of clsCustomer using the overloaded constructor
                clsCustomer cobjCustomer = new clsCustomer(txtName.Text, txtStreet.Text,
                                    txtCity.Text, txtState.Text, txtZip.Text);

                //Build mailing label using the Get methods for Customer.
                strMailingLabel = cobjCustomer.Name + "\n" +
                                  cobjCustomer.Street + "\n" +
                                  cobjCustomer.City + ", " +
                                  cobjCustomer.State + "  " + cobjCustomer.Zip;

                //Display mailing address
                lblMailingLabel.Text = strMailingLabel;

                //Create an instance of clsOrder using the overloaded constructor
                clsOrder cobjOrder = new clsOrder
                    (txtDescription.Text,
                     int.Parse(txtQuantity.Text),
                     decimal.Parse(txtPrice.Text));

                //Test the calculate Extended Price method
                cobjOrder.calcExtendedPrice();

                //Update the totals in shared variables.
                cobjOrder.accumulateTotals();

                //Test the Get property method of extended priced
                lblExtension.Text = cobjOrder.ExtendedPrice.ToString("C");

                //Shared properties are accessed using class name
                //Test the Get Property methods of ReadOnly Shared properties 
                lblTotalCount.Text = clsOrder.TotalCount.ToString("N0");
                lblTotalPrice.Text = clsOrder.TotalPrice.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message
                                + "\n" + ex.StackTrace,
                                "Try/Catch - Unexpected Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end try
        }


        private void btnNextItem_Click(object sender, EventArgs e)
        {
            //clear the item fields
            txtDescription.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            lblExtension.Text = "";

            txtDescription.Focus();
        }


        private void btnResetSummary_Click(object sender, EventArgs e)
        {
            //Reset totals using the class name to access the shared method
            clsOrder.resetTotals();

            lblTotalPrice.Text = "";
            lblTotalCount.Text = "";
            lblMailingLabel.Text = "";

            //Clear the rest of the form using next item method
            btnNextItem_Click(sender, e);    
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}