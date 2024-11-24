<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        PurposeBase = New Label()
        PublisherInfo = New TextBox()
        Label3 = New Label()
        BookIDInfo = New TextBox()
        Label4 = New Label()
        AuthorInfo = New TextBox()
        Label5 = New Label()
        DateInfo = New TextBox()
        Label6 = New Label()
        GenreInfo = New TextBox()
        Label7 = New Label()
        CategoryInfo = New TextBox()
        Label8 = New Label()
        Save = New Button()
        RichTitle = New RichTextBox()
        Cancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 10F)
        Label1.Location = New Point(24, 260)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 0
        Label1.Text = "Book ID"
        ' 
        ' PurposeBase
        ' 
        PurposeBase.AutoSize = True
        PurposeBase.Font = New Font("Poppins Medium", 20F)
        PurposeBase.Location = New Point(12, 34)
        PurposeBase.Name = "PurposeBase"
        PurposeBase.Size = New Size(400, 48)
        PurposeBase.TabIndex = 1
        PurposeBase.Text = "Window Purpose Based Title"
        ' 
        ' PublisherInfo
        ' 
        PublisherInfo.Font = New Font("Poppins", 10F)
        PublisherInfo.Location = New Point(24, 424)
        PublisherInfo.Name = "PublisherInfo"
        PublisherInfo.Size = New Size(184, 27)
        PublisherInfo.TabIndex = 4
        PublisherInfo.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 10F)
        Label3.Location = New Point(24, 396)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 25)
        Label3.TabIndex = 3
        Label3.Text = "Publisher"
        ' 
        ' BookIDInfo
        ' 
        BookIDInfo.Font = New Font("Poppins", 10F)
        BookIDInfo.Location = New Point(24, 288)
        BookIDInfo.Name = "BookIDInfo"
        BookIDInfo.Size = New Size(184, 27)
        BookIDInfo.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 10F)
        Label4.Location = New Point(22, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 25)
        Label4.TabIndex = 5
        Label4.Text = "Title"
        ' 
        ' AuthorInfo
        ' 
        AuthorInfo.Font = New Font("Poppins", 10F)
        AuthorInfo.Location = New Point(24, 354)
        AuthorInfo.Name = "AuthorInfo"
        AuthorInfo.Size = New Size(184, 27)
        AuthorInfo.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 10F)
        Label5.Location = New Point(24, 326)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 25)
        Label5.TabIndex = 7
        Label5.Text = "Author"
        ' 
        ' DateInfo
        ' 
        DateInfo.Font = New Font("Poppins", 10F)
        DateInfo.Location = New Point(232, 288)
        DateInfo.Name = "DateInfo"
        DateInfo.Size = New Size(195, 27)
        DateInfo.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 10F)
        Label6.Location = New Point(232, 260)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 25)
        Label6.TabIndex = 9
        Label6.Text = "Date Released"
        ' 
        ' GenreInfo
        ' 
        GenreInfo.Font = New Font("Poppins", 10F)
        GenreInfo.Location = New Point(232, 354)
        GenreInfo.Name = "GenreInfo"
        GenreInfo.Size = New Size(195, 27)
        GenreInfo.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Poppins", 10F)
        Label7.Location = New Point(232, 326)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 25)
        Label7.TabIndex = 11
        Label7.Text = "Genre"
        ' 
        ' CategoryInfo
        ' 
        CategoryInfo.Font = New Font("Poppins", 10F)
        CategoryInfo.Location = New Point(232, 424)
        CategoryInfo.Name = "CategoryInfo"
        CategoryInfo.Size = New Size(195, 27)
        CategoryInfo.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 10F)
        Label8.Location = New Point(232, 396)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 25)
        Label8.TabIndex = 13
        Label8.Text = "Category"
        ' 
        ' Save
        ' 
        Save.Font = New Font("Poppins", 10F)
        Save.Location = New Point(320, 481)
        Save.Name = "Save"
        Save.Size = New Size(107, 35)
        Save.TabIndex = 15
        Save.Text = "Save"
        Save.UseVisualStyleBackColor = True
        ' 
        ' RichTitle
        ' 
        RichTitle.Font = New Font("Poppins", 12F)
        RichTitle.Location = New Point(24, 110)
        RichTitle.Name = "RichTitle"
        RichTitle.Size = New Size(403, 132)
        RichTitle.TabIndex = 16
        RichTitle.Text = ""
        ' 
        ' Cancel
        ' 
        Cancel.Font = New Font("Poppins", 10F)
        Cancel.Location = New Point(207, 481)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(107, 35)
        Cancel.TabIndex = 17
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 536)
        Controls.Add(Cancel)
        Controls.Add(RichTitle)
        Controls.Add(Save)
        Controls.Add(CategoryInfo)
        Controls.Add(Label8)
        Controls.Add(GenreInfo)
        Controls.Add(Label7)
        Controls.Add(DateInfo)
        Controls.Add(Label6)
        Controls.Add(AuthorInfo)
        Controls.Add(Label5)
        Controls.Add(BookIDInfo)
        Controls.Add(Label4)
        Controls.Add(PublisherInfo)
        Controls.Add(Label3)
        Controls.Add(PurposeBase)
        Controls.Add(Label1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PurposeBase As Label
    Friend WithEvents PublisherInfo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BookIDInfo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AuthorInfo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateInfo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GenreInfo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CategoryInfo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Save As Button
    Friend WithEvents RichTitle As RichTextBox
    Friend WithEvents Cancel As Button
End Class
