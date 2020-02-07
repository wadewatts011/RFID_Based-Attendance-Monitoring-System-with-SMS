
Imports MySql.Data.MySqlClient
Public Class Login
    Dim connection As New MySqlConnection("Server=remotemysql.com;Port=3306;Database=iRgXF9zCTZ;Uid=iRgXF9zCTZ;Pwd=I8Z6KZYCqX;")
    'server natin to
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ConnectDB()
        Dim command As New MySqlCommand("SELECT  `username`, `password` FROM `tblLogin` WHERE `username` = @username AND `password` = @password", connection)
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPassword.Text
        'tblLogin, username ay admin, password ay admin or root, root
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid username or password, please try again!", "don't skip anything", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            MessageBox.Show("Welcome to Perfect Attendance Monitoring System", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainForm.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub metroLink1_Click(sender As Object, e As EventArgs) Handles metroLink1.Click
        Me.Hide()
        GateAttendance.Show() 'this is where the student log in and out screen.
    End Sub


End Class
'may error kasi obsulete yung paggamit ng watermark..

