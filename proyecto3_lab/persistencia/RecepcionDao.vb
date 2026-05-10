Imports Microsoft.VisualBasic

Public Class RecepcionDao

    Public Recepcion As New Collection

    Public Sub LeerTodos()
        Dim r As Recepcion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Recepcion ORDER BY idRecepcion")
        For Each aux In col
            r = New Recepcion(aux(1))
            r.IdCentro = aux(2)
            r.DniVoluntario = aux(3).ToString
            r.Fecha = CDate(aux(4))
            r.Origen = aux(5).ToString
            Me.Recepcion.Add(r)
        Next
    End Sub

    Public Sub Leer(ByRef rec As Recepcion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Recepcion WHERE idRecepcion=" & rec.IdRecepcion & ";")
        For Each aux In col
            rec.IdCentro = aux(2)
            rec.DniVoluntario = aux(3).ToString
            rec.Fecha = CDate(aux(4))
            rec.Origen = aux(5).ToString
        Next
    End Sub
    Dim col, aux As Collection
    Public Function Insertar(ByVal rec As Recepcion) As Integer
        Dim sql As String
        sql = "INSERT INTO recepcion (idCentro, DniVoluntario, Fecha) VALUES (" &
              rec.IdCentro & ", '" &
              rec.DniVoluntario & "', '" &
              rec.Fecha.ToString("yyyy-MM-dd") & "');"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function
    Public Function InsertarStock(ByVal ent As Recepcion, ByVal kilos As Double) As Integer

        Dim col As Collection
        Dim aux As Collection
        Dim stockActual As Double = 0
        Dim capacidadCentro As Double = 0

        ' 1. Obtener stock actual (en kg)
        col = AgenteBD.ObtenerAgente.Leer("SELECT SUM(Kilos) FROM almacenamiento WHERE idCentro=" & ent.IdCentro)

        For Each aux In col
            If Not IsDBNull(aux(1)) Then
                stockActual = CDbl(aux(1))
            End If
        Next

        ' 2. Obtener capacidad del centro (en toneladas → pasar a kg)
        col = AgenteBD.ObtenerAgente.Leer("SELECT Capacidad FROM centro WHERE idCentro=" & ent.IdCentro)

        For Each aux In col
            capacidadCentro = CDbl(aux(1)) * 1000
        Next

        ' 3. Validar capacidad
        If stockActual + kilos > capacidadCentro Then
            Return -1 ' ERROR: supera capacidad
        End If

        ' 4. Insertar o actualizar stock
        Dim sql As String

        sql = "INSERT INTO almacenamiento (idCentro, Kilos) VALUES (" &
          ent.IdCentro & ", " & kilos & ");"

        Return AgenteBD.ObtenerAgente.Modificar(sql)

    End Function

End Class
