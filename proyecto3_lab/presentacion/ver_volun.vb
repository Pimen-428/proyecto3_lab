Public Class ver_volun
    Private Sub aniadir_voluntarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub boton_volver_Click(sender As Object, e As EventArgs) Handles boton_volver.Click
        Dim ventana_volver As New voluntarios()
        ventana_volver.Show()
        Me.Hide()
    End Sub

End Class