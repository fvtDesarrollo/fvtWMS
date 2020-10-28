Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class class_carga_masiva_b2b
    Private _cnn As String
    Private _car_codigo As Integer
    Private _con_ocnumero As Long
    Private _con_skucliente As String
    Private _con_skudescripcion As String
    Private _con_cantidad As String
    Private _con_preciocosto As String
    Private _con_fechadespacho As Date
    Private _con_despachara As String
    Private _con_local As String
    Private _con_observacion As String
    Private _con_numf12 As String
    Private _con_nombrearchivo As String

    Private _con_despacharanumero As String
    Private _con_localnombre As String
    Private _rut_cliente As String
    Private _nombre_cliente As String
    Private _con_codigounico As String
    Private _es_agendable As Boolean
    Private _es_abierta As Boolean

    Private _tipo As String

    Private _con_comunareceptor As String
    Private _con_ciudadreceptor As String

    Private _con_sucursalentrega As String
    Private _con_fechaventa As Date
    Private _con_numboleta As Long
    Private _con_fechaentrega As Date
    Private _con_numcaja As Integer

    Private _con_glosadepto As String
    Private _con_codigodepto As String
    Private _con_codigoEAN13 As String

    Private _con_codlinea As String
    Private _con_nombrelinea As String
    Private _con_codsucursalentrega As String
    Private _con_codigoaux As String 'EN RIPLEY COD. ART. PROV. (CASE PACK)
    Private _con_lpn As String
    Private _con_suborden As String
    Private _con_preciolista As Long

    Private _con_regionnombre As String
    Private _con_direccioncliente As String

    Private _con_temporada As String
    Private _con_talla As String
    Private _con_color As String
    Private _fecha_emision As Date

    Private _con_telefonocliente As String
    Private _con_emailcliente As String
    Private _con_numero_nd As String
    Private _con_numero_entrega As String
    Private _con_tipoflujo As String
    Private _con_localentregaeasy As String
    Private _con_localidad As String
    Private _con_fechaentregacliente As Date

    Private _IdRegion As Integer = 0
    Private _IdCiudad As Integer = 0
    Private _IdComuna As Integer = 0

    Private _con_upc As String
    Private _con_tipoorden As String
    Private _con_cobradespacho As Boolean

    Private _con_cantidadregistros As Integer = 0
    Private _con_cantidadregistrosactualizados As Integer = 0

    Private _con_codlocalentrega As String = ""
    Private _con_nomlocalentrega As String = ""
    Private _con_posicion As Integer

    Public Property con_posicion() As Integer
        Get
            Return _con_posicion
        End Get
        Set(ByVal value As Integer)
            _con_posicion = value
        End Set
    End Property

    Public Property con_nomlocalentrega() As String
        Get
            Return _con_nomlocalentrega
        End Get
        Set(ByVal value As String)
            _con_nomlocalentrega = value
        End Set
    End Property
    Public Property con_codlocalentrega() As String
        Get
            Return _con_codlocalentrega
        End Get
        Set(ByVal value As String)
            _con_codlocalentrega = value
        End Set
    End Property
    Public Property con_cantidadregistros() As Integer
        Get
            Return _con_cantidadregistros
        End Get
        Set(ByVal value As Integer)
            _con_cantidadregistros = value
        End Set
    End Property
    Public Property con_cantidadregistrosactualizados() As Integer
        Get
            Return _con_cantidadregistrosactualizados
        End Get
        Set(ByVal value As Integer)
            _con_cantidadregistrosactualizados = value
        End Set
    End Property

    Public Property con_cobradespacho() As Boolean
        Get
            Return _con_cobradespacho
        End Get
        Set(ByVal value As Boolean)
            _con_cobradespacho = value
        End Set
    End Property
    Public Property con_tipoorden() As String
        Get
            Return _con_tipoorden
        End Get
        Set(ByVal value As String)
            _con_tipoorden = value
        End Set
    End Property
    Public Property con_upc() As String
        Get
            Return _con_upc
        End Get
        Set(ByVal value As String)
            _con_upc = value
        End Set
    End Property

    Public Property IdRegion() As Integer
        Get
            Return _IdRegion
        End Get
        Set(ByVal value As Integer)
            _IdRegion = value
        End Set
    End Property
    Public Property IdCiudad() As Integer
        Get
            Return _IdCiudad
        End Get
        Set(ByVal value As Integer)
            _IdCiudad = value
        End Set
    End Property
    Public Property IdComuna() As Integer
        Get
            Return _IdComuna
        End Get
        Set(ByVal value As Integer)
            _IdComuna = value
        End Set
    End Property

    Public Property con_fechaentregacliente() As Date
        Get
            Return _con_fechaentregacliente
        End Get
        Set(ByVal value As Date)
            _con_fechaentregacliente = value
        End Set
    End Property
    Public Property con_localidad() As String
        Get
            Return _con_localidad
        End Get
        Set(ByVal value As String)
            _con_localidad = value
        End Set
    End Property
    Public Property con_localentregaeasy() As String
        Get
            Return _con_localentregaeasy
        End Get
        Set(ByVal value As String)
            _con_localentregaeasy = value
        End Set
    End Property
    Public Property con_tipoflujo() As String
        Get
            Return _con_tipoflujo
        End Get
        Set(ByVal value As String)
            _con_tipoflujo = value
        End Set
    End Property
    Public Property con_numero_entrega() As String
        Get
            Return _con_numero_entrega
        End Get
        Set(ByVal value As String)
            _con_numero_entrega = value
        End Set
    End Property
    Public Property con_numero_nd() As String
        Get
            Return _con_numero_nd
        End Get
        Set(ByVal value As String)
            _con_numero_nd = value
        End Set
    End Property

    Public Property con_telefonocliente() As String
        Get
            Return _con_telefonocliente
        End Get
        Set(ByVal value As String)
            _con_telefonocliente = value
        End Set
    End Property

    Public Property con_emailcliente() As String
        Get
            Return _con_emailcliente
        End Get
        Set(ByVal value As String)
            _con_emailcliente = value
        End Set
    End Property

    Public Property fecha_emision() As Date
        Get
            Return _fecha_emision
        End Get
        Set(ByVal value As Date)
            _fecha_emision = value
        End Set
    End Property
    Public Property con_temporada() As String
        Get
            Return _con_temporada
        End Get
        Set(ByVal value As String)
            _con_temporada = value
        End Set
    End Property
    Public Property con_talla() As String
        Get
            Return _con_talla
        End Get
        Set(ByVal value As String)
            _con_talla = value
        End Set
    End Property
    Public Property con_color() As String
        Get
            Return _con_color
        End Get
        Set(ByVal value As String)
            _con_color = value
        End Set
    End Property

    Public Property con_regionnombre() As String
        Get
            Return _con_regionnombre
        End Get
        Set(ByVal value As String)
            _con_regionnombre = value
        End Set
    End Property
    Public Property con_direccioncliente() As String
        Get
            Return _con_direccioncliente
        End Get
        Set(ByVal value As String)
            _con_direccioncliente = value
        End Set
    End Property

    Public Property con_preciolista() As Long
        Get
            Return _con_preciolista
        End Get
        Set(ByVal value As Long)
            _con_preciolista = value
        End Set
    End Property
    Public Property con_suborden() As String
        Get
            Return _con_suborden
        End Get
        Set(ByVal value As String)
            _con_suborden = value
        End Set
    End Property

    Public Property con_lpn() As String
        Get
            Return _con_lpn
        End Get
        Set(ByVal value As String)
            _con_lpn = value
        End Set
    End Property

    Public Property con_codigoaux() As String
        Get
            Return _con_codigoaux
        End Get
        Set(ByVal value As String)
            _con_codigoaux = value
        End Set
    End Property

    Public Property con_nombrelinea() As String
        Get
            Return _con_nombrelinea
        End Get
        Set(ByVal value As String)
            _con_nombrelinea = value
        End Set
    End Property
    Public Property con_codsucursalentrega() As String
        Get
            Return _con_codsucursalentrega
        End Get
        Set(ByVal value As String)
            _con_codsucursalentrega = value
        End Set
    End Property
    Public Property con_codlinea() As String
        Get
            Return _con_codlinea
        End Get
        Set(ByVal value As String)
            _con_codlinea = value
        End Set
    End Property

    Public Property con_codigoEAN13() As String
        Get
            Return _con_codigoEAN13
        End Get
        Set(ByVal value As String)
            _con_codigoEAN13 = value
        End Set
    End Property

    Public Property con_sucursalentrega() As String
        Get
            Return _con_sucursalentrega
        End Get
        Set(ByVal value As String)
            _con_sucursalentrega = value
        End Set
    End Property
    Public Property con_fechaventa() As Date
        Get
            Return _con_fechaventa
        End Get
        Set(ByVal value As Date)
            _con_fechaventa = value
        End Set
    End Property
    Public Property con_numboleta() As Long
        Get
            Return _con_numboleta
        End Get
        Set(ByVal value As Long)
            _con_numboleta = value
        End Set
    End Property
    Public Property con_fechaentrega() As Date
        Get
            Return _con_fechaentrega
        End Get
        Set(ByVal value As Date)
            _con_fechaentrega = value
        End Set
    End Property
    Public Property con_numcaja() As Integer
        Get
            Return _con_numcaja
        End Get
        Set(ByVal value As Integer)
            _con_numcaja = value
        End Set
    End Property
    Public Property con_glosadepto() As String
        Get
            Return _con_glosadepto
        End Get
        Set(ByVal value As String)
            _con_glosadepto = value
        End Set
    End Property
    Public Property con_codigodepto() As String
        Get
            Return _con_codigodepto
        End Get
        Set(ByVal value As String)
            _con_codigodepto = value
        End Set
    End Property

    Public Property con_comunareceptor() As String
        Get
            Return _con_comunareceptor
        End Get
        Set(ByVal value As String)
            _con_comunareceptor = value
        End Set
    End Property
    Public Property con_ciudadreceptor() As String
        Get
            Return _con_ciudadreceptor
        End Get
        Set(ByVal value As String)
            _con_ciudadreceptor = value
        End Set
    End Property
    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property
    Public Property es_abierta() As Boolean
        Get
            Return _es_abierta
        End Get
        Set(ByVal value As Boolean)
            _es_abierta = value
        End Set
    End Property
    Public Property es_agendable() As Boolean
        Get
            Return _es_agendable
        End Get
        Set(ByVal value As Boolean)
            _es_agendable = value
        End Set
    End Property
    Public Property con_codigounico() As String
        Get
            Return _con_codigounico
        End Get
        Set(ByVal value As String)
            _con_codigounico = value
        End Set
    End Property
    Public Property nombre_cliente() As String
        Get
            Return _nombre_cliente
        End Get
        Set(ByVal value As String)
            _nombre_cliente = value
        End Set
    End Property
    Public Property rut_cliente() As String
        Get
            Return _rut_cliente
        End Get
        Set(ByVal value As String)
            _rut_cliente = value
        End Set
    End Property
    Public Property con_localnombre() As String
        Get
            Return _con_localnombre
        End Get
        Set(ByVal value As String)
            _con_localnombre = value
        End Set
    End Property
    Public Property con_despacharanumero() As String
        Get
            Return _con_despacharanumero
        End Get
        Set(ByVal value As String)
            _con_despacharanumero = value
        End Set
    End Property
    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Public Property car_codigo() As Integer
        Get
            Return _car_codigo
        End Get
        Set(ByVal value As Integer)
            _car_codigo = value
        End Set
    End Property
    Public Property con_ocnumero() As Long
        Get
            Return _con_ocnumero
        End Get
        Set(ByVal value As Long)
            _con_ocnumero = value
        End Set
    End Property
    Public Property con_skucliente() As String
        Get
            Return _con_skucliente
        End Get
        Set(ByVal value As String)
            _con_skucliente = value
        End Set
    End Property
    Public Property con_skudescripcion() As String
        Get
            Return _con_skudescripcion
        End Get
        Set(ByVal value As String)
            _con_skudescripcion = value
        End Set
    End Property
    Public Property con_cantidad() As String
        Get
            Return _con_cantidad
        End Get
        Set(ByVal value As String)
            _con_cantidad = value
        End Set
    End Property
    Public Property con_preciocosto() As String
        Get
            Return _con_preciocosto
        End Get
        Set(ByVal value As String)
            _con_preciocosto = value
        End Set
    End Property
    Public Property con_fechadespacho() As Date
        Get
            Return _con_fechadespacho
        End Get
        Set(ByVal value As Date)
            _con_fechadespacho = value
        End Set
    End Property
    Public Property con_despachara() As String
        Get
            Return _con_despachara
        End Get
        Set(ByVal value As String)
            _con_despachara = value
        End Set
    End Property
    Public Property con_local() As String
        Get
            Return _con_local
        End Get
        Set(ByVal value As String)
            _con_local = value
        End Set
    End Property
    Public Property con_observacion() As String
        Get
            Return _con_observacion
        End Get
        Set(ByVal value As String)
            _con_observacion = value
        End Set
    End Property
    Public Property con_numf12() As String
        Get
            Return _con_numf12
        End Get
        Set(ByVal value As String)
            _con_numf12 = value
        End Set
    End Property
    Public Property con_nombrearchivo() As String
        Get
            Return _con_nombrearchivo
        End Get
        Set(ByVal value As String)
            _con_nombrearchivo = value
        End Set
    End Property
    Public Function SELECCIONA_DIRECTORIOS_B2B(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_selecciona_directorios_b2b", conexion)

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function SELECCIONA_DIRECTORIOS_B2B_CARGA(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_selecciona_directorios_b2b_carga", conexion)

            command.Parameters.Add("@car_codigo", SqlDbType.Int)
            command.Parameters(0).Value = _car_codigo

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function SELECCIONA_DIRECTORIOS_B2B_INTERFAZ(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_selecciona_directorios_b2b_interfaz", conexion)

            command.Parameters.Add("@car_codigo", SqlDbType.Int)
            command.Parameters(0).Value = _car_codigo

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function INGRESA_REPOSITORIO(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)
        Try
            Dim command As New SqlCommand("sp_guarda_repositorio_b2b", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@car_codigo", SqlDbType.Int)
            command.Parameters.Add("@con_ocnumero", SqlDbType.Float)
            command.Parameters.Add("@con_skucliente", SqlDbType.NVarChar)
            command.Parameters.Add("@con_skudescripcion", SqlDbType.NVarChar)
            command.Parameters.Add("@con_cantidad", SqlDbType.Int)
            command.Parameters.Add("@con_preciocosto", SqlDbType.Float)
            command.Parameters.Add("@con_fechadespacho", SqlDbType.DateTime)
            command.Parameters.Add("@con_despacharanumero", SqlDbType.NVarChar)
            command.Parameters.Add("@con_despachara", SqlDbType.NVarChar)
            command.Parameters.Add("@con_local", SqlDbType.NVarChar)
            command.Parameters.Add("@con_localnombre", SqlDbType.NVarChar)
            command.Parameters.Add("@rut_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@nombre_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@con_observacion", SqlDbType.NVarChar)
            command.Parameters.Add("@con_codigounico", SqlDbType.NVarChar)
            command.Parameters.Add("@es_agendable", SqlDbType.Bit)
            command.Parameters.Add("@es_abierta", SqlDbType.Bit)
            command.Parameters.Add("@con_nombrearchivo", SqlDbType.NVarChar)
            command.Parameters.Add("@por_confirmar", SqlDbType.Bit)
            command.Parameters.Add("@con_comunareceptor", SqlDbType.NVarChar)
            command.Parameters.Add("@con_ciudadreceptor", SqlDbType.NVarChar)
            command.Parameters.Add("@con_sucursalentrega", SqlDbType.NVarChar)
            command.Parameters.Add("@con_fechaventa", SqlDbType.Date)
            command.Parameters.Add("@con_numboleta", SqlDbType.Float)
            command.Parameters.Add("@con_fechaentrega", SqlDbType.Date)
            command.Parameters.Add("@con_numcaja", SqlDbType.Int)
            command.Parameters.Add("@con_glosadepto", SqlDbType.NVarChar)
            command.Parameters.Add("@con_codigodepto", SqlDbType.NVarChar)
            command.Parameters.Add("@con_codigoEAN13", SqlDbType.NVarChar)
            command.Parameters.Add("@con_codlinea", SqlDbType.NVarChar)
            command.Parameters.Add("@con_nombrelinea", SqlDbType.NVarChar)
            command.Parameters.Add("@con_codsucursalentrega", SqlDbType.NVarChar)
            command.Parameters.Add("@con_codigoaux", SqlDbType.NVarChar)
            command.Parameters.Add("@con_lpn", SqlDbType.NVarChar)
            command.Parameters.Add("@con_suborden", SqlDbType.NVarChar)
            command.Parameters.Add("@con_preciolista", SqlDbType.Float)
            command.Parameters.Add("@con_regionnombre", SqlDbType.NVarChar)
            command.Parameters.Add("@con_direccioncliente", SqlDbType.NVarChar)
            command.Parameters.Add("@con_temporada", SqlDbType.NVarChar)
            command.Parameters.Add("@con_talla", SqlDbType.NVarChar)
            command.Parameters.Add("@con_color", SqlDbType.NVarChar)
            command.Parameters.Add("@fecha_emision", SqlDbType.Date)
            command.Parameters.Add("@con_telefonocliente", SqlDbType.NVarChar)
            command.Parameters.Add("@con_emailcliente", SqlDbType.NVarChar)
            command.Parameters.Add("@con_numero_nd", SqlDbType.NVarChar)
            command.Parameters.Add("@con_numero_entrega", SqlDbType.NVarChar)
            command.Parameters.Add("@con_tipoflujo", SqlDbType.NVarChar)
            command.Parameters.Add("@con_localentregaeasy", SqlDbType.NVarChar)
            command.Parameters.Add("@con_localidad", SqlDbType.NVarChar)
            command.Parameters.Add("@con_fechaentregacliente", SqlDbType.Date)
            command.Parameters.Add("@reg_codigo", SqlDbType.Int)
            command.Parameters.Add("@ciu_codigo", SqlDbType.Int)
            command.Parameters.Add("@com_codigo", SqlDbType.Int)
            command.Parameters.Add("@con_upc", SqlDbType.NVarChar)
            command.Parameters.Add("@con_tipoorden", SqlDbType.NVarChar)
            command.Parameters.Add("@con_cobradespacho", SqlDbType.NVarChar)
            command.Parameters.Add("@con_codlocalentrega", SqlDbType.NVarChar)
            command.Parameters.Add("@con_nomlocalentrega", SqlDbType.NVarChar)
            command.Parameters.Add("@con_posicion", SqlDbType.Int)

            command.UpdatedRowSource = UpdateRowSource.None

            'If _car_codigo = 3 Then
            '    _car_codigo = _car_codigo
            'End If

            If _con_comunareceptor = "" Then
                _con_comunareceptor = "-"
            End If
            If _con_ciudadreceptor = "" Then
                _con_ciudadreceptor = "-"
            End If

            If _con_sucursalentrega = Nothing Then
                _con_sucursalentrega = "-"
            End If

            If _con_fechaventa = Nothing Then
                _con_fechaventa = CDate("01-01-1900")
            End If

            If _con_numboleta = Nothing Then
                _con_numboleta = 0
            End If

            If _con_fechaentrega = Nothing Then
                _con_fechaentrega = CDate("01-01-1900")
            End If

            If _con_numcaja = Nothing Then
                _con_numcaja = 0
            End If

            If _con_glosadepto = Nothing Then
                _con_glosadepto = "-"
            End If

            If _con_codigodepto = Nothing Then
                _con_codigodepto = "-"
            End If

            If _con_codigoEAN13 = Nothing Then
                _con_codigoEAN13 = "-"
            End If

            If _con_telefonocliente = Nothing Then
                _con_telefonocliente = "-"
            End If

            If _con_emailcliente = Nothing Then
                _con_emailcliente = "-"
            End If

            command.Parameters(0).Value = _car_codigo
            command.Parameters(1).Value = _con_ocnumero
            command.Parameters(2).Value = Replace(_con_skucliente, Chr(34), "")
            command.Parameters(3).Value = Replace(_con_skudescripcion, Chr(34), "")
            command.Parameters(4).Value = CInt(Replace(_con_cantidad, ".", ","))
            If _car_codigo = 6 Then
                command.Parameters(5).Value = _con_preciocosto
            Else
                If CStr(CLng(Replace(_con_preciocosto, ".", ","))).Length < 4 Then
                    command.Parameters(5).Value = CLng(_con_preciocosto)
                Else
                    command.Parameters(5).Value = CLng(Replace(_con_preciocosto, ".", ","))
                End If

            End If

            command.Parameters(6).Value = _con_fechadespacho
            command.Parameters(7).Value = Replace(_con_despacharanumero, Chr(34), "")
            'command.Parameters(8).Value = Replace(Replace(Replace(_con_despachara, "°", ""), Chr(34), ""), Chr(34), "")
            command.Parameters(8).Value = Replace(Replace(Replace(_con_despachara, "°", ""), Chr(34), ""), "�", "")
            command.Parameters(9).Value = Replace(Replace(_con_local, Chr(34), ""), "�", "")
            command.Parameters(10).Value = Replace(Replace(Replace(_con_localnombre, "°", ""), Chr(34), ""), "�", "")
            command.Parameters(11).Value = Replace(_rut_cliente, Chr(34), "")
            command.Parameters(12).Value = Replace(Replace(Replace(_nombre_cliente, "°", ""), Chr(34), ""), "�", "")
            command.Parameters(13).Value = Replace(Replace(_con_observacion, Chr(34), ""), "�", "")
            command.Parameters(14).Value = Replace(Replace(Replace(_con_codigounico, "°", ""), Chr(34), ""), "�", "")
            command.Parameters(15).Value = _es_agendable
            command.Parameters(16).Value = _es_abierta
            command.Parameters(17).Value = _con_nombrearchivo
            command.Parameters(18).Value = False
            command.Parameters(19).Value = Replace(_con_comunareceptor, Chr(34), "")
            command.Parameters(20).Value = Replace(_con_ciudadreceptor, Chr(34), "")

            command.Parameters(21).Value = Replace(_con_sucursalentrega, Chr(34), "")
            command.Parameters(22).Value = _con_fechaventa
            command.Parameters(23).Value = _con_numboleta
            command.Parameters(24).Value = _con_fechaentrega
            command.Parameters(25).Value = _con_numcaja

            command.Parameters(26).Value = _con_glosadepto
            command.Parameters(27).Value = _con_codigodepto

            command.Parameters(28).Value = _con_codigoEAN13

            command.Parameters(29).Value = _con_codlinea
            command.Parameters(30).Value = _con_nombrelinea
            command.Parameters(31).Value = _con_codsucursalentrega
            command.Parameters(32).Value = _con_codigoaux
            command.Parameters(33).Value = _con_lpn
            command.Parameters(34).Value = _con_suborden
            command.Parameters(35).Value = _con_preciolista
            command.Parameters(36).Value = Replace(Replace(Replace(_con_regionnombre, "°", ""), Chr(34), ""), "�", "")
            command.Parameters(37).Value = Replace(Replace(Replace(_con_direccioncliente, "°", ""), Chr(34), ""), "�", "")
            command.Parameters(38).Value = _con_temporada
            command.Parameters(39).Value = _con_talla
            command.Parameters(40).Value = _con_color
            command.Parameters(41).Value = _fecha_emision

            command.Parameters(42).Value = Replace(Replace(Replace(_con_telefonocliente, ",", ""), "'", ""), Chr(34), "")
            command.Parameters(43).Value = Replace(Replace(Replace(_con_emailcliente, ",", ""), "'", ""), Chr(34), "")
            command.Parameters(44).Value = Replace(Replace(Replace(_con_numero_nd, ",", ""), "'", ""), Chr(34), "")
            command.Parameters(45).Value = Replace(Replace(Replace(_con_numero_entrega, ",", ""), "'", ""), Chr(34), "")
            command.Parameters(46).Value = Replace(Replace(Replace(_con_tipoflujo, ",", ""), "'", ""), Chr(34), "")
            command.Parameters(47).Value = Replace(Replace(Replace(_con_localentregaeasy, ",", ""), "'", ""), Chr(34), "")
            command.Parameters(48).Value = Replace(Replace(Replace(_con_localidad, ",", ""), "'", ""), Chr(34), "")
            command.Parameters(49).Value = _con_fechaentregacliente

            command.Parameters(50).Value = _IdRegion
            command.Parameters(51).Value = _IdCiudad
            command.Parameters(52).Value = _IdComuna
            command.Parameters(53).Value = _con_upc
            command.Parameters(54).Value = _con_tipoorden
            command.Parameters(55).Value = _con_cobradespacho
            command.Parameters(56).Value = _con_codlocalentrega
            command.Parameters(57).Value = _con_nomlocalentrega
            command.Parameters(58).Value = _con_posicion

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function SELECCIONA_CLIENTE(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_clientes_listado", conexion)

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function SELECCIONA_CLIENTE_CARGA_MASIVA(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_clientes_listado_ejecuta_carga_masiva", conexion)

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ean13(ByVal chaine As String) As String

        Dim i, checksum, first As Integer
        Dim CodeBarre As String
        Dim tableA As Boolean

        ean13 = ""
        If Len(chaine) = 12 Then
            For i = 1 To 12
                If Asc(Mid(chaine, i, 1)) < 48 Or Asc(Mid(chaine, i, 1)) > 57 Then
                    i = 0
                    Exit For
                End If
            Next
            If i = 13 Then
                For i = 2 To 12 Step 2
                    checksum = checksum + Val(Mid(chaine, i, 1))
                Next
                checksum = checksum * 3
                For i = 1 To 11 Step 2
                    checksum = checksum + Val(Mid(chaine, i, 1))
                Next
                chaine = chaine & (10 - checksum Mod 10) Mod 10
                CodeBarre = Microsoft.VisualBasic.Left(chaine, 1) & Chr(65 + Val(Mid(chaine, 2, 1)))
                first = Val(Microsoft.VisualBasic.Left(chaine, 1))
                For i = 3 To 7
                    tableA = False
                    Select Case i
                        Case 3
                            Select Case first
                                Case 0 To 3
                                    tableA = True
                            End Select
                        Case 4
                            Select Case first
                                Case 0, 4, 7, 8
                                    tableA = True
                            End Select
                        Case 5
                            Select Case first
                                Case 0, 1, 4, 5, 9
                                    tableA = True
                            End Select
                        Case 6
                            Select Case first
                                Case 0, 2, 5, 6, 7
                                    tableA = True
                            End Select
                        Case 7
                            Select Case first
                                Case 0, 3, 6, 8, 9
                                    tableA = True
                            End Select
                    End Select
                    If tableA Then
                        CodeBarre = CodeBarre & Chr(65 + Val(Mid(chaine, i, 1)))
                    Else
                        CodeBarre = CodeBarre & Chr(75 + Val(Mid(chaine, i, 1)))
                    End If
                Next
                CodeBarre = CodeBarre & "*"
                For i = 8 To 13
                    CodeBarre = CodeBarre & Chr(97 + Val(Mid(chaine, i, 1)))
                Next
                CodeBarre = CodeBarre & "+"
                ean13 = CodeBarre
            End If
        End If
    End Function

    Public Function HOMOLOGACION_PRODUCTO(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_homologacion_sv_listado", conexion)

            command.Parameters.Add("@car_codigo", SqlDbType.Int)
            command.Parameters.Add("@sku_cartera", SqlDbType.NVarChar)

            command.Parameters(0).Value = _car_codigo
            command.Parameters(1).Value = _con_skucliente

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function CARGA_DATOS_COMUNA(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_comuna_listado", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@reg_codigo", SqlDbType.Int)
            command.Parameters.Add("@ciu_codigo", SqlDbType.Int)
            command.Parameters.Add("@com_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _IdRegion
            command.Parameters(1).Value = _IdCiudad
            command.Parameters(2).Value = _IdComuna

            'command.ExecuteNonQuery()

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ULTIMA_CARGA_GUARDA_DATOS(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_repositorio_cargas_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@car_codigo", SqlDbType.Int)
            command.Parameters.Add("@con_cantidadregistros", SqlDbType.Int)
            command.Parameters.Add("@con_cantidadregistrosactualizados", SqlDbType.Int)

            command.Parameters(0).Value = _car_codigo
            command.Parameters(1).Value = _con_cantidadregistros
            command.Parameters(2).Value = _con_cantidadregistrosactualizados

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function


    Public Function GetDCBarCodEAN13(ByRef number As String) As Integer

        '*******************************************************************
        ' Nombre:     GetDCBarCodEAN13
        '             por Enrique Martínez Montejo - 07/05/2006
        '
        ' Versión:    1.0
        '
        ' Finalidad:  Calcular el dígito de control de un código de
        '             barras en formato EAN13.
        '
        ' Entradas:
        '    number:  String. El número cuyo digíto de control se desea
        '             obtener.
        ' Resultados:
        '    Integer: El dígito de control del número. En el parámetro de
        '             la función se devolverá el número completo.
        '*******************************************************************

        ' Si el número no cumple con el formato EAN13, la función
        ' devolverá una excepción de argumentos no válidos.
        ' Para ello, la cadena deberá tener 12 caracteres de
        ' longitud, y contener sólo números.
        '
        If (number.Length <> 12) Then
            number = ""
            'Throw New System.ArgumentException
        Else
            Dim ch As Char
            For Each ch In number
                If (Not Char.IsNumber(ch)) Then
                    number = ""
                    Throw New System.ArgumentException
                End If
            Next
        End If

        Dim x, digito, sumaCod As Integer

        ' Extraigo el valor del dígito, y voy
        ' sumando los valores resultantes.
        '
        For x = 11 To 0 Step -1

            digito = CInt(number.Substring(x, 1))

            Select Case x
                Case 1, 3, 5, 7, 9, 11
                    ' Las posiciones impares se multiplican por 3
                    sumaCod += (digito * 3)

                Case Else
                    ' Las posiciones pares se multiplican por 1
                    sumaCod += (digito * 1)
            End Select

        Next

        ' Calculo la decena superior
        '
        digito = (sumaCod Mod 10)

        ' Calculo el dígito de control
        '
        digito = 10 - digito

        ' Código de barras completo
        '
        'number &= CStr(digito)

        ' Devuelvo el dígito de control
        '
        If digito = 10 Then
            digito = 0
        End If
        Return digito

    End Function

End Class
