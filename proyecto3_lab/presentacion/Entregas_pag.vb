Public Class Entregas_pag

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles CentroOrigen.Click

    End Sub

    Private Sub EntregasP_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarcomboboxcentro1()
    End Sub

    Dim z As zona_conflicto
    Dim c As Centro_logistico
    Dim v As Voluntario
    Dim s As Suministro
    Dim ListaSuministros As Collection
    Private Sub refrescarcomboboxcentro1()
        Me.ComboBoxOrigen.DataSource = Nothing ' Limpiamos
        Me.c = New Centro_logistico
        Try
            Me.c.LeerTodosCentros()
            ' SUSTITUCIÓN CRÍTICA: En lugar de For Each, usamos DataSource
            Me.ComboBoxOrigen.DataSource = Me.c.CentroDAO.Centro
            Me.ComboBoxOrigen.DisplayMember = "id" ' Lo que el usuario ve
            Me.ComboBoxOrigen.ValueMember = "id"   ' El valor interno que leerá el botón
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub refrescarcomboboxzona()
        Me.ComboBoxDestino.DataSource = Nothing
        Me.z = New zona_conflicto
        Try
            Me.z.LeerTodasZonas()
            ' SUSTITUCIÓN CRÍTICA:
            Me.ComboBoxDestino.DataSource = Me.z.ZonaDAO.Zonas
            Me.ComboBoxDestino.DisplayMember = "id"
            Me.ComboBoxDestino.ValueMember = "id" ' Según tu esquema idZona
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Public Sub LimpiarTodo()

        ComboBoxOrigen.DataSource = Nothing
        ComboBoxOrigen.Text = ""

        ComboBoxDestino.DataSource = Nothing
        ComboBoxDestino.Text = ""

        ComboBoxVoluntarios.DataSource = Nothing
        ComboBoxVoluntarios.Text = ""

        DataGridView.Rows.Clear()
    End Sub
    Public Sub LimpiarTodoMenosOrigen()

        ComboBoxDestino.DataSource = Nothing
        ComboBoxDestino.Text = ""

        ComboBoxVoluntarios.DataSource = Nothing
        ComboBoxVoluntarios.Text = ""

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
        Me.ComboBoxVoluntarios.DataSource = Nothing
        Me.v = New Voluntario
        Try
            Me.v.LeerTodasPersonasdecentro(centro)
            ' SUSTITUCIÓN CRÍTICA:
            Me.ComboBoxVoluntarios.DataSource = Me.v.PerDAO.Personas
            Me.ComboBoxVoluntarios.DisplayMember = "DNI"
            Me.ComboBoxVoluntarios.ValueMember = "DNI" ' El DNI es la PK del voluntario
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub ComboBoxOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOrigen.SelectedIndexChanged
        ' Verificamos que haya una selección válida y que sea un objeto de datos
        If ComboBoxOrigen.SelectedValue IsNot Nothing AndAlso IsNumeric(ComboBoxOrigen.SelectedValue) Then
            Dim texto As String = ComboBoxOrigen.SelectedValue.ToString()

            LimpiarTodoMenosOrigen()
            refrescarcomboboxvolunatiosfromcentro(texto)

            s = New Suministro
            ListaSuministros = Me.s.SuministrosCentro(texto)
            refrescarcomboboxzona()
            ConfigurarGrid()
        End If
    End Sub

    Private Sub ButtonConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        Dim envioañadido As Boolean = False
        Dim Aux As entrega = New entrega()

        Try
            ' 1. VALIDACIONES DE SELECCIÓN (Esto evita el error 'SelectedValue devolvió Nothing')
            If ComboBoxOrigen.SelectedValue Is Nothing Then
                MessageBox.Show("Por favor, seleccione un Centro de Origen.", "Dato incompleto")
                Exit Sub
            End If

            If ComboBoxDestino.SelectedValue Is Nothing Then
                MessageBox.Show("Por favor, seleccione una Zona de Destino.", "Dato incompleto")
                Exit Sub
            End If

            If ComboBoxVoluntarios.SelectedValue Is Nothing Then
                MessageBox.Show("Por favor, seleccione un Voluntario.", "Dato incompleto")
                Exit Sub
            End If

            If DataGridView.Rows.Count = 0 OrElse (DataGridView.Rows.Count = 1 And DataGridView.Rows(0).IsNewRow) Then
                MessageBox.Show("La entrega debe tener al menos un suministro.", "Dato incompleto")
                Exit Sub
            End If
            ' Control de errores
            Dim idCentro As Integer = CInt(ComboBoxOrigen.SelectedValue)

            For Each fila As DataGridViewRow In DataGridView.Rows
                If fila.IsNewRow Then Continue For


                Dim idSumi As Integer = CInt(fila.Cells("suministro").Value)
                Dim cantPedida As Integer = 0
                Integer.TryParse(fila.Cells("Cantidad").Value?.ToString(), cantPedida)


                Dim prod As New Suministro(idSumi)
                Dim validacion As String = prod.ValidarEntrega(idCentro, cantPedida)


                If validacion <> "OK" Then
                    MessageBox.Show(validacion, "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next
            ' ---

            ' 2. ASIGNACIÓN DE DATOS A LA CABECERA
            ' Usamos CInt porque los IDs son números enteros en tu esquema
            Aux.id_centro_origen = CInt(ComboBoxOrigen.SelectedValue)
            Aux.id_zona_destino = CInt(ComboBoxDestino.SelectedValue)
            Aux.dni_voluntario = ComboBoxVoluntarios.SelectedValue.ToString()
            Aux.fecha = fecha.Value.Date

            ' 3. GENERAR EL ID Y GUARDAR EL PADRE (Importante para la Foreign Key)
            Aux.GenerarNuevoID()

            If Aux.InsertarEntrega() > 0 Then
                envioañadido = True
            Else
                Throw New Exception("Error crítico: No se pudo registrar la cabecera de la entrega.")
            End If

            ' 4. PROCESAR CADA SUMINISTRO EN EL GRID
            For Each fila As DataGridViewRow In DataGridView.Rows
                If fila.IsNewRow Then Continue For

                Dim detalle As New detalle_entrega()
                detalle.id_entrega = Aux.id ' Le pasamos el ID que acabamos de generar

                ' Validamos que la celda del suministro tenga valor
                If fila.Cells("suministro").Value Is Nothing Then Continue For
                detalle.id_suministro = CInt(fila.Cells("suministro").Value)

                ' Capturamos cantidad
                Dim cant As Integer
                If Not Integer.TryParse(fila.Cells("Cantidad").Value?.ToString(), cant) Then
                    cant = 0
                End If
                detalle.cantidad = cant

                ' 5. GUARDAR DETALLE Y ACTUALIZAR STOCK EN ORIGEN
                ' Solo restamos en el origen porque las zonas de conflicto no tienen stock
                If detalle.InsertarDetalleYRestarStock(Aux.id_centro_origen) = 0 Then
                    Throw New Exception("Fallo al insertar detalle o stock insuficiente para ID: " & detalle.id_suministro)
                End If
            Next

            MessageBox.Show("¡Entrega confirmada con éxito!", "Éxito")
            LimpiarTodo()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error al procesar")
            ' Si la cabecera se guardó pero falló un detalle, borramos la cabecera (rollback manual)
            If envioañadido Then Aux.EliminarEntrega()
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
        colCombo.DataSource = Me.ListaSuministros
        colCombo.DisplayMember = "Descripcion"
        colCombo.ValueMember = "id_suministro"
        Me.DataGridView.Columns.Add(colCombo)

        ' 2. Columna para la Cantidad
        Dim colCant As New DataGridViewTextBoxColumn()
        colCant.Name = "Cantidad"
        colCant.HeaderText = "Cantidad a Enviar"
        Me.DataGridView.Columns.Add(colCant)
    End Sub

    Private Sub Panel_editar_Paint(sender As Object, e As PaintEventArgs) Handles Panel_editar.Paint

    End Sub
End Class
