Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class frm_ajuste_ubicacion_detalle
    Private _cnn As String
    Private _codUbicacion As String
    Private _nomUbicacion As String
    Private _Pallet As String
    Private _proCodigo As Integer
    Private _codigo As String
    Private _nombreProducto As String
    Private _bulCodigo As Integer
    Private _bultoStr As String
    Private _cantidad As Integer

    Property codUbicacion() As String
        Get
            Return _codUbicacion
        End Get
        Set(ByVal value As String)
            _codUbicacion = value
        End Set
    End Property
    Property nomUbicacion() As String
        Get
            Return _nomUbicacion
        End Get
        Set(ByVal value As String)
            _nomUbicacion = value
        End Set
    End Property
    Property Pallet() As String
        Get
            Return _Pallet
        End Get
        Set(ByVal value As String)
            _Pallet = value
        End Set
    End Property
    Property proCodigo() As Integer
        Get
            Return _proCodigo
        End Get
        Set(ByVal value As Integer)
            _proCodigo = value
        End Set
    End Property
    Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property
    Property nombreProducto() As String
        Get
            Return _nombreProducto
        End Get
        Set(ByVal value As String)
            _nombreProducto = value
        End Set
    End Property
    Property bulCodigo() As Integer
        Get
            Return _bulCodigo
        End Get
        Set(ByVal value As Integer)
            _bulCodigo = value
        End Set
    End Property
    Property bultoStr() As String
        Get
            Return _bultoStr
        End Get
        Set(ByVal value As String)
            _bultoStr = value
        End Set
    End Property
    Property cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property

    Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property

    Private Sub frm_ajuste_ubicacion_detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCodigo.Text = _codigo
        lblProducto.Text = nombreProducto
        lblPallet.Text = Pallet
        lblUbicacion.Text = nomUbicacion
        lblCantidad.Text = cantidad
    End Sub

    Private Sub chkCantidad_CheckedChanged(sender As Object, e As EventArgs) Handles chkCantidad.CheckedChanged
        txtCantidad.Enabled = chkCantidad.Checked
        If chkCantidad.Checked = False Then
            txtCantidad.Text = "0"
        End If
    End Sub

    Private Sub chkMuevePallet_CheckedChanged(sender As Object, e As EventArgs) Handles chkMuevePallet.CheckedChanged
        If chkMuevePallet.Checked = True Then
            cmbPallet.Enabled = True
            chkCreaPallet.Checked = False
            'txtNuevoPallet.Enabled = False
            txtNuevoPallet.Text = ""
            btnCrear.Enabled = False
        Else
            cmbPallet.DataSource = Nothing
            cmbPallet.Items.Clear()
            cmbPallet.Enabled = False
        End If
    End Sub

    Private Sub chkCreaPallet_CheckedChanged(sender As Object, e As EventArgs) Handles chkCreaPallet.CheckedChanged
        If chkCreaPallet.Checked = True Then
            btnCrear.Enabled = True
            chkMuevePallet.Checked = False
            cmbPallet.Enabled = False
            cmbPallet.DataSource = Nothing
            cmbPallet.Items.Clear()
            cmbPallet.Enabled = False
        Else
            btnCrear.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim respuesta As Integer = 0
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()

        Dim Mensaje As String = "Acciones: " + vbCrLf

        If chkCantidad.Checked = True Then
            If txtCantidad.Text = "" Then
                MessageBox.Show("Debe ingresar una cantidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf txtCantidad.Text = 0 Or txtCantidad.Text = "0" Then
                respuesta = MessageBox.Show("Cuando la cantidad es 0 (cero) el pallet es eliminado," _
                                     + Chr(10) + "¿Desea seguir con la Object?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If respuesta = vbNo Then
                    Exit Sub
                End If
            End If
        End If

        If chkMuevePallet.Checked = True Then
            If cmbPallet.Text = "" Then
                MessageBox.Show("Debe seleccionar el pallet que desea mover", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbPallet.Focus()
                Exit Sub
            End If
        End If

        If chkCreaPallet.Checked = True Then
            If txtNuevoPallet.Text = "" Then
                MessageBox.Show("Debe ingresar los datos del pallet que desea crear", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btnCrear.Focus()
                Exit Sub
            End If
        End If

        Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
            conexion.Open()
            If chkCantidad.Checked = True Then
                If txtCantidad.Text = 0 Or txtCantidad.Text = "0" Then
                    Mensaje = Mensaje + "Se elimina pallet " + lblPallet.Text
                Else
                    Mensaje = Mensaje + "- Se cambia cantidad en pallet: " + lblPallet.Text + ", cantidad actual: " + lblCantidad.Text + ", nueva cantidad: " + txtCantidad.Text.ToString + vbCrLf
                End If
                If ACTUALIZA_CANTIDAD_PALLET(conexion) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If
                    Exit Sub
                End If
            End If

            If chkMuevePallet.Checked = True Then
                If ACTUALIZA_POSICION_PALLET(conexion) = True Then
                    Mensaje = Mensaje + "- El pallet: " + cmbPallet.Text + ", fuen enviado al PISO DE RECEPCIÓN para ser reubicado. " + vbCrLf
                Else
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If
                    Exit Sub
                End If
            End If

            If chkCreaPallet.Checked = True Then
                If CREA_PALLET(conexion) = True Then
                    Mensaje = Mensaje + "- El pallet: " + txtNuevoPallet.Text + ", fuen creado y enviado al PISO DE RECEPCIÓN para ser reubicado " + vbCrLf
                Else
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If
                    Exit Sub
                End If
            End If

            GUARDA_LOG(conexion, Mensaje)

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
            classUbicacion.codigo_interno = lblCodigo.Text
            classUbicacion.bul_codigo = _bulCodigo
            classUbicacion.bulto = _bultoStr
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


    Private Function ACTUALIZA_CANTIDAD_PALLET(ByVal conexion As SqlConnection) As Boolean
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""

        Try
            ACTUALIZA_CANTIDAD_PALLET = False
            classUbicacion.cnn = _cnn
            classUbicacion.cantidad = CInt(txtCantidad.Text)
            classUbicacion.pallet = lblPallet.Text

            ds = classUbicacion.MODIFICA_CANTIDAD_EN_PALLET(_msgError, conexion)
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
            ACTUALIZA_CANTIDAD_PALLET = True
        Catch ex As Exception
            ACTUALIZA_CANTIDAD_PALLET = False
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function ACTUALIZA_POSICION_PALLET(ByVal conexion As SqlConnection) As Boolean
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""

        Try
            ACTUALIZA_POSICION_PALLET = False
            classUbicacion.cnn = _cnn
            classUbicacion.pallet = cmbPallet.Text

            ds = classUbicacion.ACTUALIZA_POSICION_PALLET(_msgError, conexion)
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
            ACTUALIZA_POSICION_PALLET = True
        Catch ex As Exception
            ACTUALIZA_POSICION_PALLET = False
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


    Private Sub cmbPallet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPallet.SelectedIndexChanged

    End Sub

    Private Sub cmbPallet_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbPallet.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call CARGA_COMBO_PALLET()
        End If
    End Sub
    Private Sub CARGA_COMBO_PALLET()
        Dim _msg As String
        Try
            Dim classUbicacion As class_ubicaciones = New class_ubicaciones
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classUbicacion.cnn = _cnn
            classUbicacion.pallet = cmbPallet.Text.ToUpper
            _msg = ""
            ds = classUbicacion.CARGA_COMBO_PALLET_AJUSTE(_msg)
            If _msg = "" Then
                Me.cmbPallet.DataSource = ds.Tables(0)
                Me.cmbPallet.DisplayMember = "MENSAJE"
                Me.cmbPallet.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_PALLET", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        GLO_CODIGO_PRODUCTOS = 0
        GLO_NUMERO_BULTOS_PRODUCTOS = 0
        GLO_CODIGO_PALLET = "-"
        GLO_CANTIDAD_PRODUCTOS = 0

        Dim frm As frm_ing_pallet = New frm_ing_pallet
        frm.cnn = _cnn
        frm.nuevo = False
        frm.ShowDialog()

        txtNuevoPallet.Text = GLO_CODIGO_PALLET
    End Sub
End Class