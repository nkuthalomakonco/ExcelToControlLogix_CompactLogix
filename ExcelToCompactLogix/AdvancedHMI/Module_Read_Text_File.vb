Module Module_Read_Text_File
    Public Function Read_File(file As String) As String
        Dim content As String
        Try
            content = My.Computer.FileSystem.ReadAllText(file)
            Return content
        Catch ex As Exception
            Return ex.Message & " " & DateTime.Now.ToString("G") & vbLf
        End Try

        Return "My.Computer.FileSystem.ReadAllText(file) fail. " & DateTime.Now.ToString("G") & vbLf
    End Function

End Module
