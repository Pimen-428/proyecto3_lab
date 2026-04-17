Public Class Voluntarios_pag
    Dim v As Voluntario
    Dim añadir_boolean As Boolean
    Private Sub Voluntarios_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        Me.añadir_boolean = False
    End Sub
    Public Sub refrescarlistbox()
        Dim pAux As Voluntario
        Me.v = New Voluntario
        Me.lista.Items.Clear()
        Try
            Me.v.LeerTodasPersonas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.v.PerDAO.Personas
            Me.lista.Items.Add(pAux.DNI)
        Next
    End Sub
    Private Sub añadir_Click(sender As Object, e As EventArgs) Handles añadir.Click
        If añadir_boolean Then
            Panel_voluntarios.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New voluntarios_pag_añadir())
            añadir_boolean = True
        End If
    End Sub
    Private Sub cambiarvista(vistanueva As Control)
        Panel_voluntarios.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        Panel_voluntarios.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub

End Class
