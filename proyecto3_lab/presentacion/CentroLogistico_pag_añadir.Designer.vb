<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CentroLogistico_pag_añadir
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
        ButtonAñadir = New Button()
        TextBoxNombre = New TextBox()
        TextBoxCiudad = New TextBox()
        TextBoxCapacidad = New TextBox()
        LabelCiudad = New Label()
        LabelNombre = New Label()
        LabelCantidad = New Label()
        SuspendLayout()
        ' 
        ' ButtonAñadir
        ' 
        ButtonAñadir.Location = New Point(54, 235)
        ButtonAñadir.Name = "ButtonAñadir"
        ButtonAñadir.Size = New Size(94, 29)
        ButtonAñadir.TabIndex = 0
        ButtonAñadir.Text = "Añadir"
        ButtonAñadir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Location = New Point(54, 147)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 1
        ' 
        ' TextBoxCiudad
        ' 
        TextBoxCiudad.Location = New Point(219, 147)
        TextBoxCiudad.Name = "TextBoxCiudad"
        TextBoxCiudad.Size = New Size(125, 27)
        TextBoxCiudad.TabIndex = 2
        ' 
        ' TextBoxCapacidad
        ' 
        TextBoxCapacidad.Location = New Point(379, 147)
        TextBoxCapacidad.Name = "TextBoxCapacidad"
        TextBoxCapacidad.Size = New Size(125, 27)
        TextBoxCapacidad.TabIndex = 3
        ' 
        ' LabelCiudad
        ' 
        LabelCiudad.AutoSize = True
        LabelCiudad.Location = New Point(219, 107)
        LabelCiudad.Name = "LabelCiudad"
        LabelCiudad.Size = New Size(56, 20)
        LabelCiudad.TabIndex = 4
        LabelCiudad.Text = "Ciudad"
        ' 
        ' LabelNombre
        ' 
        LabelNombre.AutoSize = True
        LabelNombre.Location = New Point(54, 107)
        LabelNombre.Name = "LabelNombre"
        LabelNombre.Size = New Size(64, 20)
        LabelNombre.TabIndex = 5
        LabelNombre.Text = "Nombre"
        ' 
        ' LabelCantidad
        ' 
        LabelCantidad.AutoSize = True
        LabelCantidad.Location = New Point(379, 107)
        LabelCantidad.Name = "LabelCantidad"
        LabelCantidad.Size = New Size(122, 20)
        LabelCantidad.TabIndex = 6
        LabelCantidad.Text = "Almacenamiento"
        ' 
        ' CentroLogistico_pag_añadir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(LabelCantidad)
        Controls.Add(LabelNombre)
        Controls.Add(LabelCiudad)
        Controls.Add(TextBoxCapacidad)
        Controls.Add(TextBoxCiudad)
        Controls.Add(TextBoxNombre)
        Controls.Add(ButtonAñadir)
        Name = "CentroLogistico_pag_añadir"
        Size = New Size(535, 347)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonAñadir As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxCiudad As TextBox
    Friend WithEvents TextBoxCapacidad As TextBox
    Friend WithEvents LabelCiudad As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelCantidad As Label

End Class
