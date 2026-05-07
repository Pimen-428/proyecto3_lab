Public Class entrega
    Public Property id As Integer
    Public Property id_centro_origen As Integer
    Public Property id_zona_destino As Integer
    Public Property dni_voluntario As String
    Public Property fecha As Date


    Public Property detalles As Collection

    Public ReadOnly Property EntregaDAO As EntregaDAO

    Public Sub New()
        Me.id = 0
        Me.detalles = New Collection()
        Me.EntregaDAO = New EntregaDAO
    End Sub

    Public Sub New(id As Integer)
        Me.EntregaDAO = New EntregaDAO
        Me.id = id
        Me.detalles = New Collection()
    End Sub


    Public Sub LeerTodasEntregas()
        Me.EntregaDAO.LeerTodos()
    End Sub

    Public Sub LeerEntrega()
        Me.EntregaDAO.Leer(Me)

    End Sub

    Public Function InsertarEntrega() As Integer

        Return Me.EntregaDAO.Insertar(Me)
    End Function
    Public Function ActualizarEntrega() As Integer
        Return Me.EntregaDAO.Actualizar(Me)
    End Function
    Public Function UltimaEntrega()
        Return Me.EntregaDAO.UltimaEntregaCreada()
    End Function
    Public Function EliminarEntrega() As Integer
        Return Me.EntregaDAO.Borrar(Me)
    End Function
    Public Sub GenerarNuevoID()
        Dim col As Collection = Me.EntregaDAO.UltimaEntregaCreada()
        If col.Count > 0 Then

            Dim fila As Collection = DirectCast(col.Item(1), Collection)
            Me.id = CInt(fila.Item(1)) + 1
        Else

            Me.id = 1
        End If
    End Sub



End Class