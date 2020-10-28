<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajuste_ubicaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ajuste_ubicaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNuevaBusqueda = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnIngresar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPallet = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBulto = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbAltura = New System.Windows.Forms.ComboBox()
        Me.cmbZona = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPisoOrigen = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbBodegaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GrillaDetalle = New System.Windows.Forms.DataGridView()
        Me.c_S = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colubicod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colubi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbulcodstr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCanti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cols = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodigoB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBus = New System.Windows.Forms.Button()
        Me.GrillaLog = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.alo_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusu_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusu_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpro_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpro_codigointerno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpro_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbul_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbulcodigostr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calo_accion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrillaLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 4)
        Me.Panel1.TabIndex = 35
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.btnNuevaBusqueda, Me.ToolStripSeparator4, Me.btnBuscar, Me.ToolStripSeparator1, Me.btnImprimir, Me.ToolStripSeparator7, Me.btnIngresar, Me.ToolStripSeparator3, Me.btnEliminar, Me.ToolStripSeparator6, Me.ButtonSalir, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(827, 25)
        Me.ToolStrip1.TabIndex = 36
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnNuevaBusqueda
        '
        Me.btnNuevaBusqueda.Image = CType(resources.GetObject("btnNuevaBusqueda.Image"), System.Drawing.Image)
        Me.btnNuevaBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevaBusqueda.Name = "btnNuevaBusqueda"
        Me.btnNuevaBusqueda.Size = New System.Drawing.Size(112, 22)
        Me.btnNuevaBusqueda.Text = "Nueva Busqueda"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(60, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(185, 22)
        Me.btnImprimir.Text = "Imprime identificador de Pallet"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'btnIngresar
        '
        Me.btnIngresar.Image = CType(resources.GetObject("btnIngresar.Image"), System.Drawing.Image)
        Me.btnIngresar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(133, 22)
        Me.btnIngresar.Text = "Ingresar nuevo Pallet"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 22)
        Me.btnEliminar.Text = "Eliminar Pallet(s)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(49, 22)
        Me.ButtonSalir.Text = "Salir"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 4)
        Me.Panel2.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmbPallet)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbBulto)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbAltura)
        Me.GroupBox1.Controls.Add(Me.cmbZona)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbPisoOrigen)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbBodegaOrigen)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(798, 76)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'cmbPallet
        '
        Me.cmbPallet.BackColor = System.Drawing.Color.White
        Me.cmbPallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPallet.FormattingEnabled = True
        Me.cmbPallet.Location = New System.Drawing.Point(597, 43)
        Me.cmbPallet.Name = "cmbPallet"
        Me.cmbPallet.Size = New System.Drawing.Size(192, 21)
        Me.cmbPallet.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(521, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 22)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Pallet"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbBulto
        '
        Me.cmbBulto.BackColor = System.Drawing.Color.White
        Me.cmbBulto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBulto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBulto.FormattingEnabled = True
        Me.cmbBulto.Location = New System.Drawing.Point(738, 19)
        Me.cmbBulto.Name = "cmbBulto"
        Me.cmbBulto.Size = New System.Drawing.Size(51, 21)
        Me.cmbBulto.TabIndex = 84
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Location = New System.Drawing.Point(597, 19)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(137, 21)
        Me.txtCodigo.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(521, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Código"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbAltura
        '
        Me.cmbAltura.BackColor = System.Drawing.Color.White
        Me.cmbAltura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAltura.Enabled = False
        Me.cmbAltura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAltura.FormattingEnabled = True
        Me.cmbAltura.Location = New System.Drawing.Point(430, 44)
        Me.cmbAltura.Name = "cmbAltura"
        Me.cmbAltura.Size = New System.Drawing.Size(83, 21)
        Me.cmbAltura.TabIndex = 81
        '
        'cmbZona
        '
        Me.cmbZona.BackColor = System.Drawing.Color.White
        Me.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbZona.Enabled = False
        Me.cmbZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(430, 19)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(83, 21)
        Me.cmbZona.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(371, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Altura"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(371, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 22)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Zona"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPisoOrigen
        '
        Me.cmbPisoOrigen.BackColor = System.Drawing.Color.White
        Me.cmbPisoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPisoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPisoOrigen.FormattingEnabled = True
        Me.cmbPisoOrigen.Location = New System.Drawing.Point(134, 44)
        Me.cmbPisoOrigen.Name = "cmbPisoOrigen"
        Me.cmbPisoOrigen.Size = New System.Drawing.Size(231, 21)
        Me.cmbPisoOrigen.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(6, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 22)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Tipo de Ubicación"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbBodegaOrigen
        '
        Me.cmbBodegaOrigen.BackColor = System.Drawing.Color.White
        Me.cmbBodegaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegaOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBodegaOrigen.FormattingEnabled = True
        Me.cmbBodegaOrigen.Location = New System.Drawing.Point(134, 18)
        Me.cmbBodegaOrigen.Name = "cmbBodegaOrigen"
        Me.cmbBodegaOrigen.Size = New System.Drawing.Size(231, 21)
        Me.cmbBodegaOrigen.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(6, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 22)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Seleccione Bodega"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GrillaDetalle
        '
        Me.GrillaDetalle.AllowUserToAddRows = False
        Me.GrillaDetalle.AllowUserToDeleteRows = False
        Me.GrillaDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrillaDetalle.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.GrillaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrillaDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GrillaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_S, Me.colubicod, Me.colubi, Me.colp, Me.proco, Me.codint, Me.colPro, Me.colprob, Me.colbulcodstr, Me.colCanti, Me.cols})
        Me.GrillaDetalle.EnableHeadersVisualStyles = False
        Me.GrillaDetalle.Location = New System.Drawing.Point(6, 86)
        Me.GrillaDetalle.Name = "GrillaDetalle"
        Me.GrillaDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GrillaDetalle.RowHeadersVisible = False
        Me.GrillaDetalle.Size = New System.Drawing.Size(800, 344)
        Me.GrillaDetalle.TabIndex = 81
        '
        'c_S
        '
        Me.c_S.HeaderText = "S"
        Me.c_S.Name = "c_S"
        '
        'colubicod
        '
        Me.colubicod.HeaderText = "cod_ubicacion"
        Me.colubicod.Name = "colubicod"
        Me.colubicod.ReadOnly = True
        Me.colubicod.Visible = False
        '
        'colubi
        '
        Me.colubi.HeaderText = "Ubicacion"
        Me.colubi.Name = "colubi"
        Me.colubi.ReadOnly = True
        '
        'colp
        '
        Me.colp.HeaderText = "Pallet"
        Me.colp.Name = "colp"
        Me.colp.ReadOnly = True
        '
        'proco
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.proco.DefaultCellStyle = DataGridViewCellStyle1
        Me.proco.HeaderText = "pro_codigo"
        Me.proco.Name = "proco"
        Me.proco.ReadOnly = True
        Me.proco.Visible = False
        '
        'codint
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.codint.DefaultCellStyle = DataGridViewCellStyle2
        Me.codint.HeaderText = "Código"
        Me.codint.Name = "codint"
        '
        'colPro
        '
        Me.colPro.HeaderText = "Producto"
        Me.colPro.Name = "colPro"
        Me.colPro.ReadOnly = True
        '
        'colprob
        '
        Me.colprob.HeaderText = "bul_codigo"
        Me.colprob.Name = "colprob"
        Me.colprob.ReadOnly = True
        Me.colprob.Visible = False
        '
        'colbulcodstr
        '
        Me.colbulcodstr.HeaderText = "Bulto"
        Me.colbulcodstr.Name = "colbulcodstr"
        Me.colbulcodstr.ReadOnly = True
        '
        'colCanti
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colCanti.DefaultCellStyle = DataGridViewCellStyle3
        Me.colCanti.HeaderText = "Cantidad"
        Me.colCanti.Name = "colCanti"
        '
        'cols
        '
        Me.cols.HeaderText = ""
        Me.cols.Name = "cols"
        Me.cols.Text = "Seleccionar"
        Me.cols.UseColumnTextForButtonValue = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 462)
        Me.TabControl1.TabIndex = 82
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GrillaDetalle)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(810, 436)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ajuste de ubicaciones"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GrillaLog)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(810, 436)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LOG de ajustes por código"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnBus)
        Me.GroupBox2.Controls.Add(Me.dtpHasta)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dtpDesde)
        Me.GroupBox2.Controls.Add(Me.chkFecha)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCodigoB)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(797, 45)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'dtpHasta
        '
        Me.dtpHasta.Enabled = False
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(505, 15)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(82, 22)
        Me.dtpHasta.TabIndex = 90
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(431, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 22)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Fecha hasta"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDesde
        '
        Me.dtpDesde.Enabled = False
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(343, 15)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(82, 22)
        Me.dtpDesde.TabIndex = 88
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(243, 19)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(90, 17)
        Me.chkFecha.TabIndex = 87
        Me.chkFecha.Text = "Fecha desde"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(225, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 22)
        Me.Label8.TabIndex = 86
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigoB
        '
        Me.txtCodigoB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoB.Location = New System.Drawing.Point(82, 15)
        Me.txtCodigoB.Multiline = True
        Me.txtCodigoB.Name = "txtCodigoB"
        Me.txtCodigoB.Size = New System.Drawing.Size(137, 21)
        Me.txtCodigoB.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(6, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 22)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Código"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBus
        '
        Me.btnBus.Location = New System.Drawing.Point(593, 14)
        Me.btnBus.Name = "btnBus"
        Me.btnBus.Size = New System.Drawing.Size(64, 24)
        Me.btnBus.TabIndex = 99
        Me.btnBus.Text = "Buscar"
        Me.btnBus.UseVisualStyleBackColor = True
        '
        'GrillaLog
        '
        Me.GrillaLog.AllowUserToAddRows = False
        Me.GrillaLog.AllowUserToDeleteRows = False
        Me.GrillaLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrillaLog.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.GrillaLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrillaLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GrillaLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.alo_codigo, Me.cfecha, Me.cusu_codigo, Me.cusu_nombre, Me.cpro_codigo, Me.cpro_codigointerno, Me.cpro_nombre, Me.cbul_codigo, Me.cbulcodigostr, Me.calo_accion})
        Me.GrillaLog.EnableHeadersVisualStyles = False
        Me.GrillaLog.Location = New System.Drawing.Point(7, 55)
        Me.GrillaLog.Name = "GrillaLog"
        Me.GrillaLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GrillaLog.RowHeadersVisible = False
        Me.GrillaLog.Size = New System.Drawing.Size(797, 375)
        Me.GrillaLog.TabIndex = 82
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "S"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'alo_codigo
        '
        Me.alo_codigo.HeaderText = "alo_codigo"
        Me.alo_codigo.Name = "alo_codigo"
        Me.alo_codigo.ReadOnly = True
        Me.alo_codigo.Visible = False
        '
        'cfecha
        '
        Me.cfecha.HeaderText = "Fecha"
        Me.cfecha.Name = "cfecha"
        Me.cfecha.ReadOnly = True
        '
        'cusu_codigo
        '
        Me.cusu_codigo.HeaderText = "usu_codigo"
        Me.cusu_codigo.Name = "cusu_codigo"
        Me.cusu_codigo.ReadOnly = True
        Me.cusu_codigo.Visible = False
        '
        'cusu_nombre
        '
        Me.cusu_nombre.HeaderText = "Nombre usuario"
        Me.cusu_nombre.Name = "cusu_nombre"
        Me.cusu_nombre.ReadOnly = True
        '
        'cpro_codigo
        '
        Me.cpro_codigo.HeaderText = "pro_codigo"
        Me.cpro_codigo.Name = "cpro_codigo"
        Me.cpro_codigo.ReadOnly = True
        Me.cpro_codigo.Visible = False
        '
        'cpro_codigointerno
        '
        Me.cpro_codigointerno.HeaderText = "Códido"
        Me.cpro_codigointerno.Name = "cpro_codigointerno"
        Me.cpro_codigointerno.ReadOnly = True
        '
        'cpro_nombre
        '
        Me.cpro_nombre.HeaderText = "Nombre producto"
        Me.cpro_nombre.Name = "cpro_nombre"
        Me.cpro_nombre.ReadOnly = True
        '
        'cbul_codigo
        '
        Me.cbul_codigo.HeaderText = "bul_codigo"
        Me.cbul_codigo.Name = "cbul_codigo"
        Me.cbul_codigo.ReadOnly = True
        Me.cbul_codigo.Visible = False
        '
        'cbulcodigostr
        '
        Me.cbulcodigostr.HeaderText = "Bulto"
        Me.cbulcodigostr.Name = "cbulcodigostr"
        Me.cbulcodigostr.ReadOnly = True
        '
        'calo_accion
        '
        Me.calo_accion.HeaderText = "Acción"
        Me.calo_accion.Name = "calo_accion"
        Me.calo_accion.ReadOnly = True
        '
        'frm_ajuste_ubicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(827, 502)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_ajuste_ubicaciones"
        Me.Text = "Ajuste de ubicaciones"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrillaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GrillaLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnBuscar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnNuevaBusqueda As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ButtonSalir As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbZona As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPisoOrigen As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbBodegaOrigen As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbAltura As ComboBox
    Friend WithEvents cmbPallet As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBulto As ComboBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents GrillaDetalle As DataGridView
    Friend WithEvents btnIngresar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents c_S As DataGridViewCheckBoxColumn
    Friend WithEvents colubicod As DataGridViewTextBoxColumn
    Friend WithEvents colubi As DataGridViewTextBoxColumn
    Friend WithEvents colp As DataGridViewTextBoxColumn
    Friend WithEvents proco As DataGridViewTextBoxColumn
    Friend WithEvents codint As DataGridViewTextBoxColumn
    Friend WithEvents colPro As DataGridViewTextBoxColumn
    Friend WithEvents colprob As DataGridViewTextBoxColumn
    Friend WithEvents colbulcodstr As DataGridViewTextBoxColumn
    Friend WithEvents colCanti As DataGridViewTextBoxColumn
    Friend WithEvents cols As DataGridViewButtonColumn
    Friend WithEvents btnImprimir As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkFecha As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodigoB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents GrillaLog As DataGridView
    Friend WithEvents btnBus As Button
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents alo_codigo As DataGridViewTextBoxColumn
    Friend WithEvents cfecha As DataGridViewTextBoxColumn
    Friend WithEvents cusu_codigo As DataGridViewTextBoxColumn
    Friend WithEvents cusu_nombre As DataGridViewTextBoxColumn
    Friend WithEvents cpro_codigo As DataGridViewTextBoxColumn
    Friend WithEvents cpro_codigointerno As DataGridViewTextBoxColumn
    Friend WithEvents cpro_nombre As DataGridViewTextBoxColumn
    Friend WithEvents cbul_codigo As DataGridViewTextBoxColumn
    Friend WithEvents cbulcodigostr As DataGridViewTextBoxColumn
    Friend WithEvents calo_accion As DataGridViewTextBoxColumn
End Class
