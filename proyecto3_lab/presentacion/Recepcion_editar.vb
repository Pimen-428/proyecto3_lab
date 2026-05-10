Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Recepcion_editar

    Dim d As DetalleRecepcion
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(idRecepcion As Integer, idSuministro As Integer)
        InitializeComponent()
        Me.d = New DetalleRecepcion(idRecepcion, idSuministro)
        TextBox1.Text = idRecepcion.ToString()
        TextBox2.Text = idSuministro.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Trim() = "" OrElse TextBox2.Text.Trim() = "" OrElse TextBox3.Text.Trim() = "" Then
            MessageBox.Show("Rellene todos los campos.", "Dato incompleto")
            Exit Sub
        End If

        Me.d.IdRecepcion = CInt(TextBox1.Text.Trim())
        Me.d.IdSuministro = CInt(TextBox2.Text.Trim())
        Me.d.Cantidad = CInt(TextBox3.Text.Trim())

        Try
            If Me.d.ActualizarDetalle() > 0 Then
                MessageBox.Show("Detalle actualizado con éxito.", "Éxito")
                Me.Hide()
            Else
                MessageBox.Show("No se pudo actualizar.", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try

    End Sub

End Class