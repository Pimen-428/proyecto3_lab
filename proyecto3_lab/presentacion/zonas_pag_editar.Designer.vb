<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zonas_pag_editar
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
        btn_actualizar = New Button()
        TextBoxNombreEditar = New TextBox()
        TextBoxPaisEditar = New TextBox()
        NumericUpDown1 = New NumericUpDown()
        txt_nombre = New Label()
        txt_pais = New Label()
        txt_urgencia = New Label()
        btn_borrar = New Button()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_actualizar
        ' 
        btn_actualizar.BackColor = SystemColors.ButtonShadow
        btn_actualizar.Location = New Point(49, 475)
        btn_actualizar.Margin = New Padding(4)
        btn_actualizar.Name = "btn_actualizar"
        btn_actualizar.Size = New Size(118, 36)
        btn_actualizar.TabIndex = 9
        btn_actualizar.Text = "Editar Voluntario"
        btn_actualizar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxNombreEditar
        ' 
        TextBoxNombreEditar.Location = New Point(173, 141)
        TextBoxNombreEditar.Margin = New Padding(4)
        TextBoxNombreEditar.Name = "TextBoxNombreEditar"
        TextBoxNombreEditar.Size = New Size(155, 31)
        TextBoxNombreEditar.TabIndex = 10
        ' 
        ' TextBoxPaisEditar
        ' 
        TextBoxPaisEditar.Location = New Point(514, 141)
        TextBoxPaisEditar.Margin = New Padding(4)
        TextBoxPaisEditar.Name = "TextBoxPaisEditar"
        TextBoxPaisEditar.Size = New Size(155, 31)
        TextBoxPaisEditar.TabIndex = 11
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(301, 330)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(239, 31)
        NumericUpDown1.TabIndex = 12
        ' 
        ' txt_nombre
        ' 
        txt_nombre.AutoSize = True
        txt_nombre.Location = New Point(198, 78)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(78, 25)
        txt_nombre.TabIndex = 13
        txt_nombre.Text = "Nombre"
        ' 
        ' txt_pais
        ' 
        txt_pais.AutoSize = True
        txt_pais.Location = New Point(565, 87)
        txt_pais.Name = "txt_pais"
        txt_pais.Size = New Size(42, 25)
        txt_pais.TabIndex = 14
        txt_pais.Text = "Pais"
        ' 
        ' txt_urgencia
        ' 
        txt_urgencia.AutoSize = True
        txt_urgencia.Location = New Point(343, 281)
        txt_urgencia.Name = "txt_urgencia"
        txt_urgencia.Size = New Size(150, 25)
        txt_urgencia.TabIndex = 15
        txt_urgencia.Text = "Nivel de Urgencia"
        ' 
        ' btn_borrar
        ' 
        btn_borrar.Location = New Point(686, 477)
        btn_borrar.Name = "btn_borrar"
        btn_borrar.Size = New Size(112, 34)
        btn_borrar.TabIndex = 16
        btn_borrar.Text = "Borrar"
        btn_borrar.UseVisualStyleBackColor = True
        ' 
        ' zonas_pag_editar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btn_borrar)
        Controls.Add(txt_urgencia)
        Controls.Add(txt_pais)
        Controls.Add(txt_nombre)
        Controls.Add(NumericUpDown1)
        Controls.Add(TextBoxPaisEditar)
        Controls.Add(TextBoxNombreEditar)
        Controls.Add(btn_actualizar)
        Name = "zonas_pag_editar"
        Size = New Size(871, 547)
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_actualizar As Button
    Friend WithEvents TextBoxNombreEditar As TextBox
    Friend WithEvents TextBoxPaisEditar As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents txt_nombre As Label
    Friend WithEvents txt_pais As Label
    Friend WithEvents txt_urgencia As Label
    Friend WithEvents btn_borrar As Button

End Class
