<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suministro_pag
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
        DataGridView1 = New DataGridView()
        TextBoxDescripcion = New TextBox()
        IDlabel = New Label()
        LabelDescripcion = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBoxCategoria = New TextBox()
        TextBoxPesoUnitario = New TextBox()
        Button1 = New Button()
        Editar = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(743, 279)
        DataGridView1.TabIndex = 0
        ' 
        ' TextBoxDescripcion
        ' 
        TextBoxDescripcion.Location = New Point(214, 323)
        TextBoxDescripcion.Name = "TextBoxDescripcion"
        TextBoxDescripcion.Size = New Size(125, 27)
        TextBoxDescripcion.TabIndex = 1
        ' 
        ' IDlabel
        ' 
        IDlabel.AutoSize = True
        IDlabel.Location = New Point(41, 300)
        IDlabel.Name = "IDlabel"
        IDlabel.Size = New Size(27, 20)
        IDlabel.TabIndex = 2
        IDlabel.Text = "ID:"
        ' 
        ' LabelDescripcion
        ' 
        LabelDescripcion.AutoSize = True
        LabelDescripcion.Location = New Point(214, 300)
        LabelDescripcion.Name = "LabelDescripcion"
        LabelDescripcion.Size = New Size(87, 20)
        LabelDescripcion.TabIndex = 3
        LabelDescripcion.Text = "Descripción"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(434, 300)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 4
        Label3.Text = "Categoria"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(646, 300)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 20)
        Label4.TabIndex = 5
        Label4.Text = "PesoUnitario"
        ' 
        ' TextBoxCategoria
        ' 
        TextBoxCategoria.Location = New Point(434, 323)
        TextBoxCategoria.Name = "TextBoxCategoria"
        TextBoxCategoria.Size = New Size(120, 27)
        TextBoxCategoria.TabIndex = 8
        ' 
        ' TextBoxPesoUnitario
        ' 
        TextBoxPesoUnitario.Location = New Point(646, 323)
        TextBoxPesoUnitario.Name = "TextBoxPesoUnitario"
        TextBoxPesoUnitario.Size = New Size(125, 27)
        TextBoxPesoUnitario.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(828, 280)
        Button1.Name = "Button1"
        Button1.Size = New Size(8, 8)
        Button1.TabIndex = 10
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Editar
        ' 
        Editar.BackColor = SystemColors.ActiveCaption
        Editar.Location = New Point(817, 371)
        Editar.Name = "Editar"
        Editar.Size = New Size(94, 29)
        Editar.TabIndex = 11
        Editar.Text = "Editar"
        Editar.UseVisualStyleBackColor = False
        ' 
        ' Suministro_pag
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Editar)
        Controls.Add(Button1)
        Controls.Add(TextBoxPesoUnitario)
        Controls.Add(TextBoxCategoria)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(LabelDescripcion)
        Controls.Add(IDlabel)
        Controls.Add(TextBoxDescripcion)
        Controls.Add(DataGridView1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Suministro_pag"
        Size = New Size(941, 435)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents IDlabel As Label
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCategoria As TextBox
    Friend WithEvents TextBoxPesoUnitario As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Editar As Button

End Class
