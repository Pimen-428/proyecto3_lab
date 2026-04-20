Public Class zonas_pag_editar
    Private zonaActual As zona_conflicto


    Public Sub zonaseleccionada(z As zona_conflicto)
        Me.zonaActual = z
        txt_nombre.Text = z.nombre
        txt_pais.Text = z.pais
        txt_urgencia.Text = z.nivel_urgencia.ToString()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        zonaActual.nombre = txt_nombre.Text
        zonaActual.pais = txt_pais.Text
        zonaActual.nivel_urgencia = Convert.ToInt32(txt_urgencia.Text)

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles txt_nombre.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles txt_pais.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles txt_urgencia.Click

    End Sub
End Class