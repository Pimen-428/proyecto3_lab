Public Class ZonaConflictoDAO
    Public ReadOnly Property Zonas As Collection

    Public Sub New()
        Me.Zonas = New Collection()
    End Sub


    Public Sub LeerTodos()
        Dim z As zona_conflicto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT idZona, NombreZona, Pais, NivelUrgencia FROM zona_conflicto ORDER BY idZona")

        For Each aux In col
            z = New zona_conflicto(CInt(aux(1)))
            z.nombre = aux(2).ToString()
            z.pais = aux(3).ToString()
            z.nivel_urgencia = CInt(aux(4))
            Me.Zonas.Add(z)
        Next
    End Sub

    '
    Public Sub Leer(ByRef z As zona_conflicto)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM zona_conflicto WHERE idZona=" & z.id & ";")

        For Each aux In col
            z.nombre = aux(2).ToString()
            z.pais = aux(3).ToString()
            z.nivel_urgencia = CInt(aux(4))
        Next
    End Sub


    Public Function Insertar(ByVal z As zona_conflicto) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("INSERT INTO zona_conflicto (NombreZona, Pais, NivelUrgencia) VALUES ('" &
            z.nombre & "', '" & z.pais & "', " & z.nivel_urgencia & ");")
    End Function


    Public Function Actualizar(ByVal z As zona_conflicto) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("UPDATE zona_conflicto SET NombreZona='" &
            z.nombre & "', Pais='" & z.pais & "', NivelUrgencia=" & z.nivel_urgencia &
            " WHERE idZona=" & z.id & ";")
    End Function


    Public Function Borrar(ByVal z As zona_conflicto) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("DELETE FROM zona_conflicto WHERE idZona=" & z.id & ";")
    End Function
End Class
