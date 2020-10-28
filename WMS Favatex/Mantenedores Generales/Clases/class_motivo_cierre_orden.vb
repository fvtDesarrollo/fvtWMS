Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class class_motivo_cierre_orden
    Private _cnn As String
    Private _tdp_codigo As Integer
    Private _tdp_nombre As String
    Private _tdp_activaorden As Boolean
    Private _tdp_eliminado As Boolean

    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Public Property tdp_codigo() As Integer
        Get
            Return _tdp_codigo
        End Get
        Set(ByVal value As Integer)
            _tdp_codigo = value
        End Set
    End Property
    Public Property tdp_nombre() As String
        Get
            Return _tdp_nombre
        End Get
        Set(ByVal value As String)
            _tdp_nombre = value
        End Set
    End Property
    Public Property tdp_activaorden() As Boolean
        Get
            Return _tdp_activaorden
        End Get
        Set(ByVal value As Boolean)
            _tdp_activaorden = value
        End Set
    End Property
    Public Property tdp_eliminado() As Boolean
        Get
            Return _tdp_eliminado
        End Get
        Set(ByVal value As Boolean)
            _tdp_eliminado = value
        End Set
    End Property

    Public Function MOTIVO_CIERRE_LISTAR(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_motivo_cierre_oc_listado", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add("@tdp_codigo", SqlDbType.Int)
            command.Parameters(0).Value = _tdp_codigo
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

    Public Function MOTIVO_CIERRE_GUARDAR(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            Dim command As New SqlCommand("sp_motivo_cierre_oc_guarda", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@tdp_codigo", SqlDbType.Int)
            command.Parameters.Add("@tdp_nombre", SqlDbType.NVarChar)
            command.Parameters.Add("@tdp_activaorden", SqlDbType.Bit)

            command.Parameters(0).Value = _tdp_codigo
            command.Parameters(1).Value = _tdp_nombre
            command.Parameters(2).Value = _tdp_activaorden


            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function MOTIVO_CIERRE_ELIMINA(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)
        Try
            Dim command As New SqlCommand("sp_motivo_cierre_oc_eliminar", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@tdp_codigo", SqlDbType.Int)
            command.Parameters(0).Value = _tdp_codigo

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

End Class
