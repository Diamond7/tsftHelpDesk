<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipos
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
        Dim Equipment_idLabel As System.Windows.Forms.Label
        Dim Equipment_type_codeLabel As System.Windows.Forms.Label
        Dim Date_equipment_acquiredLabel As System.Windows.Forms.Label
        Dim Date_equipment_disposedLabel As System.Windows.Forms.Label
        Dim Equipment_codeLabel As System.Windows.Forms.Label
        Dim Equipment_nameLabel As System.Windows.Forms.Label
        Dim Equipment_descriptionLabel As System.Windows.Forms.Label
        Dim Manufacturer_nameLabel As System.Windows.Forms.Label
        Dim Other_detailsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Equipos))
        Me.Help_DeskDataSet = New TSFThelpDesk.Help_DeskDataSet()
        Me.EquipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentTableAdapter = New TSFThelpDesk.Help_DeskDataSetTableAdapters.EquipmentTableAdapter()
        Me.TableAdapterManager = New TSFThelpDesk.Help_DeskDataSetTableAdapters.TableAdapterManager()
        Me.Ref_Equipment_TypesTableAdapter = New TSFThelpDesk.Help_DeskDataSetTableAdapters.Ref_Equipment_TypesTableAdapter()
        Me.EquipmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EquipmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Equipment_idTextBox = New System.Windows.Forms.TextBox()
        Me.Date_equipment_acquiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_equipment_disposedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Equipment_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Equipment_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Equipment_descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Other_detailsTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RefEquipmentTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Equipment_idLabel = New System.Windows.Forms.Label()
        Equipment_type_codeLabel = New System.Windows.Forms.Label()
        Date_equipment_acquiredLabel = New System.Windows.Forms.Label()
        Date_equipment_disposedLabel = New System.Windows.Forms.Label()
        Equipment_codeLabel = New System.Windows.Forms.Label()
        Equipment_nameLabel = New System.Windows.Forms.Label()
        Equipment_descriptionLabel = New System.Windows.Forms.Label()
        Manufacturer_nameLabel = New System.Windows.Forms.Label()
        Other_detailsLabel = New System.Windows.Forms.Label()
        CType(Me.Help_DeskDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EquipmentBindingNavigator.SuspendLayout()
        CType(Me.RefEquipmentTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Equipment_idLabel
        '
        Equipment_idLabel.AutoSize = True
        Equipment_idLabel.Location = New System.Drawing.Point(25, 55)
        Equipment_idLabel.Name = "Equipment_idLabel"
        Equipment_idLabel.Size = New System.Drawing.Size(70, 13)
        Equipment_idLabel.TabIndex = 1
        Equipment_idLabel.Text = "equipment id:"
        '
        'Equipment_type_codeLabel
        '
        Equipment_type_codeLabel.AutoSize = True
        Equipment_type_codeLabel.Location = New System.Drawing.Point(25, 81)
        Equipment_type_codeLabel.Name = "Equipment_type_codeLabel"
        Equipment_type_codeLabel.Size = New System.Drawing.Size(109, 13)
        Equipment_type_codeLabel.TabIndex = 3
        Equipment_type_codeLabel.Text = "equipment type code:"
        '
        'Date_equipment_acquiredLabel
        '
        Date_equipment_acquiredLabel.AutoSize = True
        Date_equipment_acquiredLabel.Location = New System.Drawing.Point(25, 108)
        Date_equipment_acquiredLabel.Name = "Date_equipment_acquiredLabel"
        Date_equipment_acquiredLabel.Size = New System.Drawing.Size(127, 13)
        Date_equipment_acquiredLabel.TabIndex = 5
        Date_equipment_acquiredLabel.Text = "date equipment acquired:"
        '
        'Date_equipment_disposedLabel
        '
        Date_equipment_disposedLabel.AutoSize = True
        Date_equipment_disposedLabel.Location = New System.Drawing.Point(25, 134)
        Date_equipment_disposedLabel.Name = "Date_equipment_disposedLabel"
        Date_equipment_disposedLabel.Size = New System.Drawing.Size(128, 13)
        Date_equipment_disposedLabel.TabIndex = 7
        Date_equipment_disposedLabel.Text = "date equipment disposed:"
        '
        'Equipment_codeLabel
        '
        Equipment_codeLabel.AutoSize = True
        Equipment_codeLabel.Location = New System.Drawing.Point(25, 159)
        Equipment_codeLabel.Name = "Equipment_codeLabel"
        Equipment_codeLabel.Size = New System.Drawing.Size(86, 13)
        Equipment_codeLabel.TabIndex = 9
        Equipment_codeLabel.Text = "equipment code:"
        '
        'Equipment_nameLabel
        '
        Equipment_nameLabel.AutoSize = True
        Equipment_nameLabel.Location = New System.Drawing.Point(25, 185)
        Equipment_nameLabel.Name = "Equipment_nameLabel"
        Equipment_nameLabel.Size = New System.Drawing.Size(88, 13)
        Equipment_nameLabel.TabIndex = 11
        Equipment_nameLabel.Text = "equipment name:"
        '
        'Equipment_descriptionLabel
        '
        Equipment_descriptionLabel.AutoSize = True
        Equipment_descriptionLabel.Location = New System.Drawing.Point(25, 211)
        Equipment_descriptionLabel.Name = "Equipment_descriptionLabel"
        Equipment_descriptionLabel.Size = New System.Drawing.Size(113, 13)
        Equipment_descriptionLabel.TabIndex = 13
        Equipment_descriptionLabel.Text = "equipment description:"
        '
        'Manufacturer_nameLabel
        '
        Manufacturer_nameLabel.AutoSize = True
        Manufacturer_nameLabel.Location = New System.Drawing.Point(25, 237)
        Manufacturer_nameLabel.Name = "Manufacturer_nameLabel"
        Manufacturer_nameLabel.Size = New System.Drawing.Size(101, 13)
        Manufacturer_nameLabel.TabIndex = 15
        Manufacturer_nameLabel.Text = "manufacturer name:"
        '
        'Other_detailsLabel
        '
        Other_detailsLabel.AutoSize = True
        Other_detailsLabel.Location = New System.Drawing.Point(25, 263)
        Other_detailsLabel.Name = "Other_detailsLabel"
        Other_detailsLabel.Size = New System.Drawing.Size(67, 13)
        Other_detailsLabel.TabIndex = 17
        Other_detailsLabel.Text = "other details:"
        '
        'Help_DeskDataSet
        '
        Me.Help_DeskDataSet.DataSetName = "Help_DeskDataSet"
        Me.Help_DeskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquipmentBindingSource
        '
        Me.EquipmentBindingSource.DataMember = "Equipment"
        Me.EquipmentBindingSource.DataSource = Me.Help_DeskDataSet
        '
        'EquipmentTableAdapter
        '
        Me.EquipmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EquipmentTableAdapter = Me.EquipmentTableAdapter
        Me.TableAdapterManager.Problem_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.ProblemsTableAdapter = Nothing
        Me.TableAdapterManager.Ref_Equipment_TypesTableAdapter = Me.Ref_Equipment_TypesTableAdapter
        Me.TableAdapterManager.Ref_Priority_LevelsTableAdapter = Nothing
        Me.TableAdapterManager.Ref_Problem_Status_CodesTableAdapter = Nothing
        Me.TableAdapterManager.Ref_Skill_CodesTableAdapter = Nothing
        Me.TableAdapterManager.Ref_User_TypesTableAdapter = Nothing
        Me.TableAdapterManager.ResolutionsTableAdapter = Nothing
        Me.TableAdapterManager.Staff_SkillsTableAdapter = Nothing
        Me.TableAdapterManager.Support_StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TSFThelpDesk.Help_DeskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Ref_Equipment_TypesTableAdapter
        '
        Me.Ref_Equipment_TypesTableAdapter.ClearBeforeFill = True
        '
        'EquipmentBindingNavigator
        '
        Me.EquipmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EquipmentBindingNavigator.BindingSource = Me.EquipmentBindingSource
        Me.EquipmentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EquipmentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EquipmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EquipmentBindingNavigatorSaveItem})
        Me.EquipmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EquipmentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EquipmentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EquipmentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EquipmentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EquipmentBindingNavigator.Name = "EquipmentBindingNavigator"
        Me.EquipmentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EquipmentBindingNavigator.Size = New System.Drawing.Size(668, 25)
        Me.EquipmentBindingNavigator.TabIndex = 0
        Me.EquipmentBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EquipmentBindingNavigatorSaveItem
        '
        Me.EquipmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EquipmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("EquipmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EquipmentBindingNavigatorSaveItem.Name = "EquipmentBindingNavigatorSaveItem"
        Me.EquipmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EquipmentBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Equipment_idTextBox
        '
        Me.Equipment_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "equipment_id", True))
        Me.Equipment_idTextBox.Location = New System.Drawing.Point(159, 52)
        Me.Equipment_idTextBox.Name = "Equipment_idTextBox"
        Me.Equipment_idTextBox.Size = New System.Drawing.Size(466, 20)
        Me.Equipment_idTextBox.TabIndex = 2
        '
        'Date_equipment_acquiredDateTimePicker
        '
        Me.Date_equipment_acquiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EquipmentBindingSource, "date_equipment_acquired", True))
        Me.Date_equipment_acquiredDateTimePicker.Location = New System.Drawing.Point(159, 104)
        Me.Date_equipment_acquiredDateTimePicker.Name = "Date_equipment_acquiredDateTimePicker"
        Me.Date_equipment_acquiredDateTimePicker.Size = New System.Drawing.Size(466, 20)
        Me.Date_equipment_acquiredDateTimePicker.TabIndex = 6
        '
        'Date_equipment_disposedDateTimePicker
        '
        Me.Date_equipment_disposedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EquipmentBindingSource, "date_equipment_disposed", True))
        Me.Date_equipment_disposedDateTimePicker.Location = New System.Drawing.Point(159, 130)
        Me.Date_equipment_disposedDateTimePicker.Name = "Date_equipment_disposedDateTimePicker"
        Me.Date_equipment_disposedDateTimePicker.Size = New System.Drawing.Size(466, 20)
        Me.Date_equipment_disposedDateTimePicker.TabIndex = 8
        '
        'Equipment_codeTextBox
        '
        Me.Equipment_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "equipment_code", True))
        Me.Equipment_codeTextBox.Location = New System.Drawing.Point(159, 156)
        Me.Equipment_codeTextBox.Name = "Equipment_codeTextBox"
        Me.Equipment_codeTextBox.Size = New System.Drawing.Size(466, 20)
        Me.Equipment_codeTextBox.TabIndex = 10
        '
        'Equipment_nameTextBox
        '
        Me.Equipment_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "equipment_name", True))
        Me.Equipment_nameTextBox.Location = New System.Drawing.Point(159, 182)
        Me.Equipment_nameTextBox.Name = "Equipment_nameTextBox"
        Me.Equipment_nameTextBox.Size = New System.Drawing.Size(466, 20)
        Me.Equipment_nameTextBox.TabIndex = 12
        '
        'Equipment_descriptionTextBox
        '
        Me.Equipment_descriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "equipment_description", True))
        Me.Equipment_descriptionTextBox.Location = New System.Drawing.Point(159, 208)
        Me.Equipment_descriptionTextBox.Name = "Equipment_descriptionTextBox"
        Me.Equipment_descriptionTextBox.Size = New System.Drawing.Size(466, 20)
        Me.Equipment_descriptionTextBox.TabIndex = 14
        '
        'Manufacturer_nameTextBox
        '
        Me.Manufacturer_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "manufacturer_name", True))
        Me.Manufacturer_nameTextBox.Location = New System.Drawing.Point(159, 234)
        Me.Manufacturer_nameTextBox.Name = "Manufacturer_nameTextBox"
        Me.Manufacturer_nameTextBox.Size = New System.Drawing.Size(466, 20)
        Me.Manufacturer_nameTextBox.TabIndex = 16
        '
        'Other_detailsTextBox
        '
        Me.Other_detailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentBindingSource, "other_details", True))
        Me.Other_detailsTextBox.Location = New System.Drawing.Point(159, 260)
        Me.Other_detailsTextBox.Name = "Other_detailsTextBox"
        Me.Other_detailsTextBox.Size = New System.Drawing.Size(466, 20)
        Me.Other_detailsTextBox.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EquipmentBindingSource, "equipment_type_code", True))
        Me.ComboBox1.DataSource = Me.RefEquipmentTypesBindingSource
        Me.ComboBox1.DisplayMember = "equipment_type_description"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(159, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(466, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.ValueMember = "equipment_type_code"
        '
        'RefEquipmentTypesBindingSource
        '
        Me.RefEquipmentTypesBindingSource.DataMember = "Ref_Equipment_Types"
        Me.RefEquipmentTypesBindingSource.DataSource = Me.Help_DeskDataSet
        '
        'Equipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 305)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Equipment_idLabel)
        Me.Controls.Add(Me.Equipment_idTextBox)
        Me.Controls.Add(Equipment_type_codeLabel)
        Me.Controls.Add(Date_equipment_acquiredLabel)
        Me.Controls.Add(Me.Date_equipment_acquiredDateTimePicker)
        Me.Controls.Add(Date_equipment_disposedLabel)
        Me.Controls.Add(Me.Date_equipment_disposedDateTimePicker)
        Me.Controls.Add(Equipment_codeLabel)
        Me.Controls.Add(Me.Equipment_codeTextBox)
        Me.Controls.Add(Equipment_nameLabel)
        Me.Controls.Add(Me.Equipment_nameTextBox)
        Me.Controls.Add(Equipment_descriptionLabel)
        Me.Controls.Add(Me.Equipment_descriptionTextBox)
        Me.Controls.Add(Manufacturer_nameLabel)
        Me.Controls.Add(Me.Manufacturer_nameTextBox)
        Me.Controls.Add(Other_detailsLabel)
        Me.Controls.Add(Me.Other_detailsTextBox)
        Me.Controls.Add(Me.EquipmentBindingNavigator)
        Me.Name = "Equipos"
        Me.Text = "Equipos"
        CType(Me.Help_DeskDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EquipmentBindingNavigator.ResumeLayout(False)
        Me.EquipmentBindingNavigator.PerformLayout()
        CType(Me.RefEquipmentTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Help_DeskDataSet As TSFThelpDesk.Help_DeskDataSet
    Friend WithEvents EquipmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EquipmentTableAdapter As TSFThelpDesk.Help_DeskDataSetTableAdapters.EquipmentTableAdapter
    Friend WithEvents TableAdapterManager As TSFThelpDesk.Help_DeskDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EquipmentBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EquipmentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Equipment_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_equipment_acquiredDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_equipment_disposedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Equipment_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Equipment_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Equipment_descriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Manufacturer_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Other_detailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Ref_Equipment_TypesTableAdapter As TSFThelpDesk.Help_DeskDataSetTableAdapters.Ref_Equipment_TypesTableAdapter
    Friend WithEvents RefEquipmentTypesBindingSource As System.Windows.Forms.BindingSource
End Class
