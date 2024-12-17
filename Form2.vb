Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient

Public Class Form2
    Public _c As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SignOut.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles EndSession.Click
        Application.Exit()
    End Sub
    Private Sub FeaturedListView_DoubleClick(sender As Object, e As EventArgs) Handles RecentListView.DoubleClick, ShuffleBox.DoubleClick, AllBooks.DoubleClick, SearchResults.SelectedIndexChanged
        Dim si As ListViewItem = Nothing

        If RecentListView.SelectedItems.Count > 0 Then
            si = RecentListView.SelectedItems(0)
        ElseIf ShuffleBox.SelectedItems.Count > 0 Then
            si = ShuffleBox.SelectedItems(0)
        ElseIf AllBooks.SelectedIndices.Count > 0 Then
            si = AllBooks.SelectedItems(0)
        ElseIf SearchResults.SelectedIndices.Count > 0 Then
            Dim sr As String = SearchResults.SelectedItem.ToString()
            si = New ListViewItem(sr)
            SearchResults.Visible = False
        End If

        Connect()
        Try
            _c.Open()
            Dim rd = EQ($"SELECT * FROM {Database}.books WHERE Title = '{si.Text}' ")
            While rd.Read
                Form3.TitleInfo.Text = rd.GetString("Title")
                Form3.AuthorNameInfo.Text = rd.GetString("Author")
                Form3.PublisherInfo.Text = rd.GetString("Publisher")
                Form3.IDInfo.Text = rd.GetInt32("BookID")
                Form3.YearInfo.Text = rd.GetDateTime("YearPublished")
                Form3.GenreInfo.Text = rd.GetString("Genre")
                Form3.CategoryInfo.Text = rd.GetString("Category")
                Form3.Show()
                Me.Hide()
                SearchResults.Visible = False
                Radios()
            End While
            si = Nothing
            _c.Close()
        Catch ex As Exception
            MessageBox.Show("Not sure if that is Viable. :( " & ex.Message)
        End Try
    End Sub
    Private Sub RecentListView_DoubleClick(sender As Object, e As EventArgs) Handles RecentListView.DoubleClick, RecentListView.Click
        ShuffleBox.SelectedIndices.Clear()
        AllBooks.SelectedIndices.Clear()
        Delete.Enabled = False
    End Sub
    Private Sub ShuffleBox_DoubleClick(sender As Object, e As EventArgs) Handles ShuffleBox.DoubleClick, ShuffleBox.Click
        RecentListView.SelectedIndices.Clear()
        AllBooks.SelectedIndices.Clear()
        Delete.Enabled = False
    End Sub
    Private Sub AllBooks_DoubleClick(sender As Object, e As EventArgs) Handles AllBooks.DoubleClick, AllBooks.Click
        RecentListView.SelectedIndices.Clear()
        ShuffleBox.SelectedIndices.Clear()
    End Sub
    Public Sub RefreshFeatured()
        Connect()
        RecentListView.Items.Clear()
        Try
            _c.Open()
            Dim rd As MySqlDataReader = EQ($"SELECT * FROM {Database}.books WHERE YearPublished BETWEEN '2018-01-01' AND '2024-12-31' LIMIT 5")
            While rd.Read
                BookTitle = rd.GetString("Title")
                Dim Featured As New ListViewItem(rd.GetString("Title"))
                Featured.SubItems.Add(rd.GetString("Author"))
                RecentListView.Items.Add(Featured)
            End While
            rd.Close()
            _c.Close()
        Catch ex As Exception
            MessageBox.Show("Something went wrong on Our Side. Sorry :( " & ex.Message)
        End Try
    End Sub
    Public Sub RefreshShuffleBox()
        Connect()
        Try
            _c.Open()
            ShuffleBox.Items.Clear()
            Dim rd As MySqlDataReader = EQ($"SELECT * FROM {Database}.books LIMIT 10")
            While rd.Read
                BookTitle = rd.GetString("Title")
                Dim Shuffle As New ListViewItem(rd.GetString("Title"))
                Shuffle.SubItems.Add(rd.GetString("Author"))
                ShuffleBox.Items.Add(Shuffle)
            End While
            rd.Close()
            _c.Close()
        Catch ex As Exception
            MessageBox.Show("Something went wrong on Our Side. Sorry :( " & ex.Message)
        End Try
    End Sub
    Public Sub RefreshAllBooks()
        Connect()
        Try
            _c.Open()
            Dim rd As MySqlDataReader = EQ($"SELECT * FROM {Database}.books")
            AllBooks.Items.Clear()
            While rd.Read
                BookTitle = rd.GetString("Title")
                Dim All As New ListViewItem(rd.GetString("Title"))
                All.SubItems.Add(rd.GetString("Author"))
                AllBooks.Items.Add(All)
            End While
            rd.Close()
            _c.Close()
        Catch ex As Exception
            MessageBox.Show("Something went wrong on Our Side. Sorry :( " & ex.Message)
        End Try
    End Sub
    Public Sub Connect()
        _c = New MySqlConnection()
        _c.ConnectionString = $"server=127.0.0.1;userid={Username};password={Password};database={Database}"
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshFeatured()
        RefreshShuffleBox()
        RefreshAllBooks()
        ShuffleListViewItems(ShuffleBox)
    End Sub
    Public Function EQ(_query As String) As MySqlDataReader
        Dim comd As New MySqlCommand(_query, _c)
        Return comd.ExecuteReader()
    End Function
    Public Function Radios()
        If AdminChoice.Checked Then
            Form3.EditBookInfo.Enabled = True
            Form3.DeleteBookInfo.Enabled = True
            Form3.ButtonWarn.Visible = False
        ElseIf UserChoice.Checked Then
            Form3.EditBookInfo.Enabled = False
            Form3.DeleteBookInfo.Enabled = False
            Form3.ButtonWarn.Visible = True
        End If
    End Function

    Private Sub SearchField_TextChanged(sender As Object, e As EventArgs) Handles SearchField.TextChanged
        Dim query = SearchField.Text.ToLower
        SearchResults.Visible = True
        Connect()
        Try
            _c.Open()
            Dim rd = EQ($"SELECT * FROM {Database}.books WHERE LOWER(Title) LIKE '%{query}%' ")
            SearchResults.Items.Clear()
            While rd.Read
                SearchResults.Items.Add(rd.GetString("Title"))
            End While
        Catch ex As Exception
            MessageBox.Show("Something went wrong on Our Side. Sorry :( " & ex.Message)
        End Try
        _c.Close()
        If String.IsNullOrEmpty(SearchField.Text) Then
            SearchResults.Visible = False
        End If
        RecentListView.SelectedIndices.Clear()
        ShuffleBox.SelectedIndices.Clear()
        AllBooks.SelectedIndices.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles AddBook.Click
        Form4.PurposeBase.Text = "Adding a New Book"
        Form4.Show()
    End Sub

    Private Sub RefreshAll_Click(sender As Object, e As EventArgs) Handles RefreshAll.Click
        RefreshFeatured()
        RefreshShuffleBox()
        RefreshAllBooks()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Connect()
        Try
            _c.Open()
            EQ($"DELETE FROM {Database}.books WHERE Title = '{AllBooks.SelectedItems(0).Text}' ")
            MessageBox.Show("Data is Deleted!")
            _c.Close()
        Catch ex As Exception
            MessageBox.Show("Something went wrong on Our Side. Sorry :(" & ex.Message)
        End Try
    End Sub

    Private Sub Shuffle_Click(sender As Object, e As EventArgs) Handles Shuffle.Click

        Try
            ShuffleListViewItems(ShuffleBox)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ShuffleListViewItems(ByVal listView As ListView)
        Dim random As New Random()
        Dim items As New List(Of ListViewItem)(listView.Items.Cast(Of ListViewItem)())

        For i As Integer = items.Count - 1 To 1 Step -1
            Dim j As Integer = random.Next(i + 1)
            Dim tempItem As ListViewItem = items(i).Clone()
            items(i) = items(j).Clone()
            items(j) = tempItem
        Next

        listView.Items.Clear()
        For Each item As ListViewItem In items
            listView.Items.Add(item)
        Next
    End Sub

    Private Sub AdminChoice_CheckedChanged(sender As Object, e As EventArgs) Handles AdminChoice.CheckedChanged
        AddBook.Visible = True
        Delete.Visible = True
    End Sub
    Private Sub UserChoice_CheckedChanged(sender As Object, e As EventArgs) Handles UserChoice.CheckedChanged
        AddBook.Visible = False
        Delete.Visible = False
    End Sub
    Private Sub AllBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AllBooks.SelectedIndexChanged
        AddBook.Enabled = True
        Delete.Enabled = True
    End Sub
End Class