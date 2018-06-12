Public Class pick_dates

    Public Shared haveSelectedDates = 0

    Public Shared startDate As String

    Public Shared endDate As String

    Private Sub pick_dates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = " "

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = " "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        customer_view.Show()
        DateTimePicker1.CustomFormat = " "
        DateTimePicker2.CustomFormat = " "

        startDate = Nothing
        endDate = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        haveSelectedDates = 1

        startDate = DateTimePicker1.Value.Date.ToShortDateString()
        endDate = DateTimePicker2.Value.Date.ToShortDateString()

        Me.Hide()

        customer_view.Show()
        customer_view.Update_myTable()

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
    End Sub

End Class