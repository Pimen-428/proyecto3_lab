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

    Public Function InsertarDetalleYRestarStock(idCentroOrigen As Integer) As Integer

        Dim resultadoDetalle As Integer = Me.DetalleEnvioDAO.Insertar(Me)


        If resultadoDetalle > 0 Then
            Return Me.DetalleEnvioDAO.ActualizarStock(idCentroOrigen, Me.id_suministro, Me.cantidad)
        Else
            Return 0
        End If
    End Function
End Class
