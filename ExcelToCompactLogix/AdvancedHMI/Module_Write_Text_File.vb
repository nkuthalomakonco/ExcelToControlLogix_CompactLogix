Module Module_Write_Text_File

    Public Function Write_File(f As String, stri As String) As String

        Try

            Dim file As System.IO.StreamWriter
            If Module_File_Info.File_Size(f) > 5 Then ' 5MB size Delete the file before write if its big.
                Module_File_Info.File_Delete(f)
            End If
            file = My.Computer.FileSystem.OpenTextFileWriter(f, True)
            file.Write(stri & vbLf)
            file.Close()
        Catch ex As Exception
            Return ex.Message & " " & DateTime.Now.ToString("G") & vbLf
        End Try

        Return "My.Computer.FileSystem.OpenTextFileWriter(f, True). " & DateTime.Now.ToString("G") & vbLf
    End Function

End Module
