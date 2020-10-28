Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Threading
Public Class frm_movimientos_entre_pisos
    Dim listaDetalleParaRack As List(Of class_estructura_movimiento_rack)
    Dim _cnn As String
    Dim _omo_codigo As Integer
    Dim _eom_codigo As Integer
    Private cellTextBox As DataGridViewTextBoxEditingControl
    Dim PrecionaTeclaDesde As String = ""
    Dim PrimeraVez As Boolean
    Dim Pestana As String = ""
    Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Property omo_codigo() As Integer
        Get
            Return _omo_codigo
        End Get
        Set(ByVal value As Integer)
            _omo_codigo = value
        End Set
    End Property
    Property eom_codigo() As Integer
        Get
            Return _eom_codigo
        End Get
        Set(ByVal value As Integer)
            _eom_codigo = value
        End Set
    End Property

    Const COL_GRI_SELECCION As Integer = 0
    Const COL_GRI_FILA As Integer = 1
    Const COL_GRI_PROCODIGO As Integer = 2
    Const COL_GRI_PALLPISO As Integer = 3
    Const COL_GRI_PALLET As Integer = 4
    Const COL_GRI_CODIGO As Integer = 5
    Const COL_GRI_PRODUCTO As Integer = 6
    Const COL_GRI_PROBULTO As Integer = 7
    Const COL_GRI_BULTO As Integer = 8
    Const COL_GRI_CANTORIG As Integer = 9
    Const COL_GRI_CANTIDAD As Integer = 10
    Const COL_GRI_CANTMOVIL As Integer = 11
    Const COL_GRI_SELECT As Integer = 12

    Const COL_RAC_SELECCION As Integer = 0
    Const COL_RAC_FILA As Integer = 1
    Const COL_RAC_UBICODIGO As Integer = 2
    Const COL_RAC_UBINOMBRE As Integer = 3
    Const COL_RAC_PALLET As Integer = 4
    Const COL_RAC_PROCODINT As Integer = 5
    Const COL_RAC_PROCODIGO As Integer = 6
    Const COL_RAC_PRONOMBRE As Integer = 7
    Const COL_RAC_CODBULTO As Integer = 8
    Const COL_RAC_BULTO As Integer = 9
    Const COL_RAC_CANTIDAD As Integer = 10
    Const COL_rac_SELECT As Integer = 11
    Const COL_RAC_UBICODIGO2 As Integer = 12
    Const COL_RAC_UBINOMBRE2 As Integer = 13


    Const COL_GRA_SELECCION As Integer = 0
    Const COL_GRA_FILAR As Integer = 1
    Const COL_GRA_FILA As Integer = 2
    Const COL_GRA_PROCODIGO As Integer = 3
    Const COL_GRA_PALORIGEN As Integer = 4
    Const COL_GRA_PALLET As Integer = 5
    Const COL_GRA_CODIGO As Integer = 6
    Const COL_GRA_PRODUCTO As Integer = 7
    Const COL_GRA_PROBULTO As Integer = 8
    Const COL_GRA_BULTO As Integer = 9
    Const COL_GRA_CANTIDAD As Integer = 10
    Const COL_GRA_CODUBICA As Integer = 11
    Const COL_GRA_UBICACION As Integer = 12
    Const COL_GRA_QUITAR As Integer = 13

    Private Sub frm_movimientos_entre_pisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrimeraVez = False
        btnAsigna.Enabled = False
        btnEnviar.Enabled = False
        btnAprueba.Visible = False
        btnRechaza.Visible = False
        txtValeManager.Enabled = False
        btnGuardaVale.Enabled = False

        listaDetalleParaRack = New List(Of class_estructura_movimiento_rack)()
        TabPage2.Parent = Nothing 'PESTAÑA DE ALMACENAMIENTO EN RACK
        TabPage3.Parent = Nothing 'PESTAÑA DE RACK
        Call CARGA_COMBO_RESPONSABLE_MOVIMIENTO()
        cmbPersonas.SelectedValue = GLO_USUARIO_ACTUAL

        Call CARGA_COMBO_ESTADO_MOVIMIENTO()
        cmbEstado.SelectedValue = 0 'ESTADO_ORDEN_MOVIMIENTO.OM_GENERADA

        Call CONFIGURA_COLUMNAS()
        Call CONFIGURA_COLUMNAS_GRILLA_UBICACION()
        Call CONFIGURA_COLUMNAS_GRILLA_DESDE_RACK()

        Call CARGA_GRILLA_OPERARIO_BODEGA()
        Call CARGA_COMBO_BODEGA_ORIGEN()
        Call CARGA_COMBO_BODEGA_DESTINO()

        Call CARGA_COMBO_ZONA()
        Call CARGA_COMBO_ALTURA()

        If _eom_codigo = ESTADO_ORDEN_MOVIMIENTO.PENDIENTE_APROBACION Then
            grillaRack.Columns(COL_GRA_SELECCION).Visible = True
        End If

        If _eom_codigo = ESTADO_ORDEN_MOVIMIENTO.OM_APROBADA Then
            txtValeManager.Enabled = True
            btnGuardaVale.Enabled = True
        End If

        If GLO_USU_RESPONSABLE_MOVIMIETO = True Then
            btnAsigna.Enabled = True
        End If

        If omo_codigo > 0 Then
            Call RECARGA_DOCUMENTO()
        End If



        PrimeraVez = True
    End Sub

    Private Sub CARGA_COMBO_ALTURA()
        Dim _msg As String
        Try
            Dim classAltura As class_alturas = New class_alturas
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classAltura.cnn = _cnn
            _msg = ""
            ds = classAltura.CARGA_COMBO_ALTURA(_msg)
            If _msg = "" Then
                Me.cmbAltura.DataSource = ds.Tables(0)
                Me.cmbAltura.DisplayMember = "MENSAJE"
                Me.cmbAltura.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_ALTURA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_COMBO_ZONA()
        Dim _msg As String
        Try
            Dim classZona As class_zonas = New class_zonas
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classZona.cnn = _cnn
            _msg = ""
            ds = classZona.ZONAS_ES_RACK_CARGA_ZONAS(_msg)
            If _msg = "" Then
                Me.cmbZona.DataSource = ds.Tables(0)
                Me.cmbZona.DisplayMember = "MENSAJE"
                Me.cmbZona.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_ZONA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub


    Private Sub RECARGA_DOCUMENTO()
        btnAsigna.Enabled = False
        btnEnviar.Enabled = False
        btnAprueba.Visible = False
        btnRechaza.Visible = False

        TabPage1.Parent = Nothing
        TabPage2.Parent = TabControl1
        TabPage3.Parent = Nothing
        btnAsigna.Enabled = False
        btnEnviar.Enabled = False

        If _eom_codigo = ESTADO_ORDEN_MOVIMIENTO.PENDIENTE_APROBACION Then
            If GLO_USU_AUTORIZA_MOVIMIETO = True Then
                btnAprueba.Visible = True
                btnRechaza.Visible = True
            End If
        ElseIf _eom_codigo = ESTADO_ORDEN_MOVIMIENTO.OM_GENERADA Then
            If GLO_USU_RESPONSABLE_MOVIMIETO = True Then
                btnEnviar.Enabled = True
            End If
        End If

        grillaRack.Columns(COL_GRA_QUITAR).Visible = False
        Call CARGA_DATOS()
        Call CARGA_OPERARIO_SELECCIONADOS()
        Call DESABILITA_CONTROLES()
    End Sub

    Private Sub CARGA_OPERARIO_SELECCIONADOS()
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim Fila As Integer = 0
        Dim ds As DataSet = New DataSet
        Dim _msg As String

        Try
            If GrillaOperario.Rows.Count = 0 Then
                MessageBox.Show("No existen operarios configurados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            ds = Nothing
            classMovimiento.cnn = _cnn
            classMovimiento.omo_codigo = _omo_codigo
            _msg = ""

            GrillaOperario.DataSource = Nothing
            GrillaOperario.Rows.Clear()
            ds = classMovimiento.ORDEN_MOVIMIENTO_RESPONSABLE_BUSCAR(_msg)
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
                MessageBox.Show(_msg + "\CARGA_OPERARIO_SELECCIONADOS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_OPERARIO_SELECCIONADOS", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub DESABILITA_CONTROLES()
        lblOM.Enabled = False
        cmbPersonas.Enabled = False
        dtpDesde.Enabled = False
        cmbEstado.Enabled = False
        'txtValeManager.Enabled = False
        cmbBodegaOrigen.Enabled = False
        cmbPisoOrigen.Enabled = False
        cmbBodegaDestino.Enabled = False
        cmbPisoDestino.Enabled = False
    End Sub

    Private Sub CARGA_DATOS()
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim SearchChar As String = "-"
        Dim TestPos As Integer = 0
        Dim Fila As Integer = 0

        Dim diaASDesde As String = ""
        Dim mesASDesde As String = ""

        Dim diaASHasta As String = ""
        Dim mesASHasta As String = ""


        Dim diaASDesdeDespacho As String = ""
        Dim mesASDesdeDespacho As String = ""

        Dim diaASHastaDespacho As String = ""
        Dim mesASHastaDespacho As String = ""


        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String

            ds = Nothing
            classMovimiento.cnn = _cnn
            classMovimiento.omo_codigo = _omo_codigo
            classMovimiento.emo_codigo = 0
            classMovimiento.fecha_desde = "19000101"
            classMovimiento.fecha_hasta = "20501231"
            classMovimiento.bod_codigoorigen = 0
            classMovimiento.ubi_codigoorigen = 0
            classMovimiento.bod_codigodestino = 0
            classMovimiento.ubi_codigodestino = 0
            classMovimiento.Listado = False
            _msg = ""
            grillaRack.Rows.Clear()
            ds = classMovimiento.ORDEN_MOVIMIENTO_LISTAR(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("omo_codigo") > 0 Then
                        lblOM.Text = ds.Tables(0).Rows(Fila)("omo_codigostr")
                        cmbPersonas.SelectedValue = ds.Tables(0).Rows(Fila)("usu_codigo")
                        dtpDesde.Value = ds.Tables(0).Rows(Fila)("omo_fechadocto")
                        cmbEstado.SelectedValue = ds.Tables(0).Rows(Fila)("eom_codigo")
                        txtValeManager.Text = ds.Tables(0).Rows(Fila)("omo_valemanager")
                        cmbBodegaOrigen.SelectedValue = ds.Tables(0).Rows(Fila)("bod_codigoorigen")

                        Call CARGA_COMBO_PISO_ORIGEN()
                        cmbPisoOrigen.SelectedValue = ds.Tables(0).Rows(Fila)("ubi_codigoorigen")

                        cmbBodegaDestino.SelectedValue = ds.Tables(0).Rows(Fila)("bod_codigodestino")

                        Call CARGA_COMBO_PISO_DESTINO()
                        cmbPisoDestino.SelectedValue = ds.Tables(0).Rows(Fila)("ubi_codigodestino")

                        Do While Fila < ds.Tables(0).Rows.Count
                            grillaRack.Rows.Add(False, ds.Tables(0).Rows(Fila)("ode_fila"),
                                            0,
                                            ds.Tables(0).Rows(Fila)("pro_codigo"),
                                            ds.Tables(0).Rows(Fila)("ode_palletorigen"),
                                            ds.Tables(0).Rows(Fila)("ode_pallet"),
                                            ds.Tables(0).Rows(Fila)("pro_codigointerno"),
                                            ds.Tables(0).Rows(Fila)("pro_nombre"),
                                            ds.Tables(0).Rows(Fila)("bul_codigo"),
                                            ds.Tables(0).Rows(Fila)("ode_bulto"),
                                            ds.Tables(0).Rows(Fila)("ode_cantidad"),
                                            ds.Tables(0).Rows(Fila)("ubi_codigo"),
                                            ds.Tables(0).Rows(Fila)("ubi_nombre"),
                                            "")
                            Fila = Fila + 1
                        Loop

                        Call CONFIGURA_COLUMNAS_GRILLA_UBICACION()
                    End If
                End If

            Else
                MessageBox.Show(_msg + "\CARGA_GRILLA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_COMBO_ESTADO_MOVIMIENTO()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            _msg = ""
            ds = classMovimiento.CARGA_COMBO_ORDEN_MOVIMIENTO_ESTADO(_msg)
            If _msg = "" Then
                Me.cmbEstado.DataSource = ds.Tables(0)
                Me.cmbEstado.DisplayMember = "mensaje"
                Me.cmbEstado.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_ESTADO_MOVIMIENTO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_COMBO_RESPONSABLE_MOVIMIENTO()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            _msg = ""
            ds = classMovimiento.RESPONSABLE_MOVIMIENTO_CARGA_COMBO(_msg)
            If _msg = "" Then
                Me.cmbPersonas.DataSource = ds.Tables(0)
                Me.cmbPersonas.DisplayMember = "mensaje"
                Me.cmbPersonas.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_RESPONSABLE_MOVIMIENTO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_COMBO_BODEGA_ORIGEN()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            _msg = ""
            ds = classMovimiento.CARGA_COMBO_ORIGEN(_msg)
            If _msg = "" Then
                Me.cmbBodegaOrigen.DataSource = ds.Tables(0)
                Me.cmbBodegaOrigen.DisplayMember = "mensaje"
                Me.cmbBodegaOrigen.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_BODEGA_ORIGEN", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_COMBO_BODEGA_DESTINO()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            _msg = ""
            ds = classMovimiento.CARGA_COMBO_ORIGEN(_msg)
            If _msg = "" Then
                Me.cmbBodegaDestino.DataSource = ds.Tables(0)
                Me.cmbBodegaDestino.DisplayMember = "mensaje"
                Me.cmbBodegaDestino.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_BODEGA_DESTINO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CONFIGURA_COLUMNAS()
        GrillaDetalle.Columns(COL_GRI_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_FILA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_PROCODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_PALLPISO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_PALLET).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_CODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_PRODUCTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_PROBULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_BULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_CANTMOVIL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_SELECT).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub CONFIGURA_COLUMNAS_GRILLA_UBICACION()
        grillaRack.Columns(COL_GRA_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaRack.Columns(COL_GRA_FILA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaRack.Columns(COL_GRA_PROCODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaRack.Columns(COL_GRA_PALLET).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaRack.Columns(COL_GRA_CODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaRack.Columns(COL_GRA_PRODUCTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaRack.Columns(COL_GRA_PROBULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaRack.Columns(COL_GRA_BULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaRack.Columns(COL_GRA_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaRack.Columns(COL_GRA_UBICACION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaRack.Columns(COL_GRA_QUITAR).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub CONFIGURA_COLUMNAS_GRILLA_DESDE_RACK()
        grillaDesdeRack.Columns(COL_RAC_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_FILA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_UBICODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_UBINOMBRE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_PALLET).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_PROCODINT).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_PROCODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_PRONOMBRE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_CODBULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_BULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_rac_SELECT).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_UBICODIGO2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDesdeRack.Columns(COL_RAC_UBINOMBRE2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub cmbBodegaOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodegaOrigen.SelectedIndexChanged

    End Sub

    Private Sub cmbBodegaOrigen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbBodegaOrigen.SelectionChangeCommitted
        If cmbBodegaOrigen.SelectedValue > 0 Then
            Call CARGA_COMBO_PISO_ORIGEN()
        End If
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

    Private Sub CARGA_COMBO_PISO_ORIGEN()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            classMovimiento.bod_codigo = cmbBodegaOrigen.SelectedValue
            _msg = ""
            ds = classMovimiento.CARGA_UBICACION_ORIGEN(_msg)
            If _msg = "" Then
                Me.cmbPisoOrigen.DataSource = ds.Tables(0)
                Me.cmbPisoOrigen.DisplayMember = "mensaje"
                Me.cmbPisoOrigen.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_PISO_ORIGEN", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cmbPisoOrigen.SelectedValue = 0 Then
            MessageBox.Show("Debe seleccionar un piso de origen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        listaDetalleParaRack = New List(Of class_estructura_movimiento_rack)()
        Pestana = "DE"
        Call CARGA_PRODUCTOS()
    End Sub

    Private Sub CARGA_PRODUCTOS()
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim Fila As Integer = 0
        Dim msgError As String = ""
        Dim Cantidad As Integer = 0
        Dim cantDevuelta As Integer = 0
        Dim canDevuletaAcumulada As Integer = 0
        Try
            Dim ds As DataSet = New DataSet
            ds = Nothing
            GrillaDetalle.Rows.Clear()
            msgError = ""

            classMovimiento.cnn = _cnn
            classMovimiento.ubi_codigo = cmbPisoOrigen.SelectedValue

            If txtCodigo.Text = "0" Or txtCodigo.Text = "" Then
                classMovimiento.codigo = "-"
            Else
                classMovimiento.codigo = txtCodigo.Text
            End If

            If txtNombre.Text = "0" Or txtNombre.Text = "" Then
                classMovimiento.nombre = "-"
            Else
                classMovimiento.nombre = txtNombre.Text
            End If

            If cmbPisoDestino.SelectedValue = PISO_DESTINO.UBICACION_PICKING Then
                classMovimiento.paraUbicacionPK = True
            Else
                classMovimiento.paraUbicacionPK = False
            End If

            ds = classMovimiento.CARGA_PRODUCTO_ORIGEN(msgError)
            If msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("pro_nombre") <> "" Then
                        canDevuletaAcumulada = 0
                        Do While Fila < ds.Tables(0).Rows.Count
                            Cantidad = 0
                            cantDevuelta = 0
                            Cantidad = ds.Tables(0).Rows(Fila)("cantidad")
                            If BuscarItem(Fila, ds.Tables(0).Rows(Fila)("pro_codigo"), ds.Tables(0).Rows(Fila)("pro_bulto"), cantDevuelta) = False Then
                                Cantidad = ds.Tables(0).Rows(Fila)("cantidad")
                            Else
                                Cantidad = ds.Tables(0).Rows(Fila)("cantidad") - cantDevuelta
                            End If

                            GrillaDetalle.Rows.Add(False, Fila, ds.Tables(0).Rows(Fila)("pro_codigo"),
                                                                            ds.Tables(0).Rows(Fila)("palletPiso"),
                                                                            ds.Tables(0).Rows(Fila)("pallet"),
                                                                            ds.Tables(0).Rows(Fila)("pro_codigointerno"),
                                                                            ds.Tables(0).Rows(Fila)("pro_nombre"),
                                                                            ds.Tables(0).Rows(Fila)("pro_bulto"),
                                                                            ds.Tables(0).Rows(Fila)("bulto"),
                                                                            ds.Tables(0).Rows(Fila)("cantidad"),
                                                                            Cantidad,
                                                                            0)
                            Fila = Fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS()
                    End If
                End If
            Else
                MessageBox.Show(msgError + "\CARGA_PRODUCTOS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_PRODUCTOS", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Function BuscarItem(ByVal fila As Integer, ByVal proCodigo As Integer, ByVal bulCodigo As Integer, ByRef Cantidad As Integer) As Boolean
        'listaDetalle = New List(Of class_estructuras_embarque)()

        BuscarItem = False
        Try

            For Each d As class_estructura_movimiento_rack In listaDetalleParaRack
                If d.fila = fila And d.pro_codigo = proCodigo And d.pro_bulto = bulCodigo Then
                    Cantidad = Cantidad + d.cantidad
                    BuscarItem = True
                    'Exit Function
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub cmbBodegaDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodegaDestino.SelectedIndexChanged

    End Sub

    Private Sub CARGA_COMBO_PISO_DESTINO()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            classMovimiento.bod_codigo = cmbBodegaDestino.SelectedValue
            classMovimiento.ubi_codigo = cmbPisoOrigen.SelectedValue
            _msg = ""
            ds = classMovimiento.CARGA_UBICACION_DESTINO(_msg)
            If _msg = "" Then
                Me.cmbPisoDestino.DataSource = ds.Tables(0)
                Me.cmbPisoDestino.DisplayMember = "mensaje"
                Me.cmbPisoDestino.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_PISO_DESTINO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbBodegaDestino_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbBodegaDestino.SelectionChangeCommitted
        If cmbBodegaDestino.SelectedValue > 0 Then
            If cmbPisoOrigen.SelectedValue = 0 Then
                MessageBox.Show("Debe seleccionar el piso de origen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbPisoOrigen.Focus()
                Exit Sub
            End If

            Call CARGA_COMBO_PISO_DESTINO()

        End If
    End Sub

    Private Sub cmbPisoOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPisoOrigen.SelectedIndexChanged

    End Sub

    Private Sub cmbPisoOrigen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPisoOrigen.SelectionChangeCommitted
        If cmbPisoOrigen.SelectedValue > 0 Then
            cmbBodegaDestino.SelectedValue = 0
            cmbPisoDestino.DataSource = Nothing
            cmbPisoDestino.Items.Clear()

            grillaRack.DataSource = Nothing
            grillaRack.Rows.Clear()
            TabPage2.Parent = Nothing

            GrillaDetalle.DataSource = Nothing
            GrillaDetalle.Rows.Clear()
            TabPage1.Parent = Nothing

            TabPage3.Parent = Nothing

            If cmbPisoOrigen.SelectedValue = PISO_DESTINO.RACK Then
                TabPage3.Parent = TabControl1
            Else
                TabPage1.Parent = TabControl1
            End If


        End If
    End Sub

    Private Sub btnSeleccion_Click(sender As Object, e As EventArgs)
        'Call CargaDatosParaRack()
    End Sub

    Private Sub CargaDatosParaRack()
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim Fila As Integer = 0
        Dim ds As DataSet = New DataSet
        Dim _msg As String = ""
        Dim contador As Integer = 0

        For Each row2 As DataGridViewRow In Me.GrillaDetalle.Rows
            If row2.Cells(COL_GRI_SELECCION).Value = True Then
                classMovimiento.cnn = _cnn
                classMovimiento.fila = row2.Cells(COL_GRI_FILA).Value
                classMovimiento.pro_codigo = row2.Cells(COL_GRI_PROCODIGO).Value
                classMovimiento.bul_codigo = row2.Cells(COL_GRI_PROBULTO).Value
                classMovimiento.cantidad = row2.Cells(COL_GRI_CANTMOVIL).Value 'esta se cambia por cantidad movil
                classMovimiento.palletOrigen = row2.Cells(COL_GRI_PALLET).Value

                ds = classMovimiento.CARGA_GRILLA_PARA_ALMACENAR_EN_RACK(_msg)
                If _msg = "" Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If ds.Tables(0).Rows(Fila)("pro_nombre") <> "" Then
                            Do While Fila < ds.Tables(0).Rows.Count
                                listaDetalleParaRack.Add(New class_estructura_movimiento_rack(Fila, ds.Tables(0).Rows(Fila)("fila"), ds.Tables(0).Rows(Fila)("pro_codigo"), ds.Tables(0).Rows(Fila)("palletOrigen"),
                                                                                              ds.Tables(0).Rows(Fila)("pallet"), ds.Tables(0).Rows(Fila)("pro_codigointerno"), ds.Tables(0).Rows(Fila)("pro_nombre"),
                                                                                              ds.Tables(0).Rows(Fila)("pro_bulto"), ds.Tables(0).Rows(Fila)("bulto"), ds.Tables(0).Rows(Fila)("cantidad"), "", ""))
                                contador = contador + 1
                                Fila = Fila + 1
                            Loop
                            If contador = 0 Then
                                Exit Sub
                            End If

                            Call CargaSeleccionados()
                            Call CARGA_PRODUCTOS()
                        End If
                    End If
                Else
                    MessageBox.Show(_msg + "\CargaDatosParaRack", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next
    End Sub

    Private Sub CargaSeleccionados()
        Dim fila As Integer = 1
        Try
            grillaRack.Rows.Clear()
            For Each d As class_estructura_movimiento_rack In listaDetalleParaRack
                grillaRack.Rows.Add(False, d.filNew, d.fila, d.pro_codigo, d.palletOrigen, d.pallet, d.pro_codigointerno, d.pro_nombre, d.pro_bulto, d.bulto, d.cantidad, d.ubi_codigo, d.ubi_nombre)
                fila = fila + 1
            Next

            Call CONFIGURA_COLUMNAS_GRILLA_UBICACION()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GrillaDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaDetalle.CellContentClick
        Try
            If e.ColumnIndex = COL_GRI_SELECT Then
                If GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTMOVIL).Value.ToString = "0" Or GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTMOVIL).Value.ToString = "" Then
                    MessageBox.Show("El valor de la Cant. Movil. debe ser mayor a 0", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_SELECCION).Value = True

                If GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_PALLPISO).Value = 0 Then
                    If GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTORIG).Value <> GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTMOVIL).Value Then
                        MessageBox.Show("Debe pasar la cantidad completa de la fila, ya que, el pallet de origen no pertenece a un pallet de piso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTIDAD).Value = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTORIG).Value
                        Exit Sub
                    End If
                End If

                If cmbPisoDestino.SelectedValue = PISO_DESTINO.RACK Then
                    Call CargaDatosParaRack()
                ElseIf cmbPisoDestino.SelectedValue = PISO_DESTINO.UBICACION_PICKING Then
                    Call CargaDatosParaUbicacionPK()
                Else
                    Call CargaDatosParaUbicacionPiso()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargaDatosParaUbicacionPiso()
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim Fila As Integer = 0
        Dim ds As DataSet = New DataSet
        Dim _msg As String = ""
        Dim contador As Integer = 0

        For Each row2 As DataGridViewRow In Me.GrillaDetalle.Rows
            If row2.Cells(COL_GRI_SELECCION).Value = True Then
                classMovimiento.cnn = _cnn
                classMovimiento.fila = row2.Cells(COL_GRI_FILA).Value
                classMovimiento.pro_codigo = row2.Cells(COL_GRI_PROCODIGO).Value
                classMovimiento.bul_codigo = row2.Cells(COL_GRI_PROBULTO).Value
                classMovimiento.cantidad = row2.Cells(COL_GRI_CANTMOVIL).Value 'esta se cambia por cantidad movil
                classMovimiento.palletOrigen = row2.Cells(COL_GRI_PALLET).Value
                classMovimiento.ubi_codigodestino = cmbPisoDestino.SelectedValue

                ds = classMovimiento.CARGA_GRILLA_PARA_ALMACENAR_EN_UBICACION_PISO(_msg)
                If _msg = "" Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If ds.Tables(0).Rows(Fila)("pro_nombre") <> "" Then
                            Do While Fila < ds.Tables(0).Rows.Count
                                listaDetalleParaRack.Add(New class_estructura_movimiento_rack(Fila, ds.Tables(0).Rows(Fila)("fila"), ds.Tables(0).Rows(Fila)("pro_codigo"), ds.Tables(0).Rows(Fila)("palletOrigen"),
                                                                                              ds.Tables(0).Rows(Fila)("pallet"), ds.Tables(0).Rows(Fila)("pro_codigointerno"), ds.Tables(0).Rows(Fila)("pro_nombre"),
                                                                                              ds.Tables(0).Rows(Fila)("pro_bulto"), ds.Tables(0).Rows(Fila)("bulto"), ds.Tables(0).Rows(Fila)("cantidad"),
                                                                                              ds.Tables(0).Rows(Fila)("ubi_codigo"), ds.Tables(0).Rows(Fila)("ubi_nombre")))
                                contador = contador + 1
                                Fila = Fila + 1
                            Loop
                            If contador = 0 Then
                                Exit Sub
                            End If

                            Call CargaSeleccionados()
                            Call CARGA_PRODUCTOS()
                        Else
                            MessageBox.Show("No existe una ubicación asiganada al codigo y bulto seleccionada, o la ubicación se encuentra vacia." _
                                            + Chr(10) + "Para llenar la ubicación de PK, genere una orden de abastecimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            row2.Cells(COL_GRI_CANTIDAD).Value = row2.Cells(COL_GRI_CANTMOVIL).Value
                            row2.Cells(COL_GRI_CANTMOVIL).Value = 0
                            row2.Cells(COL_GRI_SELECCION).Value = 0
                        End If
                    End If
                Else
                    MessageBox.Show(_msg + "\CargaDatosParaUbicacionPK", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next
    End Sub

    Private Sub CargaDatosParaUbicacionPK()
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim Fila As Integer = 0
        Dim ds As DataSet = New DataSet
        Dim _msg As String = ""
        Dim contador As Integer = 0

        For Each row2 As DataGridViewRow In Me.GrillaDetalle.Rows
            If row2.Cells(COL_GRI_SELECCION).Value = True Then
                classMovimiento.cnn = _cnn
                classMovimiento.fila = row2.Cells(COL_GRI_FILA).Value
                classMovimiento.pro_codigo = row2.Cells(COL_GRI_PROCODIGO).Value
                classMovimiento.bul_codigo = row2.Cells(COL_GRI_PROBULTO).Value
                classMovimiento.cantidad = row2.Cells(COL_GRI_CANTMOVIL).Value 'esta se cambia por cantidad movil
                classMovimiento.palletOrigen = row2.Cells(COL_GRI_PALLET).Value

                ds = classMovimiento.CARGA_GRILLA_PARA_ALMACENAR_EN_UBICACION_PK(_msg)
                If _msg = "" Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If ds.Tables(0).Rows(Fila)("pro_nombre") <> "" Then
                            Do While Fila < ds.Tables(0).Rows.Count
                                listaDetalleParaRack.Add(New class_estructura_movimiento_rack(Fila, ds.Tables(0).Rows(Fila)("fila"), ds.Tables(0).Rows(Fila)("pro_codigo"), ds.Tables(0).Rows(Fila)("palletOrigen"),
                                                                                              ds.Tables(0).Rows(Fila)("pallet"), ds.Tables(0).Rows(Fila)("pro_codigointerno"), ds.Tables(0).Rows(Fila)("pro_nombre"),
                                                                                              ds.Tables(0).Rows(Fila)("pro_bulto"), ds.Tables(0).Rows(Fila)("bulto"), ds.Tables(0).Rows(Fila)("cantidad"),
                                                                                              ds.Tables(0).Rows(Fila)("ubi_codigo"), ds.Tables(0).Rows(Fila)("ubi_nombre")))
                                contador = contador + 1
                                Fila = Fila + 1
                            Loop
                            If contador = 0 Then
                                Exit Sub
                            End If

                            Call CargaSeleccionados()
                            Call CARGA_PRODUCTOS()
                        Else
                            MessageBox.Show("No existe una ubicación asiganada al codigo y bulto seleccionada, o la ubicación se encuentra vacia." _
                                            + Chr(10) + "Para llenar la ubicación de PK, genere una orden de abastecimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            row2.Cells(COL_GRI_CANTIDAD).Value = row2.Cells(COL_GRI_CANTMOVIL).Value
                            row2.Cells(COL_GRI_CANTMOVIL).Value = 0
                            row2.Cells(COL_GRI_SELECCION).Value = 0
                        End If
                    End If
                Else
                    MessageBox.Show(_msg + "\CargaDatosParaUbicacionPK", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next
    End Sub

    Private Sub btnAsigna_Click(sender As Object, e As EventArgs) Handles btnAsigna.Click
        Dim respuesta As Integer = 0
        Dim Contador As Integer = 0

        If VALIDA_FORMULARIO() = False Then
            Exit Sub
        End If

        'VALIDA OPERARIOS SELECCIONADOS
        '---------------------------------------------------------
        Contador = 0
        For Each row2 As DataGridViewRow In Me.GrillaOperario.Rows
            If row2.Cells(1).Value = True Then
                Contador = Contador + 1
            End If
        Next

        If Contador = 0 Then
            MessageBox.Show("Debe seleccionar a lo menos un operario ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'TabControl1.SelectedIndex = 1

            Exit Sub
        End If

        '_APROBADO = False
        '_RECHAZADO = False

        If cmbPisoDestino.SelectedValue = PISO_DESTINO.RACK Then
            respuesta = MessageBox.Show("El proceso de asignación puede tardar un poco mas de lo normal" _
                                    + Chr(10) + "¿Esta seguro en continuar la operación?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Exit Sub
            End If

            If GENERA_ASIGNACION_UBICACION() = False Then
                Exit Sub
            End If

            grillaRack.Columns(COL_GRA_SELECCION).Visible = True

        Else
            If GUARDAR_OM() = False Then
                Exit Sub
            End If
        End If
        Call RECARGA_DOCUMENTO()
        cmbEstado.SelectedValue = ESTADO_ORDEN_MOVIMIENTO.OM_GENERADA
        grillaRack.Columns(COL_GRA_QUITAR).Visible = False

        'Call OBTIENE_ESTADO_ASIGNACION()
        'Call CARGA_GRILLA_DETALLE(0, 0)
        'Call CARGA_GRILLA_PENDIENTE()
    End Sub

    Private Function VALIDA_FORMULARIO()
        VALIDA_FORMULARIO = False
        Try
            'If CDate(dtpDesde.Value) < CDate(GLO_FECHA_SISTEMA) Then
            '    MessageBox.Show("La fecha del movimiento debe ser mayor o igual a la fecha actual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    dtpDesde.Focus()
            '    Exit Function
            'End If

            If cmbBodegaOrigen.SelectedValue = 0 Then
                MessageBox.Show("Debe seleccionar una bodega de origen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbBodegaOrigen.Focus()
                Exit Function
            End If

            If cmbPisoOrigen.SelectedValue = 0 Then
                MessageBox.Show("Debe seleccionar un piso de origen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbPisoOrigen.Focus()
                Exit Function
            End If

            If cmbBodegaDestino.SelectedValue = 0 Then
                MessageBox.Show("Debe seleccionar una bodega de destino", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbBodegaDestino.Focus()
                Exit Function
            End If

            If cmbPisoDestino.SelectedValue = 0 Then
                MessageBox.Show("Debe seleccionar un piso de destino", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbPisoDestino.Focus()
                Exit Function
            End If

            VALIDA_FORMULARIO = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Private Function GUARDAR_OM() As Boolean
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        Dim contador As Integer = 0

        GUARDAR_OM = False

        Try
            Me.Cursor = Cursors.WaitCursor
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                classUbicaciones.cnn = _cnn
                classUbicaciones.car_codigo = 0

                'For Each row As DataGridViewRow In Me.grillaRack.Rows
                '    classUbicaciones.ubi_codigo = row.Cells(COL_GRA_CODUBICA).Value
                '    classUbicaciones.eab_codigo = ESTADO_UBICACION.RESERVADO
                '    ds = classUbicaciones.UBICACION_ACTUALIZA_ESTADO(_msgError, conexion)
                '    If _msgError <> "" Then
                '        ds = Nothing
                '        Me.Cursor = Cursors.Default
                '        MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                '        Exit Function
                '    End If
                'Next

                If GUARDA_ORDEN_MOVIMIENTO(conexion) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If
                    ds = Nothing
                    Me.Cursor = Cursors.Default
                    Exit Function
                Else
                    _eom_codigo = ESTADO_ORDEN_MOVIMIENTO.OM_GENERADA
                    cmbEstado.SelectedValue = _eom_codigo
                    If GUARDA_ORDEN_DETALLE(conexion) = False Then
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        ds = Nothing
                        Me.Cursor = Cursors.Default
                        Exit Function
                    End If
                End If

                If GUARDA_ASIGNACION_OPERARIOS(conexion) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If
                    'txtNumRec.Text = 0
                    ds = Nothing
                    Exit Function
                End If

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing
                Me.Cursor = Cursors.Default
            End Using

            If VERIFICA_UBICACIONES() = True Then
                MessageBox.Show("La Orden de Movimiento (OM) fue guardada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnImprimeIdentificador.Enabled = True
                GUARDAR_OM = True
            Else
                MessageBox.Show("Existen registros que no tiene ubicación asignada, contacte al administrador del sistema", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                GUARDAR_OM = False
            End If


            'ProgressBar1.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


    Private Function GENERA_ASIGNACION_UBICACION() As Boolean
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        Dim contador As Integer = 0

        GENERA_ASIGNACION_UBICACION = False

        Try
            Me.Cursor = Cursors.WaitCursor
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                classUbicaciones.cnn = _cnn
                classUbicaciones.car_codigo = 0

                ProgressBar1.Visible = True
                ProgressBar1.Value = 0
                ProgressBar1.Minimum = 0
                ProgressBar1.Maximum = grillaRack.RowCount
                For Each row As DataGridViewRow In Me.grillaRack.Rows
                    If row.Cells(COL_GRA_CANTIDAD).Value > 0 Then
                        classUbicaciones.pro_codigo = row.Cells(COL_GRA_PROCODIGO).Value
                        classUbicaciones.bul_codigo = row.Cells(COL_GRA_PROBULTO).Value
                        classUbicaciones.pallet = row.Cells(COL_GRA_PALLET).Value
                        ds = Nothing
                        ds = classUbicaciones.OBTIENE_UBICACION_PARA_ASIGNAR(_msgError, conexion)
                        If _msgError = "" Then
                            If ds.Tables(0).Rows.Count > 0 Then
                                If ds.Tables(0).Rows(0)("mensaje") <> "-" Then
                                    row.Cells(COL_GRA_UBICACION).Value = ds.Tables(0).Rows(0)("mensaje")
                                    row.Cells(COL_GRA_CODUBICA).Value = ds.Tables(0).Rows(0)("codigo")
                                Else
                                    row.Cells(COL_GRA_UBICACION).Value = "SIN UBICACIÓN"
                                    row.Cells(COL_GRA_CODUBICA).Value = "00000"
                                End If

                                grillaRack.Refresh()
                            Else
                                row.Cells(COL_GRA_UBICACION).Value = "SIN UBICACIÓN"
                                row.Cells(COL_GRA_CODUBICA).Value = "00000"
                                grillaRack.Refresh()
                                ds = Nothing
                            End If
                        Else
                            ds = Nothing
                            MessageBox.Show(_msgError + "\OBTIENE_UBICACIONES", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                If GUARDA_ORDEN_MOVIMIENTO(conexion) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If
                    ds = Nothing
                    Me.Cursor = Cursors.Default
                    Exit Function
                Else
                    _eom_codigo = ESTADO_ORDEN_MOVIMIENTO.OM_GENERADA
                    cmbEstado.SelectedValue = _eom_codigo
                    If GUARDA_ORDEN_DETALLE(conexion) = False Then
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        ds = Nothing
                        Me.Cursor = Cursors.Default
                        Exit Function
                    End If
                End If


                If GUARDA_ASIGNACION_OPERARIOS(conexion) = False Then
                    Me.Cursor = Cursors.WaitCursor
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If
                    'txtNumRec.Text = 0
                    ds = Nothing
                    Exit Function
                End If

                If VERIFICA_UBICACIONES() = False Then
                    Me.Cursor = Cursors.WaitCursor
                    MessageBox.Show("Existen registros que no tiene ubicación asignada, contacte al administrador del sistema", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    GENERA_ASIGNACION_UBICACION = False

                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If

                    ds = Nothing
                    Exit Function

                End If

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing
                Me.Cursor = Cursors.Default
            End Using

            'If VERIFICA_UBICACIONES() = True Then
            MessageBox.Show("La Orden de Movimiento (OM) fue guardada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnImprimeIdentificador.Enabled = True
                GENERA_ASIGNACION_UBICACION = True
            'Else

            'End If
            btnEnviar.Enabled = True


            'ProgressBar1.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function VERIFICA_UBICACIONES()
        Dim contador As Integer = 0

        VERIFICA_UBICACIONES = True
        For Each row As DataGridViewRow In Me.grillaRack.Rows
            If (row.Cells(COL_GRA_UBICACION).Value = "SIN UBICACIÓN" Or row.Cells(COL_GRA_UBICACION).Value = "-") And CInt(row.Cells(COL_GRA_CANTIDAD).Value) > 0 Then
                contador = contador + 1
            End If
        Next

        If contador > 0 Then
            VERIFICA_UBICACIONES = False
        End If
    End Function

    Private Function GUARDA_ASIGNACION_OPERARIOS(ByVal conexion As SqlConnection) As Boolean
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim _msgError As String = ""
        Dim ds As DataSet

        GUARDA_ASIGNACION_OPERARIOS = False
        Try
            'ELIMINA OPERADORES ASOCIADOS
            classMovimiento.omo_codigo = _omo_codigo
            ds = classMovimiento.ORDEN_MOVIMIENTO_RESPONSABLE_ELIMINA(_msgError, conexion)
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
                    classMovimiento.omo_codigo = _omo_codigo
                    classMovimiento.usu_codigo = row2.Cells(0).Value
                    ds = classMovimiento.ORDEN_MOVIMIENTO_RESPONSABLE_GUARDAR(_msgError, conexion)
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

            GUARDA_ASIGNACION_OPERARIOS = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function GUARDA_ORDEN_MOVIMIENTO(ByVal conexion As SqlConnection) As Boolean
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim _msgError As String = ""
        Dim ds As DataSet

        GUARDA_ORDEN_MOVIMIENTO = False

        Try
            'Guarda cabecera del documento
            ds = Nothing

            classMovimiento.omo_codigo = _omo_codigo
            classMovimiento.usu_codigo = GLO_USUARIO_ACTUAL
            classMovimiento.omo_fechadocto = dtpDesde.Value
            classMovimiento.eom_codigo = ESTADO_ORDEN_MOVIMIENTO.OM_GENERADA
            classMovimiento.omo_valemanager = 0
            classMovimiento.bod_codigoorigen = cmbBodegaOrigen.SelectedValue
            classMovimiento.ubi_codigoorigen = cmbPisoOrigen.SelectedValue
            classMovimiento.bod_codigodestino = cmbBodegaDestino.SelectedValue
            classMovimiento.ubi_codigodestino = cmbPisoDestino.SelectedValue

            ds = classMovimiento.GUARDA_ORDEN_MOVIMIENTO_ENCABEZADO(_msgError, conexion)
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
                    lblOM.Text = ds.Tables(0).Rows(0)("CODIGO")
                    _omo_codigo = ds.Tables(0).Rows(0)("CODIGO")
                End If
            End If
            GUARDA_ORDEN_MOVIMIENTO = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function GUARDA_ORDEN_DETALLE(ByVal conexion As SqlConnection) As Boolean
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim tmp_llave_pallet As String = ""
        GUARDA_ORDEN_DETALLE = False
        Try

            For Each row2 As DataGridViewRow In Me.grillaRack.Rows
                classMovimiento.omo_codigo = _omo_codigo
                classMovimiento.ode_fila = row2.Cells(COL_GRA_FILAR).Value
                classMovimiento.pro_codigo = row2.Cells(COL_GRA_PROCODIGO).Value
                classMovimiento.ode_palletorigen = row2.Cells(COL_GRA_PALORIGEN).Value
                classMovimiento.ode_pallet = row2.Cells(COL_GRA_PALLET).Value
                classMovimiento.pro_codigointerno = row2.Cells(COL_GRA_CODIGO).Value
                classMovimiento.pro_nombre = row2.Cells(COL_GRA_PRODUCTO).Value
                classMovimiento.bul_codigo = row2.Cells(COL_GRA_PROBULTO).Value
                classMovimiento.ode_bulto = row2.Cells(COL_GRA_BULTO).Value
                classMovimiento.ode_cantidad = row2.Cells(COL_GRA_CANTIDAD).Value
                classMovimiento.ubi_codigo = row2.Cells(COL_GRA_CODUBICA).Value
                classMovimiento.ubi_nombre = row2.Cells(COL_GRA_UBICACION).Value
                ds = classMovimiento.GUARDA_ORDEN_MOVIMIENTO_DETALLE(_msgError, conexion)
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

            GUARDA_ORDEN_DETALLE = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub grillaRack_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaRack.CellContentClick
        If e.ColumnIndex = COL_GRA_QUITAR Then
            listaDetalleParaRack.RemoveAll(Function(p As class_estructura_movimiento_rack) p.filNew = grillaRack.Rows(e.RowIndex).Cells(COL_GRA_FILAR).Value And p.fila = grillaRack.Rows(e.RowIndex).Cells(COL_GRA_FILA).Value And p.pro_codigo = grillaRack.Rows(e.RowIndex).Cells(COL_GRA_PROCODIGO).Value And p.pro_bulto = grillaRack.Rows(e.RowIndex).Cells(COL_GRA_PROBULTO).Value)
            grillaRack.Rows.Remove(grillaRack.Rows(e.RowIndex))
            If Pestana = "DE" Then
                Call CARGA_PRODUCTOS()
            Else
                Call CARGA_PRODUCTOS_DESDE_RACK()
            End If
        End If
    End Sub

    Private Sub cmbPisoDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPisoDestino.SelectedIndexChanged

    End Sub

    Private Sub cmbPisoDestino_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPisoDestino.SelectionChangeCommitted
        'If (cmbPisoDestino.SelectedValue = PISO_DESTINO.RACK Or cmbPisoDestino.SelectedValue = PISO_DESTINO.UBICACION_PICKING) Then
        If (cmbPisoDestino.Text <> "") Then
            If cmbPisoDestino.SelectedValue = PISO_DESTINO.RACK Then
                btnAsigna.Text = "Asignar Ubicaciones y guarda Documento"
            Else
                btnAsigna.Text = "Guardar Orden de Movimiento"
            End If


            GrillaDetalle.DataSource = Nothing
            GrillaDetalle.Rows.Clear()
            TabPage2.Parent = TabControl1
        End If
    End Sub

    Private Sub GrillaDetalle_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GrillaDetalle.EditingControlShowing
        Dim validar As TextBox = CType(e.Control, TextBox)

        cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)
        PrecionaTeclaDesde = "GrillaDetalle"
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf validar_Keypress_cantidades
    End Sub

    Private Sub validar_Keypress_cantidades(
        ByVal sender As Object,
        ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = GrillaDetalle.CurrentCell.ColumnIndex
        Dim fila As Integer = GrillaDetalle.CurrentCell.RowIndex

        ' solo numeicas 
        If (columna = COL_GRI_CANTMOVIL) Then
            ' Obtener caracter  
            Dim caracter As Char = e.KeyChar

            ' comprobar si el caracter es un número o el retroceso  
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                'Me.Text = e.KeyChar  
                e.KeyChar = Chr(0)
            End If
        End If

        'If (columna = 2) Then
        '    Dim caracter As Char = e.KeyChar

        '    ' referencia a la celda  
        '    Dim txt As TextBox = CType(sender, TextBox)

        '    ' comprobar si es un número con isNumber, si es el backspace, si el caracter  

        '    ' es el separador decimal, y que no contiene ya el separador 

        '    If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ",") And (txt.Text.Contains(",") = False) Then

        '        e.Handled = False
        '    Else
        '        e.Handled = True
        '    End If
        'End If

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim columna As Integer
        Dim fila As Integer


        ProcessCmdKey = False
        Try
            Select Case keyData
                Case Keys.Escape
                    ' No hacemos nada porque se supone
                    ' que la tecla Escape cancela la acción.

                Case Keys.Enter 'Or Keys.Down Or Keys.Up Or Keys.Left Or Keys.Right

                    'If GrillaFinanciamiento.Focus = True Then
                    If PrecionaTeclaDesde = "GrillaDetalle" Then

                        columna = GrillaDetalle.CurrentCell.ColumnIndex
                        fila = GrillaDetalle.CurrentCell.RowIndex

                        If (columna = COL_GRI_CANTMOVIL) Then
                            'If (cellTextBox IsNot Nothing) Then
                            '    With GrillaDetalle
                            '        If ((.CurrentCell.RowIndex) < (.RowCount - 1)) Then
                            '            .CurrentCell = .Item(.CurrentCell.ColumnIndex, .CurrentCell.RowIndex + 1)
                            '        ElseIf ((.CurrentCell.RowIndex) = (.RowCount - 1)) Then
                            '            If .ColumnCount = (.CurrentCell.ColumnIndex + 1) Then
                            '                .CurrentCell = .Item(.CurrentCell.ColumnIndex, 0)
                            '            Else
                            '                '.CurrentCell = .Item(.CurrentCell.ColumnIndex + 1, 0)
                            '                .CurrentCell = .Item(.CurrentCell.ColumnIndex, 0)
                            '            End If

                            '        End If
                            '    End With
                            'End If
                            If GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value.ToString = "0" Or GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value.ToString = "" Then
                                GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value = GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTORIG).Value
                            ElseIf CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value) < CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value) Then
                                MessageBox.Show("La Cant. Movil. que esta ingresando no es válida, ya que es mayor a Cantidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value = 0
                            ElseIf CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value) >= CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value) Then
                                GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value = GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTORIG).Value
                                GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value = CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value) - CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value)
                            End If
                        End If
                    End If

                    PrecionaTeclaDesde = ""

                    'Case Keys.Down Or Keys.Up Or Keys.Left Or Keys.Right
                    '    If columna = COL_GRI_CANTMOVIL Then
                    '        If GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value.ToString = "0" Or GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value.ToString = "" Then
                    '            GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value = GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTORIG).Value
                    '        ElseIf CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value) < CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value) Then
                    '            MessageBox.Show("La Cant. Movil. que esta ingresando no es válida, ya que es mayor a Cantidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    '            GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value = 0
                    '        ElseIf CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value) >= CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value) Then
                    '            GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value = GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTORIG).Value
                    '            GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value = CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTIDAD).Value) - CDbl(GrillaDetalle.Rows(fila).Cells(COL_GRI_CANTMOVIL).Value)
                    '        End If
                    '    End If

                Case Else

                    Return MyBase.ProcessCmdKey(msg, keyData)
            End Select
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub GrillaDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaDetalle.CellValueChanged
        If PrimeraVez = True Then
            If e.ColumnIndex = COL_GRI_CANTMOVIL Then
                If GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTMOVIL).Value.ToString = "0" Or GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTMOVIL).Value.ToString = "" Then
                    GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTIDAD).Value = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTORIG).Value
                ElseIf CDbl(GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTIDAD).Value) < CDbl(GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTMOVIL).Value) Then
                    MessageBox.Show("La Cant. Movil. que esta ingresando no es válida, ya que es mayor a Cantidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTMOVIL).Value = 0
                ElseIf CDbl(GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTIDAD).Value) >= CDbl(GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTMOVIL).Value) Then
                    GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTIDAD).Value = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTORIG).Value
                    GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTIDAD).Value = CDbl(GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTIDAD).Value) - CDbl(GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CANTMOVIL).Value)
                End If
            End If
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Call CAMBIA_ESTADO(ESTADO_ORDEN_MOVIMIENTO.PENDIENTE_APROBACION)
    End Sub

    Private Sub CAMBIA_ESTADO(ByVal CodEstado As Integer)
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim fila As Integer = 0
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        Dim respuesta As Integer = 0

        Try
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                classMovimiento.cnn = _cnn
                classMovimiento.omo_codigo = _omo_codigo
                classMovimiento.eom_codigo = CodEstado
                ds = Nothing
                ds = classMovimiento.ORDEN_MOVIMIENTO_CAMBIA_ESTADO(_msgError, conexion)
                If _msgError <> "" Then
                    ds = Nothing
                    MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                        ds = Nothing
                        MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing

                If CodEstado = ESTADO_ORDEN_MOVIMIENTO.PENDIENTE_APROBACION Then
                    MessageBox.Show("La orden de movimiento (OM) fue enviada para su aprobación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf CodEstado = ESTADO_ORDEN_MOVIMIENTO.OM_APROBADA Then
                    MessageBox.Show("La orden de movimiento (OM) fue aprobada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf CodEstado = ESTADO_ORDEN_MOVIMIENTO.OM_RECHAZADA Then
                    MessageBox.Show("La orden de movimiento (OM) fue rechazad en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.Dispose()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAprueba_Click(sender As Object, e As EventArgs) Handles btnAprueba.Click
        Dim Respuesta As Integer = 0

        Respuesta = MessageBox.Show("¿Esta seguro(a) de aprobar la OM?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Respuesta = vbNo Then
            Exit Sub
        End If

        Call CAMBIA_ESTADO(ESTADO_ORDEN_MOVIMIENTO.OM_APROBADA)
    End Sub

    Private Sub btnRechaza_Click(sender As Object, e As EventArgs) Handles btnRechaza.Click
        Dim Respuesta As Integer = 0

        Respuesta = MessageBox.Show("¿Esta seguro(a) de rechazar la OM?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Respuesta = vbNo Then
            Exit Sub
        End If

        Call CAMBIA_ESTADO(ESTADO_ORDEN_MOVIMIENTO.OM_RECHAZADA)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim frm As frm_imprimir = New frm_imprimir
        If _omo_codigo = 0 Then
            MessageBox.Show("Debe seleccionar una OM ingresada para poder imprimirla", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frm.nombreReporte = "rptOrdenMovimiento.rpt"
        frm.Origen = "OMO"
        frm.omo_codigo = _omo_codigo
        frm.ShowDialog()
    End Sub

    Private Sub btnImprimeIdentificador_Click(sender As Object, e As EventArgs) Handles btnImprimeIdentificador.Click
        Try
            Dim frm As frm_imprimir = New frm_imprimir
            frm.Origen = "IOM"

            frm.omo_codigo = _omo_codigo
            frm.serie_paller = OBTIENE_SERIES()

            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function OBTIENE_SERIES() As String
        Dim strPallet As String = ""
        OBTIENE_SERIES = ""
        For Each row As DataGridViewRow In Me.grillaRack.Rows
            If row.Cells(0).Value = True Then
                If strPallet = "" Then
                    strPallet = row.Cells(COL_GRA_PALLET).Value
                Else
                    strPallet = strPallet + "," + row.Cells(COL_GRA_PALLET).Value
                End If
            End If
        Next
        If strPallet = "" Then
            OBTIENE_SERIES = "-"
        Else
            OBTIENE_SERIES = strPallet + ","
        End If

    End Function

    Private Sub btnGuardaVale_Click(sender As Object, e As EventArgs) Handles btnGuardaVale.Click
        Call GUARDA_VALE()
    End Sub

    Private Sub GUARDA_VALE()
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim fila As Integer = 0
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""

        Try

            classMovimiento.cnn = _cnn
            classMovimiento.omo_codigo = _omo_codigo
            classMovimiento.omo_valemanager = txtValeManager.Text
            ds = classMovimiento.GUARDA_NUM_VALE_MANAGER_OM(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            MessageBox.Show("El vale manager fue ingresado en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtValeManager_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValeManager.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscarDesdeRack_Click(sender As Object, e As EventArgs) Handles btnBuscarDesdeRack.Click
        If cmbPisoOrigen.SelectedValue = 0 Then
            MessageBox.Show("Debe seleccionar un piso de origen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        listaDetalleParaRack = New List(Of class_estructura_movimiento_rack)()
        Pestana = "RA"
        Call CARGA_PRODUCTOS_DESDE_RACK()
    End Sub

    Private Sub CARGA_PRODUCTOS_DESDE_RACK()
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim Fila As Integer = 0
        Dim msgError As String = ""
        Dim Cantidad As Integer = 0
        Dim cantDevuelta As Integer = 0
        Dim canDevuletaAcumulada As Integer = 0
        Dim Ubicacion As String = ""
        Try
            Dim ds As DataSet = New DataSet
            ds = Nothing
            grillaDesdeRack.Rows.Clear()
            msgError = ""

            classMovimiento.cnn = _cnn

            If cmbZona.Text = "0" Or cmbZona.Text = "" Then
                classMovimiento.zon_codigo = 0
            Else
                classMovimiento.zon_codigo = cmbZona.SelectedValue
            End If

            If cmbAltura.Text = "0" Or cmbAltura.Text = "" Then
                classMovimiento.alt_codigo = 0
            Else
                classMovimiento.alt_codigo = cmbAltura.SelectedValue
            End If

            ds = classMovimiento.CARGA_PRODUCTO_ORIGEN_DESDE_RACK(msgError)
            If msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("pro_nombre") <> "" Then
                        canDevuletaAcumulada = 0
                        Do While Fila < ds.Tables(0).Rows.Count
                            If ds.Tables(0).Rows(Fila)("ubi_nombre2") = "-" Then
                                Ubicacion = ds.Tables(0).Rows(Fila)("ubi_nombre")
                            Else
                                Ubicacion = ds.Tables(0).Rows(Fila)("ubi_nombre") + " - " + ds.Tables(0).Rows(Fila)("ubi_nombre2")
                            End If

                            Cantidad = 0
                            cantDevuelta = 0
                            Cantidad = ds.Tables(0).Rows(Fila)("pal_cantidaddisponible")
                            If BuscarItem(Fila, ds.Tables(0).Rows(Fila)("pro_codigo"), ds.Tables(0).Rows(Fila)("pro_bulto"), cantDevuelta) = False Then
                                Cantidad = ds.Tables(0).Rows(Fila)("pal_cantidaddisponible")
                            Else
                                Cantidad = ds.Tables(0).Rows(Fila)("pal_cantidaddisponible") - cantDevuelta
                            End If

                            grillaDesdeRack.Rows.Add(False, Fila, ds.Tables(0).Rows(Fila)("ubi_codigo"),
                                                                            Ubicacion,
                                                                            ds.Tables(0).Rows(Fila)("pallet"),
                                                                            ds.Tables(0).Rows(Fila)("pro_codigo"),
                                                                            ds.Tables(0).Rows(Fila)("pro_codigointerno"),
                                                                            ds.Tables(0).Rows(Fila)("pro_nombre"),
                                                                            ds.Tables(0).Rows(Fila)("pro_bulto"),
                                                                            ds.Tables(0).Rows(Fila)("pro_bultostring"),
                                                                            Cantidad,
                                                                            "",
                                                                            ds.Tables(0).Rows(Fila)("ubi_codigo2"),
                                                                            ds.Tables(0).Rows(Fila)("ubi_nombre2"))
                            Fila = Fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS_GRILLA_DESDE_RACK()
                    End If
                End If
            Else
                MessageBox.Show(msgError + "\CARGA_PRODUCTOS_DESDE_RACK", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_PRODUCTOS_DESDE_RACK", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grillaDesdeRack_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaDesdeRack.CellContentClick
        Try
            If e.ColumnIndex = COL_rac_SELECT Then
                If grillaDesdeRack.Rows(e.RowIndex).Cells(COL_RAC_CANTIDAD).Value.ToString = "0" Or grillaDesdeRack.Rows(e.RowIndex).Cells(COL_RAC_CANTIDAD).Value.ToString = "" Then
                    MessageBox.Show("El valor de la Cant. Movil. debe ser mayor a 0", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                grillaDesdeRack.Rows(e.RowIndex).Cells(COL_RAC_SELECCION).Value = True

                Call CargaDatosParaUbicacionPisoDesdeRack()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargaDatosParaUbicacionPisoDesdeRack()
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
        Dim Fila As Integer = 0
        Dim ds As DataSet = New DataSet
        Dim _msg As String = ""
        Dim contador As Integer = 0

        For Each row2 As DataGridViewRow In Me.grillaDesdeRack.Rows
            If row2.Cells(COL_GRI_SELECCION).Value = True Then
                classMovimiento.cnn = _cnn
                classMovimiento.fila = row2.Cells(COL_RAC_FILA).Value
                classMovimiento.pro_codigo = row2.Cells(COL_RAC_PROCODINT).Value
                classMovimiento.bul_codigo = row2.Cells(COL_RAC_CODBULTO).Value
                classMovimiento.cantidad = row2.Cells(COL_RAC_CANTIDAD).Value 'esta se cambia por cantidad movil
                classMovimiento.palletOrigen = row2.Cells(COL_RAC_PALLET).Value
                classMovimiento.ubi_codigodestino = cmbPisoDestino.SelectedValue

                ds = classMovimiento.CARGA_GRILLA_PARA_ALMACENAR_EN_UBICACION_PISO(_msg)
                If _msg = "" Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If ds.Tables(0).Rows(Fila)("pro_nombre") <> "" Then
                            Do While Fila < ds.Tables(0).Rows.Count
                                listaDetalleParaRack.Add(New class_estructura_movimiento_rack(Fila, ds.Tables(0).Rows(Fila)("fila"), ds.Tables(0).Rows(Fila)("pro_codigo"), ds.Tables(0).Rows(Fila)("palletOrigen"),
                                                                                              ds.Tables(0).Rows(Fila)("pallet"), ds.Tables(0).Rows(Fila)("pro_codigointerno"), ds.Tables(0).Rows(Fila)("pro_nombre"),
                                                                                              ds.Tables(0).Rows(Fila)("pro_bulto"), ds.Tables(0).Rows(Fila)("bulto"), ds.Tables(0).Rows(Fila)("cantidad"),
                                                                                              ds.Tables(0).Rows(Fila)("ubi_codigo"), ds.Tables(0).Rows(Fila)("ubi_nombre")))
                                contador = contador + 1
                                Fila = Fila + 1
                            Loop
                            If contador = 0 Then
                                Exit Sub
                            End If

                            Call CargaSeleccionados()
                            Call CARGA_PRODUCTOS_DESDE_RACK()
                        Else
                            MessageBox.Show("No existe una ubicación asiganada al codigo y bulto seleccionada, o la ubicación se encuentra vacia." _
                                            + Chr(10) + "Para llenar la ubicación de PK, genere una orden de abastecimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            row2.Cells(COL_GRI_CANTIDAD).Value = row2.Cells(COL_GRI_CANTMOVIL).Value
                            row2.Cells(COL_GRI_CANTMOVIL).Value = 0
                            row2.Cells(COL_GRI_SELECCION).Value = 0
                        End If
                    End If
                Else
                    MessageBox.Show(_msg + "\CargaDatosParaUbicacionPisoDesdeRack", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next
    End Sub


End Class