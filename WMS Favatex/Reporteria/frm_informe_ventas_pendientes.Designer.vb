<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_informe_ventas_pendientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_informe_ventas_pendientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnGustar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaOCDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaOCHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optUnidades = New System.Windows.Forms.RadioButton()
        Me.optBultos = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optTipoVStock = New System.Windows.Forms.RadioButton()
        Me.optTipoVV = New System.Windows.Forms.RadioButton()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GrillaEstados = New System.Windows.Forms.DataGridView()
        Me.colcodEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCanti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVerDet = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GrillaDetalle = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colclnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnpro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cocanreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcaenc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colfecemi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colfeccom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcodes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colesta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnumpk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GrillaEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.GrillaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(837, 4)
        Me.Panel4.TabIndex = 12
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ButtonSalir, Me.ToolStripSeparator8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(837, 25)
        Me.ToolStrip1.TabIndex = 42
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 4)
        Me.Panel1.TabIndex = 43
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
        Me.Panel2.Size = New System.Drawing.Size(837, 23)
        Me.Panel2.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INFORME DE VENTAS PENDIENTES"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 493)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(837, 22)
        Me.StatusStrip1.TabIndex = 49
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(837, 73)
        Me.Panel3.TabIndex = 50
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnGustar)
        Me.GroupBox4.Location = New System.Drawing.Point(462, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(368, 64)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'BtnGustar
        '
        Me.BtnGustar.Location = New System.Drawing.Point(6, 15)
        Me.BtnGustar.Name = "BtnGustar"
        Me.BtnGustar.Size = New System.Drawing.Size(120, 24)
        Me.BtnGustar.TabIndex = 15
        Me.BtnGustar.Text = "Generar Informe"
        Me.BtnGustar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpFechaOCDesde)
        Me.GroupBox3.Controls.Add(Me.dtpFechaOCHasta)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(257, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 66)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Periodo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fecha desde"
        '
        'dtpFechaOCDesde
        '
        Me.dtpFechaOCDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaOCDesde.Location = New System.Drawing.Point(97, 13)
        Me.dtpFechaOCDesde.Name = "dtpFechaOCDesde"
        Me.dtpFechaOCDesde.Size = New System.Drawing.Size(82, 22)
        Me.dtpFechaOCDesde.TabIndex = 11
        '
        'dtpFechaOCHasta
        '
        Me.dtpFechaOCHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaOCHasta.Location = New System.Drawing.Point(97, 39)
        Me.dtpFechaOCHasta.Name = "dtpFechaOCHasta"
        Me.dtpFechaOCHasta.Size = New System.Drawing.Size(82, 22)
        Me.dtpFechaOCHasta.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Hasta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optUnidades)
        Me.GroupBox2.Controls.Add(Me.optBultos)
        Me.GroupBox2.Location = New System.Drawing.Point(151, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(101, 66)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ver en"
        '
        'optUnidades
        '
        Me.optUnidades.AutoSize = True
        Me.optUnidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optUnidades.Location = New System.Drawing.Point(20, 19)
        Me.optUnidades.Name = "optUnidades"
        Me.optUnidades.Size = New System.Drawing.Size(74, 17)
        Me.optUnidades.TabIndex = 16
        Me.optUnidades.Text = "Unidades"
        Me.optUnidades.UseVisualStyleBackColor = True
        '
        'optBultos
        '
        Me.optBultos.AutoSize = True
        Me.optBultos.Checked = True
        Me.optBultos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optBultos.Location = New System.Drawing.Point(20, 39)
        Me.optBultos.Name = "optBultos"
        Me.optBultos.Size = New System.Drawing.Size(57, 17)
        Me.optBultos.TabIndex = 17
        Me.optBultos.TabStop = True
        Me.optBultos.Text = "Bultos"
        Me.optBultos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optTipoVStock)
        Me.GroupBox1.Controls.Add(Me.optTipoVV)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 66)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de venta"
        '
        'optTipoVStock
        '
        Me.optTipoVStock.AutoSize = True
        Me.optTipoVStock.Location = New System.Drawing.Point(28, 39)
        Me.optTipoVStock.Name = "optTipoVStock"
        Me.optTipoVStock.Size = New System.Drawing.Size(53, 17)
        Me.optTipoVStock.TabIndex = 1
        Me.optTipoVStock.Text = "Stock"
        Me.optTipoVStock.UseVisualStyleBackColor = True
        '
        'optTipoVV
        '
        Me.optTipoVV.AutoSize = True
        Me.optTipoVV.Checked = True
        Me.optTipoVV.Location = New System.Drawing.Point(28, 19)
        Me.optTipoVV.Name = "optTipoVV"
        Me.optTipoVV.Size = New System.Drawing.Size(101, 17)
        Me.optTipoVV.TabIndex = 0
        Me.optTipoVV.TabStop = True
        Me.optTipoVV.Text = "Venta en verde"
        Me.optTipoVV.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.AllowUserToAddRows = False
        Me.Grilla.AllowUserToDeleteRows = False
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
        Me.Grilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla.EnableHeadersVisualStyles = False
        Me.Grilla.GridColor = System.Drawing.SystemColors.HotTrack
        Me.Grilla.Location = New System.Drawing.Point(3, 3)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.Grilla.RowHeadersVisible = False
        Me.Grilla.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.Grilla.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.Grilla.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.Grilla.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Grilla.Size = New System.Drawing.Size(823, 332)
        Me.Grilla.TabIndex = 51
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(837, 364)
        Me.TabControl1.TabIndex = 53
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Grilla)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(829, 338)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resumen de unidades por días"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GrillaEstados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(829, 338)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cantidad de unidades por etapas (estados)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GrillaEstados
        '
        Me.GrillaEstados.AllowUserToAddRows = False
        Me.GrillaEstados.AllowUserToDeleteRows = False
        Me.GrillaEstados.BackgroundColor = System.Drawing.Color.White
        Me.GrillaEstados.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaEstados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GrillaEstados.ColumnHeadersHeight = 25
        Me.GrillaEstados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcodEstado, Me.colEst, Me.colCanti, Me.colVerDet})
        Me.GrillaEstados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaEstados.EnableHeadersVisualStyles = False
        Me.GrillaEstados.GridColor = System.Drawing.SystemColors.HotTrack
        Me.GrillaEstados.Location = New System.Drawing.Point(3, 3)
        Me.GrillaEstados.Name = "GrillaEstados"
        Me.GrillaEstados.ReadOnly = True
        Me.GrillaEstados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.GrillaEstados.RowHeadersVisible = False
        Me.GrillaEstados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.GrillaEstados.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrillaEstados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.GrillaEstados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.GrillaEstados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GrillaEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaEstados.Size = New System.Drawing.Size(823, 332)
        Me.GrillaEstados.TabIndex = 52
        '
        'colcodEstado
        '
        Me.colcodEstado.HeaderText = "cod_estado"
        Me.colcodEstado.Name = "colcodEstado"
        Me.colcodEstado.ReadOnly = True
        Me.colcodEstado.Visible = False
        '
        'colEst
        '
        Me.colEst.HeaderText = "Estado"
        Me.colEst.Name = "colEst"
        Me.colEst.ReadOnly = True
        '
        'colCanti
        '
        Me.colCanti.HeaderText = "Cantidad"
        Me.colCanti.Name = "colCanti"
        Me.colCanti.ReadOnly = True
        '
        'colVerDet
        '
        Me.colVerDet.HeaderText = ""
        Me.colVerDet.Name = "colVerDet"
        Me.colVerDet.ReadOnly = True
        Me.colVerDet.Text = "Ver detalle"
        Me.colVerDet.UseColumnTextForButtonValue = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GrillaDetalle)
        Me.TabPage3.Controls.Add(Me.Panel6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(829, 338)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Detalle de ordenes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GrillaDetalle
        '
        Me.GrillaDetalle.AllowUserToAddRows = False
        Me.GrillaDetalle.AllowUserToDeleteRows = False
        Me.GrillaDetalle.BackgroundColor = System.Drawing.Color.White
        Me.GrillaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GrillaDetalle.ColumnHeadersHeight = 25
        Me.GrillaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.colclnom, Me.colOC, Me.colcint, Me.colnpro, Me.cocanreq, Me.colcaenc, Me.colpr, Me.colfecemi, Me.colfeccom, Me.colcodes, Me.colesta, Me.colnumpk})
        Me.GrillaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrillaDetalle.EnableHeadersVisualStyles = False
        Me.GrillaDetalle.GridColor = System.Drawing.SystemColors.HotTrack
        Me.GrillaDetalle.Location = New System.Drawing.Point(3, 34)
        Me.GrillaDetalle.Name = "GrillaDetalle"
        Me.GrillaDetalle.ReadOnly = True
        Me.GrillaDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.GrillaDetalle.RowHeadersVisible = False
        Me.GrillaDetalle.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.GrillaDetalle.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrillaDetalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.GrillaDetalle.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.GrillaDetalle.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GrillaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GrillaDetalle.Size = New System.Drawing.Size(823, 301)
        Me.GrillaDetalle.TabIndex = 53
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblDescripcion)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(823, 31)
        Me.Panel6.TabIndex = 54
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(10, 9)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(11, 13)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "-"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.TabControl1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 129)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(837, 364)
        Me.Panel5.TabIndex = 54
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "car_codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'colclnom
        '
        Me.colclnom.HeaderText = "Nombre Cliente"
        Me.colclnom.Name = "colclnom"
        Me.colclnom.ReadOnly = True
        '
        'colOC
        '
        Me.colOC.HeaderText = "Orden Compra"
        Me.colOC.Name = "colOC"
        Me.colOC.ReadOnly = True
        '
        'colcint
        '
        Me.colcint.HeaderText = "Codigo Interno"
        Me.colcint.Name = "colcint"
        Me.colcint.ReadOnly = True
        '
        'colnpro
        '
        Me.colnpro.HeaderText = "Nombre Producto"
        Me.colnpro.Name = "colnpro"
        Me.colnpro.ReadOnly = True
        '
        'cocanreq
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.cocanreq.DefaultCellStyle = DataGridViewCellStyle4
        Me.cocanreq.HeaderText = "Cantidad Requerida"
        Me.cocanreq.Name = "cocanreq"
        Me.cocanreq.ReadOnly = True
        '
        'colcaenc
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.colcaenc.DefaultCellStyle = DataGridViewCellStyle5
        Me.colcaenc.HeaderText = "Cantidad Encontrada"
        Me.colcaenc.Name = "colcaenc"
        Me.colcaenc.ReadOnly = True
        '
        'colpr
        '
        Me.colpr.HeaderText = "Precio"
        Me.colpr.Name = "colpr"
        Me.colpr.ReadOnly = True
        '
        'colfecemi
        '
        Me.colfecemi.HeaderText = "Fecha Emisión"
        Me.colfecemi.Name = "colfecemi"
        Me.colfecemi.ReadOnly = True
        '
        'colfeccom
        '
        Me.colfeccom.HeaderText = "Fecha Compromiso"
        Me.colfeccom.Name = "colfeccom"
        Me.colfeccom.ReadOnly = True
        '
        'colcodes
        '
        Me.colcodes.HeaderText = "epc_codigo"
        Me.colcodes.Name = "colcodes"
        Me.colcodes.ReadOnly = True
        Me.colcodes.Visible = False
        '
        'colesta
        '
        Me.colesta.HeaderText = "Estado"
        Me.colesta.Name = "colesta"
        Me.colesta.ReadOnly = True
        '
        'colnumpk
        '
        Me.colnumpk.HeaderText = "Nº PK"
        Me.colnumpk.Name = "colnumpk"
        Me.colnumpk.ReadOnly = True
        '
        'frm_informe_ventas_pendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 515)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_informe_ventas_pendientes"
        Me.Text = "Informe ventas pendientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GrillaEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GrillaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ButtonSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnGustar As Button
    Friend WithEvents dtpFechaOCHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaOCDesde As DateTimePicker
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GrillaEstados As DataGridView
    Friend WithEvents colcodEstado As DataGridViewTextBoxColumn
    Friend WithEvents colEst As DataGridViewTextBoxColumn
    Friend WithEvents colCanti As DataGridViewTextBoxColumn
    Friend WithEvents colVerDet As DataGridViewButtonColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GrillaDetalle As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents optBultos As RadioButton
    Friend WithEvents optUnidades As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optTipoVStock As RadioButton
    Friend WithEvents optTipoVV As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colclnom As DataGridViewTextBoxColumn
    Friend WithEvents colOC As DataGridViewTextBoxColumn
    Friend WithEvents colcint As DataGridViewTextBoxColumn
    Friend WithEvents colnpro As DataGridViewTextBoxColumn
    Friend WithEvents cocanreq As DataGridViewTextBoxColumn
    Friend WithEvents colcaenc As DataGridViewTextBoxColumn
    Friend WithEvents colpr As DataGridViewTextBoxColumn
    Friend WithEvents colfecemi As DataGridViewTextBoxColumn
    Friend WithEvents colfeccom As DataGridViewTextBoxColumn
    Friend WithEvents colcodes As DataGridViewTextBoxColumn
    Friend WithEvents colesta As DataGridViewTextBoxColumn
    Friend WithEvents colnumpk As DataGridViewTextBoxColumn
End Class
