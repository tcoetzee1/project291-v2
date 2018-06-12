Imports System.Data.SqlClient

Public Class new_customer_booking
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        customer_view.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub new_customer_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = customer_view.words(0)
        ComboBox1.Items.Add("Day")
        ComboBox1.Items.Add("Week")
        ComboBox1.Items.Add("Month")
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = " "
    End Sub


    Private Sub make_booking()
        If (newID = 0) Then

        Else
            Dim selectedDuration = 0
            Dim CID = newID
            Dim myDate = ""

            If (ComboBox1.Text = Nothing) Then
                MessageBox.Show("Please select a duration that you would like to rent for...")
            Else
                If (ComboBox1.Text = "Day") Then
                    selectedDuration = 1
                End If
                If (ComboBox1.Text = "Week") Then
                    selectedDuration = 2
                End If
                If (ComboBox1.Text = "Month") Then
                    selectedDuration = 3
                End If
            End If



            If DateTimePicker1.CustomFormat = " " Then
                MessageBox.Show("Please select a date...")
            Else
                myDate = DateTimePicker1.Value.Date.ToShortDateString()
            End If

            Dim connStr = GlobalVariables.serverString ' CHANGE DATA SOURCE

            Using con = New SqlConnection(connStr)

                Dim sql = "INSERT INTO [Project291].dbo.RentalHistory (CID, from_BID, scheduled_pickup_date, rental_duration, scheduled_return_date, VID, date_booking_made)" &
                          "VALUES (@CID, @from_BID, @scheduled_pickup_date, @rental_duration, @scheduled_return_date, @VID, @date_booking_made)"
                Using cmd As New SqlClient.SqlCommand(sql, con)





                    cmd.Parameters.AddWithValue("@CID", CID)



                    cmd.Parameters.AddWithValue("@from_BID", customer_view.current_selected_index + 1)



                    If (selectedDuration = 1) Then
                        cmd.Parameters.AddWithValue("@scheduled_pickup_date", DateTimePicker1.Value.AddDays(1).ToShortDateString)
                    End If
                    If (selectedDuration = 2) Then
                        cmd.Parameters.AddWithValue("@scheduled_pickup_date", DateTimePicker1.Value.AddDays(7).ToShortDateString)
                    End If
                    If (selectedDuration = 3) Then
                        cmd.Parameters.AddWithValue("@scheduled_pickup_date", DateTimePicker1.Value.AddMonths(1).ToShortDateString)
                    End If






                    If (selectedDuration = 1) Then
                        cmd.Parameters.AddWithValue("@rental_duration", "day")
                    End If
                    If (selectedDuration = 2) Then
                        cmd.Parameters.AddWithValue("@rental_duration", "week")
                    End If
                    If (selectedDuration = 3) Then
                        cmd.Parameters.AddWithValue("@rental_duration", "month")
                    End If





                    cmd.Parameters.AddWithValue("@scheduled_return_date", "") 'week from myDate, or month, or day



                    cmd.Parameters.AddWithValue("@VID", customer_view.words(0))



                    Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
                    cmd.Parameters.AddWithValue("@date_booking_made", todaysdate) 'current date



                    con.Open()




                    If cmd.ExecuteNonQuery = 0 Then
                        MessageBox.Show("Record insertion NOT successful!")
                    Else
                        MessageBox.Show("Record insertion successful!")
                    End If

                    con.Close()

                    Me.Close()

                End Using
            End Using
        End If
    End Sub

    Dim newID = 0

    Private Sub make_customer()
        Dim connStr = GlobalVariables.serverString ' CHANGE DATA SOURCE

        Using con = New SqlConnection(connStr)

            Dim sql = "INSERT INTO [Project291].dbo.Customer (FName, LName, City, Street, Postal_Code, Credit_Card, phone_number, email, Goldstar)" &
                      "VALUES (@FName, @LName, @City, @Street, @Postal_Code, @Credit_Card, @phone_number ,@email, @Goldstar); SELECT SCOPE_IDENTITY()"
            Using cmd As New SqlClient.SqlCommand(sql, con)


                If (TextBox1.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@FName", TextBox1.Text)
                End If


                If (TextBox2.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@LName", TextBox2.Text)
                End If


                If (TextBox3.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@City", TextBox3.Text)

                End If


                If (TextBox4.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@Street", TextBox4.Text)
                End If


                If (TextBox5.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@Postal_Code", TextBox5.Text)

                End If



                If (TextBox6.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@Credit_Card", TextBox6.Text)

                End If



                If (TextBox6.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@phone_number", TextBox7.Text)

                End If

                If (TextBox6.Text.Length > 0) Then
                    cmd.Parameters.AddWithValue("@email", TextBox8.Text)

                End If

                cmd.Parameters.AddWithValue("@Goldstar", "0")



                con.Open()

                Try
                    newID = Convert.ToInt32(cmd.ExecuteScalar())
                    MessageBox.Show(newID)
                    con.Close()
                    make_booking()
                Catch ex As Exception
                    MessageBox.Show("Failed")
                    con.Close()
                End Try



            End Using
        End Using
        ' -----------------------------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        make_customer()
    End Sub
End Class