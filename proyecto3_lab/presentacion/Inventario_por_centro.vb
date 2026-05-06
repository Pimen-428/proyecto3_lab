Public Class Inventario_por_centro
    Dim c As Centro_logistico
    Private Sub Inventario_por_centro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
    End Sub
    'refrescamos la combobox con todos los centros logisticos
    Public Sub refrescarlistbox()
        Dim pAux As Centro_logistico
        Me.c = New Centro_logistico
        Me.ListBox1.Items.Clear()
        Try
            Me.c.LeerTodosCentros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CentroDAO.Centro
            Me.ListBox1.Items.Add(pAux.id & " - " & pAux.nombre_centro)
        Next
    End Sub
    '
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not Me.ListBox1.SelectedItem Is Nothing Then
            Dim texto As String = Me.ListBox1.SelectedItem.ToString()
            Dim separacion() As String = texto.Split("-")
            ' 1. Creamos el objeto voluntario con el DNI seleccionado
            Dim seleccionado As New Centro_logistico(separacion(0))

            Try
                ' 2. Cargamos sus datos desde la BD
                seleccionado.LeerCentro()
                '3 editamos todos los label para darles formato
                centrolabel.Text = "CENTRO SELECCIONADO" & vbCrLf &
                    "────────────────────" & vbCrLf &
                    "ID: " & seleccionado.id & " | " & seleccionado.nombre_centro & vbCrLf &
                    "Ubicación: " & seleccionado.ciudad_centro & vbCrLf &
                    "Capacidad Máxima: " & seleccionado.capacidad & " t"

                suministrolabel.Text = "SUMINISTROS EN EL CENTRO" & vbCrLf & "────────────────────"
                'aqui obtenemos todos los suminsitros que tiene un determinado centro con un join
                seleccionado.suministrodelcentro()
                For Each Aux In seleccionado.CentroDAO.suministros
                    suministrolabel.Text &= vbCrLf & "Descripción: " & Aux.Descripcion & vbCrLf &
                 "Categoría: " & Aux.Categoria & vbCrLf &
                 "Cantidad en Stock: " & Aux.Cantidad & vbCrLf &
                 "Peso Unitario: " & Aux.PesoUnitario & " kg" & vbCrLf &
                    "────────────────────"
                Next

            Catch ex As Exception
                MessageBox.Show("Error al cargar el centro: " & ex.Message)
            End Try
        End If
    End Sub
End Class
