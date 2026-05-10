Imports System.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Suministro_pag
    Dim s As Suministro
    Dim id As Integer = 0
    Private Sub Suministros_pag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        RefrescarGrid()
    End Sub

    Private Sub ConfigurarGrid()
        DataGridView1.Columns.Clear()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.ReadOnly = True

        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colId", .HeaderText = "ID", .DataPropertyName = "id_suministro", .Width = 50
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colDescripcion", .HeaderText = "Descripción", .DataPropertyName = "Descripcion", .Width = 200
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colCategoria", .HeaderText = "Categoría", .DataPropertyName = "Categoria", .Width = 120
        })
        DataGridView1.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colPeso", .HeaderText = "Peso Unitario", .DataPropertyName = "PesoUnitario", .Width = 100
        })
    End Sub

    Private Sub RefrescarGrid()
        Me.s = New Suministro()
        Try
            Me.s.LeerTodosSuministros()
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = Me.s.suDAO.Suministros
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim idSeleccionado As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim seleccionado As New Suministro(idSeleccionado)
            Try
                seleccionado.obtenersuministro()
                suministroleccionado(seleccionado)
                id = idSeleccionado
            Catch ex As Exception
                MessageBox.Show("Error al cargar el centro: " & ex.Message)
            End Try
        End If
    End Sub
    Friend Sub suministroleccionado(seleccionado As Suministro)
        IDlabel.Text = "ID: " & seleccionado.id_suministro
        TextBoxDescripcion.Text = seleccionado.Descripcion
        TextBoxCategoria.Text = seleccionado.Categoria
        TextBoxPesoUnitario.Text = seleccionado.PesoUnitario
    End Sub
    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Try
            If id = 0 Then
                Throw New Exception("Debes elegir un suministro para editar")
            End If

            If TextBoxCategoria.Text.Trim() = "" OrElse TextBoxDescripcion.Text.Trim() = "" Then
                MessageBox.Show("Rellene todos los campos.", "Dato incompleto")
                Exit Sub
            End If

            Dim peso As Decimal
            If Not Decimal.TryParse(TextBoxPesoUnitario.Text.Trim(), peso) OrElse peso <= 0 Then
                MessageBox.Show("Introduzca un peso válido.", "Dato incompleto")
                Exit Sub
            End If
            Me.s = New Suministro(id)
            Me.s.Descripcion = TextBoxDescripcion.Text.Trim()
            Me.s.Categoria = TextBoxCategoria.Text.Trim()
            Me.s.PesoUnitario = peso

            Me.s.editarsuministro()
            MessageBox.Show("Suministro añadido con éxito.", "Éxito")
            RefrescarGrid()
            vaciarTextBox()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub vaciarTextBox()
        TextBoxPesoUnitario.Text = ""
        TextBoxCategoria.Text = ""
        TextBoxDescripcion.Text = ""
        IDlabel.Text = "ID"
    End Sub
End Class
