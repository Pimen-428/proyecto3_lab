<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voluntarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        label_voluntarios = New Label()
        aniadir_voluntario_boton = New Button()
        ver_voluntarios_boton = New Button()
        volver_menu = New Button()
        SuspendLayout()
        ' 
        ' label_voluntarios
        ' 
        label_voluntarios.AutoSize = True
        label_voluntarios.Location = New Point(238, 87)
        label_voluntarios.Name = "label_voluntarios"
        label_voluntarios.Size = New Size(261, 20)
        label_voluntarios.TabIndex = 0
        label_voluntarios.Text = "¿Que desea hacer con los voluntarios?"
        ' 
        ' aniadir_voluntario_boton
        ' 
        aniadir_voluntario_boton.Location = New Point(547, 231)
        aniadir_voluntario_boton.Name = "aniadir_voluntario_boton"
        aniadir_voluntario_boton.Size = New Size(159, 29)
        aniadir_voluntario_boton.TabIndex = 1
        aniadir_voluntario_boton.Text = "añadir voluntarios"
        aniadir_voluntario_boton.UseVisualStyleBackColor = True
        ' 
        ' ver_voluntarios_boton
        ' 
        ver_voluntarios_boton.Location = New Point(88, 221)
        ver_voluntarios_boton.Name = "ver_voluntarios_boton"
        ver_voluntarios_boton.Size = New Size(128, 29)
        ver_voluntarios_boton.TabIndex = 2
        ver_voluntarios_boton.Text = "ver voluntarios"
        ver_voluntarios_boton.UseVisualStyleBackColor = True
        ' 
        ' volver_menu
        ' 
        volver_menu.BackColor = SystemColors.MenuHighlight
        volver_menu.ForeColor = SystemColors.HighlightText
        volver_menu.Location = New Point(25, 28)
        volver_menu.Name = "volver_menu"
        volver_menu.Size = New Size(152, 29)
        volver_menu.TabIndex = 3
        volver_menu.Text = "Volver al menu"
        volver_menu.UseVisualStyleBackColor = False
        ' 
        ' voluntarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(volver_menu)
        Controls.Add(ver_voluntarios_boton)
        Controls.Add(aniadir_voluntario_boton)
        Controls.Add(label_voluntarios)
        Name = "voluntarios"
        Text = "voluntarios"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label_voluntarios As Label
    Friend WithEvents aniadir_voluntario_boton As Button
    Friend WithEvents ver_voluntarios_boton As Button
    Friend WithEvents volver_menu As Button
End Class
