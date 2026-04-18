Public Class Voluntarios_pag
    Dim v As Voluntario
    Dim añadir_boolean As Boolean
    Dim editar_boolean As Boolean
    Private Sub Voluntarios_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        Me.añadir_boolean = False
    End Sub
    Public Sub refrescarlistbox()
        Dim pAux As Voluntario
        Me.v = New Voluntario
        Me.lista.Items.Clear()
        Try
            Me.v.LeerTodasPersonas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.v.PerDAO.Personas
            Me.lista.Items.Add(pAux.DNI)
        Next
    End Sub
    Private Sub añadir_Click(sender As Object, e As EventArgs) Handles añadir.Click
        If añadir_boolean Then
            Panel_voluntarios.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New voluntarios_pag_añadir())
            añadir_boolean = True
        End If
    End Sub
    Private Sub cambiarvista(vistanueva As Control)
        Panel_voluntarios.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        Panel_voluntarios.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub

    Private Sub editar_Click(sender As Object, e As EventArgs) Handles editar.Click
        If editar_boolean Then
            Panel_voluntarios.Controls.Clear()
            editar_boolean = False
        Else
            cambiarvista(New voluntarios_pag_editar())
            editar_boolean = True
        End If
    End Sub

    Private Sub lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista.SelectedIndexChanged
        If Not Me.lista.SelectedItem Is Nothing Then
            ' 1. Creamos el objeto voluntario con el DNI seleccionado
            Dim seleccionado As New Voluntario(Me.lista.SelectedItem.ToString())

            Try
                ' 2. Cargamos sus datos desde la BD
                seleccionado.LeerPersona()

                ' 3. Creamos la vista de edición
                Dim vistaEditar As New voluntarios_pag_editar()

                ' 4. Llamamos a la función para pasarle los datos
                vistaEditar.voluntarioseleccionado(seleccionado)

                ' 5. Mostramos la vista en el panel usando tu función auxiliar
                cambiarvista(vistaEditar)
                editar_boolean = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el voluntario: " & ex.Message)
            End Try
        End If
    End Sub
End Class
