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
        SearchField = New TextBox()
        Label3 = New Label()
        SignOut = New Button()
        EndSession = New Button()
        ShuffleBox = New ListBox()
        Label2 = New Label()
        Shuffle = New Button()
        UserChoice = New RadioButton()
        AdminChoice = New RadioButton()
        FeatureListView = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins Medium", 20F)
        Label1.Location = New Point(39, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 48)
        Label1.TabIndex = 3
        Label1.Text = "Featured"
        ' 
        ' SearchField
        ' 
        SearchField.Font = New Font("Poppins", 11F)
        SearchField.ImeMode = ImeMode.NoControl
        SearchField.Location = New Point(405, 36)
        SearchField.Name = "SearchField"
        SearchField.Size = New Size(255, 29)
        SearchField.TabIndex = 11
        SearchField.TabStop = False
        SearchField.Text = "Find a Book"
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
        SignOut.Location = New Point(544, 530)
        SignOut.Name = "SignOut"
        SignOut.Size = New Size(116, 35)
        SignOut.TabIndex = 13
        SignOut.Text = "Sign Out"
        SignOut.UseVisualStyleBackColor = True
        ' 
        ' EndSession
        ' 
        EndSession.Font = New Font("Poppins", 10F)
        EndSession.Location = New Point(422, 530)
        EndSession.Name = "EndSession"
        EndSession.Size = New Size(116, 35)
        EndSession.TabIndex = 15
        EndSession.Text = "End Session"
        EndSession.UseVisualStyleBackColor = True
        ' 
        ' ShuffleBox
        ' 
        ShuffleBox.Font = New Font("Poppins", 9F)
        ShuffleBox.FormattingEnabled = True
        ShuffleBox.ItemHeight = 22
        ShuffleBox.Location = New Point(48, 386)
        ShuffleBox.Name = "ShuffleBox"
        ShuffleBox.Size = New Size(612, 114)
        ShuffleBox.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins Medium", 20F)
        Label2.Location = New Point(39, 331)
        Label2.Name = "Label2"
        Label2.Size = New Size(202, 48)
        Label2.TabIndex = 18
        Label2.Text = "Try a Shuffle?"
        ' 
        ' Shuffle
        ' 
        Shuffle.Font = New Font("Poppins", 11F)
        Shuffle.Location = New Point(512, 331)
        Shuffle.Name = "Shuffle"
        Shuffle.Size = New Size(148, 40)
        Shuffle.TabIndex = 19
        Shuffle.Text = "Shuffle"
        Shuffle.UseVisualStyleBackColor = True
        ' 
        ' UserChoice
        ' 
        UserChoice.AutoSize = True
        UserChoice.Font = New Font("Poppins", 11F)
        UserChoice.Location = New Point(55, 532)
        UserChoice.Name = "UserChoice"
        UserChoice.Size = New Size(63, 30)
        UserChoice.TabIndex = 20
        UserChoice.TabStop = True
        UserChoice.Text = "User"
        UserChoice.UseVisualStyleBackColor = True
        ' 
        ' AdminChoice
        ' 
        AdminChoice.AutoSize = True
        AdminChoice.Font = New Font("Poppins", 11F)
        AdminChoice.Location = New Point(124, 532)
        AdminChoice.Name = "AdminChoice"
        AdminChoice.Size = New Size(133, 30)
        AdminChoice.TabIndex = 21
        AdminChoice.TabStop = True
        AdminChoice.Text = "Administrator"
        AdminChoice.UseVisualStyleBackColor = True
        ' 
        ' FeatureListView
        ' 
        FeatureListView.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        FeatureListView.Font = New Font("Poppins", 9F)
        FeatureListView.Location = New Point(48, 135)
        FeatureListView.Name = "FeatureListView"
        FeatureListView.Size = New Size(612, 179)
        FeatureListView.TabIndex = 22
        FeatureListView.UseCompatibleStateImageBehavior = False
        FeatureListView.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Tag = "Title"
        ColumnHeader1.Text = "Title"
        ColumnHeader1.Width = 340
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Author"
        ColumnHeader2.Width = 250
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(706, 590)
        Controls.Add(FeatureListView)
        Controls.Add(AdminChoice)
        Controls.Add(UserChoice)
        Controls.Add(Shuffle)
        Controls.Add(Label2)
        Controls.Add(ShuffleBox)
        Controls.Add(EndSession)
        Controls.Add(SignOut)
        Controls.Add(Label3)
        Controls.Add(SearchField)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Library of Alexandria"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents SearchField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SignOut As Button
    Friend WithEvents EndSession As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ShuffleBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Shuffle As Button
    Friend WithEvents UserChoice As RadioButton
    Friend WithEvents AdminChoice As RadioButton
    Friend WithEvents FeatureListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
