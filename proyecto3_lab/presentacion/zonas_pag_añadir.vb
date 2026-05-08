Public Class zonas_pag_añadir
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click


        If String.IsNullOrWhiteSpace(txt_nombre.Text) Then
            MessageBox.Show("El nombre de la zona es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_nombre.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txt_pais.Text) Then
            MessageBox.Show("El país es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_pais.Focus()
            Exit Sub
        End If

        Dim urgencia As Integer
        If Not Integer.TryParse(txt_urgencia.Text, urgencia) Then
            MessageBox.Show("Por favor, introduce un número válido para el Nivel de Urgencia.", "Error de Formato")
            txt_urgencia.Focus()
            Exit Sub
        End If


        Dim nuevaZona As New zona_conflicto()
        nuevaZona.nombre = txt_nombre.Text.Trim() ' Guardamos sin espacios extra
        nuevaZona.pais = txt_pais.Text.Trim()
        nuevaZona.nivel_urgencia = urgencia

        Try
            nuevaZona.InsertarZona()
            MessageBox.Show("Zona añadida correctamente", "Éxito")


            Dim padre As Zonas_pag = DirectCast(Me.Parent.Parent, Zonas_pag)
            padre.refrescarlistbox()
            Me.Parent.Controls.Clear()

        Catch ex As Exception
            MessageBox.Show("Error al insertar en la base de datos: " & ex.Message, "Error Crítico")
        End Try
    End Sub
End Class