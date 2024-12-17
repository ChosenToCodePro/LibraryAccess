<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label3 = New Label()
        SignOut = New Button()
        EndSession = New Button()
        Label2 = New Label()
        Shuffle = New Button()
        UserChoice = New RadioButton()
        AdminChoice = New RadioButton()
        RecentListView = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ShuffleBox = New ListView()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        AllBooks = New ListView()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        Label4 = New Label()
        AddBook = New Button()
        Delete = New Button()
        SearchResults = New ListBox()
        SearchField = New TextBox()
        RefreshAll = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins Medium", 20F)
        Label1.Location = New Point(21, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 48)
        Label1.TabIndex = 3
        Label1.Text = "Recently Released"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins SemiBold", 16F, FontStyle.Bold)
        Label3.Location = New Point(39, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(201, 39)
        Label3.TabIndex = 12
        Label3.Text = "Hello! Welcome!"
        ' 
        ' SignOut
        ' 
        SignOut.Font = New Font("Poppins", 10F)
        SignOut.Location = New Point(347, 529)
        SignOut.Name = "SignOut"
        SignOut.Size = New Size(116, 35)
        SignOut.TabIndex = 13
        SignOut.Text = "Sign Out"
        SignOut.UseVisualStyleBackColor = True
        ' 
        ' EndSession
        ' 
        EndSession.Font = New Font("Poppins", 10F)
        EndSession.Location = New Point(225, 529)
        EndSession.Name = "EndSession"
        EndSession.Size = New Size(116, 35)
        EndSession.TabIndex = 15
        EndSession.Text = "End Session"
        EndSession.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins Medium", 20F)
        Label2.Location = New Point(21, 330)
        Label2.Name = "Label2"
        Label2.Size = New Size(202, 48)
        Label2.TabIndex = 18
        Label2.Text = "Try a Shuffle?"
        ' 
        ' Shuffle
        ' 
        Shuffle.Font = New Font("Poppins", 10F)
        Shuffle.Location = New Point(351, 340)
        Shuffle.Name = "Shuffle"
        Shuffle.Size = New Size(116, 35)
        Shuffle.TabIndex = 19
        Shuffle.Text = "Shuffle"
        Shuffle.UseVisualStyleBackColor = True
        ' 
        ' UserChoice
        ' 
        UserChoice.AutoSize = True
        UserChoice.Checked = True
        UserChoice.Font = New Font("Poppins", 9F)
        UserChoice.Location = New Point(33, 534)
        UserChoice.Name = "UserChoice"
        UserChoice.Size = New Size(53, 26)
        UserChoice.TabIndex = 20
        UserChoice.TabStop = True
        UserChoice.Text = "User"
        UserChoice.UseVisualStyleBackColor = True
        ' 
        ' AdminChoice
        ' 
        AdminChoice.AutoSize = True
        AdminChoice.Font = New Font("Poppins", 9F)
        AdminChoice.Location = New Point(102, 534)
        AdminChoice.Name = "AdminChoice"
        AdminChoice.Size = New Size(108, 26)
        AdminChoice.TabIndex = 21
        AdminChoice.Text = "Administrator"
        AdminChoice.UseVisualStyleBackColor = True
        ' 
        ' RecentListView
        ' 
        RecentListView.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        RecentListView.Font = New Font("Poppins", 9F)
        RecentListView.FullRowSelect = True
        RecentListView.HeaderStyle = ColumnHeaderStyle.Nonclickable
        RecentListView.Location = New Point(30, 134)
        RecentListView.Name = "RecentListView"
        RecentListView.Size = New Size(433, 179)
        RecentListView.TabIndex = 22
        RecentListView.UseCompatibleStateImageBehavior = False
        RecentListView.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Tag = "Title"
        ColumnHeader1.Text = "Title"
        ColumnHeader1.Width = 260
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Author"
        ColumnHeader2.Width = 150
        ' 
        ' ShuffleBox
        ' 
        ShuffleBox.Columns.AddRange(New ColumnHeader() {ColumnHeader3, ColumnHeader4})
        ShuffleBox.Font = New Font("Poppins", 9F)
        ShuffleBox.FullRowSelect = True
        ShuffleBox.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ShuffleBox.Location = New Point(30, 385)
        ShuffleBox.Name = "ShuffleBox"
        ShuffleBox.Size = New Size(433, 125)
        ShuffleBox.TabIndex = 23
        ShuffleBox.UseCompatibleStateImageBehavior = False
        ShuffleBox.View = View.Details
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Tag = "Title"
        ColumnHeader3.Text = "Title"
        ColumnHeader3.Width = 260
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Author"
        ColumnHeader4.Width = 150
        ' 
        ' AllBooks
        ' 
        AllBooks.Columns.AddRange(New ColumnHeader() {ColumnHeader5, ColumnHeader6})
        AllBooks.Font = New Font("Poppins", 9F)
        AllBooks.FullRowSelect = True
        AllBooks.HeaderStyle = ColumnHeaderStyle.Nonclickable
        AllBooks.Location = New Point(488, 134)
        AllBooks.Name = "AllBooks"
        AllBooks.Size = New Size(463, 376)
        AllBooks.TabIndex = 24
        AllBooks.UseCompatibleStateImageBehavior = False
        AllBooks.View = View.Details
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Tag = "Title"
        ColumnHeader5.Text = "Title"
        ColumnHeader5.Width = 275
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Author"
        ColumnHeader6.Width = 165
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins Medium", 20F)
        Label4.Location = New Point(479, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 48)
        Label4.TabIndex = 25
        Label4.Text = "All Books"
        ' 
        ' AddBook
        ' 
        AddBook.Font = New Font("Poppins", 10F)
        AddBook.Location = New Point(690, 529)
        AddBook.Name = "AddBook"
        AddBook.Size = New Size(139, 35)
        AddBook.TabIndex = 27
        AddBook.Text = "Add a New Book"
        AddBook.UseVisualStyleBackColor = True
        AddBook.Visible = False
        ' 
        ' Delete
        ' 
        Delete.Enabled = False
        Delete.Font = New Font("Poppins", 10F)
        Delete.Location = New Point(835, 529)
        Delete.Name = "Delete"
        Delete.Size = New Size(116, 35)
        Delete.TabIndex = 26
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = True
        Delete.Visible = False
        ' 
        ' SearchResults
        ' 
        SearchResults.Font = New Font("Poppins", 10F)
        SearchResults.FormattingEnabled = True
        SearchResults.ItemHeight = 23
        SearchResults.Location = New Point(702, 70)
        SearchResults.Name = "SearchResults"
        SearchResults.Size = New Size(230, 119)
        SearchResults.TabIndex = 28
        SearchResults.Visible = False
        ' 
        ' SearchField
        ' 
        SearchField.Font = New Font("Poppins", 10F)
        SearchField.Location = New Point(702, 37)
        SearchField.Name = "SearchField"
        SearchField.PlaceholderText = "Search Books"
        SearchField.Size = New Size(230, 27)
        SearchField.TabIndex = 29
        ' 
        ' RefreshAll
        ' 
        RefreshAll.Font = New Font("Poppins", 10F)
        RefreshAll.Location = New Point(863, 93)
        RefreshAll.Name = "RefreshAll"
        RefreshAll.Size = New Size(88, 35)
        RefreshAll.TabIndex = 30
        RefreshAll.Text = "Refresh"
        RefreshAll.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(978, 581)
        Controls.Add(SearchField)
        Controls.Add(SearchResults)
        Controls.Add(AddBook)
        Controls.Add(Delete)
        Controls.Add(Label4)
        Controls.Add(AllBooks)
        Controls.Add(ShuffleBox)
        Controls.Add(RecentListView)
        Controls.Add(AdminChoice)
        Controls.Add(UserChoice)
        Controls.Add(Shuffle)
        Controls.Add(Label2)
        Controls.Add(EndSession)
        Controls.Add(SignOut)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(RefreshAll)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Library of Alexandria"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SignOut As Button
    Friend WithEvents EndSession As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Shuffle As Button
    Friend WithEvents UserChoice As RadioButton
    Friend WithEvents AdminChoice As RadioButton
    Friend WithEvents RecentListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ShuffleBox As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents AllBooks As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents AddBook As Button
    Friend WithEvents Delete As Button
    Friend WithEvents SearchResults As ListBox
    Friend WithEvents SearchField As TextBox
    Friend WithEvents RefreshAll As Button
End Class
