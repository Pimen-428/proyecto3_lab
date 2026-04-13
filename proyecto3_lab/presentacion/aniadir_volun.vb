Public Class aniadir_volun
    Private Sub boton_volver_Click(sender As Object, e As EventArgs) Handles boton_volver.Click
        Dim ventana_volver As New voluntarios()
        ventana_volver.Show()
        Me.Hide()
    End Sub
    Private Sub boton_aniadir_Click(sender As Object, e As EventArgs) Handles aniadir_boton.Click
        Try
            ' 1. Creamos el objeto Voluntario con los datos de los cuadros de texto
            ' (Asumo que tu clase Voluntario tiene un constructor que recibe el DNI)
            Dim nuevoVoluntario As New Voluntario(DNItext.Text)
            nuevoVoluntario.Nombre = Nombretext.Text
            nuevoVoluntario.especialidad = Especialidadtext.Text
            nuevoVoluntario.centro = Centrotext.Text ' O el ID del centro
            ' 2. Usamos el DAO para insertarlo
            Dim vDAO As New voluntarioDAO()
            Dim filasAfectadas As Integer = vDAO.Insertar(nuevoVoluntario)
            ' 3. Comprobamos si se insertó (si es > 0, es que tuvo éxito)
            If filasAfectadas > 0 Then
                MsgBox("¡Voluntario añadido correctamente!")
                Nombretext.Text = ""
                Especialidadtext.Text = ""
                Centrotext.Text = ""
                DNItext.Text = ""
            Else
                MsgBox("No se pudo insertar el registro.")

            End If
        Catch ex As Exception
            MsgBox("Error al guardar: " & ex.Message)
        End Try

    End Sub

End Class