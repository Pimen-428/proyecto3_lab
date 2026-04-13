Public Class menu
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labelmenu.Click

    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub voluntarios_boton_Click(sender As Object, e As EventArgs) Handles voluntarios_boton.Click
        Dim ventanavoluntarios As New voluntarios()
        ventanavoluntarios.Show()
        Me.Hide()
    End Sub
End Class