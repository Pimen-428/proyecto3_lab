Public Class top_10_suministros
    Dim s As Suministro
    Private Sub top_10_suministros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s = New Suministro
        s.top10suministros()
        Dim i = 1
        labeltop.Text = "TOP 10 SUMINISTROS ENTREGADOS" & vbCrLf &
                    "────────────────────"
        For Each aux In s.suDAO.Suministros
            labeltop.Text &= "      TOP " & i & vbCrLf & vbCrLf &
                "ID: " & aux.id_suministro & vbCrLf &
                "Suministro: " & aux.Descripcion & vbCrLf &
                "Categoria: " & aux.Categoria & vbCrLf &
                "Total enviado: " & aux.Cantidad & vbCrLf &
                 "────────────────────"
            i = i + 1
        Next
    End Sub
End Class
