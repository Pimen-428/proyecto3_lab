Public Class Entregas_de_cada_voluntario
    Dim v As Voluntario
    Private Sub Entregas_de_cada_voluntario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not Me.ListBox1.SelectedItem Is Nothing Then
            ' 1. Creamos el objeto voluntario con el DNI seleccionado
            Dim texto As String = Me.ListBox1.SelectedItem.ToString()
            Dim dividido() As String = texto.Split(" - ")
            Dim seleccionado As New Voluntario(dividido(0))

            Try

                ' 2. Cargamos sus datos desde la BD
                seleccionado.LeerPersona()

                '3 escribimos los datos en el label voluntario
                labelvoluntario.Text = "VOLUNTARIO" & vbCrLf &
                "────────────────────" &
                vbCrLf & "DNI: " & seleccionado.DNI & vbCrLf & "Nombre: " & seleccionado.Nombre & vbCrLf &
                "Especialidad: " & seleccionado.especialidad & vbCrLf &
                "Centro de pertenencia: " & seleccionado.centro

            Catch ex As Exception
                MessageBox.Show("Error al cargar el voluntario: " & ex.Message)
            End Try
        End If
    End Sub
    'llena la listbox con todos los voluntarios disponibles
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
