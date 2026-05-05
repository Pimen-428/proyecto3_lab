Public Class menu

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiarvista(New VentanaInicio())
    End Sub
    Private Sub cambiarvista(vistanueva As Control)
        panel_principal.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        panel_principal.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub

    Private Sub MenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuPrincipalToolStripMenuItem.Click
        cambiarvista(New VentanaInicio())
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        cambiarvista(New Voluntarios_pag())
    End Sub

    Private Sub CentrosLogisticosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentrosLogisticosToolStripMenuItem.Click
        cambiarvista(New CentroLogistico_pag())
    End Sub
    Private Sub ZonasDeConflictoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ZonasDeConflictoToolStripMenuItem1.Click
        cambiarvista(New Zonas_pag())
    End Sub


    Private Sub RealizarEnvioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarEnvioToolStripMenuItem.Click
        cambiarvista(New envios_pag())
    End Sub

    Private Sub EditarEstadoEnvioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarEstadoEnvioToolStripMenuItem.Click
        cambiarvista(New envios_editar_pag())
    End Sub

    Private Sub panel_principal_Paint(sender As Object, e As PaintEventArgs) Handles panel_principal.Paint

    End Sub

    Private Sub EntregasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregasToolStripMenuItem.Click
        cambiarvista(New Entregas_pag)
    End Sub
End Class