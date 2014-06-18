<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Dim User_idLabel As System.Windows.Forms.Label
        Dim User_type_codeLabel As System.Windows.Forms.Label
        Dim User_first_nameLabel As System.Windows.Forms.Label
        Dim User_last_nameLabel As System.Windows.Forms.Label
        Dim User_phoneLabel As System.Windows.Forms.Label
        Dim User_emailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Other_user_detailsLabel As System.Windows.Forms.Label
        Me.Help_DeskDataSet = New TSFThelpDesk.Help_DeskDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New TSFThelpDesk.Help_DeskDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New TSFThelpDesk.Help_DeskDataSetTableAdapters.TableAdapterManager()
        Me.UsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.UsersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.User_idTextBox = New System.Windows.Forms.TextBox()
        Me.User_first_nameTextBox = New System.Windows.Forms.TextBox()
        Me.User_last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.User_phoneTextBox = New System.Windows.Forms.TextBox()
        Me.User_emailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Other_user_detailsTextBox = New System.Windows.Forms.TextBox()
        Me.User_type_codeTextBox = New System.Windows.Forms.TextBox()
        User_idLabel = New System.Windows.Forms.Label()
        User_type_codeLabel = New System.Windows.Forms.Label()
        User_first_nameLabel = New System.Windows.Forms.Label()
        User_last_nameLabel = New System.Windows.Forms.Label()
        User_phoneLabel = New System.Windows.Forms.Label()
        User_emailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Other_user_detailsLabel = New System.Windows.Forms.Label()
        CType(Me.Help_DeskDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Help_DeskDataSet
        '
        Me.Help_DeskDataSet.DataSetName = "Help_DeskDataSet"
        Me.Help_DeskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.Help_DeskDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EquipmentTableAdapter = Nothing
        Me.TableAdapterManager.Problem_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.ProblemsTableAdapter = Nothing
        Me.TableAdapterManager.Ref_Equipment_TypesTableAdapter = Nothing
        Me.TableAdapterManager.Ref_Priority_LevelsTableAdapter = Nothing
        Me.TableAdapterManager.Ref_Problem_Status_CodesTableAdapter = Nothing
        Me.TableAdapterManager.Ref_Skill_CodesTableAdapter = Nothing
        Me.TableAdapterManager.Ref_User_TypesTableAdapter = Nothing
        Me.TableAdapterManager.ResolutionsTableAdapter = Nothing
        Me.TableAdapterManager.Staff_SkillsTableAdapter = Nothing
        Me.TableAdapterManager.Support_StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TSFThelpDesk.Help_DeskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'UsersBindingNavigator
        '
        Me.UsersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsersBindingNavigator.BindingSource = Me.UsersBindingSource
        Me.UsersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsersBindingNavigatorSaveItem})
        Me.UsersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsersBindingNavigator.Name = "UsersBindingNavigator"
        Me.UsersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(613, 25)
        Me.UsersBindingNavigator.TabIndex = 0
        Me.UsersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'UsersBindingNavigatorSaveItem
        '
        Me.UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersBindingNavigatorSaveItem.Name = "UsersBindingNavigatorSaveItem"
        Me.UsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsersBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'User_idLabel
        '
        User_idLabel.AutoSize = True
        User_idLabel.Location = New System.Drawing.Point(38, 58)
        User_idLabel.Name = "User_idLabel"
        User_idLabel.Size = New System.Drawing.Size(41, 13)
        User_idLabel.TabIndex = 1
        User_idLabel.Text = "user id:"
        '
        'User_idTextBox
        '
        Me.User_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "user_id", True))
        Me.User_idTextBox.Location = New System.Drawing.Point(134, 55)
        Me.User_idTextBox.Name = "User_idTextBox"
        Me.User_idTextBox.Size = New System.Drawing.Size(425, 20)
        Me.User_idTextBox.TabIndex = 2
        '
        'User_type_codeLabel
        '
        User_type_codeLabel.AutoSize = True
        User_type_codeLabel.Location = New System.Drawing.Point(38, 84)
        User_type_codeLabel.Name = "User_type_codeLabel"
        User_type_codeLabel.Size = New System.Drawing.Size(80, 13)
        User_type_codeLabel.TabIndex = 3
        User_type_codeLabel.Text = "user type code:"
        '
        'User_first_nameLabel
        '
        User_first_nameLabel.AutoSize = True
        User_first_nameLabel.Location = New System.Drawing.Point(38, 110)
        User_first_nameLabel.Name = "User_first_nameLabel"
        User_first_nameLabel.Size = New System.Drawing.Size(78, 13)
        User_first_nameLabel.TabIndex = 5
        User_first_nameLabel.Text = "user first name:"
        '
        'User_first_nameTextBox
        '
        Me.User_first_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "user_first_name", True))
        Me.User_first_nameTextBox.Location = New System.Drawing.Point(134, 107)
        Me.User_first_nameTextBox.Name = "User_first_nameTextBox"
        Me.User_first_nameTextBox.Size = New System.Drawing.Size(425, 20)
        Me.User_first_nameTextBox.TabIndex = 6
        '
        'User_last_nameLabel
        '
        User_last_nameLabel.AutoSize = True
        User_last_nameLabel.Location = New System.Drawing.Point(38, 136)
        User_last_nameLabel.Name = "User_last_nameLabel"
        User_last_nameLabel.Size = New System.Drawing.Size(78, 13)
        User_last_nameLabel.TabIndex = 7
        User_last_nameLabel.Text = "user last name:"
        '
        'User_last_nameTextBox
        '
        Me.User_last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "user_last_name", True))
        Me.User_last_nameTextBox.Location = New System.Drawing.Point(134, 133)
        Me.User_last_nameTextBox.Name = "User_last_nameTextBox"
        Me.User_last_nameTextBox.Size = New System.Drawing.Size(425, 20)
        Me.User_last_nameTextBox.TabIndex = 8
        '
        'User_phoneLabel
        '
        User_phoneLabel.AutoSize = True
        User_phoneLabel.Location = New System.Drawing.Point(38, 162)
        User_phoneLabel.Name = "User_phoneLabel"
        User_phoneLabel.Size = New System.Drawing.Size(63, 13)
        User_phoneLabel.TabIndex = 9
        User_phoneLabel.Text = "user phone:"
        '
        'User_phoneTextBox
        '
        Me.User_phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "user_phone", True))
        Me.User_phoneTextBox.Location = New System.Drawing.Point(134, 159)
        Me.User_phoneTextBox.Name = "User_phoneTextBox"
        Me.User_phoneTextBox.Size = New System.Drawing.Size(425, 20)
        Me.User_phoneTextBox.TabIndex = 10
        '
        'User_emailLabel
        '
        User_emailLabel.AutoSize = True
        User_emailLabel.Location = New System.Drawing.Point(38, 188)
        User_emailLabel.Name = "User_emailLabel"
        User_emailLabel.Size = New System.Drawing.Size(57, 13)
        User_emailLabel.TabIndex = 11
        User_emailLabel.Text = "user email:"
        '
        'User_emailTextBox
        '
        Me.User_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "user_email", True))
        Me.User_emailTextBox.Location = New System.Drawing.Point(134, 185)
        Me.User_emailTextBox.Name = "User_emailTextBox"
        Me.User_emailTextBox.Size = New System.Drawing.Size(425, 20)
        Me.User_emailTextBox.TabIndex = 12
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(38, 214)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(47, 13)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(134, 211)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(425, 20)
        Me.AddressTextBox.TabIndex = 14
        '
        'Other_user_detailsLabel
        '
        Other_user_detailsLabel.AutoSize = True
        Other_user_detailsLabel.Location = New System.Drawing.Point(38, 240)
        Other_user_detailsLabel.Name = "Other_user_detailsLabel"
        Other_user_detailsLabel.Size = New System.Drawing.Size(90, 13)
        Other_user_detailsLabel.TabIndex = 15
        Other_user_detailsLabel.Text = "other user details:"
        '
        'Other_user_detailsTextBox
        '
        Me.Other_user_detailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "other_user_details", True))
        Me.Other_user_detailsTextBox.Location = New System.Drawing.Point(134, 237)
        Me.Other_user_detailsTextBox.Name = "Other_user_detailsTextBox"
        Me.Other_user_detailsTextBox.Size = New System.Drawing.Size(425, 20)
        Me.Other_user_detailsTextBox.TabIndex = 16
        '
        'User_type_codeTextBox
        '
        Me.User_type_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "user_type_code", True))
        Me.User_type_codeTextBox.Location = New System.Drawing.Point(134, 81)
        Me.User_type_codeTextBox.Name = "User_type_codeTextBox"
        Me.User_type_codeTextBox.Size = New System.Drawing.Size(425, 20)
        Me.User_type_codeTextBox.TabIndex = 4
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 338)
        Me.Controls.Add(User_idLabel)
        Me.Controls.Add(Me.User_idTextBox)
        Me.Controls.Add(User_type_codeLabel)
        Me.Controls.Add(Me.User_type_codeTextBox)
        Me.Controls.Add(User_first_nameLabel)
        Me.Controls.Add(Me.User_first_nameTextBox)
        Me.Controls.Add(User_last_nameLabel)
        Me.Controls.Add(Me.User_last_nameTextBox)
        Me.Controls.Add(User_phoneLabel)
        Me.Controls.Add(Me.User_phoneTextBox)
        Me.Controls.Add(User_emailLabel)
        Me.Controls.Add(Me.User_emailTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Other_user_detailsLabel)
        Me.Controls.Add(Me.Other_user_detailsTextBox)
        Me.Controls.Add(Me.UsersBindingNavigator)
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        CType(Me.Help_DeskDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Help_DeskDataSet As TSFThelpDesk.Help_DeskDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As TSFThelpDesk.Help_DeskDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As TSFThelpDesk.Help_DeskDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UsersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents User_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_first_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_last_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_phoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Other_user_detailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_type_codeTextBox As System.Windows.Forms.TextBox
End Class
