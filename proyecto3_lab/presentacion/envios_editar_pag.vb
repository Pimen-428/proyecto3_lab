Public Class envios_editar_pag
    Dim e As Envio
    Private Sub envios_editar_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        comboboxestado()
        comboboxid()
    End Sub
    Public Sub refrescarlistbox()
        Dim pAux As Envio
        Me.e = New Envio
        Me.ListBoxenvios.Items.Clear()
        Try
            Me.e.LeerTodosEnvios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.e.EnvioDAO.Envio
            Me.ListBoxenvios.Items.Add("id: [" & pAux.id & "] " & pAux.id_origen & " ->" & pAux.id_destino)
        Next
    End Sub
    Public Sub comboboxestado()
        ComboBoxEstados.Items.Clear()
        ComboBoxEstados.Items.Add("preparandose")
        ComboBoxEstados.Items.Add("de camino")
        ComboBoxEstados.Items.Add("detenido en aduana")
        ComboBoxEstados.Items.Add("alcanzo su destino")
    End Sub
    Public Sub comboboxid()
        Me.ComboBoxEnvio.Items.Clear()
        Dim pAux As Envio
        Me.e = New Envio
        Try
            Me.e.LeerTodosEnvios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.e.EnvioDAO.Envio
            Me.ComboBoxEnvio.Items.Add(pAux.id)
        Next
    End Sub

    Private Sub ComboBoxEnvio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEnvio.SelectedIndexChanged
        If Me.ComboBoxEnvio IsNot Nothing Then
            ' Extraemos el ID del string "ID - Nombre"
            Dim texto As String = Me.ComboBoxEnvio.SelectedItem.ToString()
            Me.e = New Envio
            Me.e.id = texto
            Me.e.LeerEnvio()
            ComboBoxEstados.Text = Me.e.Estado
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Validaciones previas: Comprobar que hay selección
        If ComboBoxEnvio.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccione un ID de envío para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ComboBoxEstados.SelectedItem Is Nothing AndAlso String.IsNullOrEmpty(ComboBoxEstados.Text) Then
            MessageBox.Show("Debe seleccionar o escribir un estado válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Proceso de actualización con Control de Errores
        Try
            ' Usamos la instancia 'e' que ya tienes declarada a nivel de clase
            ' Si no, asegúrate de que el ID sea el correcto
            Me.e.id = Me.ComboBoxEnvio.SelectedItem.ToString()
            Me.e.Estado = Me.ComboBoxEstados.Text.ToString()

            ' Llamamos al método de actualización de tu clase de dominio
            ' Asumiendo que tu clase Envio tiene un método ActualizarEnvio() que llama al DAO
            Dim filasAfectadas As Integer = Me.e.ActualizarEstado()

            If filasAfectadas > 0 Then
                MessageBox.Show("Estado del envío " & Me.e.id & " actualizado a: " & Me.e.Estado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Throw New Exception("No se realizaron cambios en la base de datos. Verifique si el envío aún existe.")
            End If

        Catch ex As Exception
            ' CAPTURA DE ERRORES: Problemas de conexión, sintaxis SQL, etc.
            MessageBox.Show("Ocurrió un error al actualizar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
