Imports System.Data.SqlClient

Public Class employee_edit_menu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        employee_choice_process_return.Show()
    End Sub

    Public Shared words As New List(Of String)

    Dim isBranch = 0
    Dim isCustomer = 0
    Dim iscarType = 0
    Dim isCar = 0


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        words.Clear()

        Dim s As String

        Dim index As Integer = 0
        While index < 100
            Try
                s = DataGridView1.Item(index, i).Value.ToString
                words.Add(s)
                index = index + 1
            Catch ex As Exception
                index = 100
            End Try
        End While



        If (isBranch = 1) Then
            branch_INFO.Show()
        End If

        If (isCustomer = 1) Then

        End If

        If (iscarType = 1) Then

        End If

        If (isCar = 1) Then

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'branch click
        isBranch = 1
        isCustomer = 0
        iscarType = 0
        isCar = 0
        Try
            Dim connection As New SqlConnection(GlobalVariables.serverString) ' CHANGE DATA SOURCE
            Dim searchQuery As String = "SELECT * From [Project291].dbo.Branch"

            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.MultiSelect = False
        Catch ex As Exception
            MessageBox.Show("nope")
        End Try



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'cars click
        isBranch = 0
        isCustomer = 0
        iscarType = 0
        isCar = 1
        Try
            Dim connection As New SqlConnection(GlobalVariables.serverString) ' CHANGE DATA SOURCE
            Dim searchQuery As String = "SELECT * From [Project291].dbo.Car"

            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.MultiSelect = False
        Catch ex As Exception
            MessageBox.Show("nope")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'car types click
        isBranch = 0
        isCustomer = 0
        iscarType = 1
        isCar = 0
        Try
            Dim connection As New SqlConnection(GlobalVariables.serverString) ' CHANGE DATA SOURCE
            Dim searchQuery As String = "SELECT * From [Project291].dbo.CarType"

            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.MultiSelect = False
        Catch ex As Exception
            MessageBox.Show("nope")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'customers click
        isBranch = 0
        isCustomer = 1
        iscarType = 0
        isCar = 0
        Try
            Dim connection As New SqlConnection(GlobalVariables.serverString) ' CHANGE DATA SOURCE
            Dim searchQuery As String = "SELECT * From [Project291].dbo.Customer"

            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.MultiSelect = False
        Catch ex As Exception
            MessageBox.Show("nope")
        End Try
    End Sub
End Class