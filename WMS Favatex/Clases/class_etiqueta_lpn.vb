Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class class_etiqueta_lpn
    Private _cnn As String
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
    Private _elp_fechacompra	As Date
    Private _elp_nbulto As String

    Private _fechaDesde As String
    Private _fechaHasta As String

    Private _car_codigo As Integer
    Private _lpn_prefijo As String
    Private _lpn_ultimocorrimpreso As Long
    Private _oc_numero As Long
    Private _pic_codigo As Integer

    Private _strCadena As String

    'LA POLAR
    Private _idImpresion As String
    Private _cod_local As String
    Private _cod_depto As String
    Private _depto As String
    Private _descripcion_local As String
    Private _lpn As String

    'EASY
    Private _easy_id_impresion As String
    Private _easy_orden_compra As String
    Private _easy_fecha_compromiso As Date
    Private _easy_cod_local As String
    Private _easy_nombre_local As String
    Private _easy_lpn As String
    Private _easy_sku_cliente As String
    Private _easy_sku_nombre As String
    Private _easy_cantidad As Integer
    Private _easy_cod_favatex As String
    Private _esPimare As Boolean

    'ABCDIN
    Private _abcdin_id_impresion As String
    Private _abcdin_razon_social As String
    Private _abcdin_fecha_entrega As Date
    Private _abcdin_numero_cita As Integer
    Private _abcdin_numero_oc As Long
    Private _abcdin_numero_factura As Long
    Private _abcdin_numero_boleta As String
    Private _abcdin_vendido_por As String
    Private _abcdin_fecha_cliente As Date
    Private _abcdin_nombre_cliente As String
    Private _abcdin_rut_cliente As String
    Private _abcdin_fono_cliente As String
    Private _abcdin_direc_cliente As String
    Private _abcdin_comuna_cliente As String
    Private _abcdin_local_cliente As String
    Private _abcdin_cod_sucursal As String
    Private _abcdin_nom_sucursal As String
    Private _abcdin_sku_cliente As String
    Private _abcdin_cantidad As Integer
    Private _abcdin_num_bulto As Integer
    Private _abcdin_sku_nombre As String
    Private _abcdin_volumne As Double
    Private _abcdin_peso As Double
    Private _abcdin_lpn As String

    'RIPLEY
    Private _ripley_id_impresion As String
    Private _ripley_lpn As String
    Private _ripley_deptoCodigo As String
    Private _ripley_deptoNombre As String
    Private _ripley_sucCodigo As String
    Private _ripley_sucNombre As String
    Private _ripley_con_skucliente As String
    Private _ripley_con_skudescripcion As String
    Private _ripley_pic_cantidad_encontrada As Integer
    Private _ripley_con_ocnumero As Double
    Private _tipo_orden As String

    'SODIMAC
    Private _sodimac_id_impresion As String
    Private _sodimac_id_proveedor As String
    Private _sodimac_con_ocnumero As Long
    Private _sodimac_cdEntregaCodigoa As String
    Private _sodimac_sucNombre As String
    Private _sodimac_sucCodigo As String
    Private _sodimac_lpn As String
    Private _sodimac_upc As String
    Private _sodimac_con_skucliente As String
    Private _sodimac_con_skudescripcion As String
    Private _sodimac_codigo_favatex As String
    Private _sodimac_cantidad As Integer
    Private _sodimac_numero_documento As Integer
    Private _sodimac_tipo_documento As String

    Public Property esPimare() As Boolean
        Get
            Return _esPimare
        End Get
        Set(ByVal value As Boolean)
            _esPimare = value
        End Set
    End Property

    Public Property sodimac_id_impresion() As String
        Get
            Return _sodimac_id_impresion
        End Get
        Set(ByVal value As String)
            _sodimac_id_impresion = value
        End Set
    End Property
    Public Property sodimac_id_proveedor() As String
        Get
            Return _sodimac_id_proveedor
        End Get
        Set(ByVal value As String)
            _sodimac_id_proveedor = value
        End Set
    End Property
    Public Property sodimac_con_ocnumero() As Long
        Get
            Return _sodimac_con_ocnumero
        End Get
        Set(ByVal value As Long)
            _sodimac_con_ocnumero = value
        End Set
    End Property
    Public Property sodimac_cdEntregaCodigoa() As String
        Get
            Return _sodimac_cdEntregaCodigoa
        End Get
        Set(ByVal value As String)
            _sodimac_cdEntregaCodigoa = value
        End Set
    End Property
    Public Property sodimac_sucNombre() As String
        Get
            Return _sodimac_sucNombre
        End Get
        Set(ByVal value As String)
            _sodimac_sucNombre = value
        End Set
    End Property
    Public Property sodimac_sucCodigo() As String
        Get
            Return _sodimac_sucCodigo
        End Get
        Set(ByVal value As String)
            _sodimac_sucCodigo = value
        End Set
    End Property
    Public Property sodimac_lpn() As String
        Get
            Return _sodimac_lpn
        End Get
        Set(ByVal value As String)
            _sodimac_lpn = value
        End Set
    End Property
    Public Property sodimac_upc() As String
        Get
            Return _sodimac_upc
        End Get
        Set(ByVal value As String)
            _sodimac_upc = value
        End Set
    End Property
    Public Property sodimac_con_skucliente() As String
        Get
            Return _sodimac_con_skucliente
        End Get
        Set(ByVal value As String)
            _sodimac_con_skucliente = value
        End Set
    End Property
    Public Property sodimac_con_skudescripcion() As String
        Get
            Return _sodimac_con_skudescripcion
        End Get
        Set(ByVal value As String)
            _sodimac_con_skudescripcion = value
        End Set
    End Property
    Public Property sodimac_codigo_favatex() As String
        Get
            Return _sodimac_codigo_favatex
        End Get
        Set(ByVal value As String)
            _sodimac_codigo_favatex = value
        End Set
    End Property
    Public Property sodimac_cantidad() As Integer
        Get
            Return _sodimac_cantidad
        End Get
        Set(ByVal value As Integer)
            _sodimac_cantidad = value
        End Set
    End Property
    Public Property sodimac_numero_documento() As Integer
        Get
            Return _sodimac_numero_documento
        End Get
        Set(ByVal value As Integer)
            _sodimac_numero_documento = value
        End Set
    End Property
    Public Property sodimac_tipo_documento() As String
        Get
            Return _sodimac_tipo_documento
        End Get
        Set(ByVal value As String)
            _sodimac_tipo_documento = value
        End Set
    End Property

    Public Property tipo_orden() As String
        Get
            Return _tipo_orden
        End Get
        Set(ByVal value As String)
            _tipo_orden = value
        End Set
    End Property


    Public Property ripley_id_impresion() As String
        Get
            Return _ripley_id_impresion
        End Get
        Set(ByVal value As String)
            _ripley_id_impresion = value
        End Set
    End Property
    Public Property ripley_lpn() As String
        Get
            Return _ripley_lpn
        End Get
        Set(ByVal value As String)
            _ripley_lpn = value
        End Set
    End Property
    Public Property ripley_deptoCodigo() As String
        Get
            Return _ripley_deptoCodigo
        End Get
        Set(ByVal value As String)
            _ripley_deptoCodigo = value
        End Set
    End Property
    Public Property ripley_deptoNombre() As String
        Get
            Return _ripley_deptoNombre
        End Get
        Set(ByVal value As String)
            _ripley_deptoNombre = value
        End Set
    End Property
    Public Property ripley_sucCodigo() As String
        Get
            Return _ripley_sucCodigo
        End Get
        Set(ByVal value As String)
            _ripley_sucCodigo = value
        End Set
    End Property
    Public Property ripley_sucNombre() As String
        Get
            Return _ripley_sucNombre
        End Get
        Set(ByVal value As String)
            _ripley_sucNombre = value
        End Set
    End Property
    Public Property ripley_con_skucliente() As String
        Get
            Return _ripley_con_skucliente
        End Get
        Set(ByVal value As String)
            _ripley_con_skucliente = value
        End Set
    End Property
    Public Property ripley_con_skudescripcion() As String
        Get
            Return _ripley_con_skudescripcion
        End Get
        Set(ByVal value As String)
            _ripley_con_skudescripcion = value
        End Set
    End Property
    Public Property ripley_pic_cantidad_encontrada() As Integer
        Get
            Return _ripley_pic_cantidad_encontrada
        End Get
        Set(ByVal value As Integer)
            _ripley_pic_cantidad_encontrada = value
        End Set
    End Property
    Public Property ripley_con_ocnumero() As Double
        Get
            Return _ripley_con_ocnumero
        End Get
        Set(ByVal value As Double)
            _ripley_con_ocnumero = value
        End Set
    End Property


    Public Property abcdin_id_impresion() As String
        Get
            Return _abcdin_id_impresion
        End Get
        Set(ByVal value As String)
            _abcdin_id_impresion = value
        End Set
    End Property
    Public Property abcdin_razon_social() As String
        Get
            Return _abcdin_razon_social
        End Get
        Set(ByVal value As String)
            _abcdin_razon_social = value
        End Set
    End Property
    Public Property abcdin_fecha_entrega() As Date
        Get
            Return _abcdin_fecha_entrega
        End Get
        Set(ByVal value As Date)
            _abcdin_fecha_entrega = value
        End Set
    End Property
    Public Property abcdin_numero_cita() As Integer
        Get
            Return _abcdin_numero_cita
        End Get
        Set(ByVal value As Integer)
            _abcdin_numero_cita = value
        End Set
    End Property
    Public Property abcdin_numero_oc() As Long
        Get
            Return _abcdin_numero_oc
        End Get
        Set(ByVal value As Long)
            _abcdin_numero_oc = value
        End Set
    End Property
    Public Property abcdin_numero_factura() As Long
        Get
            Return _abcdin_numero_factura
        End Get
        Set(ByVal value As Long)
            _abcdin_numero_factura = value
        End Set
    End Property
    Public Property abcdin_numero_boleta() As String
        Get
            Return _abcdin_numero_boleta
        End Get
        Set(ByVal value As String)
            _abcdin_numero_boleta = value
        End Set
    End Property
    Public Property abcdin_vendido_por() As String
        Get
            Return _abcdin_vendido_por
        End Get
        Set(ByVal value As String)
            _abcdin_vendido_por = value
        End Set
    End Property
    Public Property abcdin_fecha_cliente() As Date
        Get
            Return _abcdin_fecha_cliente
        End Get
        Set(ByVal value As Date)
            _abcdin_fecha_cliente = value
        End Set
    End Property
    Public Property abcdin_nombre_cliente() As String
        Get
            Return _abcdin_nombre_cliente
        End Get
        Set(ByVal value As String)
            _abcdin_nombre_cliente = value
        End Set
    End Property
    Public Property abcdin_rut_cliente() As String
        Get
            Return _abcdin_rut_cliente
        End Get
        Set(ByVal value As String)
            _abcdin_rut_cliente = value
        End Set
    End Property
    Public Property abcdin_fono_cliente() As String
        Get
            Return _abcdin_fono_cliente
        End Get
        Set(ByVal value As String)
            _abcdin_fono_cliente = value
        End Set
    End Property
    Public Property abcdin_direc_cliente() As String
        Get
            Return _abcdin_direc_cliente
        End Get
        Set(ByVal value As String)
            _abcdin_direc_cliente = value
        End Set
    End Property
    Public Property abcdin_comuna_cliente() As String
        Get
            Return _abcdin_comuna_cliente
        End Get
        Set(ByVal value As String)
            _abcdin_comuna_cliente = value
        End Set
    End Property
    Public Property abcdin_local_cliente() As String
        Get
            Return _abcdin_local_cliente
        End Get
        Set(ByVal value As String)
            _abcdin_local_cliente = value
        End Set
    End Property
    Public Property abcdin_cod_sucursal() As String
        Get
            Return _abcdin_cod_sucursal
        End Get
        Set(ByVal value As String)
            _abcdin_cod_sucursal = value
        End Set
    End Property
    Public Property abcdin_nom_sucursal() As String
        Get
            Return _abcdin_nom_sucursal
        End Get
        Set(ByVal value As String)
            _abcdin_nom_sucursal = value
        End Set
    End Property
    Public Property abcdin_sku_cliente() As String
        Get
            Return _abcdin_sku_cliente
        End Get
        Set(ByVal value As String)
            _abcdin_sku_cliente = value
        End Set
    End Property
    Public Property abcdin_cantidad() As Integer
        Get
            Return _abcdin_cantidad
        End Get
        Set(ByVal value As Integer)
            _abcdin_cantidad = value
        End Set
    End Property
    Public Property abcdin_num_bulto() As Integer
        Get
            Return _abcdin_num_bulto
        End Get
        Set(ByVal value As Integer)
            _abcdin_num_bulto = value
        End Set
    End Property
    Public Property abcdin_sku_nombre() As String
        Get
            Return _abcdin_sku_nombre
        End Get
        Set(ByVal value As String)
            _abcdin_sku_nombre = value
        End Set
    End Property
    Public Property abcdin_volumne() As Double
        Get
            Return _abcdin_volumne
        End Get
        Set(ByVal value As Double)
            _abcdin_volumne = value
        End Set
    End Property
    Public Property abcdin_peso() As Double
        Get
            Return _abcdin_peso
        End Get
        Set(ByVal value As Double)
            _abcdin_peso = value
        End Set
    End Property
    Public Property abcdin_lpn() As String
        Get
            Return _abcdin_lpn
        End Get
        Set(ByVal value As String)
            _abcdin_lpn = value
        End Set
    End Property


    Private _num_cita As Long

    Public Property num_cita() As Long
        Get
            Return _num_cita
        End Get
        Set(ByVal value As Long)
            _num_cita = value
        End Set
    End Property
    Public Property easy_id_impresion() As String
        Get
            Return _easy_id_impresion
        End Get
        Set(ByVal value As String)
            _easy_id_impresion = value
        End Set
    End Property
    Public Property easy_orden_compra() As String
        Get
            Return _easy_orden_compra
        End Get
        Set(ByVal value As String)
            _easy_orden_compra = value
        End Set
    End Property
    Public Property easy_fecha_compromiso() As Date
        Get
            Return _easy_fecha_compromiso
        End Get
        Set(ByVal value As Date)
            _easy_fecha_compromiso = value
        End Set
    End Property
    Public Property easy_cod_local() As String
        Get
            Return _easy_cod_local
        End Get
        Set(ByVal value As String)
            _easy_cod_local = value
        End Set
    End Property
    Public Property easy_nombre_local() As String
        Get
            Return _easy_nombre_local
        End Get
        Set(ByVal value As String)
            _easy_nombre_local = value
        End Set
    End Property
    Public Property easy_lpn() As String
        Get
            Return _easy_lpn
        End Get
        Set(ByVal value As String)
            _easy_lpn = value
        End Set
    End Property
    Public Property easy_sku_cliente() As String
        Get
            Return _easy_sku_cliente
        End Get
        Set(ByVal value As String)
            _easy_sku_cliente = value
        End Set
    End Property
    Public Property easy_sku_nombre() As String
        Get
            Return _easy_sku_nombre
        End Get
        Set(ByVal value As String)
            _easy_sku_nombre = value
        End Set
    End Property
    Public Property easy_cantidad() As Integer
        Get
            Return _easy_cantidad
        End Get
        Set(ByVal value As Integer)
            _easy_cantidad = value
        End Set
    End Property
    Public Property easy_cod_favatex() As String
        Get
            Return _easy_cod_favatex
        End Get
        Set(ByVal value As String)
            _easy_cod_favatex = value
        End Set
    End Property



    Public Property strCadena() As String
        Get
            Return _strCadena
        End Get
        Set(ByVal value As String)
            _strCadena = value
        End Set
    End Property

    Public Property fechaHasta() As String
        Get
            Return _fechaHasta
        End Get
        Set(ByVal value As String)
            _fechaHasta = value
        End Set
    End Property
    Public Property fechaDesde() As String
        Get
            Return _fechaDesde
        End Get
        Set(ByVal value As String)
            _fechaDesde = value
        End Set
    End Property

    Public Property idImpresion() As String
        Get
            Return _idImpresion
        End Get
        Set(ByVal value As String)
            _idImpresion = value
        End Set
    End Property
    Public Property cod_local() As String
        Get
            Return _cod_local
        End Get
        Set(ByVal value As String)
            _cod_local = value
        End Set
    End Property
    Public Property cod_depto() As String
        Get
            Return _cod_depto
        End Get
        Set(ByVal value As String)
            _cod_depto = value
        End Set
    End Property
    Public Property depto() As String
        Get
            Return _depto
        End Get
        Set(ByVal value As String)
            _depto = value
        End Set
    End Property
    Public Property descripcion_local() As String
        Get
            Return _descripcion_local
        End Get
        Set(ByVal value As String)
            _descripcion_local = value
        End Set
    End Property
    Public Property lpn() As String
        Get
            Return _lpn
        End Get
        Set(ByVal value As String)
            _lpn = value
        End Set
    End Property

    Public Property pic_codigo() As Integer
        Get
            Return _pic_codigo
        End Get
        Set(ByVal value As Integer)
            _pic_codigo = value
        End Set
    End Property
    Public Property oc_numero() As Long
        Get
            Return _oc_numero
        End Get
        Set(ByVal value As Long)
            _oc_numero = value
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
    Public Property lpn_prefijo() As String
        Get
            Return _lpn_prefijo
        End Get
        Set(ByVal value As String)
            _lpn_prefijo = value
        End Set
    End Property
    Public Property lpn_ultimocorrimpreso() As Long
        Get
            Return _lpn_ultimocorrimpreso
        End Get
        Set(ByVal value As Long)
            _lpn_ultimocorrimpreso = value
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
    Public Property elp_nombrearchivo() As String
        Get
            Return _elp_nombrearchivo
        End Get
        Set(ByVal value As String)
            _elp_nombrearchivo = value
        End Set
    End Property
    Public Property elp_sucursaldestino() As String
        Get
            Return _elp_sucursaldestino
        End Get
        Set(ByVal value As String)
            _elp_sucursaldestino = value
        End Set
    End Property
    Public Property elp_area() As String
        Get
            Return _elp_area
        End Get
        Set(ByVal value As String)
            _elp_area = value
        End Set
    End Property
    Public Property elp_proveedor() As String
        Get
            Return _elp_proveedor
        End Get
        Set(ByVal value As String)
            _elp_proveedor = value
        End Set
    End Property
    Public Property elp_lote() As String
        Get
            Return _elp_lote
        End Get
        Set(ByVal value As String)
            _elp_lote = value
        End Set
    End Property
    Public Property elp_ordencompra() As String
        Get
            Return _elp_ordencompra
        End Get
        Set(ByVal value As String)
            _elp_ordencompra = value
        End Set
    End Property
    Public Property elp_nd() As String
        Get
            Return _elp_nd
        End Get
        Set(ByVal value As String)
            _elp_nd = value
        End Set
    End Property
    Public Property elp_codigoproveedor() As String
        Get
            Return _elp_codigoproveedor
        End Get
        Set(ByVal value As String)
            _elp_codigoproveedor = value
        End Set
    End Property
    Public Property elp_descripcion() As String
        Get
            Return _elp_descripcion
        End Get
        Set(ByVal value As String)
            _elp_descripcion = value
        End Set
    End Property
    Public Property elp_plu() As String
        Get
            Return _elp_plu
        End Get
        Set(ByVal value As String)
            _elp_plu = value
        End Set
    End Property
    Public Property elp_rubro() As String
        Get
            Return _elp_rubro
        End Get
        Set(ByVal value As String)
            _elp_rubro = value
        End Set
    End Property
    Public Property elp_cantidad() As Integer
        Get
            Return _elp_cantidad
        End Get
        Set(ByVal value As Integer)
            _elp_cantidad = value
        End Set
    End Property
    Public Property elp_boleta() As String
        Get
            Return _elp_boleta
        End Get
        Set(ByVal value As String)
            _elp_boleta = value
        End Set
    End Property
    Public Property elp_cliente() As String
        Get
            Return _elp_cliente
        End Get
        Set(ByVal value As String)
            _elp_cliente = value
        End Set
    End Property
    Public Property elp_direccion() As String
        Get
            Return _elp_direccion
        End Get
        Set(ByVal value As String)
            _elp_direccion = value
        End Set
    End Property
    Public Property elp_comuna() As String
        Get
            Return _elp_comuna
        End Get
        Set(ByVal value As String)
            _elp_comuna = value
        End Set
    End Property
    Public Property elp_ciudad() As String
        Get
            Return _elp_ciudad
        End Get
        Set(ByVal value As String)
            _elp_ciudad = value
        End Set
    End Property
    Public Property elp_ruta() As String
        Get
            Return _elp_ruta
        End Get
        Set(ByVal value As String)
            _elp_ruta = value
        End Set
    End Property
    Public Property elp_fechaentrega() As Date
        Get
            Return _elp_fechaentrega
        End Get
        Set(ByVal value As Date)
            _elp_fechaentrega = value
        End Set
    End Property
    Public Property elp_fechacompra() As Date
        Get
            Return _elp_fechacompra
        End Get
        Set(ByVal value As Date)
            _elp_fechacompra = value
        End Set
    End Property
    Public Property elp_nbulto() As String
        Get
            Return _elp_nbulto
        End Get
        Set(ByVal value As String)
            _elp_nbulto = value
        End Set
    End Property

    Public Function CARTERA_SELECCIONA_LPN_LA_POLAR(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_lpn_listado", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@elp_nombrearchivo", _elp_nombrearchivo))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CARTERA_ELIMINA_LPN_LA_POLAR(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_lpn_elimina", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@elp_nombrearchivo", _elp_nombrearchivo))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CARTERA_GUARDA_LPN_LA_POLAR(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)

        Try
            Dim command As New SqlCommand("sp_lpn_guardar", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@elp_nombrearchivo", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_sucursaldestino", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_area", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_proveedor", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_lote", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_ordencompra", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_nd", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_codigoproveedor", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_descripcion", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_plu", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_rubro", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_cantidad", SqlDbType.Int)
            command.Parameters.Add("@elp_boleta", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_direccion", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_comuna", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_ciudad", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_ruta", SqlDbType.NVarChar)
            command.Parameters.Add("@elp_fechaentrega", SqlDbType.Date)
            command.Parameters.Add("@elp_fechacompra", SqlDbType.Date)
            command.Parameters.Add("@elp_nbulto", SqlDbType.NVarChar)

            command.Parameters(0).Value = _elp_nombrearchivo
            command.Parameters(1).Value = _elp_sucursaldestino
            command.Parameters(2).Value = _elp_area
            command.Parameters(3).Value = _elp_proveedor
            command.Parameters(4).Value = _elp_lote
            command.Parameters(5).Value = _elp_ordencompra
            command.Parameters(6).Value = _elp_nd
            command.Parameters(7).Value = _elp_codigoproveedor
            command.Parameters(8).Value = _elp_descripcion
            command.Parameters(9).Value = _elp_plu
            command.Parameters(10).Value = _elp_rubro
            command.Parameters(11).Value = _elp_cantidad
            command.Parameters(12).Value = _elp_boleta
            command.Parameters(13).Value = _elp_cliente
            command.Parameters(14).Value = _elp_direccion
            command.Parameters(15).Value = _elp_comuna
            command.Parameters(16).Value = _elp_ciudad
            command.Parameters(17).Value = _elp_ruta
            command.Parameters(18).Value = _elp_fechaentrega
            command.Parameters(19).Value = _elp_fechacompra
            command.Parameters(20).Value = _elp_nbulto

            'command.ExecuteNonQuery()
            conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function GUARDA_DATOS_LPN(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)

        Try
            Dim command As New SqlCommand("sp_lpn_correlativo_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@car_codigo", SqlDbType.Int)
            command.Parameters.Add("@lpn_prefijo", SqlDbType.NVarChar)
            command.Parameters.Add("@lpn_ultimocorrimpreso", SqlDbType.Float)

            command.Parameters(0).Value = _car_codigo
            command.Parameters(1).Value = _lpn_prefijo
            command.Parameters(2).Value = _lpn_ultimocorrimpreso

            'command.ExecuteNonQuery()
            conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_DATOS(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_lpn_correlativo_listado", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@car_codigo", _car_codigo))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_SIGUIENTE(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_lpn_correlativo_ultimo", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@car_codigo", _car_codigo))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_DATOS_PARIS(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_datos_lpn_paris", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@ccar_codigo", _car_codigo))
            command.Parameters.Add(New SqlParameter("@ppic_codigo", _pic_codigo))
            command.Parameters.Add(New SqlParameter("@ooc_numero", _oc_numero))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function GUARDA_DATOS_LPN_PARIS(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            Dim command As New SqlCommand("sp_lpn_paris_guardar", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@idImpresion", SqlDbType.NVarChar)
            command.Parameters.Add("@cod_local", SqlDbType.NVarChar)
            command.Parameters.Add("@cod_depto", SqlDbType.NVarChar)
            command.Parameters.Add("@depto", SqlDbType.NVarChar)
            command.Parameters.Add("@descripcion_local", SqlDbType.NVarChar)
            command.Parameters.Add("@lpn", SqlDbType.NVarChar)

            command.Parameters(0).Value = _idImpresion
            command.Parameters(1).Value = _cod_local
            command.Parameters(2).Value = _cod_depto
            command.Parameters(3).Value = _depto
            command.Parameters(4).Value = _descripcion_local
            command.Parameters(5).Value = _lpn

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

    Public Function ELIMINA_DATOS_LPN_PARIS(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)

        Try
            Dim command As New SqlCommand("sp_lpn_paris_eliminar", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@idImpresion", SqlDbType.NVarChar)
            command.Parameters(0).Value = _idImpresion

            'command.ExecuteNonQuery()
            conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

#Region "EASY"
    Public Function LPN_SELECCIONA_ENCABEZADO_ORDENES_EASY(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_encabezado_ordenes_easy_lpn", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@pic_codigo", _pic_codigo))
            command.Parameters.Add(New SqlParameter("@orden_compra", _oc_numero))
            command.Parameters.Add(New SqlParameter("@fecha_desde", _fechaDesde))
            command.Parameters.Add(New SqlParameter("@fecha_hasta", _fechaHasta))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_DETALLE_ORDENES_EASY(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_datos_para_lpn_easy", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@sstrCadena", _strCadena))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_LOCALES_EASY(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_locales_para_lpn_easy", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@sstrCadena", _strCadena))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_GUARDA_DATOS_PARA_ARCHIVO_ETIQUETA_EASY(ByRef Msg As String, ByVal conexion As SqlConnection) As DataSet
        'Dim conexion As New SqlConnection(_cnn)
        Try
            Dim command As New SqlCommand("sp_com_etiqueta_easy_lpn_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id_impresion", SqlDbType.NVarChar)
            command.Parameters.Add("@orden_compra", SqlDbType.NVarChar)
            command.Parameters.Add("@fecha_compromiso", SqlDbType.Date)
            command.Parameters.Add("@cod_local", SqlDbType.NVarChar)
            command.Parameters.Add("@nombre_local", SqlDbType.NVarChar)
            command.Parameters.Add("@lpn", SqlDbType.NVarChar)
            command.Parameters.Add("@sku_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@sku_nombre", SqlDbType.NVarChar)
            command.Parameters.Add("@cantidad", SqlDbType.Int)
            command.Parameters.Add("@cod_favatex", SqlDbType.NVarChar)

            command.Parameters(0).Value = _easy_id_impresion
            command.Parameters(1).Value = _easy_orden_compra
            command.Parameters(2).Value = _easy_fecha_compromiso
            command.Parameters(3).Value = _easy_cod_local
            command.Parameters(4).Value = _easy_nombre_local
            command.Parameters(5).Value = _easy_lpn
            command.Parameters(6).Value = _easy_sku_cliente
            command.Parameters(7).Value = _easy_sku_nombre
            command.Parameters(8).Value = _easy_cantidad
            command.Parameters(9).Value = _easy_cod_favatex

            'command.ExecuteNonQuery()
            'conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            'conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_GUARDA_DATOS_PARA_ARCHIVO_ETIQUETA_RIPLEY(ByRef Msg As String, ByVal conexion As SqlConnection) As DataSet
        'Dim conexion As New SqlConnection(_cnn)
        Try
            Dim command As New SqlCommand("sp_com_etiqueta_ripley_lpn_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id_impresion", SqlDbType.NVarChar)
            command.Parameters.Add("@lpn", SqlDbType.NVarChar)
            command.Parameters.Add("@deptoCodigo", SqlDbType.NVarChar)
            command.Parameters.Add("@deptoNombre", SqlDbType.NVarChar)
            command.Parameters.Add("@sucCodigo", SqlDbType.NVarChar)
            command.Parameters.Add("@sucNombre", SqlDbType.NVarChar)
            command.Parameters.Add("@con_skucliente", SqlDbType.NVarChar)
            command.Parameters.Add("@con_skudescripcion", SqlDbType.NVarChar)
            command.Parameters.Add("@pic_cantidad_encontrada", SqlDbType.Int)
            command.Parameters.Add("@con_ocnumero", SqlDbType.Float)

            command.Parameters(0).Value = CStr(_ripley_id_impresion)
            command.Parameters(1).Value = _ripley_lpn
            command.Parameters(2).Value = _ripley_deptoCodigo
            command.Parameters(3).Value = _ripley_deptoNombre
            command.Parameters(4).Value = _ripley_sucCodigo
            command.Parameters(5).Value = _ripley_sucNombre
            command.Parameters(6).Value = _ripley_con_skucliente
            command.Parameters(7).Value = _ripley_con_skudescripcion
            command.Parameters(8).Value = _ripley_pic_cantidad_encontrada
            command.Parameters(9).Value = _ripley_con_ocnumero

            'command.ExecuteNonQuery()
            'conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            'conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ELIMINA_DATOS_LPN_EASY(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)

        Try
            Dim command As New SqlCommand("sp_lpn_easy_eliminar", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@idImpresion", SqlDbType.NVarChar)
            command.Parameters(0).Value = _idImpresion

            'command.ExecuteNonQuery()
            conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

#End Region

#Region "RIPLEY"
    Public Function LPN_SELECCIONA_ENCABEZADO_ORDENES_RIPLEY(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_encabezado_ordenes_ripley_lpn", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@pic_codigo", _pic_codigo))
            command.Parameters.Add(New SqlParameter("@orden_compra", _oc_numero))
            command.Parameters.Add(New SqlParameter("@fecha_desde", _fechaDesde))
            command.Parameters.Add(New SqlParameter("@fecha_hasta", _fechaHasta))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_DETALLE_ORDENES_RIPLEY(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_datos_para_lpn_ripley", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@sstrCadena", _strCadena))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ELIMINA_DATOS_LPN_RIPLEY(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)

        Try
            Dim command As New SqlCommand("sp_lpn_ripley_eliminar", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@idImpresion", SqlDbType.NVarChar)
            command.Parameters(0).Value = _idImpresion

            'command.ExecuteNonQuery()
            conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function


#End Region

#Region "ABCDIN"
    Public Function LPN_SELECCIONA_DATOS_ABCDIN_VV(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_datos_lpn_abcdin_vv", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@ppic_codigo", _pic_codigo))
            command.Parameters.Add(New SqlParameter("@ooc_numero", _oc_numero))
            command.Parameters.Add(New SqlParameter("@num_cita", _num_cita))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function LPN_GUARDA_DATOS_PARA_ARCHIVO_ETIQUETA_ABCDIN_VV(ByRef Msg As String, ByVal conexion As SqlConnection) As DataSet
        'Dim conexion As New SqlConnection(_cnn)
        Try
            Dim command As New SqlCommand("sp_com_etiqueta_abcdin_lpn_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id_impresion", SqlDbType.NVarChar)
            command.Parameters.Add("@razon_social", SqlDbType.NVarChar)
            command.Parameters.Add("@fecha_entrega", SqlDbType.Date)
            command.Parameters.Add("@numero_cita", SqlDbType.Int)
            command.Parameters.Add("@numero_oc", SqlDbType.Float)
            command.Parameters.Add("@numero_factura", SqlDbType.Float)
            command.Parameters.Add("@numero_boleta", SqlDbType.NVarChar)
            command.Parameters.Add("@vendido_por", SqlDbType.NVarChar)
            command.Parameters.Add("@fecha_cliente", SqlDbType.Date)
            command.Parameters.Add("@nombre_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@rut_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@fono_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@direc_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@comuna_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@local_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@cod_sucursal", SqlDbType.NVarChar)
            command.Parameters.Add("@nom_sucursal", SqlDbType.NVarChar)
            command.Parameters.Add("@sku_cliente", SqlDbType.NVarChar)
            command.Parameters.Add("@cantidad", SqlDbType.Int)
            command.Parameters.Add("@num_bulto", SqlDbType.Int)
            command.Parameters.Add("@sku_nombre", SqlDbType.NVarChar)
            command.Parameters.Add("@volumne", SqlDbType.Decimal)
            command.Parameters.Add("@peso", SqlDbType.Decimal)
            command.Parameters.Add("@lpn", SqlDbType.NVarChar)

            command.Parameters(0).Value = _abcdin_id_impresion
            command.Parameters(1).Value = _abcdin_razon_social
            command.Parameters(2).Value = _abcdin_fecha_entrega
            command.Parameters(3).Value = _abcdin_numero_cita
            command.Parameters(4).Value = _abcdin_numero_oc
            command.Parameters(5).Value = _abcdin_numero_factura
            command.Parameters(6).Value = _abcdin_numero_boleta
            command.Parameters(7).Value = _abcdin_vendido_por
            command.Parameters(8).Value = _abcdin_fecha_cliente
            command.Parameters(9).Value = _abcdin_nombre_cliente
            command.Parameters(10).Value = _abcdin_rut_cliente
            command.Parameters(11).Value = _abcdin_fono_cliente
            command.Parameters(12).Value = _abcdin_direc_cliente
            command.Parameters(13).Value = _abcdin_comuna_cliente
            command.Parameters(14).Value = _abcdin_local_cliente
            command.Parameters(15).Value = _abcdin_cod_sucursal
            command.Parameters(16).Value = _abcdin_nom_sucursal
            command.Parameters(17).Value = _abcdin_sku_cliente
            command.Parameters(18).Value = _abcdin_cantidad
            command.Parameters(19).Value = _abcdin_num_bulto
            command.Parameters(20).Value = _abcdin_sku_nombre
            command.Parameters(21).Value = _abcdin_volumne
            command.Parameters(22).Value = _abcdin_peso
            command.Parameters(23).Value = _abcdin_lpn

            'command.ExecuteNonQuery()
            'conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            'conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ELIMINA_DATOS_LPN_ABCDIN_VV(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)

        Try
            Dim command As New SqlCommand("sp_lpn_abcdin_vv_eliminar", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@idImpresion", SqlDbType.NVarChar)
            command.Parameters(0).Value = _abcdin_id_impresion

            'command.ExecuteNonQuery()
            conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_ENCABEZADO_ORDENES_ABCDIN(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_encabezado_ordenes_abcdin_lpn", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@pic_codigo", _pic_codigo))
            command.Parameters.Add(New SqlParameter("@orden_compra", _oc_numero))
            command.Parameters.Add(New SqlParameter("@fecha_desde", _fechaDesde))
            command.Parameters.Add(New SqlParameter("@fecha_hasta", _fechaHasta))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_DETALLE_ORDENES_ACBDIN_AG(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_datos_lpn_abcdin_agenda", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@sstrCadena", _strCadena))
            command.Parameters.Add(New SqlParameter("@num_cita", 0))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

#End Region

#Region "SODIMAC"
    Public Function LPN_SELECCIONA_ENCABEZADO_ORDENES_SODIMAC(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_encabezado_ordenes_sodimac_lpn", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@pic_codigo", _pic_codigo))
            command.Parameters.Add(New SqlParameter("@orden_compra", _oc_numero))
            command.Parameters.Add(New SqlParameter("@fecha_desde", _fechaDesde))
            command.Parameters.Add(New SqlParameter("@fecha_hasta", _fechaHasta))
            command.Parameters.Add(New SqlParameter("@tipo_orden", _tipo_orden))
            command.Parameters.Add(New SqlParameter("@esPimare", _esPimare))

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_DETALLE_ORDENES_SODIMAC_VV(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_datos_para_lpn_sodimac_vv", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@sstrCadena", _strCadena))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_DETALLE_ORDENES_SODIMAC_STOCK(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_datos_para_lpn_sodimac_stock", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@sstrCadena", _strCadena))
            command.Parameters.Add(New SqlParameter("@esPimare", _esPimare))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_GUARDA_DATOS_PARA_ARCHIVO_ETIQUETA_SODIMAC(ByRef Msg As String, ByVal conexion As SqlConnection) As DataSet
        'Dim conexion As New SqlConnection(_cnn)
        Try
            Dim command As New SqlCommand("sp_com_etiqueta_sodimac_lpn_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@id_impresion", SqlDbType.NVarChar)
            command.Parameters.Add("@id_proveedor", SqlDbType.NVarChar)
            command.Parameters.Add("@con_ocnumero", SqlDbType.Float)
            command.Parameters.Add("@cdEntregaCodigo", SqlDbType.NVarChar)
            command.Parameters.Add("@sucNombre", SqlDbType.NVarChar)
            command.Parameters.Add("@sucCodigo", SqlDbType.NVarChar)
            command.Parameters.Add("@lpn", SqlDbType.NVarChar)
            command.Parameters.Add("@upc", SqlDbType.NVarChar)
            command.Parameters.Add("@con_skucliente", SqlDbType.NVarChar)
            command.Parameters.Add("@con_skudescripcion", SqlDbType.NVarChar)
            command.Parameters.Add("@codigo_favatex", SqlDbType.NVarChar)
            command.Parameters.Add("@cantidad", SqlDbType.Int)
            command.Parameters.Add("@numero_documento", SqlDbType.Int)
            command.Parameters.Add("@tipo_documento", SqlDbType.NVarChar)

            command.Parameters(0).Value = CStr(_sodimac_id_impresion)
            command.Parameters(1).Value = _sodimac_id_proveedor
            command.Parameters(2).Value = _sodimac_con_ocnumero
            command.Parameters(3).Value = _sodimac_cdEntregaCodigoa
            command.Parameters(4).Value = _sodimac_sucNombre
            command.Parameters(5).Value = _sodimac_sucCodigo
            command.Parameters(6).Value = _sodimac_lpn
            command.Parameters(7).Value = _sodimac_upc
            command.Parameters(8).Value = _sodimac_con_skucliente
            command.Parameters(9).Value = _sodimac_con_skudescripcion
            command.Parameters(10).Value = _sodimac_codigo_favatex
            command.Parameters(11).Value = _sodimac_cantidad
            command.Parameters(12).Value = _sodimac_numero_documento
            command.Parameters(13).Value = _sodimac_tipo_documento
            'command.ExecuteNonQuery()
            'conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            'conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ELIMINA_DATOS_LPN_SODIMAC(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)

        Try
            Dim command As New SqlCommand("sp_lpn_sodimac_eliminar", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@idImpresion", SqlDbType.NVarChar)
            command.Parameters(0).Value = _idImpresion

            'command.ExecuteNonQuery()
            conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

#End Region

#Region "CONSTRUMART"

    Public Function LPN_SELECCIONA_ENCABEZADO_ORDENES_CONSTRUMART(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_encabezado_ordenes_construmart_lpn", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@pic_codigo", _pic_codigo))
            command.Parameters.Add(New SqlParameter("@orden_compra", _oc_numero))
            command.Parameters.Add(New SqlParameter("@fecha_desde", _fechaDesde))
            command.Parameters.Add(New SqlParameter("@fecha_hasta", _fechaHasta))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_DETALLE_ORDENES_CONSTRUMART(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_datos_para_detalle_construmart", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@sstrCadena", _strCadena))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function LPN_SELECCIONA_ASN_CONSTRUMART(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_asn_construmart", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@strCadena", _strCadena))
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function

#End Region

End Class
