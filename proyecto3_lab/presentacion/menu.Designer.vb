<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        labelmenu = New Label()
        voluntarios_boton = New Button()
        CheckedListBox1 = New CheckedListBox()
        SuspendLayout()
        ' 
        ' labelmenu
        ' 
        labelmenu.AutoSize = True
        labelmenu.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelmenu.Location = New Point(133, 60)
        labelmenu.Name = "labelmenu"
        labelmenu.Size = New Size(526, 54)
        labelmenu.TabIndex = 0
        labelmenu.Text = "¿Qué es lo que desea hacer?"
        ' 
        ' voluntarios_boton
        ' 
        voluntarios_boton.Location = New Point(310, 156)
        voluntarios_boton.Name = "voluntarios_boton"
        voluntarios_boton.Size = New Size(164, 29)
        voluntarios_boton.TabIndex = 1
        voluntarios_boton.Text = "ver voluntarios"
        voluntarios_boton.UseVisualStyleBackColor = True
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(20, 25)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(150, 400)
        CheckedListBox1.TabIndex = 2
        ' 
        ' menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CheckedListBox1)
        Controls.Add(voluntarios_boton)
        Controls.Add(labelmenu)
        Name = "menu"
        Text = "menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelmenu As Label
    Friend WithEvents voluntarios_boton As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
