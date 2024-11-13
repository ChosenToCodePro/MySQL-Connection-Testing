Imports MySql.Data.MySqlClient

Public Class Form1
    Dim c As MySqlConnection, count = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = New MySqlConnection
        Dim usr = username.Text, pswd = password.Text
        c.ConnectionString = $"server=127.0.0.1;userid={usr};password={pswd}"

        Try
            c.Open()
            MessageBox.Show("Wow thats a success UwU, Also Chosef Henlo :P", "Testing was Successful")
            c.Close()
            Button2.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
            c.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Enabled Then
            Form2.Show()
        End If
    End Sub
End Class
