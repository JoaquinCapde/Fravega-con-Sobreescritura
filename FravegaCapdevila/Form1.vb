Public Class Form1
    Dim precioCompra, cantidadComprada, precioVenta, cantidadVenta As Integer
    Dim heladera1 As Heladera = New Heladera()
    Dim lavarropas1 As Lavarropas = New Lavarropas()

    Private Sub rdbLavarropas_CheckedChanged(sender As Object, e As EventArgs) Handles rdbLavarropas.CheckedChanged
        cboColor.Enabled = False
        cboColor.Text = "Blanco"
    End Sub

    Private Sub rdbHeladera_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHeladera.CheckedChanged
        cboColor.Enabled = True
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If (rdbHeladera.Checked = True) Then
            heladera1.modelo = txtModelo.Text
            heladera1.descripcion = txtDescripcion.Text
            heladera1.color = cboColor.Text
            heladera1.capacidad = txtCapacidad.Text
            heladera1.consumo = txtConsumo.Text
            rdbLavarropas.Enabled = False
        End If
        If (rdbLavarropas.Checked = True) Then
            lavarropas1.modelo = txtModelo.Text
            lavarropas1.descripcion = txtDescripcion.Text
            lavarropas1.capacidad = txtCapacidad.Text
            lavarropas1.consumo = txtConsumo.Text
            rdbHeladera.Enabled = False
        End If
        btnComprar.Enabled = True
        btnVender.Enabled = True
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        precioCompra = txtPrecioCompra.Text
        cantidadComprada = txtCantidad1.Text
        If (rdbHeladera.Checked = True) Then
            heladera1.Comprar(precioCompra, cantidadComprada)
            MsgBox("Se Han Comprado " & cantidadComprada.ToString() & " Heladeras Correctamente")
            txtStock.Text = heladera1.stock
        End If
        If (rdbLavarropas.Checked = True) Then
            lavarropas1.Comprar(precioCompra, cantidadComprada)
            MsgBox("Se Han Comprado " & cantidadComprada.ToString() & " Lavarropas Correctamente")
            txtStock.Text = lavarropas1.stock
        End If
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        cantidadVenta = txtCantidad2.Text
        If (rdbHeladera.Checked = True) Then
            MsgBox(heladera1.Vender(cantidadVenta))
            txtPrecioVenta.Text = heladera1.PrecioDeVenta().ToString()
            txtStock.Text = heladera1.stock
        End If
        If (rdbLavarropas.Checked = True) Then
            MsgBox(lavarropas1.Vender(cantidadVenta))
            txtPrecioVenta.Text = lavarropas1.PrecioDeVenta().ToString()
            txtStock.Text = lavarropas1.stock
        End If
    End Sub
End Class
