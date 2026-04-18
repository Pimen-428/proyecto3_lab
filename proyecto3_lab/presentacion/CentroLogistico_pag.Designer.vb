<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CentroLogistico_pag
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        ListBoxCentros = New ListBox()
        PanelCentro = New Panel()
        StatusStrip1 = New StatusStrip()
        AñadirCentro_boton = New ToolStripStatusLabel()
        editar_centro_boton = New ToolStripStatusLabel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBoxCentros
        ' 
        ListBoxCentros.Dock = DockStyle.Left
        ListBoxCentros.FormattingEnabled = True
        ListBoxCentros.Location = New Point(0, 0)
        ListBoxCentros.Name = "ListBoxCentros"
        ListBoxCentros.Size = New Size(150, 386)
        ListBoxCentros.TabIndex = 1
        ' 
        ' PanelCentro
        ' 
        PanelCentro.Dock = DockStyle.Fill
        PanelCentro.Location = New Point(150, 0)
        PanelCentro.Name = "PanelCentro"
        PanelCentro.Size = New Size(381, 386)
        PanelCentro.TabIndex = 2
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = SystemColors.ActiveCaption
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {AñadirCentro_boton, editar_centro_boton})
        StatusStrip1.Location = New Point(150, 360)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(381, 26)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' AñadirCentro_boton
        ' 
        AñadirCentro_boton.Name = "AñadirCentro_boton"
        AñadirCentro_boton.Size = New Size(101, 20)
        AñadirCentro_boton.Text = "Añadir Centro"
        ' 
        ' editar_centro_boton
        ' 
        editar_centro_boton.Name = "editar_centro_boton"
        editar_centro_boton.Size = New Size(94, 20)
        editar_centro_boton.Text = "Editar centro"
        ' 
        ' CentroLogistico_pag
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(StatusStrip1)
        Controls.Add(PanelCentro)
        Controls.Add(ListBoxCentros)
        Name = "CentroLogistico_pag"
        Size = New Size(531, 386)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ListBoxCentros As ListBox
    Friend WithEvents PanelCentro As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AñadirCentro_boton As ToolStripStatusLabel
    Friend WithEvents editar_centro_boton As ToolStripStatusLabel

End Class
