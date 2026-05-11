Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class voluntarios_pag_editar
    Private c As Centro_logistico
    Private v As Voluntario
    'funcion que se llama desde la ventana padre para rellenar los textos de los combobox
    Public Sub voluntarioseleccionado(ByVal v_recibido As Voluntario)
        v = v_recibido
        'estas combobobox no son dropdownlist por que daba problema al rellenarlas automaticamente, pero no da problemas con otras
        ComboBoxDni.Text = v.DNI.Trim
        TextBoxEspecialidadEditar.Text = v.especialidad
        TextBoxNombreEditar.Text = v.Nombre
        ComboBoxDniEditar.Text = v.centro.ToString.Trim
    End Sub
    'boton para eliminar el voluntario de la base de datos
    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim respuesta As DialogResult
        'comprobamos que id esta escrito
        If ComboBoxDni.Text = "" Then
            MessageBox.Show("Tienes que poner el DNI para poder eliminar al voluntario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres borrar este voluntario?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
        'creamos el voluntario con se dni cogido del combobox
        Dim pAux As Voluntario
        Dim Dni As String = ComboBoxDni.Text
        pAux = New Voluntario(Dni)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                'llamamos a la funcion de borrar dentro de voluntario
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
        'variamos las textbox y llamamos a la funcion del padre refrescarlistbox
        vaciarTextBox()
        Dim formularioPadre As Voluntarios_pag = DirectCast(Me.Parent.Parent, Voluntarios_pag)
        formularioPadre.refrescarlistbox()
        refrescarcomboboxdni()
    End Sub
    'boton para editar un voluntario
    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim respuesta As DialogResult
        'verificamos que todos los campos esten escritos
        If ComboBoxDni.Text = "" Or TextBoxNombreEditar.Text = "" Or ComboBoxDniEditar.Text = "" Or TextBoxEspecialidadEditar.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Dim Dni As String = ComboBoxDni.Text
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

                ' Aquí va el código si el usuario pulsa SÍ
                pAux.ActualizarPersona()
                MessageBox.Show("editado con éxito.")

            Else
                ' Aquí va el código (o nada) si el usuario pulsa NO
                MessageBox.Show("Operación cancelada.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
        End Try
        vaciarTextBox()
        Dim formularioPadre As Voluntarios_pag = DirectCast(Me.Parent.Parent, Voluntarios_pag)
        formularioPadre.refrescarlistbox()
    End Sub
    'esto se llama al cargar la pagina, solo llena las combobox con las opciones seleccionables
    Private Sub voluntarios_pag_editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarcombobox()
        refrescarcomboboxdni()
    End Sub
    'llena la combobox con los centros logisticos disponibles
    Public Sub refrescarcombobox()
        Me.ComboBoxDniEditar.Items.Clear()
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
    'llena la combobox de voluntarios con lso dnis de los voluntarios
    Public Sub refrescarcomboboxdni()
        Me.ComboBoxDni.Items.Clear()
        Dim pAux As Voluntario
        Me.v = New Voluntario
        Try
            Me.v.LeerTodasPersonas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.v.PerDAO.Personas
            Me.ComboBoxDni.Items.Add(pAux.DNI)
        Next
    End Sub
    'funcion para limpiar todas las combobox
    Private Sub vaciarTextBox()
        ComboBoxDni.Text = ""
        TextBoxEspecialidadEditar.Text = ""
        TextBoxNombreEditar.Text = ""
        ComboBoxDniEditar.Text = ""
    End Sub
End Class
