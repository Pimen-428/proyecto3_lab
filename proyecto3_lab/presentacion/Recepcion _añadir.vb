Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Recepcion__añadir
    Dim a As Almacenamiento
    Dim s As Suministro
    Dim r As Recepcion
    Dim c As Centro_logistico
    Dim v As Voluntario

    Private Sub Recepcion_anadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrescarComboBoxCentro()

    End Sub

    Private Sub RefrescarComboBoxCentro()
        ComboBox1.DataSource = Nothing
        Me.c = New Centro_logistico
        Try
            Me.c.LeerTodosCentros()
            ComboBox1.DataSource = Me.c.CentroDAO.Centro
            ComboBox1.DisplayMember = "id"
            ComboBox1.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim centroSeleccionado As Centro_logistico = CType(ComboBox1.SelectedItem, Centro_logistico)
            Dim centro As String = centroSeleccionado.id.ToString()
            RefrescarComboBoxVoluntario(centro)
        End If
    End Sub

    Private Sub RefrescarComboBoxVoluntario(centro As String)
        ComboBox2.DataSource = Nothing
        Me.v = New Voluntario
        Try
            Me.v.LeerTodasPersonasdecentro(centro)
            ComboBox2.DataSource = Me.v.PerDAO.Personas
            ComboBox2.DisplayMember = "DNI"
            ComboBox2.ValueMember = "DNI"
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' VALIDACIONES
        If ComboBox1.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un centro.", "Dato incompleto")
            Exit Sub
        End If

        If ComboBox2.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un voluntario.", "Dato incompleto")
            Exit Sub
        End If

        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Introduzca el origen.", "Dato incompleto")
            Exit Sub
        End If

        If TextBox3.Text.Trim() = "" OrElse TextBox4.Text.Trim() = "" OrElse TextBox5.Text.Trim() = "" Then
            MessageBox.Show("Rellene todos los datos del suministro.", "Dato incompleto")
            Exit Sub
        End If

        Dim cantidad As Integer
        If Not Integer.TryParse(TextBox2.Text.Trim(), cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("Introduzca una cantidad válida.", "Dato incompleto")
            Exit Sub
        End If

        Dim peso As Decimal
        If Not Decimal.TryParse(TextBox5.Text.Trim(), peso) OrElse peso <= 0 Then
            MessageBox.Show("Introduzca un peso unitario válido.", "Dato incompleto")
            Exit Sub
        End If

        Try
            ' 1. INSERTAR RECEPCION
            Me.r = New Recepcion()
            Me.r.IdCentro = CInt(ComboBox1.SelectedValue)
            Me.r.DniVoluntario = ComboBox2.SelectedValue.ToString()
            Me.r.Fecha = DateTimePicker1.Value.Date
            Me.r.Origen = TextBox1.Text.Trim()

            If Me.r.InsertarRecepcion() = 0 Then
                MessageBox.Show("No se pudo registrar la recepción.", "Error")
                Exit Sub
            End If

            ' 2. INSERTAR SUMINISTRO
            Me.s = New Suministro()
            Me.s.Descripcion = TextBox3.Text.Trim()
            Me.s.Categoria = TextBox4.Text.Trim()
            Me.s.PesoUnitario = peso

            If Me.s.InsertarSuministro() = 0 Then
                MessageBox.Show("No se pudo registrar el suministro.", "Error")
                Exit Sub
            End If

            ' 3. SUMAR STOCK
            Me.a = New Almacenamiento()
            Me.a.IdCentro = CInt(ComboBox1.SelectedValue)
            Me.a.IdSuministro = Me.s.id_suministro
            Me.a.CantidadStock = cantidad
            Me.a.SumarStock()

            MessageBox.Show("Recepción añadida con éxito.", "Éxito")
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Origen_Click(sender As Object, e As EventArgs) Handles Origen.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class