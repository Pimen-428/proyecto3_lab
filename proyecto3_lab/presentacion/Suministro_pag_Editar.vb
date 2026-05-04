Public Class Suministro_pag_editar

    Private suministroActual As Suministro

    Public Sub CargarSuministro(s As Suministro)
        suministroActual = s

        TextBoxID.Text = s.id_suministro.ToString()
        TextBoxDescripcion.Text = s.Descripcion
        TextBoxCategoria.Text = s.Categoria
        TextBoxPeso.Text = s.PesoUnitario.ToString()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

        Try
            suministroActual.Descripcion = TextBoxDescripcion.Text
            suministroActual.Categoria = TextBoxCategoria.Text
            suministroActual.PesoUnitario = CDbl(TextBoxPeso.Text)

            Dim dao As New SuministroDao()
            dao.Update(suministroActual)

            MessageBox.Show("Suministro actualizado")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

End Class
