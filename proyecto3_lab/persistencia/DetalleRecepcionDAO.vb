Imports Microsoft.VisualBasic


Public Class DetalleRecepcionDAO

        ' Insertar una línea de detalle
        Public Function Insertar(ByVal det As DetalleRecepcion) As Integer
            Dim sql As String
            sql = "INSERT INTO detalle_recepcion (idRecepcion, idSuministro, Cantidad) VALUES (" &
              det.IdRecepcion & ", " &
              det.IdSuministro & ", " &
              det.Cantidad & ");"

            Return AgenteBD.ObtenerAgente.Modificar(sql)
        End Function

        ' Obtener todos los detalles de una recepción concreta
        Public Function ObtenerPorRecepcion(ByVal idRecepcion As Integer) As DataTable
            Dim sql As String
            sql = "SELECT dr.idRecepcion, dr.idSuministro, s.Descripcion, " &
              "s.Categoria, dr.Cantidad " &
              "FROM detalle_recepcion dr " &
              "JOIN suministro s ON dr.idSuministro = s.idSuministro " &
              "WHERE dr.idRecepcion = " & idRecepcion & ";"

            Return AgenteBD.ObtenerAgente.Consultar(sql)
        End Function

        ' Obtener todos los detalles (para informes generales)
        Public Function ObtenerTodos() As DataTable
            Dim sql As String
            sql = "SELECT dr.idRecepcion, dr.idSuministro, s.Descripcion, " &
              "s.Categoria, dr.Cantidad " &
              "FROM detalle_recepcion dr " &
              "JOIN suministro s ON dr.idSuministro = s.idSuministro " &
              "ORDER BY dr.idRecepcion;"

            Return AgenteBD.ObtenerAgente.Consultar(sql)
        End Function

    End Class

End Class
