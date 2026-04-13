Public Class Voluntario

    Public Property DNI As String
    Public Property Nombre As String
    Public Property especialidad As String
    Public Property centro As Integer


    Public ReadOnly Property PerDAO As voluntarioDAO


    Public Sub New()
        Me.PerDAO = New voluntarioDAO
    End Sub

    Public Sub New(id As String)
        Me.PerDAO = New voluntarioDAO
        Me.DNI = id
    End Sub

    Public Sub LeerTodasPersonas()
        Me.PerDAO.LeerTodas()
    End Sub

    Public Sub LeerPersona()
        Me.PerDAO.Leer(Me)
    End Sub

    Public Function InsertarPersona() As Integer
        Return Me.PerDAO.Insertar(Me)
    End Function

    Public Function ActualizarPersona() As Integer
        Return Me.PerDAO.Actualizar(Me)
    End Function

    Public Function BorrarPersona() As Integer
        Return Me.PerDAO.Borrar(Me)
    End Function

End Class
