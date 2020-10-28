<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rendicion_factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rendicion_factura))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSelecciona = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonDesmarcar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNumFactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRendir = New System.Windows.Forms.Button()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GrillaRendidas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fac_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pic_ocnumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fac_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rac_neto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rac_iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rac_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colrel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpIngresoHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpIngresoDesde = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.col_s = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.COL_COD_PICKING = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_oc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fec_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCliente2 = New System.Windows.Forms.ComboBox()
        Me.txtOrdenCompra2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumFactura2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GrillaRendidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.ToolStripSeparator1, Me.ButtonSelecciona, Me.ToolStripSeparator5, Me.ButtonDesmarcar, Me.ToolStripSeparator3, Me.btnExportar, Me.ToolStripSeparator2, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1150, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 22)
        Me.btnBuscar.Text = "BUSCAR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonSelecciona
        '
        Me.ButtonSelecciona.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSelecciona.Image = CType(resources.GetObject("ButtonSelecciona.Image"), System.Drawing.Image)
        Me.ButtonSelecciona.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSelecciona.Name = "ButtonSelecciona"
        Me.ButtonSelecciona.Size = New System.Drawing.Size(123, 22)
        Me.ButtonSelecciona.Text = "SELECCIONA TODO"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonDesmarcar
        '
        Me.ButtonDesmarcar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDesmarcar.Image = CType(resources.GetObject("ButtonDesmarcar.Image"), System.Drawing.Image)
        Me.ButtonDesmarcar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonDesmarcar.Name = "ButtonDesmarcar"
        Me.ButtonDesmarcar.Size = New System.Drawing.Size(125, 22)
        Me.ButtonDesmarcar.Text = "DESMARCAR TODO"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ForeColor = System.Drawing.Color.Black
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(124, 22)
        Me.btnExportar.Text = "EXPORTAR A EXCEL"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(55, 22)
        Me.btnSalir.Text = "SALIR"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1150, 5)
        Me.Panel4.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1150, 31)
        Me.Panel3.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTADO DE FACTURAS POR RENDIR"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTotal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 576)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1150, 24)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblTotal
        '
        Me.lblTotal.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblTotal.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(123, 19)
        Me.lblTotal.Text = "ToolStripStatusLabel1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtOrdenCompra)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtNumFactura)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnRendir)
        Me.Panel1.Controls.Add(Me.cmbCliente)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 33)
        Me.Panel1.TabIndex = 14
        '
        'txtNumFactura
        '
        Me.txtNumFactura.Location = New System.Drawing.Point(592, 5)
        Me.txtNumFactura.Name = "txtNumFactura"
        Me.txtNumFactura.Size = New System.Drawing.Size(97, 22)
        Me.txtNumFactura.TabIndex = 20
        Me.txtNumFactura.Text = "0"
        Me.txtNumFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(530, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "N° Factura"
        '
        'btnRendir
        '
        Me.btnRendir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRendir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRendir.Location = New System.Drawing.Point(697, 5)
        Me.btnRendir.Name = "btnRendir"
        Me.btnRendir.Size = New System.Drawing.Size(110, 22)
        Me.btnRendir.TabIndex = 18
        Me.btnRendir.Text = "Rendir factura(s)"
        Me.btnRendir.UseVisualStyleBackColor = False
        '
        'cmbCliente
        '
        Me.cmbCliente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(110, 6)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(204, 21)
        Me.cmbCliente.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Seleccione Cliente"
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.BackgroundColor = System.Drawing.Color.White
        Me.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla.ColumnHeadersHeight = 25
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_s, Me.COL_COD_PICKING, Me.col_oc, Me.col_fec_ingreso, Me.col_monto})
        Me.Grilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla.EnableHeadersVisualStyles = False
        Me.Grilla.GridColor = System.Drawing.SystemColors.HotTrack
        Me.Grilla.Location = New System.Drawing.Point(3, 36)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.Grilla.RowHeadersVisible = False
        Me.Grilla.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.Grilla.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.Grilla.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.Grilla.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(956, 450)
        Me.Grilla.TabIndex = 15
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1150, 515)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Grilla)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(962, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RENDICIÓN DE FACTURAS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GrillaRendidas)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1142, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BUSQUEDA DE FACTURAS RENDIDAS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GrillaRendidas
        '
        Me.GrillaRendidas.AllowUserToAddRows = False
        Me.GrillaRendidas.AllowUserToDeleteRows = False
        Me.GrillaRendidas.BackgroundColor = System.Drawing.Color.White
        Me.GrillaRendidas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaRendidas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GrillaRendidas.ColumnHeadersHeight = 25
        Me.GrillaRendidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.fac_numero, Me.pic_ocnumero, Me.fac_fecha, Me.rac_neto, Me.rac_iva, Me.rac_total, Me.car_rut, Me.car_nombre, Me.colrel})
        Me.GrillaRendidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaRendidas.EnableHeadersVisualStyles = False
        Me.GrillaRendidas.GridColor = System.Drawing.SystemColors.HotTrack
        Me.GrillaRendidas.Location = New System.Drawing.Point(3, 67)
        Me.GrillaRendidas.Name = "GrillaRendidas"
        Me.GrillaRendidas.ReadOnly = True
        Me.GrillaRendidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.GrillaRendidas.RowHeadersVisible = False
        Me.GrillaRendidas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.GrillaRendidas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrillaRendidas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.GrillaRendidas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.GrillaRendidas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GrillaRendidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaRendidas.Size = New System.Drawing.Size(1136, 419)
        Me.GrillaRendidas.TabIndex = 56
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'fac_numero
        '
        Me.fac_numero.HeaderText = "N° FACTURA"
        Me.fac_numero.Name = "fac_numero"
        Me.fac_numero.ReadOnly = True
        '
        'pic_ocnumero
        '
        Me.pic_ocnumero.HeaderText = "N° OC"
        Me.pic_ocnumero.Name = "pic_ocnumero"
        Me.pic_ocnumero.ReadOnly = True
        Me.pic_ocnumero.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'fac_fecha
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.fac_fecha.DefaultCellStyle = DataGridViewCellStyle6
        Me.fac_fecha.HeaderText = "CREACION"
        Me.fac_fecha.Name = "fac_fecha"
        Me.fac_fecha.ReadOnly = True
        '
        'rac_neto
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.rac_neto.DefaultCellStyle = DataGridViewCellStyle7
        Me.rac_neto.HeaderText = "TOTAL NETO"
        Me.rac_neto.Name = "rac_neto"
        Me.rac_neto.ReadOnly = True
        '
        'rac_iva
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.rac_iva.DefaultCellStyle = DataGridViewCellStyle8
        Me.rac_iva.HeaderText = "TOTAL IVA"
        Me.rac_iva.Name = "rac_iva"
        Me.rac_iva.ReadOnly = True
        '
        'rac_total
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.rac_total.DefaultCellStyle = DataGridViewCellStyle9
        Me.rac_total.HeaderText = "TOTAL"
        Me.rac_total.Name = "rac_total"
        Me.rac_total.ReadOnly = True
        '
        'car_rut
        '
        Me.car_rut.HeaderText = "RUT"
        Me.car_rut.Name = "car_rut"
        Me.car_rut.ReadOnly = True
        '
        'car_nombre
        '
        Me.car_nombre.FillWeight = 150.0!
        Me.car_nombre.HeaderText = "RAZON  SOCIAL"
        Me.car_nombre.Name = "car_nombre"
        Me.car_nombre.ReadOnly = True
        Me.car_nombre.Width = 250
        '
        'colrel
        '
        Me.colrel.HeaderText = "RENDICIÓN"
        Me.colrel.Name = "colrel"
        Me.colrel.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtOrdenCompra2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtNumFactura2)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cmbCliente2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.dtpIngresoHasta)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.dtpIngresoDesde)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1136, 39)
        Me.Panel2.TabIndex = 55
        '
        'dtpIngresoHasta
        '
        Me.dtpIngresoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIngresoHasta.Location = New System.Drawing.Point(1033, 8)
        Me.dtpIngresoHasta.Name = "dtpIngresoHasta"
        Me.dtpIngresoHasta.Size = New System.Drawing.Size(82, 22)
        Me.dtpIngresoHasta.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(991, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(707, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Seleccione fecha de rendición desde"
        '
        'dtpIngresoDesde
        '
        Me.dtpIngresoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIngresoDesde.Location = New System.Drawing.Point(903, 8)
        Me.dtpIngresoDesde.Name = "dtpIngresoDesde"
        Me.dtpIngresoDesde.Size = New System.Drawing.Size(82, 22)
        Me.dtpIngresoDesde.TabIndex = 4
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator4, Me.ToolStripSeparator6, Me.ButtonImprimir, Me.ToolStripSeparator7})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1136, 25)
        Me.ToolStrip2.TabIndex = 54
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton1.Text = "BUSCAR"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonImprimir
        '
        Me.ButtonImprimir.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImprimir.Image = CType(resources.GetObject("ButtonImprimir.Image"), System.Drawing.Image)
        Me.ButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonImprimir.Name = "ButtonImprimir"
        Me.ButtonImprimir.Size = New System.Drawing.Size(76, 22)
        Me.ButtonImprimir.Text = "IMPRIMIR"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(327, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Orden Compra"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Location = New System.Drawing.Point(413, 5)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(97, 22)
        Me.txtOrdenCompra.TabIndex = 22
        Me.txtOrdenCompra.Text = "0"
        Me.txtOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'col_s
        '
        Me.col_s.HeaderText = "S"
        Me.col_s.Name = "col_s"
        Me.col_s.Width = 25
        '
        'COL_COD_PICKING
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.COL_COD_PICKING.DefaultCellStyle = DataGridViewCellStyle2
        Me.COL_COD_PICKING.HeaderText = "N° Factura"
        Me.COL_COD_PICKING.Name = "COL_COD_PICKING"
        Me.COL_COD_PICKING.ReadOnly = True
        '
        'col_oc
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_oc.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_oc.HeaderText = "Orden Compra"
        Me.col_oc.Name = "col_oc"
        Me.col_oc.ReadOnly = True
        '
        'col_fec_ingreso
        '
        Me.col_fec_ingreso.HeaderText = "Fecha Emisión"
        Me.col_fec_ingreso.Name = "col_fec_ingreso"
        Me.col_fec_ingreso.ReadOnly = True
        Me.col_fec_ingreso.Width = 120
        '
        'col_monto
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_monto.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_monto.HeaderText = "Monto"
        Me.col_monto.Name = "col_monto"
        Me.col_monto.ReadOnly = True
        Me.col_monto.Width = 120
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Seleccione Cliente"
        '
        'cmbCliente2
        '
        Me.cmbCliente2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente2.FormattingEnabled = True
        Me.cmbCliente2.Location = New System.Drawing.Point(121, 8)
        Me.cmbCliente2.Name = "cmbCliente2"
        Me.cmbCliente2.Size = New System.Drawing.Size(204, 21)
        Me.cmbCliente2.TabIndex = 15
        '
        'txtOrdenCompra2
        '
        Me.txtOrdenCompra2.Location = New System.Drawing.Point(419, 8)
        Me.txtOrdenCompra2.Name = "txtOrdenCompra2"
        Me.txtOrdenCompra2.Size = New System.Drawing.Size(97, 22)
        Me.txtOrdenCompra2.TabIndex = 26
        Me.txtOrdenCompra2.Text = "0"
        Me.txtOrdenCompra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(333, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Orden Compra"
        '
        'txtNumFactura2
        '
        Me.txtNumFactura2.Location = New System.Drawing.Point(591, 8)
        Me.txtNumFactura2.Name = "txtNumFactura2"
        Me.txtNumFactura2.Size = New System.Drawing.Size(97, 22)
        Me.txtNumFactura2.TabIndex = 24
        Me.txtNumFactura2.Text = "0"
        Me.txtNumFactura2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(524, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "N° Factura"
        '
        'frm_rendicion_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 600)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_rendicion_factura"
        Me.Text = "RENDICIÓN DE FACTURAS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GrillaRendidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnBuscar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnExportar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblTotal As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents btnRendir As Button
    Friend WithEvents ButtonDesmarcar As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ButtonSelecciona As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumFactura As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GrillaRendidas As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpIngresoDesde As DateTimePicker
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ButtonImprimir As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpIngresoHasta As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents fac_numero As DataGridViewTextBoxColumn
    Friend WithEvents pic_ocnumero As DataGridViewTextBoxColumn
    Friend WithEvents fac_fecha As DataGridViewTextBoxColumn
    Friend WithEvents rac_neto As DataGridViewTextBoxColumn
    Friend WithEvents rac_iva As DataGridViewTextBoxColumn
    Friend WithEvents rac_total As DataGridViewTextBoxColumn
    Friend WithEvents car_rut As DataGridViewTextBoxColumn
    Friend WithEvents car_nombre As DataGridViewTextBoxColumn
    Friend WithEvents colrel As DataGridViewTextBoxColumn
    Friend WithEvents txtOrdenCompra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents col_s As DataGridViewCheckBoxColumn
    Friend WithEvents COL_COD_PICKING As DataGridViewTextBoxColumn
    Friend WithEvents col_oc As DataGridViewTextBoxColumn
    Friend WithEvents col_fec_ingreso As DataGridViewTextBoxColumn
    Friend WithEvents col_monto As DataGridViewTextBoxColumn
    Friend WithEvents txtOrdenCompra2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNumFactura2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbCliente2 As ComboBox
    Friend WithEvents Label7 As Label
End Class
