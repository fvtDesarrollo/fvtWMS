Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Threading
Public Class frm_movimiento_de_pallet
    Private _cnn As String
    Private _bod_codigo As Integer
    Private _ubi_codigo As Integer
    Private _ubicacion_actual As String
    Private _ubicacion2 As Integer
    Private _procedencia As String
    Private _palletRequerido As String
    Private _cantidadPallet As Integer
    Private _pro_codigo As Integer
    Private _cod_bulto As Integer


    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
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
    Public Property ubicacion_actual() As String
        Get
            Return _ubicacion_actual
        End Get
        Set(ByVal value As String)
            _ubicacion_actual = value
        End Set
    End Property
    Public Property procedencia() As String
        Get
            Return _procedencia
        End Get
        Set(ByVal value As String)
            _procedencia = value
        End Set
    End Property
    Public Property palletRequerido() As String
        Get
            Return _palletRequerido
        End Get
        Set(ByVal value As String)
            _palletRequerido = value
        End Set
    End Property
    Public Property cantidadPallet() As Integer
        Get
            Return _cantidadPallet
        End Get
        Set(ByVal value As Integer)
            _cantidadPallet = value
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
    Public Property cod_bulto() As Integer
        Get
            Return _cod_bulto
        End Get
        Set(ByVal value As Integer)
            _cod_bulto = value
        End Set
    End Property

    Private Sub frm_movimiento_de_pallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim class_ubicaciones As class_ubicaciones = New class_ubicaciones
        Dim ds As DataSet = New DataSet
        ds = Nothing
        Call CARGA_COMBO_BODEGAS()

        If _procedencia = "PIK" Then
            chkUbicacionVacia.Visible = True
            chkMantener.Visible = False
        Else
            chkUbicacionVacia.Visible = False
            chkMantener.Visible = True
        End If

        lblCodigo.Text = ""
        lblNombre.Text = ""
        lblBultoCantidad.Text = ""

        lblCodigo2.Text = ""
        lblNombre2.Text = ""
        lblBultoCantidad2.Text = ""

        lblUbicacionActual.Text = _ubicacion_actual
        cmbPallet2.Enabled = False
        If _ubicacion_actual.Length > 5 And _ubicacion_actual.Length <= 11 Then
            '_ubicacion2 = CInt(Mid(_ubicacion_actual, 7, 5))
            _ubicacion2 = OBTIENE_CODIGO_UBICACION_2(Mid(_ubicacion_actual, 7, 5))
            cmbPallet2.Enabled = True
        End If

        If _bod_codigo > 0 Then
            cbmBodegas.SelectedValue = _bod_codigo
            Call CARGA_COMBO_UBICACIONES()
            If _ubi_codigo > 0 Then
                cmbUbicacion.SelectedValue = _ubi_codigo
            End If
        End If
    End Sub

    Private Function OBTIENE_CODIGO_UBICACION_2(ByVal nomUbicacion As String) As Integer
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim Fila As Integer = 0
        Try
            OBTIENE_CODIGO_UBICACION_2 = 0
            classUbicacion.cnn = _cnn
            classUbicacion.ubi_nombre = nomUbicacion

            ds = classUbicacion.OBTIENE_CODIGO_UBICACION(_msgError)
            If _msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("ubi_nombre") <> "" Then
                        OBTIENE_CODIGO_UBICACION_2 = ds.Tables(0).Rows(Fila)("ubi_codigo")
                    End If
                End If
            Else
                MessageBox.Show(_msgError + "\OBTIENE_CODIGO_UBICACION_2", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            OBTIENE_CODIGO_UBICACION_2 = 0
            MessageBox.Show(ex.Message + "\OBTIENE_CODIGO_UBICACION_2", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub CARGA_COMBO_BODEGAS()
        Dim _msg As String
        Try
            Dim class_bodegas_tipo_ubicacion As class_bodegas = New class_bodegas
            Dim ds As DataSet = New DataSet
            ds = Nothing
            cbmBodegas.DisplayMember = ""
            cbmBodegas.ValueMember = "0"
            class_bodegas_tipo_ubicacion.cnn = _cnn
            _msg = ""
            ds = class_bodegas_tipo_ubicacion.BODEGA_CARGA_COMBO(_msg)
            If _msg = "" Then
                cbmBodegas.DataSource = ds.Tables(0)
                cbmBodegas.DisplayMember = "mensaje"
                cbmBodegas.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "carga bodegas", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_COMBO_UBICACIONES()
        Dim _msg As String
        Try
            Dim class_ubicaciones As class_ubicaciones = New class_ubicaciones
            Dim ds As DataSet = New DataSet
            ds = Nothing
            cmbUbicacion.DisplayMember = ""
            cmbUbicacion.ValueMember = "0"
            class_ubicaciones.cnn = _cnn
            class_ubicaciones.bod_codigo = cbmBodegas.SelectedValue
            _msg = ""
            ds = class_ubicaciones.CARGA_COMBO_UBICACIONES(_msg)
            If _msg = "" Then
                cmbUbicacion.DataSource = ds.Tables(0)
                cmbUbicacion.DisplayMember = "mensaje"
                cmbUbicacion.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "carga bodegas", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbPallet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPallet.SelectedIndexChanged
        Call CARGA_DATOS_PALLET()
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
            ds = classUbicacion.BUSCA_PALLET_POR_TEXTO(_msg)
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

    Private Sub CARGA_COMBO_PALLET2()
        Dim _msg As String
        Try
            Dim classUbicacion As class_ubicaciones = New class_ubicaciones
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classUbicacion.cnn = _cnn
            classUbicacion.pallet = cmbPallet.Text.ToUpper
            classUbicacion.pallet2 = cmbPallet.Text.ToUpper
            _msg = ""
            ds = classUbicacion.BUSCA_PALLET_POR_TEXTO(_msg)
            If _msg = "" Then
                Me.cmbPallet2.DataSource = ds.Tables(0)
                Me.cmbPallet2.DisplayMember = "MENSAJE"
                Me.cmbPallet2.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_PALLET", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_DATOS_PALLET()
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim Fila As Integer = 0
        Try
            classUbicacion.cnn = _cnn
            classUbicacion.pallet = cmbPallet.Text.ToUpper

            lblCodigo.Text = ""
            lblNombre.Text = ""
            lblBultoCantidad.Text = ""

            ds = classUbicacion.BUSCA_PALLET_DESCRIPCION(_msgError)
            If _msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("codigo") <> "" Then
                        lblCodigo.Text = ds.Tables(0).Rows(Fila)("codigo")
                        lblNombre.Text = ds.Tables(0).Rows(Fila)("producto")
                        lblBultoCantidad.Text = ds.Tables(0).Rows(Fila)("descripcion")
                    End If
                End If
            Else
                MessageBox.Show(_msgError + "\CARGA_DATOS_PALLET", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + "\CARGA_DATOS_PALLET", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPallet_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbPallet.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call CARGA_COMBO_PALLET()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim CantidadMover As Integer = 0
        Dim palletEncontrado1 As String = "-"
        Dim palletEncontrado2 As String = "-"

        If chkMantener.Checked = True Then
            GLO_ACCION_EJECUTADA = True
            Me.Dispose()
        Else
            If _procedencia = "PIK" Then
                If chkUbicacionVacia.Checked = False Then
                    GLO_PALLET_1 = IIf(cmbPallet.Text = "", "-", cmbPallet.Text)
                    GLO_PALLET_2 = IIf(cmbPallet2.Text = "", "-", cmbPallet2.Text)

                    ''CantidadMover = MOVIMIENTO_PALLET_DESDE_PK("-", "-")

                    'palletEncontrado1 = IIf(cmbPallet.Text = "", "-", cmbPallet.Text)
                    'palletEncontrado2 = IIf(cmbPallet2.Text = "", "-", cmbPallet2.Text)
                    'CantidadMover = MOVIMIENTO_PALLET_DESDE_PK(palletEncontrado1, palletEncontrado2)
                End If
                ''If CantidadMover > 0 Then
                ''If GUARDA_MOVIMIENTO(CantidadMover) = True Then
                MessageBox.Show("La ubicación fue disponibilizada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GLO_ACCION_EJECUTADA = True
                    GLO_MUEVE_PALLET_PRODUCTO_EXTRAVIADO = True
                    Me.Dispose()
                ''End If
                ''End If
            ElseIf _procedencia = "ABA" Then
                palletEncontrado1 = IIf(cmbPallet.Text = "", "-", cmbPallet.Text)
                palletEncontrado2 = IIf(cmbPallet2.Text = "", "-", cmbPallet2.Text)
                'CantidadMover = MOVIMIENTO_PALLET_DESDE_PK(palletEncontrado1, palletEncontrado2)
            End If
        End If



        'If chkUbicacionVacia.Checked = False Then
        '    If cmbPallet.Text = "" Then
        '        MessageBox.Show("Debe seleccionar un pallet", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        cmbPallet.Focus()
        '        Exit Sub
        '    End If
        'Else
        '    If _procedencia = "PIK" Then
        '        CantidadMover = MOVIMIENTO_PALLET_DESDE_PK("-", "-")
        '        If GUARDA_MOVIMIENTO(CantidadMover) = True Then
        '            MessageBox.Show("La ubicación fue disponibilizada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            GLO_ACCION_EJECUTADA = True
        '            GLO_MUEVE_PALLET_PRODUCTO_EXTRAVIADO = True
        '            Me.Dispose()
        '        End If
        '    End If
        'End If




        'If _procedencia = "ABA" Then
        '    If ACTUALIZA_NUEVA_UBICACION() = True Then
        '        MessageBox.Show("La ubicación fue liberada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        GLO_ACCION_EJECUTADA = True
        '        Me.Dispose()
        '    Else
        '        GLO_ACCION_EJECUTADA = False
        '    End If
        'ElseIf _procedencia = "PIK" Then
        '    If DISPONIBILIZA_UBICACION_DESDE_PICKEO() = True Then
        '        If GUARDA_MOVIMIENTO() = True Then
        '            MessageBox.Show("La ubicación fue disponibilizada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            GLO_ACCION_EJECUTADA = True
        '            GLO_MUEVE_PALLET_PRODUCTO_EXTRAVIADO = True
        '            Me.Dispose()
        '        End If

        '    Else
        '        GLO_ACCION_EJECUTADA = False
        '    End If
        'End If

    End Sub

    Private Function GUARDA_MOVIMIENTO(ByVal Cantidad As Integer) As Boolean
        Dim classMOV As class_movimientos = New class_movimientos
        Dim classInv As class_inventario = New class_inventario
        'Dim class_recepcion As class_recepcion = New class_recepcion
        Dim classRecepcion As class_recepcion = New class_recepcion
        Dim ds As DataSet = New DataSet
        Dim dsDetalle As DataSet = New DataSet
        Dim dsInventario As DataSet = New DataSet
        Dim dsMov As DataSet = New DataSet
        Dim _numCantidadBultos As Integer = 0

        Dim _Folio As Integer = 0
        Dim _FolioRelacionado As Integer = 0
        Dim fila As Integer = 0
        Dim mes As String = ""
        Dim dia As String = ""
        Dim _msgError As String = ""
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        Dim _fecha As Date
        'Dim cantidad As Integer = 0
        Dim sumaCantidad As Integer = 0
        Dim seriePallet As String = ""

        Dim _Observacion As String

        GUARDA_MOVIMIENTO = False


        Try
            _Observacion = "MOVIMIENTO GENERADO A TRAVEZ DEL MOVIMIENTO DE PALLET:  " + _palletRequerido + " POR NO ENCONTRASE FISICAMENTE EN LA UBICACIÓN"
            '_numCantidadBultos = OBTIENE_NUMERO_BULTOS(cmbProductos.SelectedValue)

            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()

                _fecha = GLO_FECHA_SISTEMA

                If CStr(_fecha.Month).Length = 1 Then
                    mes = Trim("0" + CStr(_fecha.Month))
                Else
                    mes = CStr(_fecha.Month)
                End If


                'SALIDA DE BODEGA DE ORIGEN
                '=============================================================
                If GUARDA_ENC_MOVIMINETO(conexion, 0, TIPO_MOVIMIENTO.SALIDA, GLO_BODEGA_PRODUCTO_TERMINADO, _fecha, mes, _fecha.Year, GLO_USUARIO_ACTUAL, 0,
                                         COM_TIPO_DOCUMENTO.VALE_DE_SALIDA, 0, 0, _Observacion, "-", 0, _Folio) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If

                    Return False
                    Exit Function
                End If

                _FolioRelacionado = _Folio

                If ELIMINA_DETALLE_MOVIMIENTO(conexion, _Folio) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If

                    Return False
                    Exit Function
                End If

                fila = 0
                If GUARDA_DET_MOVIMINETO(conexion, _Folio, _pro_codigo, Cantidad, _cod_bulto, _cantidadPallet) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If

                    Return False
                    Exit Function
                End If

                If ACTUALIZA_STOCK_BODEGA(conexion, GLO_BODEGA_PRODUCTO_TERMINADO, _pro_codigo, TIPO_MOVIMIENTO.SALIDA, Cantidad) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If

                    Return False
                    Exit Function
                End If

                'FIN SALIDA DE BODEGA DE ORIGEN
                '=============================================================

                'ENTRADA A BODEGA DE DESTINO
                '=============================================================
                _Folio = 0
                If GUARDA_ENC_MOVIMINETO(conexion, 0, TIPO_MOVIMIENTO.ENTRADA, GLO_BODEGA_PRODUCTO_EXTRAVIADOS, _fecha, mes, _fecha.Year, GLO_USUARIO_ACTUAL, 0,
                                         COM_TIPO_DOCUMENTO.VALE_DE_INGRESO, 0, _FolioRelacionado, _Observacion, "", 0, _Folio) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If

                    Return False
                    Exit Function
                End If

                If ELIMINA_DETALLE_MOVIMIENTO(conexion, _Folio) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If

                    Return False
                    Exit Function
                End If

                If GUARDA_DET_MOVIMINETO(conexion, _Folio, _pro_codigo, Cantidad, _cod_bulto, _cantidadPallet) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If

                    Return False
                    Exit Function
                End If

                If ACTUALIZA_STOCK_BODEGA(conexion, GLO_BODEGA_PRODUCTO_EXTRAVIADOS, _pro_codigo, TIPO_MOVIMIENTO.ENTRADA, Cantidad) = False Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If

                    Return False
                    Exit Function
                End If


                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If

                GUARDA_MOVIMIENTO = True
                'Call INICIALIZA()
                'MessageBox.Show("El movimiento fui ingresado en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.Dispose()

                'GrillaSerieUbicacion.DataSource = Nothing
                'GrillaSerieUbicacion.Rows.Clear()
            End Using
        Catch ex As Exception
            GUARDA_MOVIMIENTO = False
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    Private Function MOVIMIENTO_PALLET_DESDE_ABASTECIMIENTO(ByVal palletEncontrado1 As String, ByVal palletEncontrado2 As String) As Integer
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet

        MOVIMIENTO_PALLET_DESDE_ABASTECIMIENTO = 0

        Try
            'Guarda cabecera del documento
            ds = Nothing
            classUbicaciones.cnn = _cnn
            classUbicaciones.palletEncontrado = palletEncontrado1
            ds = classUbicaciones.MOVIMIENTO_PALLET_DESDE_ABASTECIMIENTO(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            Else
                If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                    MessageBox.Show(ds.Tables(0).Rows(0)("MENSAJE"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ds = Nothing
                    Exit Function
                Else
                    MOVIMIENTO_PALLET_DESDE_ABASTECIMIENTO = ds.Tables(0).Rows(0)("cantidad_movimiento")
                End If
            End If

            If palletEncontrado2 <> "-" Then
                ds = Nothing
                classUbicaciones.cnn = _cnn
                classUbicaciones.palletEncontrado = palletEncontrado2
                ds = classUbicaciones.MOVIMIENTO_PALLET_DESDE_ABASTECIMIENTO(_msgError)
                If _msgError <> "" Then
                    ds = Nothing
                    MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                Else
                    If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                        MessageBox.Show(ds.Tables(0).Rows(0)("MENSAJE"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        MOVIMIENTO_PALLET_DESDE_ABASTECIMIENTO = 0
                        ds = Nothing
                        Exit Function
                    End If
                End If
            End If

        Catch ex As Exception
            MOVIMIENTO_PALLET_DESDE_ABASTECIMIENTO = 0
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    'Private Function DISPONIBILIZA_UBICACION_DESDE_PICKEO() As Boolean
    '    Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
    '    Dim _msgError As String = ""
    '    Dim ds As DataSet

    '    DISPONIBILIZA_UBICACION_DESDE_PICKEO = False

    '    Try
    '        'Guarda cabecera del documento
    '        ds = Nothing
    '        classUbicaciones.cnn = _cnn
    '        classUbicaciones.palletRequerido = _palletRequerido
    '        classUbicaciones.palletEncontrado = cmbPallet.Text
    '        classUbicaciones.ubi_codigoactual = _ubi_codigo
    '        classUbicaciones.ubi_codigopisopt = GLO_UBI_PISO_PRODUCTO_TERMINADO
    '        classUbicaciones.ubi_codigoextraviado = GLO_UBI_PISO_PRODUCTOS_EXTRAVIADOS
    '        classUbicaciones.ubicacion_vacia = chkUbicacionVacia.Checked

    '        ds = classUbicaciones.LIBERA_UBICACION_PROCESO_PICKEO(_msgError)
    '        If _msgError <> "" Then
    '            ds = Nothing
    '            MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Function
    '        Else
    '            If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
    '                MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                ds = Nothing
    '                Exit Function
    '            End If
    '        End If

    '        If (cmbPallet2.Enabled = True And cmbPallet2.Text <> "") Then
    '            'Actualiza posicion del segundo pallet
    '            ds = Nothing
    '            classUbicaciones.cnn = _cnn
    '            classUbicaciones.cnn = _cnn
    '            classUbicaciones.palletRequerido = _palletRequerido
    '            classUbicaciones.palletEncontrado = cmbPallet2.Text
    '            classUbicaciones.ubi_codigoactual = _ubicacion2
    '            classUbicaciones.ubi_codigopisopt = GLO_UBI_PISO_PRODUCTO_TERMINADO
    '            classUbicaciones.ubi_codigoextraviado = GLO_UBI_PISO_PRODUCTOS_EXTRAVIADOS
    '            classUbicaciones.ubicacion_vacia = chkUbicacionVacia.Checked

    '            ds = classUbicaciones.LIBERA_UBICACION_PROCESO_PICKEO(_msgError)
    '            If _msgError <> "" Then
    '                ds = Nothing
    '                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Exit Function
    '            Else
    '                If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
    '                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                    ds = Nothing
    '                    Exit Function
    '                End If
    '            End If
    '        End If

    '        DISPONIBILIZA_UBICACION_DESDE_PICKEO = True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Function

    Private Function ACTUALIZA_NUEVA_UBICACION() As Boolean
        Dim classUbicaciones As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet

        ACTUALIZA_NUEVA_UBICACION = False

        Try
            'Guarda cabecera del documento
            ds = Nothing
            classUbicaciones.cnn = _cnn
            classUbicaciones.pallet = cmbPallet.Text
            classUbicaciones.ubi_codigo = cmbUbicacion.SelectedValue

            ds = classUbicaciones.ACTUALIZA_UBICACIONES(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            Else
                If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ds = Nothing
                    Exit Function
                End If
            End If

            'Actualiza posicion del segundo pallet
            ds = Nothing
            classUbicaciones.cnn = _cnn
            classUbicaciones.pallet = cmbPallet2.Text
            classUbicaciones.ubi_codigo = cmbUbicacion.SelectedValue

            If (cmbPallet2.Enabled = True And cmbPallet2.Text <> "") Then
                ds = classUbicaciones.ACTUALIZA_UBICACIONES(_msgError)
                If _msgError <> "" Then
                    ds = Nothing
                    MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                Else
                    If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                        MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ds = Nothing
                        Exit Function
                    End If
                End If
            End If

            ACTUALIZA_NUEVA_UBICACION = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        GLO_ACCION_EJECUTADA = False
        Me.Dispose()
    End Sub

    Private Sub chkMantener_CheckedChanged(sender As Object, e As EventArgs) Handles chkMantener.CheckedChanged
        If chkMantener.Checked = True Then
            cmbPallet.Items.Clear()
            cmbPallet.Enabled = False
        ElseIf chkMantener.Checked = False Then
            cmbPallet.Enabled = True
        End If
    End Sub

    Private Sub cmbPallet2_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbPallet2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbPallet.Text <> "" Then
                Call CARGA_COMBO_PALLET()
            Else
                MessageBox.Show("Debe seleccionar un primer pallet", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbPallet.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmbPallet2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPallet2.SelectedIndexChanged
        Call CARGA_DATOS_PALLET2()
    End Sub

    Private Sub CARGA_DATOS_PALLET2()
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim Fila As Integer = 0
        Try
            classUbicacion.cnn = _cnn
            classUbicacion.pallet = cmbPallet2.Text.ToUpper

            lblCodigo2.Text = ""
            lblNombre2.Text = ""
            lblBultoCantidad2.Text = ""

            ds = classUbicacion.BUSCA_PALLET_DESCRIPCION(_msgError)
            If _msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("codigo") <> "" Then
                        lblCodigo2.Text = ds.Tables(0).Rows(Fila)("codigo")
                        lblNombre2.Text = ds.Tables(0).Rows(Fila)("producto")
                        lblBultoCantidad2.Text = ds.Tables(0).Rows(Fila)("descripcion")
                    End If
                End If
            Else
                MessageBox.Show(_msgError + "\CARGA_DATOS_PALLET2", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + "\CARGA_DATOS_PALLET2", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPallet2_Layout(sender As Object, e As LayoutEventArgs) Handles cmbPallet2.Layout

    End Sub

    Private Sub chkUbicacionVacia_CheckedChanged(sender As Object, e As EventArgs) Handles chkUbicacionVacia.CheckedChanged
        If chkUbicacionVacia.Checked = True Then
            lblCodigo.Text = ""
            lblNombre.Text = ""
            lblBultoCantidad.Text = ""

            lblCodigo2.Text = ""
            lblNombre2.Text = ""
            lblBultoCantidad2.Text = ""

            If cmbPallet.Text <> "" Then
                cmbPallet.SelectedValue = 0
            End If

            If cmbPallet2.Text <> "" Then
                cmbPallet2.SelectedValue = 0
            End If
            cmbPallet.Enabled = False
            cmbPallet2.Enabled = False

        ElseIf chkUbicacionVacia.Checked = False Then
            cmbPallet.Enabled = True
            cmbPallet2.Enabled = True
        End If
    End Sub
End Class