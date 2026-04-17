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

    Private Sub CentrosLogisticosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentrosLogisticosToolStripMenuItem.Click

    End Sub

    Private Sub MenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuPrincipalToolStripMenuItem.Click
        cambiarvista(New VentanaInicio())
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        cambiarvista(New Voluntarios_pag())
    End Sub
End Class