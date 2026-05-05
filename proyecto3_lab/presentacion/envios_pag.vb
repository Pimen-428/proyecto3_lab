Public Class envios_pag

    Dim c As Centro_logistico
    Dim v As Voluntario
    Dim s As Suministro
    Dim ListaSuministros As Collection
    Private Sub refrescarcomboboxcentro1()
        Me.ComboBoxOrigen.Items.Clear()
        Dim pAux As Centro_logistico
        Me.c = New Centro_logistico
        Try
            Me.c.LeerTodosCentros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CentroDAO.Centro
            Me.ComboBoxOrigen.Items.Add(pAux.id)
        Next
    End Sub
    Private Sub refrescarcomboboxcentro2()
        Me.ComboBoxDestino.Items.Clear()
        Dim pAux As Centro_logistico
        Me.c = New Centro_logistico
        Try
            Me.c.LeerTodosCentros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CentroDAO.Centro
            If ComboBoxOrigen.SelectedItem.ToString() <> pAux.id.ToString() Then
                Me.ComboBoxDestino.Items.Add(pAux.id)
            End If
        Next
    End Sub
    Public Sub LimpiarTodo()
        ComboBoxOrigen.Text = ""
        ComboBoxOrigen.Items.Clear()
        ComboBoxDestino.Text = ""
        ComboBoxDestino.Items.Clear()
        ComboBoxVoluntarios.Text = ""
        ComboBoxVoluntarios.Items.Clear()
        DataGridView.Rows.Clear()
    End Sub
    Public Sub LimpiarTodoMenosOrigen()
        ComboBoxDestino.Text = ""
        ComboBoxDestino.Items.Clear()
        ComboBoxVoluntarios.Text = ""
        ComboBoxVoluntarios.Items.Clear()
        DataGridView.Rows.Clear()
    End Sub
    Private Sub refrescarcomboboxvolunatios()
        Me.ComboBoxVoluntarios.Items.Clear()
        Dim pAux As Voluntario
        Me.v = New Voluntario
        Try
            Me.v.LeerTodasPersonas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.v.PerDAO.Personas
            Me.ComboBoxVoluntarios.Items.Add(pAux.DNI)
        Next
    End Sub
    Private Sub refrescarcomboboxvolunatiosfromcentro(centro As String)
        Me.ComboBoxVoluntarios.Items.Clear()
        Me.v = New Voluntario
        Try
            Me.v.LeerTodasPersonasdecentro(centro)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.v.PerDAO.Personas
            Me.ComboBoxVoluntarios.Items.Add(pAux.DNI)
        Next
    End Sub
    Private Sub envios_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarcomboboxcentro1()
    End Sub

    Private Sub ComboBoxOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOrigen.SelectedIndexChanged
        If Me.ComboBoxOrigen IsNot Nothing Then
            ' Extraemos el ID del string "ID - Nombre"
            Dim texto As String = Me.ComboBoxOrigen.SelectedItem.ToString()
            LimpiarTodoMenosOrigen()
            refrescarcomboboxvolunatiosfromcentro(texto)
            s = New Suministro
            ListaSuministros = Me.s.SuministrosCentro(texto)
            refrescarcomboboxcentro2()
            ConfigurarGrid()
        End If
    End Sub

    Private Sub ButtonConfirmar_Click(sender As Object, e As EventArgs) Handles ButtonConfirmar.Click
        Dim envioañadido As Boolean = False
        Dim Aux As Envio = New Envio()
        Dim Entregados As Integer = 0
        Try

            ' 1. VALIDACIONES PREVIAS
            If ComboBoxOrigen.SelectedItem Is Nothing OrElse ComboBoxDestino.SelectedItem Is Nothing Then
                Throw New Exception("Debe seleccionar un centro de origen y uno de destino.")
            End If

            If ComboBoxVoluntarios.SelectedItem Is Nothing Then
                Throw New Exception("Debe asignar un voluntario al envío.")
            End If

            ' 2. CAPTURA DE DATOS DE CABECERA
            Dim idOrigen As String = ComboBoxOrigen.SelectedItem.ToString()
            Dim idDestino As String = ComboBoxDestino.SelectedItem.ToString()
            Dim fechaEnvio As Date = fecha.Value.Date ' Asumiendo que es un DateTimePicker
            Dim dnivoluntario As String = ComboBoxVoluntarios.SelectedItem.ToString()

            If DataGridView.Rows.Count = 0 OrElse (DataGridView.Rows.Count = 1 And DataGridView.Rows(0).IsNewRow) Then
                Throw New Exception("El envío debe tener al menos un suministro.")
            End If

            Aux.id_destino = idDestino
            Aux.id_origen = idOrigen
            Aux.dni_voluntario = dnivoluntario
            Aux.fecha = fechaEnvio
            Aux.Estado = "preparandose"

            Aux.InsertarEnvio()
            envioañadido = True
            Dim colUltimo As Collection = Aux.UltimoEnvio()
            If colUltimo IsNot Nothing AndAlso colUltimo.Count > 0 Then
                Dim fila As Collection = colUltimo(1)
                Aux.id = CInt(fila(1))
            End If
            For Each fila As DataGridViewRow In DataGridView.Rows
                ' Saltamos la fila nueva vacía
                If fila.IsNewRow Then Continue For

                ' Validamos que el usuario haya seleccionado un suministro
                If fila.Cells("suministro").Value Is Nothing Then
                    Throw New Exception("Hay una fila sin suministro seleccionado.")
                End If

                ' Creamos el objeto Detalle
                Dim detalle As New detalle_envio()
                detalle.id_envio = Aux.id

                ' Obtenemos el ID del suministro gracias al ValueMember del ComboBoxColumn
                detalle.id_suministro = CInt(fila.Cells("suministro").Value)

                ' Validamos y capturamos la cantidad
                Dim cant As Integer
                If Not Integer.TryParse(fila.Cells("Cantidad").Value?.ToString(), cant) OrElse cant <= 0 Then
                    Throw New Exception("La cantidad debe ser un número entero mayor a 0.")
                End If
                detalle.cantidad = cant

                ' Insertamos el detalle y restamos el stock (Lógica de tu Dominio)
                ' Si falla la actualización de stock, devolvemos 0 y lanzamos excepción
                If detalle.InsertarDetalleYRestarStock(Aux.id_origen) = 0 Then
                    Throw New Exception("Error al procesar el suministro ID: " & detalle.id_suministro & ". Verifique stock.")
                End If
                Entregados = Entregados + 1
            Next

            MessageBox.Show("Envío procesado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarTodo()

        Catch ex As Exception
            ' CAPTURA DE CUALQUIER ERROR (Validación o Base de Datos)
            MessageBox.Show(ex.Message, "Error al confirmar envío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If envioañadido Then
                ' Usamos un bucle for normal para controlar el índice hasta 'Entregados'
                For i As Integer = 0 To Entregados - 1
                    Dim fila As DataGridViewRow = DataGridView.Rows(i)

                    ' Extraemos los datos necesarios para reponer el stock
                    Dim idSuministro As Integer = CInt(fila.Cells("suministro").Value)
                    Dim cantidadAReponer As Integer = CInt(fila.Cells("Cantidad").Value)

                    ' Instanciamos Almacenamiento para devolver el stock
                    Dim alm As New Almacenamiento()
                    alm.IdCentro = Aux.id_origen
                    alm.IdSuministro = idSuministro
                    alm.CantidadStock = cantidadAReponer ' La cantidad que restamos antes

                    ' Llamamos a SumarStock (que ya tienes definido en tu Almacenamiento)
                    alm.SumarStock()
                Next
                Aux.EliminarEnvio()
            End If
        End Try
    End Sub
    Private Sub ConfigurarGrid()
        Me.DataGridView.Columns.Clear()
        If Me.ListaSuministros Is Nothing OrElse Me.ListaSuministros.Count = 0 Then
            MessageBox.Show("Este centro no tiene suministros disponibles.")
            Exit Sub
        End If

        ' 1. Columna de ComboBox para Suministros
        Dim colCombo As New DataGridViewComboBoxColumn()
        colCombo.Name = "suministro"
        colCombo.HeaderText = "Suministro"
        ' Aquí cargamos los suministros (los 100 que insertamos antes)
        ' Suponiendo que tienes una lista de suministros en Me.listaSuministros
        colCombo.DataSource = Me.listaSuministros
        colCombo.DisplayMember = "Descripcion"
        colCombo.ValueMember = "id_suministro"
        Me.DataGridView.Columns.Add(colCombo)

        ' 2. Columna para la Cantidad
        Dim colCant As New DataGridViewTextBoxColumn()
        colCant.Name = "Cantidad"
        colCant.HeaderText = "Cantidad a Enviar"
        Me.DataGridView.Columns.Add(colCant)
    End Sub
End Class
