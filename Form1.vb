Imports MySql.Data.MySqlClient
Public Class Form1
    Dim c As MySqlConnection, count = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = New MySqlConnection
        [Mods].Username = tbx_Username.Text
        [Mods].Password = tbx_Password.Text
        [Mods].Database = "lib_data"
        c.ConnectionString = $"server=127.0.0.1;userid={Username};password={Password};database={Database}"

        Try
            c.Open()
            c.Dispose()
            Form2.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Well that was unexpected. Try again, perhaps? " & ex.Message)
        End Try
    End Sub
End Class