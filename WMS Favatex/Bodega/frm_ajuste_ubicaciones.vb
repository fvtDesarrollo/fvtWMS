Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Threading
Public Class frm_ajuste_ubicaciones
    Dim _cnn As String

    Const COL_GRI_SELECC As Integer = 0
    Const COL_GRI_CODUBI As Integer = 1
    Const COL_GRI_NOMUBI As Integer = 2
    Const COL_GRI_PALLET As Integer = 3
    Const COL_GRI_PROCOD As Integer = 4
    Const COL_GRI_CODINT As Integer = 5
    Const COL_GRI_PRONOM As Integer = 6
    Const COL_GRI_BULCOD As Integer = 7
    Const COL_GRI_BULSTR As Integer = 8
    Const COL_GRI_PALCAN As Integer = 9
    Const COL_GRI_BOTON As Integer = 10

    Const COL_GRI_LOG_SELECC As Integer = 0
    Const COL_GRI_LOG_ALOCOD As Integer = 1
    Const COL_GRI_LOG_FECHA As Integer = 2
    Const COL_GRI_LOG_USUCOD As Integer = 3
    Const COL_GRI_LOG_USUNOM As Integer = 4
    Const COL_GRI_LOG_PROCOD As Integer = 5
    Const COL_GRI_LOG_PROCIN As Integer = 6
    Const COL_GRI_LOG_PRONOM As Integer = 7
    Const COL_GRI_LOG_BULCOD As Integer = 8
    Const COL_GRI_LOG_BULSTR As Integer = 9
    Const COL_GRI_LOG_ACCION As Integer = 10


    Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Private Sub frm_ajuste_ubicaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CARGA_COMBO_BODEGA_ORIGEN()
        Call CARGA_COMBO_ALTURA()
        Call CARGA_COMBO_ZONA()
    End Sub

    Private Sub CONFIGURA_COLUMNAS()
        GrillaDetalle.Columns(COL_GRI_SELECC).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_CODUBI).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_NOMUBI).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_PALLET).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_PROCOD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_CODINT).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_PRONOM).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_BULCOD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_BULSTR).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_PALCAN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaDetalle.Columns(COL_GRI_BOTON).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub CONFIGURA_COLUMNAS_LOG()
        GrillaLog.Columns(COL_GRI_LOG_SELECC).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLog.Columns(COL_GRI_LOG_ALOCOD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLog.Columns(COL_GRI_LOG_FECHA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLog.Columns(COL_GRI_LOG_USUCOD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLog.Columns(COL_GRI_LOG_USUNOM).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLog.Columns(COL_GRI_LOG_PROCOD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLog.Columns(COL_GRI_LOG_PROCIN).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLog.Columns(COL_GRI_LOG_PRONOM).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLog.Columns(COL_GRI_LOG_BULCOD).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLog.Columns(COL_GRI_LOG_BULSTR).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        GrillaLog.Columns(COL_GRI_LOG_ACCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub CARGA_COMBO_BODEGA_ORIGEN()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            _msg = ""
            ds = classMovimiento.CARGA_COMBO_ORIGEN(_msg)
            If _msg = "" Then
                Me.cmbBodegaOrigen.DataSource = ds.Tables(0)
                Me.cmbBodegaOrigen.DisplayMember = "mensaje"
                Me.cmbBodegaOrigen.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_BODEGA_ORIGEN", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_COMBO_ALTURA()
        Dim _msg As String
        Try
            Dim classAltura As class_alturas = New class_alturas
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classAltura.cnn = _cnn
            _msg = ""
            ds = classAltura.CARGA_COMBO_ALTURA(_msg)
            If _msg = "" Then
                Me.cmbAltura.DataSource = ds.Tables(0)
                Me.cmbAltura.DisplayMember = "MENSAJE"
                Me.cmbAltura.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_ALTURA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbBodegaOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodegaOrigen.SelectedIndexChanged

    End Sub

    Private Sub cmbBodegaOrigen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbBodegaOrigen.SelectionChangeCommitted
        If cmbBodegaOrigen.SelectedValue > 0 Then
            Call CARGA_COMBO_PISO_ORIGEN()
        End If
    End Sub

    Private Sub CARGA_COMBO_PISO_ORIGEN()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            classMovimiento.bod_codigo = cmbBodegaOrigen.SelectedValue
            _msg = ""
            ds = classMovimiento.CARGA_UBICACION_ORIGEN(_msg)
            If _msg = "" Then
                Me.cmbPisoOrigen.DataSource = ds.Tables(0)
                Me.cmbPisoOrigen.DisplayMember = "mensaje"
                Me.cmbPisoOrigen.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_PISO_ORIGEN", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbPisoOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPisoOrigen.SelectedIndexChanged

    End Sub

    Private Sub cmbPisoOrigen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPisoOrigen.SelectionChangeCommitted
        If cmbPisoOrigen.SelectedValue = PISO_DESTINO.RACK Then
            cmbAltura.Enabled = True
            cmbZona.Enabled = True
        Else
            cmbAltura.SelectedValue = 0
            cmbZona.SelectedValue = 0
            cmbAltura.Enabled = False
            cmbZona.Enabled = False
        End If
    End Sub

    Private Sub CARGA_COMBO_ZONA()
        Dim _msg As String
        Try
            Dim classZona As class_zonas = New class_zonas
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classZona.cnn = _cnn

            _msg = ""
            ds = classZona.ZONAS_CARGA_ZONAS_NEW(_msg)
            If _msg = "" Then
                Me.cmbZona.DataSource = ds.Tables(0)
                Me.cmbZona.DisplayMember = "MENSAJE"
                Me.cmbZona.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_ZONA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

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

    Private Sub cmbPallet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPallet.SelectedIndexChanged

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


    Private Sub cmbPallet_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbPallet.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call CARGA_COMBO_PALLET()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call CARGA_GRILLA()
    End Sub

    Private Sub CARGA_GRILLA()
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim _msgError As String = ""
        Dim ds As DataSet
        Dim Fila As Integer = 0
        Dim Contador As Integer = 1
        Try
            Me.Cursor = Cursors.WaitCursor
            classUbicacion.cnn = _cnn

            If cmbBodegaOrigen.Text = "" Then
                classUbicacion.bod_codigo = 0
            Else
                classUbicacion.bod_codigo = cmbBodegaOrigen.SelectedValue
            End If

            If cmbPisoOrigen.Text = "" Then
                classUbicacion.ubi_codigo = 0
            Else
                If cmbPisoOrigen.SelectedValue <> PISO_DESTINO.RACK Then
                    classUbicacion.ubi_codigo = cmbPisoOrigen.SelectedValue
                Else
                    classUbicacion.ubi_codigo = 0
                End If
            End If

            If cmbAltura.Text = "" Then
                classUbicacion.alt_codigo = 0
            Else
                classUbicacion.alt_codigo = cmbAltura.SelectedValue
            End If

            If cmbZona.Text = "" Then
                classUbicacion.zon_codigo = 0
            Else
                classUbicacion.zon_codigo = cmbZona.SelectedValue
            End If


            If txtCodigo.Text = "" Then
                classUbicacion.codigo_interno = "-"
            Else
                classUbicacion.codigo_interno = Trim(txtCodigo.Text)
            End If

            If cmbBulto.Text = "" Then
                classUbicacion.bul_codigo = 0
            Else
                classUbicacion.bul_codigo = cmbBulto.SelectedValue
            End If

            If cmbPallet.Text = "" Then
                classUbicacion.pallet = "-"
            Else
                classUbicacion.pallet = Trim(cmbPallet.Text)
            End If


            ds = classUbicacion.AJUSTE_UBICACIONES(_msgError)
            If _msgError = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    GrillaDetalle.Rows.Clear()
                    If ds.Tables(0).Rows(Fila)("pro_codigo") > 0 Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            GrillaDetalle.Rows.Add(False, ds.Tables(0).Rows(Fila)("ubi_codigo"),
                                            ds.Tables(0).Rows(Fila)("ubi_nombre"),
                                            ds.Tables(0).Rows(Fila)("pallet"),
                                            ds.Tables(0).Rows(Fila)("pro_codigo"),
                                            ds.Tables(0).Rows(Fila)("pro_codigointerno"),
                                            ds.Tables(0).Rows(Fila)("pro_nombre"),
                                            ds.Tables(0).Rows(Fila)("pro_bulto"),
                                            ds.Tables(0).Rows(Fila)("pro_bultostr"),
                                            ds.Tables(0).Rows(Fila)("cantidad"),
                                            ds.Tables(0).Rows(Fila)("cantidad_reservada"),
                                            ds.Tables(0).Rows(Fila)("cantidad_disponible"),
                                            "")
                            Fila = Fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS()
                    End If
                End If
                Me.Cursor = Cursors.Default
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show(_msgError + "\CARGA_GRILLA_DETALLE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message + "\CARGA_GRILLA_DETALLE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevaBusqueda_Click(sender As Object, e As EventArgs) Handles btnNuevaBusqueda.Click
        Call Limpiar()
    End Sub

    Private Sub Limpiar()
        cmbBodegaOrigen.SelectedValue = 0
        cmbPisoOrigen.SelectedValue = 0
        cmbZona.SelectedValue = 0
        cmbAltura.SelectedValue = 0
        txtCodigo.Text = ""
        cmbBulto.DataSource = Nothing
        cmbBulto.Items.Clear()
        cmbPallet.DataSource = Nothing
        cmbPallet.Items.Clear()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub

    Private Sub GrillaDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaDetalle.CellContentClick
        Try
            If e.ColumnIndex = Me.GrillaDetalle.Columns.Item(COL_GRI_SELECC).Index Then
                Dim chkCell As DataGridViewCheckBoxCell = Me.GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_SELECC)
                chkCell.Value = Not chkCell.Value
            End If

            If e.ColumnIndex = COL_GRI_BOTON Then
                Dim frm As frm_ajuste_ubicacion_detalle = New frm_ajuste_ubicacion_detalle
                frm.cnn = _cnn
                frm.codUbicacion = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CODUBI).Value
                frm.nomUbicacion = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_NOMUBI).Value
                frm.Pallet = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_PALLET).Value
                frm.proCodigo = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_PROCOD).Value
                frm.codigo = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_CODINT).Value
                frm.nombreProducto = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_PRONOM).Value
                frm.bulCodigo = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_BULCOD).Value
                frm.bultoStr = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_BULSTR).Value
                frm.cantidad = GrillaDetalle.Rows(e.RowIndex).Cells(COL_GRI_PALCAN).Value
                frm.ShowDialog()
                Call CARGA_GRILLA()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        GLO_CODIGO_PRODUCTOS = 0
        GLO_NUMERO_BULTOS_PRODUCTOS = 0
        GLO_CODIGO_PALLET = "-"
        GLO_CANTIDAD_PRODUCTOS = 0

        Dim frm As frm_ing_pallet = New frm_ing_pallet
        frm.cnn = _cnn
        frm.nuevo = True
        frm.ShowDialog()

    End Sub

    'Private Function ACTUALIZA_POSICION_PALLET() As Boolean
    '    Dim classUbicacion As class_ubicaciones = New class_ubicaciones
    '    Dim ds As DataSet = New DataSet
    '    Dim _msgError As String = ""
    '    Dim fila As Integer = 0
    '    Dim _msg As String = ""

    '    Try
    '        ACTUALIZA_POSICION_PALLET = False
    '        classUbicacion.cnn = _cnn
    '        classUbicacion.pallet = cmbPallet.Text

    '        ds = classUbicacion.ACTUALIZA_POSICION_PALLET(_msgError)
    '        If _msgError <> "" Then
    '            ds = Nothing
    '            MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Function
    '        Else
    '            If ds.Tables(0).Rows(0)("codigo") < 0 Then
    '                ds = Nothing
    '                MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Exit Function
    '            End If
    '        End If
    '        ds = Nothing
    '        ACTUALIZA_POSICION_PALLET = True
    '    Catch ex As Exception
    '        ACTUALIZA_POSICION_PALLET = False
    '        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim classUbicacion As class_ubicaciones = New class_ubicaciones
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()

        Dim Mensaje As String = "Acciones: " + vbCrLf

        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim contador As Integer = 0
        Dim PalletInvalidos As Integer = 0
        Dim respuesta As Integer
        Dim Pallet As String = ""

        Try
            For Each row As DataGridViewRow In Me.GrillaDetalle.Rows
                If row.Cells(COL_GRI_SELECC).Value = True Then
                    contador = contador + 1
                End If
                If Mid(row.Cells(COL_GRI_PALLET).Value, 1, 2).ToString() = "PS" Then
                    PalletInvalidos = PalletInvalidos + 1
                    Exit For
                End If
            Next

            If contador = 0 Then
                MessageBox.Show("Debe seleccionar a lo menos un registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If PalletInvalidos > 0 Then
                    MessageBox.Show("Dentro de la selección se encuentran pallet de sistemas que no se deben eliminar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            respuesta = MessageBox.Show("¿Esta seguro(a) de eliminar el o los pallets seleccionado(s)", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = vbNo Then
                Exit Sub
            End If

            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                For Each row As DataGridViewRow In Me.GrillaDetalle.Rows
                    If row.Cells(COL_GRI_SELECC).Value = True Then
                        classUbicacion.pallet = row.Cells(COL_GRI_PALLET).Value

                        ds = classUbicacion.ELIMINA_PALLET(_msgError, conexion)
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


                        classUbicacion.usu_codigo = GLO_USUARIO_ACTUAL
                        classUbicacion.logAccion = "Elimina Pallet: " + row.Cells(COL_GRI_PALLET).Value.ToString
                        classUbicacion.codigo_interno = row.Cells(COL_GRI_CODINT).Value
                        classUbicacion.bul_codigo = row.Cells(COL_GRI_BULCOD).Value.ToString
                        classUbicacion.bulto = row.Cells(COL_GRI_BULSTR).Value
                        ds = classUbicacion.INGRESA_LOG_AJUSTE_UBICACION(_msgError, conexion)
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
                    End If
                Next

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If

            End Using



            MessageBox.Show("El o los pallet(s) fueron eliminados en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call CARGA_GRILLA()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Function ELIMINA_PALLET() As Boolean
    '    Dim classUbicacion As class_ubicaciones = New class_ubicaciones
    '    Dim ds As DataSet = New DataSet
    '    Dim _msgError As String = ""
    '    Dim fila As Integer = 0
    '    Dim _msg As String = ""

    '    Try
    '        ELIMINA_PALLET = False
    '        classUbicacion.cnn = _cnn
    '        classUbicacion.pallet = GLO_CODIGO_PALLET

    '        ds = classUbicacion.ELIMINA_PALLET(_msgError)
    '        If _msgError <> "" Then
    '            ds = Nothing
    '            MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Function
    '        Else
    '            If ds.Tables(0).Rows(0)("codigo") < 0 Then
    '                ds = Nothing
    '                MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Exit Function
    '            End If
    '        End If
    '        ds = Nothing
    '        ELIMINA_PALLET = True
    '    Catch ex As Exception
    '        ELIMINA_PALLET = False
    '        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Function

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim frm As frm_imprimir = New frm_imprimir
            frm.Origen = "IIP"

            frm.serie_paller = OBTIENE_SERIES()

            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function OBTIENE_SERIES() As String
        Dim strPallet As String = ""
        OBTIENE_SERIES = ""
        For Each row As DataGridViewRow In Me.GrillaDetalle.Rows
            If row.Cells(0).Value = True Then
                If strPallet = "" Then
                    strPallet = row.Cells(COL_GRI_PALLET).Value
                Else
                    strPallet = strPallet + "," + row.Cells(COL_GRI_PALLET).Value
                End If
            End If
        Next
        If strPallet = "" Then
            OBTIENE_SERIES = "-"
        Else
            OBTIENE_SERIES = strPallet + ","
        End If

    End Function

    Private Sub chkFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkFecha.CheckedChanged
        dtpDesde.Enabled = chkFecha.Checked
        dtpHasta.Enabled = chkFecha.Checked
    End Sub

    Private Sub btnBus_Click(sender As Object, e As EventArgs) Handles btnBus.Click
        If txtCodigoB.Text = "" Then
            MessageBox.Show("Debe ingresar un código de producto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Call CARGA_GRILLA_LOG()

    End Sub

    Private Sub CARGA_GRILLA_LOG()
        Dim class_ubicacion As class_ubicaciones = New class_ubicaciones
        Dim SearchChar As String = "-"
        Dim TestPos As Integer = 0
        Dim Fila As Integer = 0

        Dim diaASDesde As String = ""
        Dim mesASDesde As String = ""

        Dim diaASHasta As String = ""
        Dim mesASHasta As String = ""


        Dim diaASDesdeDespacho As String = ""
        Dim mesASDesdeDespacho As String = ""

        Dim diaASHastaDespacho As String = ""
        Dim mesASHastaDespacho As String = ""

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String

            ds = Nothing
            class_ubicacion.cnn = _cnn
            class_ubicacion.codigo_interno = txtCodigoB.Text

            If chkFecha.Checked = True Then
                'desde
                If CStr(dtpDesde.Value.Month).Length = 1 Then
                    mesASDesde = Trim("0" + CStr(dtpDesde.Value.Month))
                Else
                    mesASDesde = CStr(dtpDesde.Value.Month)
                End If

                If CStr(dtpDesde.Value.Day).Length = 1 Then
                    diaASDesde = Trim("0" + CStr(dtpDesde.Value.Day))
                Else
                    diaASDesde = CStr(dtpDesde.Value.Day)
                End If

                'Hasta
                If CStr(dtpHasta.Value.Month).Length = 1 Then
                    mesASHasta = Trim("0" + CStr(dtpHasta.Value.Month))
                Else
                    mesASHasta = CStr(dtpHasta.Value.Month)
                End If

                If CStr(dtpHasta.Value.Day).Length = 1 Then
                    diaASHasta = Trim("0" + CStr(dtpHasta.Value.Day))
                Else
                    diaASHasta = CStr(dtpHasta.Value.Day)
                End If

                class_ubicacion.fecha_desde = CStr(dtpDesde.Value.Year) + mesASDesde + diaASDesde
                class_ubicacion.Fecha_hasta = CStr(dtpHasta.Value.Year) + mesASHasta + diaASHasta
            Else
                class_ubicacion.fecha_desde = "19000101"
                class_ubicacion.Fecha_hasta = "20501231"
            End If



            _msg = ""
            GrillaLog.Rows.Clear()
            ds = class_ubicacion.LISTADO_DE_LOG(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("alo_codigo") > 0 Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            GrillaLog.Rows.Add(False, ds.Tables(0).Rows(Fila)("alo_codigo"),
                                            ds.Tables(0).Rows(Fila)("alo_fecha"),
                                            ds.Tables(0).Rows(Fila)("usu_codigo"),
                                            ds.Tables(0).Rows(Fila)("usu_nombre"),
                                            ds.Tables(0).Rows(Fila)("pro_codigo"),
                                            ds.Tables(0).Rows(Fila)("pro_codigointerno"),
                                            ds.Tables(0).Rows(Fila)("pro_nombre"),
                                            ds.Tables(0).Rows(Fila)("bul_codigo"),
                                            ds.Tables(0).Rows(Fila)("bul_strcodigo"),
                                            ds.Tables(0).Rows(Fila)("alo_accion"))
                            Fila = Fila + 1
                        Loop

                        Call CONFIGURA_COLUMNAS_LOG()

                    End If
                End If
                Me.Text = "LISTADO DE ORDENES DE PICKEO - [ULTIMA CONSULTA: " + DateTime.Now.ToString() + "]"
            Else
                MessageBox.Show(_msg + "\CARGA_GRILLA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

End Class