<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajuste_ubicacion_detalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProducto2 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblPallet1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPallet = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.chkCantidad = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbPallet = New System.Windows.Forms.ComboBox()
        Me.chkMuevePallet = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.txtNuevoPallet = New System.Windows.Forms.TextBox()
        Me.chkCreaPallet = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Código"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProducto2
        '
        Me.lblProducto2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProducto2.Location = New System.Drawing.Point(12, 34)
        Me.lblProducto2.Name = "lblProducto2"
        Me.lblProducto2.Size = New System.Drawing.Size(90, 22)
        Me.lblProducto2.TabIndex = 84
        Me.lblProducto2.Text = "Producto"
        Me.lblProducto2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(107, 9)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(308, 22)
        Me.lblCodigo.TabIndex = 85
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProducto
        '
        Me.lblProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProducto.Location = New System.Drawing.Point(106, 34)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(308, 22)
        Me.lblProducto.TabIndex = 86
        Me.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPallet1
        '
        Me.lblPallet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPallet1.Location = New System.Drawing.Point(12, 59)
        Me.lblPallet1.Name = "lblPallet1"
        Me.lblPallet1.Size = New System.Drawing.Size(90, 22)
        Me.lblPallet1.TabIndex = 87
        Me.lblPallet1.Text = "Pallet"
        Me.lblPallet1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(12, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 22)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Ubicación"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPallet
        '
        Me.lblPallet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPallet.Location = New System.Drawing.Point(106, 59)
        Me.lblPallet.Name = "lblPallet"
        Me.lblPallet.Size = New System.Drawing.Size(308, 22)
        Me.lblPallet.TabIndex = 89
        Me.lblPallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUbicacion
        '
        Me.lblUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUbicacion.Location = New System.Drawing.Point(106, 84)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(308, 22)
        Me.lblUbicacion.TabIndex = 90
        Me.lblUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(12, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 22)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Cantidad"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidad
        '
        Me.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidad.Location = New System.Drawing.Point(106, 109)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(308, 22)
        Me.lblCantidad.TabIndex = 92
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.chkCantidad)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 38)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(133, 11)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(76, 21)
        Me.txtCantidad.TabIndex = 84
        Me.txtCantidad.Text = "0"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkCantidad
        '
        Me.chkCantidad.AutoSize = True
        Me.chkCantidad.Location = New System.Drawing.Point(11, 13)
        Me.chkCantidad.Name = "chkCantidad"
        Me.chkCantidad.Size = New System.Drawing.Size(121, 17)
        Me.chkCantidad.TabIndex = 0
        Me.chkCantidad.Text = "Modifica Cantidad"
        Me.chkCantidad.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbPallet)
        Me.GroupBox2.Controls.Add(Me.chkMuevePallet)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 40)
        Me.GroupBox2.TabIndex = 94
        Me.GroupBox2.TabStop = False
        '
        'cmbPallet
        '
        Me.cmbPallet.BackColor = System.Drawing.Color.White
        Me.cmbPallet.Enabled = False
        Me.cmbPallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPallet.FormattingEnabled = True
        Me.cmbPallet.Location = New System.Drawing.Point(133, 12)
        Me.cmbPallet.Name = "cmbPallet"
        Me.cmbPallet.Size = New System.Drawing.Size(264, 21)
        Me.cmbPallet.TabIndex = 87
        '
        'chkMuevePallet
        '
        Me.chkMuevePallet.AutoSize = True
        Me.chkMuevePallet.Location = New System.Drawing.Point(11, 17)
        Me.chkMuevePallet.Name = "chkMuevePallet"
        Me.chkMuevePallet.Size = New System.Drawing.Size(95, 17)
        Me.chkMuevePallet.TabIndex = 1
        Me.chkMuevePallet.Text = "Mueve pallet "
        Me.chkMuevePallet.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCrear)
        Me.GroupBox3.Controls.Add(Me.txtNuevoPallet)
        Me.GroupBox3.Controls.Add(Me.chkCreaPallet)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(403, 44)
        Me.GroupBox3.TabIndex = 95
        Me.GroupBox3.TabStop = False
        '
        'btnCrear
        '
        Me.btnCrear.Enabled = False
        Me.btnCrear.Location = New System.Drawing.Point(330, 12)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(66, 23)
        Me.btnCrear.TabIndex = 86
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'txtNuevoPallet
        '
        Me.txtNuevoPallet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNuevoPallet.Enabled = False
        Me.txtNuevoPallet.Location = New System.Drawing.Point(132, 13)
        Me.txtNuevoPallet.Multiline = True
        Me.txtNuevoPallet.Name = "txtNuevoPallet"
        Me.txtNuevoPallet.Size = New System.Drawing.Size(192, 21)
        Me.txtNuevoPallet.TabIndex = 85
        '
        'chkCreaPallet
        '
        Me.chkCreaPallet.AutoSize = True
        Me.chkCreaPallet.Location = New System.Drawing.Point(11, 17)
        Me.chkCreaPallet.Name = "chkCreaPallet"
        Me.chkCreaPallet.Size = New System.Drawing.Size(85, 17)
        Me.chkCreaPallet.TabIndex = 1
        Me.chkCreaPallet.Text = "Crear pallet"
        Me.chkCreaPallet.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(11, 246)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 96
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(91, 246)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 97
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frm_ajuste_ubicacion_detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 274)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblUbicacion)
        Me.Controls.Add(Me.lblPallet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPallet1)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.lblProducto2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ajuste_ubicacion_detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de la ubicaión"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents lblProducto2 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblPallet1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPallet As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCantidad As CheckBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkMuevePallet As CheckBox
    Friend WithEvents cmbPallet As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents txtNuevoPallet As TextBox
    Friend WithEvents chkCreaPallet As CheckBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
End Class
