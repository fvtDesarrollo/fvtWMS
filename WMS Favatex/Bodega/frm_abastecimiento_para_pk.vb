Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Threading
Public Class frm_abastecimiento_para_pk
    Dim dataSetArbol As System.Data.DataSet
    Dim node As System.Windows.Forms.TreeNode

    Dim dtTree As DataTable = New DataTable
    Dim dtTree2 As DataTable = New DataTable
    Dim _cnn As String
    Dim _oab_codigo As Integer = 0
    Dim _eab_codigo As Integer

    Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Property eab_codigo() As Integer
        Get
            Return _eab_codigo
        End Get
        Set(ByVal value As Integer)
            _eab_codigo = value
        End Set
    End Property
    Property oab_codigo() As Integer
        Get
            Return _oab_codigo
        End Get
        Set(ByVal value As Integer)
            _oab_codigo = value
        End Set
    End Property

    Const COL_GRI_SELECCION As Integer = 0
    Const COL_GRI_PRO_CODIGO As Integer = 1
    Const COL_GRI_CODIGO As Integer = 2
    Const COL_GRI_PRODUCTO As Integer = 3
    Const COL_GRI_CATEGORIA As Integer = 4
    Const COL_GRI_SUBCATEGORIA As Integer = 5
    Const COL_GRI_BULTO As Integer = 6
    Const COL_GRI_UBICACIONES As Integer = 7
    Const COL_GRI_CANT_UNIDADES As Integer = 8
    Const COL_GRI_TIPOPALLET As Integer = 9
    Const COL_GRI_LLAEVE As Integer = 10
    Const COL_GRI_MARCA As Integer = 11
    Const COL_GRI_CANTIDAD_BASE As Integer = 12
    Const COL_GRI_CANT_UBICACIONES As Integer = 13

    'CONSTANTE GRILLA DE ORDEN DE ABASTECIMIENTO
    Const COL_ABA_FILA As Integer = 0
    Const COL_ABA_PRO_CODIGO As Integer = 1
    Const COL_ABA_PRO_CODIGO_INTERNO As Integer = 2
    Const COL_ABA_BULTO As Integer = 3
    Const COL_ABA_COD_UBI_ABAS As Integer = 4
    Const COL_ABA_UBICACION_ABAS As Integer = 5
    Const COL_ABA_PALLET_ABAS As Integer = 6
    Const COL_ABA_CANTIDAD_ABAS As Integer = 7
    Const COL_ABA_COD_UBICACION As Integer = 8
    Const COL_ABA_UBICACION_PK As Integer = 9
    Const COL_ABA_PALLET As Integer = 10
    Const COL_ABA_CANTIDAD As Integer = 11
    Const COL_ABA_PROCESADO As Integer = 12
    Const COL_ABA_UBICADO As Integer = 13
    Const COL_ABA_SIN_PROCESAR As Integer = 14
    Const COL_ABA_SIN_NEW_CANTIDAD As Integer = 15
    Const COL_ABA_PALLET_PISO As Integer = 16
    Const COL_ABA_VACIA As Integer = 17
    Const COL_CAN_ORIGINAL As Integer = 18



    Private Sub frm_abastecimiento_para_pk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        lblSeleccion.Text = "Registros seleccionados: 0"
        Call CARGA_GRILLA_OPERARIO_BODEGA()
        If _oab_codigo = 0 Then
            GrillaAsignacion.Columns(COL_ABA_PROCESADO).Visible = False
            GrillaAsignacion.Columns(COL_ABA_UBICADO).Visible = False
        Else
            If eab_codigo = ESTADO_ORDEN_REABASTECIMIENTO.PENDIENTE Then
                btnAnulaOrden.Enabled = True
                btnFinaliza.Enabled = True
            Else
                btnAsigna.Enabled = False
                btnAnulaOrden.Enabled = False
                btnFinaliza.Enabled = False
            End If


            TabPage1.Parent = Nothing
            GrillaAsignacion.Columns(COL_ABA_PROCESADO).Visible = True
            GrillaAsignacion.Columns(COL_ABA_UBICADO).Visible = True
            txtNumAsi.Enabled = False

            Call CARGA_DATOS_ENCABEZADO_ORDEN_ABASTECIMIENTO()
            Call CARGA_GRILLA_DETALLE_ORDEN()
            Call CARGA_OPERARIO_BODEGA()
        End If
        Call INICIALIZA()

    End Sub

    Private Sub CARGA_GRILLA_OPERARIO_BODEGA()
        Dim classComunes As class_comunes = New class_comunes
        Dim Fila As Integer = 0
        Dim ds As DataSet = New DataSet
        Dim _msg As String

        Try
            ds = Nothing
            classComunes.cnn = _cnn
            _msg = ""
            GrillaOperario.DataSource = Nothing
            GrillaOperario.Rows.Clear()

            ds = classComunes.OPERARIOS_BODEGA_BUSCAR(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("nombre") <> "" Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            GrillaOperario.Rows.Add(ds.Tables(0).Rows(Fila)("codigo"), False,
                                            ds.Tables(0).Rows(Fila)("nombre"))

                            Fila = Fila + 1

                        Loop
                        'lblTotal.Text = "Total de registros:" + ds.Tables(0).Rows.Count.ToString
                    End If
                End If

            Else
                MessageBox.Show(_msg + "\CARGA_GRILLA_OPERARIO_BODEGA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA_OPERARIO_BODEGA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_OPERARIO_BODEGA()
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim Fila As Integer = 0
        Dim ds As DataSet = New DataSet
        Dim _msg As String

        Try
            If GrillaOperario.Rows.Count = 0 Then
                MessageBox.Show("No operarios configurados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            ds = Nothing
            classUbicaciones.cnn = _cnn
            classUbicaciones.aob_codigo = _oab_codigo
            _msg = ""

            GrillaOperario.DataSource = Nothing
            GrillaOperario.Rows.Clear()
            ds = classUbicaciones.ASIGNACION_ABASTECIMIENTO_RESPONSABLE_BUSCAR(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("usu_codigo") > 0 Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            GrillaOperario.Rows.Add(ds.Tables(0).Rows(Fila)("usu_codigo"), True,
                                            ds.Tables(0).Rows(Fila)("usu_nombre"))

                            Fila = Fila + 1

                        Loop

                    End If
                End If

            Else
                MessageBox.Show(_msg + "\CARGA_ASIGNACION_ABASTECIMIENTO_BUSQUEDA_OPERARIO_BODEGA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_ASIGNACION_ABASTECIMIENTO_BUSQUEDA_OPERARIO_BODEGA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub



    Private Sub CARGA_GRILLA_DETALLE_ORDEN()
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim Fila As Integer = 0

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String

            ds = Nothing
            classUbicacion.cnn = _cnn

            classUbicacion.oab_codigo = _oab_codigo

            _msg = ""
            GrillaAsignacion.Rows.Clear()
            ds = classUbicacion.ORDEN_ABASTECIMIENTO_DETALLE_LISTAR(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("oab_codigo") > 0 Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            GrillaAsignacion.Rows.Add(ds.Tables(0).Rows(Fila)("dab_fila"),
                                            ds.Tables(0).Rows(Fila)("pro_codigo"),
                                            ds.Tables(0).Rows(Fila)("pro_codigointerno"),
                                            ds.Tables(0).Rows(Fila)("bulto"),
                                            ds.Tables(0).Rows(Fila)("dab_codigo_ubicacion_aba"),
                                            ds.Tables(0).Rows(Fila)("dab_nombre_ubicacion_aba"),
                                            ds.Tables(0).Rows(Fila)("dab_pallet_aba"),
                                            ds.Tables(0).Rows(Fila)("dab_cantidad_aba"),
                                            ds.Tables(0).Rows(Fila)("dab_codigo_ubicacion_pk"),
                                            ds.Tables(0).Rows(Fila)("dab_nombre_ubicacion_pk"),
                                            ds.Tables(0).Rows(Fila)("dab_pallet_pk"),
                                            ds.Tables(0).Rows(Fila)("dab_cantidad_pk"),
                                            ds.Tables(0).Rows(Fila)("dab_procesado"),
                                            "",
                                            False,
                                            "",
                                            "",
                                            ds.Tables(0).Rows(Fila)("dab_quitar"),
                                            ds.Tables(0).Rows(Fila)("dab_cantidad_original"))

                            If ds.Tables(0).Rows(Fila)("dab_quitar") = True Then
                                Call PINTA_CELDA_GRIS(Fila)
                            End If

                            Fila = Fila + 1
                        Loop

                    End If
                End If

            Else
                MessageBox.Show(_msg + "\CARGA_GRILLA_DETALLE_ORDEN", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Call CONFIGURA_COLUMNAS_ABASTECIMIENTO()

        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA_DETALLE_ORDEN", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_DATOS_ENCABEZADO_ORDEN_ABASTECIMIENTO()
        Dim classOrden As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim Fila As Integer = 0
        Try
            classOrden.cnn = _cnn
            classOrden.oab_codigo = _oab_codigo
            classOrden.pro_codigointerno = "-"
            classOrden.fecha_desde = "19000101"
            classOrden.Fecha_hasta = "20501231"
            classOrden.eab_codigo = 0

            ds = classOrden.ORDEN_ABASTECIMIENTO_LISTAR(_msgError)
            If _msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("codEstado") > 0 Then
                        txtNumAsi.Text = ds.Tables(0).Rows(Fila)("codigo")
                        txtObservación.Text = ds.Tables(0).Rows(Fila)("observacion")
                        TxtFechaOab.Value = ds.Tables(0).Rows(Fila)("fecha")
                        _eab_codigo = ds.Tables(0).Rows(Fila)("codEstado")

                        If _eab_codigo = 1 Then
                            btnAsigna.Enabled = False
                            btnFinaliza.Enabled = True
                            'GrillaAsignacion.Columns(COL_ABA_PROCESADO).Visible = True
                            GrillaAsignacion.Columns(COL_ABA_UBICADO).Visible = True
                        ElseIf _eab_codigo = 2 Then
                            btnAsigna.Enabled = False
                            btnFinaliza.Enabled = False
                            'GrillaAsignacion.Columns(COL_ABA_PROCESADO).Visible = False
                            GrillaAsignacion.Columns(COL_ABA_UBICADO).Visible = False
                        End If
                    End If
                End If
            Else
                MessageBox.Show(_msgError + "\CARGA_DATOS_ENCABEZADO_ASIGNACION", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + "\CARGA_DATOS_ENCABEZADO_ASIGNACION", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub INICIALIZA()
        cmbCategoria.DataSource = Nothing
        cmbCategoria.Items.Clear()
        Call CARGA_COMBO_CATEGORIAS()
        Call CONFIGURA_COLUMNAS()
    End Sub

    Private Sub CONFIGURA_COLUMNAS()
        Grilla.Columns(COL_GRI_PRO_CODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_PRODUCTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CATEGORIA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_SUBCATEGORIA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_BULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_UBICACIONES).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CANT_UNIDADES).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CANT_UBICACIONES).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub CONFIGURA_COLUMNAS_ABASTECIMIENTO()
        GrillaAsignacion.Columns(COL_ABA_FILA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_PRO_CODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_PRO_CODIGO_INTERNO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_BULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_COD_UBICACION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_UBICACION_PK).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_PALLET).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_COD_UBI_ABAS).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_UBICACION_ABAS).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_PALLET_ABAS).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_CANTIDAD_ABAS).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_PROCESADO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaAsignacion.Columns(COL_ABA_UBICADO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub CARGA_COMBO_CATEGORIAS()
        Dim _msg As String
        Try
            Dim class_categoria As class_categorias = New class_categorias
            Dim ds As DataSet = New DataSet
            ds = Nothing
            class_categoria.cnn = _cnn
            _msg = ""
            ds = class_categoria.CARGA_COMBO_CATEGORIA(_msg)
            If _msg = "" Then
                Me.cmbCategoria.DataSource = ds.Tables(0)
                Me.cmbCategoria.DisplayMember = "mensaje"
                Me.cmbCategoria.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_CATEGORIAS", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCategoria.SelectionChangeCommitted
        Call CARGA_COMBO_SUBCATEGORIAS()
    End Sub

    Private Sub CARGA_COMBO_SUBCATEGORIAS()
        Dim _msg As String
        Try
            Dim class_subcategoria As class_subcategoria = New class_subcategoria
            Dim ds As DataSet = New DataSet
            ds = Nothing
            class_subcategoria.cnn = _cnn
            class_subcategoria.cat_codigo = cmbCategoria.SelectedValue
            _msg = ""
            ds = class_subcategoria.CARGA_COMBO_SUBCATEGORIA(_msg)
            If _msg = "" Then
                Me.cmbSubcategoria.DataSource = ds.Tables(0)
                Me.cmbSubcategoria.DisplayMember = "mensaje"
                Me.cmbSubcategoria.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_SUBCATEGORIAS", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_GRILLA_DETALLE()
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim Fila As Integer = 0
        Dim Contador As Integer = 1
        Try
            Me.Cursor = Cursors.WaitCursor
            classUbicacion.cnn = _cnn

            If txtCodigoUnico.Text = "" Then
                classUbicacion.pro_codigointerno = "-"
            Else
                classUbicacion.pro_codigointerno = Trim(txtCodigoUnico.Text)
            End If

            If cmbCategoria.Text = "" Then
                classUbicacion.cat_codigo = 0
            Else
                classUbicacion.cat_codigo = cmbCategoria.SelectedValue
            End If

            If cmbSubcategoria.Text = "" Then
                classUbicacion.sca_codigo = 0
            Else
                classUbicacion.sca_codigo = cmbSubcategoria.SelectedValue
            End If

            If optTodos.Checked = True Then
                classUbicacion.opcion = 1
            ElseIf optSinUbicacionPK.Checked = True Then
                classUbicacion.opcion = 2
            ElseIf optUbicacionVacia.Checked = True Then
                classUbicacion.opcion = 3
            End If

            Grilla.Rows.Clear()
            ds = classUbicacion.BUSCA_PRODUCTOS_PARA_ABASTECIMIENTO(_msgError)
            If _msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("pro_codigo") > 0 Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            Grilla.Rows.Add(False,
                                            ds.Tables(0).Rows(Fila)("pro_codigo"),
                                            ds.Tables(0).Rows(Fila)("pro_codigointerno"),
                                            ds.Tables(0).Rows(Fila)("pro_nombre"),
                                            ds.Tables(0).Rows(Fila)("cat_nombre"),
                                            ds.Tables(0).Rows(Fila)("sub_nombre"),
                                            ds.Tables(0).Rows(Fila)("bulto"),
                                            ds.Tables(0).Rows(Fila)("ubicaciones"),
                                            ds.Tables(0).Rows(Fila)("cantidad"),
                                            ds.Tables(0).Rows(Fila)("bul_tipopallet"),
                                            ds.Tables(0).Rows(Fila)("pro_codigointerno") + "-" + CStr(ds.Tables(0).Rows(Fila)("bul_codigo")),
                                            0,
                                            ds.Tables(0).Rows(Fila)("cantidad_base"),
                                            ds.Tables(0).Rows(Fila)("cantidad_ubicaciones"))

                            Grilla.Item(COL_GRI_MARCA, Fila).Value = 0
                            If CInt(Grilla.Item(COL_GRI_CANT_UBICACIONES, Fila).Value) = 0 Then
                                Call PINTA_CELDA_ROJO(Fila)
                                Grilla.Item(COL_GRI_MARCA, Fila).Value = 0
                            Else
                                'If CInt(Grilla.Item(COL_GRI_CANT_UNIDADES, Fila).Value) <= CInt(Grilla.Item(COL_GRI_CANTIDAD_BASE, Fila).Value) Then
                                '    Call PINTA_CELDA_NARANJA(Fila)
                                '    Grilla.Item(COL_GRI_MARCA, Fila).Value = 1
                                'End If
                                Grilla.Item(COL_GRI_MARCA, Fila).Value = 1
                            End If

                            Fila = Fila + 1
                            Contador = Contador + 1
                        Loop
                        Call CONFIGURA_COLUMNAS()

                    End If
                End If

                Me.Cursor = Cursors.Default
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show(_msgError + "\CARGA_GRILLA_DETALLE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message + "\CARGA_GRILLA_DETALLE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PINTA_CELDA_ROJO(ByVal fila As Integer)
        Grilla.Item(COL_GRI_PRO_CODIGO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_PRO_CODIGO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CODIGO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CODIGO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_PRODUCTO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_PRODUCTO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CATEGORIA, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CATEGORIA, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_SUBCATEGORIA, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_SUBCATEGORIA, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_BULTO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_BULTO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CANT_UBICACIONES, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CANT_UBICACIONES, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CANT_UNIDADES, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CANT_UNIDADES, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_UBICACIONES, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_UBICACIONES, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)
    End Sub

    Private Sub PINTA_CELDA_NARANJA(ByVal fila As Integer)
        Grilla.Item(COL_GRI_PRO_CODIGO, fila).Style.BackColor = Color.FromArgb(250, 225, 169)
        Grilla.Item(COL_GRI_PRO_CODIGO, fila).Style.ForeColor = Color.FromArgb(255, 128, 0)

        Grilla.Item(COL_GRI_CODIGO, fila).Style.BackColor = Color.FromArgb(250, 225, 169)
        Grilla.Item(COL_GRI_CODIGO, fila).Style.ForeColor = Color.FromArgb(255, 128, 0)

        Grilla.Item(COL_GRI_PRODUCTO, fila).Style.BackColor = Color.FromArgb(250, 225, 169)
        Grilla.Item(COL_GRI_PRODUCTO, fila).Style.ForeColor = Color.FromArgb(255, 128, 0)

        Grilla.Item(COL_GRI_CATEGORIA, fila).Style.BackColor = Color.FromArgb(250, 225, 169)
        Grilla.Item(COL_GRI_CATEGORIA, fila).Style.ForeColor = Color.FromArgb(255, 128, 0)

        Grilla.Item(COL_GRI_SUBCATEGORIA, fila).Style.BackColor = Color.FromArgb(250, 225, 169)
        Grilla.Item(COL_GRI_SUBCATEGORIA, fila).Style.ForeColor = Color.FromArgb(255, 128, 0)

        Grilla.Item(COL_GRI_BULTO, fila).Style.BackColor = Color.FromArgb(250, 225, 169)
        Grilla.Item(COL_GRI_BULTO, fila).Style.ForeColor = Color.FromArgb(255, 128, 0)

        Grilla.Item(COL_GRI_CANT_UBICACIONES, fila).Style.BackColor = Color.FromArgb(250, 225, 169)
        Grilla.Item(COL_GRI_CANT_UBICACIONES, fila).Style.ForeColor = Color.FromArgb(255, 128, 0)

        Grilla.Item(COL_GRI_CANT_UNIDADES, fila).Style.BackColor = Color.FromArgb(250, 225, 169)
        Grilla.Item(COL_GRI_CANT_UNIDADES, fila).Style.ForeColor = Color.FromArgb(255, 128, 0)

        Grilla.Item(COL_GRI_UBICACIONES, fila).Style.BackColor = Color.FromArgb(250, 225, 169)
        Grilla.Item(COL_GRI_UBICACIONES, fila).Style.ForeColor = Color.FromArgb(255, 128, 0)
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Call CARGA_GRILLA_DETALLE()
    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        If e.ColumnIndex = Me.Grilla.Columns.Item(COL_GRI_SELECCION).Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.Grilla.Rows(e.RowIndex).Cells(COL_GRI_SELECCION)
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub ButtonAsignar_Click(sender As Object, e As EventArgs) Handles ButtonAsignar.Click
        Dim fila As Integer = 0
        Dim strCadena As String = ""
        Dim _msg As String = ""
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim ds As DataSet
        Dim Mensaje As String = ""

        If DETALLES_MARCADAS() = False Then
            MessageBox.Show("No existen registros seleccionados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Valida productos que no se encuentren dentro de otro documento de asignacion
        For Each row As DataGridViewRow In Me.Grilla.Rows
            If row.Cells(COL_GRI_SELECCION).Value = True Then
                classUbicaciones.cnn = _cnn
                classUbicaciones.pro_codigo = row.Cells(COL_GRI_PRO_CODIGO).Value
                classUbicaciones.bul_codigo = CInt(Mid(row.Cells(COL_GRI_BULTO).Value.ToString, 1, 2))
                ds = classUbicaciones.VALIDA_PRODUCTO_EN_ORDEN_ABASTESIMIENTO(_msg)
                If _msg = "" Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If ds.Tables(0).Rows(0)("resultado") <> "" Then
                            Do While fila < ds.Tables(0).Rows.Count
                                If Mensaje = "" Then
                                    Mensaje = row.Cells(COL_GRI_CODIGO).Value + "-[" + row.Cells(COL_GRI_BULTO).Value + "] " + ds.Tables(0).Rows(fila)("resultado")
                                Else
                                    Mensaje = Mensaje + vbNewLine + row.Cells(COL_GRI_CODIGO).Value + "-[" + row.Cells(COL_GRI_BULTO).Value + "] " + ds.Tables(0).Rows(fila)("resultado")
                                End If
                                fila = fila + 1
                            Loop
                        End If
                    End If
                Else
                    MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

            End If
        Next

        If Mensaje <> "" Then
            MessageBox.Show("En la seleccion existe codigos que son parte de otras ordenes de abastesimiento sin finalizar " _
                            + Chr(10) + "Se requiere regularizar para continuar: " + vbNewLine + vbNewLine + Mensaje, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If



        Do While fila <= Grilla.RowCount - 1
            If Grilla.Rows(fila).Cells(COL_GRI_SELECCION).Value = True Then
                If Grilla.Rows(fila).Cells(COL_GRI_TIPOPALLET).Value.ToString = "-" Then
                    MessageBox.Show("El producto " + Grilla.Rows(fila).Cells(COL_GRI_CODIGO).Value.ToString + ", bulto " + Grilla.Rows(fila).Cells(COL_GRI_BULTO).Value.ToString _
                                    + Chr(10) + "No tiene un tipo de pallet asociado (D: doble o E: Estandar), por favor configurar en mantenedor de bultos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If CInt(Grilla.Rows(fila).Cells(COL_GRI_CANT_UBICACIONES).Value) = 0 Then
                    MessageBox.Show("El producto " + Grilla.Rows(fila).Cells(COL_GRI_CODIGO).Value.ToString + ", bulto " + Grilla.Rows(fila).Cells(COL_GRI_BULTO).Value.ToString _
                                    + Chr(10) + "No tiene ubicaciones para picking asociada, por favor configurar en mantenedor de ubicaciones", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If CInt(Grilla.Rows(fila).Cells(COL_GRI_MARCA).Value) = 0 Then
                    MessageBox.Show("El producto " + Grilla.Rows(fila).Cells(COL_GRI_CODIGO).Value.ToString + ", bulto " + Grilla.Rows(fila).Cells(COL_GRI_BULTO).Value.ToString _
                                    + Chr(10) + "No requiere de abastecimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If



                'If Grilla.Rows(fila).Cells(COL_GRI_TIPOPALLET).Value.ToString = "D" Then
                '    If ((CInt(Grilla.Rows(fila).Cells(COL_GRI_CANT_UBICACIONES).Value) Mod 2) > 0) Then
                '        MessageBox.Show("El producto " + Grilla.Rows(fila).Cells(COL_GRI_CODIGO).Value.ToString + ", bulto " + Grilla.Rows(fila).Cells(COL_GRI_BULTO).Value.ToString _
                '                    + Chr(10) + "Utiliza un pallet doble y requiere a lo menos 2 ubicaciones o multiplos de 2, por favor configurar en mantenedor de ubicaciones ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '        Exit Sub
                '    End If
                'End If

                If strCadena = "" Then
                        strCadena = Grilla.Rows(fila).Cells(COL_GRI_LLAEVE).Value + ","
                    Else
                        strCadena = strCadena + Grilla.Rows(fila).Cells(COL_GRI_LLAEVE).Value + ","
                    End If

                End If
                fila = fila + 1
        Loop

        If strCadena <> "" Then
            Call CARGA_GRILLA_UBICACION_PK(strCadena)
            lblSeleccion.Text = "Registros seleccionados: " + GrillaAsignacion.RowCount.ToString
            'TabControl1.SelectedIndex = 1
        End If
    End Sub

    Private Sub CARGA_GRILLA_UBICACION_PK(ByVal strCadena As String)
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim Fila As Integer = 0
        Dim Contador As Integer = 1
        Try
            Me.Cursor = Cursors.WaitCursor
            classUbicacion.cnn = _cnn
            classUbicacion.strCadena = strCadena

            GrillaAsignacion.Rows.Clear()
            ds = classUbicacion.SELECCIONA_PRODUCTOS_PARA_ABASTECIMIENTO(_msgError)
            If _msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("pro_codigo") > 0 Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            GrillaAsignacion.Rows.Add(0,
                                            ds.Tables(0).Rows(Fila)("pro_codigo"),
                                            ds.Tables(0).Rows(Fila)("pro_codigointerno"),
                                            ds.Tables(0).Rows(Fila)("bulto"),
                                            "-",
                                            "-",
                                            "-",
                                            0,
                                            ds.Tables(0).Rows(Fila)("ubi_codigo"),
                                            ds.Tables(0).Rows(Fila)("ubi_nombre"),
                                            ds.Tables(0).Rows(Fila)("pallet"),
                                            ds.Tables(0).Rows(Fila)("cantidad"))

                            Fila = Fila + 1
                            Contador = Contador + 1
                        Loop

                        Call CONFIGURA_COLUMNAS_ABASTECIMIENTO()

                    End If
                End If
                Me.Cursor = Cursors.Default
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show(_msgError + "\CARGA_GRILLA_UBICACION_PK", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message + "\CARGA_GRILLA_UBICACION_PK", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function DETALLES_MARCADAS() As Boolean
        Dim Contador As Integer = 0
        Try
            DETALLES_MARCADAS = False

            For Each row As DataGridViewRow In Me.Grilla.Rows
                If row.Cells(0).Value = True Then
                    Contador = Contador + 1
                End If
            Next

            If Contador > 0 Then
                DETALLES_MARCADAS = True
            End If

        Catch ex As Exception
            DETALLES_MARCADAS = False
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub btnAsigna_Click(sender As Object, e As EventArgs) Handles btnAsigna.Click
        If txtObservación.Text = "" Then
            MessageBox.Show("Debe ingresar una observación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtObservación.Focus()
            Exit Sub
        End If

        GENERA_ORDEN_ABASTECIMIENTO()
    End Sub

    Private Function GENERA_ORDEN_ABASTECIMIENTO()
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        Dim contador As Integer = 0

        GENERA_ORDEN_ABASTECIMIENTO = False

        Try

            'VALIDA OPERARIOS SELECCIONADOS
            '---------------------------------------------------------
            contador = 0
            For Each row2 As DataGridViewRow In Me.GrillaOperario.Rows
                If row2.Cells(1).Value = True Then
                    contador = contador + 1
                End If
            Next

            If contador = 0 Then
                MessageBox.Show("Debe seleccionar a lo menos un operario ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                'TabControl1.SelectedIndex = 1

                Exit Function
            End If

            contador = 0

            Me.Cursor = Cursors.WaitCursor
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                classUbicaciones.cnn = _cnn

                ProgressBar1.Visible = True
                ProgressBar1.Value = 0
                ProgressBar1.Minimum = 0
                ProgressBar1.Maximum = GrillaAsignacion.RowCount
                For Each row As DataGridViewRow In Me.GrillaAsignacion.Rows
                    If row.Cells(COL_ABA_PRO_CODIGO_INTERNO).Value <> "" Then
                        classUbicaciones.pro_codigo = row.Cells(COL_ABA_PRO_CODIGO).Value
                        classUbicaciones.bul_codigo = CInt(Mid(row.Cells(COL_ABA_BULTO).Value, 1, 2))
                        ds = Nothing
                        ds = classUbicaciones.SELECCIONA_POSICIONES_PARA_ABASTECER(_msgError, conexion)
                        If _msgError = "" Then
                            If ds.Tables(0).Rows.Count > 0 Then
                                If ds.Tables(0).Rows(0)("ubi_codigo") <> "" Then
                                    row.Cells(COL_ABA_COD_UBI_ABAS).Value = ds.Tables(0).Rows(0)("ubi_codigo")
                                    row.Cells(COL_ABA_UBICACION_ABAS).Value = ds.Tables(0).Rows(0)("ubi_nombre")
                                    row.Cells(COL_ABA_PALLET_ABAS).Value = ds.Tables(0).Rows(0)("pallet")
                                    row.Cells(COL_ABA_CANTIDAD_ABAS).Value = ds.Tables(0).Rows(0)("cantidad")
                                Else
                                    row.Cells(COL_ABA_COD_UBI_ABAS).Value = "-"
                                    row.Cells(COL_ABA_UBICACION_ABAS).Value = "SIN UBICACIÓN"
                                    row.Cells(COL_ABA_PALLET_ABAS).Value = "-"
                                    row.Cells(COL_ABA_CANTIDAD_ABAS).Value = 0
                                End If
                                GrillaAsignacion.Refresh()
                            Else
                                row.Cells(COL_ABA_COD_UBI_ABAS).Value = "-"
                                row.Cells(COL_ABA_UBICACION_ABAS).Value = "SIN UBICACIÓN"
                                row.Cells(COL_ABA_PALLET_ABAS).Value = "-"
                                row.Cells(COL_ABA_CANTIDAD_ABAS).Value = 0
                                GrillaAsignacion.Refresh()
                                ds = Nothing
                            End If
                        Else
                            ds = Nothing
                            MessageBox.Show(_msgError + "\GENERA_ORDEN_ABASTECIMIENTO", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            If conexion.State = ConnectionState.Open Then
                                conexion.Close()
                            End If
                            ds = Nothing
                            Me.Cursor = Cursors.Default
                            Exit Function
                        End If
                    End If
                    ProgressBar1.Value += 1
                Next

                _msgError = ""
                If GUARDA_ORDEN_REABASTECIMIENTO_ENCABEZADO(ESTADO_ORDEN_REABASTECIMIENTO.PENDIENTE, conexion) = False Then
                    Exit Function
                Else
                    _eab_codigo = ESTADO_ORDEN_REABASTECIMIENTO.PENDIENTE
                    If GUARDA_ORDEN_REABASTECIMIENTO_DETALLE(conexion) = False Then
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        ds = Nothing
                        Me.Cursor = Cursors.Default
                        Exit Function
                    End If
                End If

                If GUARDA_ABASTECIMIENTO_OPERARIOS(conexion) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If
                    'txtNumRec.Text = 0
                    ds = Nothing
                    Exit Function
                End If

                GrillaAsignacion.Columns(COL_ABA_PROCESADO).Visible = True
                GrillaAsignacion.Columns(COL_ABA_UBICADO).Visible = True

                Call CONFIGURA_COLUMNAS_ABASTECIMIENTO()


                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing
                Me.Cursor = Cursors.Default

                ProgressBar1.Visible = False

                MessageBox.Show("Orden de abastecimiento generada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Using

            'If VERIFICA_UBICACIONES() = True Then
            '    MessageBox.Show("La asignación fue guardada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    btnImprimeIdentificador.Enabled = True
            '    GENERA_ASIGNACION_UBICACION = True
            'Else
            '    MessageBox.Show("Existen registros que no tiene ubicación asignada, contacte al administrador del sistema", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    GENERA_ASIGNACION_UBICACION = False
            'End If


            'ProgressBar1.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function GUARDA_ABASTECIMIENTO_OPERARIOS(ByVal conexion As SqlConnection) As Boolean
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet

        GUARDA_ABASTECIMIENTO_OPERARIOS = False
        Try
            'ELIMINA OPERADORES ASOCIADOS
            classUbicacion.oab_codigo = CInt(txtNumAsi.Text)
            ds = classUbicacion.ASIGNACION_ABASTECIMIENTO_RESPONSABLE_ELIMINA(_msgError, conexion)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            Else
                If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ds = Nothing
                    Exit Function
                End If
            End If

            'GUARDA OPERADORES SELECCIONADOS
            For Each row2 As DataGridViewRow In Me.GrillaOperario.Rows
                ds = Nothing
                If row2.Cells(1).Value = True Then
                    classUbicacion.oab_codigo = CInt(txtNumAsi.Text)
                    classUbicacion.usu_codigo = row2.Cells(0).Value
                    ds = classUbicacion.ASIGNACION_ABASTECIMIENTO_RESPONSABLE_GUARDAR(_msgError, conexion)
                    If _msgError <> "" Then
                        ds = Nothing
                        MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    Else
                        If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                            MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ds = Nothing
                            Exit Function
                        End If
                    End If
                End If
            Next

            GUARDA_ABASTECIMIENTO_OPERARIOS = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function GUARDA_ORDEN_REABASTECIMIENTO_DETALLE(ByVal conexion As SqlConnection) As Boolean
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim tmp_llave_pallet As String = ""
        GUARDA_ORDEN_REABASTECIMIENTO_DETALLE = False
        Try
            For Each row2 As DataGridViewRow In Me.GrillaAsignacion.Rows
                classUbicaciones.oab_codigo = _oab_codigo
                classUbicaciones.dab_fila = row2.Cells(COL_ABA_FILA).Value
                classUbicaciones.pro_codigo = row2.Cells(COL_ABA_PRO_CODIGO).Value
                classUbicaciones.pro_codigointerno = row2.Cells(COL_ABA_PRO_CODIGO_INTERNO).Value
                classUbicaciones.bulto = row2.Cells(COL_ABA_BULTO).Value
                classUbicaciones.dab_codigo_ubicacion_pk = row2.Cells(COL_ABA_COD_UBICACION).Value
                classUbicaciones.dab_nombre_ubicacion_pk = row2.Cells(COL_ABA_UBICACION_PK).Value
                classUbicaciones.dab_pallet_pk = row2.Cells(COL_ABA_PALLET).Value
                classUbicaciones.dab_cantidad_pk = row2.Cells(COL_ABA_CANTIDAD).Value
                classUbicaciones.dab_codigo_ubicacion_aba = row2.Cells(COL_ABA_COD_UBI_ABAS).Value
                classUbicaciones.dab_nombre_ubicacion_aba = row2.Cells(COL_ABA_UBICACION_ABAS).Value
                classUbicaciones.dab_pallet_aba = row2.Cells(COL_ABA_PALLET_ABAS).Value
                classUbicaciones.dab_cantidad_aba = row2.Cells(COL_ABA_CANTIDAD_ABAS).Value
                classUbicaciones.dab_procesado = row2.Cells(COL_ABA_PROCESADO).Value
                classUbicaciones.dab_cantidad_original = row2.Cells(COL_CAN_ORIGINAL).Value
                ds = classUbicaciones.GUARDA_ORDEN_ABASTECIMIENTO_DETALLE(_msgError, conexion)
                If _msgError <> "" Then
                    ds = Nothing
                    MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                Else
                    If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                        MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ds = Nothing
                        Exit Function
                    End If
                End If
            Next

            GUARDA_ORDEN_REABASTECIMIENTO_DETALLE = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function GUARDA_ORDEN_REABASTECIMIENTO_ENCABEZADO(ByVal codEstadoOrden As Integer, ByVal conexion As SqlConnection) As Boolean
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet

        GUARDA_ORDEN_REABASTECIMIENTO_ENCABEZADO = False

        Try
            'Guarda cabecera del documento
            ds = Nothing
            classUbicaciones.oab_codigo = _oab_codigo
            classUbicaciones.oab_observacion = txtObservación.Text
            classUbicaciones.oab_fecha = TxtFechaOab.Value
            classUbicaciones.eab_codigo = codEstadoOrden

            ds = classUbicaciones.GUARDA_ORDEN_ABASTECIMIENTO_ENCABEZADO(_msgError, conexion)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            Else
                If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ds = Nothing
                    Exit Function
                Else
                    txtNumAsi.Text = ds.Tables(0).Rows(0)("CODIGO")
                    _oab_codigo = ds.Tables(0).Rows(0)("CODIGO")
                End If
            End If

            GUARDA_ORDEN_REABASTECIMIENTO_ENCABEZADO = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub btnImprimeIdentificador_Click(sender As Object, e As EventArgs) Handles btnImprimeIdentificador.Click
        Dim frm As frm_imprimir = New frm_imprimir
        frm.Origen = "OAB"
        frm.oab_codigo = _oab_codigo
        frm.ShowDialog()
    End Sub

    Private Sub GrillaAsignacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaAsignacion.CellContentClick
        Try
            If e.ColumnIndex = Me.GrillaAsignacion.Columns.Item(COL_ABA_PROCESADO).Index Then
                Dim chkCell As DataGridViewCheckBoxCell = Me.GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_PROCESADO)
                chkCell.Value = Not chkCell.Value

                If GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_PROCESADO).Value = True Then
                    If GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_SIN_PROCESAR).Value = True Then
                        GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_PROCESADO).Value = False
                    End If

                    If GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_PROCESADO).Value = True Then
                        If GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_VACIA).Value = True Then
                            GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_PROCESADO).Value = False
                        End If
                    End If
                End If

            End If


            If e.ColumnIndex = COL_ABA_UBICADO Then
                Dim _filaSeleccionada As Integer = 0
                Dim fila As Integer = 0

                _distintoPallet = False
                _distintaCantidad = False

                Dim frm As frm_modifica_registro = New frm_modifica_registro
                frm.cnn = _cnn
                _filaSeleccionada = GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_FILA).Value
                frm.strUbicacion = GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_COD_UBI_ABAS).Value
                frm.strUbicacionPK = GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_COD_UBICACION).Value
                frm.palletABA = GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_PALLET_ABAS).Value

                frm.ShowDialog()

                If _distintoPallet = True And _distintaCantidad = False Then
                    GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_SIN_PROCESAR).Value = True
                    GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_SIN_NEW_CANTIDAD).Value = 0
                    GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_PROCESADO).Value = False
                    GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_PALLET_PISO).Value = _palletPiso

                    GrillaAsignacion.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.NavajoWhite
                    GrillaAsignacion.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black

                ElseIf _distintoPallet = False And _distintaCantidad = True Then
                    GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_SIN_PROCESAR).Value = False
                    GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_CANTIDAD_ABAS).Value = _nuevaCantidadActualizada
                    GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_PROCESADO).Value = True

                    GrillaAsignacion.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 82)
                    GrillaAsignacion.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
                End If

                If GLO_MUEVE_PALLET_PRODUCTO_EXTRAVIADO = True Then
                    GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_VACIA).Value = True
                    GrillaAsignacion.Rows(e.RowIndex).Cells(COL_ABA_SIN_PROCESAR).Value = False
                    Call PINTA_CELDA_GRIS(e.RowIndex)
                    GLO_MUEVE_PALLET_PRODUCTO_EXTRAVIADO = False

                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PINTA_CELDA_GRIS(ByVal fila As Integer)
        GrillaAsignacion.Item(COL_ABA_FILA, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_FILA, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_PRO_CODIGO, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_PRO_CODIGO, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_PRO_CODIGO_INTERNO, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_PRO_CODIGO_INTERNO, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_BULTO, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_BULTO, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_COD_UBICACION, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_COD_UBICACION, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_UBICACION_PK, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_UBICACION_PK, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_PALLET, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_PALLET, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_CANTIDAD, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_CANTIDAD, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_COD_UBI_ABAS, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_COD_UBI_ABAS, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_UBICACION_ABAS, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_UBICACION_ABAS, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_PALLET_ABAS, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_PALLET_ABAS, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_CANTIDAD_ABAS, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_CANTIDAD_ABAS, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_PROCESADO, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_PROCESADO, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_UBICADO, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_UBICADO, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_SIN_PROCESAR, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_SIN_PROCESAR, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_SIN_NEW_CANTIDAD, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_SIN_NEW_CANTIDAD, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_PALLET_PISO, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_PALLET_PISO, fila).Style.ForeColor = Color.White

        GrillaAsignacion.Item(COL_ABA_VACIA, fila).Style.BackColor = Color.Gray
        GrillaAsignacion.Item(COL_ABA_VACIA, fila).Style.ForeColor = Color.White

    End Sub

    Private Sub btnFinaliza_Click(sender As Object, e As EventArgs) Handles btnFinaliza.Click
        Dim contador As Integer = 0
        Try

            If _eab_codigo = ESTADO_ORDEN_REABASTECIMIENTO.ANULADA Then
                MessageBox.Show("No es posible FINALIZAR una orden de abastecimiento en estado ANULADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If GrillaAsignacion.RowCount = 1 Then
                If (GrillaAsignacion.Rows(0).Cells(COL_ABA_PROCESADO).Value = False) And (GrillaAsignacion.Rows(0).Cells(COL_ABA_PALLET_PISO).Value.ToString = "") Then
                    contador = 0
                Else
                    contador = 1
                End If
            Else
                For Each row As DataGridViewRow In Me.GrillaAsignacion.Rows
                    If (row.Cells(COL_ABA_PROCESADO).Value = True) And (row.Cells(COL_ABA_PALLET_PISO).Value.ToString = "") Then
                        contador = contador + 1
                    End If
                Next
            End If

            If contador = 0 Then
                MessageBox.Show("No existe ningun registro marcado como procesado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            If FINALIZA_ORDEN_ABASTECIMIENTO() = True Then
                MessageBox.Show("Orden de abastecimiento finalizada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnFinaliza.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Private Function FINALIZA_ORDEN_ABASTECIMIENTO() As Boolean
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        Dim contador As Integer = 0
        Dim cantidadOrigen As Integer = 0
        Dim cantidadFinal As Integer = 0
        Dim Cantidad As Integer
        Dim cantidad_original As Integer = 0

        FINALIZA_ORDEN_ABASTECIMIENTO = False

        Try
            Me.Cursor = Cursors.WaitCursor
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                classUbicaciones.cnn = _cnn

                _msgError = ""
                If GUARDA_ORDEN_REABASTECIMIENTO_ENCABEZADO(ESTADO_ORDEN_REABASTECIMIENTO.FINALIZADA, conexion) = False Then
                    Exit Function
                Else
                    _eab_codigo = ESTADO_ORDEN_REABASTECIMIENTO.PENDIENTE
                    If GUARDA_ORDEN_REABASTECIMIENTO_DETALLE(conexion) = False Then
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        ds = Nothing
                        Me.Cursor = Cursors.Default
                        Exit Function
                    End If
                End If

                For Each row As DataGridViewRow In Me.GrillaAsignacion.Rows
                    If row.Cells(2).Value = "182331" Then
                        cantidadFinal = cantidadFinal
                    End If

                    If row.Cells(COL_ABA_VACIA).Value = True Then
                        Cantidad = 0
                        Cantidad = row.Cells(COL_ABA_CANTIDAD_ABAS).Value
                        If MOVIMIENTO_A_PISO_EXTRAVIADO(conexion, row.Cells(COL_ABA_PRO_CODIGO).Value, Cantidad, CInt(Mid(row.Cells(COL_ABA_BULTO).Value, 1, 2)), row.Cells(COL_ABA_PALLET_ABAS).Value) = True Then
                            If GUARDA_MOVIMIENTO(conexion, row.Cells(COL_ABA_PALLET).Value, Cantidad, row.Cells(COL_ABA_PRO_CODIGO).Value, CInt(Mid(row.Cells(COL_ABA_BULTO).Value, 1, 2)), Cantidad) = False Then
                                ds = Nothing
                                Exit Function
                            End If
                        Else
                            ds = Nothing
                            Exit Function
                        End If
                    Else

                        If row.Cells(COL_ABA_PALLET_PISO).Value <> "" Then
                            If ENVIA_PALLET_A_PT(row.Cells(COL_ABA_PALLET_PISO).Value, conexion) = False Then
                                If conexion.State = ConnectionState.Open Then
                                    conexion.Close()
                                End If
                                Exit Function
                            End If
                        Else
                            If row.Cells(COL_ABA_PALLET).Value <> "" Then
                                cantidadOrigen = 0
                            Else
                                cantidadOrigen = row.Cells(COL_ABA_CANTIDAD).Value
                            End If

                            cantidadFinal = CInt(row.Cells(COL_ABA_CANTIDAD_ABAS).Value) + cantidadOrigen

                            classUbicaciones.dab_pallet_pk = row.Cells(COL_ABA_PALLET).Value
                            classUbicaciones.dab_pallet_aba = row.Cells(COL_ABA_PALLET_ABAS).Value
                            classUbicaciones.dab_cantidad_aba = row.Cells(COL_ABA_CANTIDAD_ABAS).Value
                            classUbicaciones.dab_codigo_ubicacion_pk = row.Cells(COL_ABA_COD_UBICACION).Value
                            classUbicaciones.dab_codigo_ubicacion_aba = row.Cells(COL_ABA_COD_UBI_ABAS).Value

                            ds = Nothing
                            ds = classUbicaciones.ACTUALIZA_CANTIDADES_UBICACIONES_PALLET(_msgError, conexion)
                            If _msgError = "" Then
                                If ds.Tables(0).Rows.Count > 0 Then
                                    If ds.Tables(0).Rows(0)("mensaje") <> "ok" Then
                                        ds = Nothing
                                        Me.Cursor = Cursors.Default
                                        MessageBox.Show(ds.Tables(0).Rows(0)("mensaje") + "\FINALIZA_ORDEN_ABASTECIMIENTO", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        If conexion.State = ConnectionState.Open Then
                                            conexion.Close()
                                        End If
                                        Exit Function
                                    End If
                                End If
                            Else
                                ds = Nothing
                                Me.Cursor = Cursors.Default
                                MessageBox.Show(_msgError + "\FINALIZA_ORDEN_ABASTECIMIENTO", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                If conexion.State = ConnectionState.Open Then
                                    conexion.Close()
                                End If
                                Exit Function
                            End If
                        End If


                        Cantidad = 0
                        Cantidad = row.Cells(COL_ABA_CANTIDAD_ABAS).Value
                        cantidad_original = row.Cells(COL_CAN_ORIGINAL).Value

                        If cantidad_original > Cantidad Then
                            If MOVIMIENTO_A_PISO_EXTRAVIADO(conexion, row.Cells(COL_ABA_PRO_CODIGO).Value, (cantidad_original - Cantidad), CInt(Mid(row.Cells(COL_ABA_BULTO).Value, 1, 2)), row.Cells(COL_ABA_PALLET_ABAS).Value) = True Then
                                If GUARDA_MOVIMIENTO(conexion, row.Cells(COL_ABA_PALLET).Value, Cantidad, row.Cells(COL_ABA_PRO_CODIGO).Value, CInt(Mid(row.Cells(COL_ABA_BULTO).Value, 1, 2)), Cantidad) = False Then
                                    ds = Nothing
                                    Exit Function
                                End If
                            Else
                                ds = Nothing
                                Exit Function
                            End If
                        End If





                    End If
                Next

                GrillaAsignacion.Columns(COL_ABA_PROCESADO).Visible = False
                GrillaAsignacion.Columns(COL_ABA_UBICADO).Visible = False

                Call CONFIGURA_COLUMNAS_ABASTECIMIENTO()


                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing
                Me.Cursor = Cursors.Default

                FINALIZA_ORDEN_ABASTECIMIENTO = True

            End Using

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            FINALIZA_ORDEN_ABASTECIMIENTO = False
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function MOVIMIENTO_A_PISO_EXTRAVIADO(ByVal conexion As SqlConnection, ByVal _pro_codigo As Integer, ByVal _cantidad As Integer,
                                                  ByVal _num_bulto As Integer, ByVal _palletRequerido As String) As Boolean
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet

        MOVIMIENTO_A_PISO_EXTRAVIADO = False

        Try
            'Guarda cabecera del documento
            ds = Nothing
            classUbicaciones.cnn = _cnn
            classUbicaciones.palletSuelo = GLO_PALLET_PISO_EXTRAVIADO
            classUbicaciones.pro_codigo = _pro_codigo
            classUbicaciones.cantidad = _cantidad
            classUbicaciones.num_bulto = _num_bulto
            classUbicaciones.palletRequerido = _palletRequerido

            ds = classUbicaciones.MOVIMIENTO_A_PISO_EXTRAVIADO(_msgError, conexion)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            Else
                If ds.Tables(0).Rows(0)("codigo") < 0 Then
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ds = Nothing
                    Exit Function
                End If
            End If
            MOVIMIENTO_A_PISO_EXTRAVIADO = True
        Catch ex As Exception
            MOVIMIENTO_A_PISO_EXTRAVIADO = False
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function GUARDA_MOVIMIENTO(ByVal conexion As SqlConnection, ByVal _palletRequerido As String, ByVal Cantidad As Integer,
                                       ByVal _pro_codigo As Integer, ByVal _cod_bulto As Integer, ByVal _cantidadPallet As Integer) As Boolean
        Dim classMOV As class_movimientos = New class_movimientos
        Dim classInv As class_inventario = New class_inventario
        'Dim class_recepcion As class_recepcion = New class_recepcion
        Dim classRecepcion As class_recepcion = New class_recepcion
        Dim ds As DataSet = New DataSet
        Dim dsDetalle As DataSet = New DataSet
        Dim dsInventario As DataSet = New DataSet
        Dim dsMov As DataSet = New DataSet
        Dim _numCantidadBultos As Integer = 0

        Dim _Folio As Integer = 0
        Dim _FolioRelacionado As Integer = 0
        Dim fila As Integer = 0
        Dim mes As String = ""
        Dim dia As String = ""
        Dim _msgError As String = ""
        Dim scopeOptions = New TransactionOptions()
        Dim _fecha As Date
        'Dim cantidad As Integer = 0
        Dim sumaCantidad As Integer = 0
        Dim seriePallet As String = ""

        Dim _Observacion As String

        GUARDA_MOVIMIENTO = False


        Try
            _Observacion = "MOVIMIENTO GENERADO A TRAVEZ DEL MOVIMIENTO DE PALLET:  " + _palletRequerido + " POR NO ENCONTRASE FISICAMENTE EN LA UBICACIÓN"

            _fecha = GLO_FECHA_SISTEMA

            If CStr(_fecha.Month).Length = 1 Then
                mes = Trim("0" + CStr(_fecha.Month))
            Else
                mes = CStr(_fecha.Month)
            End If


            'SALIDA DE BODEGA DE ORIGEN
            '=============================================================
            If GUARDA_ENC_MOVIMINETO(conexion, 0, TIPO_MOVIMIENTO.SALIDA, GLO_BODEGA_PRODUCTO_TERMINADO, _fecha, mes, _fecha.Year, GLO_USUARIO_ACTUAL, 0,
                                         COM_TIPO_DOCUMENTO.VALE_DE_SALIDA, 0, 0, _Observacion, "-", 0, _Folio) = False Then
                Return False
                Exit Function
            End If

            _FolioRelacionado = _Folio

            If ELIMINA_DETALLE_MOVIMIENTO(conexion, _Folio) = False Then
                Return False
                Exit Function
            End If

            fila = 0
            If GUARDA_DET_MOVIMINETO(conexion, _Folio, _pro_codigo, Cantidad, _cod_bulto, _cantidadPallet) = False Then
                Return False
                Exit Function
            End If

            If ACTUALIZA_STOCK_BODEGA(conexion, GLO_BODEGA_PRODUCTO_TERMINADO, _pro_codigo, TIPO_MOVIMIENTO.SALIDA, Cantidad) = False Then
                Return False
                Exit Function
            End If

            'FIN SALIDA DE BODEGA DE ORIGEN
            '=============================================================

            'ENTRADA A BODEGA DE DESTINO
            '=============================================================
            _Folio = 0
            If GUARDA_ENC_MOVIMINETO(conexion, 0, TIPO_MOVIMIENTO.ENTRADA, GLO_BODEGA_PRODUCTO_EXTRAVIADOS, _fecha, mes, _fecha.Year, GLO_USUARIO_ACTUAL, 0,
                                         COM_TIPO_DOCUMENTO.VALE_DE_INGRESO, 0, _FolioRelacionado, _Observacion, "", 0, _Folio) = False Then
                Return False
                Exit Function
            End If

            If ELIMINA_DETALLE_MOVIMIENTO(conexion, _Folio) = False Then
                Return False
                Exit Function
            End If

            If GUARDA_DET_MOVIMINETO(conexion, _Folio, _pro_codigo, Cantidad, _cod_bulto, _cantidadPallet) = False Then
                Return False
                Exit Function
            End If

            If ACTUALIZA_STOCK_BODEGA(conexion, GLO_BODEGA_PRODUCTO_EXTRAVIADOS, _pro_codigo, TIPO_MOVIMIENTO.ENTRADA, Cantidad) = False Then
                Return False
                Exit Function
            End If



            GUARDA_MOVIMIENTO = True


        Catch ex As Exception
            GUARDA_MOVIMIENTO = False
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function ENVIA_PALLET_A_PT(ByVal strPallet As String, ByVal conexion As SqlConnection) As Boolean
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet

        ENVIA_PALLET_A_PT = False

        Try
            'Guarda cabecera del documento
            ds = Nothing
            classUbicaciones.pallet = strPallet
            classUbicaciones.ubi_codigo = GLO_UBI_PISO_PRODUCTO_TERMINADO
            classUbicaciones.diasUbicacion = True
            ds = classUbicaciones.ACTUALIZA_UBICACIONES_A_PISO_PT(_msgError, conexion)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            Else
                If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ds = Nothing
                    Exit Function
                End If
            End If

            ENVIA_PALLET_A_PT = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnAnulaOrden_Click(sender As Object, e As EventArgs) Handles btnAnulaOrden.Click
        Dim respuesta As Integer = 0

        If _eab_codigo = ESTADO_ORDEN_REABASTECIMIENTO.FINALIZADA Then
            MessageBox.Show("No es posible ANULAR una orden de abastecimiento en estado FINALIZADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        respuesta = MessageBox.Show("¿Esta seguro(a) de anular la orden de abastecimiento?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = vbNo Then
            Exit Sub
        End If

        Call ANULA_ORDEN()
    End Sub

    Private Sub ANULA_ORDEN()
        Dim class_ubicacion As class_ubicaciones = New class_ubicaciones
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim _msg As String = ""

        Try
            ds = Nothing
            class_ubicacion.cnn = _cnn
            class_ubicacion.oab_codigo = _oab_codigo

            ds = class_ubicacion.ANULA_ORDEN_ABASTECIMIENTO(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            MessageBox.Show("El registro fue eliminado en forma excelente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAsigna.Enabled = False
            btnFinaliza.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub GrillaOperario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaOperario.CellContentClick
        Dim chkCell As DataGridViewCheckBoxCell = Me.GrillaOperario.Rows(e.RowIndex).Cells(1)
        If e.ColumnIndex = Me.GrillaOperario.Columns.Item(1).Index Then
            chkCell.Value = Not chkCell.Value
        End If
    End Sub
End Class