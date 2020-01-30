namespace CS10A
{
    partial class frmBookList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookList));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayBookCount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBookList = new System.Windows.Forms.Label();
            this.cboBookList = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrintPreview,
            this.mnuPrint,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Name = "mnuPrintPreview";
            this.mnuPrintPreview.Size = new System.Drawing.Size(143, 22);
            this.mnuPrintPreview.Text = "Print Preview";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(143, 22);
            this.mnuPrint.Text = "Print";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(143, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBook,
            this.mnuRemoveBook,
            this.mnuClearList,
            this.mnuDisplayBookCount});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuAddBook
            // 
            this.mnuAddBook.Name = "mnuAddBook";
            this.mnuAddBook.Size = new System.Drawing.Size(178, 22);
            this.mnuAddBook.Text = "Add Book";
            this.mnuAddBook.Click += new System.EventHandler(this.mnuAddBook_Click);
            // 
            // mnuRemoveBook
            // 
            this.mnuRemoveBook.Name = "mnuRemoveBook";
            this.mnuRemoveBook.Size = new System.Drawing.Size(178, 22);
            this.mnuRemoveBook.Text = "Remove Book";
            this.mnuRemoveBook.Click += new System.EventHandler(this.mnuRemoveBook_Click);
            // 
            // mnuClearList
            // 
            this.mnuClearList.Name = "mnuClearList";
            this.mnuClearList.Size = new System.Drawing.Size(178, 22);
            this.mnuClearList.Text = "Clear Book List";
            this.mnuClearList.Click += new System.EventHandler(this.mnuClearList_Click);
            // 
            // mnuDisplayBookCount
            // 
            this.mnuDisplayBookCount.Name = "mnuDisplayBookCount";
            this.mnuDisplayBookCount.Size = new System.Drawing.Size(178, 22);
            this.mnuDisplayBookCount.Text = "Display Book Count";
            this.mnuDisplayBookCount.Click += new System.EventHandler(this.mnuDisplayBookCount_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // lblBookList
            // 
            this.lblBookList.AutoSize = true;
            this.lblBookList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookList.Location = new System.Drawing.Point(105, 73);
            this.lblBookList.Name = "lblBookList";
            this.lblBookList.Size = new System.Drawing.Size(75, 19);
            this.lblBookList.TabIndex = 1;
            this.lblBookList.Text = "Book List:";
            // 
            // cboBookList
            // 
            this.cboBookList.DropDownWidth = 121;
            this.cboBookList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBookList.FormattingEnabled = true;
            this.cboBookList.Items.AddRange(new object[] {
            "How To Program",
            "Introduction to Programming",
            "Object-Oriented Programming",
            "Problem Solving and Programming",
            "Program Design and Data Structures"});
            this.cboBookList.Location = new System.Drawing.Point(42, 101);
            this.cboBookList.MinimumSize = new System.Drawing.Size(200, 0);
            this.cboBookList.Name = "cboBookList";
            this.cboBookList.Size = new System.Drawing.Size(200, 23);
            this.cboBookList.TabIndex = 2;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.cboBookList);
            this.Controls.Add(this.lblBookList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBookList";
            this.Text = "CS10A By Dave Minkowski";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveBook;
        private System.Windows.Forms.ToolStripMenuItem mnuClearList;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayBookCount;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Label lblBookList;
        private System.Windows.Forms.ComboBox cboBookList;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

