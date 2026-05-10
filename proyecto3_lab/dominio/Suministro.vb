Imports Microsoft.VisualBasic

Public Class Suministro
    Public Property id_suministro As Integer
    Public Property Descripcion As String        ' VARCHAR(150)
    Public Property Categoria As String          ' VARCHAR(50)
    Public Property PesoUnitario As Decimal      ' DECIMAL(10, ?)
    Public Property Cantidad As Integer
    Public ReadOnly Property suDAO As SuminstroDao
    Public Sub New()
        Me.suDAO = New SuminstroDao
    End Sub

    Public Sub New(id As Integer)
        Me.id_suministro = id
        Me.suDAO = New SuminstroDao
    End Sub

    Public Sub New(id As String)
        Integer.TryParse(id, Me.id_suministro)
        Me.suDAO = New SuminstroDao
    End Sub

    Public Sub New(id As Integer, descripcion As String, categoria As String, pesoUnitario As Decimal)
        Me.id_suministro = id
        Me.Descripcion = descripcion
        Me.Categoria = categoria
        Me.PesoUnitario = pesoUnitario
        Me.suDAO = New SuminstroDao
    End Sub
    Public Sub obtenersuministro()
        Me.suDAO.Obtenersuministro(Me)
    End Sub
    ' devuelve los suministros de un centro determinado
    Public Function SuministrosCentro(centro As String) As Collection
        Me.suDAO.suministrocentro(centro) ' Esto rellena suDAO.Suministros
        Return Me.suDAO.Suministros
    End Function
    Public Sub top10suministros()
        Me.suDAO.top10suministros()
    End Sub
    Public Sub editarsuministro()
        Me.suDAO.Update(Me)
    End Sub

    Public Function ValidarEntrega(idCentro As Integer, cantidadPedida As Integer) As String

        Dim stockActual As Integer = Me.suDAO.ObtenerCantidadStock(Me.id_suministro, idCentro)


        If stockActual <= 0 Then
            Return "ERROR: No hay stock de este suministro en el centro seleccionado."
        End If


        If (stockActual - cantidadPedida) < 0 Then
            Return "ERROR: Stock insuficiente. Solo quedan " & stockActual & " unidades y has solicitado " & cantidadPedida & "."
        End If


        Return "OK"
    End Function
    Public Function InsertarSuministro() As Integer
        Return Me.suDAO.Insertar(Me)
    End Function
    Public Sub LeerTodosSuministros()
        Me.suDAO.LeerTodos()
    End Sub
End Class
