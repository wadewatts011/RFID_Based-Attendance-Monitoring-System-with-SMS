Imports System.Globalization
Public Class Student
    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Load(Me.OpenFileDialog1.FileName)
        Else
            MsgBox("Please choose Image")
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

    End Sub

    Private Sub MetroLabel5_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub


End Class