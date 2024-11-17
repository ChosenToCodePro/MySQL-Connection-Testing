Imports MySql.Data.MySqlClient

Public Class Form1
    Dim c As MySqlConnection, count = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConnectionTest.Click
        c = New MySqlConnection
        [Mod].Username = username.Text
        [Mod].Password = password.Text
        [Mod].Database = database.Text
        c.ConnectionString = $"server=127.0.0.1;userid={[Mod].Username};password={[Mod].Password};database={[Mod].Database}"

        Try
            c.Open()
            MessageBox.Show("Wow thats a success UwU, Also Chosef Henlo :P")
            LogIn.Enabled = True
            c.Dispose()
        Catch ex As Exception
            MessageBox.Show("Well that was unexpected. Try again, perhaps? " & ex.Message)
            LogIn.Enabled = False
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        If LogIn.Enabled Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FinishSession_Click(sender As Object, e As EventArgs) Handles FinishSession.Click
        Application.Exit()
    End Sub
End Class
