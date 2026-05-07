Public Class Suministros_por_fechas
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Suministros_por_zonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim z As New zona_conflicto()
        Try
            z.LeerTodasZonas()
            cmbZonas.DataSource = z.ZonaDAO.Zonas

            cmbZonas.DisplayMember = "id"
            cmbZonas.ValueMember = "id"
            cmbZonas.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar zonas: " & ex.Message)
        End Try
    End Sub


    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            ' 1. Validar selección (Esto evita el error de NullReference que vimos antes)
            If cmbZonas.SelectedValue Is Nothing Then
                MessageBox.Show("Por favor, selecciona una Zona de Destino.")
                Exit Sub
            End If

            ' 2. Capturar valores del formulario
            Dim idZ As Integer = CInt(cmbZonas.SelectedValue)
            ' Formato YYYY-MM-DD es el lenguaje universal de MySQL
            Dim f1 As String = dtpInicio.Value.ToString("yyyy-MM-dd")
            Dim f2 As String = dtpFin.Value.ToString("yyyy-MM-dd")

            ' 3. Llamar al Dominio/DAO 
            ' OJO: Asegúrate de que en la clase 'entrega' el método se llame así
            Dim ent As New entrega()
            Dim dt As DataTable = ent.InformeHistorialSuministros(idZ, f1, f2)

            ' 4. Volcar datos en el DataGridView
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                dgvHistorial.DataSource = dt
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Else
                dgvHistorial.DataSource = Nothing
                MessageBox.Show("No se encontraron registros de envío para esta zona en el rango de fechas seleccionado.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al generar el informe: " & ex.Message)
        End Try
    End Sub
End Class
