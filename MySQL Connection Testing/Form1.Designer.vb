﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        ConnectionTest = New Button()
        Label1 = New Label()
        Label2 = New Label()
        username = New TextBox()
        password = New TextBox()
        LogIn = New Button()
        Label3 = New Label()
        Label4 = New Label()
        database = New TextBox()
        FinishSession = New Button()
        SuspendLayout()
        ' 
        ' ConnectionTest
        ' 
        ConnectionTest.Font = New Font("Poppins", 9F)
        ConnectionTest.Location = New Point(37, 250)
        ConnectionTest.Name = "ConnectionTest"
        ConnectionTest.Size = New Size(136, 34)
        ConnectionTest.TabIndex = 0
        ConnectionTest.Text = "Test Connection"
        ConnectionTest.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 9F)
        Label1.Location = New Point(68, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 22)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 9F)
        Label2.Location = New Point(68, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 22)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' username
        ' 
        username.Font = New Font("Poppins", 9F)
        username.Location = New Point(92, 52)
        username.Name = "username"
        username.Size = New Size(172, 25)
        username.TabIndex = 3
        ' 
        ' password
        ' 
        password.Font = New Font("Poppins", 9F)
        password.Location = New Point(92, 105)
        password.Name = "password"
        password.PasswordChar = "•"c
        password.Size = New Size(172, 25)
        password.TabIndex = 4
        ' 
        ' LogIn
        ' 
        LogIn.Enabled = False
        LogIn.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LogIn.Location = New Point(37, 290)
        LogIn.Name = "LogIn"
        LogIn.Size = New Size(280, 34)
        LogIn.TabIndex = 5
        LogIn.Text = "Log In"
        LogIn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9F)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(37, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(280, 22)
        Label3.TabIndex = 6
        Label3.Text = "Test connection first before Log In is Available."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 9F)
        Label4.Location = New Point(68, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 22)
        Label4.TabIndex = 7
        Label4.Text = "Database"
        ' 
        ' database
        ' 
        database.AllowDrop = True
        database.Font = New Font("Poppins", 9F)
        database.Location = New Point(92, 186)
        database.Name = "database"
        database.Size = New Size(172, 25)
        database.TabIndex = 8
        ' 
        ' FinishSession
        ' 
        FinishSession.Font = New Font("Poppins", 9F)
        FinishSession.Location = New Point(179, 251)
        FinishSession.Name = "FinishSession"
        FinishSession.Size = New Size(138, 34)
        FinishSession.TabIndex = 9
        FinishSession.Text = "End Session"
        FinishSession.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 346)
        Controls.Add(FinishSession)
        Controls.Add(database)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(LogIn)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ConnectionTest)
        Name = "Form1"
        Text = "Log In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ConnectionTest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents LogIn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents database As TextBox
    Friend WithEvents FinishSession As Button
End Class
