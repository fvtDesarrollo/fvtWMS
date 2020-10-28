<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listado_ordenes_pk_listado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listado_ordenes_pk_listado))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHora = New System.Windows.Forms.MaskedTextBox()
        Me.ChkHoraCita = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkFechaDespacho = New System.Windows.Forms.CheckBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.txtFechaDespachoHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaDespachoDesde = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaOCDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaOCHasta = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.col_num_asig = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnum_asig_string = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pk_asociado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(1255, 4)
        Me.Panel4.TabIndex = 18
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonNueva, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ButtonExportar, Me.ToolStripSeparator3, Me.ButtonSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1255, 25)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ButtonNueva
        '
        Me.ButtonNueva.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNueva.Image = CType(resources.GetObject("ButtonNueva.Image"), System.Drawing.Image)
        Me.ButtonNueva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonNueva.Name = "ButtonNueva"
        Me.ButtonNueva.Size = New System.Drawing.Size(143, 22)
        Me.ButtonNueva.Text = "NUEVO CONSOLIDADO"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 4)
        Me.Panel1.TabIndex = 20
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
        Me.Panel2.Size = New System.Drawing.Size(1255, 23)
        Me.Panel2.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTADO DE ORDENES DE PICKEO"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1255, 98)
        Me.Panel3.TabIndex = 47
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtHora)
        Me.GroupBox2.Controls.Add(Me.ChkHoraCita)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.chkFechaDespacho)
        Me.GroupBox2.Controls.Add(Me.cmbCliente)
        Me.GroupBox2.Controls.Add(Me.txtFechaDespachoHasta)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtFechaDespachoDesde)
        Me.GroupBox2.Location = New System.Drawing.Point(415, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 83)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro por datos del Piking"
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.White
        Me.txtHora.Location = New System.Drawing.Point(448, 17)
        Me.txtHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHora.Mask = "00:00"
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(82, 22)
        Me.txtHora.TabIndex = 52
        Me.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHora.ValidatingType = GetType(Date)
        '
        'ChkHoraCita
        '
        Me.ChkHoraCita.AutoSize = True
        Me.ChkHoraCita.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHoraCita.Location = New System.Drawing.Point(355, 20)
        Me.ChkHoraCita.Name = "ChkHoraCita"
        Me.ChkHoraCita.Size = New System.Drawing.Size(74, 17)
        Me.ChkHoraCita.TabIndex = 51
        Me.ChkHoraCita.Text = "Hora Cita"
        Me.ChkHoraCita.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(348, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Cliente"
        '
        'chkFechaDespacho
        '
        Me.chkFechaDespacho.AutoSize = True
        Me.chkFechaDespacho.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFechaDespacho.Location = New System.Drawing.Point(22, 44)
        Me.chkFechaDespacho.Name = "chkFechaDespacho"
        Me.chkFechaDespacho.Size = New System.Drawing.Size(84, 17)
        Me.chkFechaDespacho.TabIndex = 49
        Me.chkFechaDespacho.Text = "Fecha Desp"
        Me.chkFechaDespacho.UseVisualStyleBackColor = True
        '
        'cmbCliente
        '
        Me.cmbCliente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(117, 18)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(221, 21)
        Me.cmbCliente.TabIndex = 41
        '
        'txtFechaDespachoHasta
        '
        Me.txtFechaDespachoHasta.Enabled = False
        Me.txtFechaDespachoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaDespachoHasta.Location = New System.Drawing.Point(255, 41)
        Me.txtFechaDespachoHasta.Name = "txtFechaDespachoHasta"
        Me.txtFechaDespachoHasta.Size = New System.Drawing.Size(82, 22)
        Me.txtFechaDespachoHasta.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(202, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 22)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Hasta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 22)
        Me.Label5.TabIndex = 44
        '
        'txtFechaDespachoDesde
        '
        Me.txtFechaDespachoDesde.Enabled = False
        Me.txtFechaDespachoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaDespachoDesde.Location = New System.Drawing.Point(117, 41)
        Me.txtFechaDespachoDesde.Name = "txtFechaDespachoDesde"
        Me.txtFechaDespachoDesde.Size = New System.Drawing.Size(82, 22)
        Me.txtFechaDespachoDesde.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.chkFecha)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpFechaOCDesde)
        Me.GroupBox1.Controls.Add(Me.dtpFechaOCHasta)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 83)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros para Ordenes de Consolidado"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(203, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 22)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Hasta"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Estado"
        '
        'cmbEstado
        '
        Me.cmbEstado.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(118, 18)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(266, 21)
        Me.cmbEstado.TabIndex = 35
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFecha.Location = New System.Drawing.Point(23, 44)
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
        Me.Label6.Location = New System.Drawing.Point(19, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 22)
        Me.Label6.TabIndex = 45
        '
        'dtpFechaOCDesde
        '
        Me.dtpFechaOCDesde.Enabled = False
        Me.dtpFechaOCDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaOCDesde.Location = New System.Drawing.Point(118, 41)
        Me.dtpFechaOCDesde.Name = "dtpFechaOCDesde"
        Me.dtpFechaOCDesde.Size = New System.Drawing.Size(82, 22)
        Me.dtpFechaOCDesde.TabIndex = 37
        '
        'dtpFechaOCHasta
        '
        Me.dtpFechaOCHasta.Enabled = False
        Me.dtpFechaOCHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaOCHasta.Location = New System.Drawing.Point(302, 41)
        Me.dtpFechaOCHasta.Name = "dtpFechaOCHasta"
        Me.dtpFechaOCHasta.Size = New System.Drawing.Size(82, 22)
        Me.dtpFechaOCHasta.TabIndex = 36
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTotal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1255, 22)
        Me.StatusStrip1.TabIndex = 48
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
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num_asig, Me.colnum_asig_string, Me.col_fecha, Me.codEstado, Me.col_nom_estado, Me.col_pk_asociado, Me.col_responsable, Me.col_ver})
        Me.Grilla.EnableHeadersVisualStyles = False
        Me.Grilla.GridColor = System.Drawing.SystemColors.HotTrack
        Me.Grilla.Location = New System.Drawing.Point(12, 160)
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
        Me.Grilla.Size = New System.Drawing.Size(1225, 477)
        Me.Grilla.TabIndex = 49
        '
        'col_num_asig
        '
        Me.col_num_asig.HeaderText = "asicod"
        Me.col_num_asig.Name = "col_num_asig"
        Me.col_num_asig.ReadOnly = True
        Me.col_num_asig.Visible = False
        '
        'colnum_asig_string
        '
        Me.colnum_asig_string.HeaderText = "N°Asignación"
        Me.colnum_asig_string.Name = "colnum_asig_string"
        Me.colnum_asig_string.ReadOnly = True
        '
        'col_fecha
        '
        Me.col_fecha.HeaderText = "Fecha"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.ReadOnly = True
        '
        'codEstado
        '
        Me.codEstado.HeaderText = "col_estado"
        Me.codEstado.Name = "codEstado"
        Me.codEstado.ReadOnly = True
        Me.codEstado.Visible = False
        '
        'col_nom_estado
        '
        Me.col_nom_estado.HeaderText = "Estado"
        Me.col_nom_estado.Name = "col_nom_estado"
        Me.col_nom_estado.ReadOnly = True
        '
        'col_pk_asociado
        '
        Me.col_pk_asociado.HeaderText = "PK Asociados"
        Me.col_pk_asociado.Name = "col_pk_asociado"
        Me.col_pk_asociado.ReadOnly = True
        '
        'col_responsable
        '
        Me.col_responsable.HeaderText = "Responsables de ejecución"
        Me.col_responsable.Name = "col_responsable"
        Me.col_responsable.ReadOnly = True
        '
        'col_ver
        '
        Me.col_ver.HeaderText = ""
        Me.col_ver.Name = "col_ver"
        Me.col_ver.ReadOnly = True
        Me.col_ver.Text = "Abrir"
        Me.col_ver.UseColumnTextForButtonValue = True
        '
        'frm_listado_ordenes_pk_listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 662)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_listado_ordenes_pk_listado"
        Me.Text = "LISTADO DE ORDENES DE PICKEO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents dtpFechaOCDesde As DateTimePicker
    Friend WithEvents dtpFechaOCHasta As DateTimePicker
    Friend WithEvents chkFecha As CheckBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblTotal As ToolStripStatusLabel
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents col_num_asig As DataGridViewTextBoxColumn
    Friend WithEvents colnum_asig_string As DataGridViewTextBoxColumn
    Friend WithEvents col_fecha As DataGridViewTextBoxColumn
    Friend WithEvents codEstado As DataGridViewTextBoxColumn
    Friend WithEvents col_nom_estado As DataGridViewTextBoxColumn
    Friend WithEvents col_pk_asociado As DataGridViewTextBoxColumn
    Friend WithEvents col_responsable As DataGridViewTextBoxColumn
    Friend WithEvents col_ver As DataGridViewButtonColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFechaDespachoDesde As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents chkFechaDespacho As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFechaDespachoHasta As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChkHoraCita As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHora As MaskedTextBox
End Class
