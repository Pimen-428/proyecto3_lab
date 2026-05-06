Public Class voluntario_por_centro
    Dim c As Centro_logistico
    Private Sub voluntario_por_centro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
    End Sub
    'refrescamos la listbox con lox voluntarios disponibles
    Public Sub refrescarlistbox()
        Dim pAux As Centro_logistico
        Me.c = New Centro_logistico
        Me.ListBoxCentros.Items.Clear()
        Try
            Me.c.LeerTodosCentros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CentroDAO.Centro
            Me.ListBoxCentros.Items.Add(pAux.id & " - " & pAux.nombre_centro)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCentros.SelectedIndexChanged
        If Not Me.ListBoxCentros.SelectedItem Is Nothing Then
            Dim texto As String = Me.ListBoxCentros.SelectedItem.ToString()
            Dim separacion() As String = texto.Split("-")
            ' 1. Creamos el objeto voluntario con el DNI seleccionado
            Dim seleccionado As New Centro_logistico(separacion(0))

            Try
                ' 2. Cargamos sus datos desde la BD, tenemos una consulta cargada que nos devuelve todos los datos necesarios
                seleccionado.leercentroyvoluntarios()
                '3 escribimso los label con un formato
                CentroLabel.Text = "CENTRO SELECCIONADO" & vbCrLf &
                    "────────────────────" & vbCrLf &
                    "ID: " & seleccionado.id & " | " & seleccionado.nombre_centro & vbCrLf &
                    "Ubicación: " & seleccionado.ciudad_centro & vbCrLf &
                    "Capacidad Máxima: " & seleccionado.capacidad & " t"

                VoluntarioLabel.Text = "VOLUNTARIOS" & vbCrLf & "────────────────────"
                For Each Aux In seleccionado.CentroDAO.voluntarios
                    VoluntarioLabel.Text &= vbCrLf & "Nombre: " & Aux.nombre & vbCrLf &
                 "DNI: " & Aux.DNI & vbCrLf &
                 "Especialidad: " & Aux.especialidad & vbCrLf &
                    "────────────────────"
                Next

            Catch ex As Exception
                MessageBox.Show("Error al cargar el centro: " & ex.Message)
            End Try
        End If
    End Sub
End Class

