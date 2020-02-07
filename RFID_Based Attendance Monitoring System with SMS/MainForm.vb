Imports System.Globalization
Public Class MainForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        mainPanel.Show()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dddd") & " - " & Date.Now.ToString("MMM dd, yyyy")
        lblTime.Text = Format(Date.Now, "Long Time")

    End Sub


    Sub switchPanel(ByVal panel As Form)
        mainPanel.Controls.Clear()
        panel.TopLevel = False
        mainPanel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        switchPanel(formDashboard)

    End Sub
    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        switchPanel(formStudentList)
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Me.Hide()
        Login.Show()
    End Sub



End Class