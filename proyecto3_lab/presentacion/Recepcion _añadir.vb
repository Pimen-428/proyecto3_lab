Imports System.Linq.Expressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Mysqlx.Cursor

Public Class Recepcion__añadir
    Dim a As Almacenamiento
    Dim s As Suministro
    Dim r As Recepcion
    Dim c As Centro_logistico
    Dim v As Voluntario
    Dim ListaSuministros As Collection

    Private Sub Recepcion_anadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrescarComboBoxCentro()
        refrescar_lista_suministros()
    End Sub

    Private Sub RefrescarComboBoxCentro()
        Me.ComboBox1.Items.Clear()
        Dim pAux As Centro_logistico
        Me.c = New Centro_logistico
        Try
            Me.c.LeerTodosCentros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CentroDAO.Centro
            Me.ComboBox1.Items.Add(pAux.id)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1 IsNot Nothing Then
            ' Extraemos el ID del string "ID - Nombre"
            Dim texto As String = Me.ComboBox1.SelectedItem.ToString()
            LimpiarTodoMenosOrigen()
            RefrescarComboBoxVoluntario(texto)
            ConfigurarGrid()
        End If
    End Sub

    Private Sub RefrescarComboBoxVoluntario(centro As String)
        Me.ComboBox2.Items.Clear()
        Dim pAux As Voluntario
        Me.v = New Voluntario
        Try
            Me.v.LeerTodasPersonasdecentro(centro)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.v.PerDAO.Personas
            Me.ComboBox2.Items.Add(pAux.DNI)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim envioañadido As Boolean = False
        Dim Aux As Recepcion = New Recepcion()
        Dim Entregados As Integer = 0
        Try

            ' control de errores
            If ComboBox1.SelectedItem Is Nothing Then
                Throw New Exception("Debe seleccionar un centro de destino.")
            End If

            If ComboBox2.SelectedItem Is Nothing Then
                Throw New Exception("Debe asignar un voluntario al envío.")
            End If
            If TextBox1.Text = "" Then
                Throw New Exception("se debe poner un origen")
            End If
            ' capturamos datos de la cabecera
            Dim idDestino As String = ComboBox1.SelectedItem.ToString()
            Dim fechaEnvio As Date = DateTimePicker1.Value.Date
            Dim dnivoluntario As String = ComboBox2.SelectedItem.ToString()
            Dim origen As String = TextBox1.Text
            If DataGridView1.Rows.Count = 0 OrElse (DataGridView1.Rows.Count = 1 And DataGridView1.Rows(0).IsNewRow) Then
                Throw New Exception("El envío debe tener al menos un suministro.")
            End If
            'metemos los datos en la variable auxiliar que es el envio
            Aux.IdCentro = idDestino
            Aux.DniVoluntario = dnivoluntario
            Aux.fecha = fechaEnvio
            Aux.Origen = origen
            Aux.InsertarRecepcion()
            envioañadido = True
            Dim colUltimo As Collection = Aux.UltimoEnvio()
            If colUltimo IsNot Nothing AndAlso colUltimo.Count > 0 Then
                Dim fila As Collection = colUltimo(1)
                Aux.IdRecepcion = CInt(fila(1))
            End If
            ' en esta funcion recorremos todos las columnas del datagridview y las añadimosa detalle envio y añadimos stock
            For Each fila As DataGridViewRow In DataGridView1.Rows
                ' Saltamos la fila nueva vacía
                If fila.IsNewRow Then Continue For

                ' Validamos que el usuario haya seleccionado un suministro
                If fila.Cells("suministro").Value Is Nothing Then
                    Throw New Exception("Hay una fila sin suministro seleccionado.")
                End If

                ' Creamos el objeto Detalle
                Dim detalle As New DetalleRecepcion()
                detalle.IdRecepcion = Aux.IdRecepcion

                ' Obtenemos el ID del suministro gracias al ValueMember del ComboBoxColumn
                Dim suministroseleccionado = CInt(fila.Cells("suministro").Value)
                detalle.IdSuministro = suministroseleccionado

                ' Validamos y capturamos la cantidad
                Dim cant As Integer
                If Not Integer.TryParse(fila.Cells("Cantidad").Value?.ToString(), cant) OrElse cant <= 0 Then
                    Throw New Exception("La cantidad debe ser un número entero mayor a 0.")
                End If
                detalle.Cantidad = cant
                'aqui hacemos todas las comprobaciones para ver si supera el peso del centro de destino o no
                Dim centrodestino = New Centro_logistico(idDestino)
                centrodestino.LeerCentro()
                Dim almacenamientocentrodestino = centrodestino.capacidad * 1000
                Dim almacenamientodestino = New Almacenamiento()
                almacenamientodestino.IdCentro = idDestino
                Dim ocupadoactualldestino = almacenamientodestino.ObtenerStockTotalKilos()
                Dim suministroactual = New Suministro(suministroseleccionado)
                suministroactual.obtenersuministro()
                Dim pesocantidad = suministroactual.PesoUnitario * cant
                'acaba comprobacion de peso
                If (ocupadoactualldestino + pesocantidad > almacenamientocentrodestino) Then
                    Throw New Exception("Error La capacidad del centro : " & idDestino & " es " & almacenamientocentrodestino & " kilos, no se puede superar esa capacidad")
                End If

                detalle.InsertarDetalle()
                'sumamos el stock al centro correspondiente despues de comprobar que el peso estaba bien
                almacenamientodestino.IdCentro = idDestino
                almacenamientodestino.IdSuministro = suministroseleccionado
                almacenamientodestino.CantidadStock = cant
                almacenamientodestino.SumarStock()

                Entregados = Entregados + 1
            Next

            MessageBox.Show("Envío procesado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarTodo()
            RefrescarComboBoxCentro()
        Catch ex As Exception
            ' si salta algun error aqui se captura 
            MessageBox.Show(ex.Message, "Error al confirmar envío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If envioañadido Then
                ' Usamos un bucle for normal para controlar el índice hasta 'Entregados'
                For i As Integer = 0 To Entregados - 1
                    Dim fila As DataGridViewRow = DataGridView1.Rows(i)

                    ' Extraemos los datos necesarios para reponer el stock
                    Dim idSuministro As Integer = CInt(fila.Cells("suministro").Value)
                    Dim cantidadAReponer As Integer = CInt(fila.Cells("Cantidad").Value)

                    ' Instanciamos Almacenamiento para devolver el stock
                    Dim alm As New Almacenamiento()
                    alm.IdCentro = Aux.IdCentro
                    alm.IdSuministro = idSuministro
                    alm.CantidadStock = cantidadAReponer ' La cantidad que restamos antes
                    'restamos el stock al centro al que se le quitamos
                    alm.RestarStock()
                Next
                Aux.EliminarRecepcion()
            End If
        End Try
    End Sub
    Public Sub LimpiarTodo()
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        TextBox1.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Public Sub LimpiarTodoMenosOrigen()
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        TextBox1.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Public Sub refrescar_lista_suministros()
        Dim suministro = New Suministro()
        suministro.LeerTodosSuministros()
        ListaSuministros = suministro.suDAO.Suministros
    End Sub
    Private Sub ConfigurarGrid()
        Me.DataGridView1.Columns.Clear()
        If Me.ListaSuministros Is Nothing OrElse Me.ListaSuministros.Count = 0 Then
            MessageBox.Show("Este centro no tiene suministros disponibles.")
            Exit Sub
        End If

        ' primera columna de ComboBox para Suministros
        Dim colCombo As New DataGridViewComboBoxColumn()
        colCombo.Name = "suministro"
        colCombo.HeaderText = "Suministro"
        ' Aquí cargamos los suministros 
        colCombo.DataSource = Me.listaSuministros
        colCombo.DisplayMember = "Descripcion"
        colCombo.ValueMember = "id_suministro"
        Me.DataGridView1.Columns.Add(colCombo)

        ' segunda columna para la Cantidad
        Dim colCant As New DataGridViewTextBoxColumn()
        colCant.Name = "Cantidad"
        colCant.HeaderText = "Cantidad a Enviar"
        Me.DataGridView1.Columns.Add(colCant)
    End Sub
End Class