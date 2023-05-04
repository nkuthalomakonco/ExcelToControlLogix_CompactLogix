Imports Syncfusion.XlsIO
Imports System.Text.RegularExpressions
Imports System.ComponentModel

Public Class MainForm
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Dim AdvancedHMI_Populate As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Excel Battery Data To CompactLogix VRLA PLC [AdvancedHMI v3.99]"
        TextBox_IP.Text = "200.1.210.54"
        TextBox_IP.Text = "200.1.210.140"
        EthernetIPforCLXCom1.IPAddress = TextBox_IP.Text
        System_Status.Text = "Running"

        Button_Load.Enabled = False
        NumericUpDown1.Minimum = 0
        NumericUpDown1.Maximum = 4449
        NumericUpDown1.Value = 0
        Label_Size.Text = "Battery size: 0"

        MaximizeBox = False
        Button_Load.Enabled = False

        Button_Send.Enabled = False
        Button_Stop.Enabled = False

        Dim Note = Module_Read_Text_File.Read_File("ReadMe.txt")
        RichTextBox_.Clear()
        RichTextBox_.AppendText(Note)
        RichTextBox_.SelectionStart = 0
        Label_Time.Text = $"{Date.Now.ToString("G")}"
        RichTextBox_Logs.AppendText("Logs update " & DateTime.Now.ToString("G") & vbLf)

        ToolTip1.SetToolTip(Button_Send, "Send data to PLC.")
        ToolTip1.SetToolTip(Button_Stop, "Stop sending data to PLC.")
        ToolTip1.SetToolTip(Button_Load, "Load data from excel sheet.")
        ToolTip1.SetToolTip(Load, "Load IP.")
        ToolTip1.SetToolTip(Button_Clear, "Clear/Reset everything.")
        ToolTip1.SetToolTip(CheckBox_Auto_Load, "Set automatic data loading.")
        ToolTip1.SetToolTip(Button_SetUp, "Go to set up.") '
        ToolTip1.SetToolTip(CheckBox_PLC_Control, "Set PLC data position.")



    End Sub

    Private Sub PLC()
        For Each element As Battery In Battries
            Try

            Catch ex As Exception

            Finally

            End Try

        Next
    End Sub

    Dim Battries As New List(Of Battery)
    Dim Bat_Array As New Battery()
    Dim BB() As Object = New Battery() {}
    Dim Bat As Battery
    Dim inputFileName As String = "Sample.xlsx"

    Dim barcode_col As Int16 = 2
    Dim DW_col As Int16 = 5
    Dim WW_col As Int16 = 6
    Dim AW_col As Int16 = 30
    Dim intervals As Int16 = 1000
    Sub Excel_Colunms()
        Try
            barcode_col = Val(Form_Set_Up.TextBox_Excel_Barcode_col.Text)
            DW_col = Val(Form_Set_Up.TextBox_Excel_DW_col.Text)
            WW_col = Val(Form_Set_Up.TextBox_Excel_WW_col.Text)
            AW_col = Val(Form_Set_Up.TextBox_Excel_AW_col.Text)
            intervals = Val(Form_Set_Up.NumericUpDown_Intervals.Value)
            RichTextBox_Logs.AppendText("Excel_Colunms. " & DateTime.Now.ToString("G") & vbLf)
        Catch ex As Exception
            RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf)
        End Try
    End Sub
    Sub ReadExcel()
        RichTextBox_.Clear()
        Battries.Clear()
        'Instantiate the spreadsheet creation engine
        Using excelEngine As ExcelEngine = New ExcelEngine()

            Try
                'Initialize application
                Dim app As IApplication = excelEngine.Excel

                'Set default application version as Xlsx
                app.DefaultVersion = ExcelVersion.Xlsx

                'Open existing Excel workbook from the specified location

                Dim workbook As IWorkbook = app.Workbooks.Open(inputFileName, ExcelOpenType.Automatic)
                'Access the first worksheet
                Dim worksheet As IWorksheet = workbook.Worksheets(0)


                'Access the used range of the Excel file
                Dim usedRange As IRange = worksheet.UsedRange
                Dim lastRow As Integer = usedRange.LastRow
                Dim lastColumn As Integer = usedRange.LastColumn

                Dim value As String = "0"
                Dim barcode = "00"
                Dim dw As Double = 0
                Dim ww As String = "0"
                Dim aw As String = "0"
                Dim loss As String = "0"
                Dim pw As String = "0"
                Dim count_ As Int16 = 0
                Dim Regex_Module_Check_Flag As Boolean = False
                'Iterate the cells in the used range and print the display text
                For row As Integer = 1 To lastRow
                    Regex_Module_Check_Flag = False
                    For col As Integer = barcode_col To AW_col

                        If col = barcode_col Or col = DW_col Or col = WW_col Or col = AW_col Then

                            If col = barcode_col Then

                                value = worksheet(row, col).DisplayText ' Value
                                value = Regex_Module_Check(value, "barcode") 'Validating barcode
                                barcode = value
                                If Regex_Module_Check(worksheet(row, col).DisplayText, "barcode") = "0" Then
                                    Regex_Module_Check_Flag = True
                                End If
                            End If
                            If col = DW_col Then
                                value = worksheet(row, col).DisplayText ' Value
                                value = Regex_Module_Check(value, "double")
                                value = value.Replace(".", ",") 'or use ToRealValue(value).ToString
                                dw = value
                                If Regex_Module_Check(worksheet(row, col).DisplayText, "double") = "0" Then
                                    Regex_Module_Check_Flag = True
                                End If

                            End If
                            If col = WW_col Then
                                value = worksheet(row, col).DisplayText ' Value
                                value = Regex_Module_Check(value, "double") 'make sure the cell has valid value.regex(\d.\d)
                                'value = ToRealValue(value).ToString
                                ww = value.Replace(".", ",")
                                If Regex_Module_Check(worksheet(row, col).DisplayText, "double") = "0" Then
                                    Regex_Module_Check_Flag = True
                                End If
                            End If
                            If col = AW_col Then
                                value = worksheet(row, col).DisplayText ' Value
                                value = Regex_Module_Check(value, "double")
                                value = value.Replace(".", ",")
                                aw = value
                                If Regex_Module_Check(worksheet(row, col).DisplayText, "double") = "0" Then
                                    Regex_Module_Check_Flag = True
                                End If
                            End If

                        End If
                        Dim Battery_ As Battery = New Battery With {.barcode = barcode,
                                                .Dry_weight = dw, .Wet_weight = ww, .Acid_weight = aw, .Acid_loss = 0}
                        Bat = Battery_
                    Next

                    If Not Regex_Module_Check_Flag Then
                        RichTextBox_.AppendText(Bat.Battery_Data & vbLf)
                        Battries.Add(Bat) 'Add to my battery list. valid data
                        Label_Size.Text = $"Battery size: {Battries.Count}"
                        Module_Write_Text_File.Write_File("Battery list.txt", Bat.Battery_Data) 'write to text file.
                    End If

                Next

            Catch ex As Exception

                RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf)
            End Try

        End Using
        RichTextBox_Logs.AppendText("Data loaded. " & DateTime.Now.ToString("G") & vbLf)
        Label_Size.Text = $"Battery size: {Battries.Count}"
        index = Battries.Count 'global battery count
    End Sub

    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_Load.Click
        RichTextBox_Logs.AppendText("Loading PLC. " & DateTime.Now.ToString("G") & vbLf)

        RichTextBox_.Clear()
        ReadExcel()

        Button_Send.Enabled = True
        index = 0
    End Sub
    Private Sub PLC_St()

        Try
            'EthernetIPforCLXCom1.Write("AdvancedHMI_Started", 1) 'True
        Catch ex As Exception
            RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf)
        End Try
    End Sub

    Private Sub Button_File_Click(sender As Object, e As EventArgs) Handles Button_File.Click
        RichTextBox_Logs.AppendText("File selection. " & DateTime.Now.ToString("G") & vbLf)
        Dim ofd As OpenFileDialog = New OpenFileDialog
        ofd.DefaultExt = "xlsx"
        'ofd.FileName = "defaultname"
        ofd.InitialDirectory = "c:\"
        ofd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        ofd.Filter = "All files|*.*|Excel Files|*.xlsx"
        ofd.Filter = "Excel Files|*.xlsx"
        ofd.Title = "Choose an Excel file"
        Try
            If ofd.ShowDialog() <> DialogResult.Cancel Then
                'MsgBox(ofd.FileName)
                inputFileName = ofd.FileName

                RichTextBox_Logs.AppendText("File: " & inputFileName & " " & DateTime.Now.ToString("G") & vbLf)
                Button_Load.Enabled = True
            Else
                RichTextBox_Logs.AppendText("File: " & inputFileName & " " & DateTime.Now.ToString("G") & vbLf)
                RichTextBox_Logs.AppendText("Default file read. File was not selected. " & DateTime.Now.ToString("G") & vbLf)
                Button_Load.Enabled = True
            End If

        Catch ex As Exception
            RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_Time.Text = $"{Date.Now.ToString("G")}"
        Try
            If Not BackgroundWorker2.IsBusy Then
                BackgroundWorker2.RunWorkerAsync()
            End If

            If RichTextBox_Logs.TextLength = Int32.MaxValue Then
                RichTextBox_.Clear()
                RichTextBox_Logs.AppendText(" RichTextBox_Logs.TextLength = Int32.MaxValue " & DateTime.Now.ToString("G") & vbLf)
            End If
            If RichTextBox_.TextLength = Int32.MaxValue Then
                RichTextBox_.Clear()
                RichTextBox_Logs.AppendText(" RichTextBox.TextLength = Int32.MaxValue " & DateTime.Now.ToString("G") & vbLf)
            End If


        Catch ex As Exception
            RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("g") & vbLf)
        Finally

        End Try
    End Sub
    Private Sub RichTextBox_Logs_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox_Logs.TextChanged
        RichTextBox_Logs.ScrollToCaret()
        'RichTextBox_Logs.SelectionBackColor = Color.Yellow
    End Sub

    Private Sub Load_Click(sender As Object, e As EventArgs) Handles Load.Click
        '(\d{1,3}\.){3})\d{1,3}
        Try
            If Regex.IsMatch(TextBox_IP.Text, "\b(\d{1,3}\.){3}\d{1,3}\b", RegexOptions.Singleline) Then
                'MsgBox(Regex.Match(TextBox_IP.Text, "\b(\d{1,3}\.){3}\d{1,3}\b", RegexOptions.Singleline).Value)
                Timer1.Enabled = True  'Read PLC intervals
                Button_Send.Enabled = True
                RichTextBox_Logs.AppendText(" PLC init... " & DateTime.Now.ToString("G") & vbLf)

            Else
                RichTextBox_Logs.AppendText(" PLC IP invalid " & DateTime.Now.ToString("G") & vbLf)
            End If
        Catch ex As Exception
            RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf)
        End Try

    End Sub
    Dim index As Int64 = 0
    Dim FFL_CONTROL_POS As Int64 = 0
    Dim vIn As Double

    Private Sub Button_Send_Click(sender As Object, e As EventArgs) Handles Button_Send.Click

        If CheckBox_Auto_Load.Checked Then
            Button_Stop.Enabled = True
            Button_Send.Enabled = False
            RichTextBox_Logs.AppendText(" Auto load. " & " " & DateTime.Now.ToString("G") & vbLf)
            'Auto_Send_To_PLC(1) 'Send Battery list to PLC automatical.
            If Not BackgroundWorker1.IsBusy Then
                BackgroundWorker1.RunWorkerAsync()
            End If
            Exit Sub
        End If
        If Not CheckBox_Auto_Load.Checked Then

            If Battries.Count = 0 Then
                RichTextBox_Logs.AppendText(" Battries.Count = 0, load battries from excel. " & " " & DateTime.Now.ToString("G") & vbLf)
                Exit Sub
            End If

            Try
                If index <= Battries.Count - 1 Then
                    If FFL_CONTROL_POS >= 4449 Then
                        RichTextBox_Logs.AppendText(" FFL_CONTROL_POS >= 4449. " & " " & DateTime.Now.ToString("G") & vbLf)
                        Exit Sub
                    End If
                    RichTextBox_Logs.AppendText(Battries(index).Battery_Data & " " & DateTime.Now.ToString("G") & vbLf)
                    'EthernetIPforCLXCom1.Write("VRLA_FFL_CONTROL.POS", FFL_CONTROL_POS)

                    EthernetIPforCLXCom1.Write("AdvancedHMI_Barcode", Battries(index).barcode)
                    EthernetIPforCLXCom1.Write("AdvancedHMI_DW", Battries(index).Dry_weight.ToString())
                    EthernetIPforCLXCom1.Write("AdvancedHMI_WW", Battries(index).Wet_weight)
                    EthernetIPforCLXCom1.Write("AdvancedHMI_AW", Battries(index).Acid_weight)

                    index += 1
                    FFL_CONTROL_POS += 1
                End If
            Catch ex As Exception
                RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf)
            End Try
        End If
    End Sub

    Dim send_Auto As Boolean = False
    Dim Stop_send As Boolean = False

    Private Sub Auto_Send_To_PLC(autO As Boolean)
        If CheckBox_Auto_Load.Checked Then
            send_Auto = True
            Button_Send.Enabled = False

            If Battries.Count = 0 Then
                RichTextBox_Logs.AppendText(" Battries.Count = 0, load battries from excel. " & " " & DateTime.Now.ToString("G") & vbLf)
                Exit Sub
            End If

            Try
                If index <= Battries.Count - 1 Then
                    If FFL_CONTROL_POS >= 4449 Then
                        RichTextBox_Logs.AppendText(" FFL_CONTROL_POS >= 4449. " & " " & DateTime.Now.ToString("G") & vbLf)
                        Exit Sub
                    End If
                    For Each Battery_ As Battery In Battries
                        RichTextBox_Logs.AppendText(Battery_.Battery_Data & " " & DateTime.Now.ToString("G") & vbLf)
                        'EthernetIPforCLXCom1.Write("VRLA_FFL_CONTROL.POS", FFL_CONTROL_POS)

                        EthernetIPforCLXCom1.Write("AdvancedHMI_Barcode", Battery_.barcode)
                        EthernetIPforCLXCom1.Write("AdvancedHMI_DW", Battery_.Dry_weight.ToString())
                        EthernetIPforCLXCom1.Write("AdvancedHMI_WW", Battery_.Wet_weight)
                        EthernetIPforCLXCom1.Write("AdvancedHMI_AW", Battery_.Acid_weight)
                        System.Threading.Thread.Sleep(1000) '1000ms=1sec pause.
                        If Stop_send Then
                            Exit For
                        End If
                    Next
                    RichTextBox_Logs.AppendText("Done Battery list." & " " & DateTime.Now.ToString("G") & vbLf)
                End If
            Catch ex As Exception
                RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf)
            End Try
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Try
            If CheckBox_PLC_Control.Checked Then

                FFL_CONTROL_POS = NumericUpDown1.Value
                EthernetIPforCLXCom1.Write("VRLA_FFL_CONTROL.POS", FFL_CONTROL_POS)
            End If

            RichTextBox_Logs.AppendText("VRLA_FFL_CONTROL.POS:  Changed. " & DateTime.Now.ToString("g") & vbLf)

        Catch ex As Exception
            RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf)
        End Try
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        Stop_send = False

        RichTextBox_Logs.AppendText("Clear/Reset. " & DateTime.Now.ToString("G") & vbLf)
        RichTextBox_.Clear()
        Battries.Clear()
        index = 0
        Button_Load.Enabled = False
        Label_Size.Text = $"Battery size: {Battries.Count}"
    End Sub

    Private Sub Button_SetUp_Click(sender As Object, e As EventArgs) Handles Button_SetUp.Click
        'set up excel columns
        Form_Set_Up.Show()
    End Sub

    Private Sub Button_Stop_Click(sender As Object, e As EventArgs) Handles Button_Stop.Click
        Stop_send = True
        'Battries.Clear()
        'index = 0
        RichTextBox_Logs.AppendText("Stopped. Battery list cleared. " & DateTime.Now.ToString("G") & vbLf)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If CheckBox_Auto_Load.Checked Then
            send_Auto = True
            Button_Send.BeginInvoke(Sub() Button_Send.Enabled = False)

            If Battries.Count = 0 Then
                RichTextBox_Logs.BeginInvoke(Sub() RichTextBox_Logs.AppendText(" Battries.Count = 0, load battries from excel. " & " " & DateTime.Now.ToString("G") & vbLf))
                Exit Sub
            End If

            Try
                If index <= Battries.Count - 1 Then
                    If FFL_CONTROL_POS >= 4449 Then
                        RichTextBox_Logs.BeginInvoke(Sub() RichTextBox_Logs.AppendText(" FFL_CONTROL_POS >= 4449. " & " " & DateTime.Now.ToString("G") & vbLf))

                        Exit Sub
                    End If
                    For index = 0 To Battries.Count - 1

                        If Stop_send Then
                            RichTextBox_Logs.BeginInvoke(Sub() RichTextBox_Logs.AppendText($"Sending stopped, {index} loaded. :{DateTime.Now.ToString("G") & vbLf}"))

                            Exit For
                        End If
                        RichTextBox_Logs.BeginInvoke(Sub() RichTextBox_Logs.AppendText($"Battery list index: {index} :{DateTime.Now.ToString("G") & vbLf}"))
                        RichTextBox_Logs.BeginInvoke(Sub() RichTextBox_Logs.AppendText(Battries(index).Battery_Data & " " & DateTime.Now.ToString("G") & vbLf))

                        EthernetIPforCLXCom1.Write("AdvancedHMI_Barcode", Battries(index).barcode)
                        EthernetIPforCLXCom1.Write("AdvancedHMI_DW", Battries(index).Dry_weight.ToString())
                        EthernetIPforCLXCom1.Write("AdvancedHMI_WW", Battries(index).Wet_weight)
                        EthernetIPforCLXCom1.Write("AdvancedHMI_AW", Battries(index).Acid_weight)

                        System.Threading.Thread.Sleep(intervals) '1000ms=1sec pause.
                        ProgressBar1.BeginInvoke(Sub() ProgressBar1.Value = 100 * index / Battries.Count) ' ProgressBar %
                    Next

                    RichTextBox_Logs.BeginInvoke(Sub() RichTextBox_Logs.AppendText("Done Battery list." & " " & DateTime.Now.ToString("G") & vbLf))
                End If
            Catch ex As Exception
                RichTextBox_Logs.BeginInvoke(Sub() RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf))
            End Try
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        RichTextBox_Logs.AppendText($"BackgroundWorker_RunWorkerComplete :{DateTime.Now.ToString("G") & vbLf}")
    End Sub
    Dim PLC_Tags As String = "AdvancedHMI_Test"
    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Try
            PLC_Track.BeginInvoke(Sub()
                                      Try

                                          '' PLC_Track.Text = EthernetIPforCLXCom1.Read(PLC_Tags)

                                      Catch ex As Exception
                                          Exit Sub
                                      End Try

                                  End Sub)
            Label_PLC_Pos.BeginInvoke(Sub()
                                          Try
                                              ''Label_PLC_Pos.Text = EthernetIPforCLXCom1.Read("VRLA_FFL_CONTROL.POS")
                                          Catch ex As Exception
                                              Exit Sub
                                          End Try

                                      End Sub)

            System.Threading.Thread.Sleep(500) '
        Catch ex As Exception
            RichTextBox_Logs.BeginInvoke(Sub() RichTextBox_Logs.AppendText(ex.Message & " " & DateTime.Now.ToString("G") & vbLf))
        End Try
    End Sub
End Class
