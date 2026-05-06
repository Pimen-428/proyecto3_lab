<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entregas_de_cada_voluntario
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
        labelvoluntario = New Label()
        labelenvios = New Label()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.Dock = DockStyle.Left
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(0, 0)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(231, 483)
        ListBox1.TabIndex = 0
        ' 
        ' labelvoluntario
        ' 
        labelvoluntario.AutoSize = True
        labelvoluntario.BackColor = SystemColors.ButtonHighlight
        labelvoluntario.Location = New Point(286, 125)
        labelvoluntario.Name = "labelvoluntario"
        labelvoluntario.Size = New Size(98, 20)
        labelvoluntario.TabIndex = 1
        labelvoluntario.Text = "VOLUNTARIO"
        ' 
        ' labelenvios
        ' 
        labelenvios.AutoSize = True
        labelenvios.BackColor = SystemColors.ButtonHighlight
        labelenvios.Location = New Point(511, 125)
        labelenvios.Name = "labelenvios"
        labelenvios.Size = New Size(218, 20)
        labelenvios.TabIndex = 2
        labelenvios.Text = "ENVIOS EN LOS QUE PARTICIPO"
        ' 
        ' Entregas_de_cada_voluntario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(labelenvios)
        Controls.Add(labelvoluntario)
        Controls.Add(ListBox1)
        Name = "Entregas_de_cada_voluntario"
        Size = New Size(729, 483)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents labelvoluntario As Label
    Friend WithEvents labelenvios As Label

End Class
