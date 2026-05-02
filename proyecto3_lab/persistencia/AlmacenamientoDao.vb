Imports Microsoft.VisualBasic

Public Class AlmacenamientoDAO


    ' Stock de un suministro concreto en un centro
    Public Function ObtenerStock(ByVal idCentro As Integer,
                                     ByVal idSuministro As Integer) As Integer
            Dim sql As String
            sql = "SELECT COALESCE(CantidadStock, 0) " &
                  "FROM almacenamiento " &
                  "WHERE idCentro = " & idCentro &
                  " AND idSuministro = " & idSuministro & ";"

            Dim tabla As DataTable = AgenteBD.ObtenerAgente.Consultar(sql)

            If tabla.Rows.Count > 0 Then
                Return tabla.Rows(0)(0)
            End If

            Return 0
        End Function

    ' Stock total en kilos de un centro (para validar capacidad)
    Public Function ObtenerStockTotalKilos(ByVal idCentro As Integer) As Decimal
        Dim sql As String
        sql = "SELECT COALESCE(SUM(a.CantidadStock * s.PesoUnitario), 0) " &
                  "FROM almacenamiento a " &
                  "JOIN suministro s ON a.idSuministro = s.idSuministro " &
                  "WHERE a.idCentro = " & idCentro & ";"

        Dim tabla As DataTable = AgenteBD.ObtenerAgente.Consultar(sql)

        If tabla.Rows.Count > 0 Then
            Return tabla.Rows(0)(0)
        End If

        Return 0
    End Function

    ' Inventario de un centro concreto (Informe 1)
    Public Function ObtenerInventarioByCentro(ByVal idCentro As Integer) As DataTable
            Dim sql As String
            sql = "SELECT s.Descripcion, s.Categoria, a.CantidadStock " &
                  "FROM almacenamiento a " &
                  "JOIN suministro s ON a.idSuministro = s.idSuministro " &
                  "WHERE a.idCentro = " & idCentro &
                  " ORDER BY s.Categoria, s.Descripcion;"

            Return AgenteBD.ObtenerAgente.Consultar(sql)
        End Function

        ' Inventario global de todos los centros (Informe 2)
        Public Function ObtenerListadoGlobal() As DataTable
            Dim sql As String
            sql = "SELECT cl.Nombre AS Centro, s.Descripcion, a.CantidadStock " &
                  "FROM almacenamiento a " &
                  "JOIN suministro s ON a.idSuministro = s.idSuministro " &
                  "JOIN centro_logistico cl ON a.idCentro = cl.idCentro " &
                  "ORDER BY cl.Nombre, s.Descripcion;"

            Return AgenteBD.ObtenerAgente.Consultar(sql)
        End Function



    ' Sumar stock → cuando llega una recepción
    Public Function SumarStock(ByVal idCentro As Integer,
                                   ByVal idSuministro As Integer,
                                   ByVal cantidad As Integer) As Integer
            Dim sql As String
            sql = "INSERT INTO almacenamiento (idCentro, idSuministro, CantidadStock) " &
                  "VALUES (" & idCentro & ", " & idSuministro & ", " & cantidad & ") " &
                  "ON DUPLICATE KEY UPDATE CantidadStock = CantidadStock + " & cantidad & ";"

            Return AgenteBD.ObtenerAgente.Modificar(sql)
        End Function

        ' Restar stock → cuando se hace un envío o entrega
        Public Function RestarStock(ByVal idCentro As Integer,
                                    ByVal idSuministro As Integer,
                                    ByVal cantidad As Integer) As Integer
            Dim sql As String
            sql = "UPDATE almacenamiento " &
                  "SET CantidadStock = CantidadStock - " & cantidad & " " &
                  "WHERE idCentro = " & idCentro &
                  " AND idSuministro = " & idSuministro & ";"

            Return AgenteBD.ObtenerAgente.Modificar(sql)
        End Function

    End Class

End Class
