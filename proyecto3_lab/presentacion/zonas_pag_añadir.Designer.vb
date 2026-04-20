<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zonas_pag_añadir
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
        txt_nombre = New TextBox()
        txt_pais = New TextBox()
        txt_urgencia = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btn_guardar = New Button()
        CType(txt_urgencia, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(54, 142)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(150, 31)
        txt_nombre.TabIndex = 0
        ' 
        ' txt_pais
        ' 
        txt_pais.Location = New Point(374, 142)
        txt_pais.Name = "txt_pais"
        txt_pais.Size = New Size(150, 31)
        txt_pais.TabIndex = 1
        ' 
        ' txt_urgencia
        ' 
        txt_urgencia.Location = New Point(54, 303)
        txt_urgencia.Name = "txt_urgencia"
        txt_urgencia.Size = New Size(180, 31)
        txt_urgencia.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(87, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 3
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(423, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 25)
        Label2.TabIndex = 4
        Label2.Text = "Pais"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 25)
        Label3.TabIndex = 5
        Label3.Text = "Nivel de Urgencia"
        ' 
        ' btn_guardar
        ' 
        btn_guardar.BackColor = SystemColors.ControlDark
        btn_guardar.Location = New Point(395, 303)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(112, 34)
        btn_guardar.TabIndex = 6
        btn_guardar.Text = "Añadir"
        btn_guardar.UseVisualStyleBackColor = False
        ' 
        ' zonas_pag_añadir
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btn_guardar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_urgencia)
        Controls.Add(txt_pais)
        Controls.Add(txt_nombre)
        Name = "zonas_pag_añadir"
        Size = New Size(588, 491)
        CType(txt_urgencia, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents txt_urgencia As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_guardar As Button

End Class
