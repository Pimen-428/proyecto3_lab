Public Class Entregas_de_cada_voluntario
    Dim v As Voluntario
    Private Sub Entregas_de_cada_voluntario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not Me.ListBox1.SelectedItem Is Nothing Then
            Dim texto As String = Me.ListBox1.SelectedItem.ToString()
            Dim dividido() As String = texto.Split(" - ")
            Dim seleccionado As New Voluntario(dividido(0))

            Try

                seleccionado.LeerPersona()
                labelvoluntario.Text = "VOLUNTARIO" & vbCrLf &
                                 "────────────────────" & vbCrLf &
                                 "DNI: " & seleccionado.DNI & vbCrLf &
                                 "Nombre: " & seleccionado.Nombre & vbCrLf &
                                 "Especialidad: " & seleccionado.especialidad & vbCrLf &
                                 "Centro de pertenencia: " & seleccionado.centro


                Dim dtEntregas As DataTable = seleccionado.ObtenerMisEntregas()


                Dim textoEntregas As String = "ENTREGAS EN LAS QUE PARTICIPÓ" & vbCrLf &
                                         "────────────────────" & vbCrLf

                If dtEntregas.Rows.Count > 0 Then

                    For Each fila As DataRow In dtEntregas.Rows
                        Dim id As String = fila("ID Entrega").ToString()
                        Dim fecha As String = CDate(fila("Fecha")).ToShortDateString()
                        Dim destino As String = fila("Zona de Destino").ToString()


                        textoEntregas &= $"• ID: {id} | Fecha: {fecha} | Destino: {destino}" & vbCrLf
                    Next
                Else
                    textoEntregas &= "No se han registrado entregas para este voluntario."
                End If


                labelentregas.Text = textoEntregas

            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub refrescarlistbox()
        Dim pAux As Voluntario
        Me.v = New Voluntario
        Me.ListBox1.Items.Clear()
        Try
            Me.v.leervoluntariosporcantidadenvios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.v.PerDAO.Personas
            Me.ListBox1.Items.Add(pAux.DNI & " - " & pAux.Nombre & " - " & pAux.Cantidad_envios)
        Next
    End Sub

End Class
