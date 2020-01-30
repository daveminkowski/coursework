using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//CS3 by Dave Minkowski - CIS162AD

namespace CS3
{
    public partial class frmCS3 : Form
    {
        public frmCS3()
        {
            InitializeComponent();
        }

        //Declare class-level variables and constants
        //Class variables are initialized to zero when declared
        int cintOrderCount;
        decimal cdecGrandTotal;

        const decimal cdecTAX_RATE = 0.08M;
        const decimal cdecSHIPPING_AMT = 10.00M;


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare method variables
            int intQuantity;
            decimal decPrice;
            decimal decExtendedPrice;
            decimal decSalesTax;
            decimal decTotalDue;
            decimal decAverageOrder;

            //Input:
            //Use nested try-catch blocks to get the input values
            try
            {
                intQuantity = int.Parse(txtQuantity.Text);
                try
                {
                    decPrice = decimal.Parse(txtPrice.Text);

                    //Process:
                    //We now have a numeric quanitity and price.
                    //Continue processing by performing calculations.
                    decExtendedPrice = intQuantity * decPrice;
                    decSalesTax = decExtendedPrice * cdecTAX_RATE;
                    decTotalDue = cdecGrandTotal + decSalesTax + cdecSHIPPING_AMT;

                    //Accumulate summary Totals
                    cdecGrandTotal += decTotalDue;
                    cintOrderCount += 1;
                    decAverageOrder = cdecGrandTotal / cintOrderCount;


                    //Output:
                    //We now have all of the values to display
                    lblExtendedPrice.Text = decExtendedPrice.ToString("C");  //Currency
                    lblSalesTax.Text = decSalesTax.ToString("C");
                    lblShipping.Text = cdecSHIPPING_AMT.ToString("C");
                    lblTotalDue.Text = decTotalDue.ToString("C");

                    lblGrandTotal.Text = cdecGrandTotal.ToString("C");
                    lblNumberOfOrders.Text = cintOrderCount.ToString("N0"); //N and a Zero
                    lblAverageOrder.Text = decAverageOrder.ToString("C");
                }
                //Handle exceptions for price
                catch (FormatException err)
                {
                    MessageBox.Show("Price must be numeric. " + err.Message,
                        "Data Entry Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtPrice.SelectAll();
                    txtPrice.Focus();
                }
            }
            //Handle exceptions for quantity
            catch (FormatException err)
            {
                MessageBox.Show("Quantity must be numeric. " + err.Message,
                        "Data Entry Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                txtQuantity.SelectAll();
                txtQuantity.Focus();
            }
            //Handle any other exceptions. Exceptions not caught by the inner
            //Try will also end up here because that Try is inside the outer Try.

            catch (Exception err)
            {
                MessageBox.Show("Unexpected Error: " + err.Message);
            }

		}//end of btnCalculate


        private void btnClearForm_Click(object sender, EventArgs e)
        {
            //Use clear or null string "" for TextBoxes, but
            //only use null string "" for Labels

            txtQuantity.Clear();  //clear
            txtPrice.Clear();

            lblExtendedPrice.Text = "";  //null string
            lblSalesTax.Text = "";
            lblShipping.Text = "";
            lblTotalDue.Text = "";
            lblGrandTotal.Text = "";
            lblNumberOfOrders.Text = "";
            lblAverageOrder.Text = "";

            cdecGrandTotal = 0;    //Reset accumulators
            cintOrderCount = 0;

            txtQuantity.Focus();

        }//end of btnClearForm


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end of btnExit


    }//end of class
}//end of namespace