Public Class Battery
    Public barcode As String
    Public Dry_weight As Double    ' 
    Public Wet_weight As String   ' 
    Public Post_weight As String    ' 
    Public Acid_weight As String    ' 
    Public Acid_loss As String    ' 
    Public ocv As String

    Public Sub New(ByVal barcode_ As String,
                   ByVal D_weight As Double,
                   ByVal W_weight As String,
                   ByVal P_weight As String,
                   ByVal ocv_ As String,
                   ByVal A_weight As String)
        ' Set the property value.
        barcode = barcode_
        Dry_weight = D_weight    ' 
        Wet_weight = W_weight    ' 
        Post_weight = P_weight    ' 
        Acid_weight = A_weight    ' 
        ocv = ocv_    ' 
    End Sub
    Public Sub New()
        ' Initialize without a course
        barcode = ""
        Dry_weight = 0.0   ' 
        Wet_weight = "0"     ' 
        Post_weight = "0"     ' 
        Acid_loss = "0"
        ocv = "0"
        Acid_weight = "0" ' 
    End Sub

    Public Function Battery_Data() As String
        Return $"Barcode: {barcode}, Dry_weight: {Dry_weight}, Wet_weigh: {Wet_weight}, Acid_weight: {Acid_weight}, Acid_loss: {Acid_loss}, OCV: {ocv}"
    End Function

    Protected Overrides Sub Finalize()  ' destructor

    End Sub

End Class
