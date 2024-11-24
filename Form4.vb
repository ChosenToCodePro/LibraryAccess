Imports MySql.Data.MySqlClient

Public Class Form4
    Dim _c As MySqlConnection,
        _cmd As MySqlCommand,
        _q As String,
        _c2 As New Form2
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If PurposeBase.Text = "Adding a New Book" Then
            _c = New MySqlConnection()
            _c.ConnectionString = $"server=127.0.0.1;userid={Username};password={Password};database={Database}"
            Try
                _c.Open()
                _q = $"INSERT INTO {Database}.books (BookID, Title, Author, Publisher, YearPublished, Genre, Category) VALUES (@bid, @title, @author, @publisher, @date, @genre, @category)"
                _cmd = New MySqlCommand(_q, _c)

                _cmd.Parameters.AddWithValue("@bid", BookIDInfo.Text)
                _cmd.Parameters.AddWithValue("@title", RichTitle.Text)
                _cmd.Parameters.AddWithValue("@author", AuthorInfo.Text)
                _cmd.Parameters.AddWithValue("@publisher", PublisherInfo.Text)
                _cmd.Parameters.AddWithValue("@date", DateInfo.Text)
                _cmd.Parameters.AddWithValue("@genre", GenreInfo.Text)
                _cmd.Parameters.AddWithValue("@category", CategoryInfo.Text)

                _cmd.ExecuteNonQuery()
                MessageBox.Show("Data is Added to the Database.")
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("Something went wrong on Our Side. Sorry :( " & ex.Message)
            End Try
        ElseIf PurposeBase.Text = "Editing Book Information" Then
            _c = New MySqlConnection()
            _c.ConnectionString = $"server=127.0.0.1;userid={Username};password={Password};database={Database}"
            Try
                _c.Open()
                _q = $"UPDATE {Database}.books SET BookID = @bid, Title = @title, Author = @author, Publisher =@publisher , YearPublished = @date, Genre =@genre , Category = @category WHERE BookID = @bid"
                _cmd = New MySqlCommand(_q, _c)

                _cmd.Parameters.AddWithValue("@bid", BookIDInfo.Text)
                _cmd.Parameters.AddWithValue("@title", RichTitle.Text)
                _cmd.Parameters.AddWithValue("@author", AuthorInfo.Text)
                _cmd.Parameters.AddWithValue("@publisher", PublisherInfo.Text)
                _cmd.Parameters.AddWithValue("@date", DateInfo.Text)
                _cmd.Parameters.AddWithValue("@genre", GenreInfo.Text)
                _cmd.Parameters.AddWithValue("@category", CategoryInfo.Text)

                _cmd.ExecuteNonQuery()
                MessageBox.Show("Data is Edited Successfully.")
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("Something went wrong on Our Side. Sorry :( " & ex.Message)
            End Try
        End If
    End Sub
End Class