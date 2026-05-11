Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CentroLogistico_pag_editar
    Private c As Centro_logistico
    'funcion para rellenar todos los textbox con el texto recibido en la ventana padre
    Friend Sub centroseleccionado(seleccionado As Centro_logistico)
        c = seleccionado
        ComboBoxId.Text = c.id
        TextBoxnombre.Text = c.nombre_centro
        TextBoxCiudad.Text = c.ciudad_centro
        TextBoxAlmacenamiento.Text = c.capacidad
    End Sub
    'boton para eliminar el centro logistico
    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim respuesta As DialogResult
        'comprobamos el combobox para ver que el centro que queremos eliminiar esta ahi
        If ComboBoxId.Text = "" Then
            MessageBox.Show("Tienes que indicar la Id del centro que quieres eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Dim id As String = ComboBoxId.Text
            Dim pAux As Centro_logistico
            pAux = New Centro_logistico()
            pAux.id = id
            ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
            respuesta = MessageBox.Show("¿Estás seguro de que quieres borrarr este voluntario?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
            ' Evaluamos la respuesta
            If respuesta = DialogResult.Yes Then

                ' Aquí va el código si el usuario pulsa SÍ
                pAux.BorrarCentro()
                MessageBox.Show("borrado con éxito.")

            Else
                ' Aquí va el código (o nada) si el usuario pulsa NO
                MessageBox.Show("Operación cancelada.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        vaciarTextBox()
        Dim formularioPadre As CentroLogistico_pag = DirectCast(Me.Parent.Parent, CentroLogistico_pag)
        formularioPadre.refrescarlistbox()
        refrescarcombobox()
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim respuesta As DialogResult
        'comrpobamos que este todo escrito para editar
        If TextBoxAlmacenamiento.Text = "" Or TextBoxCiudad.Text = "" Or ComboBoxId.Text = "" Or TextBoxnombre.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'comprobamos que sea un numero
        Dim capacidadValue As Decimal
        If Not Decimal.TryParse(TextBoxAlmacenamiento.Text, capacidadValue) Then
            MessageBox.Show("La capacidad debe ser un valor numérico.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            'creamos el centro y le metemos los datos
            Dim id As String = ComboBoxId.Text
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

                ' Aquí va el código si el usuario pulsa SÍ
                pAux.ActualizarCentro()
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
        Dim formularioPadre As CentroLogistico_pag = DirectCast(Me.Parent.Parent, CentroLogistico_pag)
        formularioPadre.refrescarlistbox()
        refrescarcombobox()
    End Sub
    'funcion para limpiar las textbox
    Public Sub vaciarTextBox()
        ComboBoxId.Text = ""
        TextBoxnombre.Text = ""
        TextBoxAlmacenamiento.Text = ""
        TextBoxCiudad.Text = ""
    End Sub
    'rellena la combobox con los centros logisticos que hay
    Private Sub refrescarcombobox()
        Me.ComboBoxId.Items.Clear()
        Dim pAux As Centro_logistico
        Me.c = New Centro_logistico
        Try
            Me.c.LeerTodosCentros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CentroDAO.Centro
            Me.ComboBoxId.Items.Add(pAux.id)
        Next
    End Sub
    'al cargar refresca combobox con los centros correspondientes
    Private Sub CentroLogistico_pag_editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarcombobox()
    End Sub
End Class
