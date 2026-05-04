Public Class Suministro_pag_añadir

    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles ButtonAñadir.Click

        Try
            Dim s As New Suministro()

            s.id_suministro = CInt(TextBoxID.Text)
            s.Descripcion = TextBoxDescripcion.Text
            s.Categoria = TextBoxCategoria.Text
            s.PesoUnitario = CDbl(TextBoxPeso.Text)

            Dim dao As New SuministroDao()
            dao.Insertar(s)

            MessageBox.Show("Suministro añadido correctamente")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

End Class
