Imports Syncfusion.XlsIO


Module Module_Excel
    Public TextBox_ As New RichTextBox

    Sub testExcel()
        ' Create an instance of the class.
        Dim Battery_ As New Battery()

        'Instantiate the spreadsheet creation engine
        Using excelEngine As ExcelEngine = New ExcelEngine()

            'Initialize application
            Dim app As IApplication = excelEngine.Excel

            'Set default application version as Xlsx
            app.DefaultVersion = ExcelVersion.Xlsx

            'Open existing Excel workbook from the specified location
            Dim inputFileName As String = "Sample.xlsx"
            inputFileName = "C:\Users\noman.ghia\Desktop\bat.xlsx"
            Dim workbook As IWorkbook = app.Workbooks.Open(inputFileName, ExcelOpenType.Automatic)

            'Access the first worksheet
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            'Access the used range of the Excel file
            Dim usedRange As IRange = worksheet.UsedRange
            Dim lastRow As Integer = usedRange.LastRow
            Dim lastColumn As Integer = usedRange.LastColumn
            'Iterate the cells in the used range and print the cell values
            For row As Integer = 1 To lastRow
                For col As Integer = 1 To lastColumn

                Next

            Next
            Console.WriteLine(vbLf & vbLf)
            'Iterate the cells in the used range and print the display text
            For row As Integer = 1 To lastRow
                For col As Integer = 1 To lastColumn
                    Battery_.Dry_weight = worksheet(row, 1).DisplayText
                    Console.WriteLine(Battery_.Battery_Data())
                Next
                Debug.Print(vbLf)
            Next

            Console.Read()
        End Using

    End Sub
    Sub Main()

        Dim Battries As New List(Of Battery)
        Dim dry_weight As Int16
        Dim wet_weight As Int16
        Dim Bat As Battery = New Battery
        'Instantiate the spreadsheet creation engine
        Using excelEngine As ExcelEngine = New ExcelEngine()

            'Initialize application
            Dim app As IApplication = excelEngine.Excel

            'Set default application version as Xlsx
            app.DefaultVersion = ExcelVersion.Xlsx

            'Open existing Excel workbook from the specified location
            Dim inputFileName As String = "Sample.xlsx"
            inputFileName = "C:\Users\noman.ghia\Desktop\bat.xlsx"
            Dim f = "C:\Users\noman.ghia\Documents\Visual Studio 2015\Projects\AdvancedHMIv399xR1 Excel\AdvancedHMI\bin\Debug\Sample.xlsx"
            Dim workbook As IWorkbook = app.Workbooks.Open(inputFileName, ExcelOpenType.Automatic)

            'Access the first worksheet
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            'Access the used range of the Excel file
            Dim usedRange As IRange = worksheet.UsedRange
            Dim lastRow As Integer = usedRange.LastRow
            Dim lastColumn As Integer = usedRange.LastColumn
            'Iterate the cells in the used range and print the cell values
            For row As Integer = 1 To lastRow
                For col As Integer = 1 To lastColumn
                    Console.Write(worksheet(row, col).Value)
                    Console.Write(vbTab & vbTab)
                    'Debug.Print(worksheet(row, col).Value)
                    'Debug.Print(vbTab & vbTab)
                Next
                Console.WriteLine(vbLf)
                'Debug.Print(vbLf)
            Next
            Console.WriteLine(vbLf & vbLf)
            Dim dw As Double
            Dim ww As Double
            Dim loss As Double
            Dim ocv As Double

            'Iterate the cells in the used range and print the display text
            For row As Integer = 1 To lastRow
                For col As Integer = 1 To lastColumn
                    Console.Write(worksheet(row, col).DisplayText)
                    Console.Write(vbTab & vbTab)
                    If row = 1 Then
                        dw = worksheet(row, col).DisplayText
                    End If
                    If row = 2 Then
                        ww = worksheet(row, col).DisplayText
                    End If
                    If row = 3 Then
                        loss = worksheet(row, col).DisplayText
                    End If

                    Bat.Dry_weight = dw
                    Bat.Wet_weight = dw
                    Bat.Acid_loss = dw
                    Bat.ocv = dw
                    Battries.Add(Bat)
                Next
                Console.WriteLine(vbLf)
                Debug.Print(vbLf)
            Next

            For Each Bat In Battries
                TextBox_.AppendText(Bat.Battery_Data & vbLf)
            Next
            Console.WriteLine(TextBox_.ToString)

            Console.Read()
        End Using
    End Sub

End Module
