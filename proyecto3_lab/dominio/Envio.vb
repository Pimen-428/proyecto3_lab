Public Class Envio
    Public Property id As Integer
    Public Property id_destino As Integer
    Public Property id_origen As Integer
    Public Property dni_voluntario As String
    Public Property fecha As Date
    Public Property Estado As String
    Public ReadOnly Property EnvioDAO As EnvioDAO

    Public Sub New()
        Me.EnvioDAO = New EnvioDAO
    End Sub
    Public Sub New(id As String)
        Me.EnvioDAO = New EnvioDAO
        Me.id = id
    End Sub
    Public Sub LeerTodosEnvios()
        Me.EnvioDAO.LeerTodos()
    End Sub
    Public Sub LeerEnvio()
        Me.EnvioDAO.Leer(Me)
    End Sub
    Public Function InsertarEnvio() As Integer
        Return Me.EnvioDAO.Insertar(Me)
    End Function
    Public Function ActualizarEnvio() As Integer
        Return Me.EnvioDAO.Actualizar(Me)
    End Function

End Class
