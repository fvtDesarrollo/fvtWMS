Public Class frm_lpn_correlativos
    Private _cnn As String
    Private _car_codigo As Integer
    Private _car_nombre As String

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
    Public Property car_nombre() As String
        Get
            Return _car_nombre
        End Get
        Set(ByVal value As String)
            _car_nombre = value
        End Set
    End Property

    Private Sub frm_lpn_correlativos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCliente.Text = _car_nombre
        Call CARGA_REGISTRO()
    End Sub

    Private Sub CARGA_REGISTRO()
        Dim class_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim SearchChar As String = "-"
        Dim TestPos As Integer = 0
        Dim Fila As Integer = 0

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing
            class_lpn.cnn = _cnn
            class_lpn.car_codigo = _car_codigo
            _msg = ""
            ds = class_lpn.LPN_SELECCIONA_DATOS(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("lpn_prefijo") <> "" Then
                        txtCliente.Text = _car_nombre
                        txtPrefijo.Text = ds.Tables(0).Rows(Fila)("lpn_prefijo")
                        txtUltimoImpreso.Text = ds.Tables(0).Rows(Fila)("lpn_ultimocorrimpreso")
                        txtSiguiente.Text = CARGA_LPN_SIGUIENTE()
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\CARGA_REGISTRO", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_REGISTRO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Function CARGA_LPN_SIGUIENTE() As String
        Dim class_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim SearchChar As String = "-"
        Dim TestPos As Integer = 0
        Dim Fila As Integer = 0
        CARGA_LPN_SIGUIENTE = ""
        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing
            class_lpn.cnn = _cnn
            class_lpn.car_codigo = _car_codigo
            _msg = ""
            ds = class_lpn.LPN_SELECCIONA_SIGUIENTE(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("correlativoS") <> "" Then
                        CARGA_LPN_SIGUIENTE = ds.Tables(0).Rows(Fila)("correlativoS")
                    End If
                End If
            Else

                MessageBox.Show(_msg + "\CARGA_LPN_SIGUIENTE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            CARGA_LPN_SIGUIENTE = ""
            MsgBox(ex.Message + " " + "CARGA_LPN_SIGUIENTE", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Function

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If valida_form() = False Then
            Exit Sub
        End If

        Call GUARDA_REGISTRO()
    End Sub

    Private Sub GUARDA_REGISTRO()
        Dim class_etiqueta_lpn As class_etiqueta_lpn = New class_etiqueta_lpn
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0

        Try
            class_etiqueta_lpn.cnn = _cnn
            class_etiqueta_lpn.car_codigo = _car_codigo
            class_etiqueta_lpn.lpn_prefijo = txtPrefijo.Text
            class_etiqueta_lpn.lpn_ultimocorrimpreso = txtUltimoImpreso.Text

            ds = class_etiqueta_lpn.GUARDA_DATOS_LPN(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("codigo") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If


            ds = Nothing

            Call CARGA_REGISTRO()
            respuesta = MessageBox.Show("Los datos fueron guardados en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function valida_form()
        valida_form = False

        If Trim(txtUltimoImpreso.Text) = "" Then
            MessageBox.Show("Debe ingresar ultimo correlativo impreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUltimoImpreso.Focus()
            Exit Function
        End If

        valida_form = True

    End Function


End Class