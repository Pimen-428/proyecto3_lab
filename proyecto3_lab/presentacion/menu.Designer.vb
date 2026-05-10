<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        MenuPrincipalToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripTextBox1 = New ToolStripMenuItem()
        VerVoluntariosToolStripMenuItem = New ToolStripMenuItem()
        EntrgasDeCadaVoluntarioToolStripMenuItem = New ToolStripMenuItem()
        EntregasDeCadaVoluntarioToolStripMenuItem = New ToolStripMenuItem()
        VerCentrosToolStripMenuItem = New ToolStripMenuItem()
        AlmacenamientoPorCentroToolStripMenuItem = New ToolStripMenuItem()
        VoluntariosPorCentroToolStripMenuItem1 = New ToolStripMenuItem()
        ZonasConflictoToolStripMenuItem = New ToolStripMenuItem()
        SuministrosToolStripMenuItem = New ToolStripMenuItem()
        VerSuministrosToolStripMenuItem = New ToolStripMenuItem()
        Top10SuministrosEnviadosToolStripMenuItem = New ToolStripMenuItem()
        CrearNuevoSuministroToolStripMenuItem = New ToolStripMenuItem()
        TransaccionesToolStripMenuItem = New ToolStripMenuItem()
        EnvioToolStripMenuItem = New ToolStripMenuItem()
        RealizarEnvioToolStripMenuItem1 = New ToolStripMenuItem()
        EditarEstadoEnvioToolStripMenuItem1 = New ToolStripMenuItem()
        HistoricoDeEnvioToolStripMenuItem = New ToolStripMenuItem()
        EntregaToolStripMenuItem = New ToolStripMenuItem()
        HacerEntregaToolStripMenuItem = New ToolStripMenuItem()
        EntregasPorFechaToolStripMenuItem = New ToolStripMenuItem()
        RecepcionToolStripMenuItem = New ToolStripMenuItem()
        AñadirRecepToolStripMenuItem = New ToolStripMenuItem()
        VerRecepcionToolStripMenuItem = New ToolStripMenuItem()
        EditarRecepcionToolStripMenuItem = New ToolStripMenuItem()
        ListadoGlobalDeAlmacenToolStripMenuItem = New ToolStripMenuItem()
        panel_principal = New Panel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuPrincipalToolStripMenuItem, ToolStripMenuItem1, TransaccionesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(800, 30)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip"
        ' 
        ' MenuPrincipalToolStripMenuItem
        ' 
        MenuPrincipalToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText
        MenuPrincipalToolStripMenuItem.Name = "MenuPrincipalToolStripMenuItem"
        MenuPrincipalToolStripMenuItem.Size = New Size(122, 24)
        MenuPrincipalToolStripMenuItem.Text = "menu principal"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripTextBox1, EntregasDeCadaVoluntarioToolStripMenuItem, ZonasConflictoToolStripMenuItem, SuministrosToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(88, 24)
        ToolStripMenuItem1.Text = "Entidades"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.DropDownItems.AddRange(New ToolStripItem() {VerVoluntariosToolStripMenuItem, EntrgasDeCadaVoluntarioToolStripMenuItem})
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(215, 26)
        ToolStripTextBox1.Text = "Voluntarios"
        ' 
        ' VerVoluntariosToolStripMenuItem
        ' 
        VerVoluntariosToolStripMenuItem.Name = "VerVoluntariosToolStripMenuItem"
        VerVoluntariosToolStripMenuItem.Size = New Size(278, 26)
        VerVoluntariosToolStripMenuItem.Text = "Ver voluntarios"
        ' 
        ' EntrgasDeCadaVoluntarioToolStripMenuItem
        ' 
        EntrgasDeCadaVoluntarioToolStripMenuItem.Name = "EntrgasDeCadaVoluntarioToolStripMenuItem"
        EntrgasDeCadaVoluntarioToolStripMenuItem.Size = New Size(278, 26)
        EntrgasDeCadaVoluntarioToolStripMenuItem.Text = "Entregas de cada Voluntario"
        ' 
        ' EntregasDeCadaVoluntarioToolStripMenuItem
        ' 
        EntregasDeCadaVoluntarioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerCentrosToolStripMenuItem, AlmacenamientoPorCentroToolStripMenuItem, VoluntariosPorCentroToolStripMenuItem1})
        EntregasDeCadaVoluntarioToolStripMenuItem.Name = "EntregasDeCadaVoluntarioToolStripMenuItem"
        EntregasDeCadaVoluntarioToolStripMenuItem.Size = New Size(215, 26)
        EntregasDeCadaVoluntarioToolStripMenuItem.Text = "Centros"
        ' 
        ' VerCentrosToolStripMenuItem
        ' 
        VerCentrosToolStripMenuItem.Name = "VerCentrosToolStripMenuItem"
        VerCentrosToolStripMenuItem.Size = New Size(278, 26)
        VerCentrosToolStripMenuItem.Text = "Ver centros"
        ' 
        ' AlmacenamientoPorCentroToolStripMenuItem
        ' 
        AlmacenamientoPorCentroToolStripMenuItem.Name = "AlmacenamientoPorCentroToolStripMenuItem"
        AlmacenamientoPorCentroToolStripMenuItem.Size = New Size(278, 26)
        AlmacenamientoPorCentroToolStripMenuItem.Text = "Almacenamiento por centro"
        ' 
        ' VoluntariosPorCentroToolStripMenuItem1
        ' 
        VoluntariosPorCentroToolStripMenuItem1.Name = "VoluntariosPorCentroToolStripMenuItem1"
        VoluntariosPorCentroToolStripMenuItem1.Size = New Size(278, 26)
        VoluntariosPorCentroToolStripMenuItem1.Text = "voluntarios por centro"
        ' 
        ' ZonasConflictoToolStripMenuItem
        ' 
        ZonasConflictoToolStripMenuItem.Name = "ZonasConflictoToolStripMenuItem"
        ZonasConflictoToolStripMenuItem.Size = New Size(215, 26)
        ZonasConflictoToolStripMenuItem.Text = "Zonas de conflicto"
        ' 
        ' SuministrosToolStripMenuItem
        ' 
        SuministrosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerSuministrosToolStripMenuItem, Top10SuministrosEnviadosToolStripMenuItem, CrearNuevoSuministroToolStripMenuItem})
        SuministrosToolStripMenuItem.Name = "SuministrosToolStripMenuItem"
        SuministrosToolStripMenuItem.Size = New Size(215, 26)
        SuministrosToolStripMenuItem.Text = "Suministros"
        ' 
        ' VerSuministrosToolStripMenuItem
        ' 
        VerSuministrosToolStripMenuItem.Name = "VerSuministrosToolStripMenuItem"
        VerSuministrosToolStripMenuItem.Size = New Size(276, 26)
        VerSuministrosToolStripMenuItem.Text = "ver suministros"
        ' 
        ' Top10SuministrosEnviadosToolStripMenuItem
        ' 
        Top10SuministrosEnviadosToolStripMenuItem.Name = "Top10SuministrosEnviadosToolStripMenuItem"
        Top10SuministrosEnviadosToolStripMenuItem.Size = New Size(276, 26)
        Top10SuministrosEnviadosToolStripMenuItem.Text = "top 10 suministros enviados"
        ' 
        ' CrearNuevoSuministroToolStripMenuItem
        ' 
        CrearNuevoSuministroToolStripMenuItem.Name = "CrearNuevoSuministroToolStripMenuItem"
        CrearNuevoSuministroToolStripMenuItem.Size = New Size(276, 26)
        CrearNuevoSuministroToolStripMenuItem.Text = "Crear nuevo suministro"
        ' 
        ' TransaccionesToolStripMenuItem
        ' 
        TransaccionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EnvioToolStripMenuItem, EntregaToolStripMenuItem, RecepcionToolStripMenuItem, ListadoGlobalDeAlmacenToolStripMenuItem})
        TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        TransaccionesToolStripMenuItem.Size = New Size(114, 24)
        TransaccionesToolStripMenuItem.Text = "Transacciones"
        ' 
        ' EnvioToolStripMenuItem
        ' 
        EnvioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RealizarEnvioToolStripMenuItem1, EditarEstadoEnvioToolStripMenuItem1, HistoricoDeEnvioToolStripMenuItem})
        EnvioToolStripMenuItem.Name = "EnvioToolStripMenuItem"
        EnvioToolStripMenuItem.Size = New Size(268, 26)
        EnvioToolStripMenuItem.Text = "Envio"
        ' 
        ' RealizarEnvioToolStripMenuItem1
        ' 
        RealizarEnvioToolStripMenuItem1.Name = "RealizarEnvioToolStripMenuItem1"
        RealizarEnvioToolStripMenuItem1.Size = New Size(224, 26)
        RealizarEnvioToolStripMenuItem1.Text = "Realizar envio"
        ' 
        ' EditarEstadoEnvioToolStripMenuItem1
        ' 
        EditarEstadoEnvioToolStripMenuItem1.Name = "EditarEstadoEnvioToolStripMenuItem1"
        EditarEstadoEnvioToolStripMenuItem1.Size = New Size(224, 26)
        EditarEstadoEnvioToolStripMenuItem1.Text = "Editar estado envio"
        ' 
        ' HistoricoDeEnvioToolStripMenuItem
        ' 
        HistoricoDeEnvioToolStripMenuItem.Name = "HistoricoDeEnvioToolStripMenuItem"
        HistoricoDeEnvioToolStripMenuItem.Size = New Size(224, 26)
        HistoricoDeEnvioToolStripMenuItem.Text = "Historico de envio"
        ' 
        ' EntregaToolStripMenuItem
        ' 
        EntregaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HacerEntregaToolStripMenuItem, EntregasPorFechaToolStripMenuItem})
        EntregaToolStripMenuItem.Name = "EntregaToolStripMenuItem"
        EntregaToolStripMenuItem.Size = New Size(268, 26)
        EntregaToolStripMenuItem.Text = "Entrega"
        ' 
        ' HacerEntregaToolStripMenuItem
        ' 
        HacerEntregaToolStripMenuItem.Name = "HacerEntregaToolStripMenuItem"
        HacerEntregaToolStripMenuItem.Size = New Size(216, 26)
        HacerEntregaToolStripMenuItem.Text = "Hacer entrega"
        ' 
        ' EntregasPorFechaToolStripMenuItem
        ' 
        EntregasPorFechaToolStripMenuItem.Name = "EntregasPorFechaToolStripMenuItem"
        EntregasPorFechaToolStripMenuItem.Size = New Size(216, 26)
        EntregasPorFechaToolStripMenuItem.Text = "Entregas por fecha"
        ' 
        ' RecepcionToolStripMenuItem
        ' 
        RecepcionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AñadirRecepToolStripMenuItem, VerRecepcionToolStripMenuItem, EditarRecepcionToolStripMenuItem})
        RecepcionToolStripMenuItem.Name = "RecepcionToolStripMenuItem"
        RecepcionToolStripMenuItem.Size = New Size(268, 26)
        RecepcionToolStripMenuItem.Text = "Recepción"
        ' 
        ' AñadirRecepToolStripMenuItem
        ' 
        AñadirRecepToolStripMenuItem.Name = "AñadirRecepToolStripMenuItem"
        AñadirRecepToolStripMenuItem.Size = New Size(209, 26)
        AñadirRecepToolStripMenuItem.Text = "Añadir Recepción"
        ' 
        ' VerRecepcionToolStripMenuItem
        ' 
        VerRecepcionToolStripMenuItem.Name = "VerRecepcionToolStripMenuItem"
        VerRecepcionToolStripMenuItem.Size = New Size(209, 26)
        VerRecepcionToolStripMenuItem.Text = "Ver_Recepcion"
        ' 
        ' EditarRecepcionToolStripMenuItem
        ' 
        EditarRecepcionToolStripMenuItem.Name = "EditarRecepcionToolStripMenuItem"
        EditarRecepcionToolStripMenuItem.Size = New Size(209, 26)
        EditarRecepcionToolStripMenuItem.Text = "Editar_Recepcion"
        ' 
        ' ListadoGlobalDeAlmacenToolStripMenuItem
        ' 
        ListadoGlobalDeAlmacenToolStripMenuItem.Name = "ListadoGlobalDeAlmacenToolStripMenuItem"
        ListadoGlobalDeAlmacenToolStripMenuItem.Size = New Size(268, 26)
        ListadoGlobalDeAlmacenToolStripMenuItem.Text = "Listado global de almacen"
        ' 
        ' panel_principal
        ' 
        panel_principal.BackColor = SystemColors.ButtonFace
        panel_principal.BorderStyle = BorderStyle.Fixed3D
        panel_principal.Dock = DockStyle.Fill
        panel_principal.Location = New Point(0, 30)
        panel_principal.Name = "panel_principal"
        panel_principal.Size = New Size(800, 421)
        panel_principal.TabIndex = 4
        ' 
        ' menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(panel_principal)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "menu"
        Text = "menu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panel_principal As Panel
    Friend WithEvents ToolStripTextBox1 As ToolStripMenuItem
    Friend WithEvents EntregasDeCadaVoluntarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerVoluntariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrgasDeCadaVoluntarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerCentrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenamientoPorCentroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoluntariosPorCentroToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ZonasConflictoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuministrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerSuministrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Top10SuministrosEnviadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnvioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RealizarEnvioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditarEstadoEnvioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EntregaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecepcionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirRecepToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerRecepcionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarRecepcionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoricoDeEnvioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoGlobalDeAlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HacerEntregaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregasPorFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearNuevoSuministroToolStripMenuItem As ToolStripMenuItem
End Class
