/*  David Minkowski
 *  CIS 162AD Fall 2017: Section 26696
 *  TCS10B
 *  10/31/2017
 *  
 *  Converting nested loops into nested do-while and for-loops
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace CS10b
{
    public partial class frmCS10b : Form
    {
        public frmCS10b()
        {
            InitializeComponent();
        }


        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            int r = 0; //row
            int c = 0; //column
            int intResult;
            string strSpace;

            txtTable.Clear();    //clear the text box
            txtTable.Refresh();  //refresh the form before exiting the method
            Thread.Sleep(1000);  //wait one second to see the clear text box

            //Outer loop goes down the rows
            r = 1;   //initialize r
            while (r < 10)
            {
                //Inner loop goes across the columns
                c = 1;    //initialize c
                while (c < 10)
                {
                    intResult = r * c;

                    if (intResult < 10)
                        strSpace = "  ";  //two spaces 
                    else
                        strSpace = " ";   //one space
                    txtTable.AppendText(strSpace); // insert space

                    txtTable.AppendText(intResult.ToString());  //insert result
                    c++;  //increment c
                }

                txtTable.AppendText("\r\n");  //Move down one line
                r++;  //increment r
            }
        }

        private void btnDoWhileLoop_Click(object sender, EventArgs e)
        {
            int intResult;
            string strSpace;
            int r = 1;  // r must be declared here to be used in the loop
            int c = 1;  // however, c does not have to be declared here since it must be "reset" to 1 within the loop

            txtTable.Clear(); 
            txtTable.Refresh();  
            Thread.Sleep(1000); 
            do
            {
                c = 1; // declaration could be here instead - int c = 1;
                if (r > 1)
                    txtTable.AppendText("\r\n"); // only move down one line AFTER the first row of numbers is entered. if (r >= 2) also works to serve the same purpose
                do
                {
                    // math and formatting while c is < 10
                    intResult = r * c;

                    if (intResult < 10)
                        strSpace = "  ";  //two spaces 
                    else
                        strSpace = " ";   //one space
                    txtTable.AppendText(strSpace); // insert space

                    txtTable.AppendText(intResult.ToString());  //insert result
                    c++;  //increment c

                    // this loop must be repeated until c is 9, at which point we can move down one row and begin filling in those values
                }

                while (c < 10);  // the while check is performed at the end of the loop

                r++;    // increment r only after the first row of numbers is complete, or the calculation will be thrown off within the loop
                        // at this point in the first do-while loop, r is incremented and the first loop will repeat, requiring the active table row to be moved down
                        // by 1. This means the c variable must be reset to begin a new row of multiplication. r does not have to be reset in this way, since the incremented
                        // value of r will always be a product of the table (each row)
            }
            while (r < 10); // continue the loops for the table until all the fields (9x9) have been filled
            
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {

            int intResult;
            string strSpace;

            txtTable.Clear();    //clear the text box
            txtTable.Refresh();  //refresh the form before exiting the method
            Thread.Sleep(1000);  //wait one second to see the clear text box

            // r is declared and initialized in the same step here in the for loop:
            for (int r = 1; r < 10; r++)
            {
                // c is declared and initialized in the same step here in the for loop:
                for (int c = 1; c < 10; c++)
                {
                    intResult = r * c;

                    if (intResult < 10)
                        strSpace = "  ";  //two spaces 
                    else
                        strSpace = " ";   //one space
                    txtTable.AppendText(strSpace); // insert space

                    txtTable.AppendText(intResult.ToString());  //insert result
                }

                txtTable.AppendText("\r\n");  //Move down one line
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }//end of form
}//end of namespace