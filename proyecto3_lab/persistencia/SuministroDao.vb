Imports Microsoft.VisualBasic

Public Class SuminstroDao
    Public ReadOnly Property Suministros As Collection

    Public Sub New()
        Me.Suministros = New Collection
    End Sub

    Public Function Insertar(ByVal ent As Suministro) As Integer
        Dim sql As String
        sql = "INSERT INTO Suminstro (id_suministro, Descripcion, Categoria, PesoUnitario) VALUES (" &
              ent.id_suministro & ", '" &
              ent.Descripcion & "', '" &
              ent.Categoria & "', " &
              ent.PesoUnitario & ");"
        Return AgenteBD.ObtenerAgente.Modificar(sql)
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

        col = AgenteBD.ObtenerAgente().Leer("SELECT id_suministro, Descripcion, Categoria, PesoUnitario, Fecha FROM suministro ORDER BY id_suministro")

        For Each aux In col
            ent = New Suministro(CInt(aux(1)))
            ent.Descripcion = aux(2).ToString()
            ent.Categoria = aux(3).ToString()
            ent.PesoUnitario = CDbl(aux(4))
            Me.Suministros.Add(ent)
        Next
    End Sub
    Public Function ObtenerPorId(ByVal idSuministro As Integer) As Suministro
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

End Class
