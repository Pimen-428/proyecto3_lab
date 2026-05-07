Public Class zonas_pag_añadir
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        ' 1. Verificamos que los campos de texto no estén vacíos
        If txt_nombre.Text = "" Or txt_pais.Text = "" Then
            MessageBox.Show("Faltan campos obligatorios (Nombre o País)", "Atención")
            Exit Sub
        End If

        ' 2. VALIDACIÓN DE NÚMERO 
        Dim urgencia As Integer
        ' Intentamos convertir el contenido de txt_urgencia
        If Not Integer.TryParse(txt_urgencia.Text, urgencia) Then
            ' Si el usuario escribió letras o dejó el texto por defecto, entramos aquí
            MessageBox.Show("Por favor, introduce un número válido para el Nivel de Urgencia.", "Error de Formato")
            txt_urgencia.Focus() ' Ponemos el cursor en el error para ayudar al usuario
            Exit Sub
        End If

        ' 3. Si todo está bien, creamos el objeto de dominio
        Dim nuevaZona As New zona_conflicto()
        nuevaZona.nombre = txt_nombre.Text
        nuevaZona.pais = txt_pais.Text
        nuevaZona.nivel_urgencia = urgencia ' Usamos la variable ya convertida

        Try
            ' 4. Intentamos insertar en la base de datos
            nuevaZona.InsertarZona()
            MessageBox.Show("Zona añadida correctamente")

            ' 5. Refrescamos la lista en la pantalla principal
            ' Hacemos el cast al padre para llamar a la función de refresco
            Dim padre As Zonas_pag = DirectCast(Me.Parent.Parent, Zonas_pag)
            padre.refrescarlistbox()

            ' 6. Limpiamos la vista actual para volver al listado
            Me.Parent.Controls.Clear()

        Catch ex As Exception
            ' Si el error viene de la base de datos (ej. ID duplicado si no fuera AI)
            MessageBox.Show("Error al insertar en la base de datos: " & ex.Message)
        End Try
    End Sub

    Private Sub zonas_pag_añadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class