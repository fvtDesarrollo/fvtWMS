Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class class_motivo_cierre_guia_pallet
    Private _cnn As String
    Private _mcp_codigo As Integer
    Private _mcp_nombre As String
    Private _mcp_activo As Boolean
    Private _dep_num_guia As Long

    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Public Property mcp_codigo() As Integer
        Get
            Return _mcp_codigo
        End Get
        Set(ByVal value As Integer)
            _mcp_codigo = value
        End Set
    End Property
    Public Property mcp_nombre() As String
        Get
            Return _mcp_nombre
        End Get
        Set(ByVal value As String)
            _mcp_nombre = value
        End Set
    End Property
    Public Property mcp_activo() As Boolean
        Get
            Return _mcp_activo
        End Get
        Set(ByVal value As Boolean)
            _mcp_activo = value
        End Set
    End Property
    Public Property dep_num_guia() As Long
        Get
            Return _dep_num_guia
        End Get
        Set(ByVal value As Long)
            _dep_num_guia = value
        End Set
    End Property

    Public Function CARGA_COMBO_MOTIVO_CIERRE_GUIA_PALLET(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_despacho_embarque_pallet_motivo_cierre_carga_combo", conexion)

            command.CommandType = CommandType.StoredProcedure
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

    Public Function MOTIVO_CIERRE_GUIA_PALLET_LISTADO(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_despacho_embarque_pallet_motivo_cierre_listado", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@mcp_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _mcp_codigo

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function MOTIVO_CIERRE_GUIA_PALLET_GUARDA_REGISTRO(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            Dim command As New SqlCommand("sp_despacho_embarque_pallet_motivo_cierre_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@mcp_codigo", SqlDbType.Int)
            command.Parameters.Add("@mcp_nombre", SqlDbType.NVarChar)
            command.Parameters.Add("@mcp_activo", SqlDbType.Bit)

            command.Parameters(0).Value = _mcp_codigo
            command.Parameters(1).Value = _mcp_nombre
            command.Parameters(2).Value = _mcp_activo

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            'conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function MOTIVO_CIERRE_GUIA_PALLET_ELIMINA_REGISTRO(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)
        Try
            Dim command As New SqlCommand("sp_despacho_embarque_pallet_motivo_cierre_eliminar", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@mcp_codigo", SqlDbType.Int)
            command.Parameters(0).Value = _mcp_codigo
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function


    Public Function CIERRA_GUIA_PALLET(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_cierra_guia_pallet", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@dep_num_guia", SqlDbType.Int)
            command.Parameters.Add("@mcp_codigo", SqlDbType.NVarChar)

            command.Parameters(0).Value = _dep_num_guia
            command.Parameters(1).Value = _mcp_codigo

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)
            'conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function



End Class
