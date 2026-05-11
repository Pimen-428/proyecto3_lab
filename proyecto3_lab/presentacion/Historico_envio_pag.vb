Public Class Historico_envio_pag


    Dim dao As New EnvioDAO

    Private Sub Historico_envios_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        DateTimePicker1.Value = DateTime.Now.AddMonths(-1)
        DateTimePicker2.Value = DateTime.Now
        RefrescarGrid()
    End Sub

    Private Sub ConfigurarGrid()
        DataGridView1.Columns.Clear()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.ReadOnly = True

        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colId", .HeaderText = "ID", .Width = 50
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colOrigen", .HeaderText = "Origen", .Width = 100
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colDestino", .HeaderText = "Destino", .Width = 100
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colVoluntario", .HeaderText = "Voluntario", .Width = 120
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colFecha", .HeaderText = "Fecha", .Width = 100
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colEstado", .HeaderText = "Estado", .Width = 100
        })
    End Sub

    Private Sub RefrescarGrid()
        Try
            Dim fechaInicio As String = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")
            Dim fechaFin As String = DateTimePicker2.Value.Date.ToString("yyyy-MM-dd")
            Dim envios As Envio = New Envio
            envios.historicoenvios(fechaInicio, fechaFin)

            DataGridView1.Rows.Clear()

            For Each aux In envios.EnvioDAO.Envio
                DataGridView1.Rows.Add(
                    aux.id,
                    aux.id_origen,
                    aux.id_destino,
                    aux.dni_voluntario,
                    CDate(aux.fecha).ToShortDateString(),
                    aux.Estado)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefrescarGrid()
    End Sub

End Class