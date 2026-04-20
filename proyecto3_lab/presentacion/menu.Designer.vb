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
        CentrosLogisticosToolStripMenuItem = New ToolStripMenuItem()
        EnviosToolStripMenuItem = New ToolStripMenuItem()
        panel_principal = New Panel()
        VoluntariosToolStripMenuItem = New ToolStripMenuItem()
        ZonasDeConflictoToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuPrincipalToolStripMenuItem, ToolStripMenuItem1, CentrosLogisticosToolStripMenuItem, EnviosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.Size = New Size(1000, 33)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip"
        ' 
        ' MenuPrincipalToolStripMenuItem
        ' 
        MenuPrincipalToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText
        MenuPrincipalToolStripMenuItem.Name = "MenuPrincipalToolStripMenuItem"
        MenuPrincipalToolStripMenuItem.Size = New Size(145, 29)
        MenuPrincipalToolStripMenuItem.Text = "menu principal"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripTextBox1, VoluntariosToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(117, 29)
        ToolStripMenuItem1.Text = "Voluntarios"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(270, 34)
        ToolStripTextBox1.Text = "ver voluntarios"
        ' 
        ' CentrosLogisticosToolStripMenuItem
        ' 
        CentrosLogisticosToolStripMenuItem.Name = "CentrosLogisticosToolStripMenuItem"
        CentrosLogisticosToolStripMenuItem.Size = New Size(169, 29)
        CentrosLogisticosToolStripMenuItem.Text = "Centros logisticos"
        ' 
        ' EnviosToolStripMenuItem
        ' 
        EnviosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ZonasDeConflictoToolStripMenuItem})
        EnviosToolStripMenuItem.Name = "EnviosToolStripMenuItem"
        EnviosToolStripMenuItem.Size = New Size(79, 29)
        EnviosToolStripMenuItem.Text = "Envios"
        ' 
        ' panel_principal
        ' 
        panel_principal.BackColor = SystemColors.ButtonFace
        panel_principal.BorderStyle = BorderStyle.Fixed3D
        panel_principal.Dock = DockStyle.Fill
        panel_principal.Location = New Point(0, 33)
        panel_principal.Margin = New Padding(4, 4, 4, 4)
        panel_principal.Name = "panel_principal"
        panel_principal.Size = New Size(1000, 529)
        panel_principal.TabIndex = 4
        ' 
        ' VoluntariosToolStripMenuItem
        ' 
        VoluntariosToolStripMenuItem.Name = "VoluntariosToolStripMenuItem"
        VoluntariosToolStripMenuItem.Size = New Size(270, 34)
        VoluntariosToolStripMenuItem.Text = "Voluntarios"
        ' 
        ' ZonasDeConflictoToolStripMenuItem
        ' 
        ZonasDeConflictoToolStripMenuItem.Name = "ZonasDeConflictoToolStripMenuItem"
        ZonasDeConflictoToolStripMenuItem.Size = New Size(270, 34)
        ZonasDeConflictoToolStripMenuItem.Text = "Zonas de conflicto"
        ' 
        ' menu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 562)
        Controls.Add(panel_principal)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 4, 4, 4)
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
    Friend WithEvents CentrosLogisticosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripMenuItem
    Friend WithEvents VoluntariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZonasDeConflictoToolStripMenuItem As ToolStripMenuItem
End Class
