Public Class DetalleEntregaDAO

    Public Function Insertar(ByVal d As detalle_entrega) As Integer

        Dim sql As String = "INSERT INTO detalle_entrega (idEntrega, idSuministro, Cantidad) VALUES (" &
                            d.id_entrega & ", " & d.id_suministro & ", " & d.cantidad & ");"
        Return AgenteBD.ObtenerAgente().Modificar(sql)
    End Function

    Public Function LeerPorEntrega(idEntrega As Integer) As Collection
        Dim col, aux As Collection
        Dim detalles As New Collection
        Dim d As detalle_entrega

        col = AgenteBD.ObtenerAgente().Leer("SELECT idDetalleEntrega, idEntrega, idSuministro, Cantidad FROM detalle_entrega WHERE idEntrega=" & idEntrega)

        For Each aux In col
            d = New detalle_entrega(CInt(aux(1)))
            d.id_entrega = CInt(aux(2))
            d.id_suministro = CInt(aux(3))
            d.cantidad = CInt(aux(4))
            detalles.Add(d)
        Next
        Return detalles
    End Function

    Public Function Borrar(ByVal d As detalle_entrega) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("DELETE FROM detalle_entrega WHERE idDetalleEntrega=" & d.id)
    End Function
End Class