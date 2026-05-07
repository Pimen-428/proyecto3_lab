<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suministros_por_fechas
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
        cmbZonas = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        dtpInicio = New DateTimePicker()
        dtpFin = New DateTimePicker()
        dgvHistorial = New DataGridView()
        btnGenerar = New Button()
        CType(dgvHistorial, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbZonas
        ' 
        cmbZonas.FormattingEnabled = True
        cmbZonas.Location = New Point(124, 110)
        cmbZonas.Name = "cmbZonas"
        cmbZonas.Size = New Size(182, 33)
        cmbZonas.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(142, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 25)
        Label1.TabIndex = 1
        Label1.Text = "Zona de Destino"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(580, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 25)
        Label2.TabIndex = 2
        Label2.Text = "Fecha Inicio"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(580, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 25)
        Label3.TabIndex = 3
        Label3.Text = "Fecha Fin"
        ' 
        ' dtpInicio
        ' 
        dtpInicio.Location = New Point(795, 64)
        dtpInicio.Name = "dtpInicio"
        dtpInicio.Size = New Size(300, 31)
        dtpInicio.TabIndex = 4
        ' 
        ' dtpFin
        ' 
        dtpFin.Location = New Point(795, 219)
        dtpFin.Name = "dtpFin"
        dtpFin.Size = New Size(300, 31)
        dtpFin.TabIndex = 5
        ' 
        ' dgvHistorial
        ' 
        dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistorial.Location = New Point(34, 318)
        dgvHistorial.Name = "dgvHistorial"
        dgvHistorial.RowHeadersWidth = 62
        dgvHistorial.Size = New Size(531, 382)
        dgvHistorial.TabIndex = 6
        ' 
        ' btnGenerar
        ' 
        btnGenerar.Location = New Point(818, 522)
        btnGenerar.Name = "btnGenerar"
        btnGenerar.Size = New Size(130, 33)
        btnGenerar.TabIndex = 7
        btnGenerar.Text = "Generar"
        btnGenerar.UseVisualStyleBackColor = True
        ' 
        ' Suministros_por_fechas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnGenerar)
        Controls.Add(dgvHistorial)
        Controls.Add(dtpFin)
        Controls.Add(dtpInicio)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbZonas)
        Name = "Suministros_por_fechas"
        Size = New Size(1201, 784)
        CType(dgvHistorial, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbZonas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents btnGenerar As Button

End Class
