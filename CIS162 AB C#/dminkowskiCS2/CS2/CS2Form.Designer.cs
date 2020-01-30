namespace CS2
{
    partial class frmCS2
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnCustomerRelations = new System.Windows.Forms.Button();
            this.btnOrderProcessing = new System.Windows.Forms.Button();
            this.btnMarketing = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(127, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(180, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Phone Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(116, 105);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(63, 19);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(126, 142);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 19);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // btnCustomerRelations
            // 
            this.btnCustomerRelations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRelations.Location = new System.Drawing.Point(30, 204);
            this.btnCustomerRelations.Name = "btnCustomerRelations";
            this.btnCustomerRelations.Size = new System.Drawing.Size(122, 34);
            this.btnCustomerRelations.TabIndex = 7;
            this.btnCustomerRelations.Text = "&Customer Relations";
            this.toolTip1.SetToolTip(this.btnCustomerRelations, "Displays the contact information for the customer relations department.");
            this.btnCustomerRelations.UseVisualStyleBackColor = true;
            this.btnCustomerRelations.Click += new System.EventHandler(this.btnCustomerRelations_Click);
            // 
            // btnOrderProcessing
            // 
            this.btnOrderProcessing.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderProcessing.Location = new System.Drawing.Point(30, 254);
            this.btnOrderProcessing.Name = "btnOrderProcessing";
            this.btnOrderProcessing.Size = new System.Drawing.Size(122, 34);
            this.btnOrderProcessing.TabIndex = 9;
            this.btnOrderProcessing.Text = "&Order Processing";
            this.toolTip1.SetToolTip(this.btnOrderProcessing, "Displays the contact information for the order processing department.");
            this.btnOrderProcessing.UseVisualStyleBackColor = true;
            this.btnOrderProcessing.Click += new System.EventHandler(this.btnOrderProcessing_Click);
            // 
            // btnMarketing
            // 
            this.btnMarketing.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarketing.Location = new System.Drawing.Point(180, 204);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Size = new System.Drawing.Size(122, 34);
            this.btnMarketing.TabIndex = 8;
            this.btnMarketing.Text = "&Marketing";
            this.toolTip1.SetToolTip(this.btnMarketing, "Displays the contact information for the marketing department.");
            this.btnMarketing.UseVisualStyleBackColor = true;
            this.btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnShipping
            // 
            this.btnShipping.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipping.Location = new System.Drawing.Point(180, 254);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(122, 34);
            this.btnShipping.TabIndex = 10;
            this.btnShipping.Text = "&Shipping";
            this.toolTip1.SetToolTip(this.btnShipping, "Displays the contact information for the shipping department.");
            this.btnShipping.UseVisualStyleBackColor = true;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(330, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 34);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Close the phone directory.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepartmentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(195, 68);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(150, 21);
            this.lblDepartmentName.TabIndex = 2;
            // 
            // lblContactName
            // 
            this.lblContactName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContactName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.Location = new System.Drawing.Point(195, 105);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(150, 21);
            this.lblContactName.TabIndex = 4;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(195, 142);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(150, 21);
            this.lblPhoneNumber.TabIndex = 6;
            // 
            // frmCS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.btnMarketing);
            this.Controls.Add(this.btnOrderProcessing);
            this.Controls.Add(this.btnCustomerRelations);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmCS2";
            this.Text = "CS2 by Dave Minkowski";
            this.Load += new System.EventHandler(this.frmCS2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnCustomerRelations;
        private System.Windows.Forms.Button btnOrderProcessing;
        private System.Windows.Forms.Button btnMarketing;
        private System.Windows.Forms.Button btnShipping;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblPhoneNumber;
    }
}

