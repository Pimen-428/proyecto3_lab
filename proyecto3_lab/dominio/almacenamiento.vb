Imports Microsoft.VisualBasic

Public Class Almacenamiento
    Public Property idCentro As Integer
    Public Property idSuministro As Integer
    Public Property CantidadStock As Integer
    Public Sub New()
    End Sub
    Public Sub New(idCentro As Integer, idSuministro As Integer, CantidadStock As Integer)
        Me.idCentro = idCentro
        Me.idSuministro = idSuministro
        Me.CantidadStock = CantidadStock
    End Sub

End Class
