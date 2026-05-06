Public Class Voluntarios_pag
    Dim v As Voluntario
    Dim añadir_boolean As Boolean
    Dim editar_boolean As Boolean
    'esta funcion se ejecuta al cargar el panel y lo que hace es basicamente llamar a refrescarlistbox
    Private Sub Voluntarios_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        Me.añadir_boolean = False
        Me.editar_boolean = False
    End Sub
    ' refresca la listbox poniendo a todos los voluntarios que hay en la base de datos ordenados por DNI
    Public Sub refrescarlistbox()
        Dim pAux As Voluntario
        'creamos un voluntario en la variable global v
        Me.v = New Voluntario
        Me.lista.Items.Clear()
        Try
            'llamamos a su funcion de leer todas lo que va a haver que su dao.personas que es una coleccion se llene con todos los voluntarios
            Me.v.LeerTodasPersonas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        'por cada voluntario en la coleccion añadimos una linea a la listbox
        For Each pAux In Me.v.PerDAO.Personas
            Me.lista.Items.Add(pAux.DNI & " - " & pAux.Nombre)
        Next
    End Sub
    'boton que esta abajo de la pantalla y se encarga de cambiar el panel de aqui para poder acceder a la ventana de añadir voluntarios
    Private Sub añadir_Click(sender As Object, e As EventArgs) Handles añadir.Click
        If añadir_boolean Then
            Panel_voluntarios.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New voluntarios_pag_añadir())
            añadir_boolean = True
        End If
    End Sub
    ' misma funcion que en el menu principal
    Private Sub cambiarvista(vistanueva As Control)
        Panel_voluntarios.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        Panel_voluntarios.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub
    'boton que cambia el panel a la pestaña para editar un voluntario
    Private Sub editar_Click(sender As Object, e As EventArgs) Handles editar.Click
        If editar_boolean Then
            Panel_voluntarios.Controls.Clear()
            editar_boolean = False
        Else
            cambiarvista(New voluntarios_pag_editar())
            editar_boolean = True
        End If
    End Sub
    'funcion si seleccionamos un index de la listbox
    Private Sub lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista.SelectedIndexChanged
        If Not Me.lista.SelectedItem Is Nothing Then
            Dim texto As String = Me.lista.SelectedItem.ToString()
            Dim dividido() As String = texto.Split(" -")
            'creamos el voluntario con el dni obtenio de la listbox para ahora llamar a sus funciones
            Dim seleccionado As New Voluntario(dividido(0))

            Try

                'creamos la ventana que vamos a poner, en este caso la de voluntarios editar
                Dim vistaEditar As New voluntarios_pag_editar()

                'leemos los datos del voluntario de la BD
                seleccionado.LeerPersona()

                'funcion que esta dentro de la ventana para rellenar los combobox con el texto del voluntario seleccionado
                vistaEditar.voluntarioseleccionado(seleccionado)

                ' Mostramos la ventana con los datos puestos
                cambiarvista(vistaEditar)
                editar_boolean = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el voluntario: " & ex.Message)
            End Try
        End If
    End Sub

End Class
