Imports System.Linq.Expressions

Public Class menu

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiarvista(New VentanaInicio())
    End Sub
    'funcion creada para cambiar el panel que hay en el menu principal, trabajamos con paneles por que abrir nuevas paginas con 
    'cada nuevo movimiento es un tanto incomodo, lo que hace la funcion es primero limpiar el panel y luego poner la ventana que le hemos dicho
    Private Sub cambiarvista(vistanueva As Control)
        panel_principal.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        panel_principal.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub

    Private Sub MenuPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuPrincipalToolStripMenuItem.Click
        cambiarvista(New VentanaInicio())
    End Sub

    Private Sub ZonasDeConflictoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        cambiarvista(New Zonas_pag)
    End Sub
    Private Sub EntregasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cambiarvista(New Entregas_pag)
    End Sub

    Private Sub VerCentrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerCentrosToolStripMenuItem.Click
        cambiarvista(New CentroLogistico_pag)
    End Sub

    Private Sub VerVoluntariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerVoluntariosToolStripMenuItem.Click
        cambiarvista(New Voluntarios_pag())
    End Sub

    Private Sub EntrgasDeCadaVoluntarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrgasDeCadaVoluntarioToolStripMenuItem.Click
        cambiarvista(New Entregas_de_cada_voluntario())
    End Sub

    Private Sub VoluntariosPorCentroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VoluntariosPorCentroToolStripMenuItem1.Click
        cambiarvista(New voluntario_por_centro)
    End Sub

    Private Sub AlmacenamientoPorCentroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenamientoPorCentroToolStripMenuItem.Click
        cambiarvista(New Inventario_por_centro)
    End Sub

    Private Sub RealizarEnvioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RealizarEnvioToolStripMenuItem1.Click
        cambiarvista(New envios_pag)
    End Sub

    Private Sub EditarEstadoEnvioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditarEstadoEnvioToolStripMenuItem1.Click
        cambiarvista(New envios_editar_pag)
    End Sub

    Private Sub ZonasConflictoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZonasConflictoToolStripMenuItem.Click
        cambiarvista(New Zonas_pag)
    End Sub

    Private Sub Top10SuministrosEnviadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Top10SuministrosEnviadosToolStripMenuItem.Click
        cambiarvista(New top_10_suministros)
    End Sub

    Private Sub EntregaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregaToolStripMenuItem.Click
        cambiarvista(New Entregas_pag)
    End Sub

    Private Sub SuministrosPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuministrosPorFechaToolStripMenuItem.Click
        cambiarvista(New Suministros_por_fechas)
    End Sub
End Class