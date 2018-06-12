Imports System.Data.SqlClient

Public Class customer_view
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

        first_screen_choice.Show()

    End Sub

    Public Shared current_selected_index

    Private Sub customer_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim connString As String = GlobalVariables.serverString
        Dim myConn As New SqlConnection(connString)
        myConn.Open()

        Dim query As String = "SELECT * From [Project291].dbo.Branch"
        Dim da As New SqlDataAdapter(query, myConn)
        Dim dt As New DataTable

        da.Fill(dt)

        ComboBox1.DisplayMember = "location"
        ComboBox1.ValueMember = "location"

        ComboBox1.DataSource = dt
        myConn.Close()

        Label5.Text = ""
        Label6.Text = ""

    End Sub

    Public Sub Update_myTable()
        If (ComboBox1.Text = Nothing) Then

        Else
            current_selected_index = ComboBox1.SelectedIndex
            Dim connection As New SqlConnection(GlobalVariables.serverString) ' CHANGE DATA SOURCE
            Dim searchQuery As String = "SELECT VID, daily_price, weekly_price, monthly_price, car_type_name From [Project291].dbo.Branch, [Project291].dbo.Car, [Project291].dbo.CarType Where Branch.BID=Car.BID and Car.Type_ID=CarType.Type_ID and Branch.location=" + "'" + ComboBox1.SelectedValue.ToString + "'"


            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.MultiSelect = False

            Dim stringStartDate = pick_dates.startDate

            Dim stringEndDate = pick_dates.endDate

            Label5.Text = stringStartDate
            Label6.Text = stringEndDate
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pick_dates.Show()
    End Sub


    Public Shared words As New List(Of String)
    Public Shared VID

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

        VID = words.Item(0)

        returning_customer_make_booking.Show()

    End Sub

End Class