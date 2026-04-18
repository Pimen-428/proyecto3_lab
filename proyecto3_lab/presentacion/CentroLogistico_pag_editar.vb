Public Class CentroLogistico_pag_editar
    Private c As Centro_logistico
    Friend Sub centroseleccionado(seleccionado As Centro_logistico)
        c = seleccionado
        TextBoxid.Text = c.id
        TextBoxnombre.Text = c.nombre_centro
        TextBoxCiudad.Text = c.ciudad_centro
        TextBoxAlmacenamiento.Text = c.capacidad
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim respuesta As DialogResult
        If TextBoxAlmacenamiento.Text = "" Or TextBoxCiudad.Text = "" Or TextBoxid.Text = "" Or TextBoxnombre.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim id As String = TextBoxid.Text
        Dim nombre As String = TextBoxnombre.Text
        Dim capacidad As String = TextBoxAlmacenamiento.Text
        Dim ciudad As String = TextBoxCiudad.Text
        Dim pAux As Centro_logistico
        pAux = New Centro_logistico()
        pAux.id = id
        pAux.nombre_centro = nombre
        pAux.capacidad = capacidad
        pAux.ciudad_centro = ciudad
        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres borrarr este voluntario?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                pAux.BorrarCentro()
                MessageBox.Show("borrado con éxito.")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        Else
            ' Aquí va el código (o nada) si el usuario pulsa NO
            MessageBox.Show("Operación cancelada.")
        End If
        vaciarTextBox()
        Dim formularioPadre As CentroLogistico_pag = DirectCast(Me.Parent.Parent, CentroLogistico_pag)
        formularioPadre.refrescarlistbox()
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim respuesta As DialogResult
        If TextBoxAlmacenamiento.Text = "" Or TextBoxCiudad.Text = "" Or TextBoxid.Text = "" Or TextBoxnombre.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Convert.ToDouble(TextBoxAlmacenamiento)
        Catch ex As Exception
            MessageBox.Show("La capacidad tiene que ser un numero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try
        Dim id As String = TextBoxid.Text
        Dim nombre As String = TextBoxnombre.Text
        Dim capacidad As String = TextBoxAlmacenamiento.Text
        Dim ciudad As String = TextBoxCiudad.Text
        Dim pAux As Centro_logistico
        pAux = New Centro_logistico()
        pAux.id = id
        pAux.nombre_centro = nombre
        pAux.capacidad = capacidad
        pAux.ciudad_centro = ciudad
        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres editar este voluntario?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                pAux.ActualizarCentro()
                MessageBox.Show("editado con éxito.")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        Else
            ' Aquí va el código (o nada) si el usuario pulsa NO
            MessageBox.Show("Operación cancelada.")
        End If
        vaciarTextBox()
        Dim formularioPadre As CentroLogistico_pag = DirectCast(Me.Parent.Parent, CentroLogistico_pag)
        formularioPadre.refrescarlistbox()
    End Sub
    Public Sub vaciarTextBox()
        TextBoxid.Text = ""
        TextBoxnombre.Text = ""
        TextBoxAlmacenamiento.Text = ""
        TextBoxCiudad.Text = ""
    End Sub
End Class
