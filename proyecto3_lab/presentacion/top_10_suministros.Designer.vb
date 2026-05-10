<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class top_10_suministros
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
        labeltop = New Label()
        SuspendLayout()
        ' 
        ' labeltop
        ' 
        labeltop.AutoSize = True
        labeltop.BackColor = SystemColors.ButtonHighlight
        labeltop.Font = New Font("Segoe UI", 7F)
        labeltop.Location = New Point(213, 32)
        labeltop.Name = "labeltop"
        labeltop.Size = New Size(181, 15)
        labeltop.TabIndex = 0
        labeltop.Text = "TOP 10 SUMINISTROS ENVIADOS"
        ' 
        ' top_10_suministros
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(labeltop)
        Name = "top_10_suministros"
        Size = New Size(683, 474)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labeltop As Label

End Class
