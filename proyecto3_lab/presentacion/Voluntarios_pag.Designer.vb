<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Voluntarios_pag
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
        lista = New ListBox()
        StatusStrip1 = New StatusStrip()
        añadir = New ToolStripStatusLabel()
        editar = New ToolStripStatusLabel()
        Panel_voluntarios = New Panel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lista
        ' 
        lista.Dock = DockStyle.Left
        lista.FormattingEnabled = True
        lista.Location = New Point(0, 0)
        lista.Name = "lista"
        lista.Size = New Size(150, 479)
        lista.TabIndex = 0
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = SystemColors.GradientActiveCaption
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {añadir, editar})
        StatusStrip1.Location = New Point(150, 453)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(605, 26)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' añadir
        ' 
        añadir.Name = "añadir"
        añadir.Size = New Size(125, 20)
        añadir.Text = "Añadir Voluntario"
        ' 
        ' editar
        ' 
        editar.Name = "editar"
        editar.Size = New Size(126, 20)
        editar.Text = "Editar Voluntarios"
        ' 
        ' Panel_voluntarios
        ' 
        Panel_voluntarios.Dock = DockStyle.Fill
        Panel_voluntarios.Location = New Point(150, 0)
        Panel_voluntarios.Name = "Panel_voluntarios"
        Panel_voluntarios.Size = New Size(605, 453)
        Panel_voluntarios.TabIndex = 11
        ' 
        ' Voluntarios_pag
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel_voluntarios)
        Controls.Add(StatusStrip1)
        Controls.Add(lista)
        Name = "Voluntarios_pag"
        Size = New Size(755, 479)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lista As ListBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents añadir As ToolStripStatusLabel
    Friend WithEvents editar As ToolStripStatusLabel
    Friend WithEvents Panel_voluntarios As Panel

End Class
