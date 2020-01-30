<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVehicleNumber = New System.Windows.Forms.Label()
        Me.lblVehicleModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblVehiclePrice = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.chkConvertible = New System.Windows.Forms.CheckBox()
        Me.btnStickerPrice = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblStickerPriceValue = New System.Windows.Forms.Label()
        Me.picMiniConvert = New System.Windows.Forms.PictureBox()
        Me.txtVehicleMileage = New System.Windows.Forms.TextBox()
        Me.cboVehicleColor = New System.Windows.Forms.ComboBox()
        Me.cboVehicleModel = New System.Windows.Forms.ComboBox()
        Me.txtVehicleNumber = New System.Windows.Forms.TextBox()
        Me.txtVehicleYear = New System.Windows.Forms.TextBox()
        Me.txtVehiclePrice = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.picMiniHardtop = New System.Windows.Forms.PictureBox()
        Me.lblStickerPrice = New System.Windows.Forms.Label()
        CType(Me.picMiniConvert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picMiniHardtop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(173, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(159, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Mini Cooper Cars"
        '
        'lblVehicleNumber
        '
        Me.lblVehicleNumber.AutoSize = True
        Me.lblVehicleNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleNumber.Location = New System.Drawing.Point(10, 93)
        Me.lblVehicleNumber.Name = "lblVehicleNumber"
        Me.lblVehicleNumber.Size = New System.Drawing.Size(121, 19)
        Me.lblVehicleNumber.TabIndex = 1
        Me.lblVehicleNumber.Text = "Vehicle Number:"
        '
        'lblVehicleModel
        '
        Me.lblVehicleModel.AutoSize = True
        Me.lblVehicleModel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleModel.Location = New System.Drawing.Point(22, 128)
        Me.lblVehicleModel.Name = "lblVehicleModel"
        Me.lblVehicleModel.Size = New System.Drawing.Size(109, 19)
        Me.lblVehicleModel.TabIndex = 2
        Me.lblVehicleModel.Text = "Vehicle Model:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(89, 167)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(42, 19)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year:"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.Location = New System.Drawing.Point(64, 202)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(67, 19)
        Me.lblMileage.TabIndex = 4
        Me.lblMileage.Text = "Mileage:"
        '
        'lblVehiclePrice
        '
        Me.lblVehiclePrice.AutoSize = True
        Me.lblVehiclePrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehiclePrice.Location = New System.Drawing.Point(84, 241)
        Me.lblVehiclePrice.Name = "lblVehiclePrice"
        Me.lblVehiclePrice.Size = New System.Drawing.Size(47, 19)
        Me.lblVehiclePrice.TabIndex = 5
        Me.lblVehiclePrice.Text = "Price:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(82, 274)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(49, 19)
        Me.lblColor.TabIndex = 6
        Me.lblColor.Text = "Color:"
        '
        'chkConvertible
        '
        Me.chkConvertible.AutoSize = True
        Me.chkConvertible.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConvertible.Location = New System.Drawing.Point(350, 278)
        Me.chkConvertible.Name = "chkConvertible"
        Me.chkConvertible.Size = New System.Drawing.Size(96, 19)
        Me.chkConvertible.TabIndex = 6
        Me.chkConvertible.Text = "Convertible?"
        Me.chkConvertible.UseVisualStyleBackColor = True
        '
        'btnStickerPrice
        '
        Me.btnStickerPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStickerPrice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStickerPrice.ForeColor = System.Drawing.Color.White
        Me.btnStickerPrice.Location = New System.Drawing.Point(121, 314)
        Me.btnStickerPrice.Name = "btnStickerPrice"
        Me.btnStickerPrice.Size = New System.Drawing.Size(114, 34)
        Me.btnStickerPrice.TabIndex = 7
        Me.btnStickerPrice.Text = "Sticker Price"
        Me.btnStickerPrice.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(276, 314)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 34)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblStickerPriceValue
        '
        Me.lblStickerPriceValue.AutoSize = True
        Me.lblStickerPriceValue.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStickerPriceValue.Location = New System.Drawing.Point(270, 367)
        Me.lblStickerPriceValue.Name = "lblStickerPriceValue"
        Me.lblStickerPriceValue.Size = New System.Drawing.Size(100, 23)
        Me.lblStickerPriceValue.TabIndex = 11
        Me.lblStickerPriceValue.Text = "$XX,XXX.XX"
        Me.lblStickerPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblStickerPriceValue.Visible = False
        '
        'picMiniConvert
        '
        Me.picMiniConvert.BackgroundImage = CType(resources.GetObject("picMiniConvert.BackgroundImage"), System.Drawing.Image)
        Me.picMiniConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMiniConvert.Location = New System.Drawing.Point(307, 90)
        Me.picMiniConvert.Name = "picMiniConvert"
        Me.picMiniConvert.Size = New System.Drawing.Size(180, 170)
        Me.picMiniConvert.TabIndex = 12
        Me.picMiniConvert.TabStop = False
        Me.picMiniConvert.Visible = False
        '
        'txtVehicleMileage
        '
        Me.txtVehicleMileage.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleMileage.Location = New System.Drawing.Point(136, 200)
        Me.txtVehicleMileage.Name = "txtVehicleMileage"
        Me.txtVehicleMileage.Size = New System.Drawing.Size(153, 23)
        Me.txtVehicleMileage.TabIndex = 3
        '
        'cboVehicleColor
        '
        Me.cboVehicleColor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicleColor.FormattingEnabled = True
        Me.cboVehicleColor.Items.AddRange(New Object() {"Astro Black Metallic", "Bright Yellow", "Brilliant Copper Metallic", "British Racing Green Metallic", "Caribbean Aqua Metallic", "Chili Red", "Cool Blue Metallic", "Cosmic Blue Metallic", "Electric Blue Metallic", "Hot Chocolate", "Hot Orange Metallic", "Ice Blue", "Light White", "Melting Silver Metallic", "Pure Burgundy", "Royal Gray Metallic", "Silk Green Metallic", "Solid Gold Metallic", "Volcanic Orange", "Mellow Yellow"})
        Me.cboVehicleColor.Location = New System.Drawing.Point(136, 272)
        Me.cboVehicleColor.Name = "cboVehicleColor"
        Me.cboVehicleColor.Size = New System.Drawing.Size(153, 23)
        Me.cboVehicleColor.TabIndex = 5
        '
        'cboVehicleModel
        '
        Me.cboVehicleModel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicleModel.FormattingEnabled = True
        Me.cboVehicleModel.Items.AddRange(New Object() {"Clubman", "Cooper", "Cooper S", "Cooper SE", "Cooper Works", "Countryman"})
        Me.cboVehicleModel.Location = New System.Drawing.Point(136, 126)
        Me.cboVehicleModel.Name = "cboVehicleModel"
        Me.cboVehicleModel.Size = New System.Drawing.Size(153, 23)
        Me.cboVehicleModel.TabIndex = 1
        '
        'txtVehicleNumber
        '
        Me.txtVehicleNumber.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleNumber.Location = New System.Drawing.Point(136, 91)
        Me.txtVehicleNumber.Name = "txtVehicleNumber"
        Me.txtVehicleNumber.Size = New System.Drawing.Size(153, 23)
        Me.txtVehicleNumber.TabIndex = 0
        '
        'txtVehicleYear
        '
        Me.txtVehicleYear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleYear.Location = New System.Drawing.Point(136, 165)
        Me.txtVehicleYear.Name = "txtVehicleYear"
        Me.txtVehicleYear.Size = New System.Drawing.Size(153, 23)
        Me.txtVehicleYear.TabIndex = 2
        '
        'txtVehiclePrice
        '
        Me.txtVehiclePrice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehiclePrice.Location = New System.Drawing.Point(136, 239)
        Me.txtVehiclePrice.Name = "txtVehiclePrice"
        Me.txtVehiclePrice.Size = New System.Drawing.Size(153, 23)
        Me.txtVehiclePrice.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(504, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplayInventory, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuDisplayInventory
        '
        Me.mnuDisplayInventory.Name = "mnuDisplayInventory"
        Me.mnuDisplayInventory.Size = New System.Drawing.Size(165, 22)
        Me.mnuDisplayInventory.Text = "Display Inventory"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(165, 22)
        Me.mnuExit.Text = "Exit"
        '
        'picMiniHardtop
        '
        Me.picMiniHardtop.BackgroundImage = CType(resources.GetObject("picMiniHardtop.BackgroundImage"), System.Drawing.Image)
        Me.picMiniHardtop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMiniHardtop.Location = New System.Drawing.Point(307, 90)
        Me.picMiniHardtop.Name = "picMiniHardtop"
        Me.picMiniHardtop.Size = New System.Drawing.Size(180, 170)
        Me.picMiniHardtop.TabIndex = 28
        Me.picMiniHardtop.TabStop = False
        '
        'lblStickerPrice
        '
        Me.lblStickerPrice.AutoSize = True
        Me.lblStickerPrice.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStickerPrice.Location = New System.Drawing.Point(135, 367)
        Me.lblStickerPrice.Name = "lblStickerPrice"
        Me.lblStickerPrice.Size = New System.Drawing.Size(129, 23)
        Me.lblStickerPrice.TabIndex = 29
        Me.lblStickerPrice.Text = "Sticker Price is:"
        Me.lblStickerPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblStickerPrice.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(504, 399)
        Me.Controls.Add(Me.lblStickerPrice)
        Me.Controls.Add(Me.picMiniHardtop)
        Me.Controls.Add(Me.txtVehiclePrice)
        Me.Controls.Add(Me.txtVehicleYear)
        Me.Controls.Add(Me.txtVehicleNumber)
        Me.Controls.Add(Me.cboVehicleModel)
        Me.Controls.Add(Me.cboVehicleColor)
        Me.Controls.Add(Me.txtVehicleMileage)
        Me.Controls.Add(Me.picMiniConvert)
        Me.Controls.Add(Me.lblStickerPriceValue)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStickerPrice)
        Me.Controls.Add(Me.chkConvertible)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblVehiclePrice)
        Me.Controls.Add(Me.lblMileage)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblVehicleModel)
        Me.Controls.Add(Me.lblVehicleNumber)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Mini Cooper Dealership by Dave Minkowski"
        CType(Me.picMiniConvert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picMiniHardtop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVehicleNumber As Label
    Friend WithEvents lblVehicleModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMileage As Label
    Friend WithEvents lblVehiclePrice As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents chkConvertible As CheckBox
    Friend WithEvents btnStickerPrice As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblStickerPriceValue As Label
    Friend WithEvents picMiniConvert As PictureBox
    Friend WithEvents txtVehicleMileage As TextBox
    Friend WithEvents cboVehicleColor As ComboBox
    Friend WithEvents cboVehicleModel As ComboBox
    Friend WithEvents txtVehicleNumber As TextBox
    Friend WithEvents txtVehicleYear As TextBox
    Friend WithEvents txtVehiclePrice As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDisplayInventory As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents picMiniHardtop As PictureBox
    Friend WithEvents lblStickerPrice As Label
End Class
