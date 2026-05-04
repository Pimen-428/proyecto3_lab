Public Class Almacenamiento_pag_añadir

    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles ButtonAñadir.Click

        Try
            Dim dao As New AlmacenamientoDAO()

            dao.SumarStock(
                CInt(TextBoxCentro.Text),
                CInt(TextBoxSuministro.Text),
                CInt(TextBoxCantidad.Text)
            )

            MessageBox.Show("Stock añadido correctamente")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
