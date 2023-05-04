Imports System.Text.RegularExpressions
Public Class Form_Set_Up
    Private Sub Form_Set_Up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_Excel_Barcode_col.Text = "2"
        TextBox_Excel_DW_col.Text = "5"
        TextBox_Excel_WW_col.Text = "6"
        TextBox_Excel_AW_col.Text = "30"
        NumericUpDown_Intervals.Text = "1000" '1000ms

        MaximizeBox = False
        TopMost = True
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Try
            'Dim m As Match = Regex.Match(TextBox_Excel_Barcode_col.Text, "\d", RegexOptions.Singleline)
            If Regex.IsMatch(TextBox_Excel_Barcode_col.Text, "\d+", RegexOptions.Singleline) And
                Regex.IsMatch(TextBox_Excel_DW_col.Text, "\d+", RegexOptions.Singleline) And
                Regex.IsMatch(TextBox_Excel_WW_col.Text, "\d+", RegexOptions.Singleline) And
                Regex.IsMatch(TextBox_Excel_AW_col.Text, "\d+", RegexOptions.Singleline) And
                Regex.IsMatch(NumericUpDown_Intervals.Value, "\d{3,4}", RegexOptions.Singleline) Then
                MainForm.Excel_Colunms() 'set
                RichTextBox_Set_Up_Logs.AppendText("Settings saved. " & DateTime.Now.ToString("G") & vbLf)
            Else
                RichTextBox_Set_Up_Logs.AppendText("Setting invalid. " & DateTime.Now.ToString("G") & vbLf)
            End If
        Catch ex As Exception
            RichTextBox_Set_Up_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf)
        End Try

    End Sub

    Private Sub RichTextBox_Set_Up_Logs_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox_Set_Up_Logs.TextChanged
        RichTextBox_Set_Up_Logs.ScrollToCaret()
    End Sub
End Class