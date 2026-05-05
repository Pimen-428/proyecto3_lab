<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zonas_pag
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
        Lista_Zonas = New ListBox()
        Panel_Zonas = New Panel()
        StatusStrip1 = New StatusStrip()
        AÑadirBoton = New ToolStripStatusLabel()
        EditarBoton = New ToolStripStatusLabel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lista_Zonas
        ' 
        Lista_Zonas.Dock = DockStyle.Left
        Lista_Zonas.FormattingEnabled = True
        Lista_Zonas.Location = New Point(0, 0)
        Lista_Zonas.Margin = New Padding(2)
        Lista_Zonas.Name = "Lista_Zonas"
        Lista_Zonas.Size = New Size(266, 1098)
        Lista_Zonas.TabIndex = 0
        ' 
        ' Panel_Zonas
        ' 
        Panel_Zonas.Dock = DockStyle.Fill
        Panel_Zonas.Location = New Point(266, 0)
        Panel_Zonas.Margin = New Padding(2)
        Panel_Zonas.Name = "Panel_Zonas"
        Panel_Zonas.Size = New Size(1316, 1098)
        Panel_Zonas.TabIndex = 3
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {AÑadirBoton, EditarBoton})
        StatusStrip1.Location = New Point(266, 1066)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 18, 0)
        StatusStrip1.Size = New Size(1316, 32)
        StatusStrip1.TabIndex = 4
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' AÑadirBoton
        ' 
        AÑadirBoton.Name = "AÑadirBoton"
        AÑadirBoton.Size = New Size(64, 25)
        AÑadirBoton.Text = "Añadir"
        ' 
        ' EditarBoton
        ' 
        EditarBoton.Name = "EditarBoton"
        EditarBoton.Size = New Size(57, 25)
        EditarBoton.Text = "Editar"
        ' 
        ' Zonas_pag
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(StatusStrip1)
        Controls.Add(Panel_Zonas)
        Controls.Add(Lista_Zonas)
        Margin = New Padding(2)
        Name = "Zonas_pag"
        Size = New Size(1582, 1098)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lista_Zonas As ListBox
    Friend WithEvents Panel_Zonas As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AÑadirBoton As ToolStripStatusLabel
    Friend WithEvents EditarBoton As ToolStripStatusLabel

End Class
