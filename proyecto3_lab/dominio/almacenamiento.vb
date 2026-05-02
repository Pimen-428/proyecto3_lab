Public Class Almacenamiento
    Public Property IdCentro As Integer
    Public Property IdSuministro As Integer
    Public Property CantidadStock As Integer

    Public ReadOnly Property AlmacenamientoDAO As AlmacenamientoDAO

    Public Sub New()
        Me.AlmacenamientoDAO = New AlmacenamientoDAO
    End Sub

    ' ─────────────────────────────────────────
    '  MÉTODOS QUE DELEGAN AL DAO
    ' ─────────────────────────────────────────

    Public Function ObtenerStock() As Integer
        Return Me.AlmacenamientoDAO.ObtenerStock(Me.IdCentro, Me.IdSuministro)
    End Function

    Public Function ObtenerStockTotalKilos() As Decimal
        Return Me.AlmacenamientoDAO.ObtenerStockTotalKilos(Me.IdCentro)
    End Function

    Public Function SumarStock() As Integer
        Return Me.AlmacenamientoDAO.SumarStock(Me.IdCentro, Me.IdSuministro, Me.CantidadStock)
    End Function

    Public Function RestarStock() As Integer
        Return Me.AlmacenamientoDAO.RestarStock(Me.IdCentro, Me.IdSuministro, Me.CantidadStock)
    End Function

    Public Function ObtenerInventarioByCentro() As Collection
        Return Me.AlmacenamientoDAO.ObtenerInventarioByCentro(Me.IdCentro)
    End Function

    Public Function ObtenerListadoGlobal() As Collection
        Return Me.AlmacenamientoDAO.ObtenerListadoGlobal()
    End Function

End Class