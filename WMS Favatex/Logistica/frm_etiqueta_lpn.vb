Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.IO.File
Imports System.Xml.Linq
Public Class frm_etiqueta_lpn
    Private _cnn As String
    Private _rutaArchivo As String = ""

    Private _elp_nombrearchivo As String
    Private _elp_sucursaldestino As String
    Private _elp_area As String
    Private _elp_proveedor As String
    Private _elp_lote As String
    Private _elp_ordencompra As String
    Private _elp_nd As String
    Private _elp_codigoproveedor As String
    Private _elp_descripcion As String
    Private _elp_plu As String
    Private _elp_rubro As String
    Private _elp_cantidad As Integer
    Private _elp_boleta As String
    Private _elp_cliente As String
    Private _elp_direccion As String
    Private _elp_comuna As String
    Private _elp_ciudad As String
    Private _elp_ruta As String
    Private _elp_fechaentrega As Date
    Private _elp_fechacompra As Date
    Private _elp_nbulto As String
    Dim codigoImpresion As String = ""

    Dim UltimoCorrelativoLPNParis As Long = 0
    Dim PrefijoLPNParis As String = ""

    Dim UltimoCorrelativoLPNEasy As Long = 0
    Dim PrefijoLPNEasy As String = ""

    Dim UltimoCorrelativoLPNABCDIN As Long = 0
    Dim PrefijoLPNABCDIN As String = ""

    Dim UltimoCorrelativoLPNERipley As Long = 0
    Dim PrefijoLPNRipley As String = ""

    Dim UltimoCorrelativoLPNESodimac As Long = 0
    Dim PrefijoLPNSodimac As String = ""

    Dim UltimoCorrelativoLPNEConstrumart As Long = 0
    Dim PrefijoLPNConstrumart As String = ""

    Dim cargoFormulario As Boolean = False



    Dim EasyIdImpresion As String = ""

    Const COL_GRI_SELECCION As Integer = 0
    Const COL_GRI_TIPO_FLUJO As Integer = 1
    Const COL_GRI_ID_BULTO As Integer = 2
    Const COL_GRI_ID_PALLET As Integer = 3
    Const COL_GRI_DESC_PRODUCTO As Integer = 4
    Const COL_GRI_COD_LOCAL As Integer = 5
    Const COL_GRI_COD_DEPTO As Integer = 6
    Const COL_GRI_DEPTO As Integer = 7
    Const COL_GRI_DESC_LOCAL As Integer = 8
    Const COL_GRI_COD_PARIS As Integer = 9
    Const COL_GRI_COD_PROVEEDOR As Integer = 10
    Const COL_GRI_NUM_ORDEN As Integer = 11
    Const COL_GRI_CANTIDAD As Integer = 12
    Const COL_GRI_NUM_DOC_TRIBUTARIO As Integer = 13

    '===============================================
    'ENCABEADO EASY
    '===============================================
    Const COL_GRI_EASY_ENC_SELECCION As Integer = 0
    Const COL_GRI_EASY_ENC_OCOMPRA As Integer = 1
    Const COL_GRI_EASY_ENC_FCOMPROMISO As Integer = 2

    '===============================================
    'DETALLE EASY
    '===============================================
    Const COL_GRI_EASY_DET_OCOMPRA As Integer = 0
    Const COL_GRI_EASY_DET_FCOMPROMISO As Integer = 1
    Const COL_GRI_EASY_DET_CODIGO_LOCAL As Integer = 2
    Const COL_GRI_EASY_DET_NOMBRE_LOCAL As Integer = 3
    Const COL_GRI_EASY_DET_LPN As Integer = 4
    Const COL_GRI_EASY_DET_SKU As Integer = 5
    Const COL_GRI_EASY_DET_SKU_NOMBRE As Integer = 6
    Const COL_GRI_EASY_DET_CANTIDAD As Integer = 7
    Const COL_GRI_EASY_DET_CODIGO_FAVATEX As Integer = 8
    Const COL_GRI_EASY_DET_GRUPO As Integer = 9

    Const COL_GRI_EASY_ARC_OCOMPRA As Integer = 0
    Const COL_GRI_EASY_ARC_CODIGO_LOCAL As Integer = 1
    Const COL_GRI_EASY_ARC_LPN As Integer = 2
    Const COL_GRI_EASY_ARC_SKU As Integer = 3
    Const COL_GRI_EASY_ARC_CANTIDAD As Integer = 4

    '===============================================
    'DETALLE ABC VENTA EN VERDE
    '===============================================
    Const COL_GRI_ABC_DET_VV_SELECCION As Integer = 0
    Const COL_GRI_ABC_DET_VV_LPN As Integer = 1
    Const COL_GRI_ABC_DET_VV_RAZON_SOCIAL As Integer = 2
    Const COL_GRI_ABC_DET_VV_FECHA_ENTREGA As Integer = 3
    Const COL_GRI_ABC_DET_VV_NUM_CITA As Integer = 4
    Const COL_GRI_ABC_DET_VV_ORDEN_COMPRA As Integer = 5
    Const COL_GRI_ABC_DET_VV_FACTURA As Integer = 6
    Const COL_GRI_ABC_DET_VV_BOLETA As Integer = 7
    Const COL_GRI_ABC_DET_VV_VENDIDO_POR As Integer = 8
    Const COL_GRI_ABC_DET_VV_FECHA_CLIENTE As Integer = 9
    Const COL_GRI_ABC_DET_VV_NOMBRE_CLIENTE As Integer = 10
    Const COL_GRI_ABC_DET_VV_RUT_CLIENTE As Integer = 11
    Const COL_GRI_ABC_DET_VV_FONO_CLIENTE As Integer = 12
    Const COL_GRI_ABC_DET_VV_DIRECCION_CLIENTE As Integer = 13
    Const COL_GRI_ABC_DET_VV_COMUNA_CLIENTE As Integer = 14
    Const COL_GRI_ABC_DET_VV_LOCALIDAD As Integer = 15
    Const COL_GRI_ABC_DET_VV_CODIGO_SUCURSAL As Integer = 16
    Const COL_GRI_ABC_DET_VV_NOMBRE_SUCURSAL As Integer = 17
    Const COL_GRI_ABC_DET_VV_SKU_CLIENTE As Integer = 18
    Const COL_GRI_ABC_DET_VV_CANTIDAD As Integer = 19
    Const COL_GRI_ABC_DET_VV_NUMERO_BULTO As Integer = 20
    Const COL_GRI_ABC_DET_VV_SKU_NOMBRE As Integer = 21
    Const COL_GRI_ABC_DET_VV_VOLUMEN As Integer = 22
    Const COL_GRI_ABC_DET_VV_PESO As Integer = 23

    Const COL_GRI_ABC_ARC_VV_OC As Integer = 0
    Const COL_GRI_ABC_ARC_VV_SUC1 As Integer = 1
    Const COL_GRI_ABC_ARC_VV_SUC2 As Integer = 2
    Const COL_GRI_ABC_ARC_VV_LPN As Integer = 3
    Const COL_GRI_ABC_ARC_VV_SKU As Integer = 4
    Const COL_GRI_ABC_ARC_VV_CANT As Integer = 5
    Const COL_GRI_ABC_ARC_VV_FAC As Integer = 6
    Const COL_GRI_ABC_ARC_VV_TIP As Integer = 7
    Const COL_GRI_ABC_ARC_VV_BOL As Integer = 8
    Const COL_GRI_ABC_ARC_VV_RUT As Integer = 9

    '===============================================
    'ENCABEADO ABCDIN ENCABEZADO
    '===============================================
    Const COL_GRI_ABCDIN_ENC_SELECCION As Integer = 0
    Const COL_GRI_ABCDIN_ENC_OCOMPRA As Integer = 1
    Const COL_GRI_ABCDIN_ENC_FCOMPROMISO As Integer = 2

    Const COL_GRI_ABCDIN_DET_SELECCION As Integer = 0
    Const COL_GRI_ABCDIN_DET_LPN As Integer = 1
    Const COL_GRI_ABCDIN_DET_RAZON_SOCIAL As Integer = 2
    Const COL_GRI_ABCDIN_DET_FECHA_ENTREGA As Integer = 3
    Const COL_GRI_ABCDIN_DET_NUM_CITA As Integer = 4
    Const COL_GRI_ABCDIN_DET_ORDEN_COMPRA As Integer = 5
    Const COL_GRI_ABCDIN_DET_FACTURA As Integer = 6
    Const COL_GRI_ABCDIN_DET_COD_SUCURSAL As Integer = 7
    Const COL_GRI_ABCDIN_DET_NOMBRE_SUCURSAL As Integer = 8
    Const COL_GRI_ABCDIN_DET_SKU_CLIENTE As Integer = 9
    Const COL_GRI_ABCDIN_DET_CANTIDAD As Integer = 10
    Const COL_GRI_ABCDIN_DET_NUM_BULTO As Integer = 11
    Const COL_GRI_ABCDIN_DET_SKU_NOMBRE As Integer = 12
    Const COL_GRI_ABCDIN_DET_VOLUMEN As Integer = 13
    Const COL_GRI_ABCDIN_DET_PESO As Integer = 14

    Const COL_GRI_ABC_ARC_AG_OC As Integer = 0
    Const COL_GRI_ABC_ARC_AG_CSU As Integer = 1
    Const COL_GRI_ABC_ARC_AG_NSU As Integer = 2
    Const COL_GRI_ABC_ARC_AG_LPN As Integer = 3
    Const COL_GRI_ABC_ARC_AG_SKU As Integer = 4
    Const COL_GRI_ABC_ARC_AG_CANT As Integer = 5
    Const COL_GRI_ABC_ARC_AG_FAC As Integer = 6
    Const COL_GRI_ABC_ARC_AG_TIP As Integer = 7
    Const COL_GRI_ABC_ARC_AG_NOM As Integer = 8


    '===============================================
    'ENCABEADO RIPLEY
    '===============================================
    Const COL_GRI_RIPLEY_ENC_SELECCION As Integer = 0
    Const COL_GRI_RIPLEY_ENC_OCOMPRA As Integer = 1
    Const COL_GRI_RIPLEY_ENC_FCOMPROMISO As Integer = 2

    '===============================================
    'DETALLE RIPLEY
    '===============================================
    Const COL_GRI_RIPLEY_DET_OCOMPRA As Integer = 0
    Const COL_GRI_RIPLEY_DET_FCOMPROMISO As Integer = 1
    Const COL_GRI_RIPLEY_DET_CODIGO_SUCURSAL As Integer = 2
    Const COL_GRI_RIPLEY_DET_NOMBRE_SUCURSAL As Integer = 3
    Const COL_GRI_RIPLEY_DET_CODIGO_DEPTO As Integer = 4
    Const COL_GRI_RIPLEY_DET_NOMBRE_DEPTO As Integer = 5
    Const COL_GRI_RIPLEY_DET_LPN As Integer = 6
    Const COL_GRI_RIPLEY_DET_SKU As Integer = 7
    Const COL_GRI_RIPLEY_DET_SKU_NOMBRE As Integer = 8
    Const COL_GRI_RIPLEY_DET_CANTIDAD As Integer = 9
    Const COL_GRI_RIPLEY_DET_CODIGO_FAVATEX As Integer = 10

    'Const COL_GRI_EASY_ARC_OCOMPRA As Integer = 0
    'Const COL_GRI_EASY_ARC_CODIGO_LOCAL As Integer = 1
    'Const COL_GRI_EASY_ARC_LPN As Integer = 2
    'Const COL_GRI_EASY_ARC_SKU As Integer = 3
    'Const COL_GRI_EASY_ARC_CANTIDAD As Integer = 4

    '===============================================
    'ENCABEADO SODIMAC
    '===============================================
    Const COL_GRI_SODIMAC_ENC_SELECCION As Integer = 0
    Const COL_GRI_SODIMAC_ENC_OCOMPRA As Integer = 1
    Const COL_GRI_SODIMAC_ENC_FCOMPROMISO As Integer = 2
    Const COL_GRI_SODIMAC_ENC_TIPOORDEN As Integer = 3

    '===============================================
    'DETALLE SODIMAC
    '===============================================
    Const COL_GRI_SODIMAC_DET_IDPROVE As Integer = 0
    Const COL_GRI_SODIMAC_DET_OCOMPRA As Integer = 1
    Const COL_GRI_SODIMAC_DET_CDENTRE As Integer = 2
    Const COL_GRI_SODIMAC_DET_NUMSUCU As Integer = 3
    Const COL_GRI_SODIMAC_DET_CODSUCU As Integer = 4
    Const COL_GRI_SODIMAC_DET_NUMLPN As Integer = 5
    Const COL_GRI_SODIMAC_DET_UPC As Integer = 6
    Const COL_GRI_SODIMAC_DET_SKUCLIE As Integer = 7
    Const COL_GRI_SODIMAC_DET_SKUDESC As Integer = 8
    Const COL_GRI_SODIMAC_DET_CODFAV As Integer = 9
    Const COL_GRI_SODIMAC_DET_CANTIDAD As Integer = 10
    Const COL_GRI_SODIMAC_DET_NUMDOC As Integer = 11
    Const COL_GRI_SODIMAC_DET_TIPDOC As Integer = 12

    '===============================================
    'ENCABEADO CONSTRUMART
    '===============================================
    Const COL_GRI_CONSTRUMART_ENC_SELECCION As Integer = 0
    Const COL_GRI_CONSTRUMART_ENC_OCOMPRA As Integer = 1
    Const COL_GRI_CONSTRUMART_ENC_FCOMPROMISO As Integer = 2

    '===============================================
    'DETALLE CONSTRUMART
    '===============================================
    Const COL_GRI_CONSTRUMART_DET_OCFECHA As Integer = 0
    Const COL_GRI_CONSTRUMART_DET_OCOMPRA As Integer = 1
    Const COL_GRI_CONSTRUMART_DET_OCLOCAL As Integer = 2
    Const COL_GRI_CONSTRUMART_DET_OCGUIA As Integer = 3
    Const COL_GRI_CONSTRUMART_DET_OCITEMS As Integer = 4
    Const COL_GRI_CONSTRUMART_DET_OCCANTIDAD As Integer = 5
    Const COL_GRI_CONSTRUMART_DET_OCBULTOS As Integer = 6

    '===============================================
    'ASN CONSTRUMART
    '===============================================
    Const COL_GRI_CONSTRUMART_ASN_LPN As Integer = 0
    Const COL_GRI_CONSTRUMART_ASN_OCOMPRA As Integer = 1
    Const COL_GRI_CONSTRUMART_ASN_LOCAL As Integer = 2
    Const COL_GRI_CONSTRUMART_ASN_POSICION As Integer = 3
    Const COL_GRI_CONSTRUMART_ASN_SKU As Integer = 4
    Const COL_GRI_CONSTRUMART_ASN_CANTIDAD As Integer = 5
    Const COL_GRI_CONSTRUMART_ASN_CODIGO As Integer = 6


    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Private Sub frm_etiqueta_lpn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        lblLeyenda.BackColor = Color.FromArgb(255, 214, 214)
        lblLeyenda.ForeColor = Color.FromArgb(253, 49, 49)

        Call OCULTA_PESTANA()
        Call CARGA_COMBO_CLIENTE()

        Call CONFIGURA_COLUMNAS()
        Call CONFIGURA_COLUMNAS_ENCABEZADO_EASY()
        Call CONFIGURA_COLUMNAS_DETALLE_EASY()
        Call CONFIGURA_COLUMNAS_ABCDIN_VV()
        Call CONFIGURA_COLUMNAS_ABCDIN_ARC_VV()
        Call CONFIGURA_COLUMNAS_ENCABEZADO_ABCDIN()
        Call CONFIGURA_COLUMNAS_ENCABEZADO_RIPLEY()
        Call CONFIGURA_COLUMNAS_DETALLE_RIPLEY()
        Call CONFIGURA_COLUMNAS_ENCABEZADO_SODIMAC()
        Call CONFIGURA_COLUMNAS_ENCABEZADO_CONSTRUMART()
        Call CONFIGURA_COLUMNAS_DETALLE_CONSTRUMART()
        cargoFormulario = True
    End Sub

#Region "EASY"
    Private Sub CONFIGURA_COLUMNAS_ENCABEZADO_EASY()
        GrillaOCEasy.Columns(COL_GRI_EASY_ENC_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaOCEasy.Columns(COL_GRI_EASY_ENC_OCOMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaOCEasy.Columns(COL_GRI_EASY_ENC_FCOMPROMISO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub CONFIGURA_COLUMNAS_DETALLE_EASY()
        GrillaDetalleEasy.Columns(COL_GRI_EASY_DET_OCOMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleEasy.Columns(COL_GRI_EASY_DET_FCOMPROMISO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleEasy.Columns(COL_GRI_EASY_DET_CODIGO_LOCAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleEasy.Columns(COL_GRI_EASY_DET_NOMBRE_LOCAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleEasy.Columns(COL_GRI_EASY_DET_LPN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleEasy.Columns(COL_GRI_EASY_DET_SKU).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleEasy.Columns(COL_GRI_EASY_DET_SKU_NOMBRE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleEasy.Columns(COL_GRI_EASY_DET_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleEasy.Columns(COL_GRI_EASY_DET_CODIGO_FAVATEX).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub SELECCIONA_OC_ENCABEZADO_LPN_EASY()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0

        Dim diaDesde As String = ""
        Dim mesDesde As String = ""

        Dim diaHasta As String = ""
        Dim mesHasta As String = ""

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing

            class_etiqueta.cnn = _cnn
            If txtPicCodigo.Text = "0" Or txtPicCodigo.Text = "" Then
                class_etiqueta.pic_codigo = 0
            Else
                class_etiqueta.pic_codigo = CLng(txtPicCodigo.Text)
            End If

            If txtOCEasy.Text = "" Or txtOCEasy.Text = "0" Then
                class_etiqueta.oc_numero = 0
            Else
                class_etiqueta.oc_numero = CLng(txtOCEasy.Text)
            End If

            If chkFiltro.Checked = True Then
                'desde
                If CStr(dtpFechaOCDesde.Value.Month).Length = 1 Then
                    mesDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Month))
                Else
                    mesDesde = CStr(dtpFechaOCDesde.Value.Month)
                End If

                If CStr(dtpFechaOCDesde.Value.Day).Length = 1 Then
                    diaDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Day))
                Else
                    diaDesde = CStr(dtpFechaOCDesde.Value.Day)
                End If

                'Hasta
                If CStr(dtpFechaOCHasta.Value.Month).Length = 1 Then
                    mesHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Month))
                Else
                    mesHasta = CStr(dtpFechaOCHasta.Value.Month)
                End If

                If CStr(dtpFechaOCHasta.Value.Day).Length = 1 Then
                    diaHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Day))
                Else
                    diaHasta = CStr(dtpFechaOCHasta.Value.Day)
                End If

                class_etiqueta.fechaDesde = CStr(dtpFechaOCDesde.Value.Year) + mesDesde + diaDesde
                class_etiqueta.fechaHasta = CStr(dtpFechaOCHasta.Value.Year) + mesHasta + diaHasta
            Else
                class_etiqueta.fechaDesde = "19000101"
                class_etiqueta.fechaHasta = "20501231"
            End If

            _msg = ""
            GrillaOCEasy.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_ENCABEZADO_ORDENES_EASY(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("orden_compra") > 0 Then
                        Do While fila < ds.Tables(0).Rows.Count
                            GrillaOCEasy.Rows.Add(False, ds.Tables(0).Rows(fila)("orden_compra"),
                                                    ds.Tables(0).Rows(fila)("fecha_orden"))
                            fila = fila + 1
                        Loop
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\SELECCIONA_OC_ENCABEZADO_LPN_EASY", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "SELECCIONA_OC_ENCABEZADO_LPN_EASY", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    Private Sub SELECCIONA_OC_DETALLE_LPN_EASY()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Dim strCadena As String = ""
        Dim ds As DataSet = New DataSet
        Dim _msg As String
        ds = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor
            GrillaDetalleEasy.Rows.Clear()
            GrillaPackingEasy.Rows.Clear()
            Do While fila <= GrillaOCEasy.RowCount - 1
                If GrillaOCEasy.Rows(fila).Cells(COL_GRI_EASY_ENC_SELECCION).Value = True Then
                    If strCadena = "" Then
                        strCadena = GrillaOCEasy.Rows(fila).Cells(COL_GRI_EASY_ENC_OCOMPRA).Value.ToString + ","
                    Else
                        strCadena = strCadena + GrillaOCEasy.Rows(fila).Cells(COL_GRI_EASY_ENC_OCOMPRA).Value.ToString + ","
                    End If

                End If
                fila = fila + 1
            Loop

            If strCadena = "" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("Debe seleccionar a lo menos una Orden de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            fila = 0

            class_etiqueta.cnn = _cnn
            class_etiqueta.strCadena = strCadena

            _msg = ""
            GrillaDetalleEasy.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_DETALLE_ORDENES_EASY(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("numero_orden") > 0 Then
                        Do While fila < ds.Tables(0).Rows.Count
                            GrillaDetalleEasy.Rows.Add(ds.Tables(0).Rows(fila)("numero_orden"),
                                                       ds.Tables(0).Rows(fila)("fecha_entrega"),
                                                       ds.Tables(0).Rows(fila)("codigo_local"),
                                                       ds.Tables(0).Rows(fila)("nombre_local"),
                                                       ds.Tables(0).Rows(fila)("numero_lpn"),
                                                       ds.Tables(0).Rows(fila)("sku_cliente"),
                                                       ds.Tables(0).Rows(fila)("sku_nombre"),
                                                       ds.Tables(0).Rows(fila)("cantidad"),
                                                       ds.Tables(0).Rows(fila)("codigo_favatex"),
                                                       ds.Tables(0).Rows(fila)("agrupado"))
                            fila = fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS_DETALLE_EASY()
                    End If
                End If
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show(_msg + "\SELECCIONA_OC_DETALLE_LPN_EASY", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message + " " + "SELECCIONA_OC_DETALLE_LPN_EASY", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    Private Sub btnBuscaDetallesEasy_Click(sender As Object, e As EventArgs) Handles btnBuscaDetallesEasy.Click
        Call SELECCIONA_OC_DETALLE_LPN_EASY()
    End Sub
    Private Sub btnCreaLPNEasy_Click(sender As Object, e As EventArgs) Handles btnCreaLPNEasy.Click
        Dim fila As Integer = 0
        Dim fila2 As Integer = 0
        Dim Contador As Integer = 0
        Dim vPrefijo As String = ""
        Dim vCorrelativoU As String = ""
        Dim vCorrelativoS As String = ""
        Dim LargoPrefijo As Integer = 0
        Dim Correlativo As Long = 0
        Dim Respuesta As Integer = 0
        Dim newCorrelativo As String = ""
        Dim Grupo As String = ""
        Try
            UltimoCorrelativoLPNEasy = 0

            'Do While fila < GrillaLPNParis.RowCount
            '    If GrillaLPNParis.Item(COL_GRI_SELECCION, fila).Value = True Then
            '        Contador = Contador + 1
            '    End If
            '    fila = fila + 1
            'Loop


            Call SELECCIONA_ULTIMO_LPN(vPrefijo, vCorrelativoU, vCorrelativoS)
            If vCorrelativoS = "" Then
                MessageBox.Show("No es posible generar el siguiente LPN de impresión" _
                                + Chr(10) + "pongase en contacto con el area de Desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            PrefijoLPNEasy = vPrefijo
            LargoPrefijo = vPrefijo.Length
            Correlativo = CLng(Mid(vCorrelativoU, LargoPrefijo + 1, vCorrelativoU.Length))
            Respuesta = MessageBox.Show("Ultimo correlativo imprenso: " + vCorrelativoU + ", Correlativo siguiente: " + vCorrelativoS + "" _
                        + Chr(10) + "¿Desea generar los LPN para los registros seleccionados", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' PrefijoLPNEasy = Format(Correlativo, "000000000")

            If Respuesta = vbNo Then
                Exit Sub
            End If


            fila = 0
            fila2 = 0
            Do While fila < GrillaDetalleEasy.RowCount
                Correlativo = Correlativo + 1
                newCorrelativo = Format(Correlativo, "000000000")
                Grupo = GrillaDetalleEasy.Item(COL_GRI_EASY_DET_GRUPO, fila).Value

                Do While fila2 < GrillaDetalleEasy.RowCount
                    If GrillaDetalleEasy.Item(COL_GRI_EASY_DET_GRUPO, fila2).Value = Grupo Then
                        GrillaDetalleEasy.Item(COL_GRI_EASY_DET_LPN, fila2).Value = PrefijoLPNEasy + newCorrelativo.ToString
                    Else
                        'newCorrelativo = Format(Correlativo + 1, "000000000")
                        Exit Do
                    End If
                    fila2 = fila2 + 1
                Loop
                fila = fila2
            Loop

            If Correlativo > 0 Then
                UltimoCorrelativoLPNEasy = Correlativo
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GUARDA_LPN_EASY() As Boolean
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        GUARDA_LPN_EASY = False

        Try
            codigoImpresion = DateTime.Now.ToString
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                Do While fila < GrillaDetalleEasy.RowCount
                    class_etiqueta_lpn.easy_id_impresion = codigoImpresion
                    class_etiqueta_lpn.easy_orden_compra = GrillaDetalleEasy.Item(COL_GRI_EASY_DET_OCOMPRA, fila).Value
                    class_etiqueta_lpn.easy_fecha_compromiso = GrillaDetalleEasy.Item(COL_GRI_EASY_DET_FCOMPROMISO, fila).Value
                    class_etiqueta_lpn.easy_cod_local = GrillaDetalleEasy.Item(COL_GRI_EASY_DET_CODIGO_LOCAL, fila).Value
                    class_etiqueta_lpn.easy_nombre_local = GrillaDetalleEasy.Item(COL_GRI_EASY_DET_NOMBRE_LOCAL, fila).Value
                    class_etiqueta_lpn.easy_lpn = GrillaDetalleEasy.Item(COL_GRI_EASY_DET_LPN, fila).Value
                    class_etiqueta_lpn.easy_sku_cliente = GrillaDetalleEasy.Item(COL_GRI_EASY_DET_SKU, fila).Value
                    class_etiqueta_lpn.easy_sku_nombre = GrillaDetalleEasy.Item(COL_GRI_EASY_DET_SKU_NOMBRE, fila).Value
                    class_etiqueta_lpn.easy_cantidad = GrillaDetalleEasy.Item(COL_GRI_EASY_DET_CANTIDAD, fila).Value
                    class_etiqueta_lpn.easy_cod_favatex = GrillaDetalleEasy.Item(COL_GRI_EASY_DET_CODIGO_FAVATEX, fila).Value
                    ds = class_etiqueta_lpn.LPN_GUARDA_DATOS_PARA_ARCHIVO_ETIQUETA_EASY(_msgError, conexion)
                    If _msgError <> "" Then
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        ds = Nothing
                        MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    Else
                        If ds.Tables(0).Rows(0)("codigo") < 0 Then
                            If conexion.State = ConnectionState.Open Then
                                conexion.Close()
                            End If
                            ds = Nothing
                            MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Function
                        End If
                    End If

                    fila = fila + 1
                Loop

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing
                'EasyIdImpresion = codigoImpresion
                GUARDA_LPN_EASY = True
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub ELIMINA_REGISTRO_IMPRESION_EASY()
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0

        Try
            class_etiqueta_lpn.cnn = _cnn
            class_etiqueta_lpn.idImpresion = codigoImpresion

            ds = class_etiqueta_lpn.ELIMINA_DATOS_LPN_EASY(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("codigo") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            ds = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ELIMINA_REGISTRO_IMPRESION_RIPLEY()
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0

        Try
            class_etiqueta_lpn.cnn = _cnn
            class_etiqueta_lpn.idImpresion = codigoImpresion

            ds = class_etiqueta_lpn.ELIMINA_DATOS_LPN_RIPLEY(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("codigo") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            ds = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#End Region

#Region "RIPLEY"
    Private Sub CONFIGURA_COLUMNAS_ENCABEZADO_RIPLEY()
        GrillaRipleyOC.Columns(COL_GRI_RIPLEY_ENC_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaRipleyOC.Columns(COL_GRI_RIPLEY_ENC_OCOMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaRipleyOC.Columns(COL_GRI_RIPLEY_ENC_FCOMPROMISO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub CONFIGURA_COLUMNAS_DETALLE_RIPLEY()
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_OCOMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_FCOMPROMISO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_CODIGO_SUCURSAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_NOMBRE_SUCURSAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_CODIGO_DEPTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_NOMBRE_DEPTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_LPN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_SKU).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_SKU_NOMBRE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleRipley.Columns(COL_GRI_RIPLEY_DET_CODIGO_FAVATEX).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub SELECCIONA_OC_ENCABEZADO_LPN_RIPLEY()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0

        Dim diaDesde As String = ""
        Dim mesDesde As String = ""

        Dim diaHasta As String = ""
        Dim mesHasta As String = ""

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing

            class_etiqueta.cnn = _cnn
            If txtPKRipley.Text = "0" Or txtPKRipley.Text = "" Then
                class_etiqueta.pic_codigo = 0
            Else
                class_etiqueta.pic_codigo = CLng(txtPKRipley.Text)
            End If

            If txtOCRipley.Text = "" Or txtOCRipley.Text = "0" Then
                class_etiqueta.oc_numero = 0
            Else
                class_etiqueta.oc_numero = CLng(txtOCRipley.Text)
            End If

            If chkFechaRipley.Checked = True Then
                'desde
                If CStr(dtpRipleyDesde.Value.Month).Length = 1 Then
                    mesDesde = Trim("0" + CStr(dtpRipleyDesde.Value.Month))
                Else
                    mesDesde = CStr(dtpRipleyDesde.Value.Month)
                End If

                If CStr(dtpRipleyDesde.Value.Day).Length = 1 Then
                    diaDesde = Trim("0" + CStr(dtpRipleyDesde.Value.Day))
                Else
                    diaDesde = CStr(dtpRipleyDesde.Value.Day)
                End If

                'Hasta
                If CStr(dtpRipleyHasta.Value.Month).Length = 1 Then
                    mesHasta = Trim("0" + CStr(dtpRipleyHasta.Value.Month))
                Else
                    mesHasta = CStr(dtpRipleyHasta.Value.Month)
                End If

                If CStr(dtpRipleyHasta.Value.Day).Length = 1 Then
                    diaHasta = Trim("0" + CStr(dtpRipleyHasta.Value.Day))
                Else
                    diaHasta = CStr(dtpRipleyHasta.Value.Day)
                End If

                class_etiqueta.fechaDesde = CStr(dtpRipleyDesde.Value.Year) + mesDesde + diaDesde
                class_etiqueta.fechaHasta = CStr(dtpRipleyHasta.Value.Year) + mesHasta + diaHasta
            Else
                class_etiqueta.fechaDesde = "19000101"
                class_etiqueta.fechaHasta = "20501231"
            End If

            _msg = ""
            GrillaRipleyOC.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_ENCABEZADO_ORDENES_RIPLEY(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("orden_compra") > 0 Then
                        Do While fila < ds.Tables(0).Rows.Count
                            GrillaRipleyOC.Rows.Add(False, ds.Tables(0).Rows(fila)("orden_compra"),
                                                    ds.Tables(0).Rows(fila)("fecha_orden"))
                            fila = fila + 1
                        Loop
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\SELECCIONA_OC_ENCABEZADO_LPN_RIPLEY", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Call CONFIGURA_COLUMNAS_ENCABEZADO_RIPLEY()

        Catch ex As Exception
            MsgBox(ex.Message + " " + "SELECCIONA_OC_ENCABEZADO_LPN_RIPLEY", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
#End Region


#Region "LA POLAR"
    Private Sub ButtonBuscarArchivo_Click(sender As Object, e As EventArgs) Handles ButtonBuscarArchivo.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Dim cantidad As Integer = 0

        openFileDialog1.Filter = "Text Files (*.csv)|*.csv"

        openFileDialog1.Title = "seleccione archivo"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            _rutaArchivo = openFileDialog1.FileName
            lblNombreArchivo.Text = (System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName)) & (System.IO.Path.GetExtension(openFileDialog1.FileName))
            Button2.Enabled = True

            ''txtMultiNombre.Text = _nombreArchivo
            '_extension = System.IO.Path.GetExtension(openFileDialog1.FileName)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim respuesta As Integer = 0

        If _rutaArchivo = "" Then
            MessageBox.Show("Debe seleccionar un archivo vàlido para guardar e imprimir las etiquetas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If EXISTE_REGISTRO_ARCHIVO(lblNombreArchivo.Text) = True Then
            respuesta = MessageBox.Show("Ya existen registros asociados al archivo seleccionado" _
                             + Chr(10) + "¿Desea volver a generar los datos e imprimir las etiquetas? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbYes Then
                If ELIMINA_DATOS_LPN(lblNombreArchivo.Text) = False Then
                    Exit Sub
                End If

                If ListFiles(_rutaArchivo, ".csv", lblNombreArchivo.Text) = False Then
                    Exit Sub
                End If
                Call IMPRIMIR_LPN_LA_POLAR(lblNombreArchivo.Text)
            Else
                respuesta = 0
                respuesta = MessageBox.Show("¿Desea reimprimir las etiquetas que ya estan ingresadas? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If respuesta = vbYes Then
                    Call IMPRIMIR_LPN_LA_POLAR(lblNombreArchivo.Text)
                End If
            End If
        Else
            If ListFiles(_rutaArchivo, ".csv", lblNombreArchivo.Text) = False Then
                Exit Sub
            End If
            Call IMPRIMIR_LPN_LA_POLAR(lblNombreArchivo.Text)
        End If

        lblNombreArchivo.Text = ""
        Button2.Enabled = False

    End Sub
    Private Sub IMPRIMIR_LPN_LA_POLAR(ByVal nombreArchivo As String)
        Dim frm As frm_imprimir = New frm_imprimir
        frm.Origen = "LPN_LP"
        frm.nombreArchivo = nombreArchivo
        frm.ShowDialog()
    End Sub
    Private Function EXISTE_REGISTRO_ARCHIVO(ByVal nomArchivo As String) As Boolean
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing

            EXISTE_REGISTRO_ARCHIVO = False

            class_etiqueta.cnn = _cnn
            class_etiqueta.elp_nombrearchivo = nomArchivo
            _msg = ""
            ds = class_etiqueta.CARTERA_SELECCIONA_LPN_LA_POLAR(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("elp_nombrearchivo") <> "" Then
                        EXISTE_REGISTRO_ARCHIVO = True
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\EXISTE_REGISTRO_ARCHIVO", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            EXISTE_REGISTRO_ARCHIVO = False
            MsgBox(ex.Message + " " + "EXISTE_REGISTRO_ARCHIVO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Function
    Private Function ELIMINA_DATOS_LPN(ByVal nomArchivo As String) As Boolean
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing

            ELIMINA_DATOS_LPN = False

            class_etiqueta.cnn = _cnn
            class_etiqueta.elp_nombrearchivo = nomArchivo
            _msg = ""
            ds = class_etiqueta.CARTERA_ELIMINA_LPN_LA_POLAR(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("codigo") <> 0 Then
                        ELIMINA_DATOS_LPN = True
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\ELIMINA_DATOS_LPN", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ELIMINA_DATOS_LPN = False
            MsgBox(ex.Message + " " + "ELIMINA_DATOS_LPN", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Function
    Private Function CargaDatosLaPolar(ByVal DATOS As String(), ByVal rutaArchivo As String, ByVal nombreArchivo As String) As Boolean
        Dim classOrdenes As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Dim Cantidad As String = ""
        Try

            CargaDatosLaPolar = False
            If DATOS.Length <> 20 Then
                MessageBox.Show("La cantidad de columna del archivo no es compatible con los parámetros configurados" _
                 + Chr(10) + "Revice el formato del archivo antes de subirlo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Function
            End If

            _elp_nombrearchivo = nombreArchivo
            _elp_sucursaldestino = DATOS(0).ToString()
            _elp_area = DATOS(1).ToString()
            _elp_proveedor = DATOS(2).ToString()
            _elp_lote = DATOS(3).ToString()
            _elp_ordencompra = DATOS(4).ToString()
            _elp_nd = DATOS(5).ToString()
            _elp_codigoproveedor = DATOS(6).ToString()
            _elp_descripcion = DATOS(7).ToString()
            _elp_plu = DATOS(8).ToString()
            _elp_rubro = DATOS(9).ToString()

            Cantidad = CInt(Strings.Replace(Strings.Replace(DATOS(10), Chr(34), ""), ".", ",")) 'DATOS(10).ToString
            _elp_cantidad = Cantidad

            _elp_boleta = DATOS(11).ToString()
            _elp_cliente = DATOS(12).ToString()
            _elp_direccion = DATOS(13).ToString()
            _elp_comuna = DATOS(14).ToString()
            _elp_ciudad = DATOS(15).ToString()
            _elp_ruta = DATOS(16).ToString()
            _elp_fechaentrega = DATOS(17).ToString()
            _elp_fechacompra = DATOS(18).ToString()
            _elp_nbulto = DATOS(19).ToString()

            classOrdenes.cnn = _cnn
            classOrdenes.elp_nombrearchivo = _elp_nombrearchivo
            classOrdenes.elp_sucursaldestino = _elp_sucursaldestino
            classOrdenes.elp_area = _elp_area
            classOrdenes.elp_proveedor = _elp_proveedor
            classOrdenes.elp_lote = _elp_lote
            classOrdenes.elp_ordencompra = _elp_ordencompra
            classOrdenes.elp_nd = _elp_nd
            classOrdenes.elp_codigoproveedor = _elp_codigoproveedor
            classOrdenes.elp_descripcion = _elp_descripcion
            classOrdenes.elp_plu = _elp_plu
            classOrdenes.elp_rubro = _elp_rubro
            classOrdenes.elp_cantidad = _elp_cantidad
            classOrdenes.elp_boleta = _elp_boleta
            classOrdenes.elp_cliente = _elp_cliente
            classOrdenes.elp_direccion = _elp_direccion
            classOrdenes.elp_comuna = _elp_comuna
            classOrdenes.elp_ciudad = _elp_ciudad
            classOrdenes.elp_ruta = _elp_ruta
            classOrdenes.elp_fechaentrega = _elp_fechaentrega
            classOrdenes.elp_fechacompra = _elp_fechacompra
            classOrdenes.elp_nbulto = _elp_nbulto

            ds = classOrdenes.CARTERA_GUARDA_LPN_LA_POLAR(_msgError)
            If ds.Tables(0).Rows.Count > 0 Then
                If _msgError = "" Then
                    If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                        MessageBox.Show(ds.Tables(0).Rows(0)("MENSAJE"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ds = Nothing
                        Exit Function
                    End If
                Else
                    MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ds = Nothing
                    Exit Function
                End If
            End If

            CargaDatosLaPolar = True

        Catch ex As Exception
            MessageBox.Show(_msgError, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            CargaDatosLaPolar = False
        End Try
    End Function
    Private Function ListFiles(ByVal folderPath As String, ByVal extension As String, ByVal nombreArchivo As String) As Boolean
        Dim rutaArchivo As String = ""
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim filaActual As Integer = 1

        Dim Delimiter As String = ","
        Dim sLine As String = ""
        Dim FILA As String()
        Dim charVar As Char
        Dim contador As Integer

        Dim I As Integer = 1

        charVar = ","
        ListFiles = False

        Try
            Dim objReader As New StreamReader(folderPath)
            filaActual = 1
            I = 1

            Do
                sLine = objReader.ReadLine()

                If Not sLine Is Nothing Then
                    If filaActual > 1 Then
                        FILA = Util.Cadenas.Csv.LineaCsvToArray(charVar, sLine)
                        If CargaDatosLaPolar(FILA, rutaArchivo, nombreArchivo) = False Then
                            Exit Function
                        End If
                        contador = contador + 1

                        I = I + 1
                    End If
                End If
                filaActual = filaActual + 1
            Loop Until sLine Is Nothing
            ListFiles = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

#End Region

#Region "PARIS"
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Call SELECCIONA_DATOS_PARA_LPN_PARIS()
        Call CONFIGURA_COLUMNAS()
    End Sub
    Private Sub PINTA_CELDA_ROJO_GRILLA_LPN_PARIS(ByVal fila As Integer)
        GrillaLPNParis.Item(COL_GRI_SELECCION, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_SELECCION, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_TIPO_FLUJO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_TIPO_FLUJO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_ID_BULTO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_ID_BULTO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_ID_PALLET, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_ID_PALLET, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_DESC_PRODUCTO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_DESC_PRODUCTO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_COD_LOCAL, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_COD_LOCAL, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_COD_DEPTO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_COD_DEPTO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_DEPTO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_DEPTO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_DESC_LOCAL, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_DESC_LOCAL, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_COD_PARIS, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_COD_PARIS, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_COD_PROVEEDOR, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_COD_PROVEEDOR, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_NUM_ORDEN, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_NUM_ORDEN, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_CANTIDAD, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_CANTIDAD, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        GrillaLPNParis.Item(COL_GRI_NUM_DOC_TRIBUTARIO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        GrillaLPNParis.Item(COL_GRI_NUM_DOC_TRIBUTARIO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)
    End Sub
    Private Sub SELECCIONA_DATOS_PARA_LPN_PARIS()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing

            class_etiqueta.cnn = _cnn
            class_etiqueta.car_codigo = cmbCliente.SelectedValue

            If txtPicking.Text = "" Then
                class_etiqueta.pic_codigo = 0
            Else
                class_etiqueta.pic_codigo = CInt(txtPicking.Text)
            End If

            If txtOrdenCompra.Text = "" Then
                class_etiqueta.oc_numero = 0
            Else
                class_etiqueta.oc_numero = CLng(txtOrdenCompra.Text)
            End If

            _msg = ""
            GrillaLPNParisExcel.Rows.Clear()
            GrillaLPNParis.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_DATOS_PARIS(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("sku_cartera_nombre") <> "" Then
                        Do While fila < ds.Tables(0).Rows.Count
                            GrillaLPNParis.Rows.Add(False, ds.Tables(0).Rows(fila)("tipo_flujo"),
                                                    ds.Tables(0).Rows(fila)("lpn_generado"),
                                                    "",
                                                    ds.Tables(0).Rows(fila)("sku_cartera_nombre"),
                                                    ds.Tables(0).Rows(fila)("cod_local"),
                                                    ds.Tables(0).Rows(fila)("cod_depto"),
                                                    ds.Tables(0).Rows(fila)("depto"),
                                                    ds.Tables(0).Rows(fila)("descripcion_local"),
                                                    ds.Tables(0).Rows(fila)("sku_cartera"),
                                                    ds.Tables(0).Rows(fila)("pro_codigointerno"),
                                                    ds.Tables(0).Rows(fila)("pic_ocnumero"),
                                                    ds.Tables(0).Rows(fila)("pic_cantidad_encontrada"),
                                                    ds.Tables(0).Rows(fila)("fac_numero"))

                            If ds.Tables(0).Rows(fila)("fac_numero") = 0 Then
                                Call PINTA_CELDA_ROJO_GRILLA_LPN_PARIS(fila)
                            End If


                            fila = fila + 1
                        Loop
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\SELECCIONA_DATOS_PARA_LPN_PARIS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "SELECCIONA_DATOS_PARA_LPN_PARIS", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    Private Sub btnGeneraLPNParis_Click(sender As Object, e As EventArgs) Handles btnGeneraLPNParis.Click
        Dim fila As Integer = 0
        Dim Contador As Integer = 0
        Dim vPrefijo As String = ""
        Dim vCorrelativoU As String = ""
        Dim vCorrelativoS As String = ""
        Dim LargoPrefijo As Integer = 0
        Dim Correlativo As Long = 0
        Dim Respuesta As Integer = 0
        Try
            UltimoCorrelativoLPNParis = 0

            Do While fila < GrillaLPNParis.RowCount
                If GrillaLPNParis.Item(COL_GRI_SELECCION, fila).Value = True Then
                    Contador = Contador + 1
                End If
                fila = fila + 1
            Loop

            If Contador = 0 Then
                MessageBox.Show("Debe seleccionar a lo menos un registro para generar el LPN y crear el Packing List", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Call SELECCIONA_ULTIMO_LPN(vPrefijo, vCorrelativoU, vCorrelativoS)
            If vCorrelativoS = "" Then
                MessageBox.Show("No es posible generar el siguiente LPN de impresión" _
                                + Chr(10) + "pongase en contacto con el area de Desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            PrefijoLPNParis = vPrefijo
            LargoPrefijo = vPrefijo.Length
            Correlativo = CLng(Mid(vCorrelativoU, LargoPrefijo + 1, vCorrelativoU.Length))
            Respuesta = MessageBox.Show("Ultimo correlativo imprenso: " + vCorrelativoU + ", Correlativo siguiente: " + vCorrelativoS + "" _
                        + Chr(10) + "¿Desea generar los LPN para los registros seleccionados", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Respuesta = vbNo Then
                Exit Sub
            End If

            fila = 0
            Do While fila < GrillaLPNParis.RowCount
                If GrillaLPNParis.Item(COL_GRI_SELECCION, fila).Value = True Then
                    Correlativo = Correlativo + 1
                    GrillaLPNParis.Item(COL_GRI_ID_BULTO, fila).Value = Trim(vPrefijo + Correlativo.ToString)
                End If
                fila = fila + 1
            Loop

            If Correlativo > 0 Then
                UltimoCorrelativoLPNParis = Correlativo
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GrillaLPNParis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaLPNParis.CellContentClick
        Dim chkCell As DataGridViewCheckBoxCell = Me.GrillaLPNParis.Rows(e.RowIndex).Cells(COL_GRI_SELECCION)
        If e.ColumnIndex = Me.GrillaLPNParis.Columns.Item(COL_GRI_SELECCION).Index Then
            chkCell.Value = Not chkCell.Value
        End If

        If GrillaLPNParis.Rows(e.RowIndex).Cells(COL_GRI_NUM_DOC_TRIBUTARIO).Value = 0 Then
            chkCell.Value = False
        End If

    End Sub
    Private Sub SELECCIONA_ULTIMO_LPN(ByRef vPrefijo As String, ByRef vCorrelativoU As String, ByRef vCorrelativoS As String)
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing

            class_etiqueta.cnn = _cnn
            class_etiqueta.car_codigo = cmbCliente.SelectedValue

            _msg = ""
            ds = class_etiqueta.LPN_SELECCIONA_SIGUIENTE(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("lpn_prefijo") <> "" Then
                        vPrefijo = ds.Tables(0).Rows(fila)("lpn_prefijo")
                        vCorrelativoU = ds.Tables(0).Rows(fila)("correlativoU")
                        vCorrelativoS = ds.Tables(0).Rows(fila)("correlativoS")
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\SELECCIONA_ULTIMO_LPN", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "SELECCIONA_ULTIMO_LPN", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    Private Sub CONFIGURA_COLUMNAS()
        GrillaLPNParis.Columns(COL_GRI_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_TIPO_FLUJO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_ID_BULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_ID_PALLET).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_DESC_PRODUCTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_COD_LOCAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_COD_DEPTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_DEPTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_DESC_LOCAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_COD_PARIS).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_COD_PROVEEDOR).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_NUM_ORDEN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLPNParis.Columns(COL_GRI_NUM_DOC_TRIBUTARIO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub btnCreaArchivo_Click(sender As Object, e As EventArgs) Handles btnCreaArchivo.Click
        Dim fila As Integer = 0
        Dim contador As Integer = 0
        Dim respuesta As Integer = 0

        Try
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            GrillaLPNParisExcel.Rows.Clear()
            Do While fila < GrillaLPNParis.RowCount
                contador = contador + 1
                If GrillaLPNParis.Item(COL_GRI_ID_BULTO, fila).Value <> "" Then
                    GrillaLPNParisExcel.Rows.Add(GrillaLPNParis.Item(COL_GRI_TIPO_FLUJO, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_ID_BULTO, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_ID_PALLET, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_DESC_PRODUCTO, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_COD_LOCAL, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_COD_DEPTO, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_DEPTO, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_DESC_LOCAL, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_COD_PARIS, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_COD_PROVEEDOR, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_NUM_ORDEN, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_CANTIDAD, fila).Value,
                                                 GrillaLPNParis.Item(COL_GRI_NUM_DOC_TRIBUTARIO, fila).Value)
                End If
                fila = fila + 1
            Loop

            If contador = 0 Then
                MessageBox.Show("No existen LPN generados en los registros seleccionado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            respuesta = MessageBox.Show("Esta acción podría tardar un tiempo considerable dependiendo de la cantidad de registros," _
                                                + Chr(10) + "¿Desea seguir ejecutando la acción?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Exit Sub
            End If

            Call ExportarDatosExcel(Me.GrillaLPNParisExcel, "")


            Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message + "\btnCreaArchivo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub GUARDA_LPN_PARIS()
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()


        Try
            codigoImpresion = DateTime.Now.ToString
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                Do While fila < GrillaLPNParisExcel.RowCount
                    class_etiqueta_lpn.idImpresion = codigoImpresion
                    class_etiqueta_lpn.cod_local = GrillaLPNParisExcel.Item(COL_GRI_COD_LOCAL - 1, fila).Value
                    class_etiqueta_lpn.cod_depto = GrillaLPNParisExcel.Item(COL_GRI_COD_DEPTO - 1, fila).Value
                    class_etiqueta_lpn.depto = GrillaLPNParisExcel.Item(COL_GRI_DEPTO - 1, fila).Value
                    class_etiqueta_lpn.descripcion_local = GrillaLPNParisExcel.Item(COL_GRI_DESC_LOCAL - 1, fila).Value
                    class_etiqueta_lpn.lpn = GrillaLPNParisExcel.Item(COL_GRI_ID_BULTO - 1, fila).Value
                    ds = class_etiqueta_lpn.GUARDA_DATOS_LPN_PARIS(_msgError, conexion)
                    If _msgError <> "" Then
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        ds = Nothing
                        MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        If ds.Tables(0).Rows(0)("codigo") < 0 Then
                            If conexion.State = ConnectionState.Open Then
                                conexion.Close()
                            End If
                            ds = Nothing
                            MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If

                    fila = fila + 1
                Loop

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnImprimirEtiquetaParis_Click(sender As Object, e As EventArgs) Handles btnImprimirEtiquetaParis.Click
        Try
            Call GUARDA_LPN_PARIS()
            Call GUARDA_ULTIMO_CORRELATIVO(PrefijoLPNParis, UltimoCorrelativoLPNParis)

            Dim frm As frm_imprimir = New frm_imprimir
            frm.Origen = "LPN_PARIS"
            frm.codImpresionLPN = codigoImpresion
            frm.ShowDialog()

            Call ELIMINA_REGISTRO_IMPRESION_PARIS()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ELIMINA_REGISTRO_IMPRESION_PARIS()
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0

        Try
            class_etiqueta_lpn.cnn = _cnn
            class_etiqueta_lpn.idImpresion = codigoImpresion

            ds = class_etiqueta_lpn.ELIMINA_DATOS_LPN_PARIS(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("codigo") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            ds = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "ABCDIN"
    Private Sub CONFIGURA_COLUMNAS_ABCDIN_VV()
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_LPN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_RAZON_SOCIAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_FECHA_ENTREGA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_NUM_CITA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_ORDEN_COMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_FACTURA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_BOLETA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_VENDIDO_POR).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_FECHA_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_NOMBRE_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_RUT_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_FONO_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_DIRECCION_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_COMUNA_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_LOCALIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_CODIGO_SUCURSAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_NOMBRE_SUCURSAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_SKU_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_NUMERO_BULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_SKU_NOMBRE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_VOLUMEN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_DET_VV_PESO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub CONFIGURA_COLUMNAS_ABCDIN_ARC_VV()
        dtAbcDinVV.Columns(COL_GRI_ABC_ARC_VV_OC).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_ARC_VV_SUC1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_ARC_VV_SUC2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_ARC_VV_LPN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_ARC_VV_SKU).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_ARC_VV_CANT).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_ARC_VV_FAC).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_ARC_VV_TIP).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_ARC_VV_BOL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtAbcDinVV.Columns(COL_GRI_ABC_ARC_VV_RUT).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Public Sub ExportarDatosExcelAbcDinVV(ByVal DataGridView1 As DataGridView, ByVal titulo As String)
        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            ''Encabezado  
            '.Range("A1:L1").Merge()
            '.Range("A1:L1").Value = "COMERCIAL FAVATEX"
            '.Range("A1:L1").Font.Bold = True
            '.Range("A1:L1").Font.Size = 15
            ''Copete  
            '.Range("A2:L2").Merge()
            '.Range("A2:L2").Value = titulo
            '.Range("A2:L2").Font.Bold = True
            '.Range("A2:L2").Font.Size = 12

            Const primeraLetra As Char = "A"
            Const primerNumero As Short = 1
            Dim Letra As Char, UltimaLetra As Char
            Dim Numero As Integer, UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(primeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
            'Establecer formatos de las columnas de la hija de cálculo  
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
            Letra = primeraLetra
            Numero = primerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + Letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 8
                    'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                    If Letra = "C" Then
                        'objCelda.EntireColumn.NumberFormat = "000000000000000000"
                        'objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If

                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If
                End If
            Next

            Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzq As String = LetraIzq

            'CARGA DE DATOS  
            Dim i As Integer = Numero + 1

            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(primeraLetra) - 1
                Letra = primeraLetra
                cod_letra = Asc(primeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra
                        ' acá debería realizarse la carga  
                        If Letra = "D" Then
                            '.Cells(i, strColumna) = Str(reg.Cells(c.Index).Value)
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", "'" + reg.Cells(c.Index).Value)
                        Else
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                        End If

                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i

            'Dibujar las líneas de las columnas  
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(primeraLetra)
            Letra = primeraLetra
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                    'objCelda.BorderAround()
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                End If
            Next

            'Dibujar el border exterior grueso  
            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            'objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With

        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub

    Public Sub ExportarDatosExcelAbcDinAGE(ByVal DataGridView1 As DataGridView, ByVal titulo As String)
        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            ''Encabezado  
            '.Range("A1:L1").Merge()
            '.Range("A1:L1").Value = "COMERCIAL FAVATEX"
            '.Range("A1:L1").Font.Bold = True
            '.Range("A1:L1").Font.Size = 15
            ''Copete  
            '.Range("A2:L2").Merge()
            '.Range("A2:L2").Value = titulo
            '.Range("A2:L2").Font.Bold = True
            '.Range("A2:L2").Font.Size = 12

            Const primeraLetra As Char = "A"
            Const primerNumero As Short = 1
            Dim Letra As Char, UltimaLetra As Char
            Dim Numero As Integer, UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(primeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
            'Establecer formatos de las columnas de la hija de cálculo  
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
            Letra = primeraLetra
            Numero = primerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + Letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 8
                    'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                    If Letra = "C" Then
                        'objCelda.EntireColumn.NumberFormat = "000000000000000000"
                        'objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If

                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If
                End If
            Next

            Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzq As String = LetraIzq

            'CARGA DE DATOS  
            Dim i As Integer = Numero + 1

            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(primeraLetra) - 1
                Letra = primeraLetra
                cod_letra = Asc(primeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra
                        ' acá debería realizarse la carga  
                        If Letra = "D" Then
                            '.Cells(i, strColumna) = Str(reg.Cells(c.Index).Value)
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", "'" + reg.Cells(c.Index).Value)
                        Else
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                        End If

                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i

            'Dibujar las líneas de las columnas  
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(primeraLetra)
            Letra = primeraLetra
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                    'objCelda.BorderAround()
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                End If
            Next

            'Dibujar el border exterior grueso  
            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            'objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With

        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub

    Private Sub btnBuscarOCAbcVV_Click(sender As Object, e As EventArgs) Handles btnBuscarOCAbcVV.Click
        'Dim myValue As String = InputBox("Ingrese el numero de Cita", "Solicitud de cita", 0)

        'If String.IsNullOrEmpty(myValue) Then
        '    Exit Sub
        'End If

        'If IsNumeric(myValue) = False Then
        '    MessageBox.Show("Número de Cita no válido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        'If myValue = 0 Then
        '    MessageBox.Show("Número de Cita no válido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        Call SELECCIONA_DATOS_PARA_LPN_ABCDIN_VV(0)


    End Sub

    Private Sub SELECCIONA_DATOS_PARA_LPN_ABCDIN_VV(ByVal numCita As Long)
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing

            class_etiqueta.cnn = _cnn


            If txtAbcPKVV.Text = "" Then
                class_etiqueta.pic_codigo = 0
            Else
                class_etiqueta.pic_codigo = CInt(txtAbcPKVV.Text)
            End If

            If txtAbcOCVV.Text = "" Then
                class_etiqueta.oc_numero = 0
            Else
                class_etiqueta.oc_numero = CLng(txtAbcOCVV.Text)
            End If

            class_etiqueta.num_cita = numCita

            _msg = ""
            'GrillaLPNParisExcel.Rows.Clear()
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            dtAbcDinVV.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_DATOS_ABCDIN_VV(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("sku_nombre") <> "" Then
                        Do While fila < ds.Tables(0).Rows.Count
                            dtAbcDinVV.Rows.Add(False,
                                                "",
                                                ds.Tables(0).Rows(fila)("razon_social"),
                                                ds.Tables(0).Rows(fila)("fecha_entrega"),
                                                ds.Tables(0).Rows(fila)("numero_cita"),
                                                ds.Tables(0).Rows(fila)("numero_oc"),
                                                ds.Tables(0).Rows(fila)("numero_factura"),
                                                ds.Tables(0).Rows(fila)("numero_boleta"),
                                                ds.Tables(0).Rows(fila)("vendido_por"),
                                                ds.Tables(0).Rows(fila)("fecha_cliente"),
                                                ds.Tables(0).Rows(fila)("nombre_cliente"),
                                                ds.Tables(0).Rows(fila)("rut_cliente"),
                                                ds.Tables(0).Rows(fila)("fono_cliente"),
                                                ds.Tables(0).Rows(fila)("direc_cliente"),
                                                ds.Tables(0).Rows(fila)("comuna_cliente"),
                                                ds.Tables(0).Rows(fila)("local_cliente"),
                                                ds.Tables(0).Rows(fila)("cod_sucursal"),
                                                ds.Tables(0).Rows(fila)("nom_sucursal"),
                                                ds.Tables(0).Rows(fila)("sku_cliente"),
                                                ds.Tables(0).Rows(fila)("cantidad"),
                                                ds.Tables(0).Rows(fila)("num_bulto"),
                                                ds.Tables(0).Rows(fila)("sku_nombre"),
                                                ds.Tables(0).Rows(fila)("volumne"),
                                                ds.Tables(0).Rows(fila)("peso"))

                            'If ds.Tables(0).Rows(fila)("fac_numero") = 0 Then
                            '    Call PINTA_CELDA_ROJO_GRILLA_LPN_PARIS(fila)
                            'End If


                            fila = fila + 1
                        Loop
                    End If
                End If
            Else
                Cursor = System.Windows.Forms.Cursors.Default
                MessageBox.Show(_msg + "\LPN_SELECCIONA_DATOS_ABCDIN_VV", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Cursor = System.Windows.Forms.Cursors.Default
            MsgBox(ex.Message + " " + "LPN_SELECCIONA_DATOS_ABCDIN_VV", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Function GUARDA_LPN_ABCDIN_VV() As Boolean
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        GUARDA_LPN_ABCDIN_VV = False

        Try
            codigoImpresion = DateTime.Now.ToString
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                Do While fila < dtAbcDinVV.RowCount
                    If dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_LPN, fila).Value <> "" Then
                        class_etiqueta_lpn.abcdin_id_impresion = codigoImpresion
                        class_etiqueta_lpn.abcdin_razon_social = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_RAZON_SOCIAL, fila).Value
                        class_etiqueta_lpn.abcdin_fecha_entrega = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_FECHA_ENTREGA, fila).Value
                        class_etiqueta_lpn.abcdin_numero_cita = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_NUM_CITA, fila).Value
                        class_etiqueta_lpn.abcdin_numero_oc = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_ORDEN_COMPRA, fila).Value
                        class_etiqueta_lpn.abcdin_numero_factura = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_FACTURA, fila).Value
                        class_etiqueta_lpn.abcdin_numero_boleta = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_BOLETA, fila).Value
                        class_etiqueta_lpn.abcdin_vendido_por = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_VENDIDO_POR, fila).Value
                        class_etiqueta_lpn.abcdin_fecha_cliente = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_FECHA_CLIENTE, fila).Value
                        class_etiqueta_lpn.abcdin_nombre_cliente = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_NOMBRE_CLIENTE, fila).Value
                        class_etiqueta_lpn.abcdin_rut_cliente = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_RUT_CLIENTE, fila).Value
                        class_etiqueta_lpn.abcdin_fono_cliente = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_FONO_CLIENTE, fila).Value
                        class_etiqueta_lpn.abcdin_direc_cliente = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_DIRECCION_CLIENTE, fila).Value
                        class_etiqueta_lpn.abcdin_comuna_cliente = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_COMUNA_CLIENTE, fila).Value
                        class_etiqueta_lpn.abcdin_local_cliente = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_LOCALIDAD, fila).Value
                        class_etiqueta_lpn.abcdin_cod_sucursal = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_CODIGO_SUCURSAL, fila).Value
                        class_etiqueta_lpn.abcdin_nom_sucursal = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_NOMBRE_SUCURSAL, fila).Value
                        class_etiqueta_lpn.abcdin_sku_cliente = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_SKU_CLIENTE, fila).Value
                        class_etiqueta_lpn.abcdin_cantidad = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_CANTIDAD, fila).Value
                        class_etiqueta_lpn.abcdin_num_bulto = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_NUMERO_BULTO, fila).Value
                        class_etiqueta_lpn.abcdin_sku_nombre = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_SKU_NOMBRE, fila).Value
                        class_etiqueta_lpn.abcdin_volumne = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_VOLUMEN, fila).Value
                        class_etiqueta_lpn.abcdin_peso = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_PESO, fila).Value
                        class_etiqueta_lpn.abcdin_lpn = dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_LPN, fila).Value
                        ds = class_etiqueta_lpn.LPN_GUARDA_DATOS_PARA_ARCHIVO_ETIQUETA_ABCDIN_VV(_msgError, conexion)
                        If _msgError <> "" Then
                            If conexion.State = ConnectionState.Open Then
                                conexion.Close()
                            End If
                            ds = Nothing
                            MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Function
                        Else
                            If ds.Tables(0).Rows(0)("codigo") < 0 Then
                                If conexion.State = ConnectionState.Open Then
                                    conexion.Close()
                                End If
                                ds = Nothing
                                MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Function
                            End If
                        End If
                    End If

                    fila = fila + 1
                Loop

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing
                'EasyIdImpresion = codigoImpresion
                GUARDA_LPN_ABCDIN_VV = True
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub ELIMINA_REGISTRO_IMPRESION_ABCDIN()
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0

        Try
            class_etiqueta_lpn.cnn = _cnn
            class_etiqueta_lpn.abcdin_id_impresion = codigoImpresion

            ds = class_etiqueta_lpn.ELIMINA_DATOS_LPN_ABCDIN_VV(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("codigo") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            ds = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#End Region

#Region "SODIMAC"
    Private Sub SELECCIONA_OC_ENCABEZADO_LPN_SODIMAC()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0

        Dim diaDesde As String = ""
        Dim mesDesde As String = ""

        Dim diaHasta As String = ""
        Dim mesHasta As String = ""

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing

            class_etiqueta.cnn = _cnn
            If txtPKSodimac.Text = "0" Or txtPKSodimac.Text = "" Then
                class_etiqueta.pic_codigo = 0
            Else
                class_etiqueta.pic_codigo = CLng(txtPKSodimac.Text)
            End If

            If txtOCSodimac.Text = "" Or txtOCSodimac.Text = "0" Then
                class_etiqueta.oc_numero = 0
            Else
                class_etiqueta.oc_numero = CLng(txtOCSodimac.Text)
            End If

            If chkSodimac.Checked = True Then
                'desde
                If CStr(dtpDesdeSodimac.Value.Month).Length = 1 Then
                    mesDesde = Trim("0" + CStr(dtpDesdeSodimac.Value.Month))
                Else
                    mesDesde = CStr(dtpDesdeSodimac.Value.Month)
                End If

                If CStr(dtpDesdeSodimac.Value.Day).Length = 1 Then
                    diaDesde = Trim("0" + CStr(dtpDesdeSodimac.Value.Day))
                Else
                    diaDesde = CStr(dtpDesdeSodimac.Value.Day)
                End If

                'Hasta
                If CStr(txtHastaSodimac.Value.Month).Length = 1 Then
                    mesHasta = Trim("0" + CStr(txtHastaSodimac.Value.Month))
                Else
                    mesHasta = CStr(txtHastaSodimac.Value.Month)
                End If

                If CStr(txtHastaSodimac.Value.Day).Length = 1 Then
                    diaHasta = Trim("0" + CStr(txtHastaSodimac.Value.Day))
                Else
                    diaHasta = CStr(txtHastaSodimac.Value.Day)
                End If

                class_etiqueta.fechaDesde = CStr(dtpDesdeSodimac.Value.Year) + mesDesde + diaDesde
                class_etiqueta.fechaHasta = CStr(txtHastaSodimac.Value.Year) + mesHasta + diaHasta
            Else
                class_etiqueta.fechaDesde = "19000101"
                class_etiqueta.fechaHasta = "20501231"
            End If


            If optVentaVerde.Checked = True Then
                class_etiqueta.tipo_orden = "VV"
            ElseIf optStock.Checked = True Then
                class_etiqueta.tipo_orden = "CD"
            ElseIf optPredistribuida.Checked = True Then
                class_etiqueta.tipo_orden = "XD"
            End If

            'If optVentaVerde.Checked = True Then
            '    class_etiqueta.esPimare = True
            '    chkPimares.Visible = False
            'Else
            '    chkPimares.Visible = True
            'End If


            class_etiqueta.esPimare = chkPimares.Checked



            _msg = ""
            GrillaDetalleSodimac.Rows.Clear()
            GrillaOCSodimac.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_ENCABEZADO_ORDENES_SODIMAC(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("orden_compra") > 0 Then
                        Do While fila < ds.Tables(0).Rows.Count
                            GrillaOCSodimac.Rows.Add(False, ds.Tables(0).Rows(fila)("orden_compra"),
                                                    ds.Tables(0).Rows(fila)("fecha_orden"),
                                                    ds.Tables(0).Rows(fila)("tipo_orden"))
                            fila = fila + 1
                        Loop
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\SELECCIONA_OC_ENCABEZADO_LPN_SODIMAC", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Call CONFIGURA_COLUMNAS_ENCABEZADO_SODIMAC()

        Catch ex As Exception
            MsgBox(ex.Message + " " + "SELECCIONA_OC_ENCABEZADO_LPN_SODIMAC", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CONFIGURA_COLUMNAS_ENCABEZADO_SODIMAC()
        GrillaOCSodimac.Columns(COL_GRI_SODIMAC_ENC_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaOCSodimac.Columns(COL_GRI_SODIMAC_ENC_OCOMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaOCSodimac.Columns(COL_GRI_SODIMAC_ENC_FCOMPROMISO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaOCSodimac.Columns(COL_GRI_SODIMAC_ENC_TIPOORDEN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub CONFIGURA_COLUMNAS_DETALLE_SODIMAC()
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_IDPROVE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_OCOMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_CDENTRE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_NUMSUCU).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_CODSUCU).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_NUMLPN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_UPC).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_SKUCLIE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_SKUDESC).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_CODFAV).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_NUMDOC).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalleSodimac.Columns(COL_GRI_SODIMAC_DET_TIPDOC).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Function GUARDA_LPN_SODIMAC() As Boolean
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        GUARDA_LPN_SODIMAC = False

        Try
            codigoImpresion = DateTime.Now.ToString
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                Do While fila < GrillaDetalleSodimac.RowCount

                    class_etiqueta_lpn.sodimac_id_impresion = codigoImpresion
                    class_etiqueta_lpn.sodimac_id_proveedor = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_IDPROVE, fila).Value
                    class_etiqueta_lpn.sodimac_con_ocnumero = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_OCOMPRA, fila).Value
                    class_etiqueta_lpn.sodimac_cdEntregaCodigoa = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_CDENTRE, fila).Value
                    class_etiqueta_lpn.sodimac_sucNombre = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_NUMSUCU, fila).Value
                    class_etiqueta_lpn.sodimac_sucCodigo = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_CODSUCU, fila).Value
                    class_etiqueta_lpn.sodimac_lpn = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_NUMLPN, fila).Value
                    class_etiqueta_lpn.sodimac_upc = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_UPC, fila).Value
                    class_etiqueta_lpn.sodimac_con_skucliente = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_SKUCLIE, fila).Value
                    class_etiqueta_lpn.sodimac_con_skudescripcion = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_SKUDESC, fila).Value
                    class_etiqueta_lpn.sodimac_codigo_favatex = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_CODFAV, fila).Value
                    class_etiqueta_lpn.sodimac_cantidad = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_CANTIDAD, fila).Value
                    class_etiqueta_lpn.sodimac_numero_documento = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_NUMDOC, fila).Value
                    class_etiqueta_lpn.sodimac_tipo_documento = GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_TIPDOC, fila).Value

                    ds = class_etiqueta_lpn.LPN_GUARDA_DATOS_PARA_ARCHIVO_ETIQUETA_SODIMAC(_msgError, conexion)
                    If _msgError <> "" Then
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        ds = Nothing
                        MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    Else
                        If ds.Tables(0).Rows(0)("codigo") < 0 Then
                            If conexion.State = ConnectionState.Open Then
                                conexion.Close()
                            End If
                            ds = Nothing
                            MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Function
                        End If
                    End If

                    fila = fila + 1
                Loop

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing
                'EasyIdImpresion = codigoImpresion
                GUARDA_LPN_SODIMAC = True
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub ELIMINA_REGISTRO_IMPRESION_SODIMAC()
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0

        Try
            class_etiqueta_lpn.cnn = _cnn
            class_etiqueta_lpn.idImpresion = codigoImpresion

            ds = class_etiqueta_lpn.ELIMINA_DATOS_LPN_SODIMAC(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("codigo") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            ds = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region


#Region "CONSTRUMART"
    Private Sub CONFIGURA_COLUMNAS_ENCABEZADO_CONSTRUMART()
        GrillaConstrumartOC.Columns(COL_GRI_CONSTRUMART_ENC_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaConstrumartOC.Columns(COL_GRI_CONSTRUMART_ENC_OCOMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaConstrumartOC.Columns(COL_GRI_CONSTRUMART_ENC_FCOMPROMISO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub CONFIGURA_COLUMNAS_DETALLE_CONSTRUMART()
        grillaDetalleConstrumart.Columns(COL_GRI_CONSTRUMART_DET_OCFECHA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDetalleConstrumart.Columns(COL_GRI_CONSTRUMART_DET_OCOMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDetalleConstrumart.Columns(COL_GRI_CONSTRUMART_DET_OCLOCAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDetalleConstrumart.Columns(COL_GRI_CONSTRUMART_DET_OCGUIA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDetalleConstrumart.Columns(COL_GRI_CONSTRUMART_DET_OCITEMS).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDetalleConstrumart.Columns(COL_GRI_CONSTRUMART_DET_OCCANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaDetalleConstrumart.Columns(COL_GRI_CONSTRUMART_DET_OCBULTOS).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub CONFIGURA_COLUMNAS_ASN_CONSTRUMART()
        grillaASNConstrumart.Columns(COL_GRI_CONSTRUMART_ASN_LPN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaASNConstrumart.Columns(COL_GRI_CONSTRUMART_ASN_OCOMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaASNConstrumart.Columns(COL_GRI_CONSTRUMART_ASN_LOCAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaASNConstrumart.Columns(COL_GRI_CONSTRUMART_ASN_POSICION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaASNConstrumart.Columns(COL_GRI_CONSTRUMART_ASN_SKU).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaASNConstrumart.Columns(COL_GRI_CONSTRUMART_ASN_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        grillaASNConstrumart.Columns(COL_GRI_CONSTRUMART_ASN_CODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

#End Region


    Private Sub CONFIGURA_COLUMNAS_ENCABEZADO_ABCDIN()
        GrillaOCAbcDin.Columns(COL_GRI_ABCDIN_ENC_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaOCAbcDin.Columns(COL_GRI_ABCDIN_ENC_OCOMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaOCAbcDin.Columns(COL_GRI_ABCDIN_ENC_FCOMPROMISO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub CONFIGURA_COLUMNAS_DETALLE_ABCDIN()
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_LPN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_RAZON_SOCIAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_FECHA_ENTREGA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_NUM_CITA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_ORDEN_COMPRA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_FACTURA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_COD_SUCURSAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_NOMBRE_SUCURSAL).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_SKU_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_NUM_BULTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_SKU_NOMBRE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_VOLUMEN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dtArchivoAbcDinAG.Columns(COL_GRI_ABCDIN_DET_PESO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Public Sub ExportarDatosExcel(ByVal DataGridView1 As DataGridView, ByVal titulo As String)
        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            'Encabezado  
            .Range("A1:L1").Merge()
            .Range("A1:L1").Value = "COMERCIAL FAVATEX"
            .Range("A1:L1").Font.Bold = True
            .Range("A1:L1").Font.Size = 15
            'Copete  
            .Range("A2:L2").Merge()
            .Range("A2:L2").Value = titulo
            .Range("A2:L2").Font.Bold = True
            .Range("A2:L2").Font.Size = 12

            Const primeraLetra As Char = "A"
            Const primerNumero As Short = 3
            Dim Letra As Char, UltimaLetra As Char
            Dim Numero As Integer, UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(primeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
            'Establecer formatos de las columnas de la hija de cálculo  
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
            Letra = primeraLetra
            Numero = primerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + Letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 8
                    'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If
                End If
            Next

            Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzq As String = LetraIzq

            'CARGA DE DATOS  
            Dim i As Integer = Numero + 1

            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(primeraLetra) - 1
                Letra = primeraLetra
                cod_letra = Asc(primeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra
                        ' acá debería realizarse la carga  
                        .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                        '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
                        '.Range(strColumna + i, strColumna + i).In()  

                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i

            'Dibujar las líneas de las columnas  
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(primeraLetra)
            Letra = primeraLetra
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                    objCelda.BorderAround()
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                End If
            Next

            'Dibujar el border exterior grueso  
            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With

        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub


    Public Sub ExportarDatosExcelEasy(ByVal DataGridView1 As DataGridView, ByVal titulo As String)
        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            ''Encabezado  
            '.Range("A1:L1").Merge()
            '.Range("A1:L1").Value = "COMERCIAL FAVATEX"
            '.Range("A1:L1").Font.Bold = True
            '.Range("A1:L1").Font.Size = 15
            ''Copete  
            '.Range("A2:L2").Merge()
            '.Range("A2:L2").Value = titulo
            '.Range("A2:L2").Font.Bold = True
            '.Range("A2:L2").Font.Size = 12

            Const primeraLetra As Char = "A"
            Const primerNumero As Short = 1
            Dim Letra As Char, UltimaLetra As Char
            Dim Numero As Integer, UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(primeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
            'Establecer formatos de las columnas de la hija de cálculo  
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
            Letra = primeraLetra
            Numero = primerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + Letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 8
                    'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                    If Letra = "C" Then
                        'objCelda.EntireColumn.NumberFormat = "000000000000000000"
                        'objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If

                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If
                End If
            Next

            Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzq As String = LetraIzq

            'CARGA DE DATOS  
            Dim i As Integer = Numero + 1

            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(primeraLetra) - 1
                Letra = primeraLetra
                cod_letra = Asc(primeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra
                        ' acá debería realizarse la carga  
                        If Letra = "C" Then
                            '.Cells(i, strColumna) = Str(reg.Cells(c.Index).Value)
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", "'" + reg.Cells(c.Index).Value)
                        Else
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                        End If

                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i

            'Dibujar las líneas de las columnas  
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(primeraLetra)
            Letra = primeraLetra
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                    'objCelda.BorderAround()
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                End If
            Next

            'Dibujar el border exterior grueso  
            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            'objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With

        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub

    Public Sub ExportarDatosExcelRipley(ByVal DataGridView1 As DataGridView, ByVal titulo As String)
        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            ''Encabezado  
            '.Range("A1:L1").Merge()
            '.Range("A1:L1").Value = "COMERCIAL FAVATEX"
            '.Range("A1:L1").Font.Bold = True
            '.Range("A1:L1").Font.Size = 15
            ''Copete  
            '.Range("A2:L2").Merge()
            '.Range("A2:L2").Value = titulo
            '.Range("A2:L2").Font.Bold = True
            '.Range("A2:L2").Font.Size = 12

            Const primeraLetra As Char = "A"
            Const primerNumero As Short = 1
            Dim Letra As Char, UltimaLetra As Char
            Dim Numero As Integer, UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(primeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
            'Establecer formatos de las columnas de la hija de cálculo  
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
            Letra = primeraLetra
            Numero = primerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + Letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 8
                    'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                    If Letra = "C" Then
                        'objCelda.EntireColumn.NumberFormat = "000000000000000000"
                        'objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If

                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If
                End If
            Next

            Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzq As String = LetraIzq

            'CARGA DE DATOS  
            Dim i As Integer = Numero + 1

            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(primeraLetra) - 1
                Letra = primeraLetra
                cod_letra = Asc(primeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra
                        ' acá debería realizarse la carga  
                        If Letra = "B" Then
                            '.Cells(i, strColumna) = Str(reg.Cells(c.Index).Value)
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", "'" + reg.Cells(c.Index).Value)
                        Else
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                        End If

                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i

            'Dibujar las líneas de las columnas  
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(primeraLetra)
            Letra = primeraLetra
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                    'objCelda.BorderAround()
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                End If
            Next

            'Dibujar el border exterior grueso  
            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            'objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With

        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub

    Public Sub ExportarDatosExcelSodimac(ByVal DataGridView1 As DataGridView, ByVal titulo As String)
        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            ''Encabezado  
            '.Range("A1:L1").Merge()
            '.Range("A1:L1").Value = "COMERCIAL FAVATEX"
            '.Range("A1:L1").Font.Bold = True
            '.Range("A1:L1").Font.Size = 15
            ''Copete  
            '.Range("A2:L2").Merge()
            '.Range("A2:L2").Value = titulo
            '.Range("A2:L2").Font.Bold = True
            '.Range("A2:L2").Font.Size = 12

            Const primeraLetra As Char = "A"
            Const primerNumero As Short = 1
            Dim Letra As Char, UltimaLetra As Char
            Dim Numero As Integer, UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(primeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
            'Establecer formatos de las columnas de la hija de cálculo  
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
            Letra = primeraLetra
            Numero = primerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + Letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 8
                    'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                    If Letra = "C" Then
                        'objCelda.EntireColumn.NumberFormat = "000000000000000000"
                        'objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If

                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If
                End If
            Next

            Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzq As String = LetraIzq

            'CARGA DE DATOS  
            Dim i As Integer = Numero + 1

            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(primeraLetra) - 1
                Letra = primeraLetra
                cod_letra = Asc(primeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra
                        ' acá debería realizarse la carga  
                        If Letra = "F" Or Letra = "G" Then
                            '.Cells(i, strColumna) = Str(reg.Cells(c.Index).Value)
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", "'" + reg.Cells(c.Index).Value)
                        Else
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                        End If

                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i

            'Dibujar las líneas de las columnas  
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(primeraLetra)
            Letra = primeraLetra
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                    'objCelda.BorderAround()
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                End If
            Next

            'Dibujar el border exterior grueso  
            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            'objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With

        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub


    Private Sub OCULTA_PESTANA()
        TabPage1.Parent = Nothing
        TabPage2.Parent = Nothing
        TabPage3.Parent = Nothing
        TabPage4.Parent = Nothing
        TabPage7.Parent = Nothing
        TabPage8.Parent = Nothing
        TabPage9.Parent = Nothing
    End Sub
    Private Sub CARGA_COMBO_CLIENTE()
        Dim _msg As String
        Try
            Dim classCliente As class_cartera = New class_cartera
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classCliente.cnn = _cnn
            _msg = ""
            ds = classCliente.CARGA_COMBO_CLIENTE_CON_LPN(_msg)
            If _msg = "" Then
                Me.cmbCliente.DataSource = ds.Tables(0)
                Me.cmbCliente.DisplayMember = "MENSAJE"
                Me.cmbCliente.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_TIPO_BOLETA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    Private Sub cmbCliente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCliente.SelectionChangeCommitted
        Call OCULTA_PESTANA()
        If cmbCliente.SelectedValue = CLIENTES.LA_POLAR Then
            grpLaPolar.Visible = True
            lblNombreArchivo.Text = ""
            ButtonBuscarArchivo.Enabled = True
            Button2.Enabled = True

            TabPage1.Parent = TabControl1
            TabPage1.Text = "EMPRESAS LA POLAR  S.A"
        ElseIf cmbCliente.SelectedValue = CLIENTES.PARIS Then
            TabPage2.Parent = TabControl1
            TabPage2.Text = "PARIS"
        ElseIf cmbCliente.SelectedValue = CLIENTES.EASY Then
            TabPage3.Parent = TabControl1
            TabPage3.Text = "EASY S.A."
        ElseIf cmbCliente.SelectedValue = CLIENTES.ABCDIN Then
            TabPage4.Parent = TabControl1
            TabPage4.Text = "ABCDIN"
        ElseIf cmbCliente.SelectedValue = CLIENTES.RIPLEY Then
            TabPage7.Parent = TabControl1
            TabPage7.Text = "RIPLEY"
        ElseIf cmbCliente.SelectedValue = CLIENTES.SODIMAC Then
            TabPage8.Parent = TabControl1
            TabPage8.Text = "SODIMAC"
        ElseIf cmbCliente.SelectedValue = CLIENTES.CONSTRUMART Then
            TabPage9.Parent = TabControl1
            TabPage9.Text = "CONSTRUMART"
        Else
            ButtonBuscarArchivo.Enabled = False
            grpLaPolar.Visible = False
            Button2.Enabled = False
        End If
    End Sub
    Private Sub ButtonPrefijo_Click(sender As Object, e As EventArgs) Handles ButtonPrefijo.Click
        If cmbCliente.Text = "" Then
            MessageBox.Show("Debe seleccionar un cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim frm As frm_lpn_correlativos = New frm_lpn_correlativos
        frm.cnn = _cnn
        frm.car_codigo = cmbCliente.SelectedValue
        frm.car_nombre = cmbCliente.Text
        frm.ShowDialog()
    End Sub
    Private Sub GUARDA_ULTIMO_CORRELATIVO(ByVal Prefijo As String, ByVal Ultimocorrelativo As Long)
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0

        Try
            class_etiqueta_lpn.cnn = _cnn
            class_etiqueta_lpn.car_codigo = cmbCliente.SelectedValue
            class_etiqueta_lpn.lpn_prefijo = Prefijo
            class_etiqueta_lpn.lpn_ultimocorrimpreso = Ultimocorrelativo

            ds = class_etiqueta_lpn.GUARDA_DATOS_LPN(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("codigo") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            ds = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub chkFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltro.CheckedChanged
        If chkFiltro.Checked = True Then
            dtpFechaOCDesde.Enabled = True
            dtpFechaOCHasta.Enabled = True
        ElseIf chkFiltro.Checked = False Then
            dtpFechaOCDesde.Enabled = False
            dtpFechaOCHasta.Enabled = False
        End If
    End Sub
    Private Sub btnBuscaOCEasy_Click(sender As Object, e As EventArgs) Handles btnBuscaOCEasy.Click
        Call SELECCIONA_OC_ENCABEZADO_LPN_EASY()
    End Sub
    Private Sub GrillaOCEasy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaOCEasy.CellContentClick
        Dim chkCell As DataGridViewCheckBoxCell = Me.GrillaOCEasy.Rows(e.RowIndex).Cells(COL_GRI_EASY_ENC_SELECCION)
        If e.ColumnIndex = Me.GrillaOCEasy.Columns.Item(COL_GRI_EASY_ENC_SELECCION).Index Then
            chkCell.Value = Not chkCell.Value
        End If
    End Sub


    Private Sub GENERA_LPN_EASY()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Dim fila2 As Integer = 0
        Dim CodLocal As String = ""
        Dim sumaParaPallet As Integer = 0
        Dim strCadena As String = ""
        Dim ds As DataSet = New DataSet
        Dim _msg As String
        ds = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor
            Do While fila <= GrillaOCEasy.RowCount - 1
                If GrillaOCEasy.Rows(fila).Cells(COL_GRI_EASY_ENC_SELECCION).Value = True Then
                    If strCadena = "" Then
                        strCadena = GrillaOCEasy.Rows(fila).Cells(COL_GRI_EASY_ENC_OCOMPRA).Value.ToString + ","
                    Else
                        strCadena = strCadena + GrillaOCEasy.Rows(fila).Cells(COL_GRI_EASY_ENC_OCOMPRA).Value.ToString + ","
                    End If

                End If
                fila = fila + 1
            Loop

            If strCadena = "" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("Debe seleccionar a lo menos una Orden de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            fila = 0

            class_etiqueta.cnn = _cnn
            class_etiqueta.strCadena = strCadena

            _msg = ""
            GrillaDetalleEasy.Rows.Clear()
            ds = class_etiqueta.LPN_LOCALES_EASY(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("codigo_local") <> "" Then
                        Do While fila < ds.Tables(0).Rows.Count
                            CodLocal = ds.Tables(0).Rows(fila)("nombre_local")
                            sumaParaPallet = 0
                            Do While fila2 <= GrillaDetalleEasy.RowCount - 1
                                If CodLocal = GrillaDetalleEasy.Rows(fila).Cells(COL_GRI_EASY_DET_CODIGO_LOCAL).Value Then
                                    If sumaParaPallet = 0 Then
                                        sumaParaPallet = GrillaDetalleEasy.Rows(fila).Cells(COL_GRI_EASY_DET_CANTIDAD).Value
                                    End If
                                End If


                                sumaParaPallet = sumaParaPallet + GrillaDetalleEasy.Rows(fila).Cells(COL_GRI_EASY_DET_CANTIDAD).Value



                                If GrillaDetalleEasy.Rows(fila).Cells(COL_GRI_EASY_ENC_SELECCION).Value = True Then
                                    If strCadena = "" Then
                                        strCadena = GrillaOCEasy.Rows(fila).Cells(COL_GRI_EASY_ENC_OCOMPRA).Value.ToString + ","
                                    Else
                                        strCadena = strCadena + GrillaOCEasy.Rows(fila).Cells(COL_GRI_EASY_ENC_OCOMPRA).Value.ToString + ","
                                    End If

                                End If
                                fila = fila + 1
                            Loop
                        Loop
                    End If
                End If
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show(_msg + "\SELECCIONA_OC_DETALLE_LPN_EASY", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message + " " + "SELECCIONA_OC_DETALLE_LPN_EASY", MsgBoxStyle.Critical, Me.Text)
        End Try



    End Sub

    Private Sub btnEasyCreaArchivo_Click(sender As Object, e As EventArgs) Handles btnEasyCreaArchivo.Click
        Call CREAR_PACKING_EASY()
        'If GUARDA_LPN_EASY() = True Then

        'End If
    End Sub

    Private Sub CREAR_PACKING_EASY()
        Dim fila As Integer = 0
        Dim contador As Integer = 0
        Dim respuesta As Integer = 0

        Try
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            GrillaPackingEasy.Rows.Clear()
            Do While fila < GrillaDetalleEasy.RowCount
                If GrillaDetalleEasy.Item(COL_GRI_EASY_DET_LPN, fila).Value = "" Then
                    contador = contador + 1
                End If

                GrillaPackingEasy.Rows.Add(GrillaDetalleEasy.Item(COL_GRI_EASY_ARC_OCOMPRA, fila).Value,
                                           GrillaDetalleEasy.Item(COL_GRI_EASY_DET_CODIGO_LOCAL, fila).Value,
                                           GrillaDetalleEasy.Item(COL_GRI_EASY_DET_LPN, fila).Value,
                                           GrillaDetalleEasy.Item(COL_GRI_EASY_DET_SKU, fila).Value,
                                           GrillaDetalleEasy.Item(COL_GRI_EASY_DET_CANTIDAD, fila).Value)

                fila = fila + 1
            Loop

            If contador > 0 Then
                MessageBox.Show("Dentro de la selección existen registros sin LPN Generados" _
                                + Chr(10) + "Pongase en contacto con el area de desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Exit Sub
            End If

            respuesta = MessageBox.Show("Esta acción podría tardar un tiempo considerable dependiendo de la cantidad de registros," _
                                                + Chr(10) + "¿Desea seguir ejecutando la acción?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Exit Sub
            End If

            Call ExportarDatosExcelEasy(Me.GrillaPackingEasy, "")

            Cursor = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimirLPNEasy_Click(sender As Object, e As EventArgs) Handles btnImprimirLPNEasy.Click
        Try
            Call GUARDA_LPN_EASY()
            Call GUARDA_ULTIMO_CORRELATIVO(PrefijoLPNEasy, UltimoCorrelativoLPNEasy)

            Dim frm As frm_imprimir = New frm_imprimir
            frm.Origen = "LPN_EASY"
            frm.codImpresionLPN = codigoImpresion
            frm.ShowDialog()

            Call ELIMINA_REGISTRO_IMPRESION_EASY()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsolidado_Click(sender As Object, e As EventArgs) Handles btnConsolidado.Click
        Dim ordenesCompra As String = ""
        Dim contador As Integer = 0
        Dim fila As Integer = 0
        Try
            Do While fila < GrillaOCEasy.RowCount
                If GrillaOCEasy.Item(COL_GRI_EASY_ENC_SELECCION, fila).Value = True Then

                    If ordenesCompra = "" Then
                        ordenesCompra = GrillaOCEasy.Item(COL_GRI_EASY_ENC_OCOMPRA, fila).Value.ToString
                    Else
                        ordenesCompra = ordenesCompra + " | " + GrillaOCEasy.Item(COL_GRI_EASY_ENC_OCOMPRA, fila).Value.ToString
                    End If

                    contador = contador + 1
                End If

                fila = fila + 1
            Loop

            If contador = 0 Then
                MessageBox.Show("Debe seleccionar a lo menos una Orden de Compra")
                Exit Sub
            End If

            Call GUARDA_LPN_EASY()

            Dim frm As frm_imprimir = New frm_imprimir
            frm.Origen = "LPN_EASY_CONSOLIDADO"
            frm.codImpresionLPN = codigoImpresion
            frm.ordenesCompra = ordenesCompra
            frm.ShowDialog()

            Call ELIMINA_REGISTRO_IMPRESION_EASY()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged

    End Sub

    Private Sub btnGeneraLPNACB_VV_Click(sender As Object, e As EventArgs) Handles btnGeneraLPNACB_VV.Click
        Dim fila As Integer = 0
        Dim Contador As Integer = 0
        Dim vPrefijo As String = ""
        Dim vCorrelativoU As String = ""
        Dim vCorrelativoS As String = ""
        Dim LargoPrefijo As Integer = 0
        Dim Correlativo As Long = 0
        Dim Respuesta As Integer = 0
        Try

            Dim myValue As String = InputBox("Ingrese el numero de Cita", "Solicitud de cita", 0)

            If String.IsNullOrEmpty(myValue) Then
                Exit Sub
            End If

            If IsNumeric(myValue) = False Then
                MessageBox.Show("Número de Cita no válido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If myValue = 0 Then
                MessageBox.Show("Número de Cita no válido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            UltimoCorrelativoLPNABCDIN = 0

            Do While fila < dtAbcDinVV.RowCount
                If dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_SELECCION, fila).Value = True Then
                    Contador = Contador + 1
                End If
                fila = fila + 1
            Loop

            If Contador = 0 Then
                MessageBox.Show("Debe seleccionar a lo menos un registro para generar el LPN", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Call SELECCIONA_ULTIMO_LPN(vPrefijo, vCorrelativoU, vCorrelativoS)
            If vCorrelativoS = "" Then
                MessageBox.Show("No es posible generar el siguiente LPN de impresión" _
                                + Chr(10) + "pongase en contacto con el area de Desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            PrefijoLPNABCDIN = vPrefijo
            LargoPrefijo = vPrefijo.Length
            Correlativo = CLng(Mid(vCorrelativoU, LargoPrefijo + 1, vCorrelativoU.Length))
            Respuesta = MessageBox.Show("Ultimo correlativo imprenso: " + vCorrelativoU.PadLeft(7, "0") + ", Correlativo siguiente: " + vCorrelativoS.PadLeft(7, "0") + "" _
                        + Chr(10) + "¿Desea generar los LPN para los registros seleccionados", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Respuesta = vbNo Then
                Exit Sub
            End If



            fila = 0
            Do While fila < dtAbcDinVV.RowCount
                If dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_SELECCION, fila).Value = True Then
                    Correlativo = Correlativo + 1
                    dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_LPN, fila).Value = Trim(vPrefijo + Correlativo.ToString.PadLeft(7, "0"))
                    dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_NUM_CITA, fila).Value = myValue

                End If
                fila = fila + 1
            Loop

            If Correlativo > 0 Then
                UltimoCorrelativoLPNABCDIN = Correlativo
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtAbcDinVV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtAbcDinVV.CellContentClick
        Dim chkCell As DataGridViewCheckBoxCell = Me.dtAbcDinVV.Rows(e.RowIndex).Cells(COL_GRI_ABC_DET_VV_SELECCION)
        If e.ColumnIndex = Me.dtAbcDinVV.Columns.Item(COL_GRI_ABC_DET_VV_SELECCION).Index Then
            chkCell.Value = Not chkCell.Value
        End If

        'If dtAbcDinVV.Rows(e.RowIndex).Cells(COL_GRI_NUM_DOC_TRIBUTARIO).Value = 0 Then
        '    chkCell.Value = False
        'End If
    End Sub

    Private Sub btnCreaArchivoLPNAbcVV_Click(sender As Object, e As EventArgs) Handles btnCreaArchivoLPNAbcVV.Click
        Dim fila As Integer = 0
        Dim contador As Integer = 0
        Dim respuesta As Integer = 0

        Try
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            dtArchivoAbcDinVV.Rows.Clear()
            Do While fila < dtAbcDinVV.RowCount
                contador = contador + 1
                If dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_LPN, fila).Value <> "" Then
                    dtArchivoAbcDinVV.Rows.Add(dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_ORDEN_COMPRA, fila).Value,
                                                 dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_CODIGO_SUCURSAL, fila).Value,
                                                 dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_CODIGO_SUCURSAL, fila).Value,
                                                 dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_LPN, fila).Value,
                                                 dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_SKU_CLIENTE, fila).Value,
                                                 dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_CANTIDAD, fila).Value,
                                                 dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_FACTURA, fila).Value,
                                                 "EFAC",
                                                 dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_BOLETA, fila).Value,
                                                 dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_RUT_CLIENTE, fila).Value)
                End If
                fila = fila + 1
            Loop

            If contador = 0 Then
                MessageBox.Show("No existen LPN generados en los registros seleccionado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            respuesta = MessageBox.Show("Esta acción podría tardar un tiempo considerable dependiendo de la cantidad de registros," _
                                                + Chr(10) + "¿Desea seguir ejecutando la acción?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Exit Sub
            End If

            Call ExportarDatosExcelAbcDinVV(Me.dtArchivoAbcDinVV, "")


            Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message + "\btnCreaArchivo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimeEteAbcDinVV_Click(sender As Object, e As EventArgs) Handles btnImprimeEteAbcDinVV.Click
        Try
            Call GUARDA_LPN_ABCDIN_VV()
            Call GUARDA_ULTIMO_CORRELATIVO(PrefijoLPNABCDIN, UltimoCorrelativoLPNABCDIN)

            Dim frm As frm_imprimir = New frm_imprimir
            frm.Origen = "LPN_ABCDIN_VV"
            frm.codImpresionLPN = codigoImpresion
            frm.ShowDialog()

            Call ELIMINA_REGISTRO_IMPRESION_ABCDIN()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call SELECCIONA_OC_ENCABEZADO_LPN_ABCDIN_AGENDA()
    End Sub

    Private Sub SELECCIONA_OC_ENCABEZADO_LPN_ABCDIN_AGENDA()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0

        Dim diaDesde As String = ""
        Dim mesDesde As String = ""

        Dim diaHasta As String = ""
        Dim mesHasta As String = ""

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing

            class_etiqueta.cnn = _cnn
            If txtPicCodigo.Text = "0" Or txtPicCodigo.Text = "" Then
                class_etiqueta.pic_codigo = 0
            Else
                class_etiqueta.pic_codigo = CLng(txtPicCodigo.Text)
            End If

            If txtOCEasy.Text = "" Or txtOCEasy.Text = "0" Then
                class_etiqueta.oc_numero = 0
            Else
                class_etiqueta.oc_numero = CLng(txtOCEasy.Text)
            End If

            If chkFiltro.Checked = True Then
                'desde
                If CStr(dtpFechaOCDesde.Value.Month).Length = 1 Then
                    mesDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Month))
                Else
                    mesDesde = CStr(dtpFechaOCDesde.Value.Month)
                End If

                If CStr(dtpFechaOCDesde.Value.Day).Length = 1 Then
                    diaDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Day))
                Else
                    diaDesde = CStr(dtpFechaOCDesde.Value.Day)
                End If

                'Hasta
                If CStr(dtpFechaOCHasta.Value.Month).Length = 1 Then
                    mesHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Month))
                Else
                    mesHasta = CStr(dtpFechaOCHasta.Value.Month)
                End If

                If CStr(dtpFechaOCHasta.Value.Day).Length = 1 Then
                    diaHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Day))
                Else
                    diaHasta = CStr(dtpFechaOCHasta.Value.Day)
                End If

                class_etiqueta.fechaDesde = CStr(dtpFechaOCDesde.Value.Year) + mesDesde + diaDesde
                class_etiqueta.fechaHasta = CStr(dtpFechaOCHasta.Value.Year) + mesHasta + diaHasta
            Else
                class_etiqueta.fechaDesde = "19000101"
                class_etiqueta.fechaHasta = "20501231"
            End If

            _msg = ""
            GrillaOCAbcDin.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_ENCABEZADO_ORDENES_ABCDIN(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("orden_compra") > 0 Then
                        Do While fila < ds.Tables(0).Rows.Count
                            GrillaOCAbcDin.Rows.Add(False, ds.Tables(0).Rows(fila)("orden_compra"),
                                                    ds.Tables(0).Rows(fila)("fecha_orden"))
                            fila = fila + 1
                        Loop
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\SELECCIONA_OC_ENCABEZADO_LPN_ABCDIN_AGENDA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "SELECCIONA_OC_ENCABEZADO_LPN_ABCDIN_AGENDA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call SELECCIONA_OC_DETALLE_LPN_ABCDIN()
    End Sub

    Private Sub SELECCIONA_OC_DETALLE_LPN_ABCDIN()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Dim strCadena As String = ""
        Dim ds As DataSet = New DataSet
        Dim _msg As String
        ds = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor
            dtArchivoAbcDinAG.Rows.Clear()
            'GrillaPackingEasy.Rows.Clear()
            Do While fila <= GrillaOCAbcDin.RowCount - 1
                If GrillaOCAbcDin.Rows(fila).Cells(COL_GRI_ABCDIN_ENC_SELECCION).Value = True Then
                    If strCadena = "" Then
                        strCadena = GrillaOCAbcDin.Rows(fila).Cells(COL_GRI_ABCDIN_ENC_OCOMPRA).Value.ToString + ","
                    Else
                        strCadena = strCadena + GrillaOCAbcDin.Rows(fila).Cells(COL_GRI_ABCDIN_ENC_OCOMPRA).Value.ToString + ","
                    End If

                End If
                fila = fila + 1
            Loop

            If strCadena = "" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("Debe seleccionar a lo menos una Orden de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            fila = 0

            class_etiqueta.cnn = _cnn
            class_etiqueta.strCadena = strCadena

            _msg = ""
            dtArchivoAbcDinAG.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_DETALLE_ORDENES_ACBDIN_AG(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("numero_oc") > 0 Then
                        Do While fila < ds.Tables(0).Rows.Count
                            dtArchivoAbcDinAG.Rows.Add(False,
                                                       "",
                                                       ds.Tables(0).Rows(fila)("razon_social"),
                                                       ds.Tables(0).Rows(fila)("fecha_entrega"),
                                                       ds.Tables(0).Rows(fila)("numero_cita"),
                                                       ds.Tables(0).Rows(fila)("numero_oc"),
                                                       ds.Tables(0).Rows(fila)("numero_factura"),
                                                       ds.Tables(0).Rows(fila)("cod_sucursal"),
                                                       ds.Tables(0).Rows(fila)("nom_sucursal"),
                                                       ds.Tables(0).Rows(fila)("sku_cliente"),
                                                       ds.Tables(0).Rows(fila)("cantidad"),
                                                       ds.Tables(0).Rows(fila)("num_bulto"),
                                                       ds.Tables(0).Rows(fila)("sku_nombre"),
                                                       ds.Tables(0).Rows(fila)("volumne"),
                                                       ds.Tables(0).Rows(fila)("peso"))
                            fila = fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS_DETALLE_ABCDIN()
                    End If
                End If
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show(_msg + "\SELECCIONA_OC_DETALLE_LPN_ABCDIN", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message + " " + "SELECCIONA_OC_DETALLE_LPN_ABCDIN", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub GrillaOCAbcDin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaOCAbcDin.CellContentClick
        Dim chkCell As DataGridViewCheckBoxCell = Me.GrillaOCAbcDin.Rows(e.RowIndex).Cells(COL_GRI_ABCDIN_ENC_SELECCION)
        If e.ColumnIndex = Me.GrillaOCAbcDin.Columns.Item(COL_GRI_ABCDIN_ENC_SELECCION).Index Then
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim fila As Integer = 0
        Dim Contador As Integer = 0
        Dim vPrefijo As String = ""
        Dim vCorrelativoU As String = ""
        Dim vCorrelativoS As String = ""
        Dim LargoPrefijo As Integer = 0
        Dim Correlativo As Long = 0
        Dim Respuesta As Integer = 0
        Try

            Dim myValue As String = InputBox("Ingrese el numero de Cita", "Solicitud de cita", 0)

            If String.IsNullOrEmpty(myValue) Then
                Exit Sub
            End If

            If IsNumeric(myValue) = False Then
                MessageBox.Show("Número de Cita no válido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If myValue = 0 Then
                MessageBox.Show("Número de Cita no válido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            UltimoCorrelativoLPNABCDIN = 0

            Call SELECCIONA_ULTIMO_LPN(vPrefijo, vCorrelativoU, vCorrelativoS)
            If vCorrelativoS = "" Then
                MessageBox.Show("No es posible generar el siguiente LPN de impresión" _
                                + Chr(10) + "pongase en contacto con el area de Desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            PrefijoLPNABCDIN = vPrefijo
            LargoPrefijo = vPrefijo.Length
            Correlativo = CLng(Mid(vCorrelativoU, LargoPrefijo + 1, vCorrelativoU.Length))
            Respuesta = MessageBox.Show("Ultimo correlativo imprenso: " + vCorrelativoU.PadLeft(7, "0") + ", Correlativo siguiente: " + vCorrelativoS.PadLeft(7, "0") + "" _
                        + Chr(10) + "¿Desea generar los LPN para los registros seleccionados", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Respuesta = vbNo Then
                Exit Sub
            End If

            fila = 0
            Do While fila < dtArchivoAbcDinAG.RowCount
                'If dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_SELECCION, fila).Value = True Then
                Correlativo = Correlativo + 1
                dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_LPN, fila).Value = Trim(vPrefijo + Correlativo.ToString.PadLeft(7, "0"))
                dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_NUM_CITA, fila).Value = myValue

                'End If
                fila = fila + 1
            Loop

            If Correlativo > 0 Then
                UltimoCorrelativoLPNABCDIN = Correlativo
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fila As Integer = 0
        Dim contador As Integer = 0
        Dim respuesta As Integer = 0

        Try
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            dtArchivoAbcDinAGE.Rows.Clear()
            Do While fila < dtArchivoAbcDinAG.RowCount
                contador = contador + 1
                If dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_LPN, fila).Value <> "" Then
                    dtArchivoAbcDinAGE.Rows.Add(dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_ORDEN_COMPRA, fila).Value,
                                                dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_COD_SUCURSAL, fila).Value,
                                                dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_NOMBRE_SUCURSAL, fila).Value,
                                                dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_LPN, fila).Value,
                                                dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_SKU_CLIENTE, fila).Value,
                                                dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_CANTIDAD, fila).Value,
                                                dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_FACTURA, fila).Value,
                                                "EFAC",
                                                dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_SKU_NOMBRE, fila).Value)
                End If
                fila = fila + 1
            Loop

            If contador = 0 Then
                MessageBox.Show("No existen LPN generados en los registros seleccionado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            respuesta = MessageBox.Show("Esta acción podría tardar un tiempo considerable dependiendo de la cantidad de registros," _
                                                + Chr(10) + "¿Desea seguir ejecutando la acción?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Exit Sub
            End If

            Call ExportarDatosExcelAbcDinAGE(Me.dtArchivoAbcDinAGE, "")


            Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message + "\btnCreaArchivo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try
            Call GUARDA_LPN_ABCDIN_AG()
            Call GUARDA_ULTIMO_CORRELATIVO(PrefijoLPNABCDIN, UltimoCorrelativoLPNABCDIN)

            Dim frm As frm_imprimir = New frm_imprimir
            frm.Origen = "LPN_ABCDIN_AG"
            frm.codImpresionLPN = codigoImpresion
            frm.ShowDialog()

            Call ELIMINA_REGISTRO_IMPRESION_ABCDIN()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GUARDA_LPN_ABCDIN_AG() As Boolean
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        GUARDA_LPN_ABCDIN_AG = False

        Try
            codigoImpresion = DateTime.Now.ToString
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                Do While fila < dtArchivoAbcDinAG.RowCount
                    If dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_LPN, fila).Value <> "" Then
                        class_etiqueta_lpn.abcdin_id_impresion = codigoImpresion
                        class_etiqueta_lpn.abcdin_razon_social = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_RAZON_SOCIAL, fila).Value
                        class_etiqueta_lpn.abcdin_fecha_entrega = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_FECHA_ENTREGA, fila).Value
                        class_etiqueta_lpn.abcdin_numero_cita = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_NUM_CITA, fila).Value
                        class_etiqueta_lpn.abcdin_numero_oc = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_ORDEN_COMPRA, fila).Value
                        class_etiqueta_lpn.abcdin_numero_factura = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_FACTURA, fila).Value
                        class_etiqueta_lpn.abcdin_numero_boleta = 0
                        class_etiqueta_lpn.abcdin_vendido_por = ""
                        class_etiqueta_lpn.abcdin_fecha_cliente = GLO_FECHA_SISTEMA
                        class_etiqueta_lpn.abcdin_nombre_cliente = ""
                        class_etiqueta_lpn.abcdin_rut_cliente = ""
                        class_etiqueta_lpn.abcdin_fono_cliente = ""
                        class_etiqueta_lpn.abcdin_direc_cliente = ""
                        class_etiqueta_lpn.abcdin_comuna_cliente = ""
                        class_etiqueta_lpn.abcdin_local_cliente = ""
                        class_etiqueta_lpn.abcdin_cod_sucursal = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_COD_SUCURSAL, fila).Value
                        class_etiqueta_lpn.abcdin_nom_sucursal = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_NOMBRE_SUCURSAL, fila).Value
                        class_etiqueta_lpn.abcdin_sku_cliente = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_SKU_CLIENTE, fila).Value
                        class_etiqueta_lpn.abcdin_cantidad = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_CANTIDAD, fila).Value
                        class_etiqueta_lpn.abcdin_num_bulto = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_NUM_BULTO, fila).Value
                        class_etiqueta_lpn.abcdin_sku_nombre = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_SKU_NOMBRE, fila).Value
                        class_etiqueta_lpn.abcdin_volumne = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_VOLUMEN, fila).Value
                        class_etiqueta_lpn.abcdin_peso = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_PESO, fila).Value
                        class_etiqueta_lpn.abcdin_lpn = dtArchivoAbcDinAG.Item(COL_GRI_ABCDIN_DET_LPN, fila).Value
                        ds = class_etiqueta_lpn.LPN_GUARDA_DATOS_PARA_ARCHIVO_ETIQUETA_ABCDIN_VV(_msgError, conexion)
                        If _msgError <> "" Then
                            If conexion.State = ConnectionState.Open Then
                                conexion.Close()
                            End If
                            ds = Nothing
                            MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Function
                        Else
                            If ds.Tables(0).Rows(0)("codigo") < 0 Then
                                If conexion.State = ConnectionState.Open Then
                                    conexion.Close()
                                End If
                                ds = Nothing
                                MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Function
                            End If
                        End If
                    End If

                    fila = fila + 1
                Loop

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing
                'EasyIdImpresion = codigoImpresion
                GUARDA_LPN_ABCDIN_AG = True
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub cmbRipleyBuscarOC_Click(sender As Object, e As EventArgs) Handles cmbRipleyBuscarOC.Click
        Call SELECCIONA_OC_ENCABEZADO_LPN_RIPLEY()
    End Sub

    Private Sub GrillaRipleyOC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaRipleyOC.CellContentClick
        Dim chkCell As DataGridViewCheckBoxCell = Me.GrillaRipleyOC.Rows(e.RowIndex).Cells(COL_GRI_RIPLEY_ENC_SELECCION)
        If e.ColumnIndex = Me.GrillaRipleyOC.Columns.Item(COL_GRI_RIPLEY_ENC_SELECCION).Index Then
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub btnRipleyBuscarDetalle_Click(sender As Object, e As EventArgs) Handles btnRipleyBuscarDetalle.Click
        Call SELECCIONA_OC_DETALLE_LPN_RIPLEY()
    End Sub

    Private Sub SELECCIONA_OC_DETALLE_LPN_RIPLEY()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Dim strCadena As String = ""
        Dim ds As DataSet = New DataSet
        Dim _msg As String
        ds = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor
            GrillaDetalleRipley.Rows.Clear()
            'GrillaPackingEasy.Rows.Clear()
            Do While fila <= GrillaRipleyOC.RowCount - 1
                If GrillaRipleyOC.Rows(fila).Cells(COL_GRI_RIPLEY_ENC_SELECCION).Value = True Then
                    If strCadena = "" Then
                        strCadena = GrillaRipleyOC.Rows(fila).Cells(COL_GRI_RIPLEY_ENC_OCOMPRA).Value.ToString + ","
                    Else
                        strCadena = strCadena + GrillaRipleyOC.Rows(fila).Cells(COL_GRI_RIPLEY_ENC_OCOMPRA).Value.ToString + ","
                    End If

                End If
                fila = fila + 1
            Loop

            If strCadena = "" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("Debe seleccionar a lo menos una Orden de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            fila = 0

            class_etiqueta.cnn = _cnn
            class_etiqueta.strCadena = strCadena

            _msg = ""
            GrillaDetalleRipley.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_DETALLE_ORDENES_RIPLEY(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("con_skudescripcion") <> "" Then
                        Do While fila < ds.Tables(0).Rows.Count
                            GrillaDetalleRipley.Rows.Add(ds.Tables(0).Rows(fila)("con_ocnumero"),
                                                       GLO_FECHA_SISTEMA.ToShortDateString,
                                                       ds.Tables(0).Rows(fila)("con_codsucursalentrega"),
                                                       ds.Tables(0).Rows(fila)("con_sucursalentrega"),
                                                       ds.Tables(0).Rows(fila)("con_codigodepto"),
                                                       ds.Tables(0).Rows(fila)("con_glosadepto"),
                                                       "",
                                                       ds.Tables(0).Rows(fila)("con_skucliente"),
                                                       ds.Tables(0).Rows(fila)("con_skudescripcion"),
                                                       ds.Tables(0).Rows(fila)("pic_cantidad_encontrada"),
                                                       ds.Tables(0).Rows(fila)("pro_codigointerno"))
                            fila = fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS_DETALLE_RIPLEY()
                    End If
                End If
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show(_msg + "\SELECCIONA_OC_DETALLE_LPN_RIPLEY", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message + " " + "SELECCIONA_OC_DETALLE_LPN_RIPLEY", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbGeneraLPNRipley_Click(sender As Object, e As EventArgs) Handles cmbGeneraLPNRipley.Click
        Dim fila As Integer = 0
        Dim Contador As Integer = 0
        Dim vPrefijo As String = ""
        Dim vCorrelativoU As String = ""
        Dim vCorrelativoS As String = ""
        Dim LargoPrefijo As Integer = 0
        Dim Correlativo As Long = 0
        Dim Respuesta As Integer = 0
        Dim CodigoProveedor As String = "5469"
        Try

            UltimoCorrelativoLPNERipley = 0

            Call SELECCIONA_ULTIMO_LPN(vPrefijo, vCorrelativoU, vCorrelativoS)
            If vCorrelativoS = "" Then
                MessageBox.Show("No es posible generar el siguiente LPN de impresión" _
                                + Chr(10) + "pongase en contacto con el area de Desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            PrefijoLPNRipley = vPrefijo
            LargoPrefijo = vPrefijo.Length
            Correlativo = CLng(Mid(vCorrelativoU, LargoPrefijo + 1, vCorrelativoU.Length))
            Respuesta = MessageBox.Show("Ultimo correlativo imprenso: " + vCorrelativoU.PadLeft(7, "0") + ", Correlativo siguiente: " + vCorrelativoS.PadLeft(7, "0") + "" _
                        + Chr(10) + "¿Desea generar los LPN para los registros seleccionados", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Respuesta = vbNo Then
                Exit Sub
            End If

            fila = 0
            Do While fila < GrillaDetalleRipley.RowCount
                'If dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_SELECCION, fila).Value = True Then
                Correlativo = Correlativo + 1
                GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_LPN, fila).Value = CodigoProveedor + GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_CODIGO_SUCURSAL, fila).Value.ToString.PadLeft(4, "0") + Trim(vPrefijo + Correlativo.ToString.PadLeft(4, "0"))
                'End If
                fila = fila + 1
            Loop

            If Correlativo > 0 Then
                UltimoCorrelativoLPNERipley = Correlativo
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCreaArchivoRipley_Click(sender As Object, e As EventArgs) Handles btnCreaArchivoRipley.Click
        Call CREAR_PACKING_RIPLEY()
    End Sub

    Private Sub CREAR_PACKING_RIPLEY()
        Dim fila As Integer = 0
        Dim contador As Integer = 0
        Dim respuesta As Integer = 0

        Try
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            GrillaPackingRipley.Rows.Clear()
            Do While fila < GrillaDetalleRipley.RowCount
                If GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_LPN, fila).Value = "" Then
                    contador = contador + 1
                End If

                GrillaPackingRipley.Rows.Add(GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_OCOMPRA, fila).Value,
                                           GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_LPN, fila).Value,
                                           GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_FCOMPROMISO, fila).Value,
                                           GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_SKU, fila).Value,
                                           GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_CANTIDAD, fila).Value)

                fila = fila + 1
            Loop

            If contador > 0 Then
                MessageBox.Show("Dentro de la selección existen registros sin LPN Generados" _
                                + Chr(10) + "Pongase en contacto con el area de desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Exit Sub
            End If

            respuesta = MessageBox.Show("Esta acción podría tardar un tiempo considerable dependiendo de la cantidad de registros," _
                                                + Chr(10) + "¿Desea seguir ejecutando la acción?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Exit Sub
            End If

            Call ExportarDatosExcelRipley(Me.GrillaPackingRipley, "")

            Cursor = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimeLPNRipley_Click(sender As Object, e As EventArgs) Handles btnImprimeLPNRipley.Click
        Try
            Dim frm As frm_imprimir = New frm_imprimir
            Dim respuesta As Integer = 0
            Call GUARDA_LPN_RIPLEY()
            Call GUARDA_ULTIMO_CORRELATIVO(PrefijoLPNRipley, UltimoCorrelativoLPNERipley)

            respuesta = MessageBox.Show("Si desea imprimir la etiqueta de OC PREDISTRIBUIDA, precionar SI, " _
                                        + Chr(10) + "Si desea imprimir la etiqueta de OC de STOCK o POST VENTA, Precione NO", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

            If respuesta = vbYes Then
                frm.Origen = "LPN_RIPLEY_PREDISTRIBUIDO"
                frm.codImpresionLPN = codigoImpresion
                frm.ShowDialog()
            ElseIf respuesta = vbNo Then
                frm.Origen = "LPN_RIPLEY_STOCK"
                frm.codImpresionLPN = codigoImpresion
                frm.ShowDialog()
            End If

            Call ELIMINA_REGISTRO_IMPRESION_RIPLEY()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GUARDA_LPN_RIPLEY() As Boolean
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        GUARDA_LPN_RIPLEY = False

        Try
            codigoImpresion = DateTime.Now.ToString
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                Do While fila < GrillaDetalleRipley.RowCount

                    class_etiqueta_lpn.ripley_id_impresion = codigoImpresion
                    class_etiqueta_lpn.ripley_lpn = GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_LPN, fila).Value
                    class_etiqueta_lpn.ripley_deptoCodigo = GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_CODIGO_DEPTO, fila).Value
                    class_etiqueta_lpn.ripley_deptoNombre = GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_NOMBRE_DEPTO, fila).Value
                    class_etiqueta_lpn.ripley_sucCodigo = GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_CODIGO_SUCURSAL, fila).Value
                    class_etiqueta_lpn.ripley_sucNombre = GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_NOMBRE_SUCURSAL, fila).Value
                    class_etiqueta_lpn.ripley_con_skucliente = GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_SKU, fila).Value
                    class_etiqueta_lpn.ripley_con_skudescripcion = GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_SKU_NOMBRE, fila).Value
                    class_etiqueta_lpn.ripley_pic_cantidad_encontrada = GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_CANTIDAD, fila).Value
                    class_etiqueta_lpn.ripley_con_ocnumero = GrillaDetalleRipley.Item(COL_GRI_RIPLEY_DET_OCOMPRA, fila).Value

                    ds = class_etiqueta_lpn.LPN_GUARDA_DATOS_PARA_ARCHIVO_ETIQUETA_RIPLEY(_msgError, conexion)
                    If _msgError <> "" Then
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        ds = Nothing
                        MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    Else
                        If ds.Tables(0).Rows(0)("codigo") < 0 Then
                            If conexion.State = ConnectionState.Open Then
                                conexion.Close()
                            End If
                            ds = Nothing
                            MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Function
                        End If
                    End If

                    fila = fila + 1
                Loop

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing
                'EasyIdImpresion = codigoImpresion
                GUARDA_LPN_RIPLEY = True
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub btnBuscarSodimac_Click(sender As Object, e As EventArgs) Handles btnBuscarSodimac.Click
        Call SELECCIONA_OC_ENCABEZADO_LPN_SODIMAC()
    End Sub

    Private Sub btnBuscarDetalle_Click(sender As Object, e As EventArgs) Handles btnBuscarDetalle.Click

        Call SELECCIONA_OC_DETALLE_LPN_SODIMAC()

        'If optVentaVerde.Checked = True Then
        '    'Call SELECCIONA_OC_DETALLE_LPN_SODIMAC_VV()
        'ElseIf optStock.Checked = True Then
        'ElseIf optPredistribuida.Checked = True Then
        'End If


    End Sub

    Private Sub SELECCIONA_OC_DETALLE_LPN_SODIMAC()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Dim strCadena As String = ""
        Dim ds As DataSet = New DataSet
        Dim _msg As String
        ds = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor
            GrillaDetalleSodimac.Rows.Clear()
            Do While fila <= GrillaOCSodimac.RowCount - 1
                If GrillaOCSodimac.Rows(fila).Cells(COL_GRI_SODIMAC_ENC_SELECCION).Value = True Then
                    If strCadena = "" Then
                        strCadena = GrillaOCSodimac.Rows(fila).Cells(COL_GRI_SODIMAC_ENC_OCOMPRA).Value.ToString + ","
                    Else
                        strCadena = strCadena + GrillaOCSodimac.Rows(fila).Cells(COL_GRI_SODIMAC_ENC_OCOMPRA).Value.ToString + ","
                    End If

                End If
                fila = fila + 1
            Loop

            If strCadena = "" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("Debe seleccionar a lo menos una Orden de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            fila = 0

            class_etiqueta.cnn = _cnn
            class_etiqueta.strCadena = strCadena

            _msg = ""
            GrillaDetalleSodimac.Rows.Clear()

            If optVentaVerde.Checked = True Then
                ds = class_etiqueta.LPN_SELECCIONA_DETALLE_ORDENES_SODIMAC_VV(_msg)
            ElseIf optStock.Checked = True Then
                class_etiqueta.esPimare = True
                ds = class_etiqueta.LPN_SELECCIONA_DETALLE_ORDENES_SODIMAC_STOCK(_msg)
            ElseIf optPredistribuida.Checked = True Then
            End If


            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("id_proveedor") <> "" Then
                        Do While fila < ds.Tables(0).Rows.Count
                            GrillaDetalleSodimac.Rows.Add(ds.Tables(0).Rows(fila)("id_proveedor"),
                                                       ds.Tables(0).Rows(fila)("con_ocnumero"),
                                                       ds.Tables(0).Rows(fila)("cdEntregaCodigo"),
                                                       ds.Tables(0).Rows(fila)("sucNombre"),
                                                       ds.Tables(0).Rows(fila)("sucCodigo"),
                                                       ds.Tables(0).Rows(fila)("lpn"),
                                                       ds.Tables(0).Rows(fila)("upc"),
                                                       ds.Tables(0).Rows(fila)("con_skucliente"),
                                                       ds.Tables(0).Rows(fila)("con_skudescripcion"),
                                                       ds.Tables(0).Rows(fila)("codigo_favatex"),
                                                       ds.Tables(0).Rows(fila)("cantidad"),
                                                       ds.Tables(0).Rows(fila)("numero_documento"),
                                                       ds.Tables(0).Rows(fila)("tipo_documento"))
                            fila = fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS_DETALLE_SODIMAC()
                    End If
                End If
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show(_msg + "\SELECCIONA_OC_DETALLE_LPN_SODIMAC_VV", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message + " " + "SELECCIONA_OC_DETALLE_LPN_SODIMAC_VV", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub optVentaVerde_CheckedChanged(sender As Object, e As EventArgs) Handles optVentaVerde.CheckedChanged
        If cargoFormulario = True Then
            Call SELECCIONA_OC_ENCABEZADO_LPN_SODIMAC()
        End If
    End Sub

    Private Sub optStock_CheckedChanged(sender As Object, e As EventArgs) Handles optStock.CheckedChanged
        If cargoFormulario = True Then
            Call SELECCIONA_OC_ENCABEZADO_LPN_SODIMAC()
        End If
    End Sub

    Private Sub optPredistribuida_CheckedChanged(sender As Object, e As EventArgs) Handles optPredistribuida.CheckedChanged
        If cargoFormulario = True Then
            Call SELECCIONA_OC_ENCABEZADO_LPN_SODIMAC()
        End If
    End Sub

    Private Sub btnGeneraLPNSodimac_Click(sender As Object, e As EventArgs) Handles btnGeneraLPNSodimac.Click
        Dim fila As Integer = 0
        Dim Contador As Integer = 0
        Dim vPrefijo As String = ""
        Dim vCorrelativoU As String = ""
        Dim vCorrelativoS As String = ""
        Dim LargoPrefijo As Integer = 0
        Dim Correlativo As Long = 0
        Dim Respuesta As Integer = 0
        Dim CodigoFijo As String = "30"
        Try

            UltimoCorrelativoLPNESodimac = 0

            Call SELECCIONA_ULTIMO_LPN(vPrefijo, vCorrelativoU, vCorrelativoS)
            If vCorrelativoS = "" Then
                MessageBox.Show("No es posible generar el siguiente LPN de impresión" _
                                + Chr(10) + "pongase en contacto con el area de Desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            PrefijoLPNSodimac = vPrefijo
            LargoPrefijo = vPrefijo.Length
            Correlativo = CLng(Mid(vCorrelativoU, LargoPrefijo + 1, vCorrelativoU.Length))
            Respuesta = MessageBox.Show("Ultimo correlativo imprenso: " + vCorrelativoU.PadLeft(9, "0") + ", Correlativo siguiente: " + vCorrelativoS.PadLeft(9, "0") + "" _
                        + Chr(10) + "¿Desea generar los LPN para los registros seleccionados", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Respuesta = vbNo Then
                Exit Sub
            End If

            fila = 0
            Do While fila < GrillaDetalleSodimac.RowCount
                'If dtAbcDinVV.Item(COL_GRI_ABC_DET_VV_SELECCION, fila).Value = True Then
                Correlativo = Correlativo + 1
                GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_NUMLPN, fila).Value = CodigoFijo + Trim(vPrefijo + Correlativo.ToString.PadLeft(9, "0"))
                'End If
                fila = fila + 1
            Loop

            If Correlativo > 0 Then
                UltimoCorrelativoLPNESodimac = Correlativo
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCreaArchivoSodimac_Click(sender As Object, e As EventArgs) Handles btnCreaArchivoSodimac.Click
        Dim fila As Integer = 0
        Dim contador As Integer = 0
        Dim respuesta As Integer = 0

        Try
            Cursor = System.Windows.Forms.Cursors.WaitCursor

            Do While fila < GrillaDetalleSodimac.RowCount
                If GrillaDetalleSodimac.Item(COL_GRI_SODIMAC_DET_NUMLPN, fila).Value = "" Then
                    contador = contador + 1
                End If

                fila = fila + 1
            Loop

            If contador > 0 Then
                MessageBox.Show("Dentro de la selección existen registros sin LPN Generados" _
                                + Chr(10) + "Pongase en contacto con el area de desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If

            respuesta = MessageBox.Show("Esta acción podría tardar un tiempo considerable dependiendo de la cantidad de registros," _
                                                + Chr(10) + "¿Desea seguir ejecutando la acción?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Exit Sub
            End If

            Call ExportarDatosExcelSodimac(Me.GrillaDetalleSodimac, "")

            Cursor = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimeLPNSodimac_Click(sender As Object, e As EventArgs) Handles btnImprimeLPNSodimac.Click
        Try
            Dim frm As frm_imprimir = New frm_imprimir
            Dim respuesta As Integer = 0
            Call GUARDA_LPN_SODIMAC()
            Call GUARDA_ULTIMO_CORRELATIVO(PrefijoLPNSodimac, UltimoCorrelativoLPNESodimac)

            frm.Origen = "LPN_SODIMAC"
            frm.codImpresionLPN = codigoImpresion
            frm.ShowDialog()


            'respuesta = MessageBox.Show("Si desea imprimir la etiqueta de OC PREDISTRIBUIDA, precionar SI, " _
            '                            + Chr(10) + "Si desea imprimir la etiqueta de OC de STOCK o POST VENTA, Precione NO", Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

            'If respuesta = vbYes Then
            '    frm.Origen = "LPN_RIPLEY_PREDISTRIBUIDO"
            '    frm.codImpresionLPN = codigoImpresion
            '    frm.ShowDialog()
            'ElseIf respuesta = vbNo Then
            '    frm.Origen = "LPN_RIPLEY_STOCK"
            '    frm.codImpresionLPN = codigoImpresion
            '    frm.ShowDialog()
            'End If

            Call ELIMINA_REGISTRO_IMPRESION_SODIMAC()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkFechaRipley_CheckedChanged(sender As Object, e As EventArgs) Handles chkFechaRipley.CheckedChanged
        If chkFechaRipley.Checked = True Then
            dtpRipleyDesde.Enabled = True
            dtpRipleyHasta.Enabled = True
        ElseIf chkFechaRipley.Checked = False Then
            dtpRipleyDesde.Enabled = False
            dtpRipleyHasta.Enabled = False
        End If
    End Sub

    Private Sub chkSodimac_CheckedChanged(sender As Object, e As EventArgs) Handles chkSodimac.CheckedChanged
        If chkSodimac.Checked = True Then
            dtpDesdeSodimac.Enabled = True
            txtHastaSodimac.Enabled = True
        ElseIf chkSodimac.Checked = False Then
            dtpDesdeSodimac.Enabled = False
            txtHastaSodimac.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call SELECCIONA_OC_ENCABEZADO_LPN_CONSTRUMART()
    End Sub

    Private Sub SELECCIONA_OC_ENCABEZADO_LPN_CONSTRUMART()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0

        Dim diaDesde As String = ""
        Dim mesDesde As String = ""

        Dim diaHasta As String = ""
        Dim mesHasta As String = ""

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing

            class_etiqueta.cnn = _cnn
            If txtPKContrumart.Text = "0" Or txtPKContrumart.Text = "" Then
                class_etiqueta.pic_codigo = 0
            Else
                class_etiqueta.pic_codigo = CLng(txtPKContrumart.Text)
            End If

            If txtOCConstrumart.Text = "" Or txtOCConstrumart.Text = "0" Then
                class_etiqueta.oc_numero = 0
            Else
                class_etiqueta.oc_numero = CLng(txtOCConstrumart.Text)
            End If

            If chkFechaConstrumart.Checked = True Then
                'desde
                If CStr(dtpConstrumartDesde.Value.Month).Length = 1 Then
                    mesDesde = Trim("0" + CStr(dtpConstrumartDesde.Value.Month))
                Else
                    mesDesde = CStr(dtpConstrumartDesde.Value.Month)
                End If

                If CStr(dtpConstrumartDesde.Value.Day).Length = 1 Then
                    diaDesde = Trim("0" + CStr(dtpConstrumartDesde.Value.Day))
                Else
                    diaDesde = CStr(dtpConstrumartDesde.Value.Day)
                End If

                'Hasta
                If CStr(dtpConstrumartHasta.Value.Month).Length = 1 Then
                    mesHasta = Trim("0" + CStr(dtpConstrumartHasta.Value.Month))
                Else
                    mesHasta = CStr(dtpConstrumartHasta.Value.Month)
                End If

                If CStr(dtpConstrumartHasta.Value.Day).Length = 1 Then
                    diaHasta = Trim("0" + CStr(dtpConstrumartHasta.Value.Day))
                Else
                    diaHasta = CStr(dtpConstrumartHasta.Value.Day)
                End If

                class_etiqueta.fechaDesde = CStr(dtpConstrumartDesde.Value.Year) + mesDesde + diaDesde
                class_etiqueta.fechaHasta = CStr(dtpConstrumartHasta.Value.Year) + mesHasta + diaHasta
            Else
                class_etiqueta.fechaDesde = "19000101"
                class_etiqueta.fechaHasta = "20501231"
            End If

            _msg = ""
            GrillaConstrumartOC.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_ENCABEZADO_ORDENES_CONSTRUMART(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("orden_compra") > 0 Then
                        Do While fila < ds.Tables(0).Rows.Count
                            GrillaConstrumartOC.Rows.Add(False, ds.Tables(0).Rows(fila)("orden_compra"),
                                                    ds.Tables(0).Rows(fila)("fecha_orden"))
                            fila = fila + 1
                        Loop
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\SELECCIONA_OC_ENCABEZADO_LPN_CONSTRUMART", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Call CONFIGURA_COLUMNAS_ENCABEZADO_CONSTRUMART()

        Catch ex As Exception
            MsgBox(ex.Message + " " + "SELECCIONA_OC_ENCABEZADO_LPN_CONSTRUMART", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call SELECCIONA_OC_DETALLE_CONSTRUMART()
        Call SELECCIONA_ASN_CONSTRUMART()
    End Sub

    Private Sub SELECCIONA_ASN_CONSTRUMART()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Dim strCadena As String = ""
        Dim ds As DataSet = New DataSet
        Dim _msg As String
        ds = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            Do While fila <= GrillaConstrumartOC.RowCount - 1
                If GrillaConstrumartOC.Rows(fila).Cells(COL_GRI_CONSTRUMART_ENC_SELECCION).Value = True Then
                    If strCadena = "" Then
                        strCadena = GrillaConstrumartOC.Rows(fila).Cells(COL_GRI_CONSTRUMART_ENC_OCOMPRA).Value.ToString + ","
                    Else
                        strCadena = strCadena + GrillaConstrumartOC.Rows(fila).Cells(COL_GRI_CONSTRUMART_ENC_OCOMPRA).Value.ToString + ","
                    End If

                End If
                fila = fila + 1
            Loop

            If strCadena = "" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("Debe seleccionar a lo menos una Orden de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            fila = 0

            class_etiqueta.cnn = _cnn
            class_etiqueta.strCadena = strCadena

            _msg = ""
            grillaASNConstrumart.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_ASN_CONSTRUMART(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("pic_cantidad_encontrada") > 0 Then
                        Do While fila < ds.Tables(0).Rows.Count
                            grillaASNConstrumart.Rows.Add("",
                                                       ds.Tables(0).Rows(fila)("con_ocnumero"),
                                                       ds.Tables(0).Rows(fila)("con_codlocalentrega"),
                                                       ds.Tables(0).Rows(fila)("con_posicion"),
                                                       ds.Tables(0).Rows(fila)("con_skucliente"),
                                                       ds.Tables(0).Rows(fila)("pic_cantidad_encontrada"),
                                                       ds.Tables(0).Rows(fila)("pro_codigointerno"))
                            fila = fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS_ASN_CONSTRUMART()
                    End If
                End If
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show(_msg + "\SELECCIONA_ASN_CONSTRUMART", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message + " " + "SELECCIONA_ASN_CONSTRUMART", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub SELECCIONA_OC_DETALLE_CONSTRUMART()
        Dim class_etiqueta As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim fila As Integer = 0
        Dim strCadena As String = ""
        Dim ds As DataSet = New DataSet
        Dim _msg As String
        ds = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor
            grillaDetalleConstrumart.Rows.Clear()
            Do While fila <= GrillaConstrumartOC.RowCount - 1
                If GrillaConstrumartOC.Rows(fila).Cells(COL_GRI_CONSTRUMART_ENC_SELECCION).Value = True Then
                    If strCadena = "" Then
                        strCadena = GrillaConstrumartOC.Rows(fila).Cells(COL_GRI_CONSTRUMART_ENC_OCOMPRA).Value.ToString + ","
                    Else
                        strCadena = strCadena + GrillaConstrumartOC.Rows(fila).Cells(COL_GRI_CONSTRUMART_ENC_OCOMPRA).Value.ToString + ","
                    End If

                End If
                fila = fila + 1
            Loop

            If strCadena = "" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("Debe seleccionar a lo menos una Orden de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            fila = 0

            class_etiqueta.cnn = _cnn
            class_etiqueta.strCadena = strCadena

            _msg = ""
            grillaDetalleConstrumart.Rows.Clear()
            ds = class_etiqueta.LPN_SELECCIONA_DETALLE_ORDENES_CONSTRUMART(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(fila)("oc_cantidad") > 0 Then
                        Do While fila < ds.Tables(0).Rows.Count
                            grillaDetalleConstrumart.Rows.Add(CDate(ds.Tables(0).Rows(fila)("oc_fecha")).ToShortDateString,
                                                       ds.Tables(0).Rows(fila)("oc_numero"),
                                                       ds.Tables(0).Rows(fila)("oc_local"),
                                                       ds.Tables(0).Rows(fila)("oc_gdespacho"),
                                                       ds.Tables(0).Rows(fila)("oc_item"),
                                                       ds.Tables(0).Rows(fila)("oc_cantidad"),
                                                       ds.Tables(0).Rows(fila)("oc_bultos"))
                            fila = fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS_DETALLE_CONSTRUMART()
                    End If
                End If
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show(_msg + "\SELECCIONA_OC_DETALLE_CONSTRUMART", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message + " " + "SELECCIONA_OC_DETALLE_CONSTRUMART", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnImprimeConstrumart_Click(sender As Object, e As EventArgs) Handles btnImprimeConstrumart.Click
        Call IMPRIME_ETIQUETAS_CONSTRUMART()
    End Sub

    Private Sub IMPRIME_ETIQUETAS_CONSTRUMART()
        Dim classCartera As class_cartera = New class_cartera
        Dim frm As frm_imprimir = New frm_imprimir
        Dim ds As DataSet = New DataSet
        Dim _msg As String = ""
        Dim Fila As Integer = 0
        Dim nombreInforme As String = ""
        Dim Seleccionados As String = ""
        Dim numPK As Integer = 0
        Dim numBulto As Integer = 0
        Dim origen As String = ""

        Try
            origen = "ETI_CONST"

            Do While Fila <= GrillaConstrumartOC.RowCount - 1
                If GrillaConstrumartOC.Rows(Fila).Cells(COL_GRI_CONSTRUMART_ENC_SELECCION).Value = True Then
                    If Seleccionados = "" Then
                        Seleccionados = GrillaConstrumartOC.Rows(Fila).Cells(COL_GRI_CONSTRUMART_ENC_OCOMPRA).Value.ToString + ","
                    Else
                        Seleccionados = Seleccionados + GrillaConstrumartOC.Rows(Fila).Cells(COL_GRI_CONSTRUMART_ENC_OCOMPRA).Value.ToString + ","
                    End If

                End If
                Fila = Fila + 1
            Loop

            If Seleccionados = "" Then
                Me.Cursor = Cursors.Default
                MessageBox.Show("Debe seleccionar a lo menos una Orden de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Fila = 0

            frm.nombreReporte = nombreInforme
            frm.Origen = origen
            frm.strCadena = Seleccionados
            frm.orden_compra = 0
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGeneraLPNConstrumart_Click(sender As Object, e As EventArgs) Handles btnGeneraLPNConstrumart.Click
        Dim fila As Integer = 0
        Dim Contador As Integer = 0
        Dim vPrefijo As String = ""
        Dim vCorrelativoU As String = ""
        Dim vCorrelativoS As String = ""
        Dim LargoPrefijo As Integer = 0
        Dim Correlativo As Long = 0
        Dim Respuesta As Integer = 0
        Try

            UltimoCorrelativoLPNEConstrumart = 0

            Call SELECCIONA_ULTIMO_LPN(vPrefijo, vCorrelativoU, vCorrelativoS)
            If vCorrelativoS = "" Then
                MessageBox.Show("No es posible generar el siguiente LPN de impresión" _
                                + Chr(10) + "pongase en contacto con el area de Desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            PrefijoLPNConstrumart = vPrefijo
            LargoPrefijo = vPrefijo.Length
            Correlativo = CLng(Mid(vCorrelativoU, LargoPrefijo + 1, vCorrelativoU.Length))
            Respuesta = MessageBox.Show("Ultimo correlativo imprenso: " + vCorrelativoU + ", Correlativo siguiente: " + vCorrelativoS + "" _
                        + Chr(10) + "¿Desea generar los LPN para los registros seleccionados", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Respuesta = vbNo Then
                Exit Sub
            End If

            fila = 0
            Do While fila < grillaASNConstrumart.RowCount
                Correlativo = Correlativo + 1
                grillaASNConstrumart.Item(COL_GRI_CONSTRUMART_ASN_LPN, fila).Value = Trim(vPrefijo + Correlativo.ToString.PadLeft(9, "0"))
                'End If
                fila = fila + 1
            Loop

            If Correlativo > 0 Then
                UltimoCorrelativoLPNEConstrumart = Correlativo
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub CREAR_ASN_CONSTRUMART()
        Dim fila As Integer = 0
        Dim contador As Integer = 0
        Dim respuesta As Integer = 0

        Try
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Do While fila < grillaASNConstrumart.RowCount
                If grillaASNConstrumart.Item(COL_GRI_CONSTRUMART_ASN_LPN, fila).Value = "" Then
                    contador = contador + 1
                End If
                fila = fila + 1
            Loop

            If contador > 0 Then
                MessageBox.Show("Dentro de la selección existen registros sin LPN Generados o no existen datos generados" _
                                + Chr(10) + "Pongase en contacto con el area de desarrollo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If

            respuesta = MessageBox.Show("Esta acción podría tardar un tiempo considerable dependiendo de la cantidad de registros," _
                                                + Chr(10) + "¿Desea seguir ejecutando la acción?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If

            Call ExportarDatosExcelConstrumart(Me.grillaASNConstrumart, "")
            Call GUARDA_ULTIMO_CORRELATIVO(PrefijoLPNConstrumart, UltimoCorrelativoLPNEConstrumart)
            Cursor = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ExportarDatosExcelConstrumart(ByVal DataGridView1 As DataGridView, ByVal titulo As String)
        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            ''Encabezado  
            '.Range("A1:L1").Merge()
            '.Range("A1:L1").Value = "COMERCIAL FAVATEX"
            '.Range("A1:L1").Font.Bold = True
            '.Range("A1:L1").Font.Size = 15
            ''Copete  
            '.Range("A2:L2").Merge()
            '.Range("A2:L2").Value = titulo
            '.Range("A2:L2").Font.Bold = True
            '.Range("A2:L2").Font.Size = 12

            Const primeraLetra As Char = "A"
            Const primerNumero As Short = 1
            Dim Letra As Char, UltimaLetra As Char
            Dim Numero As Integer, UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(primeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
            Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
            'Establecer formatos de las columnas de la hija de cálculo  
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
            Letra = primeraLetra
            Numero = primerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + Letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 8
                    'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                    If Letra = "A" Then
                        'objCelda.EntireColumn.NumberFormat = "000000000000000000"
                        'objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If

                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                    End If
                End If
            Next

            Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzq As String = LetraIzq

            'CARGA DE DATOS  
            Dim i As Integer = Numero + 1

            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(primeraLetra) - 1
                Letra = primeraLetra
                cod_letra = Asc(primeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra
                        ' acá debería realizarse la carga  
                        If Letra = "A" Then
                            '.Cells(i, strColumna) = Str(reg.Cells(c.Index).Value)
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", "'" + reg.Cells(c.Index).Value)
                        Else
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                        End If

                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i

            'Dibujar las líneas de las columnas  
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(primeraLetra)
            Letra = primeraLetra
            For Each c As DataGridViewColumn In DataGridView1.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                    'objCelda.BorderAround()
                    If Letra = "Z" Then
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        Letra = Chr(cod_letra)
                    End If
                End If
            Next

            'Dibujar el border exterior grueso  
            Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            'objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With

        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub

    Private Sub btnCreaAsn_Click(sender As Object, e As EventArgs) Handles btnCreaAsn.Click
        Call CREAR_ASN_CONSTRUMART()
    End Sub

    Private Sub btnMarcarTodo_Click(sender As Object, e As EventArgs) Handles btnMarcarTodo.Click
        Call MARCAR_TODOS()
    End Sub

    Private Sub MARCAR_TODOS()
        For Each row As DataGridViewRow In Me.dtAbcDinVV.Rows
            row.Cells(COL_GRI_ABC_DET_VV_SELECCION).Value = True
        Next
    End Sub

    Private Sub DESMARCAR_TODOS()
        For Each row As DataGridViewRow In Me.dtAbcDinVV.Rows
            row.Cells(COL_GRI_ABC_DET_VV_SELECCION).Value = False
        Next
    End Sub

    Private Sub btnDesmarcar_Click(sender As Object, e As EventArgs) Handles btnDesmarcar.Click
        Call DESMARCAR_TODOS()
    End Sub
End Class