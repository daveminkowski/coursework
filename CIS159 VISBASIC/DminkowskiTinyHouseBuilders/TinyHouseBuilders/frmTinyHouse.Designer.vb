<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTinyHouse
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
        Me.components = New System.ComponentModel.Container()
        Dim Builder_IDLabel As System.Windows.Forms.Label
        Dim BuilderLabel As System.Windows.Forms.Label
        Dim Tiny_House_SpecialityLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim Builds_On_SiteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTinyHouse))
        Me.picBuilder = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TinyHousesDataSet = New Tiny_House_Builders.TinyHousesDataSet()
        Me.BuildersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuildersTableAdapter = New Tiny_House_Builders.TinyHousesDataSetTableAdapters.BuildersTableAdapter()
        Me.TableAdapterManager = New Tiny_House_Builders.TinyHousesDataSetTableAdapters.TableAdapterManager()
        Me.BuildersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuildersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Builder_IDTextBox = New System.Windows.Forms.TextBox()
        Me.BuilderTextBox = New System.Windows.Forms.TextBox()
        Me.Tiny_House_SpecialityTextBox = New System.Windows.Forms.TextBox()
        Me.Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.chkBuildsOnSite = New System.Windows.Forms.CheckBox()
        Builder_IDLabel = New System.Windows.Forms.Label()
        BuilderLabel = New System.Windows.Forms.Label()
        Tiny_House_SpecialityLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Builds_On_SiteLabel = New System.Windows.Forms.Label()
        CType(Me.picBuilder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TinyHousesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BuildersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Builder_IDLabel
        '
        Builder_IDLabel.AutoSize = True
        Builder_IDLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Builder_IDLabel.Location = New System.Drawing.Point(483, 97)
        Builder_IDLabel.Name = "Builder_IDLabel"
        Builder_IDLabel.Size = New System.Drawing.Size(75, 20)
        Builder_IDLabel.TabIndex = 3
        Builder_IDLabel.Text = "Builder ID:"
        '
        'BuilderLabel
        '
        BuilderLabel.AutoSize = True
        BuilderLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BuilderLabel.Location = New System.Drawing.Point(500, 152)
        BuilderLabel.Name = "BuilderLabel"
        BuilderLabel.Size = New System.Drawing.Size(58, 20)
        BuilderLabel.TabIndex = 5
        BuilderLabel.Text = "Builder:"
        '
        'Tiny_House_SpecialityLabel
        '
        Tiny_House_SpecialityLabel.AutoSize = True
        Tiny_House_SpecialityLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tiny_House_SpecialityLabel.Location = New System.Drawing.Point(410, 207)
        Tiny_House_SpecialityLabel.Name = "Tiny_House_SpecialityLabel"
        Tiny_House_SpecialityLabel.Size = New System.Drawing.Size(148, 20)
        Tiny_House_SpecialityLabel.TabIndex = 7
        Tiny_House_SpecialityLabel.Text = "Tiny House Speciality:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_AddressLabel.Location = New System.Drawing.Point(454, 262)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(104, 20)
        Email_AddressLabel.TabIndex = 9
        Email_AddressLabel.Text = "Email Address:"
        '
        'Builds_On_SiteLabel
        '
        Builds_On_SiteLabel.AutoSize = True
        Builds_On_SiteLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Builds_On_SiteLabel.Location = New System.Drawing.Point(455, 315)
        Builds_On_SiteLabel.Name = "Builds_On_SiteLabel"
        Builds_On_SiteLabel.Size = New System.Drawing.Size(103, 20)
        Builds_On_SiteLabel.TabIndex = 11
        Builds_On_SiteLabel.Text = "Builds On-Site:"
        '
        'picBuilder
        '
        Me.picBuilder.BackgroundImage = CType(resources.GetObject("picBuilder.BackgroundImage"), System.Drawing.Image)
        Me.picBuilder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBuilder.Location = New System.Drawing.Point(0, 24)
        Me.picBuilder.Name = "picBuilder"
        Me.picBuilder.Size = New System.Drawing.Size(400, 350)
        Me.picBuilder.TabIndex = 0
        Me.picBuilder.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bernard MT Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(442, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(253, 34)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Tiny House Builders"
        '
        'TinyHousesDataSet
        '
        Me.TinyHousesDataSet.DataSetName = "TinyHousesDataSet"
        Me.TinyHousesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuildersBindingSource
        '
        Me.BuildersBindingSource.DataMember = "Builders"
        Me.BuildersBindingSource.DataSource = Me.TinyHousesDataSet
        '
        'BuildersTableAdapter
        '
        Me.BuildersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuildersTableAdapter = Me.BuildersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tiny_House_Builders.TinyHousesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuildersBindingNavigator
        '
        Me.BuildersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BuildersBindingNavigator.BindingSource = Me.BuildersBindingSource
        Me.BuildersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BuildersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BuildersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BuildersBindingNavigatorSaveItem})
        Me.BuildersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BuildersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BuildersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BuildersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BuildersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BuildersBindingNavigator.Name = "BuildersBindingNavigator"
        Me.BuildersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BuildersBindingNavigator.Size = New System.Drawing.Size(762, 25)
        Me.BuildersBindingNavigator.TabIndex = 2
        Me.BuildersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BuildersBindingNavigatorSaveItem
        '
        Me.BuildersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BuildersBindingNavigatorSaveItem.Image = CType(resources.GetObject("BuildersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BuildersBindingNavigatorSaveItem.Name = "BuildersBindingNavigatorSaveItem"
        Me.BuildersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BuildersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Builder_IDTextBox
        '
        Me.Builder_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuildersBindingSource, "Builder ID", True))
        Me.Builder_IDTextBox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Builder_IDTextBox.Location = New System.Drawing.Point(564, 94)
        Me.Builder_IDTextBox.Name = "Builder_IDTextBox"
        Me.Builder_IDTextBox.Size = New System.Drawing.Size(169, 26)
        Me.Builder_IDTextBox.TabIndex = 4
        '
        'BuilderTextBox
        '
        Me.BuilderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuildersBindingSource, "Builder", True))
        Me.BuilderTextBox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuilderTextBox.Location = New System.Drawing.Point(564, 149)
        Me.BuilderTextBox.Name = "BuilderTextBox"
        Me.BuilderTextBox.Size = New System.Drawing.Size(169, 26)
        Me.BuilderTextBox.TabIndex = 6
        '
        'Tiny_House_SpecialityTextBox
        '
        Me.Tiny_House_SpecialityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuildersBindingSource, "Tiny House Speciality", True))
        Me.Tiny_House_SpecialityTextBox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiny_House_SpecialityTextBox.Location = New System.Drawing.Point(564, 204)
        Me.Tiny_House_SpecialityTextBox.Name = "Tiny_House_SpecialityTextBox"
        Me.Tiny_House_SpecialityTextBox.Size = New System.Drawing.Size(169, 26)
        Me.Tiny_House_SpecialityTextBox.TabIndex = 8
        '
        'Email_AddressTextBox
        '
        Me.Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuildersBindingSource, "Email Address", True))
        Me.Email_AddressTextBox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_AddressTextBox.Location = New System.Drawing.Point(564, 259)
        Me.Email_AddressTextBox.Name = "Email_AddressTextBox"
        Me.Email_AddressTextBox.Size = New System.Drawing.Size(169, 26)
        Me.Email_AddressTextBox.TabIndex = 10
        '
        'chkBuildsOnSite
        '
        Me.chkBuildsOnSite.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BuildersBindingSource, "Builds On-Site", True))
        Me.chkBuildsOnSite.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuildsOnSite.Location = New System.Drawing.Point(564, 314)
        Me.chkBuildsOnSite.Name = "chkBuildsOnSite"
        Me.chkBuildsOnSite.Size = New System.Drawing.Size(104, 24)
        Me.chkBuildsOnSite.TabIndex = 12
        Me.chkBuildsOnSite.UseVisualStyleBackColor = True
        '
        'frmTinyHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(762, 370)
        Me.Controls.Add(Builds_On_SiteLabel)
        Me.Controls.Add(Me.chkBuildsOnSite)
        Me.Controls.Add(Email_AddressLabel)
        Me.Controls.Add(Me.Email_AddressTextBox)
        Me.Controls.Add(Tiny_House_SpecialityLabel)
        Me.Controls.Add(Me.Tiny_House_SpecialityTextBox)
        Me.Controls.Add(BuilderLabel)
        Me.Controls.Add(Me.BuilderTextBox)
        Me.Controls.Add(Builder_IDLabel)
        Me.Controls.Add(Me.Builder_IDTextBox)
        Me.Controls.Add(Me.BuildersBindingNavigator)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBuilder)
        Me.Name = "frmTinyHouse"
        Me.Text = "Tiny House Builders by Dave Minkowski"
        CType(Me.picBuilder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TinyHousesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BuildersBindingNavigator.ResumeLayout(False)
        Me.BuildersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBuilder As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents TinyHousesDataSet As TinyHousesDataSet
    Friend WithEvents BuildersBindingSource As BindingSource
    Friend WithEvents BuildersTableAdapter As TinyHousesDataSetTableAdapters.BuildersTableAdapter
    Friend WithEvents TableAdapterManager As TinyHousesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BuildersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BuildersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Builder_IDTextBox As TextBox
    Friend WithEvents BuilderTextBox As TextBox
    Friend WithEvents Tiny_House_SpecialityTextBox As TextBox
    Friend WithEvents Email_AddressTextBox As TextBox
    Friend WithEvents chkBuildsOnSite As CheckBox
End Class
