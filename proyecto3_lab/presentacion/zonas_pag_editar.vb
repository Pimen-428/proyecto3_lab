Public Class zonas_pag_editar
    Private zonaActual As zona_conflicto


    Public Sub zonaseleccionada(z As zona_conflicto)
        Me.zonaActual = z
        TextBoxNombreEditar.Text = z.nombre
        TextBoxPaisEditar.Text = z.pais
        NumericUpDown1.Text = z.nivel_urgencia.ToString()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click

        zonaActual.nombre = TextBoxNombreEditar.Text
        zonaActual.pais = TextBoxPaisEditar.Text


        zonaActual.nivel_urgencia = Convert.ToInt32(NumericUpDown1.Value)

        Try
            zonaActual.ActualizarZona()
            MessageBox.Show("Zona actualizada")

            ' Refrescar lista del padre
            Dim padre As Zonas_pag = DirectCast(Me.Parent.Parent, Zonas_pag)
            padre.refrescarlistbox()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If MessageBox.Show("¿Seguro que desea eliminar esta zona?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                zonaActual.BorrarZona()
                Dim padre As Zonas_pag = DirectCast(Me.Parent.Parent, Zonas_pag)
                padre.refrescarlistbox()
                Me.Parent.Controls.Clear()
            Catch ex As Exception
                MessageBox.Show("Error al borrar: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub zonas_pag_editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class