Imports Microsoft.VisualBasic

Public Class Suministro
    Public Property id_suministro As Integer
    Public Property Descripcion As String        ' VARCHAR(150)
    Public Property Categoria As String          ' VARCHAR(50)
    Public Property PesoUnitario As Decimal      ' DECIMAL(10, ?)
    Public Sub New(id As String)
    End Sub
    Public Sub New(id As Integer, descripcion As String, categoria As String, pesoUnitario As Decimal)
        Me.IdSuministro = id
        Me.Descripcion = descripcion
        Me.Categoria = categoria
        Me.PesoUnitario = pesoUnitario
    End Sub

End Class
