/*  David Minkowski
 *  CIS 162AD Fall 2017: Section 26696
 *  TCS10A
 *  10/31/2017
 *  
 *  Adding and removing items from a combo box menu
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

namespace CS10A
{
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            InitializeComponent();
        }

        private void mnuPrintPreview_Click(object sender, EventArgs e)
        {
            //Begin print preview by assigning PrintDocument
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            //Trigger the print process by calling the Print method
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Handle printing and print previews
            // printPreviewDialog1.ShowDialog() and printDocument1.Print() trigger
            // PrintPage event.

            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float fltLineHeight = printFont.GetHeight();
            float fltPrintX = e.MarginBounds.Left;
            float fltPrintY = e.MarginBounds.Top;
            string strPrintLine;

            //Print Headings
            strPrintLine = "Book List";
            e.Graphics.DrawString(strPrintLine, headingFont,
                Brushes.Black, fltPrintX, fltPrintY);
            strPrintLine = "Programmer: Dave Minkowski";
            fltPrintY += fltLineHeight;
            e.Graphics.DrawString(strPrintLine, headingFont,
                Brushes.Black, fltPrintX, fltPrintY);
            strPrintLine = "Books:";
            fltPrintY += fltLineHeight;
            e.Graphics.DrawString(strPrintLine, headingFont,
                Brushes.Black, fltPrintX, fltPrintY);

            //Leave a blank line between heading and detail line
            fltPrintY += fltLineHeight * 2;

            //Loop through the entire list
            for (int intIndex = 0; intIndex <= cboBookList.Items.Count - 1; intIndex++)
            {
                //Set up a line
                strPrintLine = cboBookList.Items[intIndex].ToString();
                //Send the line to the graphics page object
                e.Graphics.DrawString(strPrintLine, printFont,
                    Brushes.Black, fltPrintX, fltPrintY);

                //Increment the Y position for the next line
                fltPrintY += fltLineHeight;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            //Add a new book to the book list
            if (cboBookList.Text != "")
            {
                cboBookList.Items.Add(cboBookList.Text);
                cboBookList.Text = "";
            }
            else
            {
                MessageBox.Show("Enter a book title to add.", "Missing Entry.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cboBookList.Focus();
        }

        private void mnuRemoveBook_Click(object sender, EventArgs e)
        {
            //Remove the selected book from the list
            if (cboBookList.SelectedIndex != -1)
            {
                cboBookList.Items.RemoveAt(cboBookList.SelectedIndex);
            }
            else
            {
                MessageBox.Show("First select a title to remove.",
                    "No selection made.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mnuClearList_Click(object sender, EventArgs e)
        {
            //Clear the book list
            DialogResult responseDialogResult;

            responseDialogResult = MessageBox.Show("Really clear the book list?",
                "Clear book list", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (responseDialogResult == DialogResult.Yes)
            {
                cboBookList.Items.Clear();
            }
        }

        private void mnuDisplayBookCount_Click(object sender, EventArgs e)
        {
            //Display the number of books in the list
            MessageBox.Show("The number of books in the list is " + cboBookList.Items.Count.ToString() + ".");
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //Create an instance and display frmAbout 
            frmAbout frmAboutObj = new frmAbout();
            frmAboutObj.ShowDialog();   //.ShowDialog displays as a Modal Form
        }

    }
}
