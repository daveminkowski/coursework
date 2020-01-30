<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRentals))
        Me.lblCityList = New System.Windows.Forms.Label()
        Me.lstCities = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.lblCitiesMedian = New System.Windows.Forms.Label()
        Me.lblCitiesMedianCost = New System.Windows.Forms.Label()
        Me.picRental = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picRental, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCityList
        '
        Me.lblCityList.AutoSize = True
        Me.lblCityList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityList.Location = New System.Drawing.Point(384, 82)
        Me.lblCityList.Name = "lblCityList"
        Me.lblCityList.Size = New System.Drawing.Size(100, 20)
        Me.lblCityList.TabIndex = 12
        Me.lblCityList.Text = "Select City:"
        '
        'lstCities
        '
        Me.lstCities.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCities.ForeColor = System.Drawing.Color.Gray
        Me.lstCities.FormattingEnabled = True
        Me.lstCities.ItemHeight = 16
        Me.lstCities.Location = New System.Drawing.Point(354, 105)
        Me.lstCities.Name = "lstCities"
        Me.lstCities.Size = New System.Drawing.Size(161, 228)
        Me.lstCities.TabIndex = 10
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Sienna
        Me.lblTitle.Location = New System.Drawing.Point(8, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(532, 31)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Two-Bedroom Median Apartment Rental"
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.Sienna
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.White
        Me.btnCalc.Location = New System.Drawing.Point(157, 390)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(231, 34)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Compute Average Rental Cost"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplay, Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(263, 22)
        Me.mnuDisplay.Text = "Display Top 10 Cities && Rental Costs"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(263, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(263, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(45, 358)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSummary.Size = New System.Drawing.Size(458, 16)
        Me.lblSummary.TabIndex = 14
        Me.lblSummary.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSummary.Visible = False
        '
        'lblCitiesMedian
        '
        Me.lblCitiesMedian.AutoSize = True
        Me.lblCitiesMedian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitiesMedian.Location = New System.Drawing.Point(74, 437)
        Me.lblCitiesMedian.Name = "lblCitiesMedian"
        Me.lblCitiesMedian.Size = New System.Drawing.Size(308, 16)
        Me.lblCitiesMedian.TabIndex = 16
        Me.lblCitiesMedian.Text = "Median Monthly Rental Cost Of All 10 Cities:"
        Me.lblCitiesMedian.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCitiesMedian.Visible = False
        '
        'lblCitiesMedianCost
        '
        Me.lblCitiesMedianCost.AutoSize = True
        Me.lblCitiesMedianCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitiesMedianCost.Location = New System.Drawing.Point(393, 437)
        Me.lblCitiesMedianCost.Name = "lblCitiesMedianCost"
        Me.lblCitiesMedianCost.Size = New System.Drawing.Size(78, 16)
        Me.lblCitiesMedianCost.TabIndex = 17
        Me.lblCitiesMedianCost.Text = "$X,XXX.XX"
        Me.lblCitiesMedianCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCitiesMedianCost.Visible = False
        '
        'picRental
        '
        Me.picRental.BackgroundImage = CType(resources.GetObject("picRental.BackgroundImage"), System.Drawing.Image)
        Me.picRental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRental.Location = New System.Drawing.Point(48, 89)
        Me.picRental.Name = "picRental"
        Me.picRental.Size = New System.Drawing.Size(259, 244)
        Me.picRental.TabIndex = 18
        Me.picRental.TabStop = False
        '
        'frmRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 482)
        Me.Controls.Add(Me.picRental)
        Me.Controls.Add(Me.lblCitiesMedianCost)
        Me.Controls.Add(Me.lblCitiesMedian)
        Me.Controls.Add(Me.lblCityList)
        Me.Controls.Add(Me.lstCities)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblSummary)
        Me.Name = "frmRentals"
        Me.Text = "Apartment Rentals by City by Dave Minkowski"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picRental, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCityList As Label
    Friend WithEvents lstCities As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblSummary As Label
    Friend WithEvents lblCitiesMedian As Label
    Friend WithEvents lblCitiesMedianCost As Label
    Friend WithEvents picRental As PictureBox
End Class
