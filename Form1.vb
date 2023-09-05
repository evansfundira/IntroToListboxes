Public Class Form1
    Private Sub btnYourGender_Click(sender As Object, e As EventArgs) Handles btnYourGender.Click
        Dim stYourGender As String

        stYourGender = ListBox1.SelectedItem
        MsgBox("You are " & stYourGender)
    End Sub
End Class
