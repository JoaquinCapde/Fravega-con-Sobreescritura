Public Class Heladera
    Inherits Electro
    Public capacidad, consumo As Integer
    Public color As String

    Public Sub New(capacidad As Integer, consumo As Integer, color As String)
        Me.capacidad = capacidad
        Me.consumo = consumo
        Me.color = color
    End Sub

    Public Sub New()

    End Sub

    Public Overridable Function PrecioDeVenta()
        Return ((Me.preciodecompra * 40) / 100) + Me.preciodecompra
    End Function
End Class
