namespace CS10b
{
    partial class frmCS10b
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.btnForLoop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnWhileLoop = new System.Windows.Forms.Button();
            this.btnDoWhileLoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(106, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Multiplication Table";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTable
            // 
            this.txtTable.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTable.Location = new System.Drawing.Point(45, 90);
            this.txtTable.Multiline = true;
            this.txtTable.Name = "txtTable";
            this.txtTable.ReadOnly = true;
            this.txtTable.Size = new System.Drawing.Size(300, 186);
            this.txtTable.TabIndex = 1;
            // 
            // btnForLoop
            // 
            this.btnForLoop.Location = new System.Drawing.Point(203, 298);
            this.btnForLoop.Name = "btnForLoop";
            this.btnForLoop.Size = new System.Drawing.Size(79, 31);
            this.btnForLoop.TabIndex = 2;
            this.btnForLoop.Text = "For Loop";
            this.btnForLoop.UseVisualStyleBackColor = true;
            this.btnForLoop.Click += new System.EventHandler(this.btnForLoop_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(285, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = " 1  2  3  4  5  6  7  8  9";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(25, 237);
            this.textBox1.TabIndex = 5;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWhileLoop
            // 
            this.btnWhileLoop.Location = new System.Drawing.Point(30, 298);
            this.btnWhileLoop.Name = "btnWhileLoop";
            this.btnWhileLoop.Size = new System.Drawing.Size(83, 31);
            this.btnWhileLoop.TabIndex = 6;
            this.btnWhileLoop.Text = "While Loop";
            this.btnWhileLoop.UseVisualStyleBackColor = true;
            this.btnWhileLoop.Click += new System.EventHandler(this.btnWhileLoop_Click);
            // 
            // btnDoWhileLoop
            // 
            this.btnDoWhileLoop.Location = new System.Drawing.Point(119, 298);
            this.btnDoWhileLoop.Name = "btnDoWhileLoop";
            this.btnDoWhileLoop.Size = new System.Drawing.Size(78, 31);
            this.btnDoWhileLoop.TabIndex = 7;
            this.btnDoWhileLoop.Text = "Do Loop";
            this.btnDoWhileLoop.UseVisualStyleBackColor = true;
            this.btnDoWhileLoop.Click += new System.EventHandler(this.btnDoWhileLoop_Click);
            // 
            // frmCS10b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 353);
            this.Controls.Add(this.btnDoWhileLoop);
            this.Controls.Add(this.btnWhileLoop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnForLoop);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCS10b";
            this.Text = "CS10b by Your Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button btnForLoop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnWhileLoop;
        private System.Windows.Forms.Button btnDoWhileLoop;


    }
}

