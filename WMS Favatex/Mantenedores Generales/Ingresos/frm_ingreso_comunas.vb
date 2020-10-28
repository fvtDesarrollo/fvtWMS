Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class frm_ingreso_comunas
    Private _cnn As String
    Private _com_codigo As Integer
    Private _reg_nombre As String
    Private _ciu_nombre As String
    Private _com_nombre As String
    Private _cod_flete As String
    Private _zog_codigo As Integer

    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Public Property com_codigo() As Integer
        Get
            Return _com_codigo
        End Get
        Set(ByVal value As Integer)
            _com_codigo = value
        End Set
    End Property
    Public Property reg_nombre() As String
        Get
            Return _reg_nombre
        End Get
        Set(ByVal value As String)
            _reg_nombre = value
        End Set
    End Property
    Public Property ciu_nombre() As String
        Get
            Return _ciu_nombre
        End Get
        Set(ByVal value As String)
            _ciu_nombre = value
        End Set
    End Property
    Public Property com_nombre() As String
        Get
            Return _com_nombre
        End Get
        Set(ByVal value As String)
            _com_nombre = value
        End Set
    End Property
    Public Property cod_flete() As String
        Get
            Return _cod_flete
        End Get
        Set(ByVal value As String)
            _cod_flete = value
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

    Private Sub frm_ingreso_comunas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CARGA_COMBO_ZONAS()
        lblRegion.Text = _reg_nombre
        lblCiudad.Text = _ciu_nombre
        lblComuna.Text = _com_nombre
        txtFlete.Text = _cod_flete
        cmbComunas.SelectedValue = _zog_codigo
    End Sub

    Private Sub CARGA_COMBO_ZONAS()
        Dim _msg As String
        Try
            Dim classZonas As class_zonas_geograficas = New class_zonas_geograficas
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classZonas.cnn = _cnn
            _msg = ""
            ds = classZonas.carga_combo_zonas_geograficas(_msg)
            If _msg = "" Then
                Me.cmbComunas.DataSource = ds.Tables(0)
                Me.cmbComunas.DisplayMember = "MENSAJE"
                Me.cmbComunas.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_ZONAS", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub ButtonGurdar_Click(sender As Object, e As EventArgs) Handles ButtonGurdar.Click
        Call GUARDA_REGISTRO()
    End Sub

    Private Sub GUARDA_REGISTRO()
        Dim class_comunes As class_comunes = New class_comunes
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0

        Try
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                class_comunes.IdComuna = _com_codigo
                class_comunes.cod_flete = txtFlete.Text

                If cmbComunas.Text = "" Then
                    class_comunes.zog_codigo = 0
                Else
                    class_comunes.zog_codigo = cmbComunas.SelectedValue
                End If

                ds = class_comunes.comuna_guarda_registro(_msgError, conexion)
                If _msgError <> "" Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If
                    ds = Nothing
                    MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    If ds.Tables(0).Rows(0)("codigo") < 0 Then
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        ds = Nothing
                        MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing

                MessageBox.Show("Los datos fueron guardados en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Dispose()

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub
End Class