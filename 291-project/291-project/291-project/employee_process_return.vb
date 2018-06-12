Imports System.Data.SqlClient

Public Class employee_process_return
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        employee_choice_process_return.Show()
    End Sub

    Public Sub update_table()
        Dim connection As New SqlConnection(GlobalVariables.serverString) ' CHANGE DATA SOURCE
        Dim searchQuery As String = "SELECT VID, CID From [Project291].dbo.RentalHistory Where RentalHistory.real_return_date IS NULL AND RentalHistory.picked_up=1"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table

        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
    End Sub

    Private Sub employee_process_return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update_table()
    End Sub

    Public Shared returnProcess As New List(Of String)
    Dim VID = 0

    Private Sub DataGridView1_CelldbClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick


        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        returnProcess.Clear()

        Dim s As String

        Dim index As Integer = 0
        While index < 100
            Try
                s = DataGridView1.Item(index, i).Value.ToString

                returnProcess.Add(s)
                index = index + 1
            Catch ex As Exception
                index = 100
            End Try
        End While

        VID = returnProcess.Item(0)

        If VID.Length > 0 Then
            returnInfo.Show()
        End If

    End Sub


End Class