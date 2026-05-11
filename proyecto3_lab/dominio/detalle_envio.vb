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
    'esta funcion permitia que hubiese stock negativo, la he arreglado
    Public Function InsertarDetalleYRestarStock(idCentroOrigen As Integer) As Integer
        Dim alm As New Almacenamiento()
        alm.IdCentro = idCentroOrigen
        alm.IdSuministro = Me.id_suministro

        'Obtenemos el stock actual usando el método que ya definiste
        Dim cantidaddelalmacen As Integer = alm.ObtenerStock()

        'VALIDACIÓN: Si no hay suficiente stock, lanzamos un error o devolvemos un código
        If cantidaddelalmacen < Me.cantidad Then
            'Lanzamos excepción para que se capture en la capa de interfaz
            Throw New Exception("Stock insuficiente para el suministro " & Me.id_suministro &
                            ". Disponible: " & cantidaddelalmacen & ", Solicitado: " & Me.cantidad)
        End If

        Dim resultadoDetalle As Integer = Me.DetalleEnvioDAO.Insertar(Me)


        If resultadoDetalle > 0 Then
            Return Me.DetalleEnvioDAO.ActualizarStock(idCentroOrigen, Me.id_suministro, Me.cantidad)
        Else
            Return 0
        End If
    End Function
End Class
