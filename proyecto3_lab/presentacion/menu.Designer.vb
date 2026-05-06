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
        TransaccionesToolStripMenuItem = New ToolStripMenuItem()
        EnvioToolStripMenuItem = New ToolStripMenuItem()
        RealizarEnvioToolStripMenuItem1 = New ToolStripMenuItem()
        EditarEstadoEnvioToolStripMenuItem1 = New ToolStripMenuItem()
        ListadoTodosLosEnviosToolStripMenuItem = New ToolStripMenuItem()
        EntregaToolStripMenuItem = New ToolStripMenuItem()
        RecepcionToolStripMenuItem = New ToolStripMenuItem()
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
        MenuStrip1.Size = New Size(800, 28)
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
        ToolStripTextBox1.Size = New Size(224, 26)
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
        EntregasDeCadaVoluntarioToolStripMenuItem.Size = New Size(224, 26)
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
        ZonasConflictoToolStripMenuItem.Size = New Size(224, 26)
        ZonasConflictoToolStripMenuItem.Text = "Zonas de conflicto"
        ' 
        ' SuministrosToolStripMenuItem
        ' 
        SuministrosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerSuministrosToolStripMenuItem, Top10SuministrosEnviadosToolStripMenuItem})
        SuministrosToolStripMenuItem.Name = "SuministrosToolStripMenuItem"
        SuministrosToolStripMenuItem.Size = New Size(224, 26)
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
        ' TransaccionesToolStripMenuItem
        ' 
        TransaccionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EnvioToolStripMenuItem, EntregaToolStripMenuItem, RecepcionToolStripMenuItem})
        TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        TransaccionesToolStripMenuItem.Size = New Size(114, 24)
        TransaccionesToolStripMenuItem.Text = "Transacciones"
        ' 
        ' EnvioToolStripMenuItem
        ' 
        EnvioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RealizarEnvioToolStripMenuItem1, EditarEstadoEnvioToolStripMenuItem1, ListadoTodosLosEnviosToolStripMenuItem})
        EnvioToolStripMenuItem.Name = "EnvioToolStripMenuItem"
        EnvioToolStripMenuItem.Size = New Size(224, 26)
        EnvioToolStripMenuItem.Text = "Envio"
        ' 
        ' RealizarEnvioToolStripMenuItem1
        ' 
        RealizarEnvioToolStripMenuItem1.Name = "RealizarEnvioToolStripMenuItem1"
        RealizarEnvioToolStripMenuItem1.Size = New Size(251, 26)
        RealizarEnvioToolStripMenuItem1.Text = "Realizar envio"
        ' 
        ' EditarEstadoEnvioToolStripMenuItem1
        ' 
        EditarEstadoEnvioToolStripMenuItem1.Name = "EditarEstadoEnvioToolStripMenuItem1"
        EditarEstadoEnvioToolStripMenuItem1.Size = New Size(251, 26)
        EditarEstadoEnvioToolStripMenuItem1.Text = "Editar estado envio"
        ' 
        ' ListadoTodosLosEnviosToolStripMenuItem
        ' 
        ListadoTodosLosEnviosToolStripMenuItem.Name = "ListadoTodosLosEnviosToolStripMenuItem"
        ListadoTodosLosEnviosToolStripMenuItem.Size = New Size(251, 26)
        ListadoTodosLosEnviosToolStripMenuItem.Text = "Listado todos los envios"
        ' 
        ' EntregaToolStripMenuItem
        ' 
        EntregaToolStripMenuItem.Name = "EntregaToolStripMenuItem"
        EntregaToolStripMenuItem.Size = New Size(224, 26)
        EntregaToolStripMenuItem.Text = "Entrega"
        ' 
        ' RecepcionToolStripMenuItem
        ' 
        RecepcionToolStripMenuItem.Name = "RecepcionToolStripMenuItem"
        RecepcionToolStripMenuItem.Size = New Size(224, 26)
        RecepcionToolStripMenuItem.Text = "Recepcion"
        ' 
        ' panel_principal
        ' 
        panel_principal.BackColor = SystemColors.ButtonFace
        panel_principal.BorderStyle = BorderStyle.Fixed3D
        panel_principal.Dock = DockStyle.Fill
        panel_principal.Location = New Point(0, 28)
        panel_principal.Name = "panel_principal"
        panel_principal.Size = New Size(800, 422)
        panel_principal.TabIndex = 4
        ' 
        ' menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
    Friend WithEvents ListadoTodosLosEnviosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecepcionToolStripMenuItem As ToolStripMenuItem
End Class
