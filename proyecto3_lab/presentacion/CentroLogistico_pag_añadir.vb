Public Class CentroLogistico_pag_añadir
    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles ButtonAñadir.Click
        Dim pAux As Centro_logistico
        If TextBoxCiudad.Text = "" Or TextBoxCapacidad.Text = "" Or TextBoxNombre.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        pAux = New Centro_logistico()
        pAux.capacidad = TextBoxCapacidad.Text
        pAux.ciudad_centro = TextBoxCiudad.Text
        pAux.nombre_centro = TextBoxNombre.Text
        Try
            pAux.InsertarCentro()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Dim formularioPadre As CentroLogistico_pag = DirectCast(Me.Parent.Parent, CentroLogistico_pag)
        formularioPadre.refrescarlistbox()
        vaciarTextBox()
    End Sub
    Private Sub vaciarTextBox()
        TextBoxCapacidad.Text = ""
        TextBoxCiudad.Text = ""
        TextBoxNombre.Text = ""
    End Sub
End Class
