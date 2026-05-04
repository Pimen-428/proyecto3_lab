Public Class Almacenamiento_pag_editar

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click

        Try
            Dim dao As New AlmacenamientoDAO()

            dao.RestarStock(
                CInt(TextBoxCentro.Text),
                CInt(TextBoxSuministro.Text),
                CInt(TextBoxCantidad.Text)
            )

            MessageBox.Show("Stock actualizado correctamente")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
