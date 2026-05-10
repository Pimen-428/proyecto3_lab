<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recepcion__añadir
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
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AccessibleName = "ComboBoxCentro"
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(24, 107)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 8
        ComboBox1.Text = "Centro"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.AccessibleName = "ComboBoxVoluntario"
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(271, 107)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 9
        ComboBox2.Text = "Voluntario"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.AccessibleName = "DatePickerFecha"
        DateTimePicker1.Location = New Point(258, 190)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.AccessibleName = "TextBoxOrigen"
        TextBox1.Location = New Point(33, 178)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 11
        TextBox1.Text = "Origen"
        ' 
        ' Button1
        ' 
        Button1.AccessibleName = "BtnConfirmar"
        Button1.Location = New Point(136, 250)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 12
        Button1.Text = "Confirmar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Recepcion__añadir
        ' 
        AccessibleName = "ComboBoxCentro"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "Recepcion__añadir"
        Size = New Size(485, 330)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button

End Class
