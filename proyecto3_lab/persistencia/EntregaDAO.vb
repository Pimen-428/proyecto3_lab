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

        sql = "INSERT INTO entrega (idEntrega, idCentroOrigen, idZonaDestino, DniVoluntario, Fecha) VALUES (" &
          ent.id & ", " &
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
    Public Function UltimaEntregaCreada() As Collection

        Return AgenteBD.ObtenerAgente.Leer("SELECT * FROM entrega ORDER BY idEntrega DESC LIMIT 1;")
    End Function

    Public Function InformeHistorialSuministros(idZona As Integer, fInicio As String, fFin As String) As DataTable
        Dim tabla As New DataTable()
        tabla.Columns.Add("Fecha")
        tabla.Columns.Add("Suministro")
        tabla.Columns.Add("Cantidad")
        tabla.Columns.Add("Zona Destino")


        Dim sql As String = "SELECT e.fecha, s.Descripcion, de.cantidad, z.idZona " &
                        "FROM detalle_entrega de " &
                        "INNER JOIN entrega e ON de.idEntrega = e.idEntrega " &
                        "INNER JOIN suministro s ON de.idSuministro = s.idSuministro " &
                        "INNER JOIN zona_conflicto z ON e.idZonaDestino = z.idZona " &
                        "WHERE e.idZonaDestino = " & idZona & " " &
                        "AND e.fecha BETWEEN '" & fInicio & "' AND '" & fFin & "' " &
                        "ORDER BY e.fecha DESC;"

        Try
            Dim datos As Collection = AgenteBD.ObtenerAgente().Leer(sql)

            For Each fila As Collection In datos
                If fila.Count >= 4 Then
                    tabla.Rows.Add(fila(1), fila(2), fila(3), fila(4))
                End If
            Next
        Catch ex As Exception
            MsgBox("Error en SQL del DAO: " & ex.Message)
        End Try

        Return tabla
    End Function
End Class