<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aniadir_volun
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
        boton_volver = New Button()
        DNItext = New TextBox()
        Nombretext = New TextBox()
        Especialidadtext = New TextBox()
        Centrotext = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        aniadir_boton = New Button()
        SuspendLayout()
        ' 
        ' boton_volver
        ' 
        boton_volver.BackColor = SystemColors.Highlight
        boton_volver.Location = New Point(34, 24)
        boton_volver.Name = "boton_volver"
        boton_volver.Size = New Size(94, 29)
        boton_volver.TabIndex = 0
        boton_volver.Text = "volver"
        boton_volver.UseVisualStyleBackColor = False
        ' 
        ' DNItext
        ' 
        DNItext.Location = New Point(37, 201)
        DNItext.Name = "DNItext"
        DNItext.Size = New Size(140, 27)
        DNItext.TabIndex = 1
        ' 
        ' Nombretext
        ' 
        Nombretext.Location = New Point(218, 201)
        Nombretext.Name = "Nombretext"
        Nombretext.Size = New Size(140, 27)
        Nombretext.TabIndex = 2
        ' 
        ' Especialidadtext
        ' 
        Especialidadtext.Location = New Point(422, 201)
        Especialidadtext.Name = "Especialidadtext"
        Especialidadtext.Size = New Size(140, 27)
        Especialidadtext.TabIndex = 3
        ' 
        ' Centrotext
        ' 
        Centrotext.Location = New Point(603, 201)
        Centrotext.Name = "Centrotext"
        Centrotext.Size = New Size(140, 27)
        Centrotext.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 20)
        Label1.TabIndex = 5
        Label1.Text = "DNI"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(218, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 6
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(422, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 7
        Label3.Text = "Especialidad"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(603, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 8
        Label4.Text = "Centro"
        ' 
        ' aniadir_boton
        ' 
        aniadir_boton.BackColor = SystemColors.ActiveCaptionText
        aniadir_boton.ForeColor = SystemColors.ControlLightLight
        aniadir_boton.Location = New Point(603, 41)
        aniadir_boton.Name = "aniadir_boton"
        aniadir_boton.Size = New Size(143, 34)
        aniadir_boton.TabIndex = 10
        aniadir_boton.Text = "añadir voluntario"
        aniadir_boton.UseVisualStyleBackColor = False
        ' 
        ' aniadir_volun
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(aniadir_boton)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Centrotext)
        Controls.Add(Especialidadtext)
        Controls.Add(Nombretext)
        Controls.Add(DNItext)
        Controls.Add(boton_volver)
        Name = "aniadir_volun"
        Text = "ver_voluntario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents boton_volver As Button
    Friend WithEvents DNItext As TextBox
    Friend WithEvents Nombretext As TextBox
    Friend WithEvents Especialidadtext As TextBox
    Friend WithEvents Centrotext As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents aniadir_boton As Button
End Class
