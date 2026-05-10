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
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 4
        Label1.Text = "Centro"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AccessibleName = "ComboBoxCentro"
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(24, 34)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 8
        ComboBox1.Text = "Centro"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.AccessibleName = "ComboBoxVoluntario"
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(12, 96)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 9
        ComboBox2.Text = "Voluntario"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.AccessibleName = "DatePickerFecha"
        DateTimePicker1.Location = New Point(164, 96)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.AccessibleName = "TextBoxOrigen"
        TextBox1.Location = New Point(179, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 11
        TextBox1.Text = "Origen"
        ' 
        ' Button1
        ' 
        Button1.AccessibleName = "BtnConfirmar"
        Button1.Location = New Point(195, 304)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 12
        Button1.Text = "Confirmar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AccessibleName = "Voluntario"
        Label2.AutoSize = True
        Label2.Location = New Point(24, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 13
        Label2.Text = "Voluntario"
        ' 
        ' Origen
        ' 
        Origen.AccessibleName = "Voluntario"
        Origen.AutoSize = True
        Origen.Location = New Point(195, 16)
        Origen.Name = "Origen"
        Origen.Size = New Size(43, 15)
        Origen.TabIndex = 14
        Origen.Text = "Origen"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(195, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 15
        Label3.Text = "Fecha"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 18
        Label4.Text = "Cantidad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(179, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 19
        Label5.Text = "Descripción"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 168)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 20
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(170, 168)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 21
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(24, 257)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 22
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(170, 267)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(37, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 15)
        Label6.TabIndex = 24
        Label6.Text = "Categoría"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(179, 249)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 15)
        Label7.TabIndex = 25
        Label7.Text = "Peso unitario"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(488, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(293, 390)
        DataGridView1.TabIndex = 26
        ' 
        ' Recepcion__añadir
        ' 
        AccessibleName = "Voluntario"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DataGridView1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Origen)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "Recepcion__añadir"
        Size = New Size(799, 418)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView

End Class
