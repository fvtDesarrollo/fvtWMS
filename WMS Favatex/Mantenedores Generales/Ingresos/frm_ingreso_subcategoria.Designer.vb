﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ingreso_subcategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ingreso_subcategoria))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ButtonNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonGurdar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtAbrevi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCategorias = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 4)
        Me.Panel1.TabIndex = 29
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonNuevo, Me.ToolStripSeparator2, Me.ButtonGurdar, Me.ToolStripSeparator1, Me.ButtonSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(342, 25)
        Me.ToolStrip1.TabIndex = 30
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNuevo.Image = CType(resources.GetObject("ButtonNuevo.Image"), System.Drawing.Image)
        Me.ButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(64, 22)
        Me.ButtonNuevo.Text = "NUEVO"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ButtonGurdar
        '
        Me.ButtonGurdar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGurdar.Image = CType(resources.GetObject("ButtonGurdar.Image"), System.Drawing.Image)
        Me.ButtonGurdar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonGurdar.Name = "ButtonGurdar"
        Me.ButtonGurdar.Size = New System.Drawing.Size(79, 22)
        Me.ButtonGurdar.Text = "GUARDAR"
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
        Me.ButtonSalir.Size = New System.Drawing.Size(55, 22)
        Me.ButtonSalir.Text = "SALIR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(342, 4)
        Me.Panel2.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmbCategorias)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.txtAbrevi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSubCategoria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 108)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MANTENEDOR DE SUBCATEGORIAS"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(200, 82)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(64, 17)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.Text = "ACTIVO"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtAbrevi
        '
        Me.txtAbrevi.Location = New System.Drawing.Point(96, 77)
        Me.txtAbrevi.MaxLength = 5
        Me.txtAbrevi.Name = "txtAbrevi"
        Me.txtAbrevi.Size = New System.Drawing.Size(85, 22)
        Me.txtAbrevi.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ABREVIACION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubCategoria
        '
        Me.txtSubCategoria.Location = New System.Drawing.Point(96, 49)
        Me.txtSubCategoria.MaxLength = 45
        Me.txtSubCategoria.Name = "txtSubCategoria"
        Me.txtSubCategoria.Size = New System.Drawing.Size(217, 22)
        Me.txtSubCategoria.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "NOMBRE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "CATEGORIA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCategorias
        '
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Location = New System.Drawing.Point(96, 22)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(217, 21)
        Me.cmbCategorias.TabIndex = 1
        '
        'frm_ingreso_subcategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 151)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ingreso_subcategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENEDOR DE SUBCATEGORIAS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ButtonNuevo As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ButtonGurdar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ButtonSalir As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents txtAbrevi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCategorias As ComboBox
End Class
