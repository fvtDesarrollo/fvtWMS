Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail
Public Class class_manager
    Private _cnn As String
    Private _codigo As String
    Private _tipo As Integer
    Private _pic_codigo As Integer
    Private _pic_fila As Integer

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
    Public Property tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
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
    Public Property pic_fila() As Integer
        Get
            Return _pic_fila
        End Get
        Set(ByVal value As Integer)
            _pic_fila = value
        End Set
    End Property
    Public Function OBTIENE_VALOR_FLETE(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_fvt_obtiene_valor_flete", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@codigo", _codigo))
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

    Public Function OBTIENE_NUMERO_VENTA(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_fvt_obtiene_documento_venta", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@tipo", _tipo))
            command.Parameters.Add(New SqlParameter("@pic_codigo", _pic_codigo))
            command.Parameters.Add(New SqlParameter("@pic_fila", _pic_fila))

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

End Class
