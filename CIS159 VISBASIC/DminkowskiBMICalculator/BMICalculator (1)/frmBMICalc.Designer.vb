<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBMICalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBMICalc))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWeightInput = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lstUnitType = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblHeightInput = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeightType = New System.Windows.Forms.Label()
        Me.lblWeightType = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblTitle.Location = New System.Drawing.Point(108, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(201, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "BMI Calculator"
        '
        'lblWeightInput
        '
        Me.lblWeightInput.AutoSize = True
        Me.lblWeightInput.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightInput.Location = New System.Drawing.Point(103, 210)
        Me.lblWeightInput.Name = "lblWeightInput"
        Me.lblWeightInput.Size = New System.Drawing.Size(161, 23)
        Me.lblWeightInput.TabIndex = 2
        Me.lblWeightInput.Text = "Enter your weight in"
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(149, 244)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(115, 32)
        Me.txtWeight.TabIndex = 3
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(28, 73)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(237, 25)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Choose imperial or metric:"
        '
        'lstUnitType
        '
        Me.lstUnitType.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUnitType.FormattingEnabled = True
        Me.lstUnitType.ItemHeight = 23
        Me.lstUnitType.Items.AddRange(New Object() {"Imperial", "Metric"})
        Me.lstUnitType.Location = New System.Drawing.Point(279, 61)
        Me.lstUnitType.Name = "lstUnitType"
        Me.lstUnitType.Size = New System.Drawing.Size(109, 50)
        Me.lstUnitType.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnCalc.Enabled = False
        Me.btnCalc.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.White
        Me.btnCalc.Location = New System.Drawing.Point(59, 292)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(132, 35)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate BMI"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(225, 292)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblHeightInput
        '
        Me.lblHeightInput.AutoSize = True
        Me.lblHeightInput.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeightInput.Location = New System.Drawing.Point(105, 128)
        Me.lblHeightInput.Name = "lblHeightInput"
        Me.lblHeightInput.Size = New System.Drawing.Size(159, 23)
        Me.lblHeightInput.TabIndex = 11
        Me.lblHeightInput.Text = "Enter your height in"
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(149, 160)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(115, 32)
        Me.txtHeight.TabIndex = 12
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHeightType
        '
        Me.lblHeightType.AutoSize = True
        Me.lblHeightType.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeightType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHeightType.Location = New System.Drawing.Point(257, 128)
        Me.lblHeightType.Name = "lblHeightType"
        Me.lblHeightType.Size = New System.Drawing.Size(55, 23)
        Me.lblHeightType.TabIndex = 13
        Me.lblHeightType.Text = "xxxxx"
        '
        'lblWeightType
        '
        Me.lblWeightType.AutoSize = True
        Me.lblWeightType.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWeightType.Location = New System.Drawing.Point(258, 210)
        Me.lblWeightType.Name = "lblWeightType"
        Me.lblWeightType.Size = New System.Drawing.Size(55, 23)
        Me.lblWeightType.TabIndex = 14
        Me.lblWeightType.Text = "xxxxx"
        '
        'lblCategory
        '
        Me.lblCategory.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(22, 339)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(373, 96)
        Me.lblCategory.TabIndex = 3
        Me.lblCategory.Text = "XXXXXXXXXXXX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XXXXXXXXXXXX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XXXXXXXXXXXX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XXXXXXXXXXXX"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.lblCategory)
        Me.Panel1.Controls.Add(Me.lblWeightType)
        Me.Panel1.Controls.Add(Me.lblHeightType)
        Me.Panel1.Controls.Add(Me.txtHeight)
        Me.Panel1.Controls.Add(Me.lblHeightInput)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnCalc)
        Me.Panel1.Controls.Add(Me.lstUnitType)
        Me.Panel1.Controls.Add(Me.lblSelect)
        Me.Panel1.Controls.Add(Me.txtWeight)
        Me.Panel1.Controls.Add(Me.lblWeightInput)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 443)
        Me.Panel1.TabIndex = 2
        '
        'frmBMICalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(418, 444)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmBMICalc"
        Me.Text = "BMI Calculator by Dave Minkowski"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWeightInput As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents lstUnitType As ListBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblHeightInput As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeightType As Label
    Friend WithEvents lblWeightType As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents Panel1 As Panel
End Class
