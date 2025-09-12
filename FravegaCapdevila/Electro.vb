Public Class Electro
    Public modelo, descripcion As String
    Public stock, preciodecompra As Integer

    Public Sub New(modelo As String, descripcion As String)
        Me.modelo = modelo
        Me.descripcion = descripcion
    End Sub

    Public Sub New()

    End Sub

    Public Function Comprar(preciodecompra As Integer, cantidaddecompra As Integer)
        Me.preciodecompra = preciodecompra
        Me.stock = Me.stock + cantidaddecompra
    End Function

    Public Function Vender(cantidadavender As Integer)
        If (cantidadavender <= Me.stock) Then
            Me.stock = Me.stock - cantidadavender
            Return "Se realizo la compra correctamente."
        Else
            Return "No se pudo realizar la compra (stock insuficiente)"
        End If
    End Function

    Public Overridable Function PrecioDeVenta()
        Return ((Me.preciodecompra * 20) / 100) + Me.preciodecompra
    End Function
End Class
