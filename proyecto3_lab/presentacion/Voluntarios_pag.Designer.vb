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
        ListBox1 = New ListBox()
        StatusStrip1 = New StatusStrip()
        añadir = New ToolStripStatusLabel()
        editar = New ToolStripStatusLabel()
        buscar = New ToolStripStatusLabel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(31, 89)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(150, 284)
        ListBox1.TabIndex = 0
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = SystemColors.GradientActiveCaption
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {añadir, editar, buscar})
        StatusStrip1.Location = New Point(0, 453)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(755, 26)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' añadir
        ' 
        añadir.Name = "añadir"
        añadir.Size = New Size(122, 20)
        añadir.Text = "añadir voluntario"
        ' 
        ' editar
        ' 
        editar.Name = "editar"
        editar.Size = New Size(120, 20)
        editar.Text = "Editar Voluntario"
        ' 
        ' buscar
        ' 
        buscar.Name = "buscar"
        buscar.Size = New Size(123, 20)
        buscar.Text = "buscar voluntario"
        ' 
        ' Voluntarios_pag
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(StatusStrip1)
        Controls.Add(ListBox1)
        Name = "Voluntarios_pag"
        Size = New Size(755, 479)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents añadir As ToolStripStatusLabel
    Friend WithEvents buscar As ToolStripStatusLabel
    Friend WithEvents editar As ToolStripStatusLabel

End Class
