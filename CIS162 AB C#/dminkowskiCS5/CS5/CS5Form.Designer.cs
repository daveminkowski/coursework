namespace CS5
{
    partial class CS5Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS5Form));
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbxTop = new System.Windows.Forms.GroupBox();
            this.bgoxUnionDues = new System.Windows.Forms.GroupBox();
            this.radSpecial = new System.Windows.Forms.RadioButton();
            this.radRegular = new System.Windows.Forms.RadioButton();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.gbxMiddle = new System.Windows.Forms.GroupBox();
            this.lblFICATaxOut = new System.Windows.Forms.Label();
            this.lblStateTaxOut = new System.Windows.Forms.Label();
            this.lblFedTaxOut = new System.Windows.Forms.Label();
            this.lblUnionDuesOut = new System.Windows.Forms.Label();
            this.lblNetPayOut = new System.Windows.Forms.Label();
            this.lblGrossPayOut = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblFICATax = new System.Windows.Forms.Label();
            this.lblStateTax = new System.Windows.Forms.Label();
            this.lblFedTax = new System.Windows.Forms.Label();
            this.lblUnionDues = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.gbxBottom = new System.Windows.Forms.GroupBox();
            this.lblEmployeeCountOut = new System.Windows.Forms.Label();
            this.lblAvgNetPayOut = new System.Windows.Forms.Label();
            this.lblTotalNetOut = new System.Windows.Forms.Label();
            this.lblTotalNet = new System.Windows.Forms.Label();
            this.lblEmployeeCount = new System.Windows.Forms.Label();
            this.lblAvgNetPay = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picSecurity = new System.Windows.Forms.PictureBox();
            this.picFolder = new System.Windows.Forms.PictureBox();
            this.gbxTop.SuspendLayout();
            this.bgoxUnionDues.SuspendLayout();
            this.gbxMiddle.SuspendLayout();
            this.gbxBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(109, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(272, 26);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Pay Calculator With Validation";
            // 
            // gbxTop
            // 
            this.gbxTop.Controls.Add(this.bgoxUnionDues);
            this.gbxTop.Controls.Add(this.txtPayRate);
            this.gbxTop.Controls.Add(this.txtHours);
            this.gbxTop.Controls.Add(this.lblPayRate);
            this.gbxTop.Controls.Add(this.lblHours);
            this.gbxTop.Location = new System.Drawing.Point(38, 33);
            this.gbxTop.Name = "gbxTop";
            this.gbxTop.Size = new System.Drawing.Size(420, 172);
            this.gbxTop.TabIndex = 0;
            this.gbxTop.TabStop = false;
            // 
            // bgoxUnionDues
            // 
            this.bgoxUnionDues.Controls.Add(this.radSpecial);
            this.bgoxUnionDues.Controls.Add(this.radRegular);
            this.bgoxUnionDues.Controls.Add(this.radNone);
            this.bgoxUnionDues.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgoxUnionDues.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bgoxUnionDues.Location = new System.Drawing.Point(41, 103);
            this.bgoxUnionDues.Name = "bgoxUnionDues";
            this.bgoxUnionDues.Size = new System.Drawing.Size(335, 55);
            this.bgoxUnionDues.TabIndex = 6;
            this.bgoxUnionDues.TabStop = false;
            this.bgoxUnionDues.Text = "Union Dues";
            // 
            // radSpecial
            // 
            this.radSpecial.AutoSize = true;
            this.radSpecial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSpecial.ForeColor = System.Drawing.Color.Black;
            this.radSpecial.Location = new System.Drawing.Point(241, 24);
            this.radSpecial.Name = "radSpecial";
            this.radSpecial.Size = new System.Drawing.Size(73, 23);
            this.radSpecial.TabIndex = 2;
            this.radSpecial.TabStop = true;
            this.radSpecial.Text = "Special";
            this.radSpecial.UseVisualStyleBackColor = true;
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRegular.ForeColor = System.Drawing.Color.Black;
            this.radRegular.Location = new System.Drawing.Point(125, 24);
            this.radRegular.Name = "radRegular";
            this.radRegular.Size = new System.Drawing.Size(77, 23);
            this.radRegular.TabIndex = 1;
            this.radRegular.TabStop = true;
            this.radRegular.Text = "Regular";
            this.radRegular.UseVisualStyleBackColor = true;
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Checked = true;
            this.radNone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNone.ForeColor = System.Drawing.Color.Black;
            this.radNone.Location = new System.Drawing.Point(25, 24);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(61, 23);
            this.radNone.TabIndex = 0;
            this.radNone.TabStop = true;
            this.radNone.Text = "None";
            this.radNone.UseVisualStyleBackColor = true;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayRate.Location = new System.Drawing.Point(218, 59);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(158, 27);
            this.txtPayRate.TabIndex = 3;
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(218, 20);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(158, 27);
            this.txtHours.TabIndex = 1;
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(37, 59);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(81, 23);
            this.lblPayRate.TabIndex = 2;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(37, 24);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(126, 23);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Hours Worked:";
            // 
            // gbxMiddle
            // 
            this.gbxMiddle.Controls.Add(this.lblFICATaxOut);
            this.gbxMiddle.Controls.Add(this.lblStateTaxOut);
            this.gbxMiddle.Controls.Add(this.lblFedTaxOut);
            this.gbxMiddle.Controls.Add(this.lblUnionDuesOut);
            this.gbxMiddle.Controls.Add(this.lblNetPayOut);
            this.gbxMiddle.Controls.Add(this.lblGrossPayOut);
            this.gbxMiddle.Controls.Add(this.lblGrossPay);
            this.gbxMiddle.Controls.Add(this.lblFICATax);
            this.gbxMiddle.Controls.Add(this.lblStateTax);
            this.gbxMiddle.Controls.Add(this.lblFedTax);
            this.gbxMiddle.Controls.Add(this.lblUnionDues);
            this.gbxMiddle.Controls.Add(this.lblNetPay);
            this.gbxMiddle.Location = new System.Drawing.Point(38, 208);
            this.gbxMiddle.Name = "gbxMiddle";
            this.gbxMiddle.Size = new System.Drawing.Size(420, 262);
            this.gbxMiddle.TabIndex = 1;
            this.gbxMiddle.TabStop = false;
            // 
            // lblFICATaxOut
            // 
            this.lblFICATaxOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFICATaxOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFICATaxOut.Location = new System.Drawing.Point(218, 64);
            this.lblFICATaxOut.Name = "lblFICATaxOut";
            this.lblFICATaxOut.Size = new System.Drawing.Size(158, 23);
            this.lblFICATaxOut.TabIndex = 3;
            // 
            // lblStateTaxOut
            // 
            this.lblStateTaxOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStateTaxOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateTaxOut.Location = new System.Drawing.Point(218, 101);
            this.lblStateTaxOut.Name = "lblStateTaxOut";
            this.lblStateTaxOut.Size = new System.Drawing.Size(158, 23);
            this.lblStateTaxOut.TabIndex = 5;
            // 
            // lblFedTaxOut
            // 
            this.lblFedTaxOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFedTaxOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFedTaxOut.Location = new System.Drawing.Point(218, 138);
            this.lblFedTaxOut.Name = "lblFedTaxOut";
            this.lblFedTaxOut.Size = new System.Drawing.Size(158, 23);
            this.lblFedTaxOut.TabIndex = 7;
            // 
            // lblUnionDuesOut
            // 
            this.lblUnionDuesOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnionDuesOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnionDuesOut.Location = new System.Drawing.Point(218, 175);
            this.lblUnionDuesOut.Name = "lblUnionDuesOut";
            this.lblUnionDuesOut.Size = new System.Drawing.Size(158, 23);
            this.lblUnionDuesOut.TabIndex = 9;
            // 
            // lblNetPayOut
            // 
            this.lblNetPayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetPayOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPayOut.ForeColor = System.Drawing.Color.Black;
            this.lblNetPayOut.Location = new System.Drawing.Point(218, 212);
            this.lblNetPayOut.Name = "lblNetPayOut";
            this.lblNetPayOut.Size = new System.Drawing.Size(158, 23);
            this.lblNetPayOut.TabIndex = 11;
            // 
            // lblGrossPayOut
            // 
            this.lblGrossPayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossPayOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPayOut.Location = new System.Drawing.Point(218, 27);
            this.lblGrossPayOut.Name = "lblGrossPayOut";
            this.lblGrossPayOut.Size = new System.Drawing.Size(158, 23);
            this.lblGrossPayOut.TabIndex = 1;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(37, 27);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(92, 23);
            this.lblGrossPay.TabIndex = 0;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // lblFICATax
            // 
            this.lblFICATax.AutoSize = true;
            this.lblFICATax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFICATax.Location = new System.Drawing.Point(37, 64);
            this.lblFICATax.Name = "lblFICATax";
            this.lblFICATax.Size = new System.Drawing.Size(80, 23);
            this.lblFICATax.TabIndex = 2;
            this.lblFICATax.Text = "FICA Tax:";
            // 
            // lblStateTax
            // 
            this.lblStateTax.AutoSize = true;
            this.lblStateTax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateTax.Location = new System.Drawing.Point(37, 101);
            this.lblStateTax.Name = "lblStateTax";
            this.lblStateTax.Size = new System.Drawing.Size(83, 23);
            this.lblStateTax.TabIndex = 4;
            this.lblStateTax.Text = "State Tax:";
            // 
            // lblFedTax
            // 
            this.lblFedTax.AutoSize = true;
            this.lblFedTax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFedTax.Location = new System.Drawing.Point(37, 138);
            this.lblFedTax.Name = "lblFedTax";
            this.lblFedTax.Size = new System.Drawing.Size(101, 23);
            this.lblFedTax.TabIndex = 6;
            this.lblFedTax.Text = "Federal Tax:";
            // 
            // lblUnionDues
            // 
            this.lblUnionDues.AutoSize = true;
            this.lblUnionDues.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnionDues.Location = new System.Drawing.Point(37, 175);
            this.lblUnionDues.Name = "lblUnionDues";
            this.lblUnionDues.Size = new System.Drawing.Size(104, 23);
            this.lblUnionDues.TabIndex = 8;
            this.lblUnionDues.Text = "Union Dues:";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.Location = new System.Drawing.Point(37, 212);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(74, 23);
            this.lblNetPay.TabIndex = 10;
            this.lblNetPay.Text = "Net Pay:";
            // 
            // gbxBottom
            // 
            this.gbxBottom.Controls.Add(this.lblEmployeeCountOut);
            this.gbxBottom.Controls.Add(this.lblAvgNetPayOut);
            this.gbxBottom.Controls.Add(this.lblTotalNetOut);
            this.gbxBottom.Controls.Add(this.lblTotalNet);
            this.gbxBottom.Controls.Add(this.lblEmployeeCount);
            this.gbxBottom.Controls.Add(this.lblAvgNetPay);
            this.gbxBottom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBottom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbxBottom.Location = new System.Drawing.Point(38, 468);
            this.gbxBottom.Name = "gbxBottom";
            this.gbxBottom.Size = new System.Drawing.Size(420, 156);
            this.gbxBottom.TabIndex = 2;
            this.gbxBottom.TabStop = false;
            this.gbxBottom.Text = "Totals";
            // 
            // lblEmployeeCountOut
            // 
            this.lblEmployeeCountOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeCountOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCountOut.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeCountOut.Location = new System.Drawing.Point(218, 73);
            this.lblEmployeeCountOut.Name = "lblEmployeeCountOut";
            this.lblEmployeeCountOut.Size = new System.Drawing.Size(158, 23);
            this.lblEmployeeCountOut.TabIndex = 3;
            // 
            // lblAvgNetPayOut
            // 
            this.lblAvgNetPayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgNetPayOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgNetPayOut.ForeColor = System.Drawing.Color.Black;
            this.lblAvgNetPayOut.Location = new System.Drawing.Point(218, 111);
            this.lblAvgNetPayOut.Name = "lblAvgNetPayOut";
            this.lblAvgNetPayOut.Size = new System.Drawing.Size(158, 23);
            this.lblAvgNetPayOut.TabIndex = 5;
            // 
            // lblTotalNetOut
            // 
            this.lblTotalNetOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalNetOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNetOut.ForeColor = System.Drawing.Color.Black;
            this.lblTotalNetOut.Location = new System.Drawing.Point(218, 36);
            this.lblTotalNetOut.Name = "lblTotalNetOut";
            this.lblTotalNetOut.Size = new System.Drawing.Size(158, 23);
            this.lblTotalNetOut.TabIndex = 1;
            // 
            // lblTotalNet
            // 
            this.lblTotalNet.AutoSize = true;
            this.lblTotalNet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNet.ForeColor = System.Drawing.Color.Black;
            this.lblTotalNet.Location = new System.Drawing.Point(37, 36);
            this.lblTotalNet.Name = "lblTotalNet";
            this.lblTotalNet.Size = new System.Drawing.Size(114, 23);
            this.lblTotalNet.TabIndex = 0;
            this.lblTotalNet.Text = "Total Net Pay:";
            // 
            // lblEmployeeCount
            // 
            this.lblEmployeeCount.AutoSize = true;
            this.lblEmployeeCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCount.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeCount.Location = new System.Drawing.Point(37, 74);
            this.lblEmployeeCount.Name = "lblEmployeeCount";
            this.lblEmployeeCount.Size = new System.Drawing.Size(140, 23);
            this.lblEmployeeCount.TabIndex = 2;
            this.lblEmployeeCount.Text = "Employee Count:";
            // 
            // lblAvgNetPay
            // 
            this.lblAvgNetPay.AutoSize = true;
            this.lblAvgNetPay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgNetPay.ForeColor = System.Drawing.Color.Black;
            this.lblAvgNetPay.Location = new System.Drawing.Point(37, 112);
            this.lblAvgNetPay.Name = "lblAvgNetPay";
            this.lblAvgNetPay.Size = new System.Drawing.Size(141, 23);
            this.lblAvgNetPay.TabIndex = 4;
            this.lblAvgNetPay.Text = "Average Net Pay:";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(54, 631);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 30);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(195, 631);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(336, 631);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picSecurity
            // 
            this.picSecurity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picSecurity.Image = ((System.Drawing.Image)(resources.GetObject("picSecurity.Image")));
            this.picSecurity.Location = new System.Drawing.Point(38, 2);
            this.picSecurity.Name = "picSecurity";
            this.picSecurity.Size = new System.Drawing.Size(30, 30);
            this.picSecurity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSecurity.TabIndex = 6;
            this.picSecurity.TabStop = false;
            // 
            // picFolder
            // 
            this.picFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picFolder.Image = ((System.Drawing.Image)(resources.GetObject("picFolder.Image")));
            this.picFolder.Location = new System.Drawing.Point(428, 2);
            this.picFolder.Name = "picFolder";
            this.picFolder.Size = new System.Drawing.Size(30, 30);
            this.picFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFolder.TabIndex = 7;
            this.picFolder.TabStop = false;
            // 
            // CS5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 672);
            this.Controls.Add(this.picFolder);
            this.Controls.Add(this.picSecurity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gbxBottom);
            this.Controls.Add(this.gbxMiddle);
            this.Controls.Add(this.gbxTop);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "CS5Form";
            this.Text = "CS5 by Dave Minkowski";
            this.gbxTop.ResumeLayout(false);
            this.gbxTop.PerformLayout();
            this.bgoxUnionDues.ResumeLayout(false);
            this.bgoxUnionDues.PerformLayout();
            this.gbxMiddle.ResumeLayout(false);
            this.gbxMiddle.PerformLayout();
            this.gbxBottom.ResumeLayout(false);
            this.gbxBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbxTop;
        private System.Windows.Forms.GroupBox gbxMiddle;
        private System.Windows.Forms.GroupBox gbxBottom;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblFICATaxOut;
        private System.Windows.Forms.Label lblStateTaxOut;
        private System.Windows.Forms.Label lblFedTaxOut;
        private System.Windows.Forms.Label lblUnionDuesOut;
        private System.Windows.Forms.Label lblNetPayOut;
        private System.Windows.Forms.Label lblGrossPayOut;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblFICATax;
        private System.Windows.Forms.Label lblStateTax;
        private System.Windows.Forms.Label lblFedTax;
        private System.Windows.Forms.Label lblUnionDues;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label lblEmployeeCountOut;
        private System.Windows.Forms.Label lblAvgNetPayOut;
        private System.Windows.Forms.Label lblTotalNetOut;
        private System.Windows.Forms.Label lblTotalNet;
        private System.Windows.Forms.Label lblEmployeeCount;
        private System.Windows.Forms.Label lblAvgNetPay;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox bgoxUnionDues;
        private System.Windows.Forms.RadioButton radSpecial;
        private System.Windows.Forms.RadioButton radRegular;
        private System.Windows.Forms.RadioButton radNone;
        private System.Windows.Forms.PictureBox picSecurity;
        private System.Windows.Forms.PictureBox picFolder;
    }
}

