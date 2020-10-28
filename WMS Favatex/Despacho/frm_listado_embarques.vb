Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class frm_listado_embarques
    Private _cnn As String
    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property

    Const COL_GRI_EMB_SELLO As Integer = 0
    Const COL_GRI_EMB_FECHA_INGRESO As Integer = 1
    Const COL_GRI_EMB_FECHA_DESPACHO As Integer = 2
    Const COL_GRI_EMB_HORA_CITA As Integer = 3
    Const COL_GRI_EMB_TIPO_TRANSPORTE As Integer = 4
    Const COL_GRI_EMB_CHOFER As Integer = 5
    Const COL_GRI_EMB_VEHICULO As Integer = 6
    Const COL_GRI_EMB_NPALLET As Integer = 7
    Const COL_GRI_EMB_NPALLETD As Integer = 8
    Const COL_GRI_EMB_VER As Integer = 9
    Const COL_GRI_EMB_IMPRIMIR As Integer = 10
    Const COL_GRI_EMB_ELIMINAR As Integer = 11
    Const COL_GRI_EMB_EXPORTA As Integer = 12

    Const COL_GRI_OC_CLIENTE As Integer = 0
    Const COL_GRI_OC_NOEMB As Integer = 1
    Const COL_GRI_OC_EMBHOY As Integer = 2
    Const COL_GRI_OC_POREMB As Integer = 3


    Private Sub frm_listado_embarques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '_cnn = "Data Source=192.168.1.8\POSEIDONSQL;Initial Catalog=APPFVT_01;User ID=sa;Password=S1nc0ntr4s3n4db4.2017"
        Call INICIALIZA()
        Call CONFIGURA_COLUMNAS_EMBARQUES()
        Call CONFIGURA_COLUMNAS_OC()

    End Sub

    Private Sub CARGA_COMBO_CLIENTE()
        Dim _msg As String
        Try
            Dim classCliente As class_cartera = New class_cartera
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classCliente.cnn = _cnn
            _msg = ""
            ds = classCliente.CARGA_COMBO_CLIENTE(_msg)
            If _msg = "" Then
                Me.cmbCliente.DataSource = ds.Tables(0)
                Me.cmbCliente.DisplayMember = "MENSAJE"
                Me.cmbCliente.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_CLIENTE", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CONFIGURA_COLUMNAS_EMBARQUES()
        Grilla.Columns(COL_GRI_EMB_SELLO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_FECHA_INGRESO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_FECHA_DESPACHO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_HORA_CITA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_TIPO_TRANSPORTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_CHOFER).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_VEHICULO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_NPALLET).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_NPALLETD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_VER).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_IMPRIMIR).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_ELIMINAR).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_EMB_EXPORTA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub CONFIGURA_COLUMNAS_OC()
        GrillaOrden.Columns(COL_GRI_OC_CLIENTE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaOrden.Columns(COL_GRI_OC_NOEMB).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaOrden.Columns(COL_GRI_OC_EMBHOY).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaOrden.Columns(COL_GRI_OC_POREMB).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub INICIALIZA()
        Me.WindowState = FormWindowState.Maximized
        lblTotal.Text = "Cantidad de registros encontrados: 0"
        txtSello.Text = ""
        optPropio.Checked = True
        chkDespacho.Checked = False
        dtpDesde.Value = GLO_FECHA_SISTEMA
        dtpHasta.Value = GLO_FECHA_SISTEMA
        Grilla.DataSource = Nothing
        Grilla.Rows.Clear()
        chkDespacho.Checked = True

        Call CARGA_COMBO_CLIENTE()

        'Call CARGA_GRILLA()
    End Sub

    Private Sub CARGA_GRILLA()
        Dim classEmbarque As class_embarque = New class_embarque
        Dim mesDesde As String = ""
        Dim diaDesde As String = ""
        Dim mesHasta As String = ""
        Dim diaHasta As String = ""
        Dim Fila As Integer = 0
        Dim tipoTransporte As String = ""

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            Me.Cursor = Cursors.WaitCursor
            ds = Nothing
            classEmbarque.cnn = _cnn
            classEmbarque.emb_sello = IIf(txtSello.Text = "", "-", txtSello.Text)

            If optPropio.Checked = True Then
                classEmbarque.emb_tipo = 1
            Else
                classEmbarque.emb_tipo = 2
            End If

            If chkOrdenCompra.Checked = True Then
                If txtOrdenCompra.Text = "" Then
                    classEmbarque.numOrdenCompra = CLng(0)
                Else
                    classEmbarque.numOrdenCompra = CLng(txtOrdenCompra.Text)
                End If

            Else
                classEmbarque.numOrdenCompra = CLng(0)
            End If

            If chkDespacho.Checked = True Then
                'fecha ingreso desde
                If CStr(dtpDesde.Value.Month).Length = 1 Then
                    mesDesde = Trim("0" + CStr(dtpDesde.Value.Month))
                Else
                    mesDesde = CStr(dtpDesde.Value.Month)
                End If

                If CStr(dtpDesde.Value.Day).Length = 1 Then
                    diaDesde = Trim("0" + CStr(dtpDesde.Value.Day))
                Else
                    diaDesde = CStr(dtpDesde.Value.Day)
                End If
                classEmbarque.fecha_despacho_desde = CStr(dtpDesde.Value.Year) + mesDesde + diaDesde

                'fecha ingreso hasta
                If CStr(dtpHasta.Value.Month).Length = 1 Then
                    mesHasta = Trim("0" + CStr(dtpHasta.Value.Month))
                Else
                    mesHasta = CStr(dtpHasta.Value.Month)
                End If

                If CStr(dtpDesde.Value.Day).Length = 1 Then
                    diaHasta = Trim("0" + CStr(dtpHasta.Value.Day))
                Else
                    diaHasta = CStr(dtpHasta.Value.Day)
                End If
                classEmbarque.fecha_despacho_hasta = CStr(dtpHasta.Value.Year) + mesHasta + diaHasta
            Else
                classEmbarque.fecha_despacho_desde = "19000101"
                classEmbarque.fecha_despacho_hasta = "20501231"
            End If

            If chkBuscaDoc.Checked = True Then

                If txtDocumento.Text = "0" Or txtDocumento.Text = "" Then
                    If optFactura.Checked = True Then
                        MessageBox.Show("Debe ingresar el número de factura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ElseIf optGuia.Checked = True Then
                        MessageBox.Show("Debe ingresar el número de la guia de despacho", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    txtDocumento.Focus()
                    Exit Sub
                End If

                If optFactura.Checked = True Then
                    classEmbarque.tipoDocumento = "F"
                Else
                    classEmbarque.tipoDocumento = "G"
                End If
                classEmbarque.numDocumento = CLng(txtDocumento.Text)
            Else
                classEmbarque.tipoDocumento = "N"
                classEmbarque.numDocumento = 0
            End If

            If cmbCliente.Text = "" Then
                classEmbarque.car_codigo = 0
            Else
                classEmbarque.car_codigo = cmbCliente.SelectedValue
            End If

            _msg = ""

            Grilla.Rows.Clear()
            ds = classEmbarque.DESPACHO_EMBARQUE_ENC_LISTADO(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("emb_sello") <> "" Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            If ds.Tables(0).Rows(Fila)("emb_tipo") = 1 Then
                                tipoTransporte = "PROPIO"
                            Else
                                tipoTransporte = "EXTERNO"
                            End If

                            Grilla.Rows.Add(ds.Tables(0).Rows(Fila)("emb_sello"),
                                            ds.Tables(0).Rows(Fila)("emb_fechaingreso"),
                                            ds.Tables(0).Rows(Fila)("emb_fechadespacho"),
                                            ds.Tables(0).Rows(Fila)("emb_horacita"),
                                            tipoTransporte,
                                            ds.Tables(0).Rows(Fila)("emb_chofernombre"),
                                            ds.Tables(0).Rows(Fila)("emb_transporte"),
                                            ds.Tables(0).Rows(Fila)("emb_cantpallet"),
                                            ds.Tables(0).Rows(Fila)("emb_cantpalletdoble"))
                            Fila = Fila + 1
                        Loop

                    End If
                    Call CONFIGURA_COLUMNAS_EMBARQUES()
                    lblTotal.Text = "Cantidad de registros encontrados: " + ds.Tables(0).Rows.Count.ToString
                End If
                Me.Text = "LISTADO DE EMBARQUES - [ULTIMA CONSULTA: " + DateTime.Now.ToString() + "]"

            Else
                MessageBox.Show(_msg + "\CARGA_GRILLA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message + " " + "CARGA_GRILLA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_GRILLA_OC()
        Dim classEmbarque As class_embarque = New class_embarque
        Dim mesDesde As String = ""
        Dim diaDesde As String = ""
        Dim mesHasta As String = ""
        Dim diaHasta As String = ""
        Dim Fila As Integer = 0
        Dim tipoTransporte As String = ""
        Dim _msg As String = ""

        Try
            Dim ds As DataSet = New DataSet

            ds = Nothing

            GrillaOrden.Rows.Clear()
            classEmbarque.cnn = _cnn
            ds = classEmbarque.DESPACHO_EMBARQUE_OC(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("car_nombre") <> "" Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            GrillaOrden.Rows.Add(ds.Tables(0).Rows(Fila)("car_codigo"),
                                            ds.Tables(0).Rows(Fila)("car_nombre"),
                                            ds.Tables(0).Rows(Fila)("Pasado"),
                                            ds.Tables(0).Rows(Fila)("Actual"),
                                            ds.Tables(0).Rows(Fila)("Futura"))
                            Fila = Fila + 1
                        Loop

                    End If
                    Call CONFIGURA_COLUMNAS_OC()
                End If

            Else
                MessageBox.Show(_msg + "\CARGA_GRILLA_OC", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA_OC", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub ButtonNueva_Click(sender As Object, e As EventArgs) Handles ButtonNueva.Click
        Dim frm As frm_ingreso_datos_despacho = New frm_ingreso_datos_despacho
        frm.cnn = _cnn
        frm.ShowDialog()
        Call CARGA_GRILLA()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call CARGA_GRILLA()
    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        Dim numDevolucion As Integer = 0
        Try
            If e.ColumnIndex = 9 Then
                Dim frm As frm_ingreso_datos_despacho = New frm_ingreso_datos_despacho
                frm.cnn = _cnn
                frm.sel_codigo = Grilla.Rows(e.RowIndex).Cells(0).Value
                frm.ShowDialog()
                Call CARGA_GRILLA()
            ElseIf e.ColumnIndex = 11 Then
                numDevolucion = VERIFICA_DEVOLUCIONES(Grilla.Rows(e.RowIndex).Cells(0).Value)
                If numDevolucion > 0 Then
                    MessageBox.Show("No es posible eliminar el embarque ya que tiene la devolucion n°: " + numDevolucion.ToString + " asociada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If vbYes = MessageBox.Show("¿Esta seguro(a) de eliminar el registro seleccionado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    Call ELIMINA_REGISTRO(Grilla.Rows(e.RowIndex).Cells(0).Value)
                End If
            ElseIf e.ColumnIndex = 10 Then
                Dim frm As frm_imprimir = New frm_imprimir
                frm.Origen = "EM"
                frm.emb_sello = Grilla.Rows(e.RowIndex).Cells(0).Value
                frm.ShowDialog()

            ElseIf e.ColumnIndex = 12 Then
                Call carga_gilla_exportar_picking(Grilla.Rows(e.RowIndex).Cells(0).Value)
                Call expParaTransporte()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub expParaTransporte()
        Dim class_comunes As class_comunes = New class_comunes
        Dim respuesta As Integer = 0

        Try
            respuesta = MessageBox.Show("Esta acción podría tardar un tiempo considerable dependiendo de la cantidad de registros," _
                                               + Chr(10) + "¿Desea seguir ejecutando la acción?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Exit Sub
            End If

            If respuesta = vbYes Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Call ExportarDatosExcel(grillaExportar, "LISTADO PARA TRANSPORTE")
                Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub carga_gilla_exportar_picking(ByVal Sello As String)
        Dim classPicking As class_picking = New class_picking
        Dim Seleccionados As String = ""
        Dim Fila As Integer = 0
        Dim FechaMin As String = ""
        Dim FechaMax As String = ""

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String

            ds = Nothing
            classPicking.cnn = _cnn

            classPicking.strCadena = "-"
            classPicking.Sello = Sello

            _msg = ""
            grillaExportar.Rows.Clear()
            ds = classPicking.PICKING_LISTADO_PARA_EXPORTAR_ARCHIVO(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("nombre_producto") <> "" Then
                        Do While Fila < ds.Tables(0).Rows.Count

                            FechaMin = CDate(ds.Tables(0).Rows(Fila)("FECHA_MIN")).ToString("dd-MM-yyyy")
                            FechaMax = CDate(ds.Tables(0).Rows(Fila)("FECHA_MAX")).ToString("dd-MM-yyyy")

                            grillaExportar.Rows.Add(ds.Tables(0).Rows(Fila)("guia"),
                            ds.Tables(0).Rows(Fila)("orde_compra"),
                            ds.Tables(0).Rows(Fila)("patente"),
                            ds.Tables(0).Rows(Fila)("nombre_producto"),
                            ds.Tables(0).Rows(Fila)("cantidad_bulto"),
                            ds.Tables(0).Rows(Fila)("codigo"),
                            ds.Tables(0).Rows(Fila)("rut_cliente"),
                            ds.Tables(0).Rows(Fila)("nombre_cliente"),
                            ds.Tables(0).Rows(Fila)("telefono"),
                            ds.Tables(0).Rows(Fila)("email_cliente"),
                            ds.Tables(0).Rows(Fila)("direccion_clinete"),
                            ds.Tables(0).Rows(Fila)("comuna"),
                            ds.Tables(0).Rows(Fila)("LAT"),
                            ds.Tables(0).Rows(Fila)("LONG"),
                            FechaMin,
                            FechaMax,
                            ds.Tables(0).Rows(Fila)("precio"))

                            Fila = Fila + 1
                        Loop

                    End If
                End If

            Else
                MessageBox.Show(_msg + "\carga_gilla_exportar_picking", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "carga_gilla_exportar_picking", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub


    Private Function VERIFICA_DEVOLUCIONES(ByVal embSello As String) As Integer
        Dim classEmbarque As class_embarque = New class_embarque
        Dim Fila As Integer = 0
        VERIFICA_DEVOLUCIONES = 0


        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing
            classEmbarque.cnn = _cnn
            classEmbarque.emb_sello = embSello

            _msg = ""
            ds = classEmbarque.VERIFICA_DEVOLUCIONES(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    VERIFICA_DEVOLUCIONES = ds.Tables(0).Rows(Fila)("dev_codigo")
                End If
            Else
                MessageBox.Show(_msg + "\VERIFICA_DEVOLUCIONES", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            VERIFICA_DEVOLUCIONES = 0
            MsgBox(ex.Message + " " + "CARGA_GRILLA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Function



    Private Sub ELIMINA_REGISTRO(ByVal sello As String)
        Dim classEmbarque As class_embarque = New class_embarque
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim _msg As String = ""

        Try
            ds = Nothing
            classEmbarque.cnn = _cnn
            classEmbarque.emb_sello = sello

            ds = classEmbarque.DESPACHO_EMBARQUE_ELIMINA(_msgError)
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
            Call CARGA_GRILLA()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Call INICIALIZA()
    End Sub

    Private Sub chkDespacho_CheckedChanged(sender As Object, e As EventArgs) Handles chkDespacho.CheckedChanged
        If chkDespacho.Checked = True Then
            dtpDesde.Enabled = True
            dtpHasta.Enabled = True
        ElseIf chkDespacho.Checked = True Then
            dtpDesde.Enabled = False
            dtpHasta.Enabled = False
        End If
    End Sub

    Private Sub ButtonExportar_Click(sender As Object, e As EventArgs) Handles ButtonExportar.Click
        Dim class_comunes As class_comunes = New class_comunes
        Dim respuesta As Integer = 0

        Try
            respuesta = MessageBox.Show("Esta acción podría tardar un tiempo considerable dependiendo de la cantidad de registros," _
                                                + Chr(10) + "¿Desea seguir ejecutando la acción?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Exit Sub
            End If
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            class_comunes.ExportarExcel(Me.Grilla)
            Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkBuscaDoc_CheckedChanged(sender As Object, e As EventArgs) Handles chkBuscaDoc.CheckedChanged
        If chkBuscaDoc.Checked = True Then
            optFactura.Enabled = True
            optGuia.Enabled = True

            optFactura.Checked = True
            optGuia.Checked = False
            txtDocumento.Enabled = True
        Else
            optFactura.Enabled = False
            optGuia.Enabled = False
            txtDocumento.Enabled = False
            txtDocumento.Text = "0"
        End If
    End Sub

    Private Sub chkOrdenCompra_CheckedChanged(sender As Object, e As EventArgs) Handles chkOrdenCompra.CheckedChanged
        txtOrdenCompra.Enabled = chkOrdenCompra.Checked
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call CARGA_GRILLA_OC()
    End Sub

    Private Sub frm_listado_embarques_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call CARGA_GRILLA_OC()
    End Sub
End Class