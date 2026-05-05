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

    Public Function InsertarDetalleYRestarStock(idCentroOrigen As Integer) As Integer
        Dim alm As New Almacenamiento()
        alm.IdCentro = idCentroOrigen
        alm.IdSuministro = Me.id_suministro

        ' 2. Obtenemos el stock actual usando el método que ya definiste
        Dim cantidaddelalmacen As Integer = alm.ObtenerStock()

        ' 3. VALIDACIÓN: Si no hay suficiente stock, lanzamos un error o devolvemos un código
        If cantidaddelalmacen < Me.cantidad Then
            ' Puedes lanzar una excepción para que el Try/Catch de la presentación lo capture
            Throw New Exception("Stock insuficiente para el suministro " & Me.id_suministro &
                            ". Disponible: " & cantidaddelalmacen & ", Solicitado: " & Me.cantidad)
        End If

        Dim resultadoDetalle As Integer = Me.DetalleDAO.Insertar(Me)


        If resultadoDetalle > 0 Then
            Return Me.DetalleDAO.ActualizarStock(idCentroOrigen, Me.id_suministro, Me.cantidad)
        Else
            Return 0
        End If
    End Function
End Class