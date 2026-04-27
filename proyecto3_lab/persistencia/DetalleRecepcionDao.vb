Imports Microsoft.VisualBasic

Public Class DetalleRecepcionDao
    Public Function Insertar(ByVal det As detalle_recepcion) As Integer
        Dim sql As String

        sql = "INSERT INTO detalle_recepcion (idRecepcion, idSuministro, cantidad) VALUES (" &
          det.id_recepcion & ", " &
          det.id_suministro & ", " &
          det.cantidad & ");"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function


End Class
