
Imports System
Imports System.Data.SqlClient

Public Class Form1

    Dim mySqlConnection As SqlConnection = New SqlConnection("server=localhost;database=Help_desk;uid=dari")


    Private Sub ProblemsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ProblemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Help_DeskDataSet)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'cerrar database
        mySqlConnection.Close()



    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Help_DeskDataSet.Users' Puede moverla o quitarla según sea necesario.
        Me.UsersTableAdapter.Fill(Me.Help_DeskDataSet.Users)
        'TODO: esta línea de código carga datos en la tabla 'Help_DeskDataSet.Equipment' Puede moverla o quitarla según sea necesario.
        Me.EquipmentTableAdapter.Fill(Me.Help_DeskDataSet.Equipment)
        'TODO: esta línea de código carga datos en la tabla 'Help_DeskDataSet.Problems' Puede moverla o quitarla según sea necesario.
        Me.ProblemsTableAdapter.Fill(Me.Help_DeskDataSet.Problems)
        'TODO: esta línea de código carga datos en la tabla 'Help_DeskDataSet.Problems' Puede moverla o quitarla según sea necesario.
        Me.ProblemsTableAdapter.Fill(Me.Help_DeskDataSet.Problems)





    End Sub

    Private Sub ProblemsBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ProblemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProblemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Help_DeskDataSet)

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim user As New Usuario
        user.Show()

    End Sub

    Private Sub EquiposToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EquiposToolStripMenuItem.Click
        Dim equip As New Equipos
        equip.Show()

    End Sub

    Private Sub TipoEquipoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TipoEquipoToolStripMenuItem.Click
        Dim tequip As New TipoEquipo
        tequip.Show()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        

        Dim datos As DataTableReader


        datos = Me.Help_DeskDataSet.Ref_Equipment_Types.CreateDataReader()
        Do
            If Not datos.HasRows Then
                MsgBox("Empty DataTableReader")
            Else
                For i As Integer = 0 To datos.FieldCount - 1
                    MsgBox(datos(i).ToString() & " ")
                Next
            End If

        Loop While datos.NextResult()




    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End

    End Sub

    Private Sub BindingNavigatorAddNewItem_DoubleClick(sender As Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.DoubleClick

    End Sub

    Private Sub ProblemsDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProblemsDataGridView.CellContentClick

    End Sub

    Private Sub ProblemsDataGridView_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProblemsDataGridView.CellEnter


        If Me.ProblemsDataGridView.CurrentCell.ColumnIndex = 3 Then

            'inde = e.RowIndex
            'MsgBox(inde)
            Me.ProblemsDataGridView.CurrentCell.Value = CType(Now, String)
        End If

    End Sub

    Private Sub ProblemsDataGridView_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProblemsDataGridView.RowEnter
        



    End Sub

    Private Sub ProblemsDataGridView_RowsAdded(sender As Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles ProblemsDataGridView.RowsAdded
    


    End Sub
End Class
