Public Class Form3
    Dim c2 As New Form2
    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub EditBookInfo_Click(sender As Object, e As EventArgs) Handles EditBookInfo.Click
        c2.Connect()
        Try
            c2._c.Open()
            Dim rd = c2.EQ($"SELECT * FROM {Database}.books WHERE Title = '{TitleInfo.Text}' ")
            Form4.PurposeBase.Text = "Editing Book Information"
            Form4.Show()
            While rd.Read()
                Form4.RichTitle.Text = rd.GetString("Title")
                Form4.BookIDInfo.Text = rd.GetInt16("BookID")
                Form4.AuthorInfo.Text = rd.GetString("Author")
                Form4.PublisherInfo.Text = rd.GetString("Publisher")
                Form4.DateInfo.Text = rd.GetDateTime("YearPublished").ToString("yyyy-MM-dd")
                Form4.GenreInfo.Text = rd.GetString("Genre")
                Form4.CategoryInfo.Text = rd.GetString("Category")
            End While
            c2._c.Close()
        Catch ex As Exception
            MessageBox.Show("Something went wrong on Our Side. Sorry :( " & ex.Message)
        End Try
    End Sub

End Class