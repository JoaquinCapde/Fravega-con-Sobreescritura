Public Class Lavarropas
    Inherits Electro
    Public capacidad, consumo As Integer

    Public Sub New(capacidad As Integer, consumo As Integer, color As String)
        Me.capacidad = capacidad
        Me.consumo = consumo
    End Sub

    Public Sub New()

    End Sub

    Public Overrides Function PrecioDeVenta()
        If (Me.stock > 100) Then
            Return preciodecompra
        Else
            Return ((Me.preciodecompra * 30) / 100) + Me.preciodecompra
        End If
    End Function
End Class
