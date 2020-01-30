namespace CS12
{
    partial class frmCS12
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
            this.Label6 = new System.Windows.Forms.Label();
            this.lstId = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearchResults = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnSortById = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnLoadArrays = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lstRate = new System.Windows.Forms.ListBox();
            this.lstCode = new System.Windows.Forms.ListBox();
            this.lstName = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(14, 9);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 16);
            this.Label6.TabIndex = 51;
            this.Label6.Text = "Id:";
            // 
            // lstId
            // 
            this.lstId.Enabled = false;
            this.lstId.Location = new System.Drawing.Point(14, 41);
            this.lstId.Name = "lstId";
            this.lstId.Size = new System.Drawing.Size(56, 147);
            this.lstId.TabIndex = 43;
            this.lstId.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(318, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 36);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearchResults
            // 
            this.txtSearchResults.Enabled = false;
            this.txtSearchResults.Location = new System.Drawing.Point(110, 289);
            this.txtSearchResults.Name = "txtSearchResults";
            this.txtSearchResults.ReadOnly = true;
            this.txtSearchResults.Size = new System.Drawing.Size(280, 20);
            this.txtSearchResults.TabIndex = 50;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(6, 289);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 16);
            this.Label5.TabIndex = 49;
            this.Label5.Text = "Search Results:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(110, 249);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(280, 20);
            this.txtSearchName.TabIndex = 42;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(6, 249);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 23);
            this.Label4.TabIndex = 48;
            this.Label4.Text = "Search Name:";
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(238, 205);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(72, 36);
            this.btnSearchByName.TabIndex = 39;
            this.btnSearchByName.Text = "Search by Name";
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSortById
            // 
            this.btnSortById.Location = new System.Drawing.Point(86, 205);
            this.btnSortById.Name = "btnSortById";
            this.btnSortById.Size = new System.Drawing.Size(64, 36);
            this.btnSortById.TabIndex = 36;
            this.btnSortById.Text = "Sort by Id";
            this.btnSortById.Click += new System.EventHandler(this.btnSortById_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.Location = new System.Drawing.Point(158, 205);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(72, 36);
            this.btnSortByName.TabIndex = 38;
            this.btnSortByName.Text = "Sort by Name";
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnLoadArrays
            // 
            this.btnLoadArrays.Location = new System.Drawing.Point(6, 205);
            this.btnLoadArrays.Name = "btnLoadArrays";
            this.btnLoadArrays.Size = new System.Drawing.Size(72, 36);
            this.btnLoadArrays.TabIndex = 35;
            this.btnLoadArrays.Text = "Load Arrays";
            this.btnLoadArrays.Click += new System.EventHandler(this.btnLoadArrays_Click);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(342, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 16);
            this.Label3.TabIndex = 44;
            this.Label3.Text = "Rate:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(238, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 16);
            this.Label2.TabIndex = 41;
            this.Label2.Text = "Discount Code:";
            // 
            // lstRate
            // 
            this.lstRate.Enabled = false;
            this.lstRate.Location = new System.Drawing.Point(334, 41);
            this.lstRate.Name = "lstRate";
            this.lstRate.Size = new System.Drawing.Size(56, 147);
            this.lstRate.TabIndex = 47;
            // 
            // lstCode
            // 
            this.lstCode.Enabled = false;
            this.lstCode.Location = new System.Drawing.Point(254, 41);
            this.lstCode.Name = "lstCode";
            this.lstCode.Size = new System.Drawing.Size(56, 147);
            this.lstCode.TabIndex = 46;
            this.lstCode.TabStop = false;
            // 
            // lstName
            // 
            this.lstName.Enabled = false;
            this.lstName.Location = new System.Drawing.Point(86, 41);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(152, 147);
            this.lstName.TabIndex = 45;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(86, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "Customer Name:";
            // 
            // frmCS12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 324);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lstId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearchResults);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.btnSortById);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.btnLoadArrays);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lstRate);
            this.Controls.Add(this.lstCode);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.Label1);
            this.Name = "frmCS12";
            this.Text = "CS12 By Dave Minkowski";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ListBox lstId;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.TextBox txtSearchResults;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtSearchName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnSearchByName;
        internal System.Windows.Forms.Button btnSortById;
        internal System.Windows.Forms.Button btnSortByName;
        internal System.Windows.Forms.Button btnLoadArrays;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ListBox lstRate;
        internal System.Windows.Forms.ListBox lstCode;
        internal System.Windows.Forms.ListBox lstName;
        internal System.Windows.Forms.Label Label1;
    }
}

