Public Class Suministro_pag
    Dim s As Suministro

    Private Sub Suministros_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        RefrescarGrid()
    End Sub

    Private Sub ConfigurarGrid()
        DataGridView1.Columns.Clear()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.ReadOnly = True

        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colId", .HeaderText = "ID", .DataPropertyName = "id_suministro", .Width = 50
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colDescripcion", .HeaderText = "Descripción", .DataPropertyName = "Descripcion", .Width = 200
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colCategoria", .HeaderText = "Categoría", .DataPropertyName = "Categoria", .Width = 120
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colPeso", .HeaderText = "Peso Unitario", .DataPropertyName = "PesoUnitario", .Width = 100
        })
    End Sub

    Private Sub RefrescarGrid()
        Me.s = New Suministro()
        Try
            Me.s.LeerTodosSuministros()
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = Me.s.suDAO.Suministros
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class
