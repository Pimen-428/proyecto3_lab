<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zonas_pag
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
        Lista_Zonas = New ListBox()
        Añadir = New Button()
        Editar = New Button()
        Panel_Zonas = New Panel()
        Panel_Zonas.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lista_Zonas
        ' 
        Lista_Zonas.FormattingEnabled = True
        Lista_Zonas.Location = New Point(4, 7)
        Lista_Zonas.Name = "Lista_Zonas"
        Lista_Zonas.Size = New Size(266, 1079)
        Lista_Zonas.TabIndex = 0
        ' 
        ' Añadir
        ' 
        Añadir.Location = New Point(824, 1005)
        Añadir.Name = "Añadir"
        Añadir.Size = New Size(112, 34)
        Añadir.TabIndex = 1
        Añadir.Text = "Añadir"
        Añadir.UseVisualStyleBackColor = True
        ' 
        ' Editar
        ' 
        Editar.Location = New Point(996, 1006)
        Editar.Name = "Editar"
        Editar.Size = New Size(112, 34)
        Editar.TabIndex = 2
        Editar.Text = "Editar"
        Editar.UseVisualStyleBackColor = True
        ' 
        ' Panel_Zonas
        ' 
        Panel_Zonas.Controls.Add(Editar)
        Panel_Zonas.Controls.Add(Añadir)
        Panel_Zonas.Location = New Point(277, 27)
        Panel_Zonas.Name = "Panel_Zonas"
        Panel_Zonas.Size = New Size(1302, 1055)
        Panel_Zonas.TabIndex = 3
        ' 
        ' Zonas_pag
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel_Zonas)
        Controls.Add(Lista_Zonas)
        Name = "Zonas_pag"
        Size = New Size(1582, 1098)
        Panel_Zonas.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Lista_Zonas As ListBox
    Friend WithEvents Añadir As Button
    Friend WithEvents Editar As Button
    Friend WithEvents Panel_Zonas As Panel

End Class
