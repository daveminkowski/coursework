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
            this.components = new System.ComponentModel.Container();
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
            this.lblEmployeeCountOut = new System.Windows.Forms.Label();
            this.lblFICATaxOut = new System.Windows.Forms.Label();
            this.lblAvgNetPayOut = new System.Windows.Forms.Label();
            this.lblStateTaxOut = new System.Windows.Forms.Label();
            this.lblTotalNetOut = new System.Windows.Forms.Label();
            this.lblFedTaxOut = new System.Windows.Forms.Label();
            this.lblTotalNet = new System.Windows.Forms.Label();
            this.lblEmployeeCount = new System.Windows.Forms.Label();
            this.lblUnionDuesOut = new System.Windows.Forms.Label();
            this.lblAvgNetPay = new System.Windows.Forms.Label();
            this.lblNetPayOut = new System.Windows.Forms.Label();
            this.lblGrossPayOut = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblFICATax = new System.Windows.Forms.Label();
            this.lblStateTax = new System.Windows.Forms.Label();
            this.lblFedTax = new System.Windows.Forms.Label();
            this.lblUnionDues = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picSecurity = new System.Windows.Forms.PictureBox();
            this.picFolder = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxTop.SuspendLayout();
            this.bgoxUnionDues.SuspendLayout();
            this.gbxMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFolder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(81, 29);
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
            this.gbxTop.Location = new System.Drawing.Point(12, 58);
            this.gbxTop.Name = "gbxTop";
            this.gbxTop.Size = new System.Drawing.Size(411, 124);
            this.gbxTop.TabIndex = 1;
            this.gbxTop.TabStop = false;
            // 
            // bgoxUnionDues
            // 
            this.bgoxUnionDues.Controls.Add(this.radSpecial);
            this.bgoxUnionDues.Controls.Add(this.radRegular);
            this.bgoxUnionDues.Controls.Add(this.radNone);
            this.bgoxUnionDues.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgoxUnionDues.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bgoxUnionDues.Location = new System.Drawing.Point(38, 67);
            this.bgoxUnionDues.Name = "bgoxUnionDues";
            this.bgoxUnionDues.Size = new System.Drawing.Size(335, 49);
            this.bgoxUnionDues.TabIndex = 4;
            this.bgoxUnionDues.TabStop = false;
            this.bgoxUnionDues.Text = "Union Dues";
            // 
            // radSpecial
            // 
            this.radSpecial.AutoSize = true;
            this.radSpecial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSpecial.ForeColor = System.Drawing.Color.Black;
            this.radSpecial.Location = new System.Drawing.Point(243, 21);
            this.radSpecial.Name = "radSpecial";
            this.radSpecial.Size = new System.Drawing.Size(65, 19);
            this.radSpecial.TabIndex = 2;
            this.radSpecial.TabStop = true;
            this.radSpecial.Text = "Special";
            this.radSpecial.UseVisualStyleBackColor = true;
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRegular.ForeColor = System.Drawing.Color.Black;
            this.radRegular.Location = new System.Drawing.Point(127, 21);
            this.radRegular.Name = "radRegular";
            this.radRegular.Size = new System.Drawing.Size(67, 19);
            this.radRegular.TabIndex = 1;
            this.radRegular.TabStop = true;
            this.radRegular.Text = "Regular";
            this.radRegular.UseVisualStyleBackColor = true;
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Checked = true;
            this.radNone.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNone.ForeColor = System.Drawing.Color.Black;
            this.radNone.Location = new System.Drawing.Point(27, 21);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(53, 19);
            this.radNone.TabIndex = 0;
            this.radNone.TabStop = true;
            this.radNone.Text = "None";
            this.radNone.UseVisualStyleBackColor = true;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayRate.Location = new System.Drawing.Point(191, 43);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(140, 23);
            this.txtPayRate.TabIndex = 3;
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(191, 17);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(140, 23);
            this.txtHours.TabIndex = 1;
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(111, 46);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(57, 15);
            this.lblPayRate.TabIndex = 2;
            this.lblPayRate.Text = "Pay Rate:";
            this.lblPayRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(80, 20);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(88, 15);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Hours Worked:";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxMiddle
            // 
            this.gbxMiddle.Controls.Add(this.lblEmployeeCountOut);
            this.gbxMiddle.Controls.Add(this.lblFICATaxOut);
            this.gbxMiddle.Controls.Add(this.lblAvgNetPayOut);
            this.gbxMiddle.Controls.Add(this.lblStateTaxOut);
            this.gbxMiddle.Controls.Add(this.lblTotalNetOut);
            this.gbxMiddle.Controls.Add(this.lblFedTaxOut);
            this.gbxMiddle.Controls.Add(this.lblTotalNet);
            this.gbxMiddle.Controls.Add(this.lblEmployeeCount);
            this.gbxMiddle.Controls.Add(this.lblUnionDuesOut);
            this.gbxMiddle.Controls.Add(this.lblAvgNetPay);
            this.gbxMiddle.Controls.Add(this.lblNetPayOut);
            this.gbxMiddle.Controls.Add(this.lblGrossPayOut);
            this.gbxMiddle.Controls.Add(this.lblGrossPay);
            this.gbxMiddle.Controls.Add(this.lblFICATax);
            this.gbxMiddle.Controls.Add(this.lblStateTax);
            this.gbxMiddle.Controls.Add(this.lblFedTax);
            this.gbxMiddle.Controls.Add(this.lblUnionDues);
            this.gbxMiddle.Controls.Add(this.lblNetPay);
            this.gbxMiddle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMiddle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbxMiddle.Location = new System.Drawing.Point(11, 188);
            this.gbxMiddle.Name = "gbxMiddle";
            this.gbxMiddle.Size = new System.Drawing.Size(412, 197);
            this.gbxMiddle.TabIndex = 2;
            this.gbxMiddle.TabStop = false;
            this.gbxMiddle.Text = "Totals";
            // 
            // lblEmployeeCountOut
            // 
            this.lblEmployeeCountOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeCountOut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCountOut.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeCountOut.Location = new System.Drawing.Point(317, 20);
            this.lblEmployeeCountOut.Name = "lblEmployeeCountOut";
            this.lblEmployeeCountOut.Size = new System.Drawing.Size(80, 23);
            this.lblEmployeeCountOut.TabIndex = 15;
            this.lblEmployeeCountOut.Text = " ";
            this.lblEmployeeCountOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFICATaxOut
            // 
            this.lblFICATaxOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFICATaxOut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFICATaxOut.ForeColor = System.Drawing.Color.Red;
            this.lblFICATaxOut.Location = new System.Drawing.Point(101, 48);
            this.lblFICATaxOut.Name = "lblFICATaxOut";
            this.lblFICATaxOut.Size = new System.Drawing.Size(80, 23);
            this.lblFICATaxOut.TabIndex = 3;
            this.lblFICATaxOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvgNetPayOut
            // 
            this.lblAvgNetPayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgNetPayOut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgNetPayOut.ForeColor = System.Drawing.Color.Black;
            this.lblAvgNetPayOut.Location = new System.Drawing.Point(317, 48);
            this.lblAvgNetPayOut.Name = "lblAvgNetPayOut";
            this.lblAvgNetPayOut.Size = new System.Drawing.Size(80, 23);
            this.lblAvgNetPayOut.TabIndex = 17;
            this.lblAvgNetPayOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStateTaxOut
            // 
            this.lblStateTaxOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStateTaxOut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateTaxOut.ForeColor = System.Drawing.Color.Red;
            this.lblStateTaxOut.Location = new System.Drawing.Point(101, 76);
            this.lblStateTaxOut.Name = "lblStateTaxOut";
            this.lblStateTaxOut.Size = new System.Drawing.Size(80, 23);
            this.lblStateTaxOut.TabIndex = 5;
            this.lblStateTaxOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalNetOut
            // 
            this.lblTotalNetOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalNetOut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNetOut.ForeColor = System.Drawing.Color.Black;
            this.lblTotalNetOut.Location = new System.Drawing.Point(317, 76);
            this.lblTotalNetOut.Name = "lblTotalNetOut";
            this.lblTotalNetOut.Size = new System.Drawing.Size(80, 23);
            this.lblTotalNetOut.TabIndex = 13;
            this.lblTotalNetOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFedTaxOut
            // 
            this.lblFedTaxOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFedTaxOut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFedTaxOut.ForeColor = System.Drawing.Color.Red;
            this.lblFedTaxOut.Location = new System.Drawing.Point(101, 104);
            this.lblFedTaxOut.Name = "lblFedTaxOut";
            this.lblFedTaxOut.Size = new System.Drawing.Size(80, 23);
            this.lblFedTaxOut.TabIndex = 7;
            this.lblFedTaxOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalNet
            // 
            this.lblTotalNet.AutoSize = true;
            this.lblTotalNet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNet.ForeColor = System.Drawing.Color.Black;
            this.lblTotalNet.Location = new System.Drawing.Point(205, 79);
            this.lblTotalNet.Name = "lblTotalNet";
            this.lblTotalNet.Size = new System.Drawing.Size(99, 15);
            this.lblTotalNet.TabIndex = 16;
            this.lblTotalNet.Text = "Total Net Payout:";
            this.lblTotalNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmployeeCount
            // 
            this.lblEmployeeCount.AutoSize = true;
            this.lblEmployeeCount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCount.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeCount.Location = new System.Drawing.Point(207, 23);
            this.lblEmployeeCount.Name = "lblEmployeeCount";
            this.lblEmployeeCount.Size = new System.Drawing.Size(97, 15);
            this.lblEmployeeCount.TabIndex = 12;
            this.lblEmployeeCount.Text = "Employee Count:";
            this.lblEmployeeCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnionDuesOut
            // 
            this.lblUnionDuesOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnionDuesOut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnionDuesOut.ForeColor = System.Drawing.Color.Red;
            this.lblUnionDuesOut.Location = new System.Drawing.Point(101, 132);
            this.lblUnionDuesOut.Name = "lblUnionDuesOut";
            this.lblUnionDuesOut.Size = new System.Drawing.Size(80, 23);
            this.lblUnionDuesOut.TabIndex = 9;
            this.lblUnionDuesOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvgNetPay
            // 
            this.lblAvgNetPay.AutoSize = true;
            this.lblAvgNetPay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgNetPay.ForeColor = System.Drawing.Color.Black;
            this.lblAvgNetPay.Location = new System.Drawing.Point(207, 51);
            this.lblAvgNetPay.Name = "lblAvgNetPay";
            this.lblAvgNetPay.Size = new System.Drawing.Size(97, 15);
            this.lblAvgNetPay.TabIndex = 14;
            this.lblAvgNetPay.Text = "Average Net Pay:";
            this.lblAvgNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetPayOut
            // 
            this.lblNetPayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetPayOut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPayOut.ForeColor = System.Drawing.Color.Green;
            this.lblNetPayOut.Location = new System.Drawing.Point(101, 160);
            this.lblNetPayOut.Name = "lblNetPayOut";
            this.lblNetPayOut.Size = new System.Drawing.Size(80, 23);
            this.lblNetPayOut.TabIndex = 11;
            this.lblNetPayOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrossPayOut
            // 
            this.lblGrossPayOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossPayOut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPayOut.ForeColor = System.Drawing.Color.Black;
            this.lblGrossPayOut.Location = new System.Drawing.Point(101, 20);
            this.lblGrossPayOut.Name = "lblGrossPayOut";
            this.lblGrossPayOut.Size = new System.Drawing.Size(80, 23);
            this.lblGrossPayOut.TabIndex = 1;
            this.lblGrossPayOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.ForeColor = System.Drawing.Color.Black;
            this.lblGrossPay.Location = new System.Drawing.Point(23, 23);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(65, 15);
            this.lblGrossPay.TabIndex = 0;
            this.lblGrossPay.Text = "Gross Pay:";
            this.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFICATax
            // 
            this.lblFICATax.AutoSize = true;
            this.lblFICATax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFICATax.ForeColor = System.Drawing.Color.Black;
            this.lblFICATax.Location = new System.Drawing.Point(33, 51);
            this.lblFICATax.Name = "lblFICATax";
            this.lblFICATax.Size = new System.Drawing.Size(55, 15);
            this.lblFICATax.TabIndex = 2;
            this.lblFICATax.Text = "FICA Tax:";
            this.lblFICATax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateTax
            // 
            this.lblStateTax.AutoSize = true;
            this.lblStateTax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateTax.ForeColor = System.Drawing.Color.Black;
            this.lblStateTax.Location = new System.Drawing.Point(30, 79);
            this.lblStateTax.Name = "lblStateTax";
            this.lblStateTax.Size = new System.Drawing.Size(58, 15);
            this.lblStateTax.TabIndex = 4;
            this.lblStateTax.Text = "State Tax:";
            this.lblStateTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFedTax
            // 
            this.lblFedTax.AutoSize = true;
            this.lblFedTax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFedTax.ForeColor = System.Drawing.Color.Black;
            this.lblFedTax.Location = new System.Drawing.Point(16, 107);
            this.lblFedTax.Name = "lblFedTax";
            this.lblFedTax.Size = new System.Drawing.Size(72, 15);
            this.lblFedTax.TabIndex = 6;
            this.lblFedTax.Text = "Federal Tax:";
            this.lblFedTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnionDues
            // 
            this.lblUnionDues.AutoSize = true;
            this.lblUnionDues.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnionDues.ForeColor = System.Drawing.Color.Black;
            this.lblUnionDues.Location = new System.Drawing.Point(15, 135);
            this.lblUnionDues.Name = "lblUnionDues";
            this.lblUnionDues.Size = new System.Drawing.Size(73, 15);
            this.lblUnionDues.TabIndex = 8;
            this.lblUnionDues.Text = "Union Dues:";
            this.lblUnionDues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.ForeColor = System.Drawing.Color.Black;
            this.lblNetPay.Location = new System.Drawing.Point(37, 163);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(51, 15);
            this.lblNetPay.TabIndex = 10;
            this.lblNetPay.Text = "Net Pay:";
            this.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(44, 401);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 30);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(167, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(290, 401);
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
            this.picSecurity.Location = new System.Drawing.Point(12, 26);
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
            this.picFolder.Location = new System.Drawing.Point(393, 26);
            this.picFolder.Name = "picFolder";
            this.picFolder.Size = new System.Drawing.Size(30, 30);
            this.picFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFolder.TabIndex = 7;
            this.picFolder.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuItem
            // 
            this.mnuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalc,
            this.mnuClear,
            this.toolStripMenuItem2,
            this.mnuFont,
            this.mnuColor});
            this.mnuItem.Name = "mnuItem";
            this.mnuItem.Size = new System.Drawing.Size(39, 20);
            this.mnuItem.Text = "&Edit";
            // 
            // mnuCalc
            // 
            this.mnuCalc.Name = "mnuCalc";
            this.mnuCalc.Size = new System.Drawing.Size(169, 22);
            this.mnuCalc.Text = "&Calculate";
            this.mnuCalc.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // mnuClear
            // 
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.Size = new System.Drawing.Size(169, 22);
            this.mnuClear.Text = "C&lear Form";
            this.mnuClear.Click += new System.EventHandler(this.clearFormToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem2.Text = "-------------------";
            // 
            // mnuFont
            // 
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(169, 22);
            this.mnuFont.Text = "F&ont";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(169, 22);
            this.mnuColor.Text = "Colo&r";
            this.mnuColor.Click += new System.EventHandler(this.mnuColor_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMnuFont,
            this.contextMnuColor});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // contextMnuFont
            // 
            this.contextMnuFont.Name = "contextMnuFont";
            this.contextMnuFont.Size = new System.Drawing.Size(103, 22);
            this.contextMnuFont.Text = "F&ont";
            this.contextMnuFont.Click += new System.EventHandler(this.contextMnuFont_Click);
            // 
            // contextMnuColor
            // 
            this.contextMnuColor.Name = "contextMnuColor";
            this.contextMnuColor.Size = new System.Drawing.Size(103, 22);
            this.contextMnuColor.Text = "Colo&r";
            this.contextMnuColor.Click += new System.EventHandler(this.contextMnuColor_Click);
            // 
            // CS5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 443);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.picFolder);
            this.Controls.Add(this.picSecurity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbxMiddle);
            this.Controls.Add(this.gbxTop);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CS5Form";
            this.Text = "CS5 by Dave Minkowski";
            this.gbxTop.ResumeLayout(false);
            this.gbxTop.PerformLayout();
            this.bgoxUnionDues.ResumeLayout(false);
            this.bgoxUnionDues.PerformLayout();
            this.gbxMiddle.ResumeLayout(false);
            this.gbxMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFolder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbxTop;
        private System.Windows.Forms.GroupBox gbxMiddle;
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
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCalc;
        private System.Windows.Forms.ToolStripMenuItem mnuClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMnuFont;
        private System.Windows.Forms.ToolStripMenuItem contextMnuColor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
    }
}

