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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 11F)
        Label1.Location = New Point(26, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 26)
        Label1.TabIndex = 0
        Label1.Text = "Title"
        ' 
        ' TitleInfo
        ' 
        TitleInfo.Font = New Font("Poppins Medium", 24F)
        TitleInfo.Location = New Point(26, 71)
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
        Label3.Location = New Point(26, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 26)
        Label3.TabIndex = 2
        Label3.Text = "Author"
        ' 
        ' AuthorNameInfo
        ' 
        AuthorNameInfo.AutoSize = True
        AuthorNameInfo.Font = New Font("Poppins Medium", 11F)
        AuthorNameInfo.Location = New Point(35, 214)
        AuthorNameInfo.Name = "AuthorNameInfo"
        AuthorNameInfo.Size = New Size(210, 26)
        AuthorNameInfo.TabIndex = 3
        AuthorNameInfo.Text = "by This Author Name Stuff"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 11F)
        Label5.Location = New Point(26, 248)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 26)
        Label5.TabIndex = 4
        Label5.Text = "Publisher"
        ' 
        ' PublisherInfo
        ' 
        PublisherInfo.AutoSize = True
        PublisherInfo.Font = New Font("Poppins Medium", 11F)
        PublisherInfo.Location = New Point(35, 274)
        PublisherInfo.Name = "PublisherInfo"
        PublisherInfo.Size = New Size(272, 26)
        PublisherInfo.TabIndex = 5
        PublisherInfo.Text = "The Name of the Publishing House"
        ' 
        ' YearInfo
        ' 
        YearInfo.AutoSize = True
        YearInfo.Font = New Font("Poppins Medium", 11F)
        YearInfo.Location = New Point(26, 405)
        YearInfo.Name = "YearInfo"
        YearInfo.Size = New Size(118, 26)
        YearInfo.TabIndex = 7
        YearInfo.Text = "Year Released"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 11F)
        Label8.Location = New Point(26, 379)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 26)
        Label8.TabIndex = 6
        Label8.Text = "Released"
        ' 
        ' GenreInfo
        ' 
        GenreInfo.AutoSize = True
        GenreInfo.Font = New Font("Poppins Medium", 11F)
        GenreInfo.Location = New Point(217, 405)
        GenreInfo.Name = "GenreInfo"
        GenreInfo.Size = New Size(108, 26)
        GenreInfo.TabIndex = 9
        GenreInfo.Text = "Genre Name"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Poppins", 11F)
        Label10.Location = New Point(217, 379)
        Label10.Name = "Label10"
        Label10.Size = New Size(58, 26)
        Label10.TabIndex = 8
        Label10.Text = "Genre"
        ' 
        ' CategoryInfo
        ' 
        CategoryInfo.AutoSize = True
        CategoryInfo.Font = New Font("Poppins Medium", 11F)
        CategoryInfo.Location = New Point(412, 405)
        CategoryInfo.Name = "CategoryInfo"
        CategoryInfo.Size = New Size(134, 26)
        CategoryInfo.TabIndex = 11
        CategoryInfo.Text = "Category Name"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Poppins", 11F)
        Label12.Location = New Point(412, 379)
        Label12.Name = "Label12"
        Label12.Size = New Size(82, 26)
        Label12.TabIndex = 10
        Label12.Text = "Category"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(412, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(164, 277)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 11F)
        Label2.Location = New Point(26, 321)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 26)
        Label2.TabIndex = 13
        Label2.Text = "Book ID: "
        ' 
        ' IDInfo
        ' 
        IDInfo.AutoSize = True
        IDInfo.Font = New Font("Poppins Medium", 11F)
        IDInfo.Location = New Point(93, 321)
        IDInfo.Name = "IDInfo"
        IDInfo.Size = New Size(116, 26)
        IDInfo.TabIndex = 14
        IDInfo.Text = "ID of the Book"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(613, 479)
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
        Text = "Book Information"
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
End Class
