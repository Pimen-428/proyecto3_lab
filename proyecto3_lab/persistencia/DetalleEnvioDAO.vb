Public Class DetalleEnvioDAO

    Public Function Insertar(ByVal d As detalle_envio) As Integer

        Dim sql As String = "INSERT INTO detalle_envio (idEnvio, idSuministro, Cantidad) VALUES (" &
                            d.id_envio & ", " & d.id_suministro & ", " & d.cantidad & ");"
        Return AgenteBD.ObtenerAgente().Modificar(sql)
    End Function


    Public Function LeerPorEnvio(idEnvio As Integer) As Collection
        Dim col, aux As Collection
        Dim detalles As New Collection
        Dim d As detalle_envio

        col = AgenteBD.ObtenerAgente().Leer("SELECT idEnvio, idSuministro, Cantidad FROM detalle_envio WHERE idEnvio=" & idEnvio)

        For Each aux In col
            d = New detalle_envio()
            d.id_envio = CInt(aux(1))
            d.id_suministro = CInt(aux(2))
            d.cantidad = CInt(aux(3))
            detalles.Add(d)
        Next
        Return detalles
    End Function


    Public Function Borrar(ByVal d As detalle_envio) As Integer
        Return AgenteBD.ObtenerAgente().Modificar("DELETE FROM detalle_envio WHERE idEnvio=" & d.id_envio & " AND idSuministro=" & d.id_suministro & ";")
    End Function
End Class