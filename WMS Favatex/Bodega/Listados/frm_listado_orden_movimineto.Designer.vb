<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listado_orden_movimineto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listado_orden_movimineto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ButtonNueva = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPisoDestino = New System.Windows.Forms.ComboBox()
        Me.cmbBodegaDestino = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbPisoOrigen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbBodegaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaOCDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaOCHasta = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.como_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.como_codstring = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colfec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codidResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcodusu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcodest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodPio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcBodDes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBodDest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcPisoDes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUbicacionDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSelecc = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1281, 4)
        Me.Panel4.TabIndex = 19
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonNueva, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ButtonExportar, Me.ToolStripSeparator3, Me.ButtonSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1281, 25)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ButtonNueva
        '
        Me.ButtonNueva.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNueva.Image = CType(resources.GetObject("ButtonNueva.Image"), System.Drawing.Image)
        Me.ButtonNueva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonNueva.Name = "ButtonNueva"
        Me.ButtonNueva.Size = New System.Drawing.Size(80, 22)
        Me.ButtonNueva.Text = "Nueva OM"
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
        Me.ToolStripButton1.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripButton1.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonExportar
        '
        Me.ButtonExportar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExportar.Image = CType(resources.GetObject("ButtonExportar.Image"), System.Drawing.Image)
        Me.ButtonExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonExportar.Name = "ButtonExportar"
        Me.ButtonExportar.Size = New System.Drawing.Size(124, 22)
        Me.ButtonExportar.Text = "EXPORTAR A EXCEL"
        Me.ButtonExportar.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator3.Visible = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.ForeColor = System.Drawing.Color.Black
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(49, 22)
        Me.ButtonSalir.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1281, 4)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1281, 23)
        Me.Panel2.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listado de ordenes de movimiento"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1281, 83)
        Me.Panel3.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbPisoDestino)
        Me.GroupBox1.Controls.Add(Me.cmbBodegaDestino)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.cmbPisoOrigen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbBodegaOrigen)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chkFecha)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpFechaOCDesde)
        Me.GroupBox1.Controls.Add(Me.dtpFechaOCHasta)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1264, 73)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por"
        '
        'cmbPisoDestino
        '
        Me.cmbPisoDestino.BackColor = System.Drawing.Color.White
        Me.cmbPisoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPisoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPisoDestino.FormattingEnabled = True
        Me.cmbPisoDestino.Location = New System.Drawing.Point(792, 45)
        Me.cmbPisoDestino.Name = "cmbPisoDestino"
        Me.cmbPisoDestino.Size = New System.Drawing.Size(213, 21)
        Me.cmbPisoDestino.TabIndex = 82
        '
        'cmbBodegaDestino
        '
        Me.cmbBodegaDestino.BackColor = System.Drawing.Color.White
        Me.cmbBodegaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegaDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBodegaDestino.FormattingEnabled = True
        Me.cmbBodegaDestino.Location = New System.Drawing.Point(792, 19)
        Me.cmbBodegaDestino.Name = "cmbBodegaDestino"
        Me.cmbBodegaDestino.Size = New System.Drawing.Size(213, 21)
        Me.cmbBodegaDestino.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(679, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 22)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Piso Destino"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(679, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 22)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Bodega Destino"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEstado
        '
        Me.cmbEstado.BackColor = System.Drawing.Color.White
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(120, 19)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(217, 21)
        Me.cmbEstado.TabIndex = 78
        '
        'cmbPisoOrigen
        '
        Me.cmbPisoOrigen.BackColor = System.Drawing.Color.White
        Me.cmbPisoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPisoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPisoOrigen.FormattingEnabled = True
        Me.cmbPisoOrigen.Location = New System.Drawing.Point(460, 44)
        Me.cmbPisoOrigen.Name = "cmbPisoOrigen"
        Me.cmbPisoOrigen.Size = New System.Drawing.Size(213, 21)
        Me.cmbPisoOrigen.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(349, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 22)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Piso Origen"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbBodegaOrigen
        '
        Me.cmbBodegaOrigen.BackColor = System.Drawing.Color.White
        Me.cmbBodegaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegaOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBodegaOrigen.FormattingEnabled = True
        Me.cmbBodegaOrigen.Location = New System.Drawing.Point(460, 19)
        Me.cmbBodegaOrigen.Name = "cmbBodegaOrigen"
        Me.cmbBodegaOrigen.Size = New System.Drawing.Size(213, 21)
        Me.cmbBodegaOrigen.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(349, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 22)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Bodega Origen"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(203, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 22)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Hasta"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 22)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Estado"
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFecha.Location = New System.Drawing.Point(23, 47)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(90, 17)
        Me.chkFecha.TabIndex = 38
        Me.chkFecha.Text = "Fecha Desde"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 22)
        Me.Label6.TabIndex = 45
        '
        'dtpFechaOCDesde
        '
        Me.dtpFechaOCDesde.Enabled = False
        Me.dtpFechaOCDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaOCDesde.Location = New System.Drawing.Point(118, 44)
        Me.dtpFechaOCDesde.Name = "dtpFechaOCDesde"
        Me.dtpFechaOCDesde.Size = New System.Drawing.Size(82, 22)
        Me.dtpFechaOCDesde.TabIndex = 37
        '
        'dtpFechaOCHasta
        '
        Me.dtpFechaOCHasta.Enabled = False
        Me.dtpFechaOCHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaOCHasta.Location = New System.Drawing.Point(255, 44)
        Me.dtpFechaOCHasta.Name = "dtpFechaOCHasta"
        Me.dtpFechaOCHasta.Size = New System.Drawing.Size(82, 22)
        Me.dtpFechaOCHasta.TabIndex = 36
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTotal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 611)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1281, 22)
        Me.StatusStrip1.TabIndex = 49
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
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
        Me.Grilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grilla.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.como_codigo, Me.como_codstring, Me.colfec, Me.codidResponsable, Me.colcodusu, Me.colcodest, Me.colest, Me.colbodo, Me.colbo, Me.colCodPio, Me.colpori, Me.colcBodDes, Me.colBodDest, Me.colcPisoDes, Me.colUbicacionDestino, Me.colVale, Me.colSelecc})
        Me.Grilla.EnableHeadersVisualStyles = False
        Me.Grilla.Location = New System.Drawing.Point(7, 145)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Grilla.RowHeadersVisible = False
        Me.Grilla.Size = New System.Drawing.Size(1264, 463)
        Me.Grilla.TabIndex = 81
        '
        'como_codigo
        '
        Me.como_codigo.HeaderText = "omo_codigo"
        Me.como_codigo.Name = "como_codigo"
        Me.como_codigo.ReadOnly = True
        Me.como_codigo.Visible = False
        '
        'como_codstring
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.como_codstring.DefaultCellStyle = DataGridViewCellStyle1
        Me.como_codstring.HeaderText = "Cod. OM"
        Me.como_codstring.Name = "como_codstring"
        '
        'colfec
        '
        Me.colfec.HeaderText = "Fecha"
        Me.colfec.Name = "colfec"
        '
        'codidResponsable
        '
        Me.codidResponsable.HeaderText = "codResponsable"
        Me.codidResponsable.Name = "codidResponsable"
        Me.codidResponsable.Visible = False
        '
        'colcodusu
        '
        Me.colcodusu.HeaderText = "Responsable"
        Me.colcodusu.Name = "colcodusu"
        '
        'colcodest
        '
        Me.colcodest.HeaderText = "eom_estado"
        Me.colcodest.Name = "colcodest"
        Me.colcodest.Visible = False
        '
        'colest
        '
        Me.colest.HeaderText = "Estado"
        Me.colest.Name = "colest"
        '
        'colbodo
        '
        Me.colbodo.HeaderText = "codBodegaOrigen"
        Me.colbodo.Name = "colbodo"
        Me.colbodo.Visible = False
        '
        'colbo
        '
        Me.colbo.HeaderText = "Bodega Origen"
        Me.colbo.Name = "colbo"
        '
        'colCodPio
        '
        Me.colCodPio.HeaderText = "codUbicacionOrigen"
        Me.colCodPio.Name = "colCodPio"
        Me.colCodPio.Visible = False
        '
        'colpori
        '
        Me.colpori.HeaderText = "Ubicación Origen"
        Me.colpori.Name = "colpori"
        '
        'colcBodDes
        '
        Me.colcBodDes.HeaderText = "CodBodegaDestino"
        Me.colcBodDes.Name = "colcBodDes"
        Me.colcBodDes.Visible = False
        '
        'colBodDest
        '
        Me.colBodDest.HeaderText = "Bodega Destino"
        Me.colBodDest.Name = "colBodDest"
        '
        'colcPisoDes
        '
        Me.colcPisoDes.HeaderText = "codUbicacionDestino"
        Me.colcPisoDes.Name = "colcPisoDes"
        Me.colcPisoDes.Visible = False
        '
        'colUbicacionDestino
        '
        Me.colUbicacionDestino.HeaderText = "Ubicación Destino"
        Me.colUbicacionDestino.Name = "colUbicacionDestino"
        '
        'colVale
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colVale.DefaultCellStyle = DataGridViewCellStyle2
        Me.colVale.HeaderText = "Vale Manager"
        Me.colVale.Name = "colVale"
        '
        'colSelecc
        '
        Me.colSelecc.HeaderText = ""
        Me.colSelecc.Name = "colSelecc"
        Me.colSelecc.Text = "Seleccionar"
        Me.colSelecc.UseColumnTextForButtonValue = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Bisque
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(1011, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 22)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "OM Aprobadas sin Vale Manager asociado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(1011, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(247, 22)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "OM Aprobadas con Vale Manager asociado"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_listado_orden_movimineto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 633)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_listado_orden_movimineto"
        Me.Text = "Listado de ordenes de movimiento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ButtonNueva As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ButtonExportar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ButtonSalir As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkFecha As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFechaOCDesde As DateTimePicker
    Friend WithEvents dtpFechaOCHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbPisoOrigen As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbBodegaOrigen As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbBodegaDestino As ComboBox
    Friend WithEvents cmbPisoDestino As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblTotal As ToolStripStatusLabel
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents como_codigo As DataGridViewTextBoxColumn
    Friend WithEvents como_codstring As DataGridViewTextBoxColumn
    Friend WithEvents colfec As DataGridViewTextBoxColumn
    Friend WithEvents codidResponsable As DataGridViewTextBoxColumn
    Friend WithEvents colcodusu As DataGridViewTextBoxColumn
    Friend WithEvents colcodest As DataGridViewTextBoxColumn
    Friend WithEvents colest As DataGridViewTextBoxColumn
    Friend WithEvents colbodo As DataGridViewTextBoxColumn
    Friend WithEvents colbo As DataGridViewTextBoxColumn
    Friend WithEvents colCodPio As DataGridViewTextBoxColumn
    Friend WithEvents colpori As DataGridViewTextBoxColumn
    Friend WithEvents colcBodDes As DataGridViewTextBoxColumn
    Friend WithEvents colBodDest As DataGridViewTextBoxColumn
    Friend WithEvents colcPisoDes As DataGridViewTextBoxColumn
    Friend WithEvents colUbicacionDestino As DataGridViewTextBoxColumn
    Friend WithEvents colVale As DataGridViewTextBoxColumn
    Friend WithEvents colSelecc As DataGridViewButtonColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
End Class
