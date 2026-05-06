Public Class CentroLogistico_pag
    Dim añadir_boolean As Boolean
    Dim editar_boolean As Boolean
    Dim c As Centro_logistico
    'cambia el panel con la funcion cambiarvista
    Private Sub AñadirCentro_boton_Click(sender As Object, e As EventArgs) Handles AñadirCentro_boton.Click
        If añadir_boolean Then
            PanelCentro.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New CentroLogistico_pag_añadir())
            añadir_boolean = True
        End If
    End Sub
    'cambia el panel con la funcion cambiarvista
    Private Sub editar_centro_boton_Click(sender As Object, e As EventArgs) Handles editar_centro_boton.Click
        If editar_boolean Then
            PanelCentro.Controls.Clear()
            editar_boolean = False
        Else
            cambiarvista(New CentroLogistico_pag_editar())
            editar_boolean = True
        End If
    End Sub
    'cambia el panel al que le metas como parametro
    Private Sub cambiarvista(vistanueva As Control)
        PanelCentro.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        PanelCentro.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub
    'rellena la listbox con todos los centros y con su nombre
    Public Sub refrescarlistbox()
        Dim pAux As Centro_logistico
        Me.c = New Centro_logistico
        Me.ListBoxCentros.Items.Clear()
        Try
            Me.c.LeerTodosCentros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CentroDAO.Centro
            Me.ListBoxCentros.Items.Add(pAux.id & " - " & pAux.nombre_centro)
        Next
    End Sub
    'esto es al cargar para refrescar la listbox
    Private Sub CentroLogistico_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        Me.añadir_boolean = False
        Me.editar_boolean = False
    End Sub
    ' si seleccionamos un centro crea un panel hijo con los datos del centro rellenados y puedes ediar centro ahi
    Private Sub ListBoxCentros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCentros.SelectedIndexChanged
        If Not Me.ListBoxCentros.SelectedItem Is Nothing Then
            Dim texto As String = Me.ListBoxCentros.SelectedItem.ToString()
            Dim separacion() As String = texto.Split("-")
            'Creamos el objeto voluntario con el DNI seleccionado
            Dim seleccionado As New Centro_logistico(separacion(0))

            Try
                'Cargamos sus datos desde la BD
                seleccionado.LeerCentro()

                'Creamos la vista de edición
                Dim vistaEditar As New CentroLogistico_pag_editar()

                'Llamamos a la función dentro de la ventana para pasarle los datos
                vistaEditar.centroseleccionado(seleccionado)

                'Mostramos la vista en el panel usando la funcion
                cambiarvista(vistaEditar)
                editar_boolean = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el centro: " & ex.Message)
            End Try
        End If
    End Sub

End Class
