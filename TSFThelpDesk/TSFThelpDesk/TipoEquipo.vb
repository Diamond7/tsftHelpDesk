Public Class TipoEquipo

    Private Sub Ref_Equipment_TypesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Ref_Equipment_TypesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Ref_Equipment_TypesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Help_DeskDataSet)

    End Sub

    Private Sub TipoEquipo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Help_DeskDataSet.Ref_Equipment_Types' Puede moverla o quitarla según sea necesario.
        Me.Ref_Equipment_TypesTableAdapter.Fill(Me.Help_DeskDataSet.Ref_Equipment_Types)

    End Sub
End Class