Public Class detalle_envio

    Public Property id_envio As Integer
    Public Property id_suministro As Integer
    Public Property cantidad As Integer

    Public ReadOnly Property DetalleEnvioDAO As DetalleEnvioDAO

    Public Sub New()
        Me.DetalleEnvioDAO = New DetalleEnvioDAO()
    End Sub


    Public Function InsertarDetalle() As Integer
        Return Me.DetalleEnvioDAO.Insertar(Me)
    End Function

    Public Function BorrarDetalle() As Integer
        Return Me.DetalleEnvioDAO.Borrar(Me)
    End Function
End Class
