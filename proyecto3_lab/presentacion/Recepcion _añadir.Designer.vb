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
        Label2 = New Label()
        Origen = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 4
        Label1.Text = "Centro"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AccessibleName = "ComboBoxCentro"
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(27, 45)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(138, 28)
        ComboBox1.TabIndex = 8
        ComboBox1.Text = "Centro"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.AccessibleName = "ComboBoxVoluntario"
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(27, 128)
        ComboBox2.Margin = New Padding(3, 4, 3, 4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(138, 28)
        ComboBox2.TabIndex = 9
        ComboBox2.Text = "Voluntario"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.AccessibleName = "DatePickerFecha"
        DateTimePicker1.Location = New Point(519, 126)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(228, 27)
        DateTimePicker1.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.AccessibleName = "TextBoxOrigen"
        TextBox1.Location = New Point(519, 46)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(114, 27)
        TextBox1.TabIndex = 11
        TextBox1.Text = "Origen"
        ' 
        ' Button1
        ' 
        Button1.AccessibleName = "BtnConfirmar"
        Button1.Location = New Point(610, 349)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 12
        Button1.Text = "Confirmar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AccessibleName = "Voluntario"
        Label2.AutoSize = True
        Label2.Location = New Point(27, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 13
        Label2.Text = "Voluntario"
        ' 
        ' Origen
        ' 
        Origen.AccessibleName = "Voluntario"
        Origen.AutoSize = True
        Origen.Location = New Point(519, 21)
        Origen.Name = "Origen"
        Origen.Size = New Size(54, 20)
        Origen.TabIndex = 14
        Origen.Text = "Origen"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(519, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 15
        Label3.Text = "Fecha"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(14, 188)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(429, 255)
        DataGridView1.TabIndex = 26
        ' 
        ' Recepcion__añadir
        ' 
        AccessibleName = "Voluntario"
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Origen)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Recepcion__añadir"
        Size = New Size(913, 557)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Origen As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView

End Class
