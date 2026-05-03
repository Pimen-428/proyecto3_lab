Imports Microsoft.VisualBasic

Public Class Suministro
    Public Property id_suministro As Integer
    Public Property Descripcion As String        ' VARCHAR(150)
    Public Property Categoria As String          ' VARCHAR(50)
    Public Property PesoUnitario As Decimal      ' DECIMAL(10, ?)
    Public ReadOnly Property suDAO As SuminstroDao
    Public Sub New()
        Me.suDAO = New SuminstroDao
    End Sub

    Public Sub New(id As Integer)
        Me.id_suministro = id
    End Sub

    Public Sub New(id As String)
        Integer.TryParse(id, Me.id_suministro)
    End Sub

    Public Sub New(id As Integer, descripcion As String, categoria As String, pesoUnitario As Decimal)
        Me.id_suministro = id
        Me.Descripcion = descripcion
        Me.Categoria = categoria
        Me.PesoUnitario = pesoUnitario
    End Sub
    ''metodo creado pro pimen, devuelve los suministros de un centro determinado
    Public Function SuministrosCentro(centro As String) As Collection
        Me.suDAO.suministrocentro(centro) ' Esto rellena suDAO.Suministros
        Return Me.suDAO.Suministros
    End Function
End Class
