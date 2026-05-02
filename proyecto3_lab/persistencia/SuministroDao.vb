Imports Microsoft.VisualBasic

Public Class Suminstro
    Public Function Insertar(ByVal ent As Suminstro) As Integer
        Dim sql As String
        sql = "INSERT INTO Suminstro (id_suministro, Descripcion, Categoria, PesoUnitario) VALUES (" &
              ent.id_suministro & ", '" &
              ent.Descripcion & "', '" &
              ent.Categoria & "', " &
              ent.PesoUnitario & ");"
        id_suministro As Integer
    Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function
    Public Function Update(ByVal ent As Suminstro)
        Dim sql As String
        sql = "UPDATE entrega SET " &
              "Descripcion = '" & ent.IdZonaDestino & "', " &
              "Categoria = '" & ent.DniVoluntario & "', " &
              "PesoUnitario = " & ent.PesoUnitario.ToString(System.Globalization.CultureInfo.InvariantCulture) & " " &
              "WHERE idSuministro = " & ent.IdSuministro & ";"
    End Function
    Public Function Eliminar(ByVal idSuministro As Integer) As Integer
        Dim sql As String
        sql = "DELETE FROM suministro WHERE idSuministro = " & idSuministro & ";"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function
    Public Function ObtenerTodos() As List(Of Suministro)
        Dim sql As String
        sql = "SELECT idSuministro, Descripcion, Categoria, PesoUnitario FROM suministro;"

        Dim tabla As DataTable = AgenteBD.ObtenerAgente.Consultar(sql)
        Dim lista As New List(Of Suministro)

        For Each fila As DataRow In tabla.Rows
            Dim suministro As New Suministro
            suministro.IdSuministro = fila("idSuministro")
            suministro.Descripcion = fila("Descripcion")
            suministro.Categoria = fila("Categoria")
            suministro.PesoUnitario = fila("PesoUnitario")
            lista.Add(suministro)
        Next

        Return lista
        Public Function ObtenerPorId(ByVal idSuministro As Integer) As Suministro
        Dim sql As String
        sql = "SELECT idSuministro, Descripcion, Categoria, PesoUnitario " &
          "FROM suministro " &
          "WHERE idSuministro = " & idSuministro & ";"

        Dim tabla As DataTable = AgenteBD.ObtenerAgente.Consultar(sql)
        Dim suministro As New Suministro

        If tabla.Rows.Count > 0 Then
            Dim fila As DataRow = tabla.Rows(0)
            suministro.IdSuministro = fila("idSuministro")
            suministro.Descripcion = fila("Descripcion")
            suministro.Categoria = fila("Categoria")
            suministro.PesoUnitario = fila("PesoUnitario")
        End If

        Return suministro
    End Function

End Class
