Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Suministro_Añadir
    Dim s As Suministro

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Trim() = "" OrElse TextBox2.Text.Trim() = "" OrElse TextBox3.Text.Trim() = "" Then
            MessageBox.Show("Rellene todos los campos.", "Dato incompleto")
            Exit Sub
        End If

        Dim peso As Decimal
        If Not Decimal.TryParse(TextBox3.Text.Trim(), peso) OrElse peso <= 0 Then
            MessageBox.Show("Introduzca un peso válido.", "Dato incompleto")
            Exit Sub
        End If
        Try
            Me.s = New Suministro()
            Me.s.Descripcion = TextBox1.Text.Trim()
            Me.s.Categoria = TextBox2.Text.Trim()
            Me.s.PesoUnitario = peso

            If Me.s.InsertarSuministro() > 0 Then
                MessageBox.Show("Suministro añadido con éxito.", "Éxito")
            Else
                MessageBox.Show("No se pudo registrar el suministro.", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
        vaciarTextBox()
    End Sub
    Private Sub vaciarTextBox()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class
