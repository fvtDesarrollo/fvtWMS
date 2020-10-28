<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orden_compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orden_compra))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrillaFechas = New System.Windows.Forms.DataGridView()
        Me.col_fecha_p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCODINTERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSKU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNOFAV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLCCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_CAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLPRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colelimina = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkParcial = New System.Windows.Forms.CheckBox()
        Me.txtDespachar = New System.Windows.Forms.TextBox()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.chkPorConfirmar = New System.Windows.Forms.CheckBox()
        Me.txtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.txtRutCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.txtFonoCliente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbRegion = New System.Windows.Forms.ComboBox()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.cmbComunas = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrillaFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ToolStrip2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1071, 30)
        Me.Panel2.TabIndex = 6
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripButton3})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1071, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripButton1.Text = "NUEVO"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripButton2.Text = "GUARDAR"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripButton3.Text = "SALIR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1071, 23)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANTENEDOR DE ORDEN DE COMPRA"
        '
        'GrillaFechas
        '
        Me.GrillaFechas.AllowUserToAddRows = False
        Me.GrillaFechas.AllowUserToDeleteRows = False
        Me.GrillaFechas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrillaFechas.BackgroundColor = System.Drawing.Color.White
        Me.GrillaFechas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaFechas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaFechas.ColumnHeadersHeight = 25
        Me.GrillaFechas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fecha_p, Me.CCODINTERNO, Me.CSKU, Me.CNOFAV, Me.COLCCL, Me.COL_CAN, Me.COLPRECIO, Me.COLTOTAL, Me.colelimina, Me.Column1})
        Me.GrillaFechas.EnableHeadersVisualStyles = False
        Me.GrillaFechas.GridColor = System.Drawing.SystemColors.HotTrack
        Me.GrillaFechas.Location = New System.Drawing.Point(16, 283)
        Me.GrillaFechas.Name = "GrillaFechas"
        Me.GrillaFechas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.GrillaFechas.RowHeadersVisible = False
        Me.GrillaFechas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.GrillaFechas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrillaFechas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.GrillaFechas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.GrillaFechas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GrillaFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaFechas.Size = New System.Drawing.Size(1043, 400)
        Me.GrillaFechas.TabIndex = 13
        '
        'col_fecha_p
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_fecha_p.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_fecha_p.HeaderText = "COD_PRODUCTO"
        Me.col_fecha_p.Name = "col_fecha_p"
        Me.col_fecha_p.ReadOnly = True
        Me.col_fecha_p.Visible = False
        Me.col_fecha_p.Width = 110
        '
        'CCODINTERNO
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.CCODINTERNO.DefaultCellStyle = DataGridViewCellStyle3
        Me.CCODINTERNO.HeaderText = "C. Interno"
        Me.CCODINTERNO.Name = "CCODINTERNO"
        '
        'CSKU
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CSKU.DefaultCellStyle = DataGridViewCellStyle4
        Me.CSKU.HeaderText = "Sku Cliente"
        Me.CSKU.Name = "CSKU"
        '
        'CNOFAV
        '
        Me.CNOFAV.HeaderText = "Nombre Favatex"
        Me.CNOFAV.Name = "CNOFAV"
        Me.CNOFAV.ReadOnly = True
        Me.CNOFAV.Width = 150
        '
        'COLCCL
        '
        Me.COLCCL.HeaderText = "Nombre cliente"
        Me.COLCCL.Name = "COLCCL"
        Me.COLCCL.ReadOnly = True
        Me.COLCCL.Width = 150
        '
        'COL_CAN
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.COL_CAN.DefaultCellStyle = DataGridViewCellStyle5
        Me.COL_CAN.HeaderText = "Cantidad"
        Me.COL_CAN.Name = "COL_CAN"
        Me.COL_CAN.Width = 70
        '
        'COLPRECIO
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.COLPRECIO.DefaultCellStyle = DataGridViewCellStyle6
        Me.COLPRECIO.HeaderText = "Precio"
        Me.COLPRECIO.Name = "COLPRECIO"
        Me.COLPRECIO.Width = 90
        '
        'COLTOTAL
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.COLTOTAL.DefaultCellStyle = DataGridViewCellStyle7
        Me.COLTOTAL.HeaderText = "Total"
        Me.COLTOTAL.Name = "COLTOTAL"
        Me.COLTOTAL.ReadOnly = True
        Me.COLTOTAL.Width = 110
        '
        'colelimina
        '
        Me.colelimina.HeaderText = ""
        Me.colelimina.Name = "colelimina"
        Me.colelimina.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colelimina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colelimina.Text = "Quitar"
        Me.colelimina.UseColumnTextForButtonValue = True
        Me.colelimina.Width = 60
        '
        'Column1
        '
        Me.Column1.HeaderText = "FILA"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(10, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccione cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCliente
        '
        Me.cmbCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCliente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(123, 16)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(334, 21)
        Me.cmbCliente.TabIndex = 2
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Location = New System.Drawing.Point(614, 15)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(206, 22)
        Me.txtOrdenCompra.TabIndex = 4
        Me.txtOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(357, 41)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 22)
        Me.txtFecha.TabIndex = 5
        '
        'chkParcial
        '
        Me.chkParcial.AutoSize = True
        Me.chkParcial.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkParcial.Location = New System.Drawing.Point(517, 146)
        Me.chkParcial.Name = "chkParcial"
        Me.chkParcial.Size = New System.Drawing.Size(130, 17)
        Me.chkParcial.TabIndex = 8
        Me.chkParcial.Text = "Entrega parcializada"
        Me.chkParcial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkParcial.UseVisualStyleBackColor = True
        '
        'txtDespachar
        '
        Me.txtDespachar.Location = New System.Drawing.Point(123, 143)
        Me.txtDespachar.Multiline = True
        Me.txtDespachar.Name = "txtDespachar"
        Me.txtDespachar.Size = New System.Drawing.Size(334, 47)
        Me.txtDespachar.TabIndex = 11
        '
        'txtLocal
        '
        Me.txtLocal.Location = New System.Drawing.Point(123, 194)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(334, 22)
        Me.txtLocal.TabIndex = 12
        '
        'chkPorConfirmar
        '
        Me.chkPorConfirmar.AutoSize = True
        Me.chkPorConfirmar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPorConfirmar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPorConfirmar.ForeColor = System.Drawing.Color.Red
        Me.chkPorConfirmar.Location = New System.Drawing.Point(663, 145)
        Me.chkPorConfirmar.Name = "chkPorConfirmar"
        Me.chkPorConfirmar.Size = New System.Drawing.Size(145, 17)
        Me.chkPorConfirmar.TabIndex = 13
        Me.chkPorConfirmar.Text = "Por confirmar entregas"
        Me.chkPorConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPorConfirmar.UseVisualStyleBackColor = True
        '
        'txtFechaEmision
        '
        Me.txtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaEmision.Location = New System.Drawing.Point(123, 41)
        Me.txtFechaEmision.Name = "txtFechaEmision"
        Me.txtFechaEmision.Size = New System.Drawing.Size(100, 22)
        Me.txtFechaEmision.TabIndex = 15
        '
        'txtRutCliente
        '
        Me.txtRutCliente.Enabled = False
        Me.txtRutCliente.Location = New System.Drawing.Point(614, 41)
        Me.txtRutCliente.Name = "txtRutCliente"
        Me.txtRutCliente.Size = New System.Drawing.Size(206, 22)
        Me.txtRutCliente.TabIndex = 17
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Enabled = False
        Me.txtNombreCliente.Location = New System.Drawing.Point(614, 67)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(206, 22)
        Me.txtNombreCliente.TabIndex = 19
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Enabled = False
        Me.txtEmailCliente.Location = New System.Drawing.Point(614, 93)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(206, 22)
        Me.txtEmailCliente.TabIndex = 20
        '
        'txtFonoCliente
        '
        Me.txtFonoCliente.Enabled = False
        Me.txtFonoCliente.Location = New System.Drawing.Point(614, 118)
        Me.txtFonoCliente.Name = "txtFonoCliente"
        Me.txtFonoCliente.Size = New System.Drawing.Size(206, 22)
        Me.txtFonoCliente.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(10, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 22)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Fecha de emisión"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(227, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 22)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Fecha de compromiso"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(10, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 22)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Seleccione Región"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(10, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 22)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Seleccione Ciudad"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(10, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 22)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Seleccione Comuna"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbRegion
        '
        Me.cmbRegion.FormattingEnabled = True
        Me.cmbRegion.Location = New System.Drawing.Point(123, 68)
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.Size = New System.Drawing.Size(334, 21)
        Me.cmbRegion.TabIndex = 49
        '
        'cmbCiudad
        '
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(123, 93)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(334, 21)
        Me.cmbCiudad.TabIndex = 51
        '
        'cmbComunas
        '
        Me.cmbComunas.FormattingEnabled = True
        Me.cmbComunas.Location = New System.Drawing.Point(123, 118)
        Me.cmbComunas.Name = "cmbComunas"
        Me.cmbComunas.Size = New System.Drawing.Size(334, 21)
        Me.cmbComunas.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(10, 143)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 46)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Despachar a"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(10, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 22)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Local de despacho"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(499, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Nº Orden Compra"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(499, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 21)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Rut Cliente"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(499, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 21)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Nombre Cliente"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(499, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 21)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Email Cliente"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkPorConfirmar)
        Me.GroupBox1.Controls.Add(Me.chkParcial)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbComunas)
        Me.GroupBox1.Controls.Add(Me.cmbCiudad)
        Me.GroupBox1.Controls.Add(Me.cmbRegion)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtFonoCliente)
        Me.GroupBox1.Controls.Add(Me.txtEmailCliente)
        Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.txtRutCliente)
        Me.GroupBox1.Controls.Add(Me.txtFechaEmision)
        Me.GroupBox1.Controls.Add(Me.txtLocal)
        Me.GroupBox1.Controls.Add(Me.txtDespachar)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.txtOrdenCompra)
        Me.GroupBox1.Controls.Add(Me.cmbCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1045, 227)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(499, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(321, 21)
        Me.Label10.TabIndex = 61
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(499, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 21)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Fono Cliente"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_orden_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 695)
        Me.Controls.Add(Me.GrillaFechas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_orden_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDEN DE COMPRA"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GrillaFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GrillaFechas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents col_fecha_p As DataGridViewTextBoxColumn
    Friend WithEvents CCODINTERNO As DataGridViewTextBoxColumn
    Friend WithEvents CSKU As DataGridViewTextBoxColumn
    Friend WithEvents CNOFAV As DataGridViewTextBoxColumn
    Friend WithEvents COLCCL As DataGridViewTextBoxColumn
    Friend WithEvents COL_CAN As DataGridViewTextBoxColumn
    Friend WithEvents COLPRECIO As DataGridViewTextBoxColumn
    Friend WithEvents COLTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents colelimina As DataGridViewButtonColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents txtOrdenCompra As TextBox
    Friend WithEvents txtFecha As DateTimePicker
    Friend WithEvents chkParcial As CheckBox
    Friend WithEvents txtDespachar As TextBox
    Friend WithEvents txtLocal As TextBox
    Friend WithEvents chkPorConfirmar As CheckBox
    Friend WithEvents txtFechaEmision As DateTimePicker
    Friend WithEvents txtRutCliente As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents txtFonoCliente As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbRegion As ComboBox
    Friend WithEvents cmbCiudad As ComboBox
    Friend WithEvents cmbComunas As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
