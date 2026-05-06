<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario_por_centro
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
        centrolabel = New Label()
        suministrolabel = New Label()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.Dock = DockStyle.Left
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(0, 0)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(150, 537)
        ListBox1.TabIndex = 0
        ' 
        ' centrolabel
        ' 
        centrolabel.AutoSize = True
        centrolabel.BackColor = SystemColors.HighlightText
        centrolabel.Location = New Point(279, 149)
        centrolabel.Name = "centrolabel"
        centrolabel.Size = New Size(176, 20)
        centrolabel.TabIndex = 1
        centrolabel.Text = "CENTRO SELECCIONADO"
        ' 
        ' suministrolabel
        ' 
        suministrolabel.AutoSize = True
        suministrolabel.BackColor = SystemColors.ButtonHighlight
        suministrolabel.Location = New Point(583, 149)
        suministrolabel.Name = "suministrolabel"
        suministrolabel.Size = New Size(205, 20)
        suministrolabel.TabIndex = 2
        suministrolabel.Text = "SUMINISTROS EN EL CENTRO"
        ' 
        ' Inventario_por_centro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(suministrolabel)
        Controls.Add(centrolabel)
        Controls.Add(ListBox1)
        Name = "Inventario_por_centro"
        Size = New Size(864, 537)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents centrolabel As Label
    Friend WithEvents suministrolabel As Label

End Class
