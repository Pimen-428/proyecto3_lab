Public Class ListadoGlobaldeAlmacenPag

    Dim dao As New AlmacenamientoDAO

    Private Sub Almacenamiento_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        RefrescarGrid()
    End Sub

    Private Sub ConfigurarGrid()
        DataGridView1.Columns.Clear()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.ReadOnly = True
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colCentro", .HeaderText = "idCentro", .Width = 150
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colCentro", .HeaderText = "Centro", .Width = 150
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colDescripcion", .HeaderText = "Suministro", .Width = 300
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colStock", .HeaderText = "Stock", .Width = 100
        })
    End Sub

    Private Sub RefrescarGrid()
        Try
            Dim col As Collection = dao.ObtenerListadoGlobal()
            DataGridView1.Rows.Clear()

            For Each aux As Collection In col
                DataGridView1.Rows.Add(aux(1).ToString(), aux(2).ToString(), aux(3).ToString(), aux(4).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


End Class

