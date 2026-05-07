Public Class DetalleEntregaDAO

    Public Function Insertar(ByVal d As detalle_entrega) As Integer

        Dim sql As String = "INSERT INTO detalle_entrega (idEntrega, idSuministro) VALUES (" &
                            d.id_entrega & ", " & d.id_suministro & ");"

        Return AgenteBD.ObtenerAgente().Modificar(sql)
    End Function

    Public Function LeerPorEntrega(idEntrega As Integer) As Collection
        Dim col, aux As Collection
        Dim detalles As New Collection
        Dim d As detalle_entrega

        ' Seguimos leyendo el ID porque nos sirve para borrar o identificar la fila
        col = AgenteBD.ObtenerAgente().Leer("SELECT IdDetalleEntrega, idEntrega, idSuministro FROM detalle_entrega WHERE idEntrega=" & idEntrega)

        For Each aux In col
            d = New detalle_entrega(CInt(aux(1)))
            d.id_entrega = CInt(aux(2))
            d.id_suministro = CInt(aux(3))
            detalles.Add(d)
        Next
        Return detalles
    End Function

    Public Function Borrar(ByVal d As detalle_entrega) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("DELETE FROM detalle_entrega WHERE IdDetalleEntrega=" & d.id)
    End Function
    Public Function ActualizarStock(idCentro As Integer, idSuministro As Integer, cantidadARestar As Integer) As Integer
        Dim sql As String = "UPDATE almacenamiento SET CantidadStock = CantidadStock - " & cantidadARestar &
                            " WHERE idCentro = " & idCentro & " AND idSuministro = " & idSuministro & ";"
        Return AgenteBD.ObtenerAgente().Modificar(sql)
    End Function

End Class