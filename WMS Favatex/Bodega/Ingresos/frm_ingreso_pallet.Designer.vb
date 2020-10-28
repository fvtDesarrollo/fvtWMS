<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ing_pallet
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
        Me.cmbBulto = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTipoPallet = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPallet = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
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
        'cmbBulto
        '
        Me.cmbBulto.BackColor = System.Drawing.Color.White
        Me.cmbBulto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBulto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBulto.FormattingEnabled = True
        Me.cmbBulto.Location = New System.Drawing.Point(281, 9)
        Me.cmbBulto.Name = "cmbBulto"
        Me.cmbBulto.Size = New System.Drawing.Size(51, 21)
        Me.cmbBulto.TabIndex = 86
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Location = New System.Drawing.Point(105, 9)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(172, 21)
        Me.txtCodigo.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 22)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProducto
        '
        Me.lblProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProducto.Location = New System.Drawing.Point(105, 33)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(227, 22)
        Me.lblProducto.TabIndex = 90
        Me.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 22)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Tipo Pallet"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoPallet
        '
        Me.lblTipoPallet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoPallet.Location = New System.Drawing.Point(105, 57)
        Me.lblTipoPallet.Name = "lblTipoPallet"
        Me.lblTipoPallet.Size = New System.Drawing.Size(227, 22)
        Me.lblTipoPallet.TabIndex = 92
        Me.lblTipoPallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(12, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 22)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Identificador"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPallet
        '
        Me.lblPallet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPallet.Location = New System.Drawing.Point(105, 81)
        Me.lblPallet.Name = "lblPallet"
        Me.lblPallet.Size = New System.Drawing.Size(227, 22)
        Me.lblPallet.TabIndex = 94
        Me.lblPallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(12, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 22)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Cantidad"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Location = New System.Drawing.Point(105, 106)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(227, 22)
        Me.txtCantidad.TabIndex = 96
        Me.txtCantidad.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(11, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 10)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(89, 139)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 99
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(9, 139)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 98
        Me.btnGuardar.Text = "Aceptar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frm_ing_pallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 168)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPallet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTipoPallet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBulto)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ing_pallet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de pallet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents cmbBulto As ComboBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTipoPallet As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPallet As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
End Class
