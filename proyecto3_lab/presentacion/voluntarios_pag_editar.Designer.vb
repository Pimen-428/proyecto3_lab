<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voluntarios_pag_editar
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
        ComboBoxDniEditar = New ComboBox()
        TextBoxEspecialidadEditar = New TextBox()
        TextBoxDniEditar = New TextBox()
        TextBoxNombreEditar = New TextBox()
        DNIlabel = New Label()
        LabelEspecialidad = New Label()
        LabelNombre = New Label()
        LabelCentro = New Label()
        ButtonEditar = New Button()
        ButtonEliminar = New Button()
        SuspendLayout()
        ' 
        ' ComboBoxDniEditar
        ' 
        ComboBoxDniEditar.FormattingEnabled = True
        ComboBoxDniEditar.Location = New Point(357, 169)
        ComboBoxDniEditar.Margin = New Padding(3, 2, 3, 2)
        ComboBoxDniEditar.Name = "ComboBoxDniEditar"
        ComboBoxDniEditar.Size = New Size(133, 23)
        ComboBoxDniEditar.TabIndex = 0
        ' 
        ' TextBoxEspecialidadEditar
        ' 
        TextBoxEspecialidadEditar.Location = New Point(119, 169)
        TextBoxEspecialidadEditar.Margin = New Padding(3, 2, 3, 2)
        TextBoxEspecialidadEditar.Name = "TextBoxEspecialidadEditar"
        TextBoxEspecialidadEditar.Size = New Size(110, 23)
        TextBoxEspecialidadEditar.TabIndex = 1
        ' 
        ' TextBoxDniEditar
        ' 
        TextBoxDniEditar.Location = New Point(119, 84)
        TextBoxDniEditar.Margin = New Padding(3, 2, 3, 2)
        TextBoxDniEditar.Name = "TextBoxDniEditar"
        TextBoxDniEditar.Size = New Size(110, 23)
        TextBoxDniEditar.TabIndex = 2
        ' 
        ' TextBoxNombreEditar
        ' 
        TextBoxNombreEditar.Location = New Point(357, 84)
        TextBoxNombreEditar.Margin = New Padding(3, 2, 3, 2)
        TextBoxNombreEditar.Name = "TextBoxNombreEditar"
        TextBoxNombreEditar.Size = New Size(110, 23)
        TextBoxNombreEditar.TabIndex = 3
        ' 
        ' DNIlabel
        ' 
        DNIlabel.AutoSize = True
        DNIlabel.Location = New Point(119, 54)
        DNIlabel.Name = "DNIlabel"
        DNIlabel.Size = New Size(27, 15)
        DNIlabel.TabIndex = 4
        DNIlabel.Text = "DNI"
        ' 
        ' LabelEspecialidad
        ' 
        LabelEspecialidad.AutoSize = True
        LabelEspecialidad.Location = New Point(119, 142)
        LabelEspecialidad.Name = "LabelEspecialidad"
        LabelEspecialidad.Size = New Size(72, 15)
        LabelEspecialidad.TabIndex = 5
        LabelEspecialidad.Text = "Especialidad"
        ' 
        ' LabelNombre
        ' 
        LabelNombre.AutoSize = True
        LabelNombre.Location = New Point(357, 54)
        LabelNombre.Name = "LabelNombre"
        LabelNombre.Size = New Size(51, 15)
        LabelNombre.TabIndex = 6
        LabelNombre.Text = "Nombre"
        ' 
        ' LabelCentro
        ' 
        LabelCentro.AutoSize = True
        LabelCentro.Location = New Point(357, 142)
        LabelCentro.Name = "LabelCentro"
        LabelCentro.Size = New Size(43, 15)
        LabelCentro.TabIndex = 7
        LabelCentro.Text = "Centro"
        ' 
        ' ButtonEditar
        ' 
        ButtonEditar.BackColor = SystemColors.ButtonShadow
        ButtonEditar.Location = New Point(108, 242)
        ButtonEditar.Margin = New Padding(3, 2, 3, 2)
        ButtonEditar.Name = "ButtonEditar"
        ButtonEditar.Size = New Size(82, 22)
        ButtonEditar.TabIndex = 8
        ButtonEditar.Text = "Editar Voluntario"
        ButtonEditar.UseVisualStyleBackColor = False
        ' 
        ' ButtonEliminar
        ' 
        ButtonEliminar.BackColor = SystemColors.MenuHighlight
        ButtonEliminar.Location = New Point(407, 242)
        ButtonEliminar.Margin = New Padding(3, 2, 3, 2)
        ButtonEliminar.Name = "ButtonEliminar"
        ButtonEliminar.Size = New Size(82, 22)
        ButtonEliminar.TabIndex = 10
        ButtonEliminar.Text = "Eliminar"
        ButtonEliminar.UseVisualStyleBackColor = False
        ' 
        ' voluntarios_pag_editar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ButtonEliminar)
        Controls.Add(ButtonEditar)
        Controls.Add(LabelCentro)
        Controls.Add(LabelNombre)
        Controls.Add(LabelEspecialidad)
        Controls.Add(DNIlabel)
        Controls.Add(TextBoxNombreEditar)
        Controls.Add(TextBoxDniEditar)
        Controls.Add(TextBoxEspecialidadEditar)
        Controls.Add(ComboBoxDniEditar)
        Margin = New Padding(3, 2, 3, 2)
        Name = "voluntarios_pag_editar"
        Size = New Size(588, 319)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxDniEditar As ComboBox
    Friend WithEvents TextBoxEspecialidadEditar As TextBox
    Friend WithEvents TextBoxDniEditar As TextBox
    Friend WithEvents TextBoxNombreEditar As TextBox
    Friend WithEvents DNIlabel As Label
    Friend WithEvents LabelEspecialidad As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelCentro As Label
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonEliminar As Button

End Class
