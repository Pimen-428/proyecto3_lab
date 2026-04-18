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
        ComboBoxDniEditar.Location = New Point(408, 225)
        ComboBoxDniEditar.Name = "ComboBoxDniEditar"
        ComboBoxDniEditar.Size = New Size(151, 28)
        ComboBoxDniEditar.TabIndex = 0
        ' 
        ' TextBoxEspecialidadEditar
        ' 
        TextBoxEspecialidadEditar.Location = New Point(136, 225)
        TextBoxEspecialidadEditar.Name = "TextBoxEspecialidadEditar"
        TextBoxEspecialidadEditar.Size = New Size(125, 27)
        TextBoxEspecialidadEditar.TabIndex = 1
        ' 
        ' TextBoxDniEditar
        ' 
        TextBoxDniEditar.Location = New Point(136, 112)
        TextBoxDniEditar.Name = "TextBoxDniEditar"
        TextBoxDniEditar.Size = New Size(125, 27)
        TextBoxDniEditar.TabIndex = 2
        ' 
        ' TextBoxNombreEditar
        ' 
        TextBoxNombreEditar.Location = New Point(408, 112)
        TextBoxNombreEditar.Name = "TextBoxNombreEditar"
        TextBoxNombreEditar.Size = New Size(125, 27)
        TextBoxNombreEditar.TabIndex = 3
        ' 
        ' DNIlabel
        ' 
        DNIlabel.AutoSize = True
        DNIlabel.Location = New Point(136, 72)
        DNIlabel.Name = "DNIlabel"
        DNIlabel.Size = New Size(35, 20)
        DNIlabel.TabIndex = 4
        DNIlabel.Text = "DNI"
        ' 
        ' LabelEspecialidad
        ' 
        LabelEspecialidad.AutoSize = True
        LabelEspecialidad.Location = New Point(136, 189)
        LabelEspecialidad.Name = "LabelEspecialidad"
        LabelEspecialidad.Size = New Size(93, 20)
        LabelEspecialidad.TabIndex = 5
        LabelEspecialidad.Text = "Especialidad"
        ' 
        ' LabelNombre
        ' 
        LabelNombre.AutoSize = True
        LabelNombre.Location = New Point(408, 72)
        LabelNombre.Name = "LabelNombre"
        LabelNombre.Size = New Size(64, 20)
        LabelNombre.TabIndex = 6
        LabelNombre.Text = "Nombre"
        ' 
        ' LabelCentro
        ' 
        LabelCentro.AutoSize = True
        LabelCentro.Location = New Point(408, 189)
        LabelCentro.Name = "LabelCentro"
        LabelCentro.Size = New Size(53, 20)
        LabelCentro.TabIndex = 7
        LabelCentro.Text = "Centro"
        ' 
        ' ButtonEditar
        ' 
        ButtonEditar.BackColor = SystemColors.ButtonShadow
        ButtonEditar.Location = New Point(123, 323)
        ButtonEditar.Name = "ButtonEditar"
        ButtonEditar.Size = New Size(94, 29)
        ButtonEditar.TabIndex = 8
        ButtonEditar.Text = "Editar Voluntario"
        ButtonEditar.UseVisualStyleBackColor = False
        ' 
        ' ButtonEliminar
        ' 
        ButtonEliminar.BackColor = SystemColors.MenuHighlight
        ButtonEliminar.Location = New Point(465, 323)
        ButtonEliminar.Name = "ButtonEliminar"
        ButtonEliminar.Size = New Size(94, 29)
        ButtonEliminar.TabIndex = 10
        ButtonEliminar.Text = "Eliminar"
        ButtonEliminar.UseVisualStyleBackColor = False
        ' 
        ' voluntarios_pag_editar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
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
        Name = "voluntarios_pag_editar"
        Size = New Size(672, 425)
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
