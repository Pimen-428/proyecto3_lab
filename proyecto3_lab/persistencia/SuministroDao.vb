Imports Microsoft.VisualBasic

Public Class SuminstroDao
    Public ReadOnly Property Suministros As Collection

    Public Sub New()
        Me.Suministros = New Collection()
    End Sub

    Public Function Insertar(ByVal ent As Suministro) As Integer
        Dim sql As String
        sql = "INSERT INTO suministro (Descripcion, Categoria, PesoUnitario) VALUES ('" &
          ent.Descripcion & "', '" &
          ent.Categoria & "', " &
          ent.PesoUnitario.ToString(System.Globalization.CultureInfo.InvariantCulture) & ");"
        AgenteBD.ObtenerAgente.Modificar(sql)

        ' Obtener el ID generado
        Dim colId As Collection = AgenteBD.ObtenerAgente.Leer("SELECT LAST_INSERT_ID();")
        For Each aux As Collection In colId
            ent.id_suministro = CInt(aux(1))
        Next

        Return ent.id_suministro
    End Function
    Public Function Update(ByVal ent As Suministro)
        Dim sql As String
        sql = "UPDATE suministro SET " &
              "Descripcion = '" & ent.Descripcion & "', " &
              "Categoria = '" & ent.Categoria & "', " &
              "PesoUnitario = " & ent.PesoUnitario.ToString(System.Globalization.CultureInfo.InvariantCulture) & " " &
              "WHERE idSuministro = " & ent.id_suministro & ";"
        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Eliminar(ByVal idSuministro As Integer) As Integer
        Dim sql As String
        sql = "DELETE FROM suministro WHERE idSuministro = " & idSuministro & ";"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function
    Public Sub LeerTodos()
        Dim ent As Suministro
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT idSuministro, Descripcion, Categoria, PesoUnitario FROM suministro ORDER BY idSuministro")

        For Each aux In col
            ent = New Suministro(CInt(aux(1)))
            ent.Descripcion = aux(2).ToString()
            ent.Categoria = aux(3).ToString()
            ent.PesoUnitario = CDbl(aux(4))
            Me.Suministros.Add(ent)
        Next
    End Sub
    Public Function ObtenerPorId(ByRef idSuministro As Integer) As Suministro
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT idSuministro, Descripcion, Categoria, PesoUnitario " &
                                       "FROM suministro " &
                                       "WHERE idSuministro = " & idSuministro & ";")

        Dim suministro As New Suministro
        For Each aux In col
            suministro.id_suministro = CInt(aux(1))
            suministro.Descripcion = aux(2).ToString()
            suministro.Categoria = aux(3).ToString()
            suministro.PesoUnitario = CDbl(aux(4))
        Next

        Return suministro
    End Function
    ''metodo creado pro pimen, devuelve los suministros de un centro determinado
    Public Sub suministrocentro(centro As String)
        Dim ent As Suministro
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT s.idSuministro, s.Descripcion, s.Categoria, s.PesoUnitario " &
                    "FROM suministro s " &
                    "INNER JOIN almacenamiento a ON s.idSuministro = a.idSuministro " &
                    "WHERE a.idCentro = " & centro & " " &
                    "ORDER BY s.idSuministro")
        For Each aux In col
            ent = New Suministro(CInt(aux(1)))
            ent.Descripcion = aux(2).ToString()
            ent.Categoria = aux(3).ToString()
            ent.PesoUnitario = CDbl(aux(4))
            Me.Suministros.Add(ent)
        Next
    End Sub
    Public Sub Obtenersuministro(ByRef suminsitro As Suministro)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT idSuministro, Descripcion, Categoria, PesoUnitario " &
                                       "FROM suministro " &
                                       "WHERE idSuministro = " & suminsitro.id_suministro & ";")

        For Each aux In col
            suminsitro.id_suministro = CInt(aux(1))
            suminsitro.Descripcion = aux(2).ToString()
            suminsitro.Categoria = aux(3).ToString()
            suminsitro.PesoUnitario = CDbl(aux(4))
        Next
    End Sub
    Public Sub top10suministros()
        Dim ent As Suministro
        Dim col As Collection
        Dim sql As String

        ' La consulta une ambas tablas y suma las cantidades
        sql = "SELECT s.idSuministro, s.Descripcion, s.Categoria, s.PesoUnitario, " &
          "SUM(mov.Cantidad) AS Total " &
          "FROM suministro s " &
          "INNER JOIN (" &
          "  SELECT idSuministro, Cantidad FROM detalle_envio " &
          "  UNION ALL " &
          "  SELECT idSuministro, Cantidad FROM detalle_entrega " &
          ") AS mov ON s.idSuministro = mov.idSuministro " &
          "GROUP BY s.idSuministro, s.Descripcion, s.Categoria, s.PesoUnitario " &
          "ORDER BY Total DESC " &
          "LIMIT 10;"

        col = AgenteBD.ObtenerAgente().Leer(sql)

        For Each aux In col
            ent = New Suministro(CInt(aux(1))) ' idSuministro
            ent.Descripcion = aux(2).ToString()
            ent.Categoria = aux(3).ToString()
            ent.PesoUnitario = CDbl(aux(4))
            ent.Cantidad = CInt(aux(5))

            Me.Suministros.Add(ent)
        Next
    End Sub

    Public Function ObtenerCantidadStock(idSuministro As Integer, idCentro As Integer) As Integer

        Dim sql As String = "SELECT CantidadStock FROM almacenamiento " &
                        "WHERE idSuministro = " & idSuministro & " AND idCentro = " & idCentro & ";"

        Dim col As Collection = AgenteBD.ObtenerAgente().Leer(sql)

        If col.Count > 0 Then

            Dim aux As Collection = DirectCast(col(1), Collection)
            Return CInt(aux(1))
        Else
            Return 0
        End If
    End Function
End Class
