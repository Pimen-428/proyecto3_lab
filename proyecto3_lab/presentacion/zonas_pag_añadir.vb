Public Class zonas_pag_añadir
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        If txt_nombre.Text = "" Or txt_pais.Text = "" Then
            MessageBox.Show("Faltan campos obligatorios", "Atención")
            Exit Sub
        End If

        Dim nuevaZona As New zona_conflicto()
        nuevaZona.nombre = txt_nombre.Text
        nuevaZona.pais = txt_pais.Text
        nuevaZona.nivel_urgencia = Convert.ToInt32(txt_urgencia.Text)

        Try
            nuevaZona.InsertarZona()
            MessageBox.Show("Zona añadida correctamente")


            Dim padre As Zonas_pag = DirectCast(Me.Parent.Parent, Zonas_pag)
            padre.refrescarlistbox()


            Me.Parent.Controls.Clear()
        Catch ex As Exception
            MessageBox.Show("Error al insertar: " & ex.Message)
        End Try
    End Sub

    Private Sub zonas_pag_añadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class