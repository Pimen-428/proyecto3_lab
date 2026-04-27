Imports Microsoft.VisualBasic

Public Class RecepcionDao
    Public Sub New()
        Me.Personas = New Collection
    End Sub
    Dim R As Recepcion
    Dim col, aux As Collection
    //Registrar Recepción
    Public Function Insertar(ByVal rec As recepcion) As Integer
        Dim sql As String
        sql = "INSERT INTO recepcion (idCentro, DniVoluntario, Fecha) VALUES (" &
              rec.id_centro_origen & ", '" &
              rec.dni_voluntario & "', '" &
              rec.fecha.ToString("yyyy-MM-dd") & "');"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function
    Public Function InsertarStock(ByVal ent As Entrega, ByVal kilos As Double) As Integer

        Dim col As Collection
        Dim aux As Collection
        Dim stockActual As Double = 0
        Dim capacidadCentro As Double = 0

        ' 1. Obtener stock actual (en kg)
        col = AgenteBD.ObtenerAgente.Leer("SELECT SUM(Kilos) FROM almacenamiento WHERE idCentro=" & ent.id_centro_origen)

        For Each aux In col
            If Not IsDBNull(aux(1)) Then
                stockActual = CDbl(aux(1))
            End If
        Next

        ' 2. Obtener capacidad del centro (en toneladas → pasar a kg)
        col = AgenteBD.ObtenerAgente.Leer("SELECT Capacidad FROM centro WHERE idCentro=" & ent.id_centro_origen)

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
          ent.id_centro_origen & ", " & kilos & ");"

        Return AgenteBD.ObtenerAgente.Modificar(sql)

    End Function

End Class
