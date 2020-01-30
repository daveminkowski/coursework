<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalculator
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
        Me.gbxTop = New System.Windows.Forms.GroupBox()
        Me.lblNetTotal = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.gbxBottom = New System.Windows.Forms.GroupBox()
        Me.lblFederalTotal = New System.Windows.Forms.Label()
        Me.lblStateTotal = New System.Windows.Forms.Label()
        Me.lblFICATotal = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblFederal = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.gbxTop.SuspendLayout()
        Me.gbxBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxTop
        '
        Me.gbxTop.Controls.Add(Me.lblNetTotal)
        Me.gbxTop.Controls.Add(Me.txtGrossPay)
        Me.gbxTop.Controls.Add(Me.lblNetPay)
        Me.gbxTop.Controls.Add(Me.lblGrossPay)
        Me.gbxTop.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTop.Location = New System.Drawing.Point(18, 29)
        Me.gbxTop.Name = "gbxTop"
        Me.gbxTop.Size = New System.Drawing.Size(363, 104)
        Me.gbxTop.TabIndex = 1
        Me.gbxTop.TabStop = False
        '
        'lblNetTotal
        '
        Me.lblNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetTotal.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNetTotal.Location = New System.Drawing.Point(165, 62)
        Me.lblNetTotal.Name = "lblNetTotal"
        Me.lblNetTotal.Size = New System.Drawing.Size(126, 27)
        Me.lblNetTotal.TabIndex = 3
        Me.lblNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(165, 28)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(126, 27)
        Me.txtGrossPay.TabIndex = 1
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(82, 66)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(69, 19)
        Me.lblNetPay.TabIndex = 2
        Me.lblNetPay.Text = "Net Pay:"
        Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(66, 31)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(85, 19)
        Me.lblGrossPay.TabIndex = 0
        Me.lblGrossPay.Text = "Gross Pay:"
        Me.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblHeader.Location = New System.Drawing.Point(110, 8)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(179, 23)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Payroll Calculator"
        '
        'gbxBottom
        '
        Me.gbxBottom.Controls.Add(Me.lblFederalTotal)
        Me.gbxBottom.Controls.Add(Me.lblStateTotal)
        Me.gbxBottom.Controls.Add(Me.lblFICATotal)
        Me.gbxBottom.Controls.Add(Me.lblState)
        Me.gbxBottom.Controls.Add(Me.lblFederal)
        Me.gbxBottom.Controls.Add(Me.lblFICA)
        Me.gbxBottom.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBottom.Location = New System.Drawing.Point(18, 136)
        Me.gbxBottom.Name = "gbxBottom"
        Me.gbxBottom.Size = New System.Drawing.Size(363, 158)
        Me.gbxBottom.TabIndex = 2
        Me.gbxBottom.TabStop = False
        '
        'lblFederalTotal
        '
        Me.lblFederalTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFederalTotal.ForeColor = System.Drawing.Color.Red
        Me.lblFederalTotal.Location = New System.Drawing.Point(216, 114)
        Me.lblFederalTotal.Name = "lblFederalTotal"
        Me.lblFederalTotal.Size = New System.Drawing.Size(126, 27)
        Me.lblFederalTotal.TabIndex = 5
        Me.lblFederalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStateTotal
        '
        Me.lblStateTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStateTotal.ForeColor = System.Drawing.Color.Red
        Me.lblStateTotal.Location = New System.Drawing.Point(216, 71)
        Me.lblStateTotal.Name = "lblStateTotal"
        Me.lblStateTotal.Size = New System.Drawing.Size(126, 27)
        Me.lblStateTotal.TabIndex = 3
        Me.lblStateTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFICATotal
        '
        Me.lblFICATotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFICATotal.ForeColor = System.Drawing.Color.Red
        Me.lblFICATotal.Location = New System.Drawing.Point(216, 28)
        Me.lblFICATotal.Name = "lblFICATotal"
        Me.lblFICATotal.Size = New System.Drawing.Size(126, 27)
        Me.lblFICATotal.TabIndex = 1
        Me.lblFICATotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(35, 75)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(163, 19)
        Me.lblState.TabIndex = 2
        Me.lblState.Text = "State Taxes Withheld:"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFederal
        '
        Me.lblFederal.AutoSize = True
        Me.lblFederal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederal.Location = New System.Drawing.Point(19, 118)
        Me.lblFederal.Name = "lblFederal"
        Me.lblFederal.Size = New System.Drawing.Size(179, 19)
        Me.lblFederal.TabIndex = 4
        Me.lblFederal.Text = "Federal Taxes Withheld:"
        Me.lblFederal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.Location = New System.Drawing.Point(35, 32)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(163, 19)
        Me.lblFICA.TabIndex = 0
        Me.lblFICA.Text = "FICA Taxes Withheld:"
        Me.lblFICA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(151, 313)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 32)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(281, 313)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 32)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(21, 313)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(96, 32)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmPayrollCalculator
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(398, 365)
        Me.Controls.Add(Me.gbxTop)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.gbxBottom)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmPayrollCalculator"
        Me.Text = "Payroll Calculator by Dave Minkowski"
        Me.gbxTop.ResumeLayout(False)
        Me.gbxTop.PerformLayout()
        Me.gbxBottom.ResumeLayout(False)
        Me.gbxBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents gbxTop As GroupBox
    Private WithEvents lblNetTotal As Label
    Private WithEvents txtGrossPay As TextBox
    Private WithEvents lblNetPay As Label
    Private WithEvents lblGrossPay As Label
    Private WithEvents lblHeader As Label
    Private WithEvents gbxBottom As GroupBox
    Private WithEvents lblFederalTotal As Label
    Private WithEvents lblStateTotal As Label
    Private WithEvents lblFICATotal As Label
    Private WithEvents lblState As Label
    Private WithEvents lblFederal As Label
    Private WithEvents lblFICA As Label
    Private WithEvents btnClear As Button
    Private WithEvents btnExit As Button
    Private WithEvents btnCalc As Button
End Class
