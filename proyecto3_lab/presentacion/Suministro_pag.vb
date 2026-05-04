<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Suministro_pag
    Inherits System.Windows.Forms.UserControl

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ListBoxSuministros = New ListBox()
        PanelSuministro = New Panel()
        StatusStrip1 = New StatusStrip()
        AñadirSuministro_boton = New ToolStripStatusLabel()
        EditarSuministro_boton = New ToolStripStatusLabel()

        StatusStrip1.SuspendLayout()
        SuspendLayout()

        ' ListBox
        ListBoxSuministros.Dock = DockStyle.Left
        ListBoxSuministros.Size = New Size(180, 500)

        ' Panel
        PanelSuministro.Dock = DockStyle.Fill

        ' StatusStrip
        StatusStrip1.Items.AddRange(New ToolStripItem() {AñadirSuministro_boton, EditarSuministro_boton})

        AñadirSuministro_boton.Text = "Añadir Suministro"
        EditarSuministro_boton.Text = "Editar Suministro"

        Controls.Add(StatusStrip1)
        Controls.Add(PanelSuministro)
        Controls.Add(ListBoxSuministros)

        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBoxSuministros As ListBox
    Friend WithEvents PanelSuministro As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AñadirSuministro_boton As ToolStripStatusLabel
    Friend WithEvents EditarSuministro_boton As ToolStripStatusLabel

End Class
