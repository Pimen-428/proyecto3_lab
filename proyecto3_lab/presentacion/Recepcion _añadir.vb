Public Class Recepcion__añadir

    Dim r As Recepcion
    Dim c As Centro_logistico
    Dim v As Voluntario

    Private Sub Recepcion_anadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrescarComboBoxCentro()
    End Sub

    Private Sub RefrescarComboBoxCentro()
        ComboBox1.DataSource = Nothing
        Me.c = New Centro_logistico
        Try
            Me.c.LeerTodosCentros()
            ComboBox1.DataSource = Me.c.CentroDAO.Centro
            ComboBox1.DisplayMember = "id"
            ComboBox1.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedValue IsNot Nothing AndAlso IsNumeric(ComboBox1.SelectedValue) Then
            RefrescarComboBoxVoluntario(ComboBox1.SelectedValue.ToString())
        End If
    End Sub

    Private Sub RefrescarComboBoxVoluntario(centro As String)
        ComboBox2.DataSource = Nothing
        Me.v = New Voluntario
        Try
            Me.v.LeerTodasPersonasdecentro(centro)
            ComboBox2.DataSource = Me.v.PerDAO.Personas
            ComboBox2.DisplayMember = "DNI"
            ComboBox2.ValueMember = "DNI"
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un centro.", "Dato incompleto")
            Exit Sub
        End If

        If ComboBox2.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un voluntario.", "Dato incompleto")
            Exit Sub
        End If

        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Introduzca el origen.", "Dato incompleto")
            Exit Sub
        End If

        Me.r = New Recepcion()
        Me.r.IdCentro = CInt(ComboBox1.SelectedValue)
        Me.r.DniVoluntario = ComboBox2.SelectedValue.ToString()
        Me.r.Fecha = DateTimePicker1.Value.Date
        Me.r.Origen = TextBox1.Text.Trim()

        Try
            If Me.r.InsertarRecepcion() > 0 Then
                MessageBox.Show("Recepción añadida con éxito.", "Éxito")
                Me.Hide()
            Else
                MessageBox.Show("No se pudo registrar la recepción.", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try

    End Sub

End Class