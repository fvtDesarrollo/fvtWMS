Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Threading
Public Class frm_ing_pallet
    Dim _cnn As String
    Dim _tipoPallet As String
    Dim _pro_codigo As Integer = 0
    Dim _nuevo As Boolean = 0
    Dim _strBulto As String = ""


    Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property

    Property nuevo() As Boolean
        Get
            Return _nuevo
        End Get
        Set(ByVal value As Boolean)
            _nuevo = value
        End Set
    End Property

    Private Sub cmbBulto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBulto.SelectedIndexChanged

    End Sub

    Private Sub cmbBulto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbBulto.SelectionChangeCommitted

        If txtCodigo.Text = "" Then
            MessageBox.Show("Debe ingresar el código de producto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodigo.Focus()
            Exit Sub
        End If

        If cmbBulto.Text <> "" Then
            Call CARGA_DATOS_PRODUCTO()
        End If
    End Sub

    Private Sub CARGA_DATOS_PRODUCTO()
        Dim class_producto As class_producto = New class_producto
        Dim SearchChar As String = "-"
        Dim TestPos As Integer = 0
        Dim Fila As Integer = 0
        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing
            class_producto.cnn = _cnn
            class_producto.codigo_interno = IIf(txtCodigo.Text = "", "-", txtCodigo.Text)
            class_producto.bul_codigo = cmbBulto.SelectedValue
            _msg = ""
            ds = class_producto.OBTIENE_PRODUCTO_PARA_CREACION_PALLET(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("pro_nombre") <> "" Then
                        lblProducto.Text = ds.Tables(0).Rows(Fila)("pro_nombre")
                        _tipoPallet = ds.Tables(0).Rows(Fila)("bul_tipobulto")
                        _strBulto = ds.Tables(0).Rows(Fila)("pro_numerobulto")
                        _pro_codigo = ds.Tables(0).Rows(Fila)("pro_codigo")
                        If _tipoPallet = "E" Then
                            lblTipoPallet.Text = "Pallet Estandar"
                            lblPallet.Text = "PE" + ds.Tables(0).Rows(Fila)("numPallet").ToString().PadLeft(21, "0")
                        ElseIf _tipoPallet = "D" Then
                            lblTipoPallet.Text = "Pallet Doble"
                            lblPallet.Text = "PD" + ds.Tables(0).Rows(Fila)("numPallet").ToString().PadLeft(21, "0")
                        End If
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\CARGA_DATOS_PRODUCTO", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_DATOS_PRODUCTO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs) Handles txtCodigo.LostFocus
        Call CARGA_COMBO_BULTO()
    End Sub

    Private Sub CARGA_COMBO_BULTO()
        Dim _msg As String
        Try
            Dim classProducto As class_producto = New class_producto
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classProducto.cnn = _cnn

            _msg = ""
            classProducto.codigo_interno = txtCodigo.Text
            ds = classProducto.CARGA_COMBO_BULTOS(_msg)
            If _msg = "" Then
                Me.cmbBulto.DataSource = ds.Tables(0)
                Me.cmbBulto.DisplayMember = "MENSAJE"
                Me.cmbBulto.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_BULTO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        'Dim Texto As String = ""
        'If Convert.ToInt32(e.KeyChar) = Convert.ToInt32(Keys.Enter) Then
        '    Call CARGA_COMBO_BULTO()
        '    Texto = Trim(Replace(txtCodigo.Text, vbCrLf, ""))
        '    txtCodigo.Text = ""
        '    txtCodigo.Text = Replace(Texto, vbCrLf, "")
        '    cmbBulto.Focus()
        'End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If nuevo = False Then
            GLO_CODIGO_PRODUCTOS = _pro_codigo
            GLO_NUMERO_BULTOS_PRODUCTOS = cmbBulto.SelectedValue
            GLO_CODIGO_PALLET = lblPallet.Text
            GLO_CANTIDAD_PRODUCTOS = txtCantidad.Text
            Me.Dispose()
        Else
            Call GUARDA_REGISTRO()
        End If
    End Sub

    Public Sub GUARDA_REGISTRO()
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()

        Dim Mensaje As String = "Acciones: " + vbCrLf

        If lblProducto.Text = "" Then
            MessageBox.Show("Debe seleccionar un producto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodigo.Focus()
            Exit Sub
        End If

        If txtCantidad.Text = "0" Or txtCantidad.Text = "" Then
            MessageBox.Show("Debe ingresar una cantidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCantidad.Focus()
            Exit Sub
        End If

        GLO_CODIGO_PRODUCTOS = _pro_codigo
        GLO_NUMERO_BULTOS_PRODUCTOS = cmbBulto.SelectedValue
        GLO_CODIGO_PALLET = lblPallet.Text
        GLO_CANTIDAD_PRODUCTOS = txtCantidad.Text

        Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
            conexion.Open()
            If _nuevo = False Then
                Me.Dispose()
            Else
                If GLO_CODIGO_PALLET <> "-" Then
                    If CREA_PALLET(conexion) = True Then
                        Mensaje = Mensaje + "El Pallet" + lblPallet.Text + " fue ingresado en forma correcta!"
                        'MessageBox.Show("El Pallet fue ingresado en forma correcta!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GUARDA_LOG(conexion, Mensaje)
                    Else
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        Exit Sub
                    End If
                End If
            End If

            Transaccion.Complete()
            Transaccion.Dispose()
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If

            If Mensaje <> "Acciones: " Then
                MessageBox.Show(Mensaje, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If

        End Using
    End Sub

    Private Function GUARDA_LOG(ByVal conexion As SqlConnection, ByVal Accion As String) As Boolean
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""

        Try
            GUARDA_LOG = False
            classUbicacion.usu_codigo = GLO_USUARIO_ACTUAL
            classUbicacion.logAccion = Accion
            classUbicacion.codigo_interno = txtCodigo.Text
            classUbicacion.bul_codigo = cmbBulto.SelectedValue
            classUbicacion.bulto = cmbBulto.Text + "/" + _strBulto
            ds = classUbicacion.INGRESA_LOG_AJUSTE_UBICACION(_msgError, conexion)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            Else
                If ds.Tables(0).Rows(0)("codigo") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If
            End If
            ds = Nothing
            GUARDA_LOG = True
        Catch ex As Exception
            GUARDA_LOG = False
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Function CREA_PALLET(ByVal conexion As SqlConnection) As Boolean
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""

        Try
            CREA_PALLET = False
            classUbicacion.cnn = _cnn
            classUbicacion.pro_codigo = GLO_CODIGO_PRODUCTOS
            classUbicacion.bul_codigo = GLO_NUMERO_BULTOS_PRODUCTOS
            classUbicacion.pallet = GLO_CODIGO_PALLET
            classUbicacion.cantidad = GLO_CANTIDAD_PRODUCTOS

            ds = classUbicacion.CREA_PALLET(_msgError, conexion)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            Else
                If ds.Tables(0).Rows(0)("codigo") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If
            End If
            ds = Nothing
            CREA_PALLET = True
        Catch ex As Exception
            CREA_PALLET = False
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub frm_ing_pallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class