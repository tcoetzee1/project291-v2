Imports System.Data.SqlClient
Public Class employee_edit_menu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        employee_choice_process_return.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' ---------------------------------------------------------------------------------------------
        ' Fills table with data from SQL query
        ' ---------------------------------------------------------------------------------------------
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
        ' ---------------------------------------------------------------------------------------------
    End Sub

    Private Sub DataGridView1_CelldbClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ---------------------------------------------------------------------------------------------
        ' Fills table with data from SQL query
        ' ---------------------------------------------------------------------------------------------
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
        ' ---------------------------------------------------------------------------------------------
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' ---------------------------------------------------------------------------------------------
        ' Fills table with data from SQL query
        ' ---------------------------------------------------------------------------------------------
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
        ' ---------------------------------------------------------------------------------------------
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' ---------------------------------------------------------------------------------------------
        ' Fills table with data from SQL query
        ' ---------------------------------------------------------------------------------------------
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
        ' ---------------------------------------------------------------------------------------------
    End Sub
End Class