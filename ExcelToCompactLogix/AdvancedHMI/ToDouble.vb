Module To_Double
    Public Function ToRealValue(value As String) As Double
        Dim style As System.Globalization.NumberStyles
        Dim culture As System.Globalization.CultureInfo
        Dim number As Single

        style = System.Globalization.NumberStyles.Number Or
                System.Globalization.NumberStyles.Float
        culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US") 'en-US..en-GB

        If Single.TryParse(value, style, culture, number) Then

            value = Format(number, "0.000")

        Else
            value = Format(number, "0.000")
        End If
        Return number
    End Function
End Module
