Public Class Equipos

    Private Sub EquipmentBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.EquipmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Help_DeskDataSet)

    End Sub

    Private Sub Equipos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Help_DeskDataSet.Ref_Equipment_Types' Puede moverla o quitarla según sea necesario.
        Me.Ref_Equipment_TypesTableAdapter.Fill(Me.Help_DeskDataSet.Ref_Equipment_Types)
        'TODO: esta línea de código carga datos en la tabla 'Help_DeskDataSet.Equipment' Puede moverla o quitarla según sea necesario.
        Me.EquipmentTableAdapter.Fill(Me.Help_DeskDataSet.Equipment)
        'TODO: esta línea de código carga datos en la tabla 'Help_DeskDataSet.Equipment' Puede moverla o quitarla según sea necesario.
        Me.EquipmentTableAdapter.Fill(Me.Help_DeskDataSet.Equipment)

    End Sub

    Private Sub EquipmentBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles EquipmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EquipmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Help_DeskDataSet)

    End Sub

    Private Sub Equipment_type_codeTextBox_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class