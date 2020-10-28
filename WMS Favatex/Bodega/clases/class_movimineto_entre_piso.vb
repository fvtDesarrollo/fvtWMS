Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class class_movimineto_entre_piso
    Private _cnn As String
    Private _bod_codigo As Integer
    Private _ubi_codigo As Integer
    Private _codigo As String
    Private _nombre As String
    Private _pro_codigo As Integer
    Private _bul_codigo As Integer
    Private _cantidad As Integer
    Private _fila As Integer
    Private _palletOrigen As String

    Private _omo_codigo As Integer
    Private _ode_fila As Integer
    Private _ode_palletorigen As String
    Private _ode_pallet As String
    Private _pro_codigointerno As String
    Private _pro_nombre As String
    Private _ode_bulto As String
    Private _ode_cantidad As Integer
    Private _ubi_nombre As String

    Private _usu_codigo As Integer
    Private _omo_fechadocto As Date
    Private _eom_codigo As Integer
    Private _omo_valemanager As Long
    Private _bod_codigoorigen As Integer
    Private _ubi_codigoorigen As Integer
    Private _bod_codigodestino As Integer
    Private _ubi_codigodestino As Integer

    Private _emo_codigo As Integer
    Private _fecha_desde As String
    Private _fecha_hasta As String

    Private _Listado As Boolean
    Private _paraUbicacionPK As Boolean

    Private _zon_codigo As Integer
    Private _alt_codigo As Integer

    Public Property zon_codigo() As Integer
        Get
            Return _zon_codigo
        End Get
        Set(ByVal value As Integer)
            _zon_codigo = value
        End Set
    End Property

    Public Property alt_codigo() As Integer
        Get
            Return _alt_codigo
        End Get
        Set(ByVal value As Integer)
            _alt_codigo = value
        End Set
    End Property

    Public Property paraUbicacionPK() As Boolean
        Get
            Return _paraUbicacionPK
        End Get
        Set(ByVal value As Boolean)
            _paraUbicacionPK = value
        End Set
    End Property
    Public Property Listado() As Integer
        Get
            Return _Listado
        End Get
        Set(ByVal value As Integer)
            _Listado = value
        End Set
    End Property

    Public Property emo_codigo() As Integer
        Get
            Return _emo_codigo
        End Get
        Set(ByVal value As Integer)
            _emo_codigo = value
        End Set
    End Property
    Public Property fecha_desde() As String
        Get
            Return _fecha_desde
        End Get
        Set(ByVal value As String)
            _fecha_desde = value
        End Set
    End Property
    Public Property fecha_hasta() As String
        Get
            Return _fecha_hasta
        End Get
        Set(ByVal value As String)
            _fecha_hasta = value
        End Set
    End Property


    Public Property usu_codigo() As Integer
        Get
            Return _usu_codigo
        End Get
        Set(ByVal value As Integer)
            _usu_codigo = value
        End Set
    End Property
    Public Property omo_fechadocto() As Date
        Get
            Return _omo_fechadocto
        End Get
        Set(ByVal value As Date)
            _omo_fechadocto = value
        End Set
    End Property
    Public Property eom_codigo() As Integer
        Get
            Return _eom_codigo
        End Get
        Set(ByVal value As Integer)
            _eom_codigo = value
        End Set
    End Property
    Public Property omo_valemanager() As Long
        Get
            Return _omo_valemanager
        End Get
        Set(ByVal value As Long)
            _omo_valemanager = value
        End Set
    End Property
    Public Property bod_codigoorigen() As Integer
        Get
            Return _bod_codigoorigen
        End Get
        Set(ByVal value As Integer)
            _bod_codigoorigen = value
        End Set
    End Property
    Public Property ubi_codigoorigen() As Integer
        Get
            Return _ubi_codigoorigen
        End Get
        Set(ByVal value As Integer)
            _ubi_codigoorigen = value
        End Set
    End Property
    Public Property bod_codigodestino() As Integer
        Get
            Return _bod_codigodestino
        End Get
        Set(ByVal value As Integer)
            _bod_codigodestino = value
        End Set
    End Property
    Public Property ubi_codigodestino() As Integer
        Get
            Return _ubi_codigodestino
        End Get
        Set(ByVal value As Integer)
            _ubi_codigodestino = value
        End Set
    End Property

    Public Property omo_codigo() As Integer
        Get
            Return _omo_codigo
        End Get
        Set(ByVal value As Integer)
            _omo_codigo = value
        End Set
    End Property
    Public Property ode_fila() As Integer
        Get
            Return _ode_fila
        End Get
        Set(ByVal value As Integer)
            _ode_fila = value
        End Set
    End Property
    Public Property ode_palletorigen() As String
        Get
            Return _ode_palletorigen
        End Get
        Set(ByVal value As String)
            _ode_palletorigen = value
        End Set
    End Property
    Public Property ode_pallet() As String
        Get
            Return _ode_pallet
        End Get
        Set(ByVal value As String)
            _ode_pallet = value
        End Set
    End Property
    Public Property pro_codigointerno() As String
        Get
            Return _pro_codigointerno
        End Get
        Set(ByVal value As String)
            _pro_codigointerno = value
        End Set
    End Property
    Public Property pro_nombre() As String
        Get
            Return _pro_nombre
        End Get
        Set(ByVal value As String)
            _pro_nombre = value
        End Set
    End Property
    Public Property ode_bulto() As String
        Get
            Return _ode_bulto
        End Get
        Set(ByVal value As String)
            _ode_bulto = value
        End Set
    End Property
    Public Property ode_cantidad() As Integer
        Get
            Return _ode_cantidad
        End Get
        Set(ByVal value As Integer)
            _ode_cantidad = value
        End Set
    End Property
    Public Property ubi_nombre() As String
        Get
            Return _ubi_nombre
        End Get
        Set(ByVal value As String)
            _ubi_nombre = value
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
    Public Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Public Property bod_codigo() As Integer
        Get
            Return _bod_codigo
        End Get
        Set(ByVal value As Integer)
            _bod_codigo = value
        End Set
    End Property
    Public Property ubi_codigo() As Integer
        Get
            Return _ubi_codigo
        End Get
        Set(ByVal value As Integer)
            _ubi_codigo = value
        End Set
    End Property
    Public Property pro_codigo() As Integer
        Get
            Return _pro_codigo
        End Get
        Set(ByVal value As Integer)
            _pro_codigo = value
        End Set
    End Property
    Public Property bul_codigo() As Integer
        Get
            Return _bul_codigo
        End Get
        Set(ByVal value As Integer)
            _bul_codigo = value
        End Set
    End Property
    Public Property cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property
    Public Property fila() As Integer
        Get
            Return _fila
        End Get
        Set(ByVal value As Integer)
            _fila = value
        End Set
    End Property
    Public Property palletOrigen() As String
        Get
            Return _palletOrigen
        End Get
        Set(ByVal value As String)
            _palletOrigen = value
        End Set
    End Property
    Public Function CARGA_COMBO_ORIGEN(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_bodega_origen_carga_combo", conexion)
            command.CommandType = CommandType.StoredProcedure

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

    Public Function CARGA_UBICACION_ORIGEN(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_piso_origen_carga_combo", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@bod_codigo", SqlDbType.Int)
            command.Parameters(0).Value = _bod_codigo

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function CARGA_UBICACION_DESTINO(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_piso_destino_carga_combo", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@bod_codigo", SqlDbType.Int)
            command.Parameters.Add("@ubi_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _bod_codigo
            command.Parameters(1).Value = _ubi_codigo

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function CARGA_PRODUCTO_ORIGEN(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_lista_producto_origen", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@ubi_codigo", SqlDbType.Int)
            command.Parameters.Add("@codigo", SqlDbType.NVarChar)
            command.Parameters.Add("@nombre", SqlDbType.NVarChar)
            command.Parameters.Add("@paraUbicacionPK", SqlDbType.Bit)

            command.Parameters(0).Value = ubi_codigo
            command.Parameters(1).Value = _codigo
            command.Parameters(2).Value = _nombre
            command.Parameters(3).Value = _paraUbicacionPK

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function CARGA_PRODUCTO_ORIGEN_DESDE_RACK(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_carga_producto_desde_rack_listado", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@zon_codigo", SqlDbType.Int)
            command.Parameters.Add("@alt_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _zon_codigo
            command.Parameters(1).Value = _alt_codigo


            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function CARGA_GRILLA_PARA_ALMACENAR_EN_RACK(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_paletiza_movimiento_piso", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@fila", SqlDbType.Int)
            command.Parameters.Add("@pro_codigo", SqlDbType.Int)
            command.Parameters.Add("@bul_codigo", SqlDbType.Int)
            command.Parameters.Add("@cantidad", SqlDbType.Int)
            command.Parameters.Add("@palletOrigen", SqlDbType.NVarChar)

            command.Parameters(0).Value = _fila
            command.Parameters(1).Value = _pro_codigo
            command.Parameters(2).Value = _bul_codigo
            command.Parameters(3).Value = _cantidad
            command.Parameters(4).Value = _palletOrigen

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function CARGA_GRILLA_PARA_ALMACENAR_EN_UBICACION_PK(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_ubicacion_pk_movimiento_piso", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@fila", SqlDbType.Int)
            command.Parameters.Add("@pro_codigo", SqlDbType.Int)
            command.Parameters.Add("@bul_codigo", SqlDbType.Int)
            command.Parameters.Add("@cantidad", SqlDbType.Int)
            command.Parameters.Add("@palletOrigen", SqlDbType.NVarChar)

            command.Parameters(0).Value = _fila
            command.Parameters(1).Value = _pro_codigo
            command.Parameters(2).Value = _bul_codigo
            command.Parameters(3).Value = _cantidad
            command.Parameters(4).Value = _palletOrigen

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function CARGA_GRILLA_PARA_ALMACENAR_EN_UBICACION_PISO(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_ubicacion_piso_movimiento_piso", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@fila", SqlDbType.Int)
            command.Parameters.Add("@pro_codigo", SqlDbType.Int)
            command.Parameters.Add("@bul_codigo", SqlDbType.Int)
            command.Parameters.Add("@cantidad", SqlDbType.Int)
            command.Parameters.Add("@palletOrigen", SqlDbType.NVarChar)
            command.Parameters.Add("@codUbicacionDestino", SqlDbType.Int)

            command.Parameters(0).Value = _fila
            command.Parameters(1).Value = _pro_codigo
            command.Parameters(2).Value = _bul_codigo
            command.Parameters(3).Value = _cantidad
            command.Parameters(4).Value = _palletOrigen
            command.Parameters(5).Value = _ubi_codigodestino

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function


    Public Function GUARDA_ORDEN_MOVIMIENTO_ENCABEZADO(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            Dim command As New SqlCommand("sp_orden_movimineto_encabezado_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@omo_codigo", SqlDbType.Int)
            command.Parameters.Add("@usu_codigo", SqlDbType.Int)
            command.Parameters.Add("@omo_fechadocto", SqlDbType.Date)
            command.Parameters.Add("@eom_codigo", SqlDbType.Int)
            command.Parameters.Add("@omo_valemanager", SqlDbType.Float)
            command.Parameters.Add("@bod_codigoorigen", SqlDbType.Int)
            command.Parameters.Add("@ubi_codigoorigen", SqlDbType.Int)
            command.Parameters.Add("@bod_codigodestino", SqlDbType.Int)
            command.Parameters.Add("@ubi_codigodestino", SqlDbType.Int)

            command.Parameters(0).Value = _omo_codigo
            command.Parameters(1).Value = _usu_codigo
            command.Parameters(2).Value = _omo_fechadocto
            command.Parameters(3).Value = _eom_codigo
            command.Parameters(4).Value = _omo_valemanager
            command.Parameters(5).Value = _bod_codigoorigen
            command.Parameters(6).Value = _ubi_codigoorigen
            command.Parameters(7).Value = _bod_codigodestino
            command.Parameters(8).Value = _ubi_codigodestino

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function GUARDA_ORDEN_MOVIMIENTO_DETALLE(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            Dim command As New SqlCommand("sp_orden_movimineto_detalle_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@omo_codigo", SqlDbType.Int)
            command.Parameters.Add("@ode_fila", SqlDbType.Int)
            command.Parameters.Add("@pro_codigo", SqlDbType.Int)
            command.Parameters.Add("@ode_palletorigen", SqlDbType.NVarChar)
            command.Parameters.Add("@ode_pallet", SqlDbType.NVarChar)
            command.Parameters.Add("@pro_codigointerno", SqlDbType.NVarChar)
            command.Parameters.Add("@pro_nombre", SqlDbType.NVarChar)
            command.Parameters.Add("@bul_codigo", SqlDbType.Int)
            command.Parameters.Add("@ode_bulto", SqlDbType.NVarChar)
            command.Parameters.Add("@ode_cantidad", SqlDbType.Int)
            command.Parameters.Add("@ubi_codigo", SqlDbType.Int)
            command.Parameters.Add("@ubi_nombre", SqlDbType.NVarChar)

            command.Parameters(0).Value = _omo_codigo
            command.Parameters(1).Value = _ode_fila
            command.Parameters(2).Value = _pro_codigo
            command.Parameters(3).Value = _ode_palletorigen
            command.Parameters(4).Value = _ode_pallet
            command.Parameters(5).Value = _pro_codigointerno
            command.Parameters(6).Value = _pro_nombre
            command.Parameters(7).Value = _bul_codigo
            command.Parameters(8).Value = _ode_bulto
            command.Parameters(9).Value = _ode_cantidad
            command.Parameters(10).Value = _ubi_codigo
            command.Parameters(11).Value = _ubi_nombre

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function CARGA_COMBO_ORDEN_MOVIMIENTO_ESTADO(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_orden_movimiento_estado_carga_combo", conexion)
            command.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ORDEN_MOVIMIENTO_RESPONSABLE_GUARDAR(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            'Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_orden_movimiento_responsable_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@omo_codigo", SqlDbType.Int)
            command.Parameters.Add("@usu_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _omo_codigo
            command.Parameters(1).Value = _usu_codigo

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

    Public Function ORDEN_MOVIMIENTO_RESPONSABLE_ELIMINA(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            Dim command As New SqlCommand("sp_orden_movimiento_responsable_elimina", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@omo_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _omo_codigo

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ORDEN_MOVIMIENTO_RESPONSABLE_BUSCAR(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_orden_movimiento_responsable_buscar", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@omo_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _omo_codigo

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function RESPONSABLE_MOVIMIENTO_CARGA_COMBO(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_usuarios_responsable_movimiento_carga_combo", conexion)
            command.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function ORDEN_MOVIMIENTO_LISTAR(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_orden_movimiento_listar", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@omo_codigo", SqlDbType.Int)
            command.Parameters.Add("@emo_codigo", SqlDbType.Int)
            command.Parameters.Add("@fecha_desde", SqlDbType.NVarChar)
            command.Parameters.Add("@fecha_hasta", SqlDbType.NVarChar)
            command.Parameters.Add("@bod_codigoorigen", SqlDbType.Int)
            command.Parameters.Add("@ubi_codigoorigen", SqlDbType.Int)
            command.Parameters.Add("@bod_codigodestino", SqlDbType.Int)
            command.Parameters.Add("@ubi_codigodestino", SqlDbType.Int)
            command.Parameters.Add("@Listado", SqlDbType.Bit)

            command.Parameters(0).Value = _omo_codigo
            command.Parameters(1).Value = _emo_codigo
            command.Parameters(2).Value = _fecha_desde
            command.Parameters(3).Value = _fecha_hasta
            command.Parameters(4).Value = _bod_codigoorigen
            command.Parameters(5).Value = _ubi_codigoorigen
            command.Parameters(6).Value = _bod_codigodestino
            command.Parameters(7).Value = _ubi_codigodestino
            command.Parameters(8).Value = _Listado

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

    Public Function ORDEN_MOVIMIENTO_CAMBIA_ESTADO(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            'Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_orden_movimineto_cambia_estado", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@omo_codigo", SqlDbType.Int)
            command.Parameters.Add("@eom_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _omo_codigo
            command.Parameters(1).Value = _eom_codigo

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

    Public Function GUARDA_NUM_VALE_MANAGER_OM(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_guarda_num_vale_manager_om", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@omo_codigo", SqlDbType.Int)
            command.Parameters.Add("@numeroVale", SqlDbType.Int)

            command.Parameters(0).Value = _omo_codigo
            command.Parameters(1).Value = _omo_valemanager

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

End Class
