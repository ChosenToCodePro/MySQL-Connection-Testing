Imports MySql.Data.MySqlClient

Public Class Form2
    Dim c As MySqlConnection,
        comd As MySqlCommand,
        q As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
        Form1.LogIn.Enabled = False
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        c = New MySqlConnection()
        c.ConnectionString = $"server=127.0.0.1;userid={[Mod].Username};password={[Mod].Password};database={[Mod].Database}"
        Dim eid = TB_EID.Text,
            nm = TB_Name.Text,
            sn = TB_Surname.Text,
            ag = TB_Age.Text,
            result = MessageBox.Show("Text in the field will be added to the database. Are you Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            Try
                c.Open()
                q = "INSERT INTO e_data.users (EID, Name, Surname, Age) VALUES (@eid,@nm,@sn,@ag)"
                comd = New MySqlCommand(q, c)

                comd.Parameters.AddWithValue("@eid", eid)
                comd.Parameters.AddWithValue("@nm", nm)
                comd.Parameters.AddWithValue("@sn", sn)
                comd.Parameters.AddWithValue("@ag", ag)

                comd.ExecuteNonQuery()
                MessageBox.Show("Data Saved!")
                c.Close()
                RefreshListBox()
            Catch ex As Exception
                MessageBox.Show("Something went wrong on Our Side. Sorry :(" & ex.Message)
            End Try
        Else
            c.Close()
        End If

    End Sub
    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        c = New MySqlConnection()
        c.ConnectionString = $"server=127.0.0.1;userid={[Mod].Username};password={[Mod].Password};database={[Mod].Database}"
        Dim eid = TB_EID.Text,
            nm = TB_Name.Text,
            sn = TB_Surname.Text,
            ag = TB_Age.Text,
            result = MessageBox.Show("Text in the Box will override the existing data. Are you Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            Try
                c.Open()
                q = $"UPDATE e_data.users  set EID=@eid, Name=@nm, Surname=@sn, Age=@ag WHERE EID=@eid "
                comd = New MySqlCommand(q, c)

                comd.Parameters.AddWithValue("@eid", eid)
                comd.Parameters.AddWithValue("@nm", nm)
                comd.Parameters.AddWithValue("@sn", sn)
                comd.Parameters.AddWithValue("@ag", ag)

                comd.ExecuteNonQuery()
                MessageBox.Show("Data Edited!")
                c.Close()
                RefreshListBox()
            Catch ex As Exception
                MessageBox.Show("Something went wrong on Our Side. Sorry :(" & ex.Message)
            End Try
        Else
            c.Close()
        End If
    End Sub
    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        c = New MySqlConnection()
        c.ConnectionString = $"server=127.0.0.1;userid={[Mod].Username};password={[Mod].Password};database={[Mod].Database}"
        Dim eid = TB_EID.Text,
            result = MessageBox.Show("Deleting the selected existing data. Are you Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If result = DialogResult.OK Then
            Try
                c.Open()
                q = $"DELETE FROM e_data.users  WHERE EID=@eid "
                comd = New MySqlCommand(q, c)
                comd.Parameters.AddWithValue("@eid", eid)
                comd.ExecuteNonQuery()
                MessageBox.Show("Data is Deleted!")
                c.Close()
                RefreshListBox()
            Catch ex As Exception
                MessageBox.Show("Something went wrong on Our Side. Sorry :(" & ex.Message)
            End Try
        Else
            c.Close()
        End If

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshListBox()
    End Sub
    Private Sub RefreshListBox()
        c = New MySqlConnection()
        c.ConnectionString = $"server=127.0.0.1;userid={[Mod].Username};password={[Mod].Password};database={[Mod].Database}"
        Dim rd As MySqlDataReader

        Try
            c.Open()
            q = $"SELECT * FROM {[Mod].Database}.users"
            comd = New MySqlCommand(q, c)
            rd = comd.ExecuteReader
            NameListBox.Items.Clear()
            While rd.Read
                Dim GetNames = rd.GetString("Name")
                NameListDrop.Items.Add(GetNames)
                NameListBox.Items.Add(GetNames)
            End While
            c.Close()
        Catch ex As Exception
            MessageBox.Show("Something went wrong on Our Side. Sorry :( " & ex.Message)
        End Try
    End Sub

    Private Sub NameList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameListDrop.SelectedIndexChanged
        c = New MySqlConnection()
        c.ConnectionString = $"server=127.0.0.1;userid={[Mod].Username};password={[Mod].Password};database={[Mod].Database}"
        Dim rd As MySqlDataReader

        Try
            c.Open()
            q = $"SELECT * FROM {[Mod].Database}.users WHERE Name = '{NameListDrop.Text}' "
            comd = New MySqlCommand(q, c)
            rd = comd.ExecuteReader
            While rd.Read
                TB_EID.Text = rd.GetInt32("EID")
                TB_Name.Text = rd.GetString("Name")
                TB_Surname.Text = rd.GetString("Surname")
                TB_Age.Text = rd.GetInt32("Age")
            End While
            c.Close()
        Catch ex As Exception
            MessageBox.Show("Not sure if that person is Available. :( " & ex.Message)
        End Try
    End Sub

    Private Sub NameListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameListBox.SelectedIndexChanged
        c = New MySqlConnection()
        c.ConnectionString = $"server=127.0.0.1;userid={[Mod].Username};password={[Mod].Password};database={[Mod].Database}"
        Dim rd As MySqlDataReader

        Try
            c.Open()
            q = $"SELECT * FROM {[Mod].Database}.users WHERE Name = '{NameListBox.Text}' "
            comd = New MySqlCommand(q, c)
            rd = comd.ExecuteReader
            While rd.Read
                TB_EID.Text = rd.GetInt32("EID")
                TB_Name.Text = rd.GetString("Name")
                TB_Surname.Text = rd.GetString("Surname")
                TB_Age.Text = rd.GetInt32("Age")
            End While
            c.Close()
        Catch ex As Exception
            MessageBox.Show("Not sure if that person is Available. :( " & ex.Message)
        End Try
    End Sub
End Class