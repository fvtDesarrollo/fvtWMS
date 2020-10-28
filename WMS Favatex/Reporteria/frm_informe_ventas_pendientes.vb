Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Windows.Forms.DataVisualization.Charting
Public Class frm_informe_ventas_pendientes
    Private _cnn As String

    'GRILLA RESUMEN POR ESTADO
    Const COL_GRI_EST_CODIGO_ESTADO As Integer = 0
    Const COL_GRI_EST_NOMBRE_ESTADO As Integer = 1
    Const COL_GRI_EST_CANTIDAD As Integer = 2
    Const COL_GRI_EST_VER_DETALLE As Integer = 3

    'GRILLA DETALLE
    Const COL_GRI_DET_CODIGO_CLIENTE As Integer = 0
    Const COL_GRI_DET_NOMBRE_CLIENTE As Integer = 1
    Const COL_GRI_DET_CODIGO_INTERNO As Integer = 2
    Const COL_GRI_DET_NOMBRE_PRODUCTO As Integer = 3
    Const COL_GRI_DET_CANTIDAD_REQUERIDA As Integer = 4
    Const COL_GRI_DET_CANTIDAD_ENCONTRADA As Integer = 5
    Const COL_GRI_DET_PRECIO As Integer = 6
    Const COL_GRI_DET_FECHA_EMISION As Integer = 7
    Const COL_GRI_DET_FECHA_COMPROMISO As Integer = 8
    Const COL_GRI_DET_CODIGO_ESTADO As Integer = 9
    Const COL_GRI_DET_NOMBRE_ESTADO As Integer = 10
    Const COL_GRI_DET_NUMERO_PICKING As Integer = 11
    Const COL_GRI_DET_ORDEN_COMPRA As Integer = 12

    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtnGustar_Click(sender As Object, e As EventArgs) Handles BtnGustar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If CARGA_GRILLA() = True Then
            Call CARGA_GRILLA_POR_ESTADO()
        End If

        'Call CARGA_GRAFICO_BARRAS()
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub CONFIGURA_COLUMNAS_RESUMEN_POR_ESTADO()
        GrillaEstados.Columns(COL_GRI_EST_CODIGO_ESTADO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaEstados.Columns(COL_GRI_EST_NOMBRE_ESTADO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaEstados.Columns(COL_GRI_EST_CANTIDAD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaEstados.Columns(COL_GRI_EST_VER_DETALLE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub CONFIGURA_COLUMNAS_DETALLE()
        GrillaDetalle.Columns(COL_GRI_DET_CODIGO_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_NOMBRE_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_CODIGO_INTERNO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_NOMBRE_PRODUCTO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_CANTIDAD_REQUERIDA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_CANTIDAD_ENCONTRADA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_PRECIO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_FECHA_EMISION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_FECHA_COMPROMISO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_CODIGO_ESTADO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_NOMBRE_ESTADO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_DET_NUMERO_PICKING).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub


    ''Private Sub CARGA_GRAFICO_BARRAS()
    ''    Dim classInformes As class_informes = New class_informes
    ''    Dim SearchChar As String = "-"
    ''    Dim TestPos As Integer = 0
    ''    Dim Fila As Integer = 0
    ''    Dim Columna As Integer = 0

    ''    Dim diaOCDesde As String = ""
    ''    Dim mesOCDesde As String = ""

    ''    Dim diaOCHasta As String = ""
    ''    Dim mesOCHasta As String = ""

    ''    Dim diaArriboDesde As String = ""
    ''    Dim mesArriboDesde As String = ""

    ''    Dim diaArriboHasta As String = ""
    ''    Dim mesArriboHasta As String = ""

    ''    'Dim ChartArea1 As ChartArea = New ChartArea()
    ''    'Dim Legend1 As Legend = New Legend()
    ''    'Dim Series1 As Series = New Series()
    ''    'Dim Chart1 = New Chart()
    ''    'Me.Controls.Add(Chart1)

    ''    Dim style As New DataGridViewCellStyle()

    ''    'Formato totales
    ''    style.Font = New Font(Grilla.Font, FontStyle.Bold)


    ''    Try


    ''        Dim ds As DataSet = New DataSet
    ''        Dim _msg As String

    ''        ds = Nothing
    ''        classInformes.cnn = _cnn

    ''        'desde
    ''        If CStr(dtpFechaOCDesde.Value.Month).Length = 1 Then
    ''            mesOCDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Month))
    ''        Else
    ''            mesOCDesde = CStr(dtpFechaOCDesde.Value.Month)
    ''        End If

    ''        If CStr(dtpFechaOCDesde.Value.Day).Length = 1 Then
    ''            diaOCDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Day))
    ''        Else
    ''            diaOCDesde = CStr(dtpFechaOCDesde.Value.Day)
    ''        End If
    ''        'Hasta
    ''        If CStr(dtpFechaOCHasta.Value.Month).Length = 1 Then
    ''            mesOCHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Month))
    ''        Else
    ''            mesOCHasta = CStr(dtpFechaOCHasta.Value.Month)
    ''        End If

    ''        If CStr(dtpFechaOCHasta.Value.Day).Length = 1 Then
    ''            diaOCHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Day))
    ''        Else
    ''            diaOCHasta = CStr(dtpFechaOCHasta.Value.Day)
    ''        End If

    ''        classInformes.str_fechaDesde = CStr(dtpFechaOCDesde.Value.Year) + mesOCDesde + diaOCDesde
    ''        classInformes.str_fechaHasta = CStr(dtpFechaOCHasta.Value.Year) + mesOCHasta + diaOCHasta
    ''        classInformes.grafico = "CARGA_POR_FECHA"
    ''        _msg = ""
    ''        Grafico.DataSource = Nothing
    ''        ds = classInformes.carga_informe_ventas_pendientes_wms_grafico(_msg)
    ''        If _msg = "" Then
    ''            If ds.Tables(0).Rows.Count > 0 Then
    ''                If ds.Tables(0).Rows(Fila)("serie2") <> "" Then
    ''                    Grafico.DataSource = ds.Tables(0)
    ''                    Dim Series1 As Series = Grafico.Series("Series1")
    ''                    Series1.Name = "Unidades"
    ''                    Grafico.Series(Series1.Name).XValueMember = "serie1" ' assigning age column to x axis
    ''                    Grafico.Series(Series1.Name).YValueMembers = "serie2" ' assigning city count to y axis


    ''                    'Grafico.Series("Series1").XValueMember = "serie1"
    ''                    'Grafico.Series("Series1").YValueMembers = "serie2"
    ''                    'Grafico.DataSource = ds.Tables(0)
    ''                End If
    ''            End If
    ''        Else
    ''            MessageBox.Show(_msg + "\CARGA_GRAFICO_BARRAS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    ''        End If
    ''        ds = Nothing
    ''    Catch ex As Exception
    ''        MsgBox(ex.Message + " " + "CARGA_GRAFICO_BARRAS", MsgBoxStyle.Critical, Me.Text)
    ''    End Try

    ''End Sub

    Private Function CARGA_GRILLA() As Boolean
        Dim classInformes As class_informes = New class_informes
        Dim SearchChar As String = "-"
        Dim TestPos As Integer = 0
        Dim Fila As Integer = 0
        Dim Columna As Integer = 0

        Dim diaOCDesde As String = ""
        Dim mesOCDesde As String = ""

        Dim diaOCHasta As String = ""
        Dim mesOCHasta As String = ""

        Dim diaArriboDesde As String = ""
        Dim mesArriboDesde As String = ""

        Dim diaArriboHasta As String = ""
        Dim mesArriboHasta As String = ""

        Dim cantColumnas As Integer = 0

        Dim style As New DataGridViewCellStyle()

        'Formato totales
        style.Font = New Font(Grilla.Font, FontStyle.Bold)
        CARGA_GRILLA = False

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String

            ds = Nothing
            classInformes.cnn = _cnn

            'desde
            If CStr(dtpFechaOCDesde.Value.Month).Length = 1 Then
                mesOCDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Month))
            Else
                mesOCDesde = CStr(dtpFechaOCDesde.Value.Month)
            End If

            If CStr(dtpFechaOCDesde.Value.Day).Length = 1 Then
                diaOCDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Day))
            Else
                diaOCDesde = CStr(dtpFechaOCDesde.Value.Day)
            End If
            'Hasta
            If CStr(dtpFechaOCHasta.Value.Month).Length = 1 Then
                mesOCHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Month))
            Else
                mesOCHasta = CStr(dtpFechaOCHasta.Value.Month)
            End If

            If CStr(dtpFechaOCHasta.Value.Day).Length = 1 Then
                diaOCHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Day))
            Else
                diaOCHasta = CStr(dtpFechaOCHasta.Value.Day)
            End If

            Grilla.DataSource = Nothing
            Grilla.Columns.Clear()

            'Carga columnas
            classInformes.str_fechaDesde = CStr(dtpFechaOCDesde.Value.Year) + mesOCDesde + diaOCDesde
            classInformes.str_fechaHasta = CStr(dtpFechaOCHasta.Value.Year) + mesOCHasta + diaOCHasta
            classInformes.solo_columnas = 1

            If optUnidades.Checked = True Then
                classInformes.enUnidades = True
            Else
                classInformes.enUnidades = False
            End If

            If optTipoVV.Checked = True Then
                classInformes.esVentaVerde = True
            Else
                classInformes.esVentaVerde = False
            End If

            _msg = ""
            Grilla.Rows.Clear()
            ds = classInformes.carga_informe_ventas_pendientes_wms(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("car_nombre") <> "" Then
                        cantColumnas = ds.Tables(0).Columns.Count
                        For Each c As DataColumn In ds.Tables(0).Columns
                            If ds.Tables(0).Rows(0)(Fila) = "0" Then
                                Grilla.Columns.Add("car_codigo", "")
                            Else
                                Grilla.Columns.Add(ds.Tables(0).Rows(0)(Fila), ds.Tables(0).Rows(0)(Fila))
                            End If
                            Fila = Fila + 1
                        Next
                    Else
                        MessageBox.Show("No existen registros para los filtros seleccionados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Function
                    End If
                Else
                    MessageBox.Show("No existen registros para los filtros seleccionados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Function
                End If
                Me.Text = "LISTADO DE ORDENES DE COMRPA - [ULTIMA CONSULTA: " + DateTime.Now.ToString() + "]"
            Else
                MessageBox.Show(_msg + "\CARGA_GRILLA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            ds = Nothing

            'Carga filas según columnas
            Grilla.Columns(0).Visible = False
            classInformes.str_fechaDesde = CStr(dtpFechaOCDesde.Value.Year) + mesOCDesde + diaOCDesde
            classInformes.str_fechaHasta = CStr(dtpFechaOCHasta.Value.Year) + mesOCHasta + diaOCHasta
            classInformes.solo_columnas = 0
            If optUnidades.Checked = True Then
                classInformes.enUnidades = True
            Else
                classInformes.enUnidades = False
            End If
            If optTipoVV.Checked = True Then
                classInformes.esVentaVerde = True
            Else
                classInformes.esVentaVerde = False
            End If
            _msg = ""
            Fila = 0
            Grilla.Rows.Clear()
            ds = classInformes.carga_informe_ventas_pendientes_wms(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(0)("car_nombre") <> "" Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            Grilla.Rows.Add(ds.Tables(0).Rows(Fila)("car_codigo"))
                            Fila = Fila + 1
                        Loop

                        Fila = 0
                        Do While Fila < ds.Tables(0).Rows.Count
                            Columna = 0
                            Do While Columna < cantColumnas
                                Grilla.Rows(Fila).Cells(Columna).Value = IIf(ds.Tables(0).Rows(Fila)(Columna).ToString = "", 0, ds.Tables(0).Rows(Fila)(Columna))

                                If Columna = 0 Then
                                    If IIf(ds.Tables(0).Rows(Fila)(Columna).ToString = "", 0, ds.Tables(0).Rows(Fila)(Columna)) = -1 Then
                                        Grilla.Rows(Fila).DefaultCellStyle = style
                                    End If
                                End If

                                Grilla.Columns(Columna).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                                If Columna > 1 Then
                                    Grilla.Columns(Columna).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                                End If
                                Columna = Columna + 1
                            Loop
                            Fila = Fila + 1
                        Loop



                    End If
                End If
            End If
            CARGA_GRILLA = True
        Catch ex As Exception
            CARGA_GRILLA = False
            MsgBox(ex.Message + " " + "CARGA_GRILLA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Function
    Private Sub CARGA_GRILLA_POR_ESTADO()
        Dim classInformes As class_informes = New class_informes
        Dim SearchChar As String = "-"
        Dim TestPos As Integer = 0
        Dim Fila As Integer = 0
        Dim Columna As Integer = 0

        Dim diaOCDesde As String = ""
        Dim mesOCDesde As String = ""

        Dim diaOCHasta As String = ""
        Dim mesOCHasta As String = ""

        Dim diaArriboDesde As String = ""
        Dim mesArriboDesde As String = ""

        Dim diaArriboHasta As String = ""
        Dim mesArriboHasta As String = ""

        Dim cantColumnas As Integer = 0

        Dim style As New DataGridViewCellStyle()

        'Formato totales
        style.Font = New Font(GrillaEstados.Font, FontStyle.Bold)


        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String

            ds = Nothing
            classInformes.cnn = _cnn

            'desde
            If CStr(dtpFechaOCDesde.Value.Month).Length = 1 Then
                mesOCDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Month))
            Else
                mesOCDesde = CStr(dtpFechaOCDesde.Value.Month)
            End If

            If CStr(dtpFechaOCDesde.Value.Day).Length = 1 Then
                diaOCDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Day))
            Else
                diaOCDesde = CStr(dtpFechaOCDesde.Value.Day)
            End If
            'Hasta
            If CStr(dtpFechaOCHasta.Value.Month).Length = 1 Then
                mesOCHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Month))
            Else
                mesOCHasta = CStr(dtpFechaOCHasta.Value.Month)
            End If

            If CStr(dtpFechaOCHasta.Value.Day).Length = 1 Then
                diaOCHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Day))
            Else
                diaOCHasta = CStr(dtpFechaOCHasta.Value.Day)
            End If

            GrillaEstados.DataSource = Nothing

            'Carga columnas
            classInformes.str_fechaDesde = CStr(dtpFechaOCDesde.Value.Year) + mesOCDesde + diaOCDesde
            classInformes.str_fechaHasta = CStr(dtpFechaOCHasta.Value.Year) + mesOCHasta + diaOCHasta

            If optUnidades.Checked = True Then
                classInformes.enUnidades = True
            Else
                classInformes.enUnidades = False
            End If

            If optTipoVV.Checked = True Then
                classInformes.esVentaVerde = True
            Else
                classInformes.esVentaVerde = False
            End If

            _msg = ""
            GrillaEstados.Rows.Clear()
            ds = classInformes.carga_informe_ventas_pendientes_wms_por_estado(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(0)("epc_nombre") <> "" Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            GrillaEstados.Rows.Add(ds.Tables(0).Rows(Fila)("epc_codigo"),
                                            ds.Tables(0).Rows(Fila)("epc_nombre"),
                                            ds.Tables(0).Rows(Fila)("cant_requerida"))
                            Fila = Fila + 1
                        Loop

                        GrillaEstados.Rows(Fila - 1).DefaultCellStyle = style
                        Call CONFIGURA_COLUMNAS_RESUMEN_POR_ESTADO()
                    Else
                        MessageBox.Show("No existen registros para los filtros seleccionados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("No existen registros para los filtros seleccionados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If
            ds = Nothing

        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA_POR_ESTADO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    Private Sub CARGA_GRILLA_POR_DETALLE(ByVal codEstado As Integer)
        Dim classInformes As class_informes = New class_informes
        Dim SearchChar As String = "-"
        Dim TestPos As Integer = 0
        Dim Fila As Integer = 0
        Dim Columna As Integer = 0

        Dim diaOCDesde As String = ""
        Dim mesOCDesde As String = ""

        Dim diaOCHasta As String = ""
        Dim mesOCHasta As String = ""

        Dim diaArriboDesde As String = ""
        Dim mesArriboDesde As String = ""

        Dim diaArriboHasta As String = ""
        Dim mesArriboHasta As String = ""

        Dim cantColumnas As Integer = 0

        Dim style As New DataGridViewCellStyle()

        'Formato totales
        style.Font = New Font(GrillaDetalle.Font, FontStyle.Bold)


        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String

            ds = Nothing
            classInformes.cnn = _cnn

            'desde
            If CStr(dtpFechaOCDesde.Value.Month).Length = 1 Then
                mesOCDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Month))
            Else
                mesOCDesde = CStr(dtpFechaOCDesde.Value.Month)
            End If

            If CStr(dtpFechaOCDesde.Value.Day).Length = 1 Then
                diaOCDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Day))
            Else
                diaOCDesde = CStr(dtpFechaOCDesde.Value.Day)
            End If
            'Hasta
            If CStr(dtpFechaOCHasta.Value.Month).Length = 1 Then
                mesOCHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Month))
            Else
                mesOCHasta = CStr(dtpFechaOCHasta.Value.Month)
            End If

            If CStr(dtpFechaOCHasta.Value.Day).Length = 1 Then
                diaOCHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Day))
            Else
                diaOCHasta = CStr(dtpFechaOCHasta.Value.Day)
            End If



            GrillaDetalle.DataSource = Nothing

            'Carga columnas
            classInformes.str_fechaDesde = CStr(dtpFechaOCDesde.Value.Year) + mesOCDesde + diaOCDesde
            classInformes.str_fechaHasta = CStr(dtpFechaOCHasta.Value.Year) + mesOCHasta + diaOCHasta
            classInformes.epc_codigo = codEstado
            If optUnidades.Checked = True Then
                classInformes.enUnidades = True
            Else
                classInformes.enUnidades = False
            End If

            If optTipoVV.Checked = True Then
                classInformes.esVentaVerde = True
            Else
                classInformes.esVentaVerde = False
            End If

            _msg = ""
            GrillaDetalle.Rows.Clear()
            ds = classInformes.carga_informe_ventas_pendientes_wms_por_detalle(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(0)("epc_nombre") <> "" Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            GrillaDetalle.Rows.Add(ds.Tables(0).Rows(Fila)("car_codigo"),
                                                   ds.Tables(0).Rows(Fila)("car_nombre"),
                                                   ds.Tables(0).Rows(Fila)("con_ocnumero"),
                                                   ds.Tables(0).Rows(Fila)("pro_codigointerno"),
                                                   ds.Tables(0).Rows(Fila)("pro_nombre"),
                                                   ds.Tables(0).Rows(Fila)("cant_requerida"),
                                                   ds.Tables(0).Rows(Fila)("cant_encontrada"),
                                                   ds.Tables(0).Rows(Fila)("precio"),
                                                   ds.Tables(0).Rows(Fila)("fecha_emision"),
                                                   ds.Tables(0).Rows(Fila)("con_fechadespacho"),
                                                   ds.Tables(0).Rows(Fila)("epc_codigo"),
                                                   ds.Tables(0).Rows(Fila)("epc_nombre"),
                                                   ds.Tables(0).Rows(Fila)("num_pk"))
                            Fila = Fila + 1
                        Loop

                        'GrillaEstados.Rows(Fila - 1).DefaultCellStyle = style
                        Call CONFIGURA_COLUMNAS_DETALLE()
                        TabControl1.SelectedIndex = 2
                    End If
                End If
            End If
            ds = Nothing

        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA_POR_DETALLE", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub


    Private Sub frm_informe_ventas_pendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call INICIALIZA()
    End Sub

    Private Sub INICIALIZA()
        Me.WindowState = FormWindowState.Maximized
        Me.Grilla.ClearSelection()
        lblDescripcion.Text = ""
        GrillaEstados.Columns(COL_GRI_EST_CANTIDAD).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtpFechaOCDesde.Value = GLO_FECHA_SISTEMA
        dtpFechaOCHasta.Value = DateAdd(DateInterval.Day, 15, dtpFechaOCDesde.Value)
    End Sub

    Private Sub GrillaEstados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaEstados.CellContentClick
        Try
            If e.ColumnIndex = COL_GRI_EST_VER_DETALLE Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                lblDescripcion.Text = ""
                lblDescripcion.Text = "ESTADO SELECCIONADO: " + GrillaEstados.Rows(e.RowIndex).Cells(COL_GRI_EST_NOMBRE_ESTADO).Value.ToString + " | CANTIDAD DE UNIDADES: " + GrillaEstados.Rows(e.RowIndex).Cells(COL_GRI_EST_CANTIDAD).Value.ToString
                Call CARGA_GRILLA_POR_DETALLE(GrillaEstados.Rows(e.RowIndex).Cells(COL_GRI_EST_CODIGO_ESTADO).Value)
                Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class