<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTravelSpecials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTravelSpecials))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.picMyrtle = New System.Windows.Forms.PictureBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnMyrtle = New System.Windows.Forms.Button()
        Me.btnVenice = New System.Windows.Forms.Button()
        Me.btnKeyWest = New System.Windows.Forms.Button()
        Me.lblMyrtle = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.picKeyWest = New System.Windows.Forms.PictureBox()
        Me.picVenice = New System.Windows.Forms.PictureBox()
        Me.lblKeyWest = New System.Windows.Forms.Label()
        Me.lblVenice = New System.Windows.Forms.Label()
        Me.lblMyrtleDescription = New System.Windows.Forms.Label()
        Me.lblKeyWestDescription = New System.Windows.Forms.Label()
        Me.lblVeniceDescription = New System.Windows.Forms.Label()
        CType(Me.picMyrtle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeyWest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVenice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(42, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(351, 36)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Spring Break Travel Specials"
        '
        'picMyrtle
        '
        Me.picMyrtle.Image = CType(resources.GetObject("picMyrtle.Image"), System.Drawing.Image)
        Me.picMyrtle.Location = New System.Drawing.Point(67, 159)
        Me.picMyrtle.Name = "picMyrtle"
        Me.picMyrtle.Size = New System.Drawing.Size(300, 150)
        Me.picMyrtle.TabIndex = 1
        Me.picMyrtle.TabStop = False
        Me.picMyrtle.Visible = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(71, 56)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(293, 18)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Click to choose one of our 3 beautiful locations:"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnMyrtle
        '
        Me.btnMyrtle.BackColor = System.Drawing.Color.AliceBlue
        Me.btnMyrtle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyrtle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnMyrtle.Location = New System.Drawing.Point(23, 102)
        Me.btnMyrtle.Name = "btnMyrtle"
        Me.btnMyrtle.Size = New System.Drawing.Size(115, 35)
        Me.btnMyrtle.TabIndex = 3
        Me.btnMyrtle.Text = "Myrtle Beach"
        Me.btnMyrtle.UseVisualStyleBackColor = False
        '
        'btnVenice
        '
        Me.btnVenice.BackColor = System.Drawing.Color.AliceBlue
        Me.btnVenice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenice.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnVenice.Location = New System.Drawing.Point(297, 102)
        Me.btnVenice.Name = "btnVenice"
        Me.btnVenice.Size = New System.Drawing.Size(115, 35)
        Me.btnVenice.TabIndex = 4
        Me.btnVenice.Text = "Venice Beach"
        Me.btnVenice.UseVisualStyleBackColor = False
        '
        'btnKeyWest
        '
        Me.btnKeyWest.BackColor = System.Drawing.Color.AliceBlue
        Me.btnKeyWest.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeyWest.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnKeyWest.Location = New System.Drawing.Point(160, 102)
        Me.btnKeyWest.Name = "btnKeyWest"
        Me.btnKeyWest.Size = New System.Drawing.Size(115, 35)
        Me.btnKeyWest.TabIndex = 5
        Me.btnKeyWest.Text = "Key West"
        Me.btnKeyWest.UseVisualStyleBackColor = False
        '
        'lblMyrtle
        '
        Me.lblMyrtle.AutoSize = True
        Me.lblMyrtle.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyrtle.Location = New System.Drawing.Point(153, 322)
        Me.lblMyrtle.Name = "lblMyrtle"
        Me.lblMyrtle.Size = New System.Drawing.Size(128, 26)
        Me.lblMyrtle.TabIndex = 6
        Me.lblMyrtle.Text = "Myrtle Beach"
        Me.lblMyrtle.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelect.Enabled = False
        Me.btnSelect.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.Black
        Me.btnSelect.Location = New System.Drawing.Point(147, 434)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(140, 35)
        Me.btnSelect.TabIndex = 7
        Me.btnSelect.Text = "Select this trip!"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Enabled = False
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(177, 514)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblConfirmation.Location = New System.Drawing.Point(119, 370)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(197, 36)
        Me.lblConfirmation.TabIndex = 9
        Me.lblConfirmation.Text = "Enjoy your trip!"
        Me.lblConfirmation.Visible = False
        '
        'picKeyWest
        '
        Me.picKeyWest.Image = CType(resources.GetObject("picKeyWest.Image"), System.Drawing.Image)
        Me.picKeyWest.Location = New System.Drawing.Point(67, 159)
        Me.picKeyWest.Name = "picKeyWest"
        Me.picKeyWest.Size = New System.Drawing.Size(300, 150)
        Me.picKeyWest.TabIndex = 10
        Me.picKeyWest.TabStop = False
        Me.picKeyWest.Visible = False
        '
        'picVenice
        '
        Me.picVenice.Image = CType(resources.GetObject("picVenice.Image"), System.Drawing.Image)
        Me.picVenice.Location = New System.Drawing.Point(67, 159)
        Me.picVenice.Name = "picVenice"
        Me.picVenice.Size = New System.Drawing.Size(300, 150)
        Me.picVenice.TabIndex = 11
        Me.picVenice.TabStop = False
        Me.picVenice.Visible = False
        '
        'lblKeyWest
        '
        Me.lblKeyWest.AutoSize = True
        Me.lblKeyWest.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeyWest.Location = New System.Drawing.Point(171, 322)
        Me.lblKeyWest.Name = "lblKeyWest"
        Me.lblKeyWest.Size = New System.Drawing.Size(93, 26)
        Me.lblKeyWest.TabIndex = 12
        Me.lblKeyWest.Text = "Key West"
        Me.lblKeyWest.Visible = False
        '
        'lblVenice
        '
        Me.lblVenice.AutoSize = True
        Me.lblVenice.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenice.Location = New System.Drawing.Point(153, 322)
        Me.lblVenice.Name = "lblVenice"
        Me.lblVenice.Size = New System.Drawing.Size(128, 26)
        Me.lblVenice.TabIndex = 13
        Me.lblVenice.Text = "Venice Beach"
        Me.lblVenice.Visible = False
        '
        'lblMyrtleDescription
        '
        Me.lblMyrtleDescription.AutoSize = True
        Me.lblMyrtleDescription.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyrtleDescription.Location = New System.Drawing.Point(35, 377)
        Me.lblMyrtleDescription.Name = "lblMyrtleDescription"
        Me.lblMyrtleDescription.Size = New System.Drawing.Size(364, 30)
        Me.lblMyrtleDescription.TabIndex = 14
        Me.lblMyrtleDescription.Text = "Sixty miles of beautiful sandy beaches, first-class live entertainment " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and thri" &
    "lling water sports!"
        Me.lblMyrtleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMyrtleDescription.Visible = False
        '
        'lblKeyWestDescription
        '
        Me.lblKeyWestDescription.AutoSize = True
        Me.lblKeyWestDescription.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeyWestDescription.Location = New System.Drawing.Point(20, 377)
        Me.lblKeyWestDescription.Name = "lblKeyWestDescription"
        Me.lblKeyWestDescription.Size = New System.Drawing.Size(387, 30)
        Me.lblKeyWestDescription.TabIndex = 15
        Me.lblKeyWestDescription.Text = "A unique confluene of history, climate, natural beauty, cultural diversity, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "arc" &
    "hitecture and unabashed romantic appeal!"
        Me.lblKeyWestDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblKeyWestDescription.Visible = False
        '
        'lblVeniceDescription
        '
        Me.lblVeniceDescription.AutoSize = True
        Me.lblVeniceDescription.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeniceDescription.Location = New System.Drawing.Point(30, 377)
        Me.lblVeniceDescription.Name = "lblVeniceDescription"
        Me.lblVeniceDescription.Size = New System.Drawing.Size(375, 30)
        Me.lblVeniceDescription.TabIndex = 16
        Me.lblVeniceDescription.Text = "The World famous Venice Beach Boardwalk is not to be missed - more " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "diversity an" &
    "d retail per square inch than anywhere else in the world!"
        Me.lblVeniceDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblVeniceDescription.Visible = False
        '
        'frmTravelSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 561)
        Me.Controls.Add(Me.lblVeniceDescription)
        Me.Controls.Add(Me.lblKeyWestDescription)
        Me.Controls.Add(Me.lblMyrtleDescription)
        Me.Controls.Add(Me.lblVenice)
        Me.Controls.Add(Me.lblKeyWest)
        Me.Controls.Add(Me.picVenice)
        Me.Controls.Add(Me.picKeyWest)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblMyrtle)
        Me.Controls.Add(Me.btnKeyWest)
        Me.Controls.Add(Me.btnVenice)
        Me.Controls.Add(Me.btnMyrtle)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.picMyrtle)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmTravelSpecials"
        Me.Text = "Travel Specials by Dave Minkowski"
        CType(Me.picMyrtle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeyWest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVenice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents picMyrtle As PictureBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnMyrtle As Button
    Friend WithEvents btnVenice As Button
    Friend WithEvents btnKeyWest As Button
    Friend WithEvents lblMyrtle As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents picKeyWest As PictureBox
    Friend WithEvents picVenice As PictureBox
    Friend WithEvents lblKeyWest As Label
    Friend WithEvents lblVenice As Label
    Friend WithEvents lblMyrtleDescription As Label
    Friend WithEvents lblKeyWestDescription As Label
    Friend WithEvents lblVeniceDescription As Label
End Class
