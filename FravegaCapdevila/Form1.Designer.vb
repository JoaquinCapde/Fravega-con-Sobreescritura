<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        gpb1 = New GroupBox()
        rdbOtro = New RadioButton()
        rdbHeladera = New RadioButton()
        rdbLavarropas = New RadioButton()
        txtDescripcion = New TextBox()
        txtModelo = New TextBox()
        lblDescripcion = New Label()
        lblModelo = New Label()
        gpb2 = New GroupBox()
        btnAlta = New Button()
        lblWatt = New Label()
        txtConsumo = New TextBox()
        lblConsumo = New Label()
        lblKgLitro = New Label()
        txtCapacidad = New TextBox()
        lblCapacidad = New Label()
        cboColor = New ComboBox()
        lblColor = New Label()
        gpb3 = New GroupBox()
        lblUnid = New Label()
        txtStock = New TextBox()
        lblStock = New Label()
        gpb4 = New GroupBox()
        btnComprar = New Button()
        txtPrecioCompra = New TextBox()
        lblPrecioCompra = New Label()
        txtCantidad1 = New TextBox()
        lblCantidad1 = New Label()
        GroupBox1 = New GroupBox()
        btnVender = New Button()
        txtPrecioVenta = New TextBox()
        lblPrecioVenta = New Label()
        txtCantidad2 = New TextBox()
        lblCantidad2 = New Label()
        gpb1.SuspendLayout()
        gpb2.SuspendLayout()
        gpb3.SuspendLayout()
        gpb4.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' gpb1
        ' 
        gpb1.BackColor = Color.PaleGreen
        gpb1.Controls.Add(rdbOtro)
        gpb1.Controls.Add(rdbHeladera)
        gpb1.Controls.Add(rdbLavarropas)
        gpb1.Controls.Add(txtDescripcion)
        gpb1.Controls.Add(txtModelo)
        gpb1.Controls.Add(lblDescripcion)
        gpb1.Controls.Add(lblModelo)
        gpb1.Location = New Point(30, 20)
        gpb1.Name = "gpb1"
        gpb1.Size = New Size(405, 178)
        gpb1.TabIndex = 0
        gpb1.TabStop = False
        ' 
        ' rdbOtro
        ' 
        rdbOtro.AutoSize = True
        rdbOtro.Location = New Point(231, 127)
        rdbOtro.Name = "rdbOtro"
        rdbOtro.Size = New Size(49, 19)
        rdbOtro.TabIndex = 5
        rdbOtro.TabStop = True
        rdbOtro.Text = "Otro"
        rdbOtro.UseVisualStyleBackColor = True
        ' 
        ' rdbHeladera
        ' 
        rdbHeladera.AutoSize = True
        rdbHeladera.Location = New Point(130, 127)
        rdbHeladera.Name = "rdbHeladera"
        rdbHeladera.Size = New Size(72, 19)
        rdbHeladera.TabIndex = 5
        rdbHeladera.TabStop = True
        rdbHeladera.Text = "Heladera"
        rdbHeladera.UseVisualStyleBackColor = True
        ' 
        ' rdbLavarropas
        ' 
        rdbLavarropas.AutoSize = True
        rdbLavarropas.Location = New Point(18, 127)
        rdbLavarropas.Name = "rdbLavarropas"
        rdbLavarropas.Size = New Size(82, 19)
        rdbLavarropas.TabIndex = 4
        rdbLavarropas.TabStop = True
        rdbLavarropas.Text = "Lavarropas"
        rdbLavarropas.UseVisualStyleBackColor = True
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(145, 63)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(155, 23)
        txtDescripcion.TabIndex = 3
        ' 
        ' txtModelo
        ' 
        txtModelo.Location = New Point(145, 27)
        txtModelo.Name = "txtModelo"
        txtModelo.Size = New Size(155, 23)
        txtModelo.TabIndex = 2
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Location = New Point(20, 71)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(69, 15)
        lblDescripcion.TabIndex = 1
        lblDescripcion.Text = "Descripcion"
        ' 
        ' lblModelo
        ' 
        lblModelo.AutoSize = True
        lblModelo.Location = New Point(20, 30)
        lblModelo.Name = "lblModelo"
        lblModelo.Size = New Size(48, 15)
        lblModelo.TabIndex = 0
        lblModelo.Text = "Modelo"
        ' 
        ' gpb2
        ' 
        gpb2.BackColor = Color.PaleGreen
        gpb2.Controls.Add(btnAlta)
        gpb2.Controls.Add(lblWatt)
        gpb2.Controls.Add(txtConsumo)
        gpb2.Controls.Add(lblConsumo)
        gpb2.Controls.Add(lblKgLitro)
        gpb2.Controls.Add(txtCapacidad)
        gpb2.Controls.Add(lblCapacidad)
        gpb2.Controls.Add(cboColor)
        gpb2.Controls.Add(lblColor)
        gpb2.Location = New Point(30, 236)
        gpb2.Name = "gpb2"
        gpb2.Size = New Size(405, 202)
        gpb2.TabIndex = 1
        gpb2.TabStop = False
        ' 
        ' btnAlta
        ' 
        btnAlta.BackColor = Color.Fuchsia
        btnAlta.Font = New Font("Segoe UI", 21.75F)
        btnAlta.ForeColor = SystemColors.ControlLightLight
        btnAlta.Location = New Point(293, 10)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(100, 183)
        btnAlta.TabIndex = 14
        btnAlta.Text = "ALTA"
        btnAlta.UseVisualStyleBackColor = False
        ' 
        ' lblWatt
        ' 
        lblWatt.AutoSize = True
        lblWatt.Location = New Point(222, 138)
        lblWatt.Name = "lblWatt"
        lblWatt.Size = New Size(32, 15)
        lblWatt.TabIndex = 13
        lblWatt.Text = "Watt"
        ' 
        ' txtConsumo
        ' 
        txtConsumo.Location = New Point(113, 135)
        txtConsumo.Name = "txtConsumo"
        txtConsumo.Size = New Size(100, 23)
        txtConsumo.TabIndex = 12
        ' 
        ' lblConsumo
        ' 
        lblConsumo.AutoSize = True
        lblConsumo.Location = New Point(20, 138)
        lblConsumo.Name = "lblConsumo"
        lblConsumo.Size = New Size(59, 15)
        lblConsumo.TabIndex = 11
        lblConsumo.Text = "Consumo"
        ' 
        ' lblKgLitro
        ' 
        lblKgLitro.AutoSize = True
        lblKgLitro.Location = New Point(222, 109)
        lblKgLitro.Name = "lblKgLitro"
        lblKgLitro.Size = New Size(55, 15)
        lblKgLitro.TabIndex = 10
        lblKgLitro.Text = "Kg/Litros"
        ' 
        ' txtCapacidad
        ' 
        txtCapacidad.Location = New Point(113, 106)
        txtCapacidad.Name = "txtCapacidad"
        txtCapacidad.Size = New Size(100, 23)
        txtCapacidad.TabIndex = 9
        ' 
        ' lblCapacidad
        ' 
        lblCapacidad.AutoSize = True
        lblCapacidad.Location = New Point(20, 109)
        lblCapacidad.Name = "lblCapacidad"
        lblCapacidad.Size = New Size(63, 15)
        lblCapacidad.TabIndex = 8
        lblCapacidad.Text = "Capacidad"
        ' 
        ' cboColor
        ' 
        cboColor.FormattingEnabled = True
        cboColor.Location = New Point(92, 21)
        cboColor.Name = "cboColor"
        cboColor.Size = New Size(121, 23)
        cboColor.TabIndex = 7
        ' 
        ' lblColor
        ' 
        lblColor.AutoSize = True
        lblColor.Location = New Point(20, 19)
        lblColor.Name = "lblColor"
        lblColor.Size = New Size(36, 15)
        lblColor.TabIndex = 6
        lblColor.Text = "Color"
        ' 
        ' gpb3
        ' 
        gpb3.BackColor = Color.Red
        gpb3.Controls.Add(lblUnid)
        gpb3.Controls.Add(txtStock)
        gpb3.Controls.Add(lblStock)
        gpb3.Location = New Point(457, 20)
        gpb3.Name = "gpb3"
        gpb3.Size = New Size(301, 100)
        gpb3.TabIndex = 2
        gpb3.TabStop = False
        ' 
        ' lblUnid
        ' 
        lblUnid.AutoSize = True
        lblUnid.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblUnid.ForeColor = Color.White
        lblUnid.Location = New Point(200, 36)
        lblUnid.Name = "lblUnid"
        lblUnid.Size = New Size(71, 32)
        lblUnid.TabIndex = 2
        lblUnid.Text = "Unid."
        ' 
        ' txtStock
        ' 
        txtStock.Enabled = False
        txtStock.Location = New Point(159, 43)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(35, 23)
        txtStock.TabIndex = 1
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblStock.ForeColor = Color.White
        lblStock.Location = New Point(24, 36)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(87, 32)
        lblStock.TabIndex = 0
        lblStock.Text = "STOCK"
        ' 
        ' gpb4
        ' 
        gpb4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        gpb4.Controls.Add(btnComprar)
        gpb4.Controls.Add(txtPrecioCompra)
        gpb4.Controls.Add(lblPrecioCompra)
        gpb4.Controls.Add(txtCantidad1)
        gpb4.Controls.Add(lblCantidad1)
        gpb4.Location = New Point(461, 133)
        gpb4.Name = "gpb4"
        gpb4.Size = New Size(297, 137)
        gpb4.TabIndex = 3
        gpb4.TabStop = False
        ' 
        ' btnComprar
        ' 
        btnComprar.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        btnComprar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        btnComprar.Location = New Point(20, 82)
        btnComprar.Name = "btnComprar"
        btnComprar.Size = New Size(240, 49)
        btnComprar.TabIndex = 4
        btnComprar.Text = "Comprar"
        btnComprar.UseVisualStyleBackColor = False
        ' 
        ' txtPrecioCompra
        ' 
        txtPrecioCompra.Location = New Point(144, 46)
        txtPrecioCompra.Name = "txtPrecioCompra"
        txtPrecioCompra.Size = New Size(96, 23)
        txtPrecioCompra.TabIndex = 3
        ' 
        ' lblPrecioCompra
        ' 
        lblPrecioCompra.AutoSize = True
        lblPrecioCompra.Location = New Point(27, 49)
        lblPrecioCompra.Name = "lblPrecioCompra"
        lblPrecioCompra.Size = New Size(86, 15)
        lblPrecioCompra.TabIndex = 2
        lblPrecioCompra.Text = "Precio Compra"
        ' 
        ' txtCantidad1
        ' 
        txtCantidad1.Location = New Point(144, 20)
        txtCantidad1.Name = "txtCantidad1"
        txtCantidad1.Size = New Size(96, 23)
        txtCantidad1.TabIndex = 1
        ' 
        ' lblCantidad1
        ' 
        lblCantidad1.AutoSize = True
        lblCantidad1.Location = New Point(27, 23)
        lblCantidad1.Name = "lblCantidad1"
        lblCantidad1.Size = New Size(52, 15)
        lblCantidad1.TabIndex = 0
        lblCantidad1.Text = "Cantdad"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        GroupBox1.Controls.Add(btnVender)
        GroupBox1.Controls.Add(txtPrecioVenta)
        GroupBox1.Controls.Add(lblPrecioVenta)
        GroupBox1.Controls.Add(txtCantidad2)
        GroupBox1.Controls.Add(lblCantidad2)
        GroupBox1.Location = New Point(461, 276)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(297, 137)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' btnVender
        ' 
        btnVender.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        btnVender.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        btnVender.Location = New Point(20, 82)
        btnVender.Name = "btnVender"
        btnVender.Size = New Size(240, 49)
        btnVender.TabIndex = 4
        btnVender.Text = "Vender"
        btnVender.UseVisualStyleBackColor = False
        ' 
        ' txtPrecioVenta
        ' 
        txtPrecioVenta.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        txtPrecioVenta.Enabled = False
        txtPrecioVenta.Location = New Point(144, 46)
        txtPrecioVenta.Name = "txtPrecioVenta"
        txtPrecioVenta.Size = New Size(96, 23)
        txtPrecioVenta.TabIndex = 3
        ' 
        ' lblPrecioVenta
        ' 
        lblPrecioVenta.AutoSize = True
        lblPrecioVenta.Location = New Point(27, 49)
        lblPrecioVenta.Name = "lblPrecioVenta"
        lblPrecioVenta.Size = New Size(72, 15)
        lblPrecioVenta.TabIndex = 2
        lblPrecioVenta.Text = "Precio Venta"
        ' 
        ' txtCantidad2
        ' 
        txtCantidad2.Location = New Point(144, 20)
        txtCantidad2.Name = "txtCantidad2"
        txtCantidad2.Size = New Size(96, 23)
        txtCantidad2.TabIndex = 1
        ' 
        ' lblCantidad2
        ' 
        lblCantidad2.AutoSize = True
        lblCantidad2.Location = New Point(27, 23)
        lblCantidad2.Name = "lblCantidad2"
        lblCantidad2.Size = New Size(52, 15)
        lblCantidad2.TabIndex = 0
        lblCantidad2.Text = "Cantdad"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(gpb4)
        Controls.Add(gpb3)
        Controls.Add(gpb2)
        Controls.Add(gpb1)
        Name = "Form1"
        Text = "Form1"
        gpb1.ResumeLayout(False)
        gpb1.PerformLayout()
        gpb2.ResumeLayout(False)
        gpb2.PerformLayout()
        gpb3.ResumeLayout(False)
        gpb3.PerformLayout()
        gpb4.ResumeLayout(False)
        gpb4.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gpb1 As GroupBox
    Friend WithEvents rdbOtro As RadioButton
    Friend WithEvents rdbHeladera As RadioButton
    Friend WithEvents rdbLavarropas As RadioButton
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents gpb2 As GroupBox
    Friend WithEvents lblWatt As Label
    Friend WithEvents txtConsumo As TextBox
    Friend WithEvents lblConsumo As Label
    Friend WithEvents lblKgLitro As Label
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents lblCapacidad As Label
    Friend WithEvents cboColor As ComboBox
    Friend WithEvents lblColor As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents gpb3 As GroupBox
    Friend WithEvents lblStock As Label
    Friend WithEvents lblUnid As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents gpb4 As GroupBox
    Friend WithEvents lblCantidad1 As Label
    Friend WithEvents btnComprar As Button
    Friend WithEvents txtPrecioCompra As TextBox
    Friend WithEvents lblPrecioCompra As Label
    Friend WithEvents txtCantidad1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnVender As Button
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents lblPrecioVenta As Label
    Friend WithEvents txtCantidad2 As TextBox
    Friend WithEvents lblCantidad2 As Label

End Class
