Imports Windows.Win32.System

Public Class Centro_logisticoDAO
    Public ReadOnly Property Centro As Collection
    Public ReadOnly Property suministros As Collection
    Public Sub New()
        Me.Centro = New Collection
        Me.suministros = New Collection
    End Sub
    Public Sub LeerTodos()
        Dim c As Centro_logistico
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM centro_logistico ORDER BY idCentro")
        For Each aux In col
            c = New Centro_logistico(aux(1).ToString)
            c.nombre_centro = aux(2).ToString
            c.ciudad_centro = aux(3).ToString
            c.capacidad = aux(4)
            Me.Centro.Add(c)
        Next
    End Sub
    Public Sub suministrosdelcentro(ByRef centro_logistico As Centro_logistico)
        Dim colSum, auxSum As Collection
        Dim s As Suministro
        Dim sql As String



        ' Consulta con JOIN para obtener los datos legibles
        ' Usamos el ID del centro que ya viene dentro del objeto
        sql = "SELECT 
                        S.Descripcion AS Suministro,
                        S.Categoria,
                        A.CantidadStock AS Cantidad,
                        S.PesoUnitario
                        FROM Almacenamiento A
                        JOIN Suministro S ON A.idSuministro = S.idSuministro
                        WHERE A.idCentro = " & centro_logistico.id & ";"

        Try
            colSum = AgenteBD.ObtenerAgente().Leer(sql)

            For Each auxSum In colSum
                s = New Suministro()
                s.Descripcion = auxSum(1)
                s.Categoria = auxSum(2)
                s.Cantidad = auxSum(3)
                s.PesoUnitario = auxSum(4)
                Me.suministros.Add(s)
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar el inventario: " & ex.Message)
        End Try
    End Sub
    Public Sub Leer(ByRef centro_logistico As Centro_logistico)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM centro_logistico WHERE idCentro='" & centro_logistico.id & "';")
        For Each aux In col
            centro_logistico.nombre_centro = aux(2).ToString
            centro_logistico.ciudad_centro = aux(3).ToString
            centro_logistico.capacidad = aux(4)
        Next
    End Sub

    Public Function Insertar(centro_logistico As Centro_logistico) As Integer
        Dim num As Double = Val(centro_logistico.capacidad)
        Dim capacidadFormateada As String = num.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO centro_logistico (Nombre, Ciudad, CapacidadTM) " & "VALUES ('" & centro_logistico.nombre_centro & "', '" & centro_logistico.ciudad_centro & "', " & capacidadFormateada & ");")
    End Function

    Public Function Actualizar(centro_logistico As Centro_logistico) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE centro_logistico SET Nombre='" & centro_logistico.nombre_centro & "', Ciudad='" & centro_logistico.ciudad_centro & "', CapacidadTM='" & centro_logistico.capacidad & "' WHERE idCentro='" & centro_logistico.id & "';")
    End Function

    Public Function Borrar(centro_logistico As Centro_logistico) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM centro_logistico WHERE idCentro='" & centro_logistico.id & "';")
    End Function
End Class
