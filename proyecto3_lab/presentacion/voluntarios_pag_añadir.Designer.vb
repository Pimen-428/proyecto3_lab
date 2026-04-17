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
        Añadir_boton.Location = New Point(67, 317)
        Añadir_boton.Name = "Añadir_boton"
        Añadir_boton.Size = New Size(94, 29)
        Añadir_boton.TabIndex = 11
        Añadir_boton.Text = "Añadir"
        Añadir_boton.UseVisualStyleBackColor = False
        ' 
        ' TextBoxEspecialidad_añadir
        ' 
        TextBoxEspecialidad_añadir.Location = New Point(215, 260)
        TextBoxEspecialidad_añadir.Name = "TextBoxEspecialidad_añadir"
        TextBoxEspecialidad_añadir.Size = New Size(125, 27)
        TextBoxEspecialidad_añadir.TabIndex = 19
        ' 
        ' TextBoxNombre_añadir
        ' 
        TextBoxNombre_añadir.Location = New Point(434, 138)
        TextBoxNombre_añadir.Name = "TextBoxNombre_añadir"
        TextBoxNombre_añadir.Size = New Size(125, 27)
        TextBoxNombre_añadir.TabIndex = 18
        ' 
        ' ComboBox_añadir
        ' 
        ComboBox_añadir.FormattingEnabled = True
        ComboBox_añadir.Location = New Point(434, 259)
        ComboBox_añadir.Name = "ComboBox_añadir"
        ComboBox_añadir.Size = New Size(151, 28)
        ComboBox_añadir.TabIndex = 17
        ' 
        ' TextBoxDni_añadir
        ' 
        TextBoxDni_añadir.Location = New Point(212, 138)
        TextBoxDni_añadir.Name = "TextBoxDni_añadir"
        TextBoxDni_añadir.Size = New Size(125, 27)
        TextBoxDni_añadir.TabIndex = 16
        ' 
        ' centro_label
        ' 
        centro_label.AutoSize = True
        centro_label.Location = New Point(434, 206)
        centro_label.Name = "centro_label"
        centro_label.Size = New Size(156, 20)
        centro_label.TabIndex = 15
        centro_label.Text = "Centro de pertenencia"
        ' 
        ' especialidad_label
        ' 
        especialidad_label.AutoSize = True
        especialidad_label.Location = New Point(215, 206)
        especialidad_label.Name = "especialidad_label"
        especialidad_label.Size = New Size(93, 20)
        especialidad_label.TabIndex = 14
        especialidad_label.Text = "Especialidad"
        ' 
        ' Nombre_label
        ' 
        Nombre_label.AutoSize = True
        Nombre_label.Location = New Point(434, 87)
        Nombre_label.Name = "Nombre_label"
        Nombre_label.Size = New Size(61, 20)
        Nombre_label.TabIndex = 13
        Nombre_label.Text = "nombre"
        ' 
        ' DNI_label
        ' 
        DNI_label.AutoSize = True
        DNI_label.Location = New Point(215, 87)
        DNI_label.Name = "DNI_label"
        DNI_label.Size = New Size(35, 20)
        DNI_label.TabIndex = 12
        DNI_label.Text = "DNI"
        ' 
        ' voluntarios_pag_añadir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
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
        Name = "voluntarios_pag_añadir"
        Size = New Size(790, 418)
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
