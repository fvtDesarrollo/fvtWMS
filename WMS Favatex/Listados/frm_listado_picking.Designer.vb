﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listado_picking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listado_picking))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grupoExportar = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnSelecciona = New System.Windows.Forms.Button()
        Me.dtpFechaDespacho = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_numero_picking = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipoEntrega = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalBultos = New System.Windows.Forms.TextBox()
        Me.lblTotalBultos = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.chkProOC = New System.Windows.Forms.CheckBox()
        Me.chkIngreso = New System.Windows.Forms.CheckBox()
        Me.cmbEstaddo = New System.Windows.Forms.ComboBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpCompromisoHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpCompromisoDesde = New System.Windows.Forms.DateTimePicker()
        Me.chkCompromiso = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpIngresoHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpIngresoDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.COL_PIC_CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_COD_PICKING = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fec_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_embarque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_HORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_CAR_CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_CAL_NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_EPC_CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_EPC_NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_CANT_UNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_CANT_BULTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_TOTAL_BULTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLUE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.grilla_detallada = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fec_Emb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpi_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.epc_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_codigointerno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pic_num_bultos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_bulto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pic_ocnumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pic_fechaoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.con_codigounico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pic_filadevuelta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existentes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tot_bultoext = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cant_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_bulto_despachado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total_embarcado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total_bulto_embarcado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_observacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grillaExportar = New System.Windows.Forms.DataGridView()
        Me.cguia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coloc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COPP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.grupoExportar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.grilla_detallada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grillaExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ButtonExportar, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1290, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.ButtonExportar.ForeColor = System.Drawing.Color.Black
        Me.ButtonExportar.Image = CType(resources.GetObject("ButtonExportar.Image"), System.Drawing.Image)
        Me.ButtonExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonExportar.Name = "ButtonExportar"
        Me.ButtonExportar.Size = New System.Drawing.Size(124, 22)
        Me.ButtonExportar.Text = "EXPORTAR A EXCEL"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripButton2.Text = "SALIR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.grupoExportar)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1290, 114)
        Me.Panel2.TabIndex = 2
        '
        'grupoExportar
        '
        Me.grupoExportar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grupoExportar.BackColor = System.Drawing.Color.LightYellow
        Me.grupoExportar.Controls.Add(Me.btnExportar)
        Me.grupoExportar.Controls.Add(Me.btnSelecciona)
        Me.grupoExportar.Controls.Add(Me.dtpFechaDespacho)
        Me.grupoExportar.Controls.Add(Me.Label8)
        Me.grupoExportar.Enabled = False
        Me.grupoExportar.Location = New System.Drawing.Point(995, 1)
        Me.grupoExportar.Name = "grupoExportar"
        Me.grupoExportar.Size = New System.Drawing.Size(287, 108)
        Me.grupoExportar.TabIndex = 1
        Me.grupoExportar.TabStop = False
        Me.grupoExportar.Text = "Generar Archivo de despacho"
        '
        'btnExportar
        '
        Me.btnExportar.ForeColor = System.Drawing.Color.Black
        Me.btnExportar.Location = New System.Drawing.Point(9, 74)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(230, 24)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = "Exporta a Archivo"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnSelecciona
        '
        Me.btnSelecciona.ForeColor = System.Drawing.Color.Black
        Me.btnSelecciona.Location = New System.Drawing.Point(9, 48)
        Me.btnSelecciona.Name = "btnSelecciona"
        Me.btnSelecciona.Size = New System.Drawing.Size(230, 24)
        Me.btnSelecciona.TabIndex = 5
        Me.btnSelecciona.Text = "Selecciona Registros"
        Me.btnSelecciona.UseVisualStyleBackColor = True
        '
        'dtpFechaDespacho
        '
        Me.dtpFechaDespacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDespacho.Location = New System.Drawing.Point(157, 22)
        Me.dtpFechaDespacho.Name = "dtpFechaDespacho"
        Me.dtpFechaDespacho.Size = New System.Drawing.Size(82, 22)
        Me.dtpFechaDespacho.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Seleccione fecha despacho"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txt_numero_picking)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbTipoEntrega)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTotalBultos)
        Me.GroupBox1.Controls.Add(Me.lblTotalBultos)
        Me.GroupBox1.Controls.Add(Me.txtOrden)
        Me.GroupBox1.Controls.Add(Me.chkProOC)
        Me.GroupBox1.Controls.Add(Me.chkIngreso)
        Me.GroupBox1.Controls.Add(Me.cmbEstaddo)
        Me.GroupBox1.Controls.Add(Me.cmbCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpCompromisoHasta)
        Me.GroupBox1.Controls.Add(Me.dtpCompromisoDesde)
        Me.GroupBox1.Controls.Add(Me.chkCompromiso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpIngresoHasta)
        Me.GroupBox1.Controls.Add(Me.dtpIngresoDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros de busqueda"
        '
        'txt_numero_picking
        '
        Me.txt_numero_picking.Location = New System.Drawing.Point(500, 75)
        Me.txt_numero_picking.Name = "txt_numero_picking"
        Me.txt_numero_picking.Size = New System.Drawing.Size(82, 22)
        Me.txt_numero_picking.TabIndex = 25
        Me.txt_numero_picking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(346, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Numero Picking "
        '
        'cmbTipoEntrega
        '
        Me.cmbTipoEntrega.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrega.FormattingEnabled = True
        Me.cmbTipoEntrega.Location = New System.Drawing.Point(113, 76)
        Me.cmbTipoEntrega.Name = "cmbTipoEntrega"
        Me.cmbTipoEntrega.Size = New System.Drawing.Size(209, 21)
        Me.cmbTipoEntrega.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 27)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Seleccione tipo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entrega" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalBultos
        '
        Me.txtTotalBultos.Enabled = False
        Me.txtTotalBultos.Location = New System.Drawing.Point(849, 49)
        Me.txtTotalBultos.Name = "txtTotalBultos"
        Me.txtTotalBultos.Size = New System.Drawing.Size(115, 22)
        Me.txtTotalBultos.TabIndex = 16
        Me.txtTotalBultos.Text = "0"
        Me.txtTotalBultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalBultos.Visible = False
        '
        'lblTotalBultos
        '
        Me.lblTotalBultos.AutoSize = True
        Me.lblTotalBultos.Location = New System.Drawing.Point(760, 52)
        Me.lblTotalBultos.Name = "lblTotalBultos"
        Me.lblTotalBultos.Size = New System.Drawing.Size(84, 13)
        Me.lblTotalBultos.TabIndex = 15
        Me.lblTotalBultos.Text = "Total de bultos"
        Me.lblTotalBultos.Visible = False
        '
        'txtOrden
        '
        Me.txtOrden.Enabled = False
        Me.txtOrden.Location = New System.Drawing.Point(849, 23)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(115, 22)
        Me.txtOrden.TabIndex = 14
        Me.txtOrden.Text = "0"
        Me.txtOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkProOC
        '
        Me.chkProOC.ForeColor = System.Drawing.Color.Black
        Me.chkProOC.Location = New System.Drawing.Point(718, 22)
        Me.chkProOC.Name = "chkProOC"
        Me.chkProOC.Size = New System.Drawing.Size(135, 22)
        Me.chkProOC.TabIndex = 13
        Me.chkProOC.Text = "Por orden de compra"
        Me.chkProOC.UseVisualStyleBackColor = True
        '
        'chkIngreso
        '
        Me.chkIngreso.ForeColor = System.Drawing.Color.Black
        Me.chkIngreso.Location = New System.Drawing.Point(328, 22)
        Me.chkIngreso.Name = "chkIngreso"
        Me.chkIngreso.Size = New System.Drawing.Size(166, 22)
        Me.chkIngreso.TabIndex = 12
        Me.chkIngreso.Text = "Fecha de ingreso desde"
        Me.chkIngreso.UseVisualStyleBackColor = True
        '
        'cmbEstaddo
        '
        Me.cmbEstaddo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstaddo.FormattingEnabled = True
        Me.cmbEstaddo.Location = New System.Drawing.Point(113, 49)
        Me.cmbEstaddo.Name = "cmbEstaddo"
        Me.cmbEstaddo.Size = New System.Drawing.Size(209, 21)
        Me.cmbEstaddo.TabIndex = 11
        '
        'cmbCliente
        '
        Me.cmbCliente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(113, 22)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(209, 21)
        Me.cmbCliente.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(588, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Hasta"
        '
        'dtpCompromisoHasta
        '
        Me.dtpCompromisoHasta.Enabled = False
        Me.dtpCompromisoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCompromisoHasta.Location = New System.Drawing.Point(626, 49)
        Me.dtpCompromisoHasta.Name = "dtpCompromisoHasta"
        Me.dtpCompromisoHasta.Size = New System.Drawing.Size(82, 22)
        Me.dtpCompromisoHasta.TabIndex = 8
        '
        'dtpCompromisoDesde
        '
        Me.dtpCompromisoDesde.Enabled = False
        Me.dtpCompromisoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCompromisoDesde.Location = New System.Drawing.Point(500, 49)
        Me.dtpCompromisoDesde.Name = "dtpCompromisoDesde"
        Me.dtpCompromisoDesde.Size = New System.Drawing.Size(82, 22)
        Me.dtpCompromisoDesde.TabIndex = 7
        '
        'chkCompromiso
        '
        Me.chkCompromiso.AutoSize = True
        Me.chkCompromiso.ForeColor = System.Drawing.Color.Black
        Me.chkCompromiso.Location = New System.Drawing.Point(328, 50)
        Me.chkCompromiso.Name = "chkCompromiso"
        Me.chkCompromiso.Size = New System.Drawing.Size(172, 17)
        Me.chkCompromiso.TabIndex = 6
        Me.chkCompromiso.Text = "Fecha de compromiso desde"
        Me.chkCompromiso.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(588, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta"
        '
        'dtpIngresoHasta
        '
        Me.dtpIngresoHasta.Enabled = False
        Me.dtpIngresoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIngresoHasta.Location = New System.Drawing.Point(626, 21)
        Me.dtpIngresoHasta.Name = "dtpIngresoHasta"
        Me.dtpIngresoHasta.Size = New System.Drawing.Size(82, 22)
        Me.dtpIngresoHasta.TabIndex = 4
        '
        'dtpIngresoDesde
        '
        Me.dtpIngresoDesde.Enabled = False
        Me.dtpIngresoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIngresoDesde.Location = New System.Drawing.Point(500, 21)
        Me.dtpIngresoDesde.Name = "dtpIngresoDesde"
        Me.dtpIngresoDesde.Size = New System.Drawing.Size(82, 22)
        Me.dtpIngresoDesde.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seleccione estado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione cliente"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTotal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 621)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1290, 24)
        Me.StatusStrip1.TabIndex = 3
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
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COL_PIC_CODIGO, Me.COL_COD_PICKING, Me.col_fec_ingreso, Me.col_fecha_p, Me.col_fecha_embarque, Me.Column4, Me.COL_HORA, Me.COL_CAR_CODIGO, Me.COL_CAL_NOMBRE, Me.COL_EPC_CODIGO, Me.COL_EPC_NOMBRE, Me.Column3, Me.COL_CANT_UNI, Me.COL_CANT_BULTOS, Me.COL_TOTAL_BULTO, Me.COLUE, Me.Column1, Me.Column2})
        Me.Grilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla.EnableHeadersVisualStyles = False
        Me.Grilla.GridColor = System.Drawing.SystemColors.HotTrack
        Me.Grilla.Location = New System.Drawing.Point(0, 175)
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
        Me.Grilla.Size = New System.Drawing.Size(1290, 446)
        Me.Grilla.TabIndex = 8
        '
        'COL_PIC_CODIGO
        '
        Me.COL_PIC_CODIGO.HeaderText = "pic_codigo"
        Me.COL_PIC_CODIGO.Name = "COL_PIC_CODIGO"
        Me.COL_PIC_CODIGO.ReadOnly = True
        Me.COL_PIC_CODIGO.Visible = False
        '
        'COL_COD_PICKING
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.COL_COD_PICKING.DefaultCellStyle = DataGridViewCellStyle2
        Me.COL_COD_PICKING.HeaderText = "Nº PK"
        Me.COL_COD_PICKING.Name = "COL_COD_PICKING"
        Me.COL_COD_PICKING.ReadOnly = True
        Me.COL_COD_PICKING.Width = 80
        '
        'col_fec_ingreso
        '
        Me.col_fec_ingreso.HeaderText = "Fecha de Ingreso"
        Me.col_fec_ingreso.Name = "col_fec_ingreso"
        Me.col_fec_ingreso.ReadOnly = True
        Me.col_fec_ingreso.Width = 120
        '
        'col_fecha_p
        '
        Me.col_fecha_p.HeaderText = "Fecha Despacho"
        Me.col_fecha_p.Name = "col_fecha_p"
        Me.col_fecha_p.ReadOnly = True
        Me.col_fecha_p.Width = 120
        '
        'col_fecha_embarque
        '
        Me.col_fecha_embarque.HeaderText = "Fecha Embarque"
        Me.col_fecha_embarque.Name = "col_fecha_embarque"
        Me.col_fecha_embarque.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tipo Entrega"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 140
        '
        'COL_HORA
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.COL_HORA.DefaultCellStyle = DataGridViewCellStyle3
        Me.COL_HORA.HeaderText = "Hora Cita"
        Me.COL_HORA.Name = "COL_HORA"
        Me.COL_HORA.ReadOnly = True
        Me.COL_HORA.Width = 70
        '
        'COL_CAR_CODIGO
        '
        Me.COL_CAR_CODIGO.HeaderText = "Car_codigo"
        Me.COL_CAR_CODIGO.Name = "COL_CAR_CODIGO"
        Me.COL_CAR_CODIGO.ReadOnly = True
        Me.COL_CAR_CODIGO.Visible = False
        '
        'COL_CAL_NOMBRE
        '
        Me.COL_CAL_NOMBRE.HeaderText = "Nombre Cliente"
        Me.COL_CAL_NOMBRE.Name = "COL_CAL_NOMBRE"
        Me.COL_CAL_NOMBRE.ReadOnly = True
        Me.COL_CAL_NOMBRE.Width = 250
        '
        'COL_EPC_CODIGO
        '
        Me.COL_EPC_CODIGO.HeaderText = "EPC_ESTADO"
        Me.COL_EPC_CODIGO.Name = "COL_EPC_CODIGO"
        Me.COL_EPC_CODIGO.ReadOnly = True
        Me.COL_EPC_CODIGO.Visible = False
        '
        'COL_EPC_NOMBRE
        '
        Me.COL_EPC_NOMBRE.HeaderText = "Estado PK"
        Me.COL_EPC_NOMBRE.Name = "COL_EPC_NOMBRE"
        Me.COL_EPC_NOMBRE.ReadOnly = True
        Me.COL_EPC_NOMBRE.Width = 140
        '
        'Column3
        '
        Me.Column3.HeaderText = "Embarque"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'COL_CANT_UNI
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.COL_CANT_UNI.DefaultCellStyle = DataGridViewCellStyle4
        Me.COL_CANT_UNI.HeaderText = "Unidades"
        Me.COL_CANT_UNI.Name = "COL_CANT_UNI"
        Me.COL_CANT_UNI.ReadOnly = True
        Me.COL_CANT_UNI.Width = 70
        '
        'COL_CANT_BULTOS
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.COL_CANT_BULTOS.DefaultCellStyle = DataGridViewCellStyle5
        Me.COL_CANT_BULTOS.HeaderText = "Uni. Encontradas"
        Me.COL_CANT_BULTOS.Name = "COL_CANT_BULTOS"
        Me.COL_CANT_BULTOS.ReadOnly = True
        Me.COL_CANT_BULTOS.Width = 120
        '
        'COL_TOTAL_BULTO
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.COL_TOTAL_BULTO.DefaultCellStyle = DataGridViewCellStyle6
        Me.COL_TOTAL_BULTO.HeaderText = "Uni. Despachadas"
        Me.COL_TOTAL_BULTO.Name = "COL_TOTAL_BULTO"
        Me.COL_TOTAL_BULTO.ReadOnly = True
        '
        'COLUE
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.COLUE.DefaultCellStyle = DataGridViewCellStyle7
        Me.COLUE.HeaderText = "Uni. Embarcadas"
        Me.COLUE.Name = "COLUE"
        Me.COLUE.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "Ver picking"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "Imprimir"
        Me.Column2.UseColumnTextForButtonValue = True
        Me.Column2.Width = 70
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1290, 31)
        Me.Panel3.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 30)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "LISTADO DE PICKING"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1290, 5)
        Me.Panel4.TabIndex = 10
        '
        'grilla_detallada
        '
        Me.grilla_detallada.AllowUserToAddRows = False
        Me.grilla_detallada.AllowUserToDeleteRows = False
        Me.grilla_detallada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla_detallada.BackgroundColor = System.Drawing.Color.White
        Me.grilla_detallada.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_detallada.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grilla_detallada.ColumnHeadersHeight = 25
        Me.grilla_detallada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.col_fec_Emb, Me.car_nombre, Me.tpi_nombre, Me.epc_nombre, Me.pro_codigointerno, Me.pro_nombre, Me.disponible, Me.cantidad, Me.pic_num_bultos, Me.total_bulto, Me.precio, Me.pic_ocnumero, Me.pic_fechaoc, Me.con_codigounico, Me.pic_filadevuelta, Me.existentes, Me.col_tot_bultoext, Me.col_cant_des, Me.col_bulto_despachado, Me.col_total_embarcado, Me.col_total_bulto_embarcado, Me.col_observacion, Me.col_observacion2})
        Me.grilla_detallada.EnableHeadersVisualStyles = False
        Me.grilla_detallada.GridColor = System.Drawing.SystemColors.HotTrack
        Me.grilla_detallada.Location = New System.Drawing.Point(5, 236)
        Me.grilla_detallada.Name = "grilla_detallada"
        Me.grilla_detallada.ReadOnly = True
        Me.grilla_detallada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.grilla_detallada.RowHeadersVisible = False
        Me.grilla_detallada.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.grilla_detallada.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grilla_detallada.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.grilla_detallada.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.grilla_detallada.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.grilla_detallada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla_detallada.Size = New System.Drawing.Size(1278, 348)
        Me.grilla_detallada.TabIndex = 12
        Me.grilla_detallada.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "pic_codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn2.HeaderText = "N° PICKING"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "FECHA DE INGRESO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "F. COMPROMETIDA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'col_fec_Emb
        '
        Me.col_fec_Emb.HeaderText = "FECHA EMBARQUE"
        Me.col_fec_Emb.Name = "col_fec_Emb"
        Me.col_fec_Emb.ReadOnly = True
        '
        'car_nombre
        '
        Me.car_nombre.HeaderText = "CLIENTE"
        Me.car_nombre.Name = "car_nombre"
        Me.car_nombre.ReadOnly = True
        '
        'tpi_nombre
        '
        Me.tpi_nombre.HeaderText = "TIPO ENTREGA"
        Me.tpi_nombre.Name = "tpi_nombre"
        Me.tpi_nombre.ReadOnly = True
        '
        'epc_nombre
        '
        Me.epc_nombre.HeaderText = "ESTADO DE PICKING"
        Me.epc_nombre.Name = "epc_nombre"
        Me.epc_nombre.ReadOnly = True
        '
        'pro_codigointerno
        '
        Me.pro_codigointerno.HeaderText = "CODIGO INTERNO"
        Me.pro_codigointerno.Name = "pro_codigointerno"
        Me.pro_codigointerno.ReadOnly = True
        '
        'pro_nombre
        '
        Me.pro_nombre.HeaderText = "PRODUCTO"
        Me.pro_nombre.Name = "pro_nombre"
        Me.pro_nombre.ReadOnly = True
        '
        'disponible
        '
        Me.disponible.HeaderText = "CANT. DISPONIBLE"
        Me.disponible.Name = "disponible"
        Me.disponible.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'pic_num_bultos
        '
        Me.pic_num_bultos.HeaderText = "N°BULTOS X UNID."
        Me.pic_num_bultos.Name = "pic_num_bultos"
        Me.pic_num_bultos.ReadOnly = True
        '
        'total_bulto
        '
        Me.total_bulto.HeaderText = "TOTAL BULTOS"
        Me.total_bulto.Name = "total_bulto"
        Me.total_bulto.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "PRECIO"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'pic_ocnumero
        '
        Me.pic_ocnumero.HeaderText = "O. COMPRA"
        Me.pic_ocnumero.Name = "pic_ocnumero"
        Me.pic_ocnumero.ReadOnly = True
        '
        'pic_fechaoc
        '
        Me.pic_fechaoc.HeaderText = "FECHA O.C."
        Me.pic_fechaoc.Name = "pic_fechaoc"
        Me.pic_fechaoc.ReadOnly = True
        '
        'con_codigounico
        '
        Me.con_codigounico.HeaderText = "CODIGO UNICO"
        Me.con_codigounico.Name = "con_codigounico"
        Me.con_codigounico.ReadOnly = True
        '
        'pic_filadevuelta
        '
        Me.pic_filadevuelta.HeaderText = "FILA DEVUELTA"
        Me.pic_filadevuelta.Name = "pic_filadevuelta"
        Me.pic_filadevuelta.ReadOnly = True
        '
        'existentes
        '
        Me.existentes.HeaderText = "EXISTENTES"
        Me.existentes.Name = "existentes"
        Me.existentes.ReadOnly = True
        '
        'col_tot_bultoext
        '
        Me.col_tot_bultoext.HeaderText = "TOTAL BULTO EXISTENTE"
        Me.col_tot_bultoext.Name = "col_tot_bultoext"
        Me.col_tot_bultoext.ReadOnly = True
        '
        'col_cant_des
        '
        Me.col_cant_des.HeaderText = "CANTIDAD DESPACHADA"
        Me.col_cant_des.Name = "col_cant_des"
        Me.col_cant_des.ReadOnly = True
        '
        'col_bulto_despachado
        '
        Me.col_bulto_despachado.HeaderText = "TOTAL BULTOS DESPACHADOS"
        Me.col_bulto_despachado.Name = "col_bulto_despachado"
        Me.col_bulto_despachado.ReadOnly = True
        '
        'col_total_embarcado
        '
        Me.col_total_embarcado.HeaderText = "CANTIDAD EMBARCADA"
        Me.col_total_embarcado.Name = "col_total_embarcado"
        Me.col_total_embarcado.ReadOnly = True
        '
        'col_total_bulto_embarcado
        '
        Me.col_total_bulto_embarcado.HeaderText = "TOTAL BULTOS EMBARCADOS"
        Me.col_total_bulto_embarcado.Name = "col_total_bulto_embarcado"
        Me.col_total_bulto_embarcado.ReadOnly = True
        '
        'col_observacion
        '
        Me.col_observacion.HeaderText = "OBSERVACIÓN"
        Me.col_observacion.Name = "col_observacion"
        Me.col_observacion.ReadOnly = True
        '
        'col_observacion2
        '
        Me.col_observacion2.HeaderText = "OBSERVACION 2"
        Me.col_observacion2.Name = "col_observacion2"
        Me.col_observacion2.ReadOnly = True
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaExportar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grillaExportar.ColumnHeadersHeight = 25
        Me.grillaExportar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cguia, Me.coloc, Me.CPAT, Me.CNOM, Me.CC, Me.CCO, Me.CR, Me.CNC, Me.CT, Me.CE, Me.CDI, Me.colcom, Me.CLA, Me.CLO, Me.CFM, Me.CFMA, Me.COPP})
        Me.grillaExportar.EnableHeadersVisualStyles = False
        Me.grillaExportar.GridColor = System.Drawing.SystemColors.HotTrack
        Me.grillaExportar.Location = New System.Drawing.Point(184, 295)
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
        Me.grillaExportar.Size = New System.Drawing.Size(762, 205)
        Me.grillaExportar.TabIndex = 13
        Me.grillaExportar.Visible = False
        '
        'cguia
        '
        Me.cguia.HeaderText = "GUIA"
        Me.cguia.Name = "cguia"
        Me.cguia.ReadOnly = True
        '
        'coloc
        '
        Me.coloc.HeaderText = "ORDEN COMPRA"
        Me.coloc.Name = "coloc"
        Me.coloc.ReadOnly = True
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
        'colcom
        '
        Me.colcom.HeaderText = "COMUNA"
        Me.colcom.Name = "colcom"
        Me.colcom.ReadOnly = True
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
        'frm_listado_picking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 645)
        Me.Controls.Add(Me.grillaExportar)
        Me.Controls.Add(Me.grilla_detallada)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frm_listado_picking"
        Me.Text = "LISTADO DE PICKING"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.grupoExportar.ResumeLayout(False)
        Me.grupoExportar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.grilla_detallada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grillaExportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpCompromisoHasta As DateTimePicker
    Friend WithEvents dtpCompromisoDesde As DateTimePicker
    Friend WithEvents chkCompromiso As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpIngresoHasta As DateTimePicker
    Friend WithEvents dtpIngresoDesde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents cmbEstaddo As ComboBox
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents lblTotal As ToolStripStatusLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents chkIngreso As CheckBox
    Friend WithEvents txtOrden As TextBox
    Friend WithEvents chkProOC As CheckBox
    Friend WithEvents txtTotalBultos As TextBox
    Friend WithEvents lblTotalBultos As Label
    Friend WithEvents ButtonExportar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmbTipoEntrega As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_numero_picking As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents grilla_detallada As DataGridView
    Friend WithEvents COL_PIC_CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents COL_COD_PICKING As DataGridViewTextBoxColumn
    Friend WithEvents col_fec_ingreso As DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_p As DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_embarque As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents COL_HORA As DataGridViewTextBoxColumn
    Friend WithEvents COL_CAR_CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents COL_CAL_NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents COL_EPC_CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents COL_EPC_NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents COL_CANT_UNI As DataGridViewTextBoxColumn
    Friend WithEvents COL_CANT_BULTOS As DataGridViewTextBoxColumn
    Friend WithEvents COL_TOTAL_BULTO As DataGridViewTextBoxColumn
    Friend WithEvents COLUE As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents col_fec_Emb As DataGridViewTextBoxColumn
    Friend WithEvents car_nombre As DataGridViewTextBoxColumn
    Friend WithEvents tpi_nombre As DataGridViewTextBoxColumn
    Friend WithEvents epc_nombre As DataGridViewTextBoxColumn
    Friend WithEvents pro_codigointerno As DataGridViewTextBoxColumn
    Friend WithEvents pro_nombre As DataGridViewTextBoxColumn
    Friend WithEvents disponible As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents pic_num_bultos As DataGridViewTextBoxColumn
    Friend WithEvents total_bulto As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents pic_ocnumero As DataGridViewTextBoxColumn
    Friend WithEvents pic_fechaoc As DataGridViewTextBoxColumn
    Friend WithEvents con_codigounico As DataGridViewTextBoxColumn
    Friend WithEvents pic_filadevuelta As DataGridViewTextBoxColumn
    Friend WithEvents existentes As DataGridViewTextBoxColumn
    Friend WithEvents col_tot_bultoext As DataGridViewTextBoxColumn
    Friend WithEvents col_cant_des As DataGridViewTextBoxColumn
    Friend WithEvents col_bulto_despachado As DataGridViewTextBoxColumn
    Friend WithEvents col_total_embarcado As DataGridViewTextBoxColumn
    Friend WithEvents col_total_bulto_embarcado As DataGridViewTextBoxColumn
    Friend WithEvents col_observacion As DataGridViewTextBoxColumn
    Friend WithEvents col_observacion2 As DataGridViewTextBoxColumn
    Friend WithEvents grupoExportar As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnSelecciona As Button
    Friend WithEvents dtpFechaDespacho As DateTimePicker
    Friend WithEvents grillaExportar As DataGridView
    Friend WithEvents cguia As DataGridViewTextBoxColumn
    Friend WithEvents coloc As DataGridViewTextBoxColumn
    Friend WithEvents CPAT As DataGridViewTextBoxColumn
    Friend WithEvents CNOM As DataGridViewTextBoxColumn
    Friend WithEvents CC As DataGridViewTextBoxColumn
    Friend WithEvents CCO As DataGridViewTextBoxColumn
    Friend WithEvents CR As DataGridViewTextBoxColumn
    Friend WithEvents CNC As DataGridViewTextBoxColumn
    Friend WithEvents CT As DataGridViewTextBoxColumn
    Friend WithEvents CE As DataGridViewTextBoxColumn
    Friend WithEvents CDI As DataGridViewTextBoxColumn
    Friend WithEvents colcom As DataGridViewTextBoxColumn
    Friend WithEvents CLA As DataGridViewTextBoxColumn
    Friend WithEvents CLO As DataGridViewTextBoxColumn
    Friend WithEvents CFM As DataGridViewTextBoxColumn
    Friend WithEvents CFMA As DataGridViewTextBoxColumn
    Friend WithEvents COPP As DataGridViewTextBoxColumn
End Class
