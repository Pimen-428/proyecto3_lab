Public Class detalle_entrega
    Public Property id As Integer
    Public Property id_entrega As Integer
    Public Property id_suministro As Integer
    Public Property cantidad As Integer

    Public ReadOnly Property DetalleDAO As DetalleEntregaDAO

    Public Sub New()
        Me.DetalleDAO = New DetalleEntregaDAO()
    End Sub

    Public Sub New(id As Integer)
        Me.id = id
        Me.DetalleDAO = New DetalleEntregaDAO()
    End Sub


    Public Function InsertarDetalle() As Integer
        Return Me.DetalleDAO.Insertar(Me)
    End Function

    Public Function BorrarDetalle() As Integer
        Return Me.DetalleDAO.Borrar(Me)
    End Function
End Class