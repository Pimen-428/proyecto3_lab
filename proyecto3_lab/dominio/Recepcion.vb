Imports Microsoft.VisualBasic

Public Class Recepcion

    Public Property IdRecepcion As Integer        ' INT
        Public Property IdCentro As Integer           ' INT (clave foránea → centro)
        Public Property DniVoluntario As String       ' VARCHAR(15)
        Public Property Fecha As Date                 ' DATE
        Public Property Origen As String              ' VARCHAR(100)

        ' Constructor vacío
        Public Sub New()
        End Sub

        ' Constructor completo
        Public Sub New(idRecepcion As Integer, idCentro As Integer, dniVoluntario As String, fecha As Date, origen As String)
            Me.IdRecepcion = idRecepcion
            Me.IdCentro = idCentro
            Me.DniVoluntario = dniVoluntario
            Me.Fecha = fecha
            Me.Origen = origen
        End Sub

    End Class
