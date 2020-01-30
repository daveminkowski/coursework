<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainfall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRainfall))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstMonthlyRainfall = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblAverageRainfall = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(130, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(461, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Most Rainfall in U.S. - Kauai"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstMonthlyRainfall
        '
        Me.lstMonthlyRainfall.BackColor = System.Drawing.SystemColors.Control
        Me.lstMonthlyRainfall.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMonthlyRainfall.ForeColor = System.Drawing.Color.Black
        Me.lstMonthlyRainfall.FormattingEnabled = True
        Me.lstMonthlyRainfall.ItemHeight = 23
        Me.lstMonthlyRainfall.Location = New System.Drawing.Point(613, 117)
        Me.lstMonthlyRainfall.Name = "lstMonthlyRainfall"
        Me.lstMonthlyRainfall.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstMonthlyRainfall.Size = New System.Drawing.Size(43, 280)
        Me.lstMonthlyRainfall.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(286, 337)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(148, 34)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Enter Rainfall"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblAverageRainfall
        '
        Me.lblAverageRainfall.AutoSize = True
        Me.lblAverageRainfall.BackColor = System.Drawing.Color.Transparent
        Me.lblAverageRainfall.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageRainfall.ForeColor = System.Drawing.Color.Gold
        Me.lblAverageRainfall.Location = New System.Drawing.Point(50, 205)
        Me.lblAverageRainfall.Name = "lblAverageRainfall"
        Me.lblAverageRainfall.Size = New System.Drawing.Size(496, 29)
        Me.lblAverageRainfall.TabIndex = 3
        Me.lblAverageRainfall.Text = "Average Monthly Rainfall is XX.X Inches."
        Me.lblAverageRainfall.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'frmRainfall
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(721, 438)
        Me.Controls.Add(Me.lblAverageRainfall)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lstMonthlyRainfall)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRainfall"
        Me.Text = "Most Rainfall in USA by Dave Minkowski"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lstMonthlyRainfall As ListBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblAverageRainfall As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
