Public Class Centro_logisticoDAO
    Public ReadOnly Property Centro As Collection
    Public Sub New()
        Me.Centro = New Collection
    End Sub
    Public Sub LeerTodos()
        Dim c As Centro_logistico
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM centro_logistico ORDER BY idCentro")
        For Each aux In col
            c = New Centro_logistico(aux(1).ToString)
            c.nombre_centro = aux(2).ToString
            c.ciudad_centro = aux(3).ToString
            c.capacidad = aux(4)
            Me.Centro.Add(c)
        Next
        Throw New NotImplementedException()
    End Sub

    Public Sub Leer(ByRef centro_logistico As Centro_logistico)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM centro_logistico WHERE idCentro='" & centro_logistico.id & "';")
        For Each aux In col
            centro_logistico.nombre_centro = aux(2).ToString
            centro_logistico.ciudad_centro = aux(3).ToString
            centro_logistico.capacidad = aux(4)
        Next
    End Sub

    Public Function Insertar(centro_logistico As Centro_logistico) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO centro_logistico (Nombre, Ciudad, CapacidadTM) " & "VALUES ('" & centro_logistico.nombre_centro & "', '" & centro_logistico.ciudad_centro & "', " & centro_logistico.capacidad & ");")
    End Function

    Public Function Actualizar(centro_logistico As Centro_logistico) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE voluntario SET Nombre='" & centro_logistico.nombre_centro & "', Ciudad='" & centro_logistico.ciudad_centro & "', CapacidadTM='" & centro_logistico.capacidad & "' WHERE idCentro='" & centro_logistico.id & "';")
    End Function

    Public Function Borrar(centro_logistico As Centro_logistico) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM voluntario WHERE idCentro='" & centro_logistico.id & "';")
    End Function
End Class
