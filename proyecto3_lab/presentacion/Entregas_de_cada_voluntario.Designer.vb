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
        labelentregas = New Label()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.Dock = DockStyle.Left
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(0, 0)
        ListBox1.Margin = New Padding(4)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(288, 916)
        ListBox1.TabIndex = 0
        ' 
        ' labelvoluntario
        ' 
        labelvoluntario.AutoSize = True
        labelvoluntario.BackColor = SystemColors.ButtonHighlight
        labelvoluntario.Location = New Point(358, 156)
        labelvoluntario.Margin = New Padding(4, 0, 4, 0)
        labelvoluntario.Name = "labelvoluntario"
        labelvoluntario.Size = New Size(120, 25)
        labelvoluntario.TabIndex = 1
        labelvoluntario.Text = "VOLUNTARIO"
        ' 
        ' labelentregas
        ' 
        labelentregas.AutoSize = True
        labelentregas.BackColor = SystemColors.ButtonHighlight
        labelentregas.Location = New Point(639, 156)
        labelentregas.Margin = New Padding(4, 0, 4, 0)
        labelentregas.Name = "labelentregas"
        labelentregas.Size = New Size(300, 25)
        labelentregas.TabIndex = 2
        labelentregas.Text = "ENTREGASS EN LAS QUE PARTICIPO"
        ' 
        ' Entregas_de_cada_voluntario
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(labelentregas)
        Controls.Add(labelvoluntario)
        Controls.Add(ListBox1)
        Margin = New Padding(4)
        Name = "Entregas_de_cada_voluntario"
        Size = New Size(1215, 916)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents labelvoluntario As Label
    Friend WithEvents labelentregas As Label

End Class
