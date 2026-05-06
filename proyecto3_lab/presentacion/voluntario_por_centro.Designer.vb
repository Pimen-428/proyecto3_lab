<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voluntario_por_centro
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
        CentroLabel = New Label()
        VoluntarioLabel = New Label()
        SuspendLayout()
        ' 
        ' ListBoxCentros
        ' 
        ListBoxCentros.Dock = DockStyle.Left
        ListBoxCentros.FormattingEnabled = True
        ListBoxCentros.Location = New Point(0, 0)
        ListBoxCentros.Name = "ListBoxCentros"
        ListBoxCentros.Size = New Size(150, 541)
        ListBoxCentros.TabIndex = 0
        ' 
        ' CentroLabel
        ' 
        CentroLabel.AutoSize = True
        CentroLabel.BackColor = SystemColors.ButtonHighlight
        CentroLabel.Location = New Point(230, 162)
        CentroLabel.Name = "CentroLabel"
        CentroLabel.Size = New Size(176, 20)
        CentroLabel.TabIndex = 1
        CentroLabel.Text = "CENTRO SELECCIONADO"
        ' 
        ' VoluntarioLabel
        ' 
        VoluntarioLabel.AutoSize = True
        VoluntarioLabel.BackColor = SystemColors.ButtonHighlight
        VoluntarioLabel.Location = New Point(521, 162)
        VoluntarioLabel.Name = "VoluntarioLabel"
        VoluntarioLabel.Size = New Size(106, 20)
        VoluntarioLabel.TabIndex = 2
        VoluntarioLabel.Text = "VOLUNTARIOS"
        ' 
        ' voluntario_por_centro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(VoluntarioLabel)
        Controls.Add(CentroLabel)
        Controls.Add(ListBoxCentros)
        Name = "voluntario_por_centro"
        Size = New Size(790, 541)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBoxCentros As ListBox
    Friend WithEvents CentroLabel As Label
    Friend WithEvents VoluntarioLabel As Label

End Class
