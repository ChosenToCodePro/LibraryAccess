<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        tbx_Username = New TextBox()
        tbx_Password = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 10F)
        Label1.Location = New Point(50, 203)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 10F)
        Label2.Location = New Point(50, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tbx_Username
        ' 
        tbx_Username.Font = New Font("Poppins", 10F)
        tbx_Username.Location = New Point(50, 231)
        tbx_Username.Name = "tbx_Username"
        tbx_Username.Size = New Size(212, 27)
        tbx_Username.TabIndex = 2
        ' 
        ' tbx_Password
        ' 
        tbx_Password.Font = New Font("Poppins", 10F)
        tbx_Password.Location = New Point(50, 299)
        tbx_Password.Name = "tbx_Password"
        tbx_Password.PasswordChar = "•"c
        tbx_Password.Size = New Size(212, 27)
        tbx_Password.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Poppins", 10F)
        Button1.Location = New Point(50, 363)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 37)
        Button1.TabIndex = 4
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Poppins", 10F)
        Button2.Location = New Point(159, 363)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 37)
        Button2.TabIndex = 5
        Button2.Text = "End Session"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = My.Resources.Resources._3571652
        PictureBox1.Location = New Point(65, 49)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(184, 136)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(309, 455)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(tbx_Password)
        Controls.Add(tbx_Username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "The Library of Alexandria"
        TopMost = True
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbx_Username As TextBox
    Friend WithEvents tbx_Password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
