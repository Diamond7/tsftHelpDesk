<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoEquipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TipoEquipo))
        Me.Help_DeskDataSet = New TSFThelpDesk.Help_DeskDataSet()
        Me.Ref_Equipment_TypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ref_Equipment_TypesTableAdapter = New TSFThelpDesk.Help_DeskDataSetTableAdapters.Ref_Equipment_TypesTableAdapter()
        Me.TableAdapterManager = New TSFThelpDesk.Help_DeskDataSetTableAdapters.TableAdapterManager()
        Me.Ref_Equipment_TypesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Ref_Equipment_TypesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Ref_Equipment_TypesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Help_DeskDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ref_Equipment_TypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ref_Equipment_TypesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ref_Equipment_TypesBindingNavigator.SuspendLayout()
        CType(Me.Ref_Equipment_TypesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Help_DeskDataSet
        '
        Me.Help_DeskDataSet.DataSetName = "Help_DeskDataSet"
        Me.Help_DeskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ref_Equipment_TypesBindingSource
        '
        Me.Ref_Equipment_TypesBindingSource.DataMember = "Ref_Equipment_Types"
        Me.Ref_Equipment_TypesBindingSource.DataSource = Me.Help_DeskDataSet
        '
        'Ref_Equipment_TypesTableAdapter
        '
        Me.Ref_Equipment_TypesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EquipmentTableAdapter = Nothing
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
        'Ref_Equipment_TypesBindingNavigator
        '
        Me.Ref_Equipment_TypesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Ref_Equipment_TypesBindingNavigator.BindingSource = Me.Ref_Equipment_TypesBindingSource
        Me.Ref_Equipment_TypesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Ref_Equipment_TypesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Ref_Equipment_TypesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Ref_Equipment_TypesBindingNavigatorSaveItem})
        Me.Ref_Equipment_TypesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Ref_Equipment_TypesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Ref_Equipment_TypesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Ref_Equipment_TypesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Ref_Equipment_TypesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Ref_Equipment_TypesBindingNavigator.Name = "Ref_Equipment_TypesBindingNavigator"
        Me.Ref_Equipment_TypesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Ref_Equipment_TypesBindingNavigator.Size = New System.Drawing.Size(576, 25)
        Me.Ref_Equipment_TypesBindingNavigator.TabIndex = 0
        Me.Ref_Equipment_TypesBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Ref_Equipment_TypesBindingNavigatorSaveItem
        '
        Me.Ref_Equipment_TypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ref_Equipment_TypesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Ref_Equipment_TypesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Ref_Equipment_TypesBindingNavigatorSaveItem.Name = "Ref_Equipment_TypesBindingNavigatorSaveItem"
        Me.Ref_Equipment_TypesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Ref_Equipment_TypesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Ref_Equipment_TypesDataGridView
        '
        Me.Ref_Equipment_TypesDataGridView.AutoGenerateColumns = False
        Me.Ref_Equipment_TypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ref_Equipment_TypesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Ref_Equipment_TypesDataGridView.DataSource = Me.Ref_Equipment_TypesBindingSource
        Me.Ref_Equipment_TypesDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Ref_Equipment_TypesDataGridView.Name = "Ref_Equipment_TypesDataGridView"
        Me.Ref_Equipment_TypesDataGridView.Size = New System.Drawing.Size(552, 220)
        Me.Ref_Equipment_TypesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "equipment_type_code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "equipment_type_code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "equipment_type_description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "equipment_type_description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 500
        '
        'TipoEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 260)
        Me.Controls.Add(Me.Ref_Equipment_TypesDataGridView)
        Me.Controls.Add(Me.Ref_Equipment_TypesBindingNavigator)
        Me.Name = "TipoEquipo"
        Me.Text = "TipoEquipo"
        CType(Me.Help_DeskDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ref_Equipment_TypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ref_Equipment_TypesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ref_Equipment_TypesBindingNavigator.ResumeLayout(False)
        Me.Ref_Equipment_TypesBindingNavigator.PerformLayout()
        CType(Me.Ref_Equipment_TypesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Help_DeskDataSet As TSFThelpDesk.Help_DeskDataSet
    Friend WithEvents Ref_Equipment_TypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ref_Equipment_TypesTableAdapter As TSFThelpDesk.Help_DeskDataSetTableAdapters.Ref_Equipment_TypesTableAdapter
    Friend WithEvents TableAdapterManager As TSFThelpDesk.Help_DeskDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Ref_Equipment_TypesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Ref_Equipment_TypesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Ref_Equipment_TypesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
