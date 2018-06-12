Imports System.Data.SqlClient

Public Class pickupProcessInfo
    Dim VID
    Private Sub pickupProcessInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VID = employee_process_pickup.pickupProcess.Item(0)
        MessageBox.Show(VID)
    End Sub

    Private Sub editInfo()
        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim row As Integer
        'Dim str As String
        con = New SqlConnection(GlobalVariables.serverString)
        con.Open()




        cmd = New SqlCommand("UPDATE [Project291].dbo.RentalHistory Set picked_up=@picked_up, EID_process_pickup=@EID_process_pickup WHERE VID=@VID", con)
        cmd.Parameters.AddWithValue("@VID", VID)
        cmd.Parameters.AddWithValue("@picked_up", 1)
        cmd.Parameters.AddWithValue("@EID_process_pickup", TextBox1.Text)


        row = cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        editInfo()
        Me.Close()
        employee_process_pickup.update_table()
    End Sub
End Class