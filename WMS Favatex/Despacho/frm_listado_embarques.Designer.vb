<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listado_embarques
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listado_embarques))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonNueva = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ButtonExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optExterno = New System.Windows.Forms.RadioButton()
        Me.optPropio = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSello = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkDespacho = New System.Windows.Forms.CheckBox()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkOrdenCompra = New System.Windows.Forms.CheckBox()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.optGuia = New System.Windows.Forms.RadioButton()
        Me.optFactura = New System.Windows.Forms.RadioButton()
        Me.chkBuscaDoc = New System.Windows.Forms.CheckBox()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.pro_sel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_catego = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._subcat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bul_cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.doc_cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.elimina = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colArchivo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.grillaExportar = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GrillaOrden = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pasadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_hoy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cguia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COPP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.grillaExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GrillaOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1217, 4)
        Me.Panel4.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1217, 4)
        Me.Panel1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1217, 23)
        Me.Panel2.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTADO DE EMBARQUES"
        '
        'ButtonNueva
        '
        Me.ButtonNueva.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNueva.Image = CType(resources.GetObject("ButtonNueva.Image"), System.Drawing.Image)
        Me.ButtonNueva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonNueva.Name = "ButtonNueva"
        Me.ButtonNueva.Size = New System.Drawing.Size(118, 22)
        Me.ButtonNueva.Text = "NUEVO REGISTRO"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton1.Text = "BUSCAR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.ForeColor = System.Drawing.Color.Black
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(55, 22)
        Me.ButtonSalir.Text = "SALIR"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonNueva, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ButtonExportar, Me.ToolStripSeparator3, Me.ButtonSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1217, 25)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ButtonExportar
        '
        Me.ButtonExportar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExportar.Image = CType(resources.GetObject("ButtonExportar.Image"), System.Drawing.Image)
        Me.ButtonExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonExportar.Name = "ButtonExportar"
        Me.ButtonExportar.Size = New System.Drawing.Size(124, 22)
        Me.ButtonExportar.Text = "EXPORTAR A EXCEL"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTotal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 579)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1217, 22)
        Me.StatusStrip1.TabIndex = 35
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblTotal
        '
        Me.lblTotal.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblTotal.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(4, 17)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1217, 85)
        Me.Panel3.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.optExterno)
        Me.GroupBox1.Controls.Add(Me.optPropio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSello)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1203, 40)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'optExterno
        '
        Me.optExterno.AutoSize = True
        Me.optExterno.Location = New System.Drawing.Point(718, 14)
        Me.optExterno.Name = "optExterno"
        Me.optExterno.Size = New System.Drawing.Size(64, 17)
        Me.optExterno.TabIndex = 12
        Me.optExterno.Text = "Externo"
        Me.optExterno.UseVisualStyleBackColor = True
        '
        'optPropio
        '
        Me.optPropio.AutoSize = True
        Me.optPropio.Checked = True
        Me.optPropio.Location = New System.Drawing.Point(652, 14)
        Me.optPropio.Name = "optPropio"
        Me.optPropio.Size = New System.Drawing.Size(59, 17)
        Me.optPropio.TabIndex = 11
        Me.optPropio.TabStop = True
        Me.optPropio.Text = "Propio"
        Me.optPropio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(539, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo de Transporte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Cliente"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(55, 13)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(319, 21)
        Me.cmbCliente.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sello"
        '
        'txtSello
        '
        Me.txtSello.Location = New System.Drawing.Point(428, 12)
        Me.txtSello.MaxLength = 8
        Me.txtSello.Name = "txtSello"
        Me.txtSello.Size = New System.Drawing.Size(89, 22)
        Me.txtSello.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.chkDespacho)
        Me.GroupBox4.Controls.Add(Me.dtpDesde)
        Me.GroupBox4.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox4.Controls.Add(Me.txtOrdenCompra)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.chkOrdenCompra)
        Me.GroupBox4.Controls.Add(Me.dtpHasta)
        Me.GroupBox4.Controls.Add(Me.txtDocumento)
        Me.GroupBox4.Controls.Add(Me.optGuia)
        Me.GroupBox4.Controls.Add(Me.optFactura)
        Me.GroupBox4.Controls.Add(Me.chkBuscaDoc)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 38)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1202, 40)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        '
        'chkDespacho
        '
        Me.chkDespacho.AutoSize = True
        Me.chkDespacho.ForeColor = System.Drawing.Color.Black
        Me.chkDespacho.Location = New System.Drawing.Point(6, 16)
        Me.chkDespacho.Name = "chkDespacho"
        Me.chkDespacho.Size = New System.Drawing.Size(145, 17)
        Me.chkDespacho.TabIndex = 13
        Me.chkDespacho.Text = "Fecha Despacho Desde"
        Me.chkDespacho.UseVisualStyleBackColor = True
        '
        'dtpDesde
        '
        Me.dtpDesde.Enabled = False
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(154, 13)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(82, 22)
        Me.dtpDesde.TabIndex = 14
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(1109, 12)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(62, 23)
        Me.ButtonLimpiar.TabIndex = 10
        Me.ButtonLimpiar.Text = "LIMPIAR"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Enabled = False
        Me.txtOrdenCompra.Location = New System.Drawing.Point(934, 12)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(98, 22)
        Me.txtOrdenCompra.TabIndex = 11
        Me.txtOrdenCompra.Text = "0"
        Me.txtOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Hasta"
        '
        'chkOrdenCompra
        '
        Me.chkOrdenCompra.AutoSize = True
        Me.chkOrdenCompra.Location = New System.Drawing.Point(825, 15)
        Me.chkOrdenCompra.Name = "chkOrdenCompra"
        Me.chkOrdenCompra.Size = New System.Drawing.Size(102, 17)
        Me.chkOrdenCompra.TabIndex = 10
        Me.chkOrdenCompra.Text = "Orden Compra"
        Me.chkOrdenCompra.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.Enabled = False
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(291, 13)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(82, 22)
        Me.dtpHasta.TabIndex = 15
        '
        'txtDocumento
        '
        Me.txtDocumento.Enabled = False
        Me.txtDocumento.Location = New System.Drawing.Point(696, 13)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(85, 22)
        Me.txtDocumento.TabIndex = 9
        Me.txtDocumento.Text = "0"
        Me.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'optGuia
        '
        Me.optGuia.AutoSize = True
        Me.optGuia.Enabled = False
        Me.optGuia.Location = New System.Drawing.Point(590, 15)
        Me.optGuia.Name = "optGuia"
        Me.optGuia.Size = New System.Drawing.Size(103, 17)
        Me.optGuia.TabIndex = 8
        Me.optGuia.Text = "Guia Despacho"
        Me.optGuia.UseVisualStyleBackColor = True
        '
        'optFactura
        '
        Me.optFactura.AutoSize = True
        Me.optFactura.Checked = True
        Me.optFactura.Enabled = False
        Me.optFactura.Location = New System.Drawing.Point(522, 15)
        Me.optFactura.Name = "optFactura"
        Me.optFactura.Size = New System.Drawing.Size(63, 17)
        Me.optFactura.TabIndex = 7
        Me.optFactura.TabStop = True
        Me.optFactura.Text = "Factura"
        Me.optFactura.UseVisualStyleBackColor = True
        '
        'chkBuscaDoc
        '
        Me.chkBuscaDoc.AutoSize = True
        Me.chkBuscaDoc.Location = New System.Drawing.Point(394, 16)
        Me.chkBuscaDoc.Name = "chkBuscaDoc"
        Me.chkBuscaDoc.Size = New System.Drawing.Size(122, 17)
        Me.chkBuscaDoc.TabIndex = 6
        Me.chkBuscaDoc.Text = "Buscar Documento"
        Me.chkBuscaDoc.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grilla.BackgroundColor = System.Drawing.Color.White
        Me.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla.ColumnHeadersHeight = 25
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pro_sel, Me.pro_nombre, Me.pro_catego, Me.Column5, Me._subcat, Me.bul_cant, Me.doc_cant, Me.Column2, Me.Column3, Me.Column1, Me.Column4, Me.elimina, Me.colArchivo})
        Me.Grilla.EnableHeadersVisualStyles = False
        Me.Grilla.GridColor = System.Drawing.SystemColors.HotTrack
        Me.Grilla.Location = New System.Drawing.Point(7, 18)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.Grilla.RowHeadersVisible = False
        Me.Grilla.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.Grilla.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.Grilla.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.Grilla.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(607, 395)
        Me.Grilla.TabIndex = 37
        '
        'pro_sel
        '
        Me.pro_sel.HeaderText = "Sello"
        Me.pro_sel.Name = "pro_sel"
        Me.pro_sel.ReadOnly = True
        Me.pro_sel.Width = 80
        '
        'pro_nombre
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.pro_nombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.pro_nombre.HeaderText = "Fecha Ingreso"
        Me.pro_nombre.Name = "pro_nombre"
        Me.pro_nombre.ReadOnly = True
        Me.pro_nombre.Width = 110
        '
        'pro_catego
        '
        Me.pro_catego.HeaderText = "Fecha Despacho"
        Me.pro_catego.Name = "pro_catego"
        Me.pro_catego.ReadOnly = True
        Me.pro_catego.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "Hora Cita"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        '_subcat
        '
        Me._subcat.HeaderText = "Tipo Transporte"
        Me._subcat.Name = "_subcat"
        Me._subcat.ReadOnly = True
        Me._subcat.Width = 130
        '
        'bul_cant
        '
        Me.bul_cant.FillWeight = 70.0!
        Me.bul_cant.HeaderText = "Chofer"
        Me.bul_cant.Name = "bul_cant"
        Me.bul_cant.ReadOnly = True
        Me.bul_cant.Width = 150
        '
        'doc_cant
        '
        Me.doc_cant.FillWeight = 70.0!
        Me.doc_cant.HeaderText = "Vehiculo"
        Me.doc_cant.Name = "doc_cant"
        Me.doc_cant.ReadOnly = True
        Me.doc_cant.Width = 180
        '
        'Column2
        '
        Me.Column2.HeaderText = "N PALLET"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "N PALLET D"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        Me.Column3.Width = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "Ver"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.Text = "Imprimir"
        Me.Column4.UseColumnTextForButtonValue = True
        Me.Column4.Width = 80
        '
        'elimina
        '
        Me.elimina.HeaderText = ""
        Me.elimina.Name = "elimina"
        Me.elimina.ReadOnly = True
        Me.elimina.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.elimina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.elimina.Text = "Eliminar"
        Me.elimina.UseColumnTextForButtonValue = True
        Me.elimina.Width = 80
        '
        'colArchivo
        '
        Me.colArchivo.HeaderText = ""
        Me.colArchivo.Name = "colArchivo"
        Me.colArchivo.ReadOnly = True
        Me.colArchivo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colArchivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colArchivo.Text = "Arch. Para Transporte"
        Me.colArchivo.UseColumnTextForButtonValue = True
        Me.colArchivo.Width = 120
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.grillaExportar)
        Me.GroupBox5.Controls.Add(Me.Grilla)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 155)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(620, 421)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Listado de Embarques"
        '
        'grillaExportar
        '
        Me.grillaExportar.AllowUserToAddRows = False
        Me.grillaExportar.AllowUserToDeleteRows = False
        Me.grillaExportar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaExportar.BackgroundColor = System.Drawing.Color.White
        Me.grillaExportar.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaExportar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grillaExportar.ColumnHeadersHeight = 25
        Me.grillaExportar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cguia, Me.colOc, Me.CPAT, Me.CNOM, Me.CC, Me.CCO, Me.CR, Me.CNC, Me.CT, Me.CE, Me.CDI, Me.colCom, Me.CLA, Me.CLO, Me.CFM, Me.CFMA, Me.COPP})
        Me.grillaExportar.EnableHeadersVisualStyles = False
        Me.grillaExportar.GridColor = System.Drawing.SystemColors.HotTrack
        Me.grillaExportar.Location = New System.Drawing.Point(53, 114)
        Me.grillaExportar.Name = "grillaExportar"
        Me.grillaExportar.ReadOnly = True
        Me.grillaExportar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.grillaExportar.RowHeadersVisible = False
        Me.grillaExportar.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.grillaExportar.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grillaExportar.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.grillaExportar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.grillaExportar.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.grillaExportar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaExportar.Size = New System.Drawing.Size(486, 205)
        Me.grillaExportar.TabIndex = 38
        Me.grillaExportar.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.GrillaOrden)
        Me.GroupBox6.Location = New System.Drawing.Point(634, 155)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(575, 421)
        Me.GroupBox6.TabIndex = 39
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Ordenes de Compra"
        '
        'GrillaOrden
        '
        Me.GrillaOrden.AllowUserToAddRows = False
        Me.GrillaOrden.AllowUserToDeleteRows = False
        Me.GrillaOrden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrillaOrden.BackgroundColor = System.Drawing.Color.White
        Me.GrillaOrden.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaOrden.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GrillaOrden.ColumnHeadersHeight = 25
        Me.GrillaOrden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.col_cli, Me.col_pasadas, Me.col_hoy, Me.colmana})
        Me.GrillaOrden.EnableHeadersVisualStyles = False
        Me.GrillaOrden.GridColor = System.Drawing.SystemColors.HotTrack
        Me.GrillaOrden.Location = New System.Drawing.Point(6, 18)
        Me.GrillaOrden.Name = "GrillaOrden"
        Me.GrillaOrden.ReadOnly = True
        Me.GrillaOrden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.GrillaOrden.RowHeadersVisible = False
        Me.GrillaOrden.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.GrillaOrden.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrillaOrden.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.GrillaOrden.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.GrillaOrden.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GrillaOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaOrden.Size = New System.Drawing.Size(557, 395)
        Me.GrillaOrden.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "car_codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'col_cli
        '
        Me.col_cli.HeaderText = "Cliente"
        Me.col_cli.Name = "col_cli"
        Me.col_cli.ReadOnly = True
        '
        'col_pasadas
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_pasadas.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_pasadas.HeaderText = "OC No Emb."
        Me.col_pasadas.Name = "col_pasadas"
        Me.col_pasadas.ReadOnly = True
        Me.col_pasadas.Width = 80
        '
        'col_hoy
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_hoy.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_hoy.HeaderText = "OC Por Emb. Hoy"
        Me.col_hoy.Name = "col_hoy"
        Me.col_hoy.ReadOnly = True
        Me.col_hoy.Width = 120
        '
        'colmana
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colmana.DefaultCellStyle = DataGridViewCellStyle7
        Me.colmana.HeaderText = "OC Por Emb."
        Me.colmana.Name = "colmana"
        Me.colmana.ReadOnly = True
        Me.colmana.Width = 120
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30000
        '
        'cguia
        '
        Me.cguia.HeaderText = "GUIA"
        Me.cguia.Name = "cguia"
        Me.cguia.ReadOnly = True
        '
        'colOc
        '
        Me.colOc.HeaderText = "ORDEN COMPRA"
        Me.colOc.Name = "colOc"
        Me.colOc.ReadOnly = True
        '
        'CPAT
        '
        Me.CPAT.HeaderText = "PATENTE"
        Me.CPAT.Name = "CPAT"
        Me.CPAT.ReadOnly = True
        '
        'CNOM
        '
        Me.CNOM.HeaderText = "NOMBRE ITEM"
        Me.CNOM.Name = "CNOM"
        Me.CNOM.ReadOnly = True
        '
        'CC
        '
        Me.CC.HeaderText = "CANTIDAD DE BULTOS"
        Me.CC.Name = "CC"
        Me.CC.ReadOnly = True
        '
        'CCO
        '
        Me.CCO.HeaderText = "CODIGO ITEM"
        Me.CCO.Name = "CCO"
        Me.CCO.ReadOnly = True
        '
        'CR
        '
        Me.CR.HeaderText = "RUT"
        Me.CR.Name = "CR"
        Me.CR.ReadOnly = True
        '
        'CNC
        '
        Me.CNC.HeaderText = "NOMBRE CLIENTE / PROVEEDOR"
        Me.CNC.Name = "CNC"
        Me.CNC.ReadOnly = True
        '
        'CT
        '
        Me.CT.HeaderText = "TELEFONO"
        Me.CT.Name = "CT"
        Me.CT.ReadOnly = True
        '
        'CE
        '
        Me.CE.HeaderText = "EMAIL"
        Me.CE.Name = "CE"
        Me.CE.ReadOnly = True
        '
        'CDI
        '
        Me.CDI.HeaderText = "DIRECCIÓN"
        Me.CDI.Name = "CDI"
        Me.CDI.ReadOnly = True
        '
        'colCom
        '
        Me.colCom.HeaderText = "COMUNA"
        Me.colCom.Name = "colCom"
        Me.colCom.ReadOnly = True
        '
        'CLA
        '
        Me.CLA.HeaderText = "LAT"
        Me.CLA.Name = "CLA"
        Me.CLA.ReadOnly = True
        '
        'CLO
        '
        Me.CLO.HeaderText = "LONG"
        Me.CLO.Name = "CLO"
        Me.CLO.ReadOnly = True
        '
        'CFM
        '
        Me.CFM.HeaderText = "FECHA MIN"
        Me.CFM.Name = "CFM"
        Me.CFM.ReadOnly = True
        '
        'CFMA
        '
        Me.CFMA.HeaderText = "MECHA MAX"
        Me.CFMA.Name = "CFMA"
        Me.CFMA.ReadOnly = True
        '
        'COPP
        '
        Me.COPP.HeaderText = "PRECIO"
        Me.COPP.Name = "COPP"
        Me.COPP.ReadOnly = True
        '
        'frm_listado_embarques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 601)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_listado_embarques"
        Me.Text = "LISTADO DE EMBARQUES"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.grillaExportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.GrillaOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonNueva As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ButtonSalir As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblTotal As ToolStripStatusLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents txtSello As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents optExterno As RadioButton
    Friend WithEvents optPropio As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents chkDespacho As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonExportar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents optGuia As RadioButton
    Friend WithEvents optFactura As RadioButton
    Friend WithEvents chkBuscaDoc As CheckBox
    Friend WithEvents txtOrdenCompra As TextBox
    Friend WithEvents chkOrdenCompra As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GrillaOrden As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents col_cli As DataGridViewTextBoxColumn
    Friend WithEvents col_pasadas As DataGridViewTextBoxColumn
    Friend WithEvents col_hoy As DataGridViewTextBoxColumn
    Friend WithEvents colmana As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents grillaExportar As DataGridView
    Friend WithEvents pro_sel As DataGridViewTextBoxColumn
    Friend WithEvents pro_nombre As DataGridViewTextBoxColumn
    Friend WithEvents pro_catego As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents _subcat As DataGridViewTextBoxColumn
    Friend WithEvents bul_cant As DataGridViewTextBoxColumn
    Friend WithEvents doc_cant As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents elimina As DataGridViewButtonColumn
    Friend WithEvents colArchivo As DataGridViewButtonColumn
    Friend WithEvents cguia As DataGridViewTextBoxColumn
    Friend WithEvents colOc As DataGridViewTextBoxColumn
    Friend WithEvents CPAT As DataGridViewTextBoxColumn
    Friend WithEvents CNOM As DataGridViewTextBoxColumn
    Friend WithEvents CC As DataGridViewTextBoxColumn
    Friend WithEvents CCO As DataGridViewTextBoxColumn
    Friend WithEvents CR As DataGridViewTextBoxColumn
    Friend WithEvents CNC As DataGridViewTextBoxColumn
    Friend WithEvents CT As DataGridViewTextBoxColumn
    Friend WithEvents CE As DataGridViewTextBoxColumn
    Friend WithEvents CDI As DataGridViewTextBoxColumn
    Friend WithEvents colCom As DataGridViewTextBoxColumn
    Friend WithEvents CLA As DataGridViewTextBoxColumn
    Friend WithEvents CLO As DataGridViewTextBoxColumn
    Friend WithEvents CFM As DataGridViewTextBoxColumn
    Friend WithEvents CFMA As DataGridViewTextBoxColumn
    Friend WithEvents COPP As DataGridViewTextBoxColumn
End Class
