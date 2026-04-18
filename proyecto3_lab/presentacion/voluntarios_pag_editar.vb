Public Class voluntarios_pag_editar
    Private c As Centro_logistico
    Private v As Voluntario
    Public Sub voluntarioseleccionado(ByVal v_recibido As Voluntario)
        v = v_recibido
        TextBoxDniEditar.Text = v.DNI
        TextBoxEspecialidadEditar.Text = v.especialidad
        TextBoxNombreEditar.Text = v.Nombre
        ComboBoxDniEditar.Text = v.centro
    End Sub
    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim respuesta As DialogResult
        If TextBoxDniEditar.Text = "" Then
            MessageBox.Show("Tienes que poner el DNI para poder eliminar al voluntario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres borrar este voluntario?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)

        Dim pAux As Voluntario
        Dim Dni As String = TextBoxDniEditar.Text
        pAux = New Voluntario(Dni)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                pAux.BorrarPersona()
                MessageBox.Show("Borrado con éxito.")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        Else
                ' Aquí va el código (o nada) si el usuario pulsa NO
                MessageBox.Show("Operación cancelada.")
        End If
        vaciarTextBox()
        Dim formularioPadre As Voluntarios_pag = DirectCast(Me.Parent.Parent, Voluntarios_pag)
        formularioPadre.refrescarlistbox()
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim respuesta As DialogResult
        If TextBoxDniEditar.Text = "" Or TextBoxNombreEditar.Text = "" Or ComboBoxDniEditar.Text = "" Or TextBoxEspecialidadEditar.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim Dni As String = TextBoxDniEditar.Text
        Dim Centro As Integer = Convert.ToInt16(ComboBoxDniEditar.Text)
        Dim nombre As String = TextBoxNombreEditar.Text
        Dim especialidad As String = TextBoxEspecialidadEditar.Text
        Dim pAux As Voluntario
        pAux = New Voluntario(Dni)
        pAux.centro = Centro
        pAux.Nombre = nombre
        pAux.especialidad = especialidad
        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres editar este voluntario?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                pAux.ActualizarPersona()
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
        Dim formularioPadre As Voluntarios_pag = DirectCast(Me.Parent.Parent, Voluntarios_pag)
        formularioPadre.refrescarlistbox()
    End Sub

    Private Sub voluntarios_pag_editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarcombobox()
    End Sub
    Private Sub refrescarcombobox()
        Dim pAux As Centro_logistico
        Me.c = New Centro_logistico
        Try
            Me.c.LeerTodosCentros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CentroDAO.Centro
            Me.ComboBoxDniEditar.Items.Add(pAux.id)
        Next
    End Sub
    Private Sub vaciarTextBox()
        TextBoxDniEditar.Text = ""
        TextBoxEspecialidadEditar.Text = ""
        TextBoxNombreEditar.Text = ""
        ComboBoxDniEditar.Text = ""
    End Sub
End Class
