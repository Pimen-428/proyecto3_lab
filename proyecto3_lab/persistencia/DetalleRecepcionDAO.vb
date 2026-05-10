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
    Public Function ObtenerPorRecepcion(ByVal idRecepcion As Integer) As Collection
        Dim col As Collection
        col = AgenteBD.ObtenerAgente.Leer(
              "SELECT dr.idRecepcion, dr.idSuministro, s.Descripcion, " &
              "s.Categoria, dr.Cantidad " &
              "FROM detalle_recepcion dr " &
              "JOIN suministro s ON dr.idSuministro = s.idSuministro " &
              "WHERE dr.idRecepcion = " & idRecepcion & ";")

        Return col
    End Function

    ' Obtener todos los detalles
    Public Function ObtenerTodos() As Collection
        Dim col As Collection
        col = AgenteBD.ObtenerAgente.Leer(
              "SELECT dr.idRecepcion, dr.idSuministro, s.Descripcion, " &
              "s.Categoria, dr.Cantidad " &
              "FROM detalle_recepcion dr " &
              "JOIN suministro s ON dr.idSuministro = s.idSuministro " &
              "ORDER BY dr.idRecepcion;")

        Return col
    End Function
    Public Function Actualizar(ByVal det As DetalleRecepcion) As Integer
        Dim sql As String
        sql = "UPDATE detalle_recepcion SET Cantidad=" & det.Cantidad &
              " WHERE idRecepcion=" & det.IdRecepcion &
              " AND idSuministro=" & det.IdSuministro & ";"
        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function
End Class