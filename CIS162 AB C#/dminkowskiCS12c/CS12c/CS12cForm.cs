/*  David Minkowski
 *  CIS 162AD Fall 2017: Section 26696
 *  TCS 12c
 *  11/20/2017
 *  
 *  Using nested loops to load, display and search 2 dimensional arrays which are
 *  used to build a multiplication table. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//CS12c by Your Name
 
namespace CS12c
{
    public partial class frmCS12c : Form
    {
      
        int [ , ] intTable = new int[9,9];  // 9 x 9 table (2d array)
        
        public frmCS12c()
        {
            InitializeComponent();
            btnWhileLoop.Enabled = false;
            btnSearchArray.Enabled = false;
            txtSearchNumber.Enabled = false;
        }

        private void btnLoadArray_Click(object sender, EventArgs e)
        {
            txtTable.Clear();
            txtTable.Refresh();
            btnWhileLoop.Enabled = true;
            btnSearchArray.Enabled = true;
            txtSearchNumber.Enabled = true;

            int r; //row
            int c; //column

            int intResult; //multiplication result

            int intRows = intTable.GetLength(0);
            int intCols = intTable.GetLength(1);

            for (r = 0; r < intRows; r++)
            {
                for (c = 0; c < intCols; c++)
                {
                    intResult = (r + 1) * (c + 1);
                    intTable[r, c] = intResult; 
                }
            }
            txtTable.AppendText("Array Loaded!");  
        }
 
        //Modify the nested for loops used above to nested while loops
        private void btnDisplayArray_Click(object sender, EventArgs e)
        {

            txtTable.Clear();
            txtTable.Refresh();

            int r; //row
            int c; //column
            int intResult; //multiplication result
            String strSpace;

            int intRows = intTable.GetLength(0);
            int intCols = intTable.GetLength(1);

            r = 0;
            while (r < intRows)
            {
                c = 0;
                while (c < intCols)
                {
                    intResult = (r + 1) * (c + 1);
                    intTable[r, c] = intResult;

                    if (intResult < 10)
                        strSpace = "  ";
                    else
                        strSpace = " "; 
                    txtTable.AppendText(strSpace);
                    txtTable.AppendText(intResult.ToString());
                    c++;
                }
                txtTable.AppendText("\r\n");
                r++;
            }
        }

        private void btnSearchArray_Click(object sender, EventArgs e)
        {
            txtTable.Clear();

            int r; //row
            int c; //column
            int intRows = intTable.GetLength(0);
            int intCols = intTable.GetLength(1);
            int intSearchNumber;

            //Not enclosed in a try-catch; make you enter a number in textbox
            intSearchNumber = int.Parse(txtSearchNumber.Text);

            for (r = 0; r < intRows; r++)
            {
                for (c = 0; c < intCols; c++)
                {

                    if (intSearchNumber == intTable[r, c])
                    txtTable.AppendText(intTable[r, c].ToString() + " is located in " + r + ", " + c + "\r\n");

                    txtSearchNumber.Focus();

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }//end of form
}//end of namespace