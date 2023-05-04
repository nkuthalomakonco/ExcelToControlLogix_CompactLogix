Public Class EXcel_Colunms
    Public EXcel_Colunms_barcode As String
    Public EXcel_Colunms_Dry_weight As Double    ' 
    Public EXcel_Colunms_Wet_weight As String   ' 
    Public EXcel_Colunms_Post_weight As String    ' 
    Public EXcel_Colunms_Acid_weight As String    ' 
    Public EXcel_Colunms_Acid_loss As String    ' 
    Public EXcel_Colunms_ocv As String

    Public Sub New(ByVal barcode_ As String,
                   ByVal D_weight As Double,
                   ByVal W_weight As String,
                   ByVal P_weight As String,
                   ByVal ocv_ As String,
                   ByVal A_weight As String)
        ' Set the property value.
        EXcel_Colunms_barcode = barcode_
        EXcel_Colunms_Dry_weight = D_weight    ' 
        EXcel_Colunms_Wet_weight = W_weight    ' 
        EXcel_Colunms_Post_weight = P_weight    ' 
        EXcel_Colunms_Acid_weight = A_weight    ' 
        ' 
    End Sub
    Public Sub New()
        EXcel_Colunms_barcode = "1"
        EXcel_Colunms_Dry_weight = "2"    ' 
        EXcel_Colunms_Wet_weight = "3"    ' 
        EXcel_Colunms_Post_weight = "4"    ' 
        EXcel_Colunms_Acid_weight = "5"    '  ' 
    End Sub
    Protected Overrides Sub Finalize()

        'MyBase.Finalize()
    End Sub
End Class
