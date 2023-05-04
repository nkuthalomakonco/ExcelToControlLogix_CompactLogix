Module Module_File_Info
    Private Property MB As Double = 0
    Function File_Size(fileName As String) As Double

        Dim fi As New IO.FileInfo(fileName)

        If fi.Exists Then
            MB = (fi.Length) / 1024 / 1024 'Bytes to MB Module_File_Info.File_Size("aaaaa.txt")
            Return MB
        End If
        File_Size = 0
    End Function
    Function File_Delete(fileName As String) As Boolean

        Try
            If My.Computer.FileSystem.FileExists(fileName) Then
                My.Computer.FileSystem.DeleteFile(fileName,
                                                Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                                                Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)

            End If

        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Module
