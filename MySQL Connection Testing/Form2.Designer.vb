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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TB_EID = New TextBox()
        TB_Name = New TextBox()
        TB_Surname = New TextBox()
        TB_Age = New TextBox()
        Btn_Edit = New Button()
        Btn_Save = New Button()
        Btn_Delete = New Button()
        NameListDrop = New ComboBox()
        NameListBox = New ListBox()
        EndSession = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Poppins", 9F)
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 27)
        Button1.TabIndex = 0
        Button1.Text = "Sign Out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 9F)
        Label1.Location = New Point(25, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 22)
        Label1.TabIndex = 1
        Label1.Text = "E-ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 9F)
        Label2.Location = New Point(25, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 22)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9F)
        Label3.Location = New Point(25, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 22)
        Label3.TabIndex = 3
        Label3.Text = "Surname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 9F)
        Label4.Location = New Point(25, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 22)
        Label4.TabIndex = 4
        Label4.Text = "Age"
        ' 
        ' TB_EID
        ' 
        TB_EID.Font = New Font("Poppins", 9F)
        TB_EID.Location = New Point(112, 76)
        TB_EID.Name = "TB_EID"
        TB_EID.Size = New Size(158, 25)
        TB_EID.TabIndex = 5
        ' 
        ' TB_Name
        ' 
        TB_Name.Font = New Font("Poppins", 9F)
        TB_Name.Location = New Point(112, 105)
        TB_Name.Name = "TB_Name"
        TB_Name.Size = New Size(158, 25)
        TB_Name.TabIndex = 6
        ' 
        ' TB_Surname
        ' 
        TB_Surname.Font = New Font("Poppins", 9F)
        TB_Surname.Location = New Point(112, 138)
        TB_Surname.Name = "TB_Surname"
        TB_Surname.Size = New Size(158, 25)
        TB_Surname.TabIndex = 7
        ' 
        ' TB_Age
        ' 
        TB_Age.Font = New Font("Poppins", 9F)
        TB_Age.Location = New Point(112, 167)
        TB_Age.Name = "TB_Age"
        TB_Age.Size = New Size(158, 25)
        TB_Age.TabIndex = 8
        ' 
        ' Btn_Edit
        ' 
        Btn_Edit.Font = New Font("Poppins", 9F)
        Btn_Edit.Location = New Point(199, 215)
        Btn_Edit.Name = "Btn_Edit"
        Btn_Edit.Size = New Size(71, 29)
        Btn_Edit.TabIndex = 9
        Btn_Edit.Text = "Edit"
        Btn_Edit.UseVisualStyleBackColor = True
        ' 
        ' Btn_Save
        ' 
        Btn_Save.Font = New Font("Poppins", 9F)
        Btn_Save.Location = New Point(112, 215)
        Btn_Save.Name = "Btn_Save"
        Btn_Save.Size = New Size(71, 29)
        Btn_Save.TabIndex = 10
        Btn_Save.Text = "Save"
        Btn_Save.UseVisualStyleBackColor = True
        ' 
        ' Btn_Delete
        ' 
        Btn_Delete.Font = New Font("Poppins", 9F)
        Btn_Delete.Location = New Point(288, 305)
        Btn_Delete.Name = "Btn_Delete"
        Btn_Delete.Size = New Size(87, 29)
        Btn_Delete.TabIndex = 11
        Btn_Delete.Text = "Delete"
        Btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' NameListDrop
        ' 
        NameListDrop.Font = New Font("Poppins", 9F)
        NameListDrop.FormattingEnabled = True
        NameListDrop.Location = New Point(113, 304)
        NameListDrop.Name = "NameListDrop"
        NameListDrop.Size = New Size(158, 30)
        NameListDrop.TabIndex = 12
        ' 
        ' NameListBox
        ' 
        NameListBox.Font = New Font("Poppins", 9F)
        NameListBox.FormattingEnabled = True
        NameListBox.ItemHeight = 22
        NameListBox.Location = New Point(288, 69)
        NameListBox.Name = "NameListBox"
        NameListBox.Size = New Size(215, 202)
        NameListBox.TabIndex = 13
        ' 
        ' EndSession
        ' 
        EndSession.Font = New Font("Poppins", 9F)
        EndSession.Location = New Point(402, 305)
        EndSession.Name = "EndSession"
        EndSession.Size = New Size(101, 29)
        EndSession.TabIndex = 14
        EndSession.Text = "End Session"
        EndSession.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(529, 372)
        Controls.Add(EndSession)
        Controls.Add(NameListBox)
        Controls.Add(NameListDrop)
        Controls.Add(Btn_Delete)
        Controls.Add(Btn_Save)
        Controls.Add(Btn_Edit)
        Controls.Add(TB_Age)
        Controls.Add(TB_Surname)
        Controls.Add(TB_Name)
        Controls.Add(TB_EID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Database Main"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_EID As TextBox
    Friend WithEvents TB_Name As TextBox
    Friend WithEvents TB_Surname As TextBox
    Friend WithEvents TB_Age As TextBox
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents NameListDrop As ComboBox
    Friend WithEvents NameListBox As ListBox
    Friend WithEvents EndSession As Button
End Class
