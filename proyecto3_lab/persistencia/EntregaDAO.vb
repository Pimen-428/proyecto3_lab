Public Class EntregaDAO
    Public ReadOnly Property Entregas As Collection

    Public Sub New()
        Me.Entregas = New Collection
    End Sub


    Public Sub LeerTodos()
        Dim ent As entrega
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT idEntrega, idCentroOrigen, idZonaDestino, DniVoluntario, Fecha FROM entrega ORDER BY idEntrega")

        For Each aux In col

            ent = New entrega(CInt(aux(1)))
            ent.id_centro_origen = CInt(aux(2))
            ent.id_zona_destino = CInt(aux(3))
            ent.dni_voluntario = aux(4).ToString()
            ent.fecha = CDate(aux(5))
            Me.Entregas.Add(ent)
        Next
    End Sub


    Public Sub Leer(ByRef ent As entrega)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM entrega WHERE idEntrega=" & ent.id & ";")

        For Each aux In col
            ent.id_centro_origen = CInt(aux(2))
            ent.id_zona_destino = CInt(aux(3))
            ent.dni_voluntario = aux(4).ToString()
            ent.fecha = CDate(aux(5))
        Next
    End Sub


    Public Function Insertar(ByVal ent As entrega) As Integer
        Dim sql As String
        sql = "INSERT INTO entrega (idCentroOrigen, idZonaDestino, DniVoluntario, Fecha) VALUES (" &
              ent.id_centro_origen & ", " &
              ent.id_zona_destino & ", '" &
              ent.dni_voluntario & "', '" &
              ent.fecha.ToString("yyyy-MM-dd") & "');"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function


    Public Function Actualizar(ByVal ent As entrega) As Integer
        Dim sql As String
        sql = "UPDATE entrega SET " &
              "idCentroOrigen=" & ent.id_centro_origen & ", " &
              "idZonaDestino=" & ent.id_zona_destino & ", " &
              "DniVoluntario='" & ent.dni_voluntario & "', " &
              "Fecha='" & ent.fecha.ToString("yyyy-MM-dd") & "' " &
              "WHERE idEntrega=" & ent.id & ";"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function


    Public Function Borrar(ByVal ent As entrega) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM entrega WHERE idEntrega=" & ent.id & ";")
    End Function
End Class