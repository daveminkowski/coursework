/* Project:         CS12 Array Processing
 * Name:            Dave Minkowski
 * Course:          CIS 162 AD Fall 2017: Section 26696
 * Assignment:      TCS12 
 * Date:            11/15/17
 * Description:     Load a list of Customer Ids, Names, and Discount Codes from a file.
 *                  The list can hold up to 10 customers.
 *                  Data is displayed in list boxes
 *                  The user can sort the list by Id or Name and search by name.
 *  
 *  Code Rate
 *      A      0.03    Administrators
 *      F      0.05    Faculty
 *      S      0.10    Student
 *      X      0.00    No Discount
 *      
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;  // FileStream and StreamReader

namespace CS12
{
    public partial class frmCS12 : Form
    {
        public frmCS12()
        {
            InitializeComponent();
        }

        //Declare class-level arrays

        const int ARRAY_SIZE = 10;  //to be the max number of elements in the array
                
        int[] identifier = new int[ARRAY_SIZE]; //personal ID
        string[] customerName = new string[ARRAY_SIZE]; //name
        string[] discountCode = new string[ARRAY_SIZE]; // discount code   
        decimal[] discountRate = new decimal[ARRAY_SIZE]; // discount % rate

        //Declare constant arrays
        //Size of array determined by the number of values provided.
        decimal[] constDISCOUNT_RATES = new decimal[] { .03M, .05M, .10M, 0.0M}; // index 0,1,2,3 for discount rates
        string[] constDISCOUNT_CODES = new string[] { "A", "F", "S", "X"}; // index 0,1,2,3 for discount codes

        int NumOfCustomers;
        //Use NumOfCustomers to process arrays because arrays 
        //may be partially loaded.  Count set in LoadArrays.

        private void btnLoadArrays_Click(object sender, EventArgs e)
        {
            int i = 0; // subscript initialized to zero

            //Note:
            //cstrName.Length is the number of entries that can be loaded.
            //The last valid subscript value is one less than Length.
            //cstrName.GetUpperBound(0) is last valid subscript value.
            //In this example:
            //   cstrName.Length = 10
            //   cstrName.GetUpperBound(0) = 9

            try
            {
                //Load the arrays with the data in the file
                FileStream customerFile = new FileStream("cs12.txt", FileMode.Open);
                StreamReader customerStreamReader = new StreamReader(customerFile);

                while (customerStreamReader.Peek() != -1) //reads until there is no more data in the file to read
                {
                    if (i < customerName.Length)
                    {
                        identifier[i] = Convert.ToInt32(customerStreamReader.ReadLine());
                        customerName[i] = customerStreamReader.ReadLine();
                        discountCode[i] = customerStreamReader.ReadLine();
                        i++;  //Increment subscript by one
                    }
                    else
                    {
                        MessageBox.Show
                            ("Error: Notify Programmer Array Size Exceeded. ",
                            "Array Size Exceeded", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        break; //Get of out of loop; Arrays are full.
                    }//End If
                }//End Loop

                customerFile.Close();      //Close file
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Opening File. Data not loaded " + ex.Message,
                     "File Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            NumOfCustomers = i;    //Save how many students were loaded
            assignDiscountRate();         //assign Letter Grade
            displayArrays();             //display arrays in list boxes
            btnLoadArrays.Enabled = false;  //Load array only once
        }

        void assignDiscountRate()
        {
            int s;
            int g;

            //outer loop walks through customers
            //inner loop looks up discount rate

            for (s = 0; s < NumOfCustomers; s++)
            {
                for (g = 0; g <= discountRate.GetUpperBound(0); g++)
                {
                    if (discountCode[s] == constDISCOUNT_CODES[g])
                    {
                        discountRate[s] = constDISCOUNT_RATES[g];
                        break; //exit inner for loop
                    }
                }//next g - rate
            }//next s - customer
        }

        void displayArrays()
        {
            int i;

            //Listboxes need to be cleared because this procedure
            //is also called to redisplayed the data.

            lstId.Items.Clear();
            lstName.Items.Clear();
            lstRate.Items.Clear();
            lstCode.Items.Clear();
 
            for (i = 0; i < NumOfCustomers; i++)
            {
                lstId.Items.Add(identifier[i]);
                lstName.Items.Add(customerName[i]);
                lstRate.Items.Add(discountRate[i].ToString("N2"));  // 2 decimal places
                lstCode.Items.Add(discountCode[i]);
            }//next i - customer
        }

        private void btnSortById_Click(object sender, EventArgs e)
        {

        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }//end of class
}//end of namespace
