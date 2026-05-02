Imports Microsoft.VisualBasic

Public Class DetalleRecepcion
    Public Property idRecepcion As Integer
    Public Property idSuministro As Integer
    Public Property Cantidad As Integer
    Public Sub New()
    End Sub
    Public Sub New(idRecepcion As Integer, idSuministro As Integer, Cantidad As Integer)
        Me.idRecepcion = idRecepcion
        Me.idSuministro = idSuministro
        Me.Cantidad = Cantidad
    End Sub
End Class
