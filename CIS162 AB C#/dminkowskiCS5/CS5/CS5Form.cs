/*  David Minkowski
 *  CIS 162AD Fall 2017: Section 26696
 *  TCS5
 *  9/14/17
 *  
 *  This project uses if statements to validate the hours and pay rates entered.  If valid, the inputs are used
    to calculate employee's total pay by figuring overtime, union dues (if any) and applicable taxes. 
    If the # of hours worked are between 1 and 50, and if the pay rate is between 10 and 15 dollars, 
    the program will continue with it's calculations and keep track of multiple employees' average pay. 
    Otherwise, the program will notify the user of incorrect values and data formats and start over.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS5
{
    public partial class CS5Form : Form
    {
        public CS5Form()
        {
            InitializeComponent();
        }

        //declaring my class-level variables here:

        int cintEmployeeCount;
        decimal cdecTotalNetPay;

        const decimal cdecFICA_RATE = 0.06M;
        const decimal cdecFED_RATE = 0.15M;
        const decimal cdecSTATE_RATE = 0.05M;
        const decimal cdecNONE_UNION_DUES = 0.00M;
        const decimal cdecREGULAR_UNION_DUES = 5.00M;
        const decimal cdecSPECIAL_UNION_DUES = 10.00M;

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
            decimal decUnionDues; // we needed a variable for union dues since it can be set to 3 different values now

            //get input values with try-catch
            try
            {
                //convert # of hours into an integer variable (intHours) from user input
                intHours = int.Parse(txtHours.Text);
                try
                {
                    //convert payrate into a decimal variable (decPayRate) from user input
                    decPayRate = decimal.Parse(txtPayRate.Text);

                    //calculating overtime and gross pay

                    //first check if values are outside of acceptable range
                    //(10 and 15 dollars for pay, between 1 and 50 for hours)
                    if (intHours >= 1 && intHours <= 50)
                        if (decPayRate >= 10.00M && decPayRate <= 15.00M)
                        {
                            //if both statements are true, continue:
                            //determine if overtime is applicable to the hours worked (>40)

                            //if hours are < or equal to 40, calculate normal pay rate
                            if (intHours <= 40)
                                decGrossPay = intHours * decPayRate;
                            //otherwise, calculate 40 hours of straight time plus time and a half for the
                            //number of hours worked over 40
                            else
                                decGrossPay = (40 * decPayRate) + ((intHours - 40) * decPayRate * 1.5M);

                            //calulate each taxed amount to be subtracted from gross pay (fica, state, federal)

                            decFICATaxes = decGrossPay * cdecFICA_RATE;
                            decStateTaxes = decGrossPay * cdecSTATE_RATE;
                            decFedTaxes = decGrossPay * cdecFED_RATE;

                            //calculating union dues

                            //depending on which radio button is checked, decUnionDues will change to 0, 5 or 10 dollars
                            //default is set to 0

                            if (radRegular.Checked == true)
                                decUnionDues = cdecREGULAR_UNION_DUES; // 5 dollar dues
                            else if (radSpecial.Checked == true)
                                decUnionDues = cdecSPECIAL_UNION_DUES; // 10 dollar dues
                            else
                                decUnionDues = 0M; // default of 0 dollar dues


                            //find total net pay by subtracting taxes and union dues from gross pay
                            decNetPay = decGrossPay - (decFICATaxes + decStateTaxes + decFedTaxes + decUnionDues);

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
                            lblUnionDuesOut.Text = decUnionDues.ToString("C"); // this label will show each different value for the union dies as they change
                            lblNetPayOut.Text = decNetPay.ToString("C");
                            lblTotalNetOut.Text = cdecTotalNetPay.ToString("C");

                            //accumulators
                            lblEmployeeCountOut.Text = cintEmployeeCount.ToString("N0"); //this will remain an integer, not a currency
                            lblAvgNetPayOut.Text = decAverageNetPay.ToString("C");

                            txtHours.Focus();    //ready for input
                        }
                        else
                        {   // error handling for incorrect values for pay rate
                            MessageBox.Show("Pay Rate must be between $10.00 and $15.00. ",
                                "Data Entry Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                            txtPayRate.SelectAll();
                            txtPayRate.Focus();
                        }   // this ends the second "if" statement
                    else
                    {   // error handling for incorrect values for hours worked
                        MessageBox.Show("Hours must be between 1 and 50. ",
                            "Data Entry Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        txtHours.SelectAll();
                        txtHours.Focus();
                    }   //this ends the first "if" statement

                } // ends the inner "try" statement

                //exception handling for Pay Rate
                catch (FormatException err)
                {   // error handling for incorrect input formats for pay rate
                    MessageBox.Show("Pay Rate must be entered as a whole or decimal number. " + err.Message,
                        "Data Entry Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtPayRate.SelectAll();
                    txtPayRate.Focus();
                }
            } // ends the outer "try" statement

            catch (FormatException err)
            {   //error handling for incorrect input formats for hours
                MessageBox.Show("Hours must be entered as a whole number. " + err.Message,
                    "Data Entry Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtHours.SelectAll();
                txtHours.Focus();
            }

            // all other exceptions
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

            //reset radio buttons to default of "none"
            radNone.Checked = true;

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
