Imports System.IO
Imports System.IO.File
Imports System.Xml.Linq
Imports System.Threading
Public Class CargaMasivaB2B
    Private _CantidadIngreso As Integer = 0
    Private _CantidadActualizacion As Integer = 0
    Private _cnn As String

    Const LOG_ERROR As Integer = 1
    Const LOG_INFORMACION As Integer = 2
    Const LOG_ADVERTENCIA As Integer = 3

    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property

    '========================================================================
    'Variables de procedimiento de ingreso
    '========================================================================
    Dim CAR_CODIGO As Integer = 0
    Dim CON_OCNUMERO As Long = 0
    Dim CON_SKUCLIENTE As String = ""
    Dim CON_SKUDESCRIPCION As String = ""
    Dim CON_CANTIDAD As String = "0"
    Dim CON_PRECIOCOSTO As String = "0"
    Dim CON_FECHADESPACHO As Date = "01-01-1900"
    Dim CON_DESPACHARANUMERO As String = ""
    Dim CON_DESPACHARA As String = ""
    Dim CON_LOCAL As String = ""
    Dim CON_LOCALNOMBRE As String = ""
    Dim CON_RUTCLIENTE As String = ""
    Dim CON_NOMBRECLIENTE As String = ""
    Dim CON_OBSERVACION As String = ""
    Dim CON_CODIGOUNICO As String = ""
    Dim CON_ESAGENDABLE As Boolean = False
    Dim CON_ESABIERTA As Boolean = False
    Dim CON_NOMBREARCHIVO As String = ""
    Dim CON_TIPO As String = ""

    Dim CON_COMUNARECEPTOR As String = "-"
    Dim CON_CIUDADRECEPTOR As String = "-"

    Dim CON_SUCURSALENTREGA As String = "-"

    Dim CON_FECHAVENTA As Date = "01-01-1900"
    Dim CON_NUMBOLETA As Integer = 0
    Dim CON_FECHAENTREGA As Date = "01-01-1900"
    Dim CON_NUMCAJA As Integer = 0
    Dim CON_GLOSADEPTO As String = ""
    Dim CON_CODIGODEPTO As String = ""
    Dim CON_CODIGOEAN13 As String = ""

    Dim CON_CODLINEA As String = ""
    Dim CON_NOMBRELINEA As String = ""
    Dim CON_CODSUCURSALENTREGA As String = "-"
    Dim CON_CODAUXILIAR As String = ""
    Dim CON_CONLPN As String = ""
    Dim CON_SUB_ORDEN As String = ""
    Dim CON_PRECIOLISTA As Long = 0

    Dim CON_REGIONNOMBRE As String = ""
    Dim CON_DIRECCIONCLIENTE As String = ""

    Dim CON_TEMPORADA As String = "-"
    Dim CON_TALLA As String = "-"
    Dim CON_COLOR As String = "-"

    Dim CON_FECHAEMISION As Date = "01-01-1900"

    Dim CON_TELEFONOCLIENTE As String = "-"
    Dim CON_EMAILCLIENTE As String = "-"

    Dim CON_NUMERO_ND As String = "-"
    Dim CON_UNIDADES_X_EMPAUQE As String = "-"
    Dim CON_NUMERO_ENTREGA As String = "-"
    Dim CON_LOCALIDAD As String = "-"
    Dim CON_FECHAENTREGACLIENTE As Date = "01-01-1900"

    Dim CON_ID_REGION As Integer = 0
    Dim CON_ID_CIUDAD As Integer = 0
    Dim CON_ID_COMUNA As Integer = 0

    Dim CON_UPC As String = "-"
    Dim CON_TIPOORDEN As String = "-"
    Dim CON_COBRA_DESPACHO As Boolean = 0

    Dim contador As Integer = 0
    Dim contadorTotal As Integer = 0

    '1   SODIMAC S.A
    '2   HOMY
    '3   HITES S.A..
    '4   FALABELLA.
    '5   EASY.
    '9   RIPLEY0
    '6   PARIS
    '24  ABCDIN
    '8   LIDER
    '98  LA POLAR
    '7   CORONA
    '137 PIMARES
    '122 UNIMARC
    '143 FAVATEX

    Dim codCliente As Integer = 0

    'COLUMNAS DE LA GRILLA
    '---------------------------------------------------------
    Const COL_GRI_SELECCION As Integer = 0
    Const COL_GRI_CAR_CODIGO As Integer = 1
    Const COL_GRI_CAR_NOMBRE As Integer = 2
    Const COL_GRI_CON_FECHAHORACARGA As Integer = 3
    Const COL_GRI_CON_CANTIDADREGISTROSACTUALIZADOS As Integer = 4
    Const COL_GRI_CON_CANTIDADREGISTROS As Integer = 5
    Const COL_GRI_CAR_CARPETACLIENTE As Integer = 6
    Const COL_GRI_CAR_DELIMITADOR As Integer = 7
    Const COL_GRI_OBSERVACION As Integer = 8
    Const COL_GRI_LINK As Integer = 9

    Private Sub CargaMasivaB2B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New System.Drawing.Point(481, 16)
        CheckForIllegalCrossThreadCalls = False
        Call CARGA_GRILLA()
    End Sub

    Private Sub CARGA_GRILLA()
        Dim classCartera As class_cartera = New class_cartera
        Dim Fila As Integer = 0
        Dim msgError As String = ""
        Try
            Dim ds As DataSet = New DataSet
            ds = Nothing
            Grilla.Rows.Clear()
            msgError = ""
            classCartera.cnn = _cnn
            ds = classCartera.LISTA_CLIENTE_B2B(msgError)
            If msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("car_nombre") <> "" Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            Grilla.Rows.Add(False,
                                            ds.Tables(0).Rows(Fila)("car_codigo"),
                                            ds.Tables(0).Rows(Fila)("car_nombre"),
                                            ds.Tables(0).Rows(Fila)("con_fechahoracarga"),
                                            ds.Tables(0).Rows(Fila)("con_cantidadregistrosactualizados"),
                                            ds.Tables(0).Rows(Fila)("con_cantidadregistros"),
                                            ds.Tables(0).Rows(Fila)("car_carpetarepositorioB2B"),
                                            ds.Tables(0).Rows(Fila)("car_delimitador"),
                                            "",
                                            "")
                            Fila = Fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS()
                    End If
                End If
            Else
                MessageBox.Show(msgError + "\CARGA_GRILLA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CONFIGURA_COLUMNAS()
        Grilla.Columns(COL_GRI_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CAR_CODIGO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CAR_NOMBRE).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CON_FECHAHORACARGA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CON_CANTIDADREGISTROSACTUALIZADOS).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CON_CANTIDADREGISTROS).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_LINK).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim procesoEjecuta As Thread = Nothing
        Dim procesoEjecutaStar As New ThreadStart(AddressOf CargaOrdenesCompra)
        procesoEjecuta = New Thread(procesoEjecutaStar)
        procesoEjecuta.IsBackground = True
        procesoEjecuta.Name = "cargaOrdenes"
        procesoEjecuta.Start()
    End Sub

    Private Sub CargaOrdenesCompra()
        Dim classRepositorio As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim contador As Integer = 0
        Dim _msgError As String = ""
        Dim _FilaIdentificada As String = ""
        Dim fila As Integer = 0
        Dim contadorTotal As Integer = 0
        Dim contadorTotalActualizacion As Integer = 0

        Dim RecorreArchivos As Thread = Nothing


        Try
            For Each row As DataGridViewRow In Me.Grilla.Rows
                If row.Cells(COL_GRI_SELECCION).Value = True Then
                    contador = contador + 1
                End If
            Next

            If contador = 0 Then
                MessageBox.Show("Debe seleccionar a lo menos un cliente ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            contador = 0

            Me.Cursor = Cursors.WaitCursor

            For Each row As DataGridViewRow In Me.Grilla.Rows
                If row.Cells(COL_GRI_SELECCION).Value = True Then


                    _CantidadIngreso = 0
                    _CantidadActualizacion = 0
                    Dim carpetas() As String = Directory.GetFiles(rutaRepositorios + row.Cells(COL_GRI_CAR_CARPETACLIENTE).Value)
                    If carpetas.Length <> 0 Then

                        ListFiles(rutaRepositorios + row.Cells(COL_GRI_CAR_CARPETACLIENTE).Value.ToString, row.Cells(COL_GRI_CAR_DELIMITADOR).Value.ToString, row.Cells(COL_GRI_CAR_CODIGO).Value.ToString, "", _msgError, _FilaIdentificada, row.Cells(COL_GRI_CAR_NOMBRE).Value)

                        If _msgError <> "" Then

                            MessageBox.Show("Se produjo un error en el proceso!!" _
                                                + Chr(10) + "Se ingresaron " + contadorTotal.ToString() + " registros nuevos a la base de datos." _
                                                + Chr(10) + "Se actualizaron " + contadorTotalActualizacion.ToString() + " registros.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            'Call CARGA_GRILLA()
                            Grilla.Rows(fila).Cells(COL_GRI_OBSERVACION).Value = _FilaIdentificada + " " + Chr(10) + "[" + _msgError + "]"
                            Grilla.Rows(fila).Cells(COL_GRI_LINK).Value = "Ver Error"
                            Call CONFIGURA_COLUMNAS()
                            Call PINTA_CELDA_ROJO(fila)
                            Me.Cursor = Cursors.Default
                            'lblArchivo.Text = "Archivo: "
                            Exit Sub
                        End If

                        _msgError = ""
                        contadorTotal = contadorTotal + _CantidadIngreso
                        contadorTotalActualizacion = contadorTotalActualizacion + _CantidadActualizacion

                        If INGRESA_ULTIMA_CARGA(_msgError, row.Cells(COL_GRI_CAR_CODIGO).Value, _CantidadIngreso, _CantidadActualizacion) = False Then
                            MessageBox.Show("Se produjo un error en el proceso!!" _
                                                + Chr(10) + "Se ingresaron " + contadorTotal.ToString() + " registros nuevos a la base de datos." _
                                                + Chr(10) + "Se actualizaron " + contadorTotalActualizacion.ToString() + " registros.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Call CARGA_GRILLA()
                            Grilla.Rows(fila).Cells(COL_GRI_OBSERVACION).Value = _msgError
                            Grilla.Rows(fila).Cells(COL_GRI_LINK).Value = "Ver Error"
                            Call CONFIGURA_COLUMNAS()
                            Call PINTA_CELDA_ROJO(fila)
                            Exit Sub
                        End If

                        If _msgError <> "" Then

                            MessageBox.Show("Se produjo un error en el proceso!!" _
                                                + Chr(10) + "Se ingresaron " + contadorTotal.ToString() + " registros nuevos a la base de datos." _
                                                + Chr(10) + "Se actualizaron " + contadorTotalActualizacion.ToString() + " registros.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Call CARGA_GRILLA()
                            Grilla.Rows(fila).Cells(COL_GRI_OBSERVACION).Value = _FilaIdentificada + " " + Chr(10) + "[" + _msgError + "]"
                            Grilla.Rows(fila).Cells(COL_GRI_LINK).Value = "Ver Error"
                            Call CONFIGURA_COLUMNAS()
                            Call PINTA_CELDA_ROJO(fila)
                            Me.Cursor = Cursors.Default
                            lblArchivo.Text = "Archivo: "
                            Exit Sub
                        End If
                    End If

                End If
                fila = fila + 1

            Next

            Me.Cursor = Cursors.Default
            lblArchivo.Text = "Archivo: "

            MessageBox.Show("Proceso finalizado con exito!!" _
                          + Chr(10) + "Se ingresaron " + contadorTotal.ToString() + " registros nuevos a la base de datos." _
                          + Chr(10) + "Se actualizaron " + contadorTotalActualizacion.ToString() + " registros.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call CARGA_GRILLA()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function INGRESA_ULTIMA_CARGA(ByRef msgError As String, ByVal carCodigo As Integer, ByVal cantidadRegistro As Integer, ByVal cantidadRegistroActualizado As Integer) As Boolean

        Dim classRepositorio As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet

        INGRESA_ULTIMA_CARGA = False

        Try
            classRepositorio.cnn = _cnn
            classRepositorio.car_codigo = carCodigo
            classRepositorio.con_cantidadregistros = cantidadRegistro
            classRepositorio.con_cantidadregistrosactualizados = cantidadRegistroActualizado

            ds = classRepositorio.ULTIMA_CARGA_GUARDA_DATOS(msgError)
            If ds.Tables(0).Rows.Count > 0 Then
                If msgError = "" Then
                    If ds.Tables(0).Rows(0)("codigo") < 0 Then
                        msgError = ds.Tables(0).Rows(0)("mensaje")
                        Exit Function
                    End If
                End If
            End If
            INGRESA_ULTIMA_CARGA = True
        Catch ex As Exception
            msgError = ex.Message
        End Try
    End Function
    Private Sub PINTA_CELDA_ROJO(ByVal fila As Integer)
        Grilla.Item(COL_GRI_SELECCION, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_SELECCION, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CAR_CODIGO, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CAR_CODIGO, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CAR_NOMBRE, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CAR_NOMBRE, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CON_FECHAHORACARGA, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CON_FECHAHORACARGA, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CON_CANTIDADREGISTROSACTUALIZADOS, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CON_CANTIDADREGISTROSACTUALIZADOS, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CON_CANTIDADREGISTROS, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CON_CANTIDADREGISTROS, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CAR_CARPETACLIENTE, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CAR_CARPETACLIENTE, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_CAR_DELIMITADOR, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_CAR_DELIMITADOR, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_OBSERVACION, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_OBSERVACION, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

        Grilla.Item(COL_GRI_LINK, fila).Style.BackColor = Color.FromArgb(255, 214, 214)
        Grilla.Item(COL_GRI_LINK, fila).Style.ForeColor = Color.FromArgb(253, 49, 49)

    End Sub

    'Private Function ListFiles(ByVal folderPath As String, ByVal delimitador As String, ByVal codigo As Integer, ByVal extension As String, ByRef _msgError As String, ByRef _FilaIdentificada As String, ByVal Cliente As String)
    Private Function ListFiles(ByVal folderPath As String, ByVal delimitador As String, ByVal codigo As Integer, ByVal extension As String, ByRef _msgError As String, ByRef _FilaIdentificada As String, ByVal Cliente As String) As Boolean
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim rutaArchivo As String = ""
        Dim ds As DataSet = New DataSet

        Dim filaActual As Integer = 1

        Dim Delimiter As String = ","

        Dim sLine As String = ""
        Dim FILA As String() = Nothing
        Dim charVar As Char

        Dim I As Integer = 1

        Dim ExtensionArchivo As String = ""
        Dim NombreArchivo As String = ""

        charVar = ","
        ListFiles = False

        Try
            prbArchivo.Value = 0
            prbArchivo.Minimum = 0
            prbArchivo.Maximum = My.Computer.FileSystem.GetFiles(folderPath).Count
            prbArchivo.Refresh()

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(folderPath)
                prbArchivo.Value += 1
                charVar = delimitador
                rutaArchivo = foundFile
                Dim Archivo As New FileInfo(foundFile)
                Dim lineas() As String = File.ReadAllLines(foundFile)

                ExtensionArchivo = Archivo.Extension
                NombreArchivo = Path.GetFileName(rutaArchivo)

                If ExtensionArchivo <> ".db" Then
                    lblArchivo.Text = "Archivo: " + Cliente + " [ " + Archivo.Name.ToString() + " ]"
                    lblArchivo.Update()

                    Dim objReader As New StreamReader(rutaArchivo)
                    filaActual = 1
                    I = 1

                    Do
                        sLine = objReader.ReadLine()

                        If codigo = CLIENTES.RIPLEY Then
                            If Mid(sLine, 1, 1) = Chr(34) Then
                                sLine = Mid(sLine, 3, sLine.Length - 3)
                            End If
                        End If


                        If Not sLine Is Nothing Then
                            If filaActual > 1 Then
                                If codigo <> CLIENTES.FALABELLA And codigo <> CLIENTES.SODIMAC And codigo <> CLIENTES.PRIMARES And codigo <> CLIENTES.HOMY Then
                                    FILA = Util.Cadenas.Csv.LineaCsvToArray(charVar, sLine)
                                End If

                                If codigo = CLIENTES.HITES Then
                                    If FILA(0).Length > 50 Then
                                        charVar = ";"
                                        FILA = Util.Cadenas.Csv.LineaCsvToArray(charVar, sLine)
                                    End If
                                    CargaDatosHites(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.EASY Then
                                    If FILA(0).Length > 50 Then
                                        charVar = ";"
                                        FILA = Util.Cadenas.Csv.LineaCsvToArray(charVar, sLine)
                                    End If
                                    CargaDatosEasy(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.PARIS Then
                                    If FILA(0).Length > 50 Then
                                        charVar = ","
                                        FILA = Util.Cadenas.Csv.LineaCsvToArray(charVar, sLine)
                                    End If
                                    CargaDatosParis(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.RIPLEY Then
                                    If FILA(0).Length > 50 Then
                                        charVar = ","
                                        FILA = Util.Cadenas.Csv.LineaCsvToArray(charVar, sLine)
                                    End If
                                    CargaDatosRipley(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.CORONA Then
                                    CargaDatosCorona(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.ABCDIN Then
                                    charVar = ","
                                    FILA = Util.Cadenas.Csv.LineaCsvToArray(charVar, sLine)
                                    CargaDatosAbcDin(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.FALABELLA Then
                                    FILA = IO.File.ReadAllLines(rutaArchivo)(I).Split(delimitador)
                                    CargaDatosFalabella(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.SODIMAC Then
                                    FILA = IO.File.ReadAllLines(rutaArchivo)(I).Split(delimitador)
                                    CargaDatosSodimac(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.PRIMARES Then
                                    FILA = IO.File.ReadAllLines(rutaArchivo)(I).Split(delimitador)
                                    CargaDatosPrimares(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.HOMY Then
                                    FILA = IO.File.ReadAllLines(rutaArchivo)(I).Split(delimitador)
                                    CargaDatosVicenti(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.LIDER Then
                                    CargaDatosLider(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.LA_POLAR Then
                                    CargaDatosLaPolar(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.FAVATEX_INTERNET Then
                                    If FILA(0).Length > 50 Then
                                        charVar = ","
                                        FILA = Util.Cadenas.Csv.LineaCsvToArray(charVar, sLine)
                                    End If
                                    CargaDatosFavatexInternet(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                ElseIf codigo = CLIENTES.CONSTRUMART Then
                                    CargaDatosConstrumart(FILA, rutaArchivo, _msgError, _FilaIdentificada)
                                End If
                                I = I + 1
                            End If
                        End If
                        filaActual = filaActual + 1

                    Loop Until sLine Is Nothing
                End If


            Next
            prbArchivo.Value = 0
            prbArchivo.Minimum = 0
        Catch ex As Exception
            _msgError = ex.Message
        End Try
    End Function

    Private Sub CargaDatosFavatexInternet(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim OCNUM As String = ""
        Dim caracter As String = Chr(34)
        Dim MiP As String = ""

        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = ""
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"

            CON_DIRECCIONCLIENTE = "-"
            CON_TELEFONOCLIENTE = "-"
            CON_EMAILCLIENTE = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"

            CON_ID_REGION = 0
            CON_ID_CIUDAD = 0
            CON_ID_COMUNA = 0
            CON_COBRA_DESPACHO = 0

            CAR_CODIGO = CLIENTES.FAVATEX_INTERNET
            If DATOS.Length = 15 Then
                OCNUM = DATOS(0)
                'If OCNUM <> "12599" Then
                '    Exit Sub
                'End If

                MiP = Strings.Replace(Strings.Replace(OCNUM, Chr(34), ""), Chr(34), "")

                CON_OCNUMERO = Strings.Replace(DATOS(0).ToString, Chr(34), "")
                'CON_OCNUMERO = DATOS(0)
                CON_FECHAEMISION = Strings.Replace(DATOS(1).ToString, Chr(34), "") 'DATOS(1)
                CON_SKUCLIENTE = DATOS(2)
                CON_SKUDESCRIPCION = Strings.Replace(DATOS(3).ToString, Chr(34), "") 'DATOS(3)
                CON_CANTIDAD = DATOS(4).ToString()
                CON_PRECIOCOSTO = DATOS(5).ToString()
                CON_FECHADESPACHO = Strings.Replace(DATOS(6).ToString, Chr(34), "") 'DATOS(6)
                CON_FECHADESPACHO = Mid(CON_FECHADESPACHO, 1, 10)
                CON_CODIGOUNICO = DATOS(7)
                CON_RUTCLIENTE = DATOS(8)
                CON_NOMBRECLIENTE = DATOS(9)
                CON_TELEFONOCLIENTE = DATOS(10)
                CON_EMAILCLIENTE = DATOS(11)
                CON_DIRECCIONCLIENTE = Strings.Replace(DATOS(12).ToString, Chr(34), "") 'DATOS(12)
                CON_LOCALNOMBRE = "Favatex"

                CON_DESPACHARA = Strings.Replace(DATOS(12).ToString, Chr(34), "") ' DATOS(12)
                classOrdenes.cnn = _cnn
                classOrdenes.IdRegion = 0
                classOrdenes.IdCiudad = 0
                classOrdenes.IdComuna = Strings.Replace(DATOS(13).ToString, Chr(34), "") 'DATOS(13)
                ds = classOrdenes.CARGA_DATOS_COMUNA(_msgError)
                If _msgError = "" Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If ds.Tables(0).Rows(0)("com_nombre") <> "" Then
                            CON_DESPACHARA = UCase(ds.Tables(0).Rows(0)("zog_nombre"))
                            CON_ID_REGION = ds.Tables(0).Rows(0)("reg_codigo")
                            CON_ID_CIUDAD = ds.Tables(0).Rows(0)("ciu_codigo")
                            CON_ID_COMUNA = ds.Tables(0).Rows(0)("com_codigo")

                            CON_COMUNARECEPTOR = UCase(ds.Tables(0).Rows(0)("com_nombre"))
                            CON_CIUDADRECEPTOR = UCase(ds.Tables(0).Rows(0)("ciu_nombre"))
                            CON_REGIONNOMBRE = UCase(ds.Tables(0).Rows(0)("reg_nombre"))
                        End If
                    End If
                End If

                CON_ESAGENDABLE = False
                CON_ESABIERTA = False

                CON_COBRA_DESPACHO = DATOS(14).ToString()


            End If
            CON_NOMBREARCHIVO = rutaArchivo

            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO
                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR
                classOrdenes.con_regionnombre = CON_REGIONNOMBRE

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.fecha_emision = CON_FECHAEMISION

                classOrdenes.con_telefonocliente = CON_TELEFONOCLIENTE
                classOrdenes.con_emailcliente = CON_EMAILCLIENTE
                classOrdenes.con_direccioncliente = CON_DIRECCIONCLIENTE
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE
                classOrdenes.IdRegion = CON_ID_REGION
                classOrdenes.IdCiudad = CON_ID_CIUDAD
                classOrdenes.IdComuna = CON_ID_COMUNA
                classOrdenes.con_cobradespacho = CON_COBRA_DESPACHO

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosConstrumart(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Dim CON_CODLOCALENTREGA As String = "-"
        Dim CON_NOMLOCALENTREGA As String = "-"
        Dim CON_POSICION As Integer = 0
        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = ""
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"

            CON_DIRECCIONCLIENTE = "-"
            CON_TELEFONOCLIENTE = "-"
            CON_EMAILCLIENTE = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"

            Dim Precio As Integer = 0
            Dim codigoEAN As String = ""

            CAR_CODIGO = CLIENTES.CONSTRUMART
            If DATOS.Length = 33 Then
                CON_OCNUMERO = DATOS(0)
                CON_SKUCLIENTE = DATOS(15)
                CON_SKUDESCRIPCION = DATOS(17)
                CON_CANTIDAD = DATOS(31).ToString()

                Precio = (CInt(DATOS(32).ToString()) / CInt(DATOS(31).ToString())).ToString
                CON_PRECIOCOSTO = Precio

                CON_FECHADESPACHO = CDate(DATOS(9).ToString).ToShortDateString
                CON_FECHAEMISION = CDate(DATOS(7).ToString).ToShortDateString

                CON_DESPACHARANUMERO = DATOS(10)
                CON_DESPACHARA = DATOS(11)
                CON_LOCAL = DATOS(12)
                CON_LOCALNOMBRE = "-"
                CON_RUTCLIENTE = "-"

                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = "-"

                CON_CODIGOUNICO = "-"
                CON_ESAGENDABLE = True
                CON_ESABIERTA = True

                If Len(DATOS(14).ToString()) = 13 Then
                    codigoEAN = Mid(DATOS(14).ToString(), 2, Len(DATOS(14).ToString()))
                    CON_CODIGOEAN13 = classOrdenes.ean13(codigoEAN)
                End If

                CON_COMUNARECEPTOR = "-"
                CON_CIUDADRECEPTOR = "-"


                CON_DIRECCIONCLIENTE = "-"
                CON_TELEFONOCLIENTE = "-"
                CON_EMAILCLIENTE = "-"

                CON_CODLOCALENTREGA = DATOS(29)
                CON_NOMLOCALENTREGA = DATOS(30)

                CON_POSICION = DATOS(13)


            End If
            CON_NOMBREARCHIVO = rutaArchivo

            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO
                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.fecha_emision = CON_FECHAEMISION

                classOrdenes.con_telefonocliente = CON_TELEFONOCLIENTE
                classOrdenes.con_emailcliente = CON_EMAILCLIENTE
                classOrdenes.con_direccioncliente = CON_DIRECCIONCLIENTE
                classOrdenes.con_numero_nd = CON_NUMERO_ND
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE
                classOrdenes.con_codlocalentrega = CON_CODLOCALENTREGA
                classOrdenes.con_nomlocalentrega = CON_NOMLOCALENTREGA
                classOrdenes.con_posicion = CON_POSICION
                classOrdenes.con_codigoEAN13 = CON_CODIGOEAN13


                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosLaPolar(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = ""
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"

            CON_DIRECCIONCLIENTE = "-"
            CON_TELEFONOCLIENTE = "-"
            CON_EMAILCLIENTE = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"

            CAR_CODIGO = CLIENTES.LA_POLAR
            If DATOS.Length = 31 Then
                CON_OCNUMERO = DATOS(0)
                CON_SKUCLIENTE = DATOS(12)
                CON_SKUDESCRIPCION = DATOS(14)
                CON_CANTIDAD = DATOS(19).ToString()
                CON_PRECIOCOSTO = DATOS(15).ToString()
                CON_FECHADESPACHO = DATOS(9)
                CON_DESPACHARANUMERO = "0"
                CON_DESPACHARA = "CD LINEAS DURAS (55)" 'DATOS(10)
                CON_LOCAL = "CD LINEAS DURAS (55)"
                CON_LOCALNOMBRE = "-"
                CON_RUTCLIENTE = "-"

                CON_NOMBRECLIENTE = DATOS(23)
                CON_OBSERVACION = "-"

                CON_CODIGOUNICO = DATOS(1)
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False

                CON_COMUNARECEPTOR = "-"
                CON_CIUDADRECEPTOR = "-"
                CON_FECHAEMISION = DATOS(8)

                CON_DIRECCIONCLIENTE = DATOS(24)
                CON_TELEFONOCLIENTE = DATOS(28)
                CON_EMAILCLIENTE = "-"


            End If
            CON_NOMBREARCHIVO = rutaArchivo

            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then


                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO
                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.fecha_emision = CON_FECHAEMISION

                classOrdenes.con_telefonocliente = CON_TELEFONOCLIENTE
                classOrdenes.con_emailcliente = CON_EMAILCLIENTE
                classOrdenes.con_direccioncliente = CON_DIRECCIONCLIENTE
                classOrdenes.con_numero_nd = CON_NUMERO_ND
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosLider(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Dim Precio As String = ""
        Dim fecha As String = ""
        Dim mesDespacho As String = ""
        Dim diaDespacho As String = ""
        Dim anoDespacho As String = ""

        Dim mesEmision As String = ""
        Dim diaEmision As String = ""
        Dim anoEmision As String = ""

        Dim Cantidad As Integer = 0
        Dim codigoEAN As String = ""

        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = "-"
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"

            CAR_CODIGO = CLIENTES.LIDER
            If DATOS.Length = 21 Then
                CON_OCNUMERO = DATOS(0)
                If CON_OCNUMERO = 4300420616 Then
                    CON_OCNUMERO = CON_OCNUMERO
                End If

                If (DATOS(2) = 20 Or DATOS(2) = 73 Or DATOS(2) = 3) Then
                    CON_OCNUMERO = DATOS(0)
                    CON_SKUCLIENTE = DATOS(5)

                    CON_SKUDESCRIPCION = DATOS(6)
                    CON_CANTIDAD = DATOS(18).ToString()
                    Cantidad = DATOS(18).ToString()
                    Precio = DATOS(20).ToString()

                    If CInt(DATOS(18).ToString()) > 0 Then
                        'CON_PRECIOCOSTO = CInt(Strings.Replace(Precio, ",", "")) / CInt(DATOS(18).ToString())
                        CON_PRECIOCOSTO = CInt(Strings.Replace(Precio, "$", ""))
                        'CON_PRECIOCOSTO = Precio
                    Else
                        CON_PRECIOCOSTO = 0
                    End If

                    'diaDespacho = Mid(Trim(DATOS(3)), 4, 2)
                    'mesDespacho = Mid(Trim(DATOS(3)), 1, 2)
                    'anoDespacho = Mid(Trim(DATOS(3)), 7, 4)

                    diaDespacho = Mid(Trim(DATOS(3)), 1, 2)
                    mesDespacho = Mid(Trim(DATOS(3)), 4, 2)
                    anoDespacho = Mid(Trim(DATOS(3)), 7, 4)

                    CON_FECHADESPACHO = diaDespacho + "-" + mesDespacho + "-" + anoDespacho

                    CON_DESPACHARANUMERO = "-"
                    CON_DESPACHARA = "-"
                    CON_LOCAL = "-"
                    CON_LOCALNOMBRE = "-"
                    CON_NOMBRECLIENTE = "-"
                    CON_RUTCLIENTE = "-"
                    CON_OBSERVACION = "-"
                    CON_CODIGOUNICO = DATOS(8)

                    CON_CODIGOEAN13 = DATOS(8)

                    If Len(DATOS(8).ToString()) = 11 Then
                        CON_CODIGOEAN13 = classOrdenes.ean13("0" + DATOS(8))
                    ElseIf Len(DATOS(8).ToString()) = 12 Then
                        CON_CODIGOEAN13 = classOrdenes.ean13(DATOS(8))
                    ElseIf Len(DATOS(8).ToString()) = 13 Then
                        codigoEAN = Mid(DATOS(8).ToString(), 2, Len(DATOS(8).ToString()))
                        CON_CODIGOEAN13 = classOrdenes.ean13(codigoEAN)
                    End If



                    CON_ESAGENDABLE = True
                    CON_ESABIERTA = True

                    'diaEmision = Mid(Trim(DATOS(1)), 4, 2)
                    'mesEmision = Mid(Trim(DATOS(1)), 1, 2)
                    'anoEmision = Mid(Trim(DATOS(1)), 7, 4)

                    diaEmision = Mid(Trim(DATOS(1)), 1, 2)
                    mesEmision = Mid(Trim(DATOS(1)), 4, 2)
                    anoEmision = Mid(Trim(DATOS(1)), 7, 4)


                    CON_FECHAEMISION = diaEmision + "-" + mesEmision + "-" + anoEmision

                End If

            ElseIf DATOS.Length >= 23 Then
                If DATOS(0).ToString() <> "" Then
                    ''CON_FECHAEMISION = DATOS(0)
                    ''CON_OCNUMERO = DATOS(1)

                    CON_FECHAEMISION = CDate(DATOS(0).ToString())
                    CON_OCNUMERO = DATOS(1)

                    'If CON_OCNUMERO = 4300420616 Then
                    '    CON_OCNUMERO = CON_OCNUMERO
                    'End If

                    CON_SKUCLIENTE = DATOS(16)
                    CON_SKUDESCRIPCION = DATOS(19)
                    CON_CANTIDAD = DATOS(22).ToString()
                    CON_PRECIOCOSTO = CInt(CInt(DATOS(21).ToString()) / CInt(CON_CANTIDAD))
                    CON_FECHADESPACHO = DATOS(24)

                    CON_DESPACHARANUMERO = "-"
                    CON_DESPACHARA = "-"
                    CON_LOCAL = "-"
                    CON_LOCALNOMBRE = "-"
                    CON_NOMBRECLIENTE = "-"
                    CON_RUTCLIENTE = "-"
                    CON_OBSERVACION = "-"
                    CON_CODIGOUNICO = DATOS(2)
                    CON_CODIGOEAN13 = classOrdenes.ean13("0" + Mid(DATOS(18).ToString(), 1, Len(DATOS(18).ToString()) - 1))

                    CON_ESAGENDABLE = False
                    CON_ESABIERTA = False
                Else
                    CON_OCNUMERO = 0
                End If
            End If

            CON_NOMBREARCHIVO = rutaArchivo


            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO

                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.fecha_emision = CON_FECHAEMISION
                classOrdenes.con_codigoEAN13 = CON_CODIGOEAN13
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosVicenti(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = ""
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"


            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"

            CAR_CODIGO = CLIENTES.SODIMAC
            If DATOS.Length = 34 Then
                CON_OCNUMERO = DATOS(1)
                CON_SKUCLIENTE = DATOS(18)
                CON_SKUDESCRIPCION = DATOS(19)
                CON_CANTIDAD = DATOS(21).ToString()
                CON_PRECIOCOSTO = DATOS(22).ToString()
                CON_FECHADESPACHO = DATOS(30)
                CON_DESPACHARANUMERO = "-"
                CON_DESPACHARA = IIf(DATOS(15) = "", "-", DATOS(15))
                CON_LOCAL = IIf(DATOS(14) = "", "-", DATOS(14))
                CON_LOCALNOMBRE = IIf(DATOS(13) = "", "-", DATOS(13))
                CON_RUTCLIENTE = "-"
                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = IIf(DATOS(16) = "", "-", DATOS(16))
                CON_CODIGOUNICO = DATOS(0)
                'If DATOS(0) = "SE" Then
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False
                'Else
                '    CON_ESAGENDABLE = True
                '    CON_ESABIERTA = True
                'End If

                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(Trim(DATOS(17).ToString), 1, 12))
                CON_FECHAEMISION = DATOS(2)

            ElseIf DATOS.Length = 39 Then
                CON_OCNUMERO = DATOS(1)
                CON_SKUCLIENTE = DATOS(25)
                CON_SKUDESCRIPCION = DATOS(26)
                CON_CANTIDAD = DATOS(33).ToString()
                CON_PRECIOCOSTO = DATOS(32).ToString()
                CON_FECHADESPACHO = DATOS(23)
                CON_DESPACHARANUMERO = "-"
                CON_DESPACHARA = DATOS(11)
                CON_LOCAL = "-"
                CON_LOCALNOMBRE = "-"
                CON_RUTCLIENTE = "-"
                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = "-"
                CON_CODIGOUNICO = DATOS(0)
                'If DATOS(0) = "SE" Then
                CON_ESAGENDABLE = True
                CON_ESABIERTA = True
                'Else
                '    CON_ESAGENDABLE = True
                '    CON_ESABIERTA = True
                'End If
                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(Trim(DATOS(24).ToString), 1, 12))
                CON_FECHAEMISION = DATOS(12)

            ElseIf DATOS.Length = 29 Then
                CON_OCNUMERO = DATOS(1)
                CON_SKUCLIENTE = DATOS(16)
                CON_SKUDESCRIPCION = DATOS(17)
                CON_CANTIDAD = DATOS(24).ToString()
                CON_PRECIOCOSTO = 0
                CON_FECHADESPACHO = DATOS(14)
                CON_DESPACHARANUMERO = DATOS(9)
                CON_DESPACHARA = DATOS(10)
                CON_LOCAL = DATOS(9)
                CON_LOCALNOMBRE = DATOS(10)
                CON_RUTCLIENTE = "-"

                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = "-"
                CON_CODIGOUNICO = DATOS(0)
                'If DATOS(0) = "SE" Then
                CON_ESAGENDABLE = True
                CON_ESABIERTA = True
                'Else
                '    CON_ESAGENDABLE = True
                '    CON_ESABIERTA = True
                'End If

                CON_FECHAEMISION = DATOS(12)
            End If
            CON_NOMBREARCHIVO = rutaArchivo

            Dim Fila As Integer = 0
            ds = Nothing

            'Homologacion a SODIMAC VICENTI
            _msgError = ""
            classOrdenes.cnn = _cnn
            classOrdenes.car_codigo = CLIENTES.SODIMAC
            classOrdenes.con_skucliente = CON_SKUCLIENTE
            ds = classOrdenes.HOMOLOGACION_PRODUCTO(_msgError)
            If _msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("codigo") = 1 Then
                        CAR_CODIGO = CLIENTES.SODIMAC
                    ElseIf ds.Tables(0).Rows(Fila)("codigo") = 0 Then
                        CAR_CODIGO = CLIENTES.HOMY
                    End If
                End If
            Else
                'Call INGRESA_LOG(LOG_ERROR, _msgError, "CargaMasivaB2B", 1)
            End If
            'Fin Homologacion


            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO


                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.con_codigoEAN13 = CON_CODIGOEAN13
                classOrdenes.fecha_emision = CON_FECHAEMISION
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosPrimares(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = ""
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"
            CON_TIPOORDEN = "-"
            CON_UPC = "-"

            CAR_CODIGO = CLIENTES.PRIMARES
            If DATOS.Length = 34 Then
                CON_OCNUMERO = DATOS(1)
                CON_TIPOORDEN = "VV"
                CON_UPC = DATOS(17)
                CON_SKUCLIENTE = DATOS(18)
                CON_SKUDESCRIPCION = DATOS(19)
                CON_CANTIDAD = DATOS(21).ToString()
                CON_PRECIOCOSTO = DATOS(22).ToString()
                CON_FECHADESPACHO = DATOS(30)
                CON_DESPACHARANUMERO = "-"
                CON_DESPACHARA = IIf(DATOS(15) = "", "-", DATOS(15))
                CON_LOCAL = IIf(DATOS(14) = "", "-", DATOS(14))
                CON_LOCALNOMBRE = IIf(DATOS(13) = "", "-", DATOS(13))
                CON_RUTCLIENTE = "-"
                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = IIf(DATOS(16) = "", "-", DATOS(16))
                CON_CODIGOUNICO = DATOS(0)
                'If DATOS(0) = "SE" Then
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False
                'Else
                '    CON_ESAGENDABLE = True
                '    CON_ESABIERTA = True
                'End If

                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(Trim(DATOS(17).ToString), 1, 12))
                CON_FECHAEMISION = DATOS(2)

            ElseIf DATOS.Length = 39 Then
                CON_OCNUMERO = DATOS(1)
                CON_TIPOORDEN = DATOS(4)
                CON_SKUCLIENTE = DATOS(25)
                CON_SKUDESCRIPCION = DATOS(26)
                CON_CANTIDAD = DATOS(33.ToString())
                CON_PRECIOCOSTO = DATOS(32).ToString()
                CON_FECHADESPACHO = DATOS(23)
                CON_UPC = DATOS(24)
                CON_DESPACHARANUMERO = "-"
                CON_DESPACHARA = "-" 'IIf(DATOS(15) = "", "-", DATOS(15))
                CON_LOCAL = "-" 'IIf(DATOS(14) = "", "-", DATOS(14))
                CON_LOCALNOMBRE = "-" 'IIf(DATOS(13) = "", "-", DATOS(13))
                CON_RUTCLIENTE = "-"
                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = "-" 'IIf(DATOS(16) = "", "-", DATOS(16))
                CON_CODIGOUNICO = DATOS(0)
                If DATOS(4) = "SE" Then
                    CON_ESAGENDABLE = False
                    CON_ESABIERTA = False
                Else
                    CON_ESAGENDABLE = True
                    CON_ESABIERTA = True
                End If

                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(Trim(DATOS(24).ToString), 1, 12))
                CON_FECHAEMISION = DATOS(12)
            End If
            CON_NOMBREARCHIVO = rutaArchivo


            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                CON_DESPACHARA = "SODIMAC"
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO

                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.con_codigoEAN13 = CON_CODIGOEAN13
                classOrdenes.fecha_emision = CON_FECHAEMISION
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE
                classOrdenes.con_upc = CON_UPC
                classOrdenes.con_tipoorden = CON_TIPOORDEN

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosSodimac(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = ""
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"
            CON_UPC = "-"
            CON_TIPOORDEN = "-"

            CAR_CODIGO = CLIENTES.SODIMAC
            If DATOS.Length = 34 Then
                CON_OCNUMERO = DATOS(1)
                CON_TIPOORDEN = "VV"
                CON_UPC = DATOS(17)
                CON_SKUCLIENTE = DATOS(18)
                CON_SKUDESCRIPCION = DATOS(19)
                CON_CANTIDAD = DATOS(21).ToString()
                CON_PRECIOCOSTO = DATOS(22).ToString()
                CON_FECHADESPACHO = DATOS(30)
                CON_DESPACHARANUMERO = "-"
                CON_DESPACHARA = IIf(DATOS(15) = "", "-", DATOS(15))
                CON_LOCAL = IIf(DATOS(14) = "", "-", DATOS(14))
                CON_LOCALNOMBRE = IIf(DATOS(13) = "", "-", DATOS(13))
                CON_RUTCLIENTE = "-"
                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = IIf(DATOS(16) = "", "-", DATOS(16))
                CON_CODIGOUNICO = DATOS(0)
                'If DATOS(0) = "SE" Then
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False
                'Else
                '    CON_ESAGENDABLE = True
                '    CON_ESABIERTA = True
                'End If

                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(Trim(DATOS(17).ToString), 1, 12))
                CON_FECHAEMISION = DATOS(2)

            ElseIf DATOS.Length = 39 Then
                CON_OCNUMERO = DATOS(1)
                CON_TIPOORDEN = DATOS(4)
                CON_SKUCLIENTE = DATOS(25)
                CON_SKUDESCRIPCION = DATOS(26)
                CON_CANTIDAD = DATOS(33.ToString())
                CON_PRECIOCOSTO = DATOS(32).ToString()
                CON_FECHADESPACHO = DATOS(23)
                CON_UPC = DATOS(24)
                CON_DESPACHARANUMERO = "-"
                CON_DESPACHARA = "-" 'IIf(DATOS(15) = "", "-", DATOS(15))
                CON_LOCAL = "-" 'IIf(DATOS(14) = "", "-", DATOS(14))
                CON_LOCALNOMBRE = "-" 'IIf(DATOS(13) = "", "-", DATOS(13))
                CON_RUTCLIENTE = "-"
                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = "-" 'IIf(DATOS(16) = "", "-", DATOS(16))
                CON_CODIGOUNICO = DATOS(0)
                If DATOS(4) = "SE" Then
                    CON_ESAGENDABLE = False
                    CON_ESABIERTA = False
                Else
                    CON_ESAGENDABLE = True
                    CON_ESABIERTA = True
                End If

                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(Trim(DATOS(24).ToString), 1, 12))
                CON_FECHAEMISION = DATOS(12)
            End If
            CON_NOMBREARCHIVO = rutaArchivo


            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                CON_DESPACHARA = "SODIMAC"
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO

                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.con_codigoEAN13 = CON_CODIGOEAN13
                classOrdenes.fecha_emision = CON_FECHAEMISION
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE
                classOrdenes.con_upc = CON_UPC
                classOrdenes.con_tipoorden = CON_TIPOORDEN

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosAbcDin(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Dim clienteDireccion As String = ""
        Dim clienteTelefono As String = ""
        Dim clienteEmail As String = ""

        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = "-"
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"
            CON_DIRECCIONCLIENTE = "-"
            CON_TELEFONOCLIENTE = "-"
            CON_EMAILCLIENTE = "-"
            CON_LOCALIDAD = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"

            CAR_CODIGO = CLIENTES.ABCDIN
            If DATOS.Length = 41 Then
                CON_OCNUMERO = DATOS(2)

                If CON_OCNUMERO = 5387509 Then
                    CON_OCNUMERO = CON_OCNUMERO
                End If

                CON_SKUCLIENTE = DATOS(9)
                CON_SKUDESCRIPCION = DATOS(11)
                CON_CANTIDAD = DATOS(14).ToString()
                CON_PRECIOCOSTO = DATOS(13).ToString()
                CON_FECHADESPACHO = DATOS(23)
                CON_DESPACHARANUMERO = DATOS(5)
                CON_DESPACHARA = "CD ALERCE" 'DATOS(6)
                CON_LOCAL = "-"
                CON_LOCALNOMBRE = "CD ALERCE"

                CON_OBSERVACION = "-"
                CON_CODIGOUNICO = DATOS(29)
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False
                CON_FECHAEMISION = DATOS(22)

                CON_NOMBRECLIENTE = DATOS(27)
                CON_RUTCLIENTE = DATOS(28)
                CON_COMUNARECEPTOR = DATOS(32)
                CON_DIRECCIONCLIENTE = DATOS(30)
                CON_TELEFONOCLIENTE = DATOS(38)
                CON_EMAILCLIENTE = "-"
                CON_LOCALIDAD = DATOS(31)
                CON_FECHAENTREGACLIENTE = DATOS(34)

            ElseIf DATOS.Length = 31 Then


                CON_OCNUMERO = DATOS(5)

                If CON_OCNUMERO = 5387509 Then
                    CON_OCNUMERO = CON_OCNUMERO
                End If

                CON_SKUCLIENTE = DATOS(14)
                CON_SKUDESCRIPCION = DATOS(16)
                CON_CANTIDAD = DATOS(19).ToString()
                CON_PRECIOCOSTO = DATOS(18).ToString()
                CON_FECHADESPACHO = DATOS(29)
                CON_DESPACHARANUMERO = DATOS(8)
                CON_DESPACHARA = "CD ALERCE" 'DATOS(8)
                CON_LOCAL = "-"
                CON_LOCALNOMBRE = "CD ALERCE" '"-"
                CON_NOMBRECLIENTE = "-"
                CON_RUTCLIENTE = "-"
                CON_OBSERVACION = "-"
                CON_CODIGOUNICO = "-"
                CON_ESAGENDABLE = True
                CON_ESABIERTA = True
                CON_FECHAEMISION = DATOS(27)
                CON_SUCURSALENTREGA = DATOS(11)
            End If

            CON_NOMBREARCHIVO = rutaArchivo


            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO

                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.fecha_emision = CON_FECHAEMISION
                classOrdenes.con_telefonocliente = CON_TELEFONOCLIENTE
                classOrdenes.con_emailcliente = CON_EMAILCLIENTE
                classOrdenes.con_direccioncliente = CON_DIRECCIONCLIENTE
                classOrdenes.con_localidad = CON_LOCALIDAD
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosCorona(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)

        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = "-"
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"

            CAR_CODIGO = CLIENTES.CORONA
            CON_OCNUMERO = DATOS(0)
            CON_SKUCLIENTE = DATOS(17)
            CON_SKUDESCRIPCION = DATOS(14)
            CON_CANTIDAD = DATOS(18).ToString()
            CON_PRECIOCOSTO = DATOS(19).ToString()
            CON_FECHADESPACHO = DATOS(6)
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = "CENTRO DE DISTIBUCIÓN LA MONTANA" 'DATOS(7)
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "CENTRO DE DISTIBUCIÓN LA MONTANA"
            CON_NOMBRECLIENTE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = DATOS(10)
            CON_CODIGOUNICO = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"


            If DATOS(2) = "RA" Then
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False
            Else
                CON_ESAGENDABLE = True
                CON_ESABIERTA = True
            End If

            CON_NOMBREARCHIVO = rutaArchivo
            CON_FECHAEMISION = DATOS(4)

            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO

                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.fecha_emision = CON_FECHAEMISION
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub
    Private Sub CargaDatosRipley(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Dim codVerificador As Integer = 0
        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = ""
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"

            CON_CODLINEA = "-"
            CON_NOMBRELINEA = "-"
            CON_CODSUCURSALENTREGA = "-"
            CON_CODIGOEAN13 = "-"
            CON_CODAUXILIAR = "-"
            CON_CONLPN = "-"
            CON_PRECIOLISTA = 0
            CON_REGIONNOMBRE = ""
            CON_DIRECCIONCLIENTE = ""
            CON_FECHAENTREGACLIENTE = "01-01-1900"

            CAR_CODIGO = CLIENTES.RIPLEY
            If DATOS.Length = 49 Then
                'If DATOS(33).ToString = "8957258" Then
                '    CON_CONLPN = "-"
                'End If

                CON_OCNUMERO = DATOS(33)
                CON_SKUCLIENTE = DATOS(35)
                'CON_SKUDESCRIPCION = "[*] " + DATOS(38)
                CON_SKUDESCRIPCION = DATOS(38)
                CON_CANTIDAD = DATOS(44).ToString()
                CON_PRECIOCOSTO = DATOS(45).ToString()
                CON_FECHADESPACHO = DATOS(13)
                'CON_DESPACHARANUMERO = DATOS(29)
                'CON_DESPACHARA = DATOS(30)

                CON_DESPACHARANUMERO = DATOS(18)
                'If UCase(DATOS(19).ToString()) <> "SANTIAGO" Then
                '    CON_DESPACHARA = "PULLMAN"
                'Else
                '    CON_DESPACHARA = UCase(DATOS(19).ToString())
                'End If
                CON_DESPACHARA = DATOS(28)
                CON_LOCAL = DATOS(27)
                CON_LOCALNOMBRE = DATOS(28)
                CON_RUTCLIENTE = DATOS(14)
                CON_NOMBRECLIENTE = DATOS(15)
                CON_OBSERVACION = "-"
                CON_CODIGOUNICO = DATOS(42) ' DATOS(1)
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False

                CON_FECHAVENTA = Mid(Trim(DATOS(5)), 1, 10)
                CON_NUMBOLETA = DATOS(1)

                CON_GLOSADEPTO = DATOS(32)
                CON_CODIGODEPTO = DATOS(31)

                CON_SUCURSALENTREGA = DATOS(3)

                CON_FECHAENTREGA = "01-01-1900" 'Mid(Trim(DATOS(12)), 14, 10) 'DATOS(13)

                'codVerificador = classOrdenes.GetDCBarCodEAN13("2000" + DATOS(35).ToString)

                CON_CODIGOEAN13 = classOrdenes.ean13("2000" + Trim(DATOS(35).ToString))

                CON_CONLPN = DATOS(47)
                CON_REGIONNOMBRE = DATOS(17)
                CON_DIRECCIONCLIENTE = DATOS(22)
                CON_FECHAEMISION = DATOS(5)
                CON_COMUNARECEPTOR = DATOS(21)
                CON_DIRECCIONCLIENTE = DATOS(22)
                CON_TELEFONOCLIENTE = DATOS(23)
                CON_EMAILCLIENTE = DATOS(24)

            ElseIf DATOS.Length = 48 Then
                CON_OCNUMERO = DATOS(34)

                If CON_OCNUMERO = 9433819 Then
                    CON_OCNUMERO = CON_OCNUMERO
                End If

                CON_SKUCLIENTE = DATOS(36)
                CON_SKUDESCRIPCION = DATOS(39)
                CON_CANTIDAD = DATOS(45).ToString()
                CON_PRECIOCOSTO = DATOS(46).ToString()
                CON_FECHADESPACHO = DATOS(13)
                CON_DESPACHARANUMERO = DATOS(19)

                CON_DESPACHARA = DATOS(29)

                'If UCase(DATOS(20).ToString()) <> "SANTIAGO" Then
                '    CON_DESPACHARA = "PULLMAN"
                'Else
                '    CON_DESPACHARA = UCase(DATOS(20).ToString())
                'End If

                CON_LOCAL = DATOS(28)
                CON_LOCALNOMBRE = DATOS(29)

                CON_RUTCLIENTE = DATOS(15)
                CON_NOMBRECLIENTE = DATOS(16)
                CON_OBSERVACION = "-"
                CON_CODIGOUNICO = DATOS(43)
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False

                CON_FECHAVENTA = Mid(Trim(DATOS(5)), 1, 10)
                CON_NUMBOLETA = DATOS(1)

                CON_GLOSADEPTO = DATOS(33)
                CON_CODIGODEPTO = DATOS(32)

                CON_SUCURSALENTREGA = DATOS(3)

                CON_FECHAENTREGA = "01-01-1900" 'Mid(Trim(DATOS(12)), 14, 10) 'DATOS(13)

                'codVerificador = classOrdenes.GetDCBarCodEAN13("2000" + DATOS(35).ToString)
                CON_CODIGOEAN13 = classOrdenes.ean13("2000" + Trim(DATOS(36).ToString))

                CON_CONLPN = "-" 'DATOS(47)
                CON_REGIONNOMBRE = DATOS(18)
                CON_DIRECCIONCLIENTE = DATOS(23)
                CON_FECHAEMISION = DATOS(5)
                CON_COMUNARECEPTOR = DATOS(22)
                CON_DIRECCIONCLIENTE = DATOS(23)
                CON_TELEFONOCLIENTE = DATOS(24)
                CON_EMAILCLIENTE = DATOS(25)

            ElseIf DATOS.Length = 37 Then
                CON_OCNUMERO = DATOS(2)
                CON_SKUCLIENTE = DATOS(22)
                CON_SKUDESCRIPCION = DATOS(27)
                CON_CANTIDAD = DATOS(29).ToString()
                CON_PRECIOCOSTO = DATOS(30).ToString()

                CON_FECHADESPACHO = Mid(Trim(DATOS(16)), 1, 10) 'DATOS(16)

                CON_LOCAL = DATOS(11)
                CON_LOCALNOMBRE = DATOS(12)

                CON_DESPACHARANUMERO = DATOS(11)
                CON_DESPACHARA = DATOS(12)

                CON_CODSUCURSALENTREGA = DATOS(13)
                CON_SUCURSALENTREGA = DATOS(14)

                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(Trim(DATOS(23).ToString), 1, 12))

                CON_CODAUXILIAR = "-" 'DATOS(21)

                CON_CODIGODEPTO = DATOS(7)
                CON_GLOSADEPTO = DATOS(8)

                CON_CODLINEA = DATOS(9)
                CON_NOMBRELINEA = DATOS(10)

                CON_ESAGENDABLE = True
                CON_ESABIERTA = False

                CON_CONLPN = "5469" + Trim(DATOS(13).ToString())

                CON_PRECIOLISTA = DATOS(32)

                CON_FECHAEMISION = DATOS(15)


            End If
            CON_NOMBREARCHIVO = rutaArchivo


            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD.ToString()
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO.ToString()
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO

                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_GLOSADEPTO
                classOrdenes.con_codigodepto = CON_CODIGODEPTO
                classOrdenes.con_codigoEAN13 = CON_CODIGOEAN13

                classOrdenes.con_codlinea = CON_CODLINEA
                classOrdenes.con_nombrelinea = CON_NOMBRELINEA
                classOrdenes.con_codsucursalentrega = CON_CODSUCURSALENTREGA
                classOrdenes.con_codigoaux = CON_CODAUXILIAR
                classOrdenes.con_lpn = CON_CONLPN
                classOrdenes.con_preciolista = CON_PRECIOLISTA
                classOrdenes.con_regionnombre = CON_REGIONNOMBRE
                classOrdenes.con_direccioncliente = CON_DIRECCIONCLIENTE
                classOrdenes.fecha_emision = CON_FECHAEMISION
                classOrdenes.con_telefonocliente = CON_TELEFONOCLIENTE
                classOrdenes.con_emailcliente = CON_EMAILCLIENTE
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then

                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosParis(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Dim OCNUM As String = ""
        Dim MiP As String = ""
        Dim Posicion As Integer = 0
        Dim Precio As String = "0"
        Dim ValidaDecimales As Integer = 0
        Dim CON_CODIGODEPTO As String = "-"
        Dim CON_NOMBRELINEA As String = "-"
        Dim CON_TIPOFLUJO As String = "-"


        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = ""
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"

            CAR_CODIGO = CLIENTES.PARIS
            If DATOS.Length = 39 Then
                OCNUM = DATOS(0)
                MiP = Strings.Replace(OCNUM, Chr(34), "")
                MiP = Strings.Replace(MiP, Chr(148), "")

                CON_OCNUMERO = CLng(MiP) ' DATOS(0)
                CON_COMUNARECEPTOR = DATOS(2)

                'CON_OCNUMERO = DATOS(0)
                CON_SKUCLIENTE = DATOS(15)
                CON_SKUDESCRIPCION = DATOS(19)
                CON_CANTIDAD = DATOS(29).ToString()

                'Posicion = DATOS(28).ToString().IndexOf(".")
                'Precio = Mid(DATOS(28).ToString(), 1, Posicion)

                Posicion = 0
                Posicion = DATOS(28).ToString().IndexOf(".")
                Posicion = Posicion + 2

                ValidaDecimales = Mid(DATOS(28).ToString(), Posicion, DATOS(28).ToString().Length).Length

                If ValidaDecimales = 2 Then
                    Precio = Mid(DATOS(28).ToString(), 1, Posicion - 2)
                Else
                    Precio = DATOS(28).ToString()
                End If


                CON_PRECIOCOSTO = Precio.ToString
                CON_FECHADESPACHO = DATOS(12)
                CON_DESPACHARANUMERO = DATOS(8)
                CON_DESPACHARA = DATOS(9)
                CON_LOCAL = DATOS(10)
                CON_LOCALNOMBRE = DATOS(11)
                CON_RUTCLIENTE = "-"
                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = "-"
                CON_CODIGOUNICO = DATOS(1)
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False


                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(Trim(DATOS(17).ToString), 1, 12))
                CON_FECHAEMISION = DATOS(14)

                CON_CODIGODEPTO = DATOS(4)
                CON_NOMBRELINEA = DATOS(5)
                CON_TIPOFLUJO = DATOS(18)


                '**********************************************
                'Dim codigoPrueba As String = "2035397799907"
                'CON_CODIGOEAN13 = classOrdenes.ean13(Mid(codigoPrueba, 1, 12))
                '**********************************************

                'ElseIf DATOS.Length = 38 Then
                '    OCNUM = DATOS(0)
                '    MiP = Strings.Replace(OCNUM, Chr(34), "")
                '    MiP = Strings.Replace(MiP, Chr(148), "")

                '    CON_OCNUMERO = CLng(MiP)

                '    CON_SKUCLIENTE = DATOS(15)
                '    CON_SKUDESCRIPCION = DATOS(19)
                '    CON_CANTIDAD = DATOS(29).ToString()
                '    CON_PRECIOCOSTO = DATOS(28).ToString()
                '    CON_FECHADESPACHO = DATOS(12)
                '    CON_DESPACHARANUMERO = DATOS(8)
                '    CON_DESPACHARA = DATOS(9)
                '    CON_LOCAL = DATOS(10)
                '    CON_LOCALNOMBRE = DATOS(11)
                '    CON_RUTCLIENTE = "-"
                '    CON_NOMBRECLIENTE = "-"
                '    CON_OBSERVACION = "-"
                '    CON_CODIGOUNICO = DATOS(1)
                '    CON_ESAGENDABLE = False
                '    CON_ESABIERTA = False
            ElseIf DATOS.Length = 37 Then
                OCNUM = DATOS(0)
                MiP = Strings.Replace(OCNUM, Chr(34), "")
                MiP = Strings.Replace(MiP, Chr(148), "")

                CON_OCNUMERO = CLng(MiP) ' DATOS(0)

                'CON_OCNUMERO = DATOS(0)
                CON_SKUCLIENTE = DATOS(13)
                CON_SKUDESCRIPCION = DATOS(17)
                CON_CANTIDAD = DATOS(27).ToString()

                Posicion = 0
                Posicion = DATOS(26).ToString().IndexOf(".")
                Posicion = Posicion + 2

                ValidaDecimales = Mid(DATOS(26).ToString(), Posicion, DATOS(26).ToString().Length).Length

                If ValidaDecimales = 2 Then
                    Precio = Mid(DATOS(26).ToString(), 1, Posicion - 2)
                Else
                    Precio = DATOS(26).ToString()
                End If



                CON_PRECIOCOSTO = Precio.ToString 'DATOS(26).ToString()
                CON_FECHADESPACHO = DATOS(11)
                CON_DESPACHARANUMERO = DATOS(6)
                CON_DESPACHARA = DATOS(7)
                CON_LOCAL = DATOS(8)
                CON_LOCALNOMBRE = DATOS(9)
                CON_RUTCLIENTE = "-"
                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = "-"

                CON_CODIGOUNICO = 0
                CON_ESAGENDABLE = True
                CON_ESABIERTA = True


                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(Trim(DATOS(15).ToString), 1, 12))
                CON_FECHAEMISION = DATOS(12)

            End If
            CON_NOMBREARCHIVO = rutaArchivo


            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                CON_DESPACHARA = "CENTRO DISTRIBUCION RENCA"

                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD.ToString()
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO.ToString()
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO

                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.con_codigoEAN13 = CON_CODIGOEAN13
                classOrdenes.fecha_emision = CON_FECHAEMISION
                classOrdenes.con_codigodepto = CON_CODIGODEPTO
                classOrdenes.con_nombrelinea = CON_NOMBRELINEA
                classOrdenes.con_tipoflujo = CON_TIPOFLUJO
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE


                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosEasy(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Dim OCNUM As String = ""
        Dim MiP As String = ""
        Dim VarEAN13 As String = ""
        Dim MiEAN13 As String = ""
        Dim Precio As String = ""

        Dim CON_LOCALDESTINOEASY As String = ""

        Try

            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = "-"
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"
            CON_CODIGOEAN13 = "-"
            CON_SUB_ORDEN = "-"

            CON_DIRECCIONCLIENTE = "-"
            CON_TELEFONOCLIENTE = "-"
            CON_EMAILCLIENTE = "-"
            CON_UNIDADES_X_EMPAUQE = 0
            CON_NUMERO_ENTREGA = "000000"
            CON_FECHAENTREGACLIENTE = "01-01-1900"


            CAR_CODIGO = CLIENTES.EASY

            If (DATOS.Length = 45) Or DATOS.Length = 44 Then
                OCNUM = DATOS(0)
                If OCNUM = "6504516979" Then
                    OCNUM = OCNUM
                End If

                VarEAN13 = DATOS(25)

                'MiP = Strings.Replace(OCNUM, Chr(147), "")

                MiP = Strings.Replace(OCNUM, Chr(34), "")
                MiP = Strings.Replace(MiP, Chr(148), "")

                MiEAN13 = Strings.Replace(VarEAN13, Chr(34), "")
                MiEAN13 = Strings.Replace(MiEAN13, Chr(148), "")

                If MiEAN13.ToString.Length = 13 Then
                    MiEAN13 = MiEAN13
                Else
                    MiEAN13 = Double.Parse(MiEAN13)
                End If


                CON_OCNUMERO = CLng(MiP) ' DATOS(0)

                'If (CON_OCNUMERO = 6503271030) Then
                '    CON_OCNUMERO = CON_OCNUMERO
                'End If


                CON_SKUCLIENTE = DATOS(23)
                CON_SKUDESCRIPCION = DATOS(27)


                'CON_PRECIOCOSTO = DATOS(31).ToString() 'DATOS(41).ToString()
                'Precio = Strings.Replace(CON_PRECIOCOSTO, Chr(34), "")
                'Precio = Strings.Replace(Precio, Chr(148), "")

                'CON_UNIDADES_X_EMPAUQE = DATOS(29).ToString()
                'CON_CANTIDAD = DATOS(30).ToString()

                CON_UNIDADES_X_EMPAUQE = CInt(Strings.Replace(Strings.Replace(DATOS(29), Chr(34), ""), ".", ",")) 'DATOS(21).ToString()
                CON_CANTIDAD = CInt(Strings.Replace(Strings.Replace(DATOS(30), Chr(34), ""), ".", ",")) 'DATOS(22).ToString()
                CON_PRECIOCOSTO = CLng(Strings.Replace(Strings.Replace(DATOS(41), Chr(34), ""), ".", ",")) 'DATOS(23).ToString()

                CON_PRECIOCOSTO = ((CON_PRECIOCOSTO * CON_CANTIDAD) / (CON_UNIDADES_X_EMPAUQE * CON_CANTIDAD))
                CON_CANTIDAD = CLng(CON_CANTIDAD) * CLng(CON_UNIDADES_X_EMPAUQE)

                'Precio = Strings.Replace(DATOS(31).ToString(), Chr(34), "")
                'If (Strings.Replace(CON_SKUCLIENTE, Chr(34), "") = "1112267" Or Strings.Replace(CON_SKUCLIENTE, Chr(34), "") = "1215869") Then
                '    CON_CANTIDAD = (CInt(Strings.Replace(Strings.Replace(DATOS(30), Chr(34), ""), ".", ",")) * 10).ToString
                '    CON_PRECIOCOSTO = (CLng(Strings.Replace(Precio, ".", ",")) / 10)
                'Else
                '    CON_CANTIDAD = DATOS(30).ToString()
                '    CON_PRECIOCOSTO = Precio
                'End If



                CON_FECHADESPACHO = DATOS(7)
                CON_DESPACHARANUMERO = DATOS(9)
                CON_DESPACHARA = DATOS(10)
                CON_LOCAL = DATOS(12)
                CON_LOCALNOMBRE = DATOS(13)

                CON_OBSERVACION = "-"
                CON_CODIGOUNICO = "-"
                'MiEAN13 = "0400005651116"
                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(MiEAN13, 1, (MiEAN13.Length - 1)))

                CON_RUTCLIENTE = DATOS(18)
                CON_NOMBRECLIENTE = DATOS(17)
                CON_DIRECCIONCLIENTE = DATOS(21)
                CON_TELEFONOCLIENTE = DATOS(22)
                CON_EMAILCLIENTE = "-"

                If CON_RUTCLIENTE = "" Then
                    CON_RUTCLIENTE = "-"
                End If

                If CON_NOMBRECLIENTE = "" Then
                    CON_NOMBRECLIENTE = "-"
                End If

                CON_COMUNARECEPTOR = DATOS(20)

                If (DATOS(8) = Chr(34) + "A pedido" + Chr(34)) Or (DATOS(8) = "A pedido") Or (DATOS(8) = Chr(34) + "A Pedido Web" + Chr(34)) Or (DATOS(8) = "A Pedido Web" Or (DATOS(8) = Chr(34) + "A Pedido Web Postventa" + Chr(34)) Or (DATOS(8) = "A Pedido Web Postventa")) Then
                    CON_ESAGENDABLE = False
                    CON_ESABIERTA = False
                Else
                    CON_ESAGENDABLE = True
                    CON_ESABIERTA = False
                End If

                CON_NOMBREARCHIVO = rutaArchivo

                If DATOS(15).ToString() = "" Then
                    CON_SUB_ORDEN = 0
                Else
                    CON_SUB_ORDEN = DATOS(15)
                End If
                CON_FECHAEMISION = DATOS(6)
                If (DATOS.Length = 45) Then
                    CON_NUMERO_ENTREGA = DATOS(44)
                Else
                    CON_NUMERO_ENTREGA = "000000"
                End If


            Else
                OCNUM = DATOS(0)
                VarEAN13 = DATOS(17)

                'MiP = Strings.Replace(OCNUM, Chr(147), "")

                MiP = Strings.Replace(OCNUM, Chr(34), "")
                MiP = Strings.Replace(MiP, Chr(148), "")

                MiEAN13 = Strings.Replace(VarEAN13, Chr(34), "")
                MiEAN13 = Strings.Replace(MiEAN13, Chr(148), "")

                If MiEAN13.ToString.Length = 13 Then
                    MiEAN13 = MiEAN13
                Else
                    MiEAN13 = Double.Parse(MiEAN13)
                End If


                CON_OCNUMERO = CLng(MiP) ' DATOS(0)

                'If (CON_OCNUMERO = 6503271030) Then
                '    CON_OCNUMERO = CON_OCNUMERO
                'End If


                CON_SKUCLIENTE = DATOS(15)
                CON_SKUDESCRIPCION = DATOS(19)


                CON_UNIDADES_X_EMPAUQE = CInt(Strings.Replace(Strings.Replace(DATOS(21), Chr(34), ""), ".", ",")) 'DATOS(21).ToString()
                CON_CANTIDAD = CInt(Strings.Replace(Strings.Replace(DATOS(22), Chr(34), ""), ".", ",")) 'DATOS(22).ToString()
                CON_PRECIOCOSTO = CLng(Strings.Replace(Strings.Replace(DATOS(23), Chr(34), ""), ".", ",")) 'DATOS(23).ToString()


                CON_PRECIOCOSTO = ((CON_PRECIOCOSTO * CON_CANTIDAD) / (CON_UNIDADES_X_EMPAUQE * CON_CANTIDAD))
                CON_CANTIDAD = CLng(CON_CANTIDAD) * CLng(CON_UNIDADES_X_EMPAUQE)


                'CON_PRECIOCOSTO = DATOS(23).ToString()
                'Precio = Strings.Replace(CON_PRECIOCOSTO, Chr(34), "")
                'Precio = Strings.Replace(Precio, Chr(148), "")
                'CON_PRECIOCOSTO = Precio

                'If (Strings.Replace(CON_SKUCLIENTE, Chr(34), "") = "1112267" Or Strings.Replace(CON_SKUCLIENTE, Chr(34), "") = "1215869") Then
                '    CON_CANTIDAD = (CInt(Strings.Replace(Strings.Replace(DATOS(22), Chr(34), ""), ".", ",")) * 10).ToString
                '    CON_PRECIOCOSTO = (CLng(Strings.Replace(Precio, ".", ",")) / 10)
                'Else
                '    CON_CANTIDAD = DATOS(22).ToString()
                '    CON_PRECIOCOSTO = Precio
                'End If


                CON_FECHADESPACHO = DATOS(7)
                CON_DESPACHARANUMERO = DATOS(9)
                CON_DESPACHARA = DATOS(10)
                CON_LOCAL = DATOS(12)
                CON_LOCALNOMBRE = DATOS(13)
                CON_NOMBRECLIENTE = "-"
                CON_RUTCLIENTE = "-"
                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = "-"
                CON_CODIGOUNICO = "-"
                CON_CODIGOEAN13 = classOrdenes.ean13(Mid(MiEAN13, 1, (MiEAN13.Length - 1)))

                'If (DATOS(8) = Chr(34) + "A pedido" + Chr(34)) Or (DATOS(8) = "A pedido") Then
                If (DATOS(8) = Chr(34) + "A pedido" + Chr(34)) Or (DATOS(8) = "A pedido") Or (DATOS(8) = Chr(34) + "A Pedido Web" + Chr(34)) Or (DATOS(8) = "A Pedido Web" Or (DATOS(8) = Chr(34) + "A Pedido Web Postventa" + Chr(34)) Or (DATOS(8) = "A Pedido Web Postventa")) Then
                    CON_ESAGENDABLE = False
                    CON_ESABIERTA = False
                Else
                    CON_ESAGENDABLE = True
                    CON_ESABIERTA = False
                End If

                CON_NOMBREARCHIVO = rutaArchivo
                CON_SUB_ORDEN = 0
                CON_FECHAEMISION = DATOS(6)

                CON_LOCALDESTINOEASY = DATOS(13)

                'If DATOS(15).ToString() = "" Then
                '    CON_SUB_ORDEN = 0
                'Else
                '    CON_SUB_ORDEN = DATOS(15)
                'End If

            End If

            'If CON_ESAGENDABLE = True Then
            '    If (Strings.Replace(CON_SKUCLIENTE, Chr(34), "") = "1166904") Or
            '       (Strings.Replace(CON_SKUCLIENTE, Chr(34), "") = "1166906") Or
            '       (Strings.Replace(CON_SKUCLIENTE, Chr(34), "") = "1166907") Or
            '       (Strings.Replace(CON_SKUCLIENTE, Chr(34), "") = "1219573") Then

            '        CON_CANTIDAD = CON_CANTIDAD * 3
            '        CON_PRECIOCOSTO = (CLng(Strings.Replace(Precio, ".", ",")) / CON_CANTIDAD)
            '    End If
            'End If



            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                CON_DESPACHARA = "DEPOSITO CENTRAL EASY PYP"
                CON_LOCALNOMBRE = "DEPOSITO CENTRAL EASY PYP"

                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO

                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.con_codigoEAN13 = CON_CODIGOEAN13
                classOrdenes.con_suborden = CON_SUB_ORDEN
                classOrdenes.fecha_emision = CON_FECHAEMISION
                classOrdenes.con_telefonocliente = CON_TELEFONOCLIENTE
                classOrdenes.con_emailcliente = CON_EMAILCLIENTE
                classOrdenes.con_direccioncliente = CON_DIRECCIONCLIENTE
                classOrdenes.con_numero_entrega = CON_NUMERO_ENTREGA
                classOrdenes.con_localentregaeasy = CON_LOCALDESTINOEASY
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosHites(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = "-"
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"

            CON_TEMPORADA = "-"
            CON_TALLA = "-"
            CON_COLOR = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"

            CAR_CODIGO = CLIENTES.HITES
            If DATOS.Length = 23 Then
                If DATOS(0).Length < 8 Then
                    'If (DATOS(10) <> "708334001" And DATOS(10) <> "733935001" And DATOS(10) <> "697784001") Then
                    CON_OCNUMERO = CLng(DATOS(0))
                    CON_SKUCLIENTE = DATOS(8)
                    CON_SKUDESCRIPCION = DATOS(15)
                    CON_CANTIDAD = DATOS(18).ToString()
                    CON_PRECIOCOSTO = DATOS(22).ToString()
                    CON_FECHADESPACHO = Mid(Trim(DATOS(12)), 15, 10)
                    CON_DESPACHARANUMERO = DATOS(3)
                    CON_DESPACHARA = DATOS(4)
                    CON_LOCAL = DATOS(5)
                    CON_LOCALNOMBRE = DATOS(6)
                    CON_RUTCLIENTE = "-"
                    CON_NOMBRECLIENTE = "-"
                    CON_OBSERVACION = "-"
                    CON_CODIGOUNICO = "-"
                    CON_ESAGENDABLE = True
                    CON_ESABIERTA = True
                    CON_NOMBREARCHIVO = rutaArchivo

                    CON_SUCURSALENTREGA = DATOS(3)
                    CON_FECHAVENTA = DATOS(11)
                    CON_FECHAENTREGA = Mid(Trim(DATOS(12)), 14, 10) 'DATOS(13)
                    CON_GLOSADEPTO = DATOS(14)

                    CON_TEMPORADA = DATOS(13)
                    CON_TALLA = DATOS(16)
                    CON_COLOR = DATOS(17)
                    CON_FECHAEMISION = DATOS(11)

                    'End If
                End If
            ElseIf DATOS.Length >= 31 Then 'Datos enviados por correo
                'If (DATOS(10) <> "708334001" And DATOS(10) <> "733935001" And DATOS(10) <> "697784001") Then
                CON_OCNUMERO = DATOS(27)
                CON_SKUCLIENTE = DATOS(10)
                CON_SKUDESCRIPCION = DATOS(12)
                CON_CANTIDAD = DATOS(13).ToString()
                CON_PRECIOCOSTO = DATOS(28).ToString()
                CON_FECHADESPACHO = DATOS(6)
                CON_DESPACHARANUMERO = DATOS(16)
                'CON_DESPACHARA = DATOS(17)

                If DATOS(17).ToString <> "INTERNET" Then
                    CON_DESPACHARA = "B.SAN FRANCISCO N2"
                Else
                    CON_DESPACHARA = DATOS(17)
                End If

                CON_LOCAL = DATOS(1)
                CON_LOCALNOMBRE = DATOS(2)
                CON_OBSERVACION = DATOS(25)
                CON_CODIGOUNICO = DATOS(3)
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False
                CON_NOMBREARCHIVO = rutaArchivo

                CON_CODSUCURSALENTREGA = DATOS(16)

                If DATOS(17).ToString <> "INTERNET" Then
                    CON_CODSUCURSALENTREGA = "B.SAN FRANCISCO N2"
                Else
                    CON_CODSUCURSALENTREGA = DATOS(17)
                End If

                'CON_SUCURSALENTREGA = DATOS(17)

                CON_FECHAVENTA = DATOS(0)
                CON_NUMBOLETA = DATOS(3)
                CON_FECHAENTREGA = DATOS(6)
                CON_NUMCAJA = DATOS(4)
                CON_CODIGODEPTO = DATOS(7)
                CON_GLOSADEPTO = DATOS(8)
                CON_CODIGOEAN13 = classOrdenes.ean13((Mid(DATOS(11).ToString(), 1, 12)))
                CON_FECHAEMISION = DATOS(0)

                CON_NOMBRECLIENTE = DATOS(19)
                CON_RUTCLIENTE = DATOS(18)
                CON_COMUNARECEPTOR = DATOS(22)
                CON_DIRECCIONCLIENTE = DATOS(20)
                CON_TELEFONOCLIENTE = DATOS(23)
                CON_EMAILCLIENTE = "-"

                'End If
            End If

            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO

                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_codsucursalentrega = CON_CODSUCURSALENTREGA

                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_GLOSADEPTO
                classOrdenes.con_codigodepto = CON_CODIGODEPTO
                classOrdenes.con_codigoEAN13 = CON_CODIGOEAN13

                classOrdenes.con_temporada = CON_TEMPORADA
                classOrdenes.con_talla = CON_TALLA
                classOrdenes.con_color = CON_COLOR
                classOrdenes.fecha_emision = CON_FECHAEMISION
                classOrdenes.con_telefonocliente = CON_TELEFONOCLIENTE
                classOrdenes.con_emailcliente = CON_EMAILCLIENTE
                classOrdenes.con_direccioncliente = CON_DIRECCIONCLIENTE
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE


                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If

            End If
        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub CargaDatosFalabella(ByVal DATOS As String(), ByVal rutaArchivo As String, ByRef msgError As String, ByRef FilaIdentificada As String)
        Dim classOrdenes As class_carga_masiva_b2b = New class_carga_masiva_b2b
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim caracter As String = Chr(34)
        Try
            CON_OCNUMERO = 0
            CON_SKUCLIENTE = "-"
            CON_SKUDESCRIPCION = "-"
            CON_CANTIDAD = "0"
            CON_PRECIOCOSTO = "0"
            CON_FECHADESPACHO = "01-01-1900"
            CON_DESPACHARANUMERO = "-"
            CON_DESPACHARA = ""
            CON_LOCAL = "-"
            CON_LOCALNOMBRE = "-"
            CON_RUTCLIENTE = "-"
            CON_NOMBRECLIENTE = "-"
            CON_OBSERVACION = "-"
            CON_CODIGOUNICO = "-"
            CON_ESAGENDABLE = False
            CON_ESABIERTA = False
            CON_NOMBREARCHIVO = "-"

            CON_COMUNARECEPTOR = "-"
            CON_CIUDADRECEPTOR = "-"

            CON_SUCURSALENTREGA = "-"
            CON_FECHAVENTA = "01-01-1900"
            CON_NUMBOLETA = 0
            CON_FECHAENTREGA = "01-01-1900"
            CON_NUMCAJA = 0
            CON_GLOSADEPTO = "-"
            CON_CODIGODEPTO = "-"

            CON_DIRECCIONCLIENTE = "-"
            CON_TELEFONOCLIENTE = "-"
            CON_EMAILCLIENTE = "-"
            CON_FECHAENTREGACLIENTE = "01-01-1900"

            CAR_CODIGO = CLIENTES.FALABELLA
            If DATOS.Length = 38 Then
                CON_OCNUMERO = DATOS(1)

                CON_SKUCLIENTE = DATOS(18)
                CON_SKUDESCRIPCION = DATOS(19)
                CON_CANTIDAD = DATOS(20).ToString()
                CON_PRECIOCOSTO = DATOS(21).ToString()
                CON_FECHADESPACHO = DATOS(3)
                CON_DESPACHARANUMERO = "0"
                CON_DESPACHARA = "CT HUB-CROSS DOCK MUEBLES" 'DATOS(15)
                CON_LOCAL = IIf(DATOS(13).ToString = "", "-", DATOS(13))
                CON_LOCALNOMBRE = IIf(DATOS(14).ToString = "", "-", DATOS(14))
                CON_RUTCLIENTE = "-"
                CON_NOMBRECLIENTE = "-"
                CON_OBSERVACION = DATOS(16)
                CON_CODIGOUNICO = DATOS(0)
                CON_ESAGENDABLE = False
                CON_ESABIERTA = False
                CON_COMUNARECEPTOR = DATOS(8)
                CON_CIUDADRECEPTOR = DATOS(9)
                CON_FECHAEMISION = DATOS(2)

                CON_DIRECCIONCLIENTE = "-"
                CON_TELEFONOCLIENTE = "-"
                CON_EMAILCLIENTE = "-"


            End If
            CON_NOMBREARCHIVO = rutaArchivo

            classOrdenes.cnn = _cnn
            If CON_OCNUMERO > 0 Then
                classOrdenes.car_codigo = CAR_CODIGO
                classOrdenes.con_ocnumero = CON_OCNUMERO
                classOrdenes.con_skucliente = CON_SKUCLIENTE
                classOrdenes.con_skudescripcion = CON_SKUDESCRIPCION
                classOrdenes.con_cantidad = CON_CANTIDAD
                classOrdenes.con_preciocosto = CON_PRECIOCOSTO
                classOrdenes.con_fechadespacho = CON_FECHADESPACHO
                classOrdenes.con_despacharanumero = CON_DESPACHARANUMERO
                classOrdenes.con_despachara = CON_DESPACHARA
                classOrdenes.con_local = CON_LOCAL
                classOrdenes.con_localnombre = CON_LOCALNOMBRE
                classOrdenes.rut_cliente = CON_RUTCLIENTE
                classOrdenes.nombre_cliente = CON_NOMBRECLIENTE
                classOrdenes.con_observacion = IIf(CON_OBSERVACION = "", "-", CON_OBSERVACION)
                classOrdenes.con_codigounico = CON_CODIGOUNICO
                classOrdenes.es_agendable = CON_ESAGENDABLE
                classOrdenes.es_abierta = CON_ESABIERTA
                classOrdenes.con_nombrearchivo = CON_NOMBREARCHIVO
                classOrdenes.tipo = CON_TIPO
                classOrdenes.con_comunareceptor = CON_COMUNARECEPTOR
                classOrdenes.con_ciudadreceptor = CON_CIUDADRECEPTOR

                classOrdenes.con_sucursalentrega = CON_SUCURSALENTREGA
                classOrdenes.con_fechaventa = CON_FECHAVENTA
                classOrdenes.con_numboleta = CON_NUMBOLETA
                classOrdenes.con_fechaentrega = CON_FECHAENTREGA
                classOrdenes.con_numcaja = CON_NUMCAJA
                classOrdenes.con_glosadepto = CON_CODIGODEPTO
                classOrdenes.con_codigodepto = CON_GLOSADEPTO
                classOrdenes.fecha_emision = CON_FECHAEMISION

                classOrdenes.con_telefonocliente = CON_TELEFONOCLIENTE
                classOrdenes.con_emailcliente = CON_EMAILCLIENTE
                classOrdenes.con_direccioncliente = CON_DIRECCIONCLIENTE
                classOrdenes.con_fechaentregacliente = CON_FECHAENTREGACLIENTE

                ds = classOrdenes.INGRESA_REPOSITORIO(_msgError)
                If ds.Tables(0).Rows.Count > 0 Then
                    If _msgError = "" Then
                        If ds.Tables(0).Rows(0)("CODIGO") = 2 Then
                            _CantidadIngreso = _CantidadIngreso + 1
                        ElseIf ds.Tables(0).Rows(0)("CODIGO") = 1 Then
                            _CantidadActualizacion = _CantidadActualizacion + 1
                        End If
                    Else
                        msgError = _msgError
                        FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
            msgError = ex.Message
            FilaIdentificada = "Error en el archivo: " + CON_NOMBREARCHIVO + ", orden de compra: " + CON_OCNUMERO.ToString
        End Try
    End Sub

    Private Sub ButtonSelecciona_Click(sender As Object, e As EventArgs) Handles ButtonSelecciona.Click
        Call MARCAR_TODOS()
    End Sub
    Private Sub MARCAR_TODOS()
        For Each row As DataGridViewRow In Me.Grilla.Rows
            row.Cells(0).Value = True
        Next
    End Sub
    Private Sub DESMARCAR_TODOS()
        For Each row As DataGridViewRow In Me.Grilla.Rows
            row.Cells(0).Value = False
        Next
    End Sub
    Private Sub ButtonDesmarcar_Click(sender As Object, e As EventArgs) Handles ButtonDesmarcar.Click
        Call DESMARCAR_TODOS()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        If e.ColumnIndex = Me.Grilla.Columns.Item(COL_GRI_SELECCION).Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.Grilla.Rows(e.RowIndex).Cells(COL_GRI_SELECCION)
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub Grilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellClick
        If (e.ColumnIndex = COL_GRI_LINK) Then
            Dim link As String = Grilla(e.ColumnIndex, e.RowIndex).Value.ToString()
            Dim frm As frm_mensaje = New frm_mensaje
            If link = "Ver Error" Then
                frm.mensaje = Grilla(COL_GRI_OBSERVACION, e.RowIndex).Value.ToString()
                frm.ShowDialog()
            End If

            'System.Diagnostics.Process.Start(link)
        End If
    End Sub
End Class