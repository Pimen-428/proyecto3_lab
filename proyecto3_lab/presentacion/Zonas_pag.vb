Public Class Zonas_pag
    Dim z As zona_conflicto
    Dim añadir_boolean As Boolean
    Dim editar_boolean As Boolean

    Private Sub Zonas_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        Me.añadir_boolean = False
        Me.editar_boolean = False
    End Sub

    Public Sub refrescarlistbox()
        Dim zAux As zona_conflicto
        Me.z = New zona_conflicto()
        Me.Lista_Zonas.Items.Clear()
        Try
            Me.z.LeerTodasZonas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        ' Mostramos el nombre de la zona en la lista
        For Each zAux In Me.z.ZonaDAO.Zonas
            Me.Lista_Zonas.Items.Add(zAux.id & " - " & zAux.nombre)
        Next
    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        If añadir_boolean Then
            Panel_Zonas.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New zonas_pag_añadir())
            añadir_boolean = True
            editar_boolean = False
        End If
    End Sub

    Private Sub cambiarvista(vistanueva As Control)
        Panel_zonas.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        Panel_zonas.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub

    Private Sub lista_zonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lista_Zonas.SelectedIndexChanged
        If Not Me.Lista_Zonas.SelectedItem Is Nothing Then
            ' Extraemos el ID del string "ID - Nombre"
            Dim texto As String = Me.Lista_Zonas.SelectedItem.ToString()
            Dim idSeleccionado As Integer = Convert.ToInt32(texto.Split("-"c)(0).Trim())

            Dim seleccionado As New zona_conflicto(idSeleccionado)

            Try
                seleccionado.LeerZona()
                Dim vistaEditar As New zonas_pag_editar()
                vistaEditar.zonaseleccionada(seleccionado) ' Pasamos el objeto cargado
                cambiarvista(vistaEditar)
                editar_boolean = True
                añadir_boolean = False
            Catch ex As Exception
                MessageBox.Show("Error al cargar la zona: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Panel_Zonas_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Zonas.Paint

    End Sub
End Class