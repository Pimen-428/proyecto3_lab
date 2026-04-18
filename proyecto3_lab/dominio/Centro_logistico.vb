Public Class Centro_logistico
    Public Property id As Integer
    Public Property nombre_centro As String
    Public Property ciudad_centro As String
    'mirar esta por que en la base de datos es decimal(10,2)
    Public Property capacidad As String
    Public ReadOnly Property CentroDAO As Centro_logisticoDAO
    Public Sub New()
        Me.CentroDAO = New Centro_logisticoDAO
    End Sub
    Public Sub New(id As String)
        Me.CentroDAO = New Centro_logisticoDAO
        Me.id = id
    End Sub
    Public Sub LeerTodosCentros()
        Me.CentroDAO.LeerTodos()
    End Sub
    Public Sub LeerCentro()
        Me.CentroDAO.Leer(Me)
    End Sub
    Public Function InsertarCentro() As Integer
        Return Me.CentroDAO.Insertar(Me)
    End Function
    Public Function ActualizarCentro() As Integer
        Return Me.CentroDAO.Actualizar(Me)
    End Function

    Public Function BorrarCentro() As Integer
        Return Me.CentroDAO.Borrar(Me)
    End Function
End Class