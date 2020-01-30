// CS4 by David Minkowski 9/9/17

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS4
{
    public partial class CS4Form : Form
    {
        public CS4Form()
        {
            InitializeComponent();
        }

        //declaring my class-level variables here:

        int cintEmployeeCount;
        decimal cdecTotalNetPay;

        const decimal cdecFICA_RATE = 0.06M;
        const decimal cdecFED_RATE = 0.15M;
        const decimal cdecSTATE_RATE = 0.05M;
        const decimal cdecUNION_DUES = 10.00M;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declaring method variables
            int intHours;
            decimal decPayRate;
            decimal decGrossPay;
            decimal decFICATaxes;
            decimal decStateTaxes;
            decimal decFedTaxes;
            decimal decNetPay;
            decimal decAverageNetPay;

            //get input values with try-catch
            try
            {
                //convert # of hours into an integer variable (intHours) from user input
                intHours = int.Parse(txtHours.Text);
                try
                {
                    //convert payrate into a decimal variable (decPayRate) from user input
                    decPayRate = decimal.Parse(txtPayRate.Text);

                    //calculating input values with constants

                    //calculate gross pay (hours x pay rate) and save as variable (decGrossPay)
                    decGrossPay = intHours * decPayRate;
                    //calulate each taxed amount to be subtracted from gross pay (fica, state, federal)
                    decFICATaxes = decGrossPay * cdecFICA_RATE;
                    decStateTaxes = decGrossPay * cdecSTATE_RATE;
                    decFedTaxes = decGrossPay * cdecFED_RATE;
                    //find total net pay by subtracting taxes and union dues from gross pay
                    decNetPay = decGrossPay - (decFICATaxes + decStateTaxes + decFedTaxes + cdecUNION_DUES);

                    //summary totals
                    //incrementing total net pay by each amount net pay is calculated per button click
                    cdecTotalNetPay += decNetPay;
                    //incrementing employee count by 1 per button click
                    cintEmployeeCount += 1;
                    //calculating average net pay (amounts minus taxes and union dues) for each employee's net total divided by
                    //the # of employees this calculation was performed. (set to decAverageNetPay)
                    decAverageNetPay = cdecTotalNetPay / cintEmployeeCount;

                    //converting values to display strings (in currency) for each output label on the form:
                    lblGrossPayOut.Text = decGrossPay.ToString("C");
                    lblFICATaxOut.Text = decFICATaxes.ToString("C");
                    lblStateTaxOut.Text = decStateTaxes.ToString("C");
                    lblFedTaxOut.Text = decFedTaxes.ToString("C");
                    lblUnionDuesOut.Text = cdecUNION_DUES.ToString("C");
                    lblNetPayOut.Text = decNetPay.ToString("C");
                    lblTotalNetOut.Text = cdecTotalNetPay.ToString("C");

                    //accumulators
                    lblEmployeeCountOut.Text = cintEmployeeCount.ToString("N0"); //this will remain an integer, not a currency
                    lblAvgNetPayOut.Text = decAverageNetPay.ToString("C");
                }
                //exception handling for Pay Rate
                catch (FormatException err)
                {
                    MessageBox.Show("Pay Rate must be entered as a whole or decimal number. " + err.Message,
                        "Data Entry Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtPayRate.SelectAll();
                    txtPayRate.Focus();
                }
            }
            //exception handling for hours
            catch (FormatException err)
            {
                MessageBox.Show("Hours must be entered as a whole number. " + err.Message,
                    "Data Entry Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtHours.SelectAll();
                txtHours.Focus();
            }

            catch (Exception err)
            {
                MessageBox.Show("Unexpected Error: " + err.Message);
            }
        } //end of btnCalc


        private void btnClear_Click(object sender, EventArgs e)
        {
           
            //clearing text fields
            txtHours.Clear(); 
            txtPayRate.Clear();

            //clearing output labels

            lblGrossPayOut.Text = "";
            lblFICATaxOut.Text = "";
            lblStateTaxOut.Text = "";
            lblFedTaxOut.Text = "";
            lblUnionDuesOut.Text = "";
            lblNetPayOut.Text = "";
            lblTotalNetOut.Text = "";
            lblEmployeeCountOut.Text = "";
            lblAvgNetPayOut.Text = "";

            //reset accumulators
            cdecTotalNetPay = 0;
            cintEmployeeCount= 0;

            //refocus on Hours field for more input
            txtHours.Focus();

        }//end btnclear

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }//end btnExit


    }//end of class
}//end of namespace
