<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_movimientos_entre_pisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_movimientos_entre_pisos))
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAprueba = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRechaza = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardaVale = New System.Windows.Forms.Button()
        Me.txtValeManager = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbPersonas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOM = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbPisoOrigen = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbBodegaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbPisoDestino = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbBodegaDestino = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GrillaDetalle = New System.Windows.Forms.DataGridView()
        Me.c_S = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cfila = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_pro_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpalletPiso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cprobulto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbultos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cols = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GrillaOperario = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.grillaDesdeRack = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmbAltura = New System.Windows.Forms.ComboBox()
        Me.cmbZona = New System.Windows.Forms.ComboBox()
        Me.btnBuscarDesdeRack = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnImprimeIdentificador = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnAsigna = New System.Windows.Forms.Button()
        Me.grillaRack = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colffr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccfila = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPalletOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccodubi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqu = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcoubi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cubin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpall = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_codin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnompro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcbul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codstrbul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.procodubi2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colubinombre2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GrillaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GrillaOperario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.grillaDesdeRack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.grillaRack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nº OM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1140, 4)
        Me.Panel1.TabIndex = 34
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.btnAprueba, Me.ToolStripSeparator1, Me.btnRechaza, Me.ToolStripSeparator3, Me.ButtonSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1140, 25)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripButton1.Text = "Imprimir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnAprueba
        '
        Me.btnAprueba.Image = CType(resources.GetObject("btnAprueba.Image"), System.Drawing.Image)
        Me.btnAprueba.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAprueba.Name = "btnAprueba"
        Me.btnAprueba.Size = New System.Drawing.Size(91, 22)
        Me.btnAprueba.Text = "Aprueba OM"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnRechaza
        '
        Me.btnRechaza.Image = CType(resources.GetObject("btnRechaza.Image"), System.Drawing.Image)
        Me.btnRechaza.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRechaza.Name = "btnRechaza"
        Me.btnRechaza.Size = New System.Drawing.Size(89, 22)
        Me.btnRechaza.Text = "Rechaza OM"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 4)
        Me.Panel2.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnGuardaVale)
        Me.GroupBox1.Controls.Add(Me.txtValeManager)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbPersonas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblOM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1119, 42)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'btnGuardaVale
        '
        Me.btnGuardaVale.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardaVale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardaVale.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardaVale.Image = CType(resources.GetObject("btnGuardaVale.Image"), System.Drawing.Image)
        Me.btnGuardaVale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardaVale.Location = New System.Drawing.Point(1003, 14)
        Me.btnGuardaVale.Name = "btnGuardaVale"
        Me.btnGuardaVale.Size = New System.Drawing.Size(105, 24)
        Me.btnGuardaVale.TabIndex = 92
        Me.btnGuardaVale.Text = "Guardar Vale"
        Me.btnGuardaVale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardaVale.UseVisualStyleBackColor = False
        '
        'txtValeManager
        '
        Me.txtValeManager.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValeManager.Enabled = False
        Me.txtValeManager.Location = New System.Drawing.Point(918, 15)
        Me.txtValeManager.Multiline = True
        Me.txtValeManager.Name = "txtValeManager"
        Me.txtValeManager.Size = New System.Drawing.Size(79, 21)
        Me.txtValeManager.TabIndex = 77
        Me.txtValeManager.Text = "0"
        Me.txtValeManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(814, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 22)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Nº Vale Manager"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEstado
        '
        Me.cmbEstado.BackColor = System.Drawing.Color.White
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Enabled = False
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(650, 15)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(158, 21)
        Me.cmbEstado.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(564, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 22)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Estado Docto."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(465, 15)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(94, 22)
        Me.dtpDesde.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(383, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Fecha Docto."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPersonas
        '
        Me.cmbPersonas.BackColor = System.Drawing.Color.White
        Me.cmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPersonas.Enabled = False
        Me.cmbPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPersonas.FormattingEnabled = True
        Me.cmbPersonas.Location = New System.Drawing.Point(220, 15)
        Me.cmbPersonas.Name = "cmbPersonas"
        Me.cmbPersonas.Size = New System.Drawing.Size(158, 21)
        Me.cmbPersonas.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(147, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 22)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Asignar a"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOM
        '
        Me.lblOM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOM.Location = New System.Drawing.Point(68, 13)
        Me.lblOM.Name = "lblOM"
        Me.lblOM.Size = New System.Drawing.Size(73, 22)
        Me.lblOM.TabIndex = 38
        Me.lblOM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbPisoOrigen)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbBodegaOrigen)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 76)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de Origen"
        '
        'cmbPisoOrigen
        '
        Me.cmbPisoOrigen.BackColor = System.Drawing.Color.White
        Me.cmbPisoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPisoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPisoOrigen.FormattingEnabled = True
        Me.cmbPisoOrigen.Location = New System.Drawing.Point(147, 44)
        Me.cmbPisoOrigen.Name = "cmbPisoOrigen"
        Me.cmbPisoOrigen.Size = New System.Drawing.Size(231, 21)
        Me.cmbPisoOrigen.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(19, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 22)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Seleccione Piso"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbBodegaOrigen
        '
        Me.cmbBodegaOrigen.BackColor = System.Drawing.Color.White
        Me.cmbBodegaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegaOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBodegaOrigen.FormattingEnabled = True
        Me.cmbBodegaOrigen.Location = New System.Drawing.Point(147, 18)
        Me.cmbBodegaOrigen.Name = "cmbBodegaOrigen"
        Me.cmbBodegaOrigen.Size = New System.Drawing.Size(231, 21)
        Me.cmbBodegaOrigen.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(19, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 22)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Seleccione Bodega"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbPisoDestino)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmbBodegaDestino)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(416, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(425, 76)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información de Destino"
        '
        'cmbPisoDestino
        '
        Me.cmbPisoDestino.BackColor = System.Drawing.Color.White
        Me.cmbPisoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPisoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPisoDestino.FormattingEnabled = True
        Me.cmbPisoDestino.Location = New System.Drawing.Point(145, 44)
        Me.cmbPisoDestino.Name = "cmbPisoDestino"
        Me.cmbPisoDestino.Size = New System.Drawing.Size(231, 21)
        Me.cmbPisoDestino.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(17, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 22)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Seleccione Piso"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbBodegaDestino
        '
        Me.cmbBodegaDestino.BackColor = System.Drawing.Color.White
        Me.cmbBodegaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegaDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBodegaDestino.FormattingEnabled = True
        Me.cmbBodegaDestino.Location = New System.Drawing.Point(145, 18)
        Me.cmbBodegaDestino.Name = "cmbBodegaDestino"
        Me.cmbBodegaDestino.Size = New System.Drawing.Size(231, 21)
        Me.cmbBodegaDestino.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(17, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 22)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Seleccione Bodega"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.GrillaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_S, Me.cfila, Me.c_pro_codigo, Me.colpalletPiso, Me.cpal, Me.ccod, Me.cop, Me.cprobulto, Me.colbultos, Me.cco, Me.colcan, Me.col, Me.cols})
        Me.GrillaDetalle.EnableHeadersVisualStyles = False
        Me.GrillaDetalle.Location = New System.Drawing.Point(6, 59)
        Me.GrillaDetalle.Name = "GrillaDetalle"
        Me.GrillaDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GrillaDetalle.RowHeadersVisible = False
        Me.GrillaDetalle.Size = New System.Drawing.Size(811, 441)
        Me.GrillaDetalle.TabIndex = 80
        '
        'c_S
        '
        Me.c_S.HeaderText = "S"
        Me.c_S.Name = "c_S"
        Me.c_S.Visible = False
        '
        'cfila
        '
        Me.cfila.HeaderText = "Fila"
        Me.cfila.Name = "cfila"
        Me.cfila.ReadOnly = True
        Me.cfila.Visible = False
        '
        'c_pro_codigo
        '
        Me.c_pro_codigo.HeaderText = "pro_codigo"
        Me.c_pro_codigo.Name = "c_pro_codigo"
        Me.c_pro_codigo.ReadOnly = True
        Me.c_pro_codigo.Visible = False
        '
        'colpalletPiso
        '
        Me.colpalletPiso.HeaderText = "palletPiso"
        Me.colpalletPiso.Name = "colpalletPiso"
        '
        'cpal
        '
        Me.cpal.HeaderText = "Pallet"
        Me.cpal.Name = "cpal"
        Me.cpal.ReadOnly = True
        '
        'ccod
        '
        Me.ccod.HeaderText = "Código"
        Me.ccod.Name = "ccod"
        Me.ccod.ReadOnly = True
        '
        'cop
        '
        Me.cop.HeaderText = "Producto"
        Me.cop.Name = "cop"
        Me.cop.ReadOnly = True
        '
        'cprobulto
        '
        Me.cprobulto.HeaderText = "pro_bulto"
        Me.cprobulto.Name = "cprobulto"
        Me.cprobulto.ReadOnly = True
        Me.cprobulto.Visible = False
        '
        'colbultos
        '
        Me.colbultos.HeaderText = "Bulto"
        Me.colbultos.Name = "colbultos"
        Me.colbultos.ReadOnly = True
        '
        'cco
        '
        Me.cco.HeaderText = "CantidadOriginal"
        Me.cco.Name = "cco"
        Me.cco.ReadOnly = True
        Me.cco.Visible = False
        '
        'colcan
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colcan.DefaultCellStyle = DataGridViewCellStyle21
        Me.colcan.HeaderText = "Cantidad"
        Me.colcan.Name = "colcan"
        Me.colcan.ReadOnly = True
        '
        'col
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col.DefaultCellStyle = DataGridViewCellStyle22
        Me.col.HeaderText = "Cant. Movil."
        Me.col.Name = "col"
        '
        'cols
        '
        Me.cols.HeaderText = ""
        Me.cols.Name = "cols"
        Me.cols.Text = "Seleccionar"
        Me.cols.UseColumnTextForButtonValue = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.GrillaOperario)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(847, 79)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 610)
        Me.GroupBox4.TabIndex = 81
        Me.GroupBox4.TabStop = False
        '
        'GrillaOperario
        '
        Me.GrillaOperario.AllowUserToAddRows = False
        Me.GrillaOperario.AllowUserToDeleteRows = False
        Me.GrillaOperario.AllowUserToOrderColumns = True
        Me.GrillaOperario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrillaOperario.BackgroundColor = System.Drawing.Color.White
        Me.GrillaOperario.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaOperario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.GrillaOperario.ColumnHeadersHeight = 25
        Me.GrillaOperario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.GrillaOperario.EnableHeadersVisualStyles = False
        Me.GrillaOperario.GridColor = System.Drawing.SystemColors.HotTrack
        Me.GrillaOperario.Location = New System.Drawing.Point(6, 47)
        Me.GrillaOperario.Name = "GrillaOperario"
        Me.GrillaOperario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.GrillaOperario.RowHeadersVisible = False
        Me.GrillaOperario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.GrillaOperario.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrillaOperario.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.GrillaOperario.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.GrillaOperario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GrillaOperario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaOperario.Size = New System.Drawing.Size(265, 557)
        Me.GrillaOperario.TabIndex = 166
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "usu_codigo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = ""
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn9.Width = 30
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nombre operario"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 215
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(6, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(265, 21)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Responsable de ejecución"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnBuscar)
        Me.GroupBox5.Controls.Add(Me.txtNombre)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txtCodigo)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(811, 49)
        Me.GroupBox5.TabIndex = 82
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Area de busqueda"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(551, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 24)
        Me.btnBuscar.TabIndex = 86
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Location = New System.Drawing.Point(360, 17)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(185, 21)
        Me.txtNombre.TabIndex = 80
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(232, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 22)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Diguite Producto"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Location = New System.Drawing.Point(147, 18)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(79, 21)
        Me.txtCodigo.TabIndex = 78
        Me.txtCodigo.Text = "0"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(19, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 22)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Diguite Código"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 157)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(831, 532)
        Me.TabControl1.TabIndex = 83
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GrillaDetalle)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(823, 506)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Busqueda"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.grillaDesdeRack)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(823, 506)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Busqueda en Rack"
        '
        'grillaDesdeRack
        '
        Me.grillaDesdeRack.AllowUserToAddRows = False
        Me.grillaDesdeRack.AllowUserToDeleteRows = False
        Me.grillaDesdeRack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaDesdeRack.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grillaDesdeRack.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaDesdeRack.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grillaDesdeRack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grillaDesdeRack.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn12, Me.colcoubi, Me.cubin, Me.colpall, Me.colpro, Me.col_codin, Me.colnompro, Me.colcbul, Me.codstrbul, Me.colcant, Me.DataGridViewButtonColumn1, Me.procodubi2, Me.colubinombre2})
        Me.grillaDesdeRack.EnableHeadersVisualStyles = False
        Me.grillaDesdeRack.Location = New System.Drawing.Point(6, 59)
        Me.grillaDesdeRack.Name = "grillaDesdeRack"
        Me.grillaDesdeRack.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grillaDesdeRack.RowHeadersVisible = False
        Me.grillaDesdeRack.Size = New System.Drawing.Size(811, 441)
        Me.grillaDesdeRack.TabIndex = 84
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmbAltura)
        Me.GroupBox6.Controls.Add(Me.cmbZona)
        Me.GroupBox6.Controls.Add(Me.btnBuscarDesdeRack)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(811, 49)
        Me.GroupBox6.TabIndex = 83
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Area de busqueda"
        '
        'cmbAltura
        '
        Me.cmbAltura.BackColor = System.Drawing.Color.White
        Me.cmbAltura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAltura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAltura.FormattingEnabled = True
        Me.cmbAltura.Location = New System.Drawing.Point(359, 17)
        Me.cmbAltura.Name = "cmbAltura"
        Me.cmbAltura.Size = New System.Drawing.Size(81, 21)
        Me.cmbAltura.TabIndex = 88
        '
        'cmbZona
        '
        Me.cmbZona.BackColor = System.Drawing.Color.White
        Me.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.Location = New System.Drawing.Point(145, 18)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(81, 21)
        Me.cmbZona.TabIndex = 87
        '
        'btnBuscarDesdeRack
        '
        Me.btnBuscarDesdeRack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscarDesdeRack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarDesdeRack.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDesdeRack.Image = CType(resources.GetObject("btnBuscarDesdeRack.Image"), System.Drawing.Image)
        Me.btnBuscarDesdeRack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarDesdeRack.Location = New System.Drawing.Point(447, 16)
        Me.btnBuscarDesdeRack.Name = "btnBuscarDesdeRack"
        Me.btnBuscarDesdeRack.Size = New System.Drawing.Size(67, 24)
        Me.btnBuscarDesdeRack.TabIndex = 86
        Me.btnBuscarDesdeRack.Text = "Buscar"
        Me.btnBuscarDesdeRack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarDesdeRack.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(232, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 22)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Seleccione Altura"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(19, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 22)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Seleccione Zona"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.UseCompatibleTextRendering = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btnEnviar)
        Me.TabPage2.Controls.Add(Me.btnImprimeIdentificador)
        Me.TabPage2.Controls.Add(Me.ProgressBar1)
        Me.TabPage2.Controls.Add(Me.btnAsigna)
        Me.TabPage2.Controls.Add(Me.grillaRack)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(823, 506)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Selección"
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Image = CType(resources.GetObject("btnEnviar.Image"), System.Drawing.Image)
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(462, 6)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(156, 24)
        Me.btnEnviar.TabIndex = 91
        Me.btnEnviar.Text = "Enviar para Aprobación"
        Me.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnImprimeIdentificador
        '
        Me.btnImprimeIdentificador.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprimeIdentificador.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimeIdentificador.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimeIdentificador.Image = CType(resources.GetObject("btnImprimeIdentificador.Image"), System.Drawing.Image)
        Me.btnImprimeIdentificador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimeIdentificador.Location = New System.Drawing.Point(259, 6)
        Me.btnImprimeIdentificador.Name = "btnImprimeIdentificador"
        Me.btnImprimeIdentificador.Size = New System.Drawing.Size(197, 24)
        Me.btnImprimeIdentificador.TabIndex = 90
        Me.btnImprimeIdentificador.Text = "Imprime Identificador de Pallet"
        Me.btnImprimeIdentificador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimeIdentificador.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 33)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(788, 23)
        Me.ProgressBar1.TabIndex = 89
        Me.ProgressBar1.Visible = False
        '
        'btnAsigna
        '
        Me.btnAsigna.BackColor = System.Drawing.SystemColors.Control
        Me.btnAsigna.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAsigna.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsigna.Image = CType(resources.GetObject("btnAsigna.Image"), System.Drawing.Image)
        Me.btnAsigna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsigna.Location = New System.Drawing.Point(7, 6)
        Me.btnAsigna.Name = "btnAsigna"
        Me.btnAsigna.Size = New System.Drawing.Size(249, 24)
        Me.btnAsigna.TabIndex = 88
        Me.btnAsigna.Text = "Asignar Ubicaciones y guarda Documento"
        Me.btnAsigna.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsigna.UseVisualStyleBackColor = False
        '
        'grillaRack
        '
        Me.grillaRack.AllowUserToAddRows = False
        Me.grillaRack.AllowUserToDeleteRows = False
        Me.grillaRack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaRack.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grillaRack.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaRack.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grillaRack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grillaRack.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.colffr, Me.ccfila, Me.DataGridViewTextBoxColumn1, Me.colPalletOrigen, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.ccodubi, Me.DataGridViewTextBoxColumn11, Me.colqu})
        Me.grillaRack.EnableHeadersVisualStyles = False
        Me.grillaRack.Location = New System.Drawing.Point(6, 60)
        Me.grillaRack.Name = "grillaRack"
        Me.grillaRack.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grillaRack.RowHeadersVisible = False
        Me.grillaRack.Size = New System.Drawing.Size(811, 440)
        Me.grillaRack.TabIndex = 81
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "S"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'colffr
        '
        Me.colffr.HeaderText = "Fila Registro"
        Me.colffr.Name = "colffr"
        Me.colffr.ReadOnly = True
        Me.colffr.Visible = False
        '
        'ccfila
        '
        Me.ccfila.HeaderText = "Fila"
        Me.ccfila.Name = "ccfila"
        Me.ccfila.ReadOnly = True
        Me.ccfila.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "pro_codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'colPalletOrigen
        '
        Me.colPalletOrigen.HeaderText = "Pallet Origen"
        Me.colPalletOrigen.Name = "colPalletOrigen"
        Me.colPalletOrigen.ReadOnly = True
        Me.colPalletOrigen.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Pallet"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "pro_bulto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'ccodubi
        '
        Me.ccodubi.HeaderText = "codUbicacion"
        Me.ccodubi.Name = "ccodubi"
        Me.ccodubi.ReadOnly = True
        Me.ccodubi.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn11.HeaderText = "Ubicación"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'colqu
        '
        Me.colqu.HeaderText = ""
        Me.colqu.Name = "colqu"
        Me.colqu.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colqu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colqu.Text = "Quitar"
        Me.colqu.UseColumnTextForButtonValue = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "S"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fila"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'colcoubi
        '
        Me.colcoubi.HeaderText = "ubi_codigo"
        Me.colcoubi.Name = "colcoubi"
        Me.colcoubi.Visible = False
        '
        'cubin
        '
        Me.cubin.HeaderText = "Ubicacion"
        Me.cubin.Name = "cubin"
        Me.cubin.ReadOnly = True
        '
        'colpall
        '
        Me.colpall.HeaderText = "Pallet"
        Me.colpall.Name = "colpall"
        Me.colpall.ReadOnly = True
        '
        'colpro
        '
        Me.colpro.HeaderText = "pro_codigo"
        Me.colpro.Name = "colpro"
        Me.colpro.ReadOnly = True
        Me.colpro.Visible = False
        '
        'col_codin
        '
        Me.col_codin.HeaderText = "Codigo"
        Me.col_codin.Name = "col_codin"
        Me.col_codin.ReadOnly = True
        '
        'colnompro
        '
        Me.colnompro.HeaderText = "Nombre Producto"
        Me.colnompro.Name = "colnompro"
        Me.colnompro.ReadOnly = True
        '
        'colcbul
        '
        Me.colcbul.HeaderText = "cod_bulto"
        Me.colcbul.Name = "colcbul"
        Me.colcbul.ReadOnly = True
        Me.colcbul.Visible = False
        '
        'codstrbul
        '
        Me.codstrbul.HeaderText = "Bulto"
        Me.codstrbul.Name = "codstrbul"
        Me.codstrbul.ReadOnly = True
        '
        'colcant
        '
        Me.colcant.HeaderText = "Canidad"
        Me.colcant.Name = "colcant"
        Me.colcant.ReadOnly = True
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = ""
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Text = "Seleccionar"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        '
        'procodubi2
        '
        Me.procodubi2.HeaderText = "ubi_codigo2"
        Me.procodubi2.Name = "procodubi2"
        Me.procodubi2.ReadOnly = True
        Me.procodubi2.Visible = False
        '
        'colubinombre2
        '
        Me.colubinombre2.HeaderText = "Ubicacion 2"
        Me.colubinombre2.Name = "colubinombre2"
        Me.colubinombre2.ReadOnly = True
        Me.colubinombre2.Visible = False
        '
        'frm_movimientos_entre_pisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 696)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_movimientos_entre_pisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de movimientos entre piso (OM)"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GrillaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GrillaOperario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.grillaDesdeRack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grillaRack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ButtonSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOM As Label
    Friend WithEvents txtValeManager As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbPersonas As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbPisoOrigen As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbBodegaOrigen As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbPisoDestino As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbBodegaDestino As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GrillaDetalle As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GrillaOperario As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents grillaRack As DataGridView
    Friend WithEvents btnAsigna As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnImprimeIdentificador As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnAprueba As ToolStripButton
    Friend WithEvents btnRechaza As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents colffr As DataGridViewTextBoxColumn
    Friend WithEvents ccfila As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colPalletOrigen As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents ccodubi As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents colqu As DataGridViewButtonColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents c_S As DataGridViewCheckBoxColumn
    Friend WithEvents cfila As DataGridViewTextBoxColumn
    Friend WithEvents c_pro_codigo As DataGridViewTextBoxColumn
    Friend WithEvents colpalletPiso As DataGridViewTextBoxColumn
    Friend WithEvents cpal As DataGridViewTextBoxColumn
    Friend WithEvents ccod As DataGridViewTextBoxColumn
    Friend WithEvents cop As DataGridViewTextBoxColumn
    Friend WithEvents cprobulto As DataGridViewTextBoxColumn
    Friend WithEvents colbultos As DataGridViewTextBoxColumn
    Friend WithEvents cco As DataGridViewTextBoxColumn
    Friend WithEvents colcan As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents cols As DataGridViewButtonColumn
    Friend WithEvents btnGuardaVale As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents grillaDesdeRack As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cmbAltura As ComboBox
    Friend WithEvents cmbZona As ComboBox
    Friend WithEvents btnBuscarDesdeRack As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents colcoubi As DataGridViewTextBoxColumn
    Friend WithEvents cubin As DataGridViewTextBoxColumn
    Friend WithEvents colpall As DataGridViewTextBoxColumn
    Friend WithEvents colpro As DataGridViewTextBoxColumn
    Friend WithEvents col_codin As DataGridViewTextBoxColumn
    Friend WithEvents colnompro As DataGridViewTextBoxColumn
    Friend WithEvents colcbul As DataGridViewTextBoxColumn
    Friend WithEvents codstrbul As DataGridViewTextBoxColumn
    Friend WithEvents colcant As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents procodubi2 As DataGridViewTextBoxColumn
    Friend WithEvents colubinombre2 As DataGridViewTextBoxColumn
End Class
