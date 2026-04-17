Public Class voluntarios_pag_añadir
    Private c As Centro_logistico
    Private Sub Añadir_boton_Click(sender As Object, e As EventArgs) Handles Añadir_boton.Click
        Dim pAux As Voluntario
        If TextBoxDni_añadir.Text = "" Or TextBoxNombre_añadir.Text = "" Or ComboBox_añadir.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim Dni As String = TextBoxDni_añadir.Text
        Dim Centro As Integer = Convert.ToInt16(ComboBox_añadir.Text)
        Dim nombre As String = TextBoxNombre_añadir.Text
        Dim especialidad As String = TextBoxEspecialidad_añadir.Text
        pAux = New Voluntario(Dni)
        pAux.centro = Centro
        pAux.Nombre = nombre
        pAux.especialidad = especialidad
        Try
            pAux.InsertarPersona()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Dim formularioPadre As Voluntarios_pag = DirectCast(Me.Parent.Parent, Voluntarios_pag)

        formularioPadre.refrescarlistbox()
        vaciarTextBox()

    End Sub

    Private Sub voluntarios_pag_añadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Me.ComboBox_añadir.Items.Add(pAux.id)
        Next
    End Sub
    Private Sub vaciarTextBox()
        TextBoxDni_añadir.Text = ""
        TextBoxEspecialidad_añadir.Text = ""
        TextBoxNombre_añadir.Text = ""
        ComboBox_añadir.Text = ""
    End Sub
End Class
