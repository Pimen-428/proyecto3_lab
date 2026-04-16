Public Class EnvioDAO
    Public ReadOnly Property Envio As Collection
    Public Sub New()
        Me.Envio = New Collection
    End Sub
    Public Sub LeerTodos()
        Dim e As Envio
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM envio ORDER BY idEnvio")
        For Each aux In col
            e = New Envio(aux(1).ToString)
            e.id_origen = aux(2)
            e.id_destino = aux(3)
            e.dni_voluntario = aux(4).ToString
            e.fecha = CDate(aux(5))
            e.Estado = aux(6).ToString
            Me.Envio.Add(e)
        Next
        Throw New NotImplementedException()
    End Sub
    Public Sub Leer(ByRef Envio As Envio)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM envio WHERE idEnvio='" & Envio.id & "';")
        For Each aux In col
            Envio.id_origen = aux(2)
            Envio.id_destino = aux(3)
            Envio.dni_voluntario = aux(4).ToString
            Envio.fecha = CDate(aux(5))
            Envio.Estado = aux(6).ToString
        Next
    End Sub
    Public Function Insertar(Envio As Envio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO envio (idCentroOrigen, idCentroDestino, DniVoluntario, Fecha, Estado) " & "VALUES ('" & Envio.id_origen & "', '" & Envio.id_destino & "', '" & Envio.dni_voluntario & "', '" & Envio.fecha & "', '" & Envio.Estado & ");")
    End Function

    Public Function Actualizar(Envio As Envio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE envio SET idCentroOrigen='" & Envio.id_origen & "', idCentroDestino='" & Envio.id_destino & "', DniVoluntario='" & Envio.dni_voluntario & "', Fecha='" & Envio.fecha & "', Estado='" & Envio.Estado & "' WHERE idEnvio='" & Envio.id & "';")
    End Function

    Public Function Borrar(Envio As Envio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM ennvio WHERE idEnvio='" & Envio.id & "';")
    End Function
End Class
