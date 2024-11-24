<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        TitleInfo = New Label()
        Label3 = New Label()
        AuthorNameInfo = New Label()
        Label5 = New Label()
        PublisherInfo = New Label()
        YearInfo = New Label()
        Label8 = New Label()
        GenreInfo = New Label()
        Label10 = New Label()
        CategoryInfo = New Label()
        Label12 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        IDInfo = New Label()
        EditBookInfo = New Button()
        ButtonWarn = New Label()
        DeleteBookInfo = New Button()
        GoBack = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 11F)
        Label1.Location = New Point(24, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 26)
        Label1.TabIndex = 0
        Label1.Text = "Title"
        ' 
        ' TitleInfo
        ' 
        TitleInfo.Font = New Font("Poppins Medium", 24F)
        TitleInfo.Location = New Point(24, 84)
        TitleInfo.Name = "TitleInfo"
        TitleInfo.RightToLeft = RightToLeft.No
        TitleInfo.Size = New Size(342, 117)
        TitleInfo.TabIndex = 1
        TitleInfo.Text = "This is a Really Long Book Title"
        TitleInfo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 11F)
        Label3.Location = New Point(24, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 26)
        Label3.TabIndex = 2
        Label3.Text = "Author"
        ' 
        ' AuthorNameInfo
        ' 
        AuthorNameInfo.AutoSize = True
        AuthorNameInfo.Font = New Font("Poppins Medium", 11F)
        AuthorNameInfo.Location = New Point(33, 227)
        AuthorNameInfo.Name = "AuthorNameInfo"
        AuthorNameInfo.Size = New Size(210, 26)
        AuthorNameInfo.TabIndex = 3
        AuthorNameInfo.Text = "by This Author Name Stuff"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 11F)
        Label5.Location = New Point(24, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 26)
        Label5.TabIndex = 4
        Label5.Text = "Publisher"
        ' 
        ' PublisherInfo
        ' 
        PublisherInfo.AutoSize = True
        PublisherInfo.Font = New Font("Poppins Medium", 11F)
        PublisherInfo.Location = New Point(33, 287)
        PublisherInfo.Name = "PublisherInfo"
        PublisherInfo.Size = New Size(272, 26)
        PublisherInfo.TabIndex = 5
        PublisherInfo.Text = "The Name of the Publishing House"
        ' 
        ' YearInfo
        ' 
        YearInfo.AutoSize = True
        YearInfo.Font = New Font("Poppins Medium", 11F)
        YearInfo.Location = New Point(33, 418)
        YearInfo.Name = "YearInfo"
        YearInfo.Size = New Size(118, 26)
        YearInfo.TabIndex = 7
        YearInfo.Text = "Year Released"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 11F)
        Label8.Location = New Point(24, 392)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 26)
        Label8.TabIndex = 6
        Label8.Text = "Released"
        ' 
        ' GenreInfo
        ' 
        GenreInfo.AutoSize = True
        GenreInfo.Font = New Font("Poppins Medium", 11F)
        GenreInfo.Location = New Point(224, 418)
        GenreInfo.Name = "GenreInfo"
        GenreInfo.Size = New Size(108, 26)
        GenreInfo.TabIndex = 9
        GenreInfo.Text = "Genre Name"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Poppins", 11F)
        Label10.Location = New Point(215, 392)
        Label10.Name = "Label10"
        Label10.Size = New Size(58, 26)
        Label10.TabIndex = 8
        Label10.Text = "Genre"
        ' 
        ' CategoryInfo
        ' 
        CategoryInfo.AutoSize = True
        CategoryInfo.Font = New Font("Poppins Medium", 11F)
        CategoryInfo.Location = New Point(419, 418)
        CategoryInfo.Name = "CategoryInfo"
        CategoryInfo.Size = New Size(134, 26)
        CategoryInfo.TabIndex = 11
        CategoryInfo.Text = "Category Name"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Poppins", 11F)
        Label12.Location = New Point(407, 392)
        Label12.Name = "Label12"
        Label12.Size = New Size(82, 26)
        Label12.TabIndex = 10
        Label12.Text = "Category"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(410, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(146, 230)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 11F)
        Label2.Location = New Point(407, 332)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 26)
        Label2.TabIndex = 13
        Label2.Text = "Book ID: "
        ' 
        ' IDInfo
        ' 
        IDInfo.AutoSize = True
        IDInfo.Font = New Font("Poppins Medium", 11F)
        IDInfo.Location = New Point(474, 332)
        IDInfo.Name = "IDInfo"
        IDInfo.Size = New Size(116, 26)
        IDInfo.TabIndex = 14
        IDInfo.Text = "ID of the Book"
        ' 
        ' EditBookInfo
        ' 
        EditBookInfo.Enabled = False
        EditBookInfo.Font = New Font("Poppins", 10F)
        EditBookInfo.Location = New Point(363, 474)
        EditBookInfo.Name = "EditBookInfo"
        EditBookInfo.Size = New Size(116, 33)
        EditBookInfo.TabIndex = 15
        EditBookInfo.Text = "Edit"
        EditBookInfo.UseVisualStyleBackColor = True
        ' 
        ' ButtonWarn
        ' 
        ButtonWarn.AutoSize = True
        ButtonWarn.Font = New Font("Poppins", 9F)
        ButtonWarn.ForeColor = SystemColors.ControlDarkDark
        ButtonWarn.Location = New Point(35, 480)
        ButtonWarn.Name = "ButtonWarn"
        ButtonWarn.Size = New Size(272, 22)
        ButtonWarn.TabIndex = 16
        ButtonWarn.Text = "Modification needs Administration Privilages"
        ButtonWarn.Visible = False
        ' 
        ' DeleteBookInfo
        ' 
        DeleteBookInfo.Enabled = False
        DeleteBookInfo.Font = New Font("Poppins", 10F)
        DeleteBookInfo.Location = New Point(485, 474)
        DeleteBookInfo.Name = "DeleteBookInfo"
        DeleteBookInfo.Size = New Size(116, 33)
        DeleteBookInfo.TabIndex = 17
        DeleteBookInfo.Text = "Delete"
        DeleteBookInfo.UseVisualStyleBackColor = True
        ' 
        ' GoBack
        ' 
        GoBack.Font = New Font("Poppins", 10F)
        GoBack.Location = New Point(12, 12)
        GoBack.Name = "GoBack"
        GoBack.Size = New Size(92, 30)
        GoBack.TabIndex = 18
        GoBack.Text = "Go Back"
        GoBack.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(613, 519)
        Controls.Add(GoBack)
        Controls.Add(DeleteBookInfo)
        Controls.Add(ButtonWarn)
        Controls.Add(EditBookInfo)
        Controls.Add(IDInfo)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(CategoryInfo)
        Controls.Add(Label12)
        Controls.Add(GenreInfo)
        Controls.Add(Label10)
        Controls.Add(YearInfo)
        Controls.Add(Label8)
        Controls.Add(PublisherInfo)
        Controls.Add(Label5)
        Controls.Add(AuthorNameInfo)
        Controls.Add(Label3)
        Controls.Add(TitleInfo)
        Controls.Add(Label1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Book Information"
        TopMost = True
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TitleInfo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AuthorNameInfo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PublisherInfo As Label
    Friend WithEvents YearInfo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GenreInfo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CategoryInfo As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IDInfo As Label
    Friend WithEvents EditBookInfo As Button
    Friend WithEvents ButtonWarn As Label
    Friend WithEvents DeleteBookInfo As Button
    Friend WithEvents GoBack As Button
End Class
