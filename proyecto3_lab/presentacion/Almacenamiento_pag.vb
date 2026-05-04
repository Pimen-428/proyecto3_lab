Public Class Almacenamiento_pag

    Dim añadir_boolean As Boolean
    Dim editar_boolean As Boolean

    Private Sub AñadirStock_boton_Click(sender As Object, e As EventArgs) Handles AñadirStock_boton.Click
        If añadir_boolean Then
            PanelContenido.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New Almacenamiento_pag_añadir())
            añadir_boolean = True
        End If
    End Sub

    Private Sub EditarStock_boton_Click(sender As Object, e As EventArgs) Handles EditarStock_boton.Click
        If editar_boolean Then
            PanelContenido.Controls.Clear()
            editar_boolean = False
        Else
            cambiarvista(New Almacenamiento_pag_editar())
            editar_boolean = True
        End If
    End Sub

    Private Sub cambiarvista(v As Control)
        PanelContenido.Controls.Clear()
        v.Dock = DockStyle.Fill
        PanelContenido.Controls.Add(v)
        v.BringToFront()
    End Sub

End Class
