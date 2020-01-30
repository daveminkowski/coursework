<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstVehicleNumber = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lstVehiclePrice = New System.Windows.Forms.ListBox()
        Me.lstVehicleMileage = New System.Windows.Forms.ListBox()
        Me.lstVehicleModel = New System.Windows.Forms.ListBox()
        Me.lstVehicleYear = New System.Windows.Forms.ListBox()
        Me.lstVehicleColor = New System.Windows.Forms.ListBox()
        Me.lblInventoryHeader = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblVehiclePrice = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblVehicleModel = New System.Windows.Forms.Label()
        Me.lblVehicleNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstVehicleNumber
        '
        Me.lstVehicleNumber.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVehicleNumber.FormattingEnabled = True
        Me.lstVehicleNumber.Location = New System.Drawing.Point(34, 103)
        Me.lstVehicleNumber.Name = "lstVehicleNumber"
        Me.lstVehicleNumber.Size = New System.Drawing.Size(123, 251)
        Me.lstVehicleNumber.TabIndex = 1
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(213, 387)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(251, 33)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "Return to Details Form"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lstVehiclePrice
        '
        Me.lstVehiclePrice.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVehiclePrice.FormatString = "C2"
        Me.lstVehiclePrice.FormattingEnabled = True
        Me.lstVehiclePrice.Location = New System.Drawing.Point(574, 103)
        Me.lstVehiclePrice.Name = "lstVehiclePrice"
        Me.lstVehiclePrice.Size = New System.Drawing.Size(80, 251)
        Me.lstVehiclePrice.TabIndex = 6
        '
        'lstVehicleMileage
        '
        Me.lstVehicleMileage.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVehicleMileage.FormattingEnabled = True
        Me.lstVehicleMileage.Location = New System.Drawing.Point(491, 103)
        Me.lstVehicleMileage.Name = "lstVehicleMileage"
        Me.lstVehicleMileage.Size = New System.Drawing.Size(71, 251)
        Me.lstVehicleMileage.TabIndex = 5
        '
        'lstVehicleModel
        '
        Me.lstVehicleModel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVehicleModel.FormattingEnabled = True
        Me.lstVehicleModel.Location = New System.Drawing.Point(387, 103)
        Me.lstVehicleModel.Name = "lstVehicleModel"
        Me.lstVehicleModel.Size = New System.Drawing.Size(92, 251)
        Me.lstVehicleModel.TabIndex = 4
        '
        'lstVehicleYear
        '
        Me.lstVehicleYear.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVehicleYear.FormattingEnabled = True
        Me.lstVehicleYear.Location = New System.Drawing.Point(325, 103)
        Me.lstVehicleYear.Name = "lstVehicleYear"
        Me.lstVehicleYear.Size = New System.Drawing.Size(50, 251)
        Me.lstVehicleYear.TabIndex = 3
        '
        'lstVehicleColor
        '
        Me.lstVehicleColor.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVehicleColor.FormattingEnabled = True
        Me.lstVehicleColor.Location = New System.Drawing.Point(169, 103)
        Me.lstVehicleColor.Name = "lstVehicleColor"
        Me.lstVehicleColor.Size = New System.Drawing.Size(144, 251)
        Me.lstVehicleColor.TabIndex = 2
        '
        'lblInventoryHeader
        '
        Me.lblInventoryHeader.AutoSize = True
        Me.lblInventoryHeader.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventoryHeader.Location = New System.Drawing.Point(151, 27)
        Me.lblInventoryHeader.Name = "lblInventoryHeader"
        Me.lblInventoryHeader.Size = New System.Drawing.Size(374, 26)
        Me.lblInventoryHeader.TabIndex = 7
        Me.lblInventoryHeader.Text = "Mini Cooper Dealership Current Inventory"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(217, 79)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(49, 19)
        Me.lblColor.TabIndex = 13
        Me.lblColor.Text = "Color:"
        '
        'lblVehiclePrice
        '
        Me.lblVehiclePrice.AutoSize = True
        Me.lblVehiclePrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehiclePrice.Location = New System.Drawing.Point(591, 79)
        Me.lblVehiclePrice.Name = "lblVehiclePrice"
        Me.lblVehiclePrice.Size = New System.Drawing.Size(47, 19)
        Me.lblVehiclePrice.TabIndex = 12
        Me.lblVehiclePrice.Text = "Price:"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.Location = New System.Drawing.Point(493, 79)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(67, 19)
        Me.lblMileage.TabIndex = 11
        Me.lblMileage.Text = "Mileage:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(329, 79)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(42, 19)
        Me.lblYear.TabIndex = 10
        Me.lblYear.Text = "Year:"
        '
        'lblVehicleModel
        '
        Me.lblVehicleModel.AutoSize = True
        Me.lblVehicleModel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleModel.Location = New System.Drawing.Point(405, 79)
        Me.lblVehicleModel.Name = "lblVehicleModel"
        Me.lblVehicleModel.Size = New System.Drawing.Size(57, 19)
        Me.lblVehicleModel.TabIndex = 9
        Me.lblVehicleModel.Text = "Model:"
        '
        'lblVehicleNumber
        '
        Me.lblVehicleNumber.AutoSize = True
        Me.lblVehicleNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleNumber.Location = New System.Drawing.Point(35, 79)
        Me.lblVehicleNumber.Name = "lblVehicleNumber"
        Me.lblVehicleNumber.Size = New System.Drawing.Size(121, 19)
        Me.lblVehicleNumber.TabIndex = 8
        Me.lblVehicleNumber.Text = "Vehicle Number:"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(677, 437)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblVehiclePrice)
        Me.Controls.Add(Me.lblMileage)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblVehicleModel)
        Me.Controls.Add(Me.lblVehicleNumber)
        Me.Controls.Add(Me.lblInventoryHeader)
        Me.Controls.Add(Me.lstVehicleColor)
        Me.Controls.Add(Me.lstVehicleYear)
        Me.Controls.Add(Me.lstVehicleModel)
        Me.Controls.Add(Me.lstVehicleMileage)
        Me.Controls.Add(Me.lstVehiclePrice)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstVehicleNumber)
        Me.Name = "frmInventory"
        Me.Text = "Mini Cooper Inventory by Dave Minkowski"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstVehicleNumber As ListBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents lstVehiclePrice As ListBox
    Friend WithEvents lstVehicleMileage As ListBox
    Friend WithEvents lstVehicleModel As ListBox
    Friend WithEvents lstVehicleYear As ListBox
    Friend WithEvents lstVehicleColor As ListBox
    Friend WithEvents lblInventoryHeader As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblVehiclePrice As Label
    Friend WithEvents lblMileage As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblVehicleModel As Label
    Friend WithEvents lblVehicleNumber As Label
End Class
