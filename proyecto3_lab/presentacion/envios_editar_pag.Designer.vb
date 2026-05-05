<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class envios_editar_pag
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
        ListBoxenvios = New ListBox()
        IdEnvio = New Label()
        ComboBoxEstados = New ComboBox()
        Label1 = New Label()
        Button1 = New Button()
        ComboBoxEnvio = New ComboBox()
        SuspendLayout()
        ' 
        ' ListBoxenvios
        ' 
        ListBoxenvios.Dock = DockStyle.Left
        ListBoxenvios.FormattingEnabled = True
        ListBoxenvios.Location = New Point(0, 0)
        ListBoxenvios.Name = "ListBoxenvios"
        ListBoxenvios.Size = New Size(150, 458)
        ListBoxenvios.TabIndex = 0
        ' 
        ' IdEnvio
        ' 
        IdEnvio.AutoSize = True
        IdEnvio.Location = New Point(256, 179)
        IdEnvio.Name = "IdEnvio"
        IdEnvio.Size = New Size(58, 20)
        IdEnvio.TabIndex = 2
        IdEnvio.Text = "IdEnvio"
        ' 
        ' ComboBoxEstados
        ' 
        ComboBoxEstados.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxEstados.FormattingEnabled = True
        ComboBoxEstados.Location = New Point(487, 215)
        ComboBoxEstados.Name = "ComboBoxEstados"
        ComboBoxEstados.Size = New Size(151, 28)
        ComboBoxEstados.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(487, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 20)
        Label1.TabIndex = 4
        Label1.Text = "Estado"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(529, 358)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "Confirmar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxEnvio
        ' 
        ComboBoxEnvio.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxEnvio.FormattingEnabled = True
        ComboBoxEnvio.Location = New Point(256, 215)
        ComboBoxEnvio.Name = "ComboBoxEnvio"
        ComboBoxEnvio.Size = New Size(151, 28)
        ComboBoxEnvio.TabIndex = 6
        ' 
        ' envios_editar_pag
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ComboBoxEnvio)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(ComboBoxEstados)
        Controls.Add(IdEnvio)
        Controls.Add(ListBoxenvios)
        Name = "envios_editar_pag"
        Size = New Size(697, 458)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBoxenvios As ListBox
    Friend WithEvents IdEnvio As Label
    Friend WithEvents ComboBoxEstados As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBoxEnvio As ComboBox

End Class
