<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceData
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
        Me.lstCities = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lstPrices = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstCities
        '
        Me.lstCities.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCities.FormattingEnabled = True
        Me.lstCities.ItemHeight = 20
        Me.lstCities.Location = New System.Drawing.Point(56, 30)
        Me.lstCities.Name = "lstCities"
        Me.lstCities.Size = New System.Drawing.Size(180, 284)
        Me.lstCities.TabIndex = 0
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Sienna
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(119, 355)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(237, 63)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return to Rental Cities"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lstPrices
        '
        Me.lstPrices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrices.FormattingEnabled = True
        Me.lstPrices.ItemHeight = 20
        Me.lstPrices.Location = New System.Drawing.Point(239, 30)
        Me.lstPrices.Name = "lstPrices"
        Me.lstPrices.Size = New System.Drawing.Size(180, 284)
        Me.lstPrices.TabIndex = 3
        '
        'frmPriceData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 440)
        Me.Controls.Add(Me.lstPrices)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstCities)
        Me.Name = "frmPriceData"
        Me.Text = "City Rentals"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstCities As ListBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents lstPrices As ListBox
End Class
