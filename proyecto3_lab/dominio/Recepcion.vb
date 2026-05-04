Public Class Recepcion

    Public Property IdRecepcion As Integer
    Public Property IdCentro As Integer
    Public Property DniVoluntario As String
    Public Property Fecha As Date
    Public Property Origen As String

    Public ReadOnly Property RecepcionDAO As RecepcionDAO

    ' Constructor vacío
    Public Sub New()
        Me.RecepcionDAO = New RecepcionDAO
    End Sub

    ' Constructor con ID
    Public Sub New(id As Integer)
        Me.RecepcionDAO = New RecepcionDAO
        Me.IdRecepcion = id
    End Sub


    ' Registrar la recepción
    Public Function InsertarRecepcion() As Integer
        Return Me.RecepcionDAO.Insertar(Me)
    End Function

    ' Insertar stock validando capacidad
    ' Devuelve -1 si supera capacidad
    Public Function InsertarStock(ByVal kilos As Double) As Integer
        Return Me.RecepcionDAO.InsertarStock(Me, kilos)
    End Function

End Class
