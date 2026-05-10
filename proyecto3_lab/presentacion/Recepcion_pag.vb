Public Class Recepcion_pag

    Dim r As Recepcion

    Private Sub Recepcion_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        RefrescarGrid()
    End Sub

    Private Sub ConfigurarGrid()
        DataGridView1.Columns.Clear()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.ReadOnly = True

        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colId", .HeaderText = "ID", .DataPropertyName = "IdRecepcion", .Width = 50
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colCentro", .HeaderText = "Centro", .DataPropertyName = "IdCentro", .Width = 80
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colVoluntario", .HeaderText = "Voluntario", .DataPropertyName = "DniVoluntario", .Width = 120
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colFecha", .HeaderText = "Fecha", .DataPropertyName = "Fecha", .Width = 100
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colOrigen", .HeaderText = "Origen", .DataPropertyName = "Origen", .Width = 150
        })
    End Sub

    Private Sub RefrescarGrid()
        Me.r = New Recepcion()
        Try
            Me.r.LeerTodosRecepciones()
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = Me.r.RecepcionDAO.Recepcion
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class