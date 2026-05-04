<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voluntarios_pag_añadir
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
        Añadir_boton = New Button()
        TextBoxEspecialidad_añadir = New TextBox()
        TextBoxNombre_añadir = New TextBox()
        ComboBox_añadir = New ComboBox()
        TextBoxDni_añadir = New TextBox()
        centro_label = New Label()
        especialidad_label = New Label()
        Nombre_label = New Label()
        DNI_label = New Label()
        SuspendLayout()
        ' 
        ' Añadir_boton
        ' 
        Añadir_boton.BackColor = SystemColors.AppWorkspace
        Añadir_boton.ForeColor = SystemColors.ControlText
        Añadir_boton.Location = New Point(59, 238)
        Añadir_boton.Margin = New Padding(3, 2, 3, 2)
        Añadir_boton.Name = "Añadir_boton"
        Añadir_boton.Size = New Size(82, 22)
        Añadir_boton.TabIndex = 11
        Añadir_boton.Text = "Añadir"
        Añadir_boton.UseVisualStyleBackColor = False
        ' 
        ' TextBoxEspecialidad_añadir
        ' 
        TextBoxEspecialidad_añadir.Location = New Point(188, 195)
        TextBoxEspecialidad_añadir.Margin = New Padding(3, 2, 3, 2)
        TextBoxEspecialidad_añadir.Name = "TextBoxEspecialidad_añadir"
        TextBoxEspecialidad_añadir.Size = New Size(110, 23)
        TextBoxEspecialidad_añadir.TabIndex = 19
        ' 
        ' TextBoxNombre_añadir
        ' 
        TextBoxNombre_añadir.Location = New Point(380, 104)
        TextBoxNombre_añadir.Margin = New Padding(3, 2, 3, 2)
        TextBoxNombre_añadir.Name = "TextBoxNombre_añadir"
        TextBoxNombre_añadir.Size = New Size(110, 23)
        TextBoxNombre_añadir.TabIndex = 18
        ' 
        ' ComboBox_añadir
        ' 
        ComboBox_añadir.FormattingEnabled = True
        ComboBox_añadir.Location = New Point(380, 194)
        ComboBox_añadir.Margin = New Padding(3, 2, 3, 2)
        ComboBox_añadir.Name = "ComboBox_añadir"
        ComboBox_añadir.Size = New Size(133, 23)
        ComboBox_añadir.TabIndex = 17
        ' 
        ' TextBoxDni_añadir
        ' 
        TextBoxDni_añadir.Location = New Point(188, 104)
        TextBoxDni_añadir.Margin = New Padding(3, 2, 3, 2)
        TextBoxDni_añadir.Name = "TextBoxDni_añadir"
        TextBoxDni_añadir.Size = New Size(110, 23)
        TextBoxDni_añadir.TabIndex = 16
        ' 
        ' centro_label
        ' 
        centro_label.AutoSize = True
        centro_label.Location = New Point(380, 154)
        centro_label.Name = "centro_label"
        centro_label.Size = New Size(124, 15)
        centro_label.TabIndex = 15
        centro_label.Text = "Centro de pertenencia"
        ' 
        ' especialidad_label
        ' 
        especialidad_label.AutoSize = True
        especialidad_label.Location = New Point(188, 154)
        especialidad_label.Name = "especialidad_label"
        especialidad_label.Size = New Size(72, 15)
        especialidad_label.TabIndex = 14
        especialidad_label.Text = "Especialidad"
        ' 
        ' Nombre_label
        ' 
        Nombre_label.AutoSize = True
        Nombre_label.Location = New Point(380, 65)
        Nombre_label.Name = "Nombre_label"
        Nombre_label.Size = New Size(49, 15)
        Nombre_label.TabIndex = 13
        Nombre_label.Text = "nombre"
        ' 
        ' DNI_label
        ' 
        DNI_label.AutoSize = True
        DNI_label.Location = New Point(188, 65)
        DNI_label.Name = "DNI_label"
        DNI_label.Size = New Size(27, 15)
        DNI_label.TabIndex = 12
        DNI_label.Text = "DNI"
        ' 
        ' voluntarios_pag_añadir
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TextBoxEspecialidad_añadir)
        Controls.Add(TextBoxNombre_añadir)
        Controls.Add(ComboBox_añadir)
        Controls.Add(TextBoxDni_añadir)
        Controls.Add(centro_label)
        Controls.Add(especialidad_label)
        Controls.Add(Nombre_label)
        Controls.Add(DNI_label)
        Controls.Add(Añadir_boton)
        Margin = New Padding(3, 2, 3, 2)
        Name = "voluntarios_pag_añadir"
        Size = New Size(691, 314)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Añadir_boton As Button
    Friend WithEvents TextBoxEspecialidad_añadir As TextBox
    Friend WithEvents TextBoxNombre_añadir As TextBox
    Friend WithEvents ComboBox_añadir As ComboBox
    Friend WithEvents TextBoxDni_añadir As TextBox
    Friend WithEvents centro_label As Label
    Friend WithEvents especialidad_label As Label
    Friend WithEvents Nombre_label As Label
    Friend WithEvents DNI_label As Label

End Class
