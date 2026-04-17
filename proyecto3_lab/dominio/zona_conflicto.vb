Public Class zona_conflicto

    Public Property id As Integer
    Public Property nombre As String
    Public Property pais As String
    Public Property nivel_urgencia As Integer

    Public ReadOnly Property ZonaDAO As ZonaConflictoDAO

    Public Sub New()
        Me.ZonaDAO = New ZonaConflictoDAO()
    End Sub

    Public Sub New(id As Integer)
        Me.id = id
        Me.ZonaDAO = New ZonaConflictoDAO()
    End Sub


    Public Sub LeerTodasZonas()
        Me.ZonaDAO.LeerTodos()
    End Sub

    Public Sub LeerZona()
        Me.ZonaDAO.Leer(Me)
    End Sub

    Public Function InsertarZona() As Integer
        Return Me.ZonaDAO.Insertar(Me)
    End Function

    Public Function ActualizarZona() As Integer
        Return Me.ZonaDAO.Actualizar(Me)
    End Function

    Public Function BorrarZona() As Integer
        Return Me.ZonaDAO.Borrar(Me)
    End Function
End Class
