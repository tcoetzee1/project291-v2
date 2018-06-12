Imports System.Data.SqlClient
Public Class returnInfo
    Dim VID
    Private Sub returnInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VID = employee_process_return.returnProcess.Item(0)
        Dim CID = employee_process_return.returnProcess.Item(0)
        Label6.Text = String.Format("{0:yyyy/MM/dd}", DateTime.Now)
        searchForInfo()
    End Sub
    Private Sub searchForInfo()

        Dim dbConn As SqlConnection
        Dim myCommand As SqlCommand
        dbConn = New SqlConnection(GlobalVariables.serverString)
        dbConn.Open()
        myCommand = New SqlCommand("SELECT * FROM [Project291].dbo.RentalHistory WHERE RentalHistory.VID = @VID", dbConn)
        myCommand.Parameters.AddWithValue("@VID", VID)

        Dim myDataReader = myCommand.ExecuteReader()
        If myDataReader.HasRows Then
            While myDataReader.Read()
                Label3.Text = myDataReader("scheduled_return_date")
                Label8.Text = myDataReader("from_BID")
            End While
        End If
        myDataReader.Close()
        dbConn.Close()

    End Sub

    Private Sub editInfo()
        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim row As Integer
        'Dim str As String
        con = New SqlConnection(GlobalVariables.serverString)
        con.Open()

        cmd = New SqlCommand("UPDATE [Project291].dbo.RentalHistory Set delivered_to_BID=@delivered_to_BID, EID_process_return=@EID_process_return, late_fee=@late_fee, real_return_date=@real_return_date WHERE VID=@VID", con)

        cmd.Parameters.AddWithValue("@VID", VID)

        cmd.Parameters.AddWithValue("@delivered_to_BID", TextBox1.Text)
        cmd.Parameters.AddWithValue("@EID_process_return", TextBox2.Text)
        cmd.Parameters.AddWithValue("@late_fee", TextBox3.Text)
        cmd.Parameters.AddWithValue("@real_return_date", String.Format("{0:yyyy/MM/dd}", DateTime.Now))

        row = cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        editInfo()
        Me.Close()
        employee_process_return.update_table()
    End Sub
End Class