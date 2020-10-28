<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaMasivaB2B
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargaMasivaB2B))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ButtonSelecciona = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonDesmarcar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.prbArchivo = New System.Windows.Forms.ProgressBar()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.colSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_car_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ultima_ejecucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_regisdtros_actualizados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad_registros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_carpeta_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_delimitador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_link = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 1)
        Me.Panel1.TabIndex = 21
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonSelecciona, Me.ToolStripSeparator2, Me.ButtonDesmarcar, Me.ToolStripSeparator3, Me.ButtonGuardar, Me.ToolStripSeparator1, Me.ButtonSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(602, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ButtonSelecciona
        '
        Me.ButtonSelecciona.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSelecciona.Image = CType(resources.GetObject("ButtonSelecciona.Image"), System.Drawing.Image)
        Me.ButtonSelecciona.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSelecciona.Name = "ButtonSelecciona"
        Me.ButtonSelecciona.Size = New System.Drawing.Size(113, 22)
        Me.ButtonSelecciona.Text = "Seleccionar Todo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonDesmarcar
        '
        Me.ButtonDesmarcar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDesmarcar.Image = CType(resources.GetObject("ButtonDesmarcar.Image"), System.Drawing.Image)
        Me.ButtonDesmarcar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonDesmarcar.Name = "ButtonDesmarcar"
        Me.ButtonDesmarcar.Size = New System.Drawing.Size(110, 22)
        Me.ButtonDesmarcar.Text = "Desmarcar Todo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.Image = CType(resources.GetObject("ButtonGuardar.Image"), System.Drawing.Image)
        Me.ButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(117, 22)
        Me.ButtonGuardar.Text = "Importar Ordenes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(49, 22)
        Me.ButtonSalir.Text = "Salir"
        '
        'lblArchivo
        '
        Me.lblArchivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArchivo.Location = New System.Drawing.Point(12, 33)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(578, 21)
        Me.lblArchivo.TabIndex = 23
        Me.lblArchivo.Text = "Archivo:"
        Me.lblArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prbArchivo
        '
        Me.prbArchivo.Location = New System.Drawing.Point(12, 57)
        Me.prbArchivo.Name = "prbArchivo"
        Me.prbArchivo.Size = New System.Drawing.Size(578, 22)
        Me.prbArchivo.TabIndex = 24
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
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSel, Me.col_car_codigo, Me.col_nombre_cliente, Me.col_ultima_ejecucion, Me.col_regisdtros_actualizados, Me.col_cantidad_registros, Me.col_carpeta_cliente, Me.col_delimitador, Me.col_observacion, Me.col_link})
        Me.Grilla.EnableHeadersVisualStyles = False
        Me.Grilla.Location = New System.Drawing.Point(12, 85)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Grilla.RowHeadersVisible = False
        Me.Grilla.Size = New System.Drawing.Size(578, 393)
        Me.Grilla.TabIndex = 25
        '
        'colSel
        '
        Me.colSel.HeaderText = "S"
        Me.colSel.Name = "colSel"
        '
        'col_car_codigo
        '
        Me.col_car_codigo.HeaderText = "car_codigo"
        Me.col_car_codigo.Name = "col_car_codigo"
        Me.col_car_codigo.ReadOnly = True
        Me.col_car_codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_car_codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_car_codigo.Visible = False
        '
        'col_nombre_cliente
        '
        Me.col_nombre_cliente.HeaderText = "Cliente"
        Me.col_nombre_cliente.Name = "col_nombre_cliente"
        Me.col_nombre_cliente.ReadOnly = True
        Me.col_nombre_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_nombre_cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_ultima_ejecucion
        '
        Me.col_ultima_ejecucion.HeaderText = "Ultima Ejecucón"
        Me.col_ultima_ejecucion.Name = "col_ultima_ejecucion"
        Me.col_ultima_ejecucion.ReadOnly = True
        '
        'col_regisdtros_actualizados
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_regisdtros_actualizados.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_regisdtros_actualizados.HeaderText = "Registos Actualizados"
        Me.col_regisdtros_actualizados.Name = "col_regisdtros_actualizados"
        Me.col_regisdtros_actualizados.ReadOnly = True
        Me.col_regisdtros_actualizados.Width = 150
        '
        'col_cantidad_registros
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_cantidad_registros.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_cantidad_registros.HeaderText = "Registros Nuevos"
        Me.col_cantidad_registros.Name = "col_cantidad_registros"
        Me.col_cantidad_registros.ReadOnly = True
        Me.col_cantidad_registros.Width = 150
        '
        'col_carpeta_cliente
        '
        Me.col_carpeta_cliente.HeaderText = "carpeta_cliente"
        Me.col_carpeta_cliente.Name = "col_carpeta_cliente"
        Me.col_carpeta_cliente.ReadOnly = True
        Me.col_carpeta_cliente.Visible = False
        '
        'col_delimitador
        '
        Me.col_delimitador.HeaderText = "delimitador"
        Me.col_delimitador.Name = "col_delimitador"
        Me.col_delimitador.ReadOnly = True
        Me.col_delimitador.Visible = False
        '
        'col_observacion
        '
        Me.col_observacion.HeaderText = "Observacion"
        Me.col_observacion.Name = "col_observacion"
        Me.col_observacion.ReadOnly = True
        Me.col_observacion.Visible = False
        '
        'col_link
        '
        Me.col_link.HeaderText = ""
        Me.col_link.Name = "col_link"
        '
        'CargaMasivaB2B
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 490)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.prbArchivo)
        Me.Controls.Add(Me.lblArchivo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CargaMasivaB2B"
        Me.Text = "Carga masiva de Ordenes de Compra"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ButtonSelecciona As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ButtonDesmarcar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ButtonGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ButtonSalir As ToolStripButton
    Friend WithEvents lblArchivo As Label
    Friend WithEvents prbArchivo As ProgressBar
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents colSel As DataGridViewCheckBoxColumn
    Friend WithEvents col_car_codigo As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre_cliente As DataGridViewTextBoxColumn
    Friend WithEvents col_ultima_ejecucion As DataGridViewTextBoxColumn
    Friend WithEvents col_regisdtros_actualizados As DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad_registros As DataGridViewTextBoxColumn
    Friend WithEvents col_carpeta_cliente As DataGridViewTextBoxColumn
    Friend WithEvents col_delimitador As DataGridViewTextBoxColumn
    Friend WithEvents col_observacion As DataGridViewTextBoxColumn
    Friend WithEvents col_link As DataGridViewLinkColumn
End Class
