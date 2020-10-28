Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class class_zonas_geograficas
    Private _cnn As String
    Private _zog_codigo As Integer
    Private _zog_nombre As String
    Private _zog_activa As Boolean

    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Public Property zog_codigo() As Integer
        Get
            Return _zog_codigo
        End Get
        Set(ByVal value As Integer)
            _zog_codigo = value
        End Set
    End Property
    Public Property zog_nombre() As String
        Get
            Return _zog_nombre
        End Get
        Set(ByVal value As String)
            _zog_nombre = value
        End Set
    End Property
    Public Property zog_activa() As Boolean
        Get
            Return _zog_activa
        End Get
        Set(ByVal value As Boolean)
            _zog_activa = value
        End Set
    End Property

    Public Function carga_combo_zonas_geograficas(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_zonas_geografica_carga_combo", conexion)

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

    Public Function zonas_geograficas_listado(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_zonas_geografica_listado", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@zog_codigo", SqlDbType.Int)
            command.Parameters(0).Value = _zog_codigo

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function zonas_geograficas_guarda_registro(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            Dim command As New SqlCommand("sp_zonas_geografica_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@zog_codigo", SqlDbType.Int)
            command.Parameters.Add("@zog_nombre", SqlDbType.NVarChar)
            command.Parameters.Add("@zog_activa", SqlDbType.Bit)

            command.Parameters(0).Value = _zog_codigo
            command.Parameters(1).Value = _zog_nombre
            command.Parameters(2).Value = _zog_activa

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

    Public Function zonas_geograficas_elimina_registro(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)
        Try
            Dim command As New SqlCommand("sp_zonas_geografica_eliminar", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@zog_codigo", SqlDbType.Int)
            command.Parameters(0).Value = _zog_codigo
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
