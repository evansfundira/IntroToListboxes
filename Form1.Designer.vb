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
        ListBox1 = New ListBox()
        Label1 = New Label()
        btnYourGender = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.AllowDrop = True
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Items.AddRange(New Object() {"Male", "Female", "Other"})
        ListBox1.Location = New Point(323, 106)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(150, 104)
        ListBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(245, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 20)
        Label1.TabIndex = 1
        Label1.Text = "Gender"
        ' 
        ' btnYourGender
        ' 
        btnYourGender.Location = New Point(299, 229)
        btnYourGender.Name = "btnYourGender"
        btnYourGender.Size = New Size(174, 99)
        btnYourGender.TabIndex = 2
        btnYourGender.Text = "Your Gender"
        btnYourGender.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnYourGender)
        Controls.Add(Label1)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnYourGender As Button
End Class
