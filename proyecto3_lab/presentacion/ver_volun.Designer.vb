<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ver_volun
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
        ListBox1 = New ListBox()
        boton_volver = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(40, 83)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(296, 304)
        ListBox1.TabIndex = 0
        ' 
        ' boton_volver
        ' 
        boton_volver.BackColor = SystemColors.Highlight
        boton_volver.Location = New Point(12, 12)
        boton_volver.Name = "boton_volver"
        boton_volver.Size = New Size(94, 29)
        boton_volver.TabIndex = 1
        boton_volver.Text = "volver"
        boton_volver.UseVisualStyleBackColor = False
        ' 
        ' ver_volun
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(boton_volver)
        Controls.Add(ListBox1)
        Name = "ver_volun"
        Text = "aniadir_voluntarios"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents boton_volver As Button
End Class
