﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoEquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Help_DeskDataSet = New TSFThelpDesk.Help_DeskDataSet()
        Me.ProblemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProblemsTableAdapter = New TSFThelpDesk.Help_DeskDataSetTableAdapters.ProblemsTableAdapter()
        Me.TableAdapterManager = New TSFThelpDesk.Help_DeskDataSetTableAdapters.TableAdapterManager()
        Me.EquipmentTableAdapter = New TSFThelpDesk.Help_DeskDataSetTableAdapters.EquipmentTableAdapter()
        Me.UsersTableAdapter = New TSFThelpDesk.Help_DeskDataSetTableAdapters.UsersTableAdapter()
        Me.ProblemsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProblemsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProblemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EquipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Help_DeskDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProblemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProblemsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProblemsBindingNavigator.SuspendLayout()
        CType(Me.ProblemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(962, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.EquiposToolStripMenuItem, Me.TipoEquipoToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'EquiposToolStripMenuItem
        '
        Me.EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        Me.EquiposToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EquiposToolStripMenuItem.Text = "Equipos"
        '
        'TipoEquipoToolStripMenuItem
        '
        Me.TipoEquipoToolStripMenuItem.Name = "TipoEquipoToolStripMenuItem"
        Me.TipoEquipoToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.TipoEquipoToolStripMenuItem.Text = "Tipo Equipo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Help_DeskDataSet
        '
        Me.Help_DeskDataSet.DataSetName = "Help_DeskDataSet"
        Me.Help_DeskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProblemsBindingSource
        '
        Me.ProblemsBindingSource.DataMember = "Problems"
        Me.ProblemsBindingSource.DataSource = Me.Help_DeskDataSet
        '
        'ProblemsTableAdapter
        '
        Me.ProblemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EquipmentTableAdapter = Me.EquipmentTableAdapter
        Me.TableAdapterManager.Problem_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.ProblemsTableAdapter = Me.ProblemsTableAdapter
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
        'EquipmentTableAdapter
        '
        Me.EquipmentTableAdapter.ClearBeforeFill = True
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'ProblemsBindingNavigator
        '
        Me.ProblemsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProblemsBindingNavigator.BindingSource = Me.ProblemsBindingSource
        Me.ProblemsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProblemsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProblemsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProblemsBindingNavigatorSaveItem})
        Me.ProblemsBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.ProblemsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProblemsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProblemsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProblemsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProblemsBindingNavigator.Name = "ProblemsBindingNavigator"
        Me.ProblemsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProblemsBindingNavigator.Size = New System.Drawing.Size(962, 25)
        Me.ProblemsBindingNavigator.TabIndex = 12
        Me.ProblemsBindingNavigator.Text = "BindingNavigator1"
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
        'ProblemsBindingNavigatorSaveItem
        '
        Me.ProblemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProblemsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProblemsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProblemsBindingNavigatorSaveItem.Name = "ProblemsBindingNavigatorSaveItem"
        Me.ProblemsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProblemsBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ProblemsDataGridView
        '
        Me.ProblemsDataGridView.AutoGenerateColumns = False
        Me.ProblemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProblemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProblemsDataGridView.DataSource = Me.ProblemsBindingSource
        Me.ProblemsDataGridView.Location = New System.Drawing.Point(12, 52)
        Me.ProblemsDataGridView.Name = "ProblemsDataGridView"
        Me.ProblemsDataGridView.Size = New System.Drawing.Size(941, 220)
        Me.ProblemsDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "problem_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "problem_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "equipment_id"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.EquipmentBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "equipment_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "equipment_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "equipment_id"
        '
        'EquipmentBindingSource
        '
        Me.EquipmentBindingSource.DataMember = "Equipment"
        Me.EquipmentBindingSource.DataSource = Me.Help_DeskDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "user_id"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.UsersBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "user_first_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "user_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "user_id"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.Help_DeskDataSet
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "problem_reported_datetime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "datetime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "problem_description"
        Me.DataGridViewTextBoxColumn5.HeaderText = "problem_description"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 290)
        Me.Controls.Add(Me.ProblemsDataGridView)
        Me.Controls.Add(Me.ProblemsBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "TSFTHelpDesk"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Help_DeskDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProblemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProblemsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProblemsBindingNavigator.ResumeLayout(False)
        Me.ProblemsBindingNavigator.PerformLayout()
        CType(Me.ProblemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Help_DeskDataSet As TSFThelpDesk.Help_DeskDataSet
    Friend WithEvents ProblemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProblemsTableAdapter As TSFThelpDesk.Help_DeskDataSetTableAdapters.ProblemsTableAdapter
    Friend WithEvents TableAdapterManager As TSFThelpDesk.Help_DeskDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProblemsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProblemsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProblemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EquipmentTableAdapter As TSFThelpDesk.Help_DeskDataSetTableAdapters.EquipmentTableAdapter
    Friend WithEvents EquipmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As TSFThelpDesk.Help_DeskDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoEquipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
