/*  David Minkowski
 *  CIS 162AD Fall 2017: Section 26696
 *  TCS11
 *  11/08/2017
 *  
 *  Adding and removing items from a combo box menu, saving and editing text files/entries to a list
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
using System.IO;

namespace CS10A
{
    public partial class frmBookList : Form
    {
        //Use a flag to track if the data has been changed but not saved
        //Set to true as the default; set to false when the user makes a change
        private bool cblnIsDataSaved = true;

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

        private void mnuLoad_Click(object sender, EventArgs e)
        {
             //Not checking if a list has already been loaded
            string strFileName;
            string strBookName;

           //Open the file and load the list box with the data stored in the file
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" ;
                openFileDialog1.FilterIndex = 1; // At first only show text files.
                openFileDialog1.InitialDirectory = Application.StartupPath; //default folder
                openFileDialog1.RestoreDirectory = true;  // restore path to default folder

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    strFileName = openFileDialog1.FileName;
                    FileStream booksFileIn = new FileStream(strFileName, FileMode.Open);
                    StreamReader booksStreamReader = new StreamReader(booksFileIn);
                    while (booksStreamReader.Peek() != -1)
                    {
                        strBookName = booksStreamReader.ReadLine();
                        cboBookList.Items.Add(strBookName);
                    }
                    booksStreamReader.Close();
                }
                else
                {
                    MessageBox.Show("File not selected; List was not loaded.",
                            "List Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Selected file could not be opened.",
                        "Error Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            string strFileName;
            int intIndex, intMaximum;
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1; // At first only show text files.
                saveFileDialog1.CheckFileExists = false; // Allow user to create file
                saveFileDialog1.InitialDirectory = Application.StartupPath; //default folder
                saveFileDialog1.RestoreDirectory = true;  // restore path to default folder

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    strFileName = saveFileDialog1.FileName;
                    FileStream booksFileOut = new FileStream(strFileName, FileMode.Create);
                    StreamWriter booksStreamWriter = new StreamWriter(booksFileOut);

                    intMaximum = cboBookList.Items.Count;
                    for (intIndex = 0; intIndex < intMaximum; intIndex++)
                    {
                        booksStreamWriter.WriteLine(cboBookList.Items[intIndex]);
                    }
                    booksStreamWriter.Close();
                    cblnIsDataSaved = true;  //reset flag after saving data
                }
            }
            catch
            {
                MessageBox.Show("Error saving the changes to the data file.",
                        "Error Saving Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            //Add a new coffee flavor to the coffee list
            if (cboBookList.Text != "")
            {
                cboBookList.Items.Add(cboBookList.Text);
                cboBookList.Text = "";
                cblnIsDataSaved = false;
            }
            else
            {
                MessageBox.Show("Enter a coffee flavor to add", "Missing data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cboBookList.Focus();
        }

        private void mnuRemoveBook_Click(object sender, EventArgs e)
        {
            //Remove the selected coffee from list
            if (cboBookList.SelectedIndex != -1)
            {
                cboBookList.Items.RemoveAt(cboBookList.SelectedIndex);
                cblnIsDataSaved = false;
            }
            else
            {
                MessageBox.Show("First select the coffee to remove",
                    "No selection made", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mnuClearList_Click(object sender, EventArgs e)
        {
            //Clear the book list
            DialogResult responseDialogResult;

            responseDialogResult = MessageBox.Show("Really clear the book list?",
                "Clear book list?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (responseDialogResult == DialogResult.Yes)
            {
                cboBookList.Items.Clear();
                cblnIsDataSaved = false;
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

        private void frmBookList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //After writing this method to handle the FormClosing event, its needs to
            //be assigned as the form's FormClosing event handler while in Design Mode.
            //After assigning it to the form, the method is automatically executed 
            //when the form is instructed to close.

            //If changes have not been saved, ask user if they want to save the changes

            DialogResult responseDialogResult;

            if (cblnIsDataSaved == false)
            {
                responseDialogResult = MessageBox.Show("Book list has changed. Save the list?",
                        "Book List Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    mnuSave_Click(mnuSave, new System.EventArgs());
                }
                if (responseDialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true; //cancel close event
                }
            }
        }
    }
}
