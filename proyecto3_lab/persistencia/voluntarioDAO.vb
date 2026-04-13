Public Class voluntarioDAO

    Public ReadOnly Property Personas As Collection

    Public Sub New()
        Me.Personas = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Voluntario
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM voluntario ORDER BY DNI")
        For Each aux In col
            p = New Voluntario(aux(1).ToString)
            p.Nombre = aux(2).ToString
            p.especialidad = aux(3).ToString
            p.centro = aux(4)
            Me.Personas.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Voluntario)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM voluntario WHERE DNI='" & p.DNI & "';")
        For Each aux In col
            p.Nombre = aux(2).ToString
            p.especialidad = aux(3).ToString
            p.centro = aux(4)
        Next
    End Sub

    Public Function Insertar(ByVal p As Voluntario) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO voluntario VALUES ('" & p.DNI & "', '" & p.Nombre & "', '" & p.especialidad & "', '" & p.centro & "');")
    End Function

    Public Function Actualizar(ByVal p As Voluntario) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE voluntario SET Nombre='" & p.Nombre & "', Especialidad='" & p.especialidad & "', idCentro='" & p.centro & "' WHERE DNI='" & p.DNI & "';")
    End Function

    Public Function Borrar(ByVal p As Voluntario) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM voluntario WHERE DNI='" & p.DNI & "';")
    End Function

End Class

