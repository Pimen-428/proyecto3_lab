<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class envios_pag
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
        ComboBoxOrigen = New ComboBox()
        ComboBoxDestino = New ComboBox()
        ComboBoxVoluntarios = New ComboBox()
        DataGridView = New DataGridView()
        ButtonConfirmar = New Button()
        fecha = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBoxOrigen
        ' 
        ComboBoxOrigen.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxOrigen.FormattingEnabled = True
        ComboBoxOrigen.Location = New Point(46, 55)
        ComboBoxOrigen.Name = "ComboBoxOrigen"
        ComboBoxOrigen.Size = New Size(151, 28)
        ComboBoxOrigen.TabIndex = 0
        ' 
        ' ComboBoxDestino
        ' 
        ComboBoxDestino.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxDestino.FormattingEnabled = True
        ComboBoxDestino.Location = New Point(402, 55)
        ComboBoxDestino.Name = "ComboBoxDestino"
        ComboBoxDestino.Size = New Size(151, 28)
        ComboBoxDestino.TabIndex = 1
        ' 
        ' ComboBoxVoluntarios
        ' 
        ComboBoxVoluntarios.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxVoluntarios.FormattingEnabled = True
        ComboBoxVoluntarios.Location = New Point(46, 155)
        ComboBoxVoluntarios.Name = "ComboBoxVoluntarios"
        ComboBoxVoluntarios.Size = New Size(151, 28)
        ComboBoxVoluntarios.TabIndex = 2
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(3, 214)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.Size = New Size(398, 300)
        DataGridView.TabIndex = 3
        ' 
        ' ButtonConfirmar
        ' 
        ButtonConfirmar.Location = New Point(616, 520)
        ButtonConfirmar.Name = "ButtonConfirmar"
        ButtonConfirmar.Size = New Size(94, 29)
        ButtonConfirmar.TabIndex = 4
        ButtonConfirmar.Text = "Confirmar"
        ButtonConfirmar.UseVisualStyleBackColor = True
        ' 
        ' fecha
        ' 
        fecha.Location = New Point(402, 156)
        fecha.Name = "fecha"
        fecha.Size = New Size(308, 27)
        fecha.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 20)
        Label1.TabIndex = 6
        Label1.Text = "Centro Origen"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 20)
        Label2.TabIndex = 7
        Label2.Text = "Voluntario encargado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(402, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 8
        Label3.Text = "Centro Destino"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(402, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 9
        Label4.Text = "Fecha envio"
        ' 
        ' envios_pag
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(fecha)
        Controls.Add(ButtonConfirmar)
        Controls.Add(DataGridView)
        Controls.Add(ComboBoxVoluntarios)
        Controls.Add(ComboBoxDestino)
        Controls.Add(ComboBoxOrigen)
        Name = "envios_pag"
        Size = New Size(838, 583)
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxOrigen As ComboBox
    Friend WithEvents ComboBoxDestino As ComboBox
    Friend WithEvents ComboBoxVoluntarios As ComboBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ButtonConfirmar As Button
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
