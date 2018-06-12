Public Class branch_INFO
    Private Sub branch_INFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BID = employee_edit_menu.words.Item(0)
        Dim location = employee_edit_menu.words.Item(1)

        TextBox1.Text = BID
        TextBox2.Text = location
    End Sub
End Class