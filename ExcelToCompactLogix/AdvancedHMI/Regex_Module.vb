Imports System.Text.RegularExpressions
Module Regex_Module
    Private Property Regex_Pass As Boolean
    Private Property Regex_Pattern As String = New String("") '
    Private Property Regex_ToString_ As String = New String("") '
    Private Property Regex_Fail As String = New String("") '

    Public Function Regex_Module_Check(string_test As String, string_Indenty As String) As String
        'Check here
        Select Case string_Indenty
            Case "barcode"
                Regex_Pattern = "\d{5,10}" '000225524134
                'Regex_Pattern = "\d+"'
            Case "double"
                Regex_Pattern = "\d{1,4}.\d{1,3}" '0000.000
            Case "int"
                Regex_Pattern = "\d{1,4}" '0000
            Case Else
                Regex_Pattern = "\w+"

        End Select
        Try
            Dim m As Match = Regex.Match(string_test, Regex_Pattern, RegexOptions.Singleline)
            If m.Success Then
                Regex_Pass = True
                Regex_ToString_ = m.Value

            Else
                Regex_Pass = False
                Regex_ToString_ = "0"
                Regex_Fail = string_test

            End If
            Return Regex_ToString_
        Catch ex As Exception
            Regex_ToString_ = "0"
        End Try
        Return Regex_ToString_
    End Function
    Public Function Regex_Module_Check_Settings(string_test As String, string_Indenty As String) As String
        'Check here
        Select Case string_Indenty
            Case "barcode"
                Regex_Pattern = "\d{5,10}" '000225524134

            Case "double"
                Regex_Pattern = "\d{1,4}.\d{1,3}" '0000.000
            Case "int"
                Regex_Pattern = "\d{1,4}" '0000
            Case Else
                Regex_Pattern = "\w+"

        End Select
        Try
            Dim m As Match = Regex.Match(string_test, Regex_Pattern, RegexOptions.Singleline)
            If m.Success Then
                Regex_Pass = True
                Regex_ToString_ = m.Value

            Else
                Regex_Pass = False
                Regex_ToString_ = "0"
                Regex_Fail = string_test

                'Module_Write_Text_File.Write_File($"Battery list fail Regex.txt", Regex_Fail) 'write to text file. all fails.
            End If
            Return Regex_ToString_
        Catch ex As Exception
            Regex_ToString_ = "0"
        End Try
        Return Regex_ToString_
    End Function
End Module
