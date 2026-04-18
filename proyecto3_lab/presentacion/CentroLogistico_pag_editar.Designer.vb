<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CentroLogistico_pag_editar
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
        ButtonEditar = New Button()
        ButtonEliminar = New Button()
        LabelId = New Label()
        LabelNombre = New Label()
        LabelCiudad = New Label()
        LabelCantidad = New Label()
        TextBoxid = New TextBox()
        TextBoxnombre = New TextBox()
        TextBoxCiudad = New TextBox()
        TextBoxAlmacenamiento = New TextBox()
        SuspendLayout()
        ' 
        ' ButtonEditar
        ' 
        ButtonEditar.BackColor = SystemColors.ControlDark
        ButtonEditar.Location = New Point(67, 318)
        ButtonEditar.Name = "ButtonEditar"
        ButtonEditar.Size = New Size(94, 29)
        ButtonEditar.TabIndex = 0
        ButtonEditar.Text = "Editar"
        ButtonEditar.UseVisualStyleBackColor = False
        ' 
        ' ButtonEliminar
        ' 
        ButtonEliminar.BackColor = SystemColors.Highlight
        ButtonEliminar.Location = New Point(357, 318)
        ButtonEliminar.Name = "ButtonEliminar"
        ButtonEliminar.Size = New Size(94, 29)
        ButtonEliminar.TabIndex = 1
        ButtonEliminar.Text = "Eliminar"
        ButtonEliminar.UseVisualStyleBackColor = False
        ' 
        ' LabelId
        ' 
        LabelId.AutoSize = True
        LabelId.Location = New Point(67, 56)
        LabelId.Name = "LabelId"
        LabelId.Size = New Size(70, 20)
        LabelId.TabIndex = 2
        LabelId.Text = "Id Centro"
        ' 
        ' LabelNombre
        ' 
        LabelNombre.AutoSize = True
        LabelNombre.Location = New Point(67, 170)
        LabelNombre.Name = "LabelNombre"
        LabelNombre.Size = New Size(64, 20)
        LabelNombre.TabIndex = 3
        LabelNombre.Text = "Nombre"
        ' 
        ' LabelCiudad
        ' 
        LabelCiudad.AutoSize = True
        LabelCiudad.Location = New Point(357, 56)
        LabelCiudad.Name = "LabelCiudad"
        LabelCiudad.Size = New Size(56, 20)
        LabelCiudad.TabIndex = 4
        LabelCiudad.Text = "Ciudad"
        ' 
        ' LabelCantidad
        ' 
        LabelCantidad.AutoSize = True
        LabelCantidad.Location = New Point(357, 170)
        LabelCantidad.Name = "LabelCantidad"
        LabelCantidad.Size = New Size(122, 20)
        LabelCantidad.TabIndex = 5
        LabelCantidad.Text = "Almacenamiento"
        ' 
        ' TextBoxid
        ' 
        TextBoxid.Location = New Point(67, 104)
        TextBoxid.Name = "TextBoxid"
        TextBoxid.Size = New Size(125, 27)
        TextBoxid.TabIndex = 6
        ' 
        ' TextBoxnombre
        ' 
        TextBoxnombre.Location = New Point(67, 218)
        TextBoxnombre.Name = "TextBoxnombre"
        TextBoxnombre.Size = New Size(125, 27)
        TextBoxnombre.TabIndex = 7
        ' 
        ' TextBoxCiudad
        ' 
        TextBoxCiudad.Location = New Point(357, 104)
        TextBoxCiudad.Name = "TextBoxCiudad"
        TextBoxCiudad.Size = New Size(125, 27)
        TextBoxCiudad.TabIndex = 8
        ' 
        ' TextBoxAlmacenamiento
        ' 
        TextBoxAlmacenamiento.Location = New Point(357, 218)
        TextBoxAlmacenamiento.Name = "TextBoxAlmacenamiento"
        TextBoxAlmacenamiento.Size = New Size(125, 27)
        TextBoxAlmacenamiento.TabIndex = 9
        ' 
        ' CentroLogistico_pag_editar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TextBoxAlmacenamiento)
        Controls.Add(TextBoxCiudad)
        Controls.Add(TextBoxnombre)
        Controls.Add(TextBoxid)
        Controls.Add(LabelCantidad)
        Controls.Add(LabelCiudad)
        Controls.Add(LabelNombre)
        Controls.Add(LabelId)
        Controls.Add(ButtonEliminar)
        Controls.Add(ButtonEditar)
        Name = "CentroLogistico_pag_editar"
        Size = New Size(653, 399)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents LabelId As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelCiudad As Label
    Friend WithEvents LabelCantidad As Label
    Friend WithEvents TextBoxid As TextBox
    Friend WithEvents TextBoxnombre As TextBox
    Friend WithEvents TextBoxCiudad As TextBox
    Friend WithEvents TextBoxAlmacenamiento As TextBox

End Class
