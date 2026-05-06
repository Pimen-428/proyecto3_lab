<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entregas_pag
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
        CentroOrigen = New Label()
        ComboBoxDestino = New ComboBox()
        ZonaDestino = New Label()
        ComboBoxVoluntarios = New ComboBox()
        Label2 = New Label()
        Label4 = New Label()
        fecha = New DateTimePicker()
        DataGridView = New DataGridView()
        BtnConfirmar = New Button()
        Panel_editar = New Panel()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel_editar.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBoxOrigen
        ' 
        ComboBoxOrigen.FormattingEnabled = True
        ComboBoxOrigen.Location = New Point(48, 101)
        ComboBoxOrigen.Name = "ComboBoxOrigen"
        ComboBoxOrigen.Size = New Size(151, 28)
        ComboBoxOrigen.TabIndex = 1
        ' 
        ' CentroOrigen
        ' 
        CentroOrigen.AutoSize = True
        CentroOrigen.Location = New Point(53, 51)
        CentroOrigen.Margin = New Padding(2, 0, 2, 0)
        CentroOrigen.Name = "CentroOrigen"
        CentroOrigen.Size = New Size(123, 20)
        CentroOrigen.TabIndex = 2
        CentroOrigen.Text = "Centro de Origen"
        ' 
        ' ComboBoxDestino
        ' 
        ComboBoxDestino.FormattingEnabled = True
        ComboBoxDestino.Location = New Point(486, 101)
        ComboBoxDestino.Name = "ComboBoxDestino"
        ComboBoxDestino.Size = New Size(151, 28)
        ComboBoxDestino.TabIndex = 3
        ' 
        ' ZonaDestino
        ' 
        ZonaDestino.AutoSize = True
        ZonaDestino.Location = New Point(513, 51)
        ZonaDestino.Margin = New Padding(2, 0, 2, 0)
        ZonaDestino.Name = "ZonaDestino"
        ZonaDestino.Size = New Size(117, 20)
        ZonaDestino.TabIndex = 4
        ZonaDestino.Text = "Zona de destino"
        ' 
        ' ComboBoxVoluntarios
        ' 
        ComboBoxVoluntarios.FormattingEnabled = True
        ComboBoxVoluntarios.Location = New Point(53, 250)
        ComboBoxVoluntarios.Name = "ComboBoxVoluntarios"
        ComboBoxVoluntarios.Size = New Size(151, 28)
        ComboBoxVoluntarios.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 202)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 20)
        Label2.TabIndex = 8
        Label2.Text = "Voluntario encargado"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(542, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 10
        Label4.Text = "Fecha envio"
        ' 
        ' fecha
        ' 
        fecha.Location = New Point(427, 251)
        fecha.Name = "fecha"
        fecha.Size = New Size(308, 27)
        fecha.TabIndex = 11
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(18, 321)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.Size = New Size(398, 300)
        DataGridView.TabIndex = 12
        ' 
        ' BtnConfirmar
        ' 
        BtnConfirmar.Location = New Point(542, 547)
        BtnConfirmar.Name = "BtnConfirmar"
        BtnConfirmar.Size = New Size(94, 29)
        BtnConfirmar.TabIndex = 13
        BtnConfirmar.Text = "Confirmar"
        BtnConfirmar.UseVisualStyleBackColor = True
        ' 
        ' Panel_editar
        ' 
        Panel_editar.Controls.Add(DataGridView)
        Panel_editar.Controls.Add(ComboBoxOrigen)
        Panel_editar.Controls.Add(ComboBoxVoluntarios)
        Panel_editar.Controls.Add(Label2)
        Panel_editar.Controls.Add(ComboBoxDestino)
        Panel_editar.Controls.Add(Label4)
        Panel_editar.Controls.Add(fecha)
        Panel_editar.Controls.Add(ZonaDestino)
        Panel_editar.Controls.Add(BtnConfirmar)
        Panel_editar.Controls.Add(CentroOrigen)
        Panel_editar.Location = New Point(17, 20)
        Panel_editar.Margin = New Padding(2, 2, 2, 2)
        Panel_editar.Name = "Panel_editar"
        Panel_editar.Size = New Size(762, 653)
        Panel_editar.TabIndex = 15
        ' 
        ' Entregas_pag
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel_editar)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Entregas_pag"
        Size = New Size(779, 717)
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel_editar.ResumeLayout(False)
        Panel_editar.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboBoxOrigen As ComboBox
    Friend WithEvents CentroOrigen As Label
    Friend WithEvents ComboBoxDestino As ComboBox
    Friend WithEvents ZonaDestino As Label
    Friend WithEvents ComboBoxVoluntarios As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents Panel_editar As Panel

End Class
