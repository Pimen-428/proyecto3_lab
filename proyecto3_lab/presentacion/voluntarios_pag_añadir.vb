Public Class voluntarios_pag_añadir
    Private c As Centro_logistico
    ' el boton para añadir los voluntarios a la base de datos
    Private Sub Añadir_boton_Click(sender As Object, e As EventArgs) Handles Añadir_boton.Click
        Dim pAux As Voluntario
        'verificamos todos los parametros
        If TextBoxDni_añadir.Text = "" Or TextBoxNombre_añadir.Text = "" Or ComboBox_añadir.Text = "" Or TextBoxEspecialidad_añadir.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim Dni As String = TextBoxDni_añadir.Text
        Dim Centro As Integer = Convert.ToInt16(ComboBox_añadir.Text)
        Dim nombre As String = TextBoxNombre_añadir.Text
        Dim especialidad As String = TextBoxEspecialidad_añadir.Text
        'creamos el voluntario con los parametros de los textbox
        pAux = New Voluntario(Dni)
        pAux.centro = Centro
        pAux.Nombre = nombre
        pAux.especialidad = especialidad
        Try
            'insertamos el voluntario
            pAux.InsertarPersona()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Dim formularioPadre As Voluntarios_pag = DirectCast(Me.Parent.Parent, Voluntarios_pag)
        'refrescamos la listbox
        formularioPadre.refrescarlistbox()
        vaciarTextBox()

    End Sub
    ' al cargar la pagina se refresca la combobox
    Private Sub voluntarios_pag_añadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarcombobox()
    End Sub
    ' se llena la combobox con los centros logisticos disponibles para elegir y asi poder seleccionar entre ellos
    Private Sub refrescarcombobox()
        Me.ComboBox_añadir.Items.Clear()
        Dim pAux As Centro_logistico
        Me.c = New Centro_logistico
        Try
            Me.c.LeerTodosCentros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CentroDAO.Centro
            Me.ComboBox_añadir.Items.Add(pAux.id)
        Next
    End Sub
    'despues de incluir el volunario todos los textos se vacian
    Private Sub vaciarTextBox()
        TextBoxDni_añadir.Text = ""
        TextBoxEspecialidad_añadir.Text = ""
        TextBoxNombre_añadir.Text = ""
        ComboBox_añadir.SelectedIndex = -1
    End Sub

End Class
