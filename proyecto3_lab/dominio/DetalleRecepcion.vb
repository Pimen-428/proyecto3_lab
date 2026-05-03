Public Class DetalleRecepcion

    Public Property IdRecepcion As Integer
    Public Property IdSuministro As Integer
    Public Property Cantidad As Integer

    Public ReadOnly Property DetalleRecepcionDAO As DetalleRecepcionDAO

    ' Constructor vacío
    Public Sub New()
        Me.DetalleRecepcionDAO = New DetalleRecepcionDAO
    End Sub

    ' Constructor con ID
    Public Sub New(idRecepcion As Integer, idSuministro As Integer)
        Me.DetalleRecepcionDAO = New DetalleRecepcionDAO
        Me.IdRecepcion = idRecepcion
        Me.IdSuministro = idSuministro
    End Sub

    ' ─────────────────────────────────────────
    '  MÉTODOS QUE DELEGAN AL DAO
    ' ─────────────────────────────────────────

    Public Function InsertarDetalle() As Integer
        Return Me.DetalleRecepcionDAO.Insertar(Me)
    End Function

    Public Function ObtenerPorRecepcion() As DataTable
        Return Me.DetalleRecepcionDAO.ObtenerPorRecepcion(Me.IdRecepcion)
    End Function

    Public Function ObtenerTodos() As DataTable
        Return Me.DetalleRecepcionDAO.ObtenerTodos()
    End Function

End Class