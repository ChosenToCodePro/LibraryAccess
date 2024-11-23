Imports MySql.Data.MySqlClient

Public Class Form2
    Dim _c As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SignOut.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles EndSession.Click
        Application.Exit()
    End Sub

    Private Sub SearchField_Click(sender As Object, e As EventArgs) Handles SearchField.Click
        SearchField.Text = ""
    End Sub

    Private Sub FeaturedBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Connect()

        Try
            _c.Open()
            Dim rd As MySqlDataReader = EQ($"SELECT * FROM {Database}.books WHERE Title = '{BookTitle}' ")
            While rd.Read
                Form3.TitleInfo.Text = rd.GetString("Title")
                Form3.AuthorNameInfo.Text = rd.GetString("Author")
                Form3.PublisherInfo.Text = rd.GetString("Publisher")
                Form3.IDInfo.Text = rd.GetInt32("BookID")
                Form3.YearInfo.Text = rd.GetDateTime("YearPublished")
                Form3.GenreInfo.Text = rd.GetString("Genre")
                Form3.CategoryInfo.Text = rd.GetString("Category")
                Form3.Show()
            End While
            _c.Close()
        Catch ex As Exception
            MessageBox.Show("Not sure if that person is Available. :( " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshListBox()
        Connect()
        Try
            _c.Open()
            Dim rd As MySqlDataReader = EQ($"SELECT * FROM {Database}.books")
            FeatureListView.Items.Clear()
            While rd.Read
                BookTitle = rd.GetString("Title")
                Dim Items As New ListViewItem(rd.GetString("Title"))
                Items.SubItems.Add(rd.GetString("Author"))
                FeatureListView.Items.Add(Items)
            End While
            _c.Close()
        Catch ex As Exception
            MessageBox.Show("Something went wrong on Our Side. Sorry :( " & ex.Message)
        End Try
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshListBox()
    End Sub
    Public Sub Connect()
        _c = New MySqlConnection()
        _c.ConnectionString = $"server=127.0.0.1;userid={Username};password={Password};database={Database}"
    End Sub
    Public Function EQ(_query As String) As MySqlDataReader
        Dim comd As New MySqlCommand(_query, _c)
        Return comd.ExecuteReader()
    End Function
End Class