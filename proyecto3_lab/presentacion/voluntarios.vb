Public Class voluntarios
    Private Sub volver_menu_Click(sender As Object, e As EventArgs) Handles volver_menu.Click
        Dim volver As New menu()
        volver.Show()
        Me.Hide()
    End Sub

    Private Sub aniadir_voluntario_boton_Click(sender As Object, e As EventArgs) Handles aniadir_voluntario_boton.Click
        Dim ventanaaniadir As New aniadir_volun()
        ventanaaniadir.Show()
        Me.Hide()
    End Sub

    Private Sub ver_voluntarios_boton_Click(sender As Object, e As EventArgs) Handles ver_voluntarios_boton.Click
        Dim ventanaver As New ver_volun()
        ventanaver.Show()
        Me.Hide()
    End Sub

    Private Sub voluntarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class