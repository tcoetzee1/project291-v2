Public Class first_screen_choice
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        customer_view.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        employee_choice_process_return.Show()
        Me.Hide()
    End Sub
End Class
