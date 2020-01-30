<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicConvention
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComicConvention))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.lblRegistraton = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radBasic = New System.Windows.Forms.RadioButton()
        Me.radAutograph = New System.Windows.Forms.RadioButton()
        Me.radSuperhero = New System.Windows.Forms.RadioButton()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.grpBadgeType.SuspendLayout()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeader.Location = New System.Drawing.Point(34, 210)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(355, 37)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Comic Convention Registration"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Firebrick
        Me.lblGroupSize.Location = New System.Drawing.Point(102, 265)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(103, 26)
        Me.lblGroupSize.TabIndex = 1
        Me.lblGroupSize.Text = "Group Size:"
        '
        'lblRegistraton
        '
        Me.lblRegistraton.AutoSize = True
        Me.lblRegistraton.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistraton.ForeColor = System.Drawing.Color.Firebrick
        Me.lblRegistraton.Location = New System.Drawing.Point(87, 437)
        Me.lblRegistraton.Name = "lblRegistraton"
        Me.lblRegistraton.Size = New System.Drawing.Size(155, 26)
        Me.lblRegistraton.TabIndex = 5
        Me.lblRegistraton.Text = "Registration Cost:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.Firebrick
        Me.lblTotalCost.Location = New System.Drawing.Point(241, 437)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(94, 26)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "$0000.00"
        '
        'grpBadgeType
        '
        Me.grpBadgeType.BackColor = System.Drawing.Color.CadetBlue
        Me.grpBadgeType.Controls.Add(Me.radBasic)
        Me.grpBadgeType.Controls.Add(Me.radAutograph)
        Me.grpBadgeType.Controls.Add(Me.radSuperhero)
        Me.grpBadgeType.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.Location = New System.Drawing.Point(60, 314)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(302, 106)
        Me.grpBadgeType.TabIndex = 7
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'radBasic
        '
        Me.radBasic.AutoSize = True
        Me.radBasic.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBasic.Location = New System.Drawing.Point(32, 75)
        Me.radBasic.Name = "radBasic"
        Me.radBasic.Size = New System.Drawing.Size(99, 25)
        Me.radBasic.TabIndex = 2
        Me.radBasic.Text = "Convention"
        Me.radBasic.UseVisualStyleBackColor = True
        '
        'radAutograph
        '
        Me.radAutograph.AutoSize = True
        Me.radAutograph.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAutograph.Location = New System.Drawing.Point(32, 50)
        Me.radAutograph.Name = "radAutograph"
        Me.radAutograph.Size = New System.Drawing.Size(187, 25)
        Me.radAutograph.TabIndex = 1
        Me.radAutograph.Text = "Convention && Autographs"
        Me.radAutograph.UseVisualStyleBackColor = True
        '
        'radSuperhero
        '
        Me.radSuperhero.AutoSize = True
        Me.radSuperhero.Checked = True
        Me.radSuperhero.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSuperhero.Location = New System.Drawing.Point(32, 25)
        Me.radSuperhero.Name = "radSuperhero"
        Me.radSuperhero.Size = New System.Drawing.Size(249, 25)
        Me.radSuperhero.TabIndex = 0
        Me.radSuperhero.TabStop = True
        Me.radSuperhero.Text = "Convention && Superhero Experience"
        Me.radSuperhero.UseVisualStyleBackColor = True
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.ForeColor = System.Drawing.Color.Firebrick
        Me.txtGroupSize.Location = New System.Drawing.Point(220, 262)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(100, 31)
        Me.txtGroupSize.TabIndex = 8
        Me.txtGroupSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.CadetBlue
        Me.btnCalc.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(99, 477)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(99, 30)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.CadetBlue
        Me.btnClear.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(224, 477)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'picComic
        '
        Me.picComic.BackgroundImage = CType(resources.GetObject("picComic.BackgroundImage"), System.Drawing.Image)
        Me.picComic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picComic.Location = New System.Drawing.Point(-6, 1)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(435, 203)
        Me.picComic.TabIndex = 11
        Me.picComic.TabStop = False
        '
        'frmComicConvention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(423, 519)
        Me.Controls.Add(Me.picComic)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblRegistraton)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmComicConvention"
        Me.Text = "Comic Convention Registration by Dave Minkowski"
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents lblRegistraton As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radBasic As RadioButton
    Friend WithEvents radAutograph As RadioButton
    Friend WithEvents radSuperhero As RadioButton
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents picComic As PictureBox
End Class
