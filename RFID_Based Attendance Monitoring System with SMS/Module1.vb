Imports MySql.Data.MySqlClient
Module Module1

    Public Sub ConnectDB()
        Dim connection As New MySqlConnection("Server=remotemysql.com;Port=3306;Database=iRgXF9zCTZ;Uid=iRgXF9zCTZ;Pwd=I8Z6KZYCqX;")
    End Sub

End Module
