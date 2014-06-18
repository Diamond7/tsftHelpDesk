Public Class Usuario

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Help_DeskDataSet)

    End Sub

    Private Sub Usuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Help_DeskDataSet.Users' Puede moverla o quitarla según sea necesario.
        Me.UsersTableAdapter.Fill(Me.Help_DeskDataSet.Users)

    End Sub

    Private Sub User_type_codeTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles User_type_codeTextBox.TextChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        User_type_codeTextBox.Text = "Admin"
        User_type_codeTextBox.Refresh()

    End Sub
End Class