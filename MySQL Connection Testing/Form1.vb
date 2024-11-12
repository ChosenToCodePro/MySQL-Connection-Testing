Imports MySql.Data.MySqlClient

Public Class Form1
    Dim c As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = New MySqlConnection
        c.ConnectionString = "server=127.0.0.1;userid=ChosenProSQLX;password='#Ndrdaoi13';database=chinookemc"

        Try
            c.Open()
            MessageBox.Show("Wow thats a success UwU", "Testing was Successful")
            c.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            c.Close()
        End Try
    End Sub
End Class
