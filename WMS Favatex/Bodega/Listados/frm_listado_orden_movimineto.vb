Public Class frm_listado_orden_movimineto
    Private _cnn As String
    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property

    Const COL_GRI_CODIGOOMO As Integer = 0
    Const COL_GRI_CODSTROMO As Integer = 1
    Const COL_GRI_FECHAOMO As Integer = 2
    Const COL_GRI_CODRESPON As Integer = 3
    Const COL_GRI_NOMRESPON As Integer = 4
    Const COL_GRI_CODESTADO As Integer = 5
    Const COL_GRI_NOMESTADO As Integer = 6
    Const COL_GRI_CODBODORI As Integer = 7
    Const COL_GRI_NOMBODORI As Integer = 8
    Const COL_GRI_CODUBIORI As Integer = 9
    Const COL_GRI_NOMUBIORI As Integer = 10
    Const COL_GRI_CODBODDES As Integer = 11
    Const COL_GRI_NOMBODDES As Integer = 12
    Const COL_GRI_CODUBIDES As Integer = 13
    Const COL_GRI_NOMUBIDES As Integer = 14
    Const COL_GRI_VALEMANAG As Integer = 15
    Const COL_GRI_SELECCION As Integer = 16



    Private Sub frm_listado_orden_movimineto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call CONFIGURA_COLUMNAS()
        Call CARGA_COMBO_ESTADO_MOVIMIENTO()
        If GLO_USU_AUTORIZA_MOVIMIETO = True Then
            cmbEstado.SelectedValue = ESTADO_ORDEN_MOVIMIENTO.PENDIENTE_APROBACION
            Call CARGA_GRILLA()
        End If
        Call CARGA_COMBO_BODEGA_ORIGEN()
        Call CARGA_COMBO_BODEGA_DESTINO()

    End Sub

    Private Sub CONFIGURA_COLUMNAS()
        Grilla.Columns(COL_GRI_CODIGOOMO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CODSTROMO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_FECHAOMO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CODRESPON).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_NOMRESPON).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CODESTADO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_NOMESTADO).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CODBODORI).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_NOMBODORI).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CODUBIORI).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_NOMUBIORI).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CODBODDES).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_NOMBODDES).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_CODUBIDES).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_NOMUBIDES).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_VALEMANAG).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_SELECCION).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
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

    Private Sub CARGA_COMBO_ESTADO_MOVIMIENTO()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            _msg = ""
            ds = classMovimiento.CARGA_COMBO_ORDEN_MOVIMIENTO_ESTADO(_msg)
            If _msg = "" Then
                Me.cmbEstado.DataSource = ds.Tables(0)
                Me.cmbEstado.DisplayMember = "mensaje"
                Me.cmbEstado.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_ESTADO_MOVIMIENTO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_COMBO_BODEGA_DESTINO()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            _msg = ""
            ds = classMovimiento.CARGA_COMBO_ORIGEN(_msg)
            If _msg = "" Then
                Me.cmbBodegaDestino.DataSource = ds.Tables(0)
                Me.cmbBodegaDestino.DisplayMember = "mensaje"
                Me.cmbBodegaDestino.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_BODEGA_DESTINO", MsgBoxStyle.Critical, Me.Text)
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

    Private Sub cmbBodegaDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBodegaDestino.SelectedIndexChanged

    End Sub

    Private Sub cmbBodegaDestino_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbBodegaDestino.SelectionChangeCommitted
        If cmbBodegaDestino.SelectedValue > 0 Then
            Call CARGA_COMBO_PISO_DESTINO()
        End If
    End Sub

    Private Sub CARGA_COMBO_PISO_DESTINO()
        Dim _msg As String
        Try
            Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
            Dim ds As DataSet = New DataSet
            ds = Nothing
            classMovimiento.cnn = _cnn
            classMovimiento.bod_codigo = cmbBodegaDestino.SelectedValue
            classMovimiento.ubi_codigo = cmbPisoOrigen.SelectedValue
            _msg = ""
            ds = classMovimiento.CARGA_UBICACION_DESTINO(_msg)
            If _msg = "" Then
                Me.cmbPisoDestino.DataSource = ds.Tables(0)
                Me.cmbPisoDestino.DisplayMember = "mensaje"
                Me.cmbPisoDestino.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_PISO_DESTINO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call CARGA_GRILLA()
    End Sub

    Private Sub CARGA_GRILLA()
        Dim classMovimiento As class_movimineto_entre_piso = New class_movimineto_entre_piso
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
            classMovimiento.cnn = _cnn
            classMovimiento.omo_codigo = 0

            If cmbEstado.Text = "" Then
                classMovimiento.emo_codigo = 0
            Else
                classMovimiento.emo_codigo = cmbEstado.SelectedValue
            End If

            If chkFecha.Checked = True Then
                'desde
                If CStr(dtpFechaOCDesde.Value.Month).Length = 1 Then
                    mesASDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Month))
                Else
                    mesASDesde = CStr(dtpFechaOCDesde.Value.Month)
                End If

                If CStr(dtpFechaOCDesde.Value.Day).Length = 1 Then
                    diaASDesde = Trim("0" + CStr(dtpFechaOCDesde.Value.Day))
                Else
                    diaASDesde = CStr(dtpFechaOCDesde.Value.Day)
                End If

                'Hasta
                If CStr(dtpFechaOCHasta.Value.Month).Length = 1 Then
                    mesASHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Month))
                Else
                    mesASHasta = CStr(dtpFechaOCHasta.Value.Month)
                End If

                If CStr(dtpFechaOCHasta.Value.Day).Length = 1 Then
                    diaASHasta = Trim("0" + CStr(dtpFechaOCHasta.Value.Day))
                Else
                    diaASHasta = CStr(dtpFechaOCHasta.Value.Day)
                End If

                classMovimiento.fecha_desde = CStr(dtpFechaOCDesde.Value.Year) + mesASDesde + diaASDesde
                classMovimiento.fecha_hasta = CStr(dtpFechaOCHasta.Value.Year) + mesASHasta + diaASHasta
            Else
                classMovimiento.fecha_desde = "19000101"
                classMovimiento.fecha_hasta = "20501231"
            End If

            If cmbBodegaOrigen.Text = "" Then
                classMovimiento.bod_codigoorigen = 0
            Else
                classMovimiento.bod_codigoorigen = cmbBodegaOrigen.SelectedValue
            End If
            If cmbPisoOrigen.Text = "" Then
                classMovimiento.ubi_codigoorigen = 0
            Else
                classMovimiento.ubi_codigoorigen = cmbPisoOrigen.SelectedValue
            End If
            If cmbBodegaDestino.Text = "" Then
                classMovimiento.bod_codigodestino = 0
            Else
                classMovimiento.bod_codigodestino = cmbBodegaDestino.SelectedValue
            End If
            If cmbPisoDestino.Text = "" Then
                classMovimiento.ubi_codigodestino = 0
            Else
                classMovimiento.ubi_codigodestino = cmbPisoDestino.SelectedValue
            End If
            classMovimiento.Listado = True
            _msg = ""
            Grilla.Rows.Clear()
            ds = classMovimiento.ORDEN_MOVIMIENTO_LISTAR(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("omo_codigo") > 0 Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            Grilla.Rows.Add(ds.Tables(0).Rows(Fila)("omo_codigo"),
                                            ds.Tables(0).Rows(Fila)("omo_codigostr"),
                                            CDate(ds.Tables(0).Rows(Fila)("omo_fechadocto")),
                                            ds.Tables(0).Rows(Fila)("usu_codigo"),
                                            ds.Tables(0).Rows(Fila)("usu_nombre"),
                                            ds.Tables(0).Rows(Fila)("eom_codigo"),
                                            ds.Tables(0).Rows(Fila)("eom_nombre"),
                                            ds.Tables(0).Rows(Fila)("bod_codigoorigen"),
                                            ds.Tables(0).Rows(Fila)("bod_nombreorigen"),
                                            ds.Tables(0).Rows(Fila)("ubi_codigoorigen"),
                                            ds.Tables(0).Rows(Fila)("ubi_nombreorigen"),
                                            ds.Tables(0).Rows(Fila)("bod_codigodestino"),
                                            ds.Tables(0).Rows(Fila)("bod_nombredestino"),
                                            ds.Tables(0).Rows(Fila)("ubi_codigodestino"),
                                            ds.Tables(0).Rows(Fila)("ubi_nombredestino"),
                                            ds.Tables(0).Rows(Fila)("omo_valemanager"),
                                            "")
                            If (ds.Tables(0).Rows(Fila)("eom_codigo") = ESTADO_ORDEN_MOVIMIENTO.OM_APROBADA And ds.Tables(0).Rows(Fila)("omo_valemanager") <> 0) Then
                                Grilla.Rows(Fila).DefaultCellStyle.BackColor = Color.DarkSeaGreen
                            ElseIf (ds.Tables(0).Rows(Fila)("eom_codigo") = ESTADO_ORDEN_MOVIMIENTO.OM_APROBADA And ds.Tables(0).Rows(Fila)("omo_valemanager") = 0) Then
                                Grilla.Rows(Fila).DefaultCellStyle.BackColor = Color.Bisque
                            End If

                            Fila = Fila + 1
                        Loop

                        Call CONFIGURA_COLUMNAS()

                        lblTotal.Text = "Total de registros:" + ds.Tables(0).Rows.Count.ToString

                    End If
                End If

            Else
                MessageBox.Show(_msg + "\CARGA_GRILLA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        Try
            If e.ColumnIndex = COL_GRI_SELECCION Then
                If Grilla.Rows(e.RowIndex).Cells(COL_GRI_CODSTROMO).Value <> "" Then
                    Dim frm As frm_movimientos_entre_pisos = New frm_movimientos_entre_pisos
                    frm.cnn = _cnn
                    frm.omo_codigo = Grilla.Rows(e.RowIndex).Cells(COL_GRI_CODIGOOMO).Value
                    frm.eom_codigo = Grilla.Rows(e.RowIndex).Cells(COL_GRI_CODESTADO).Value
                    frm.ShowDialog()
                    Call CARGA_GRILLA()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonNueva_Click(sender As Object, e As EventArgs) Handles ButtonNueva.Click
        Dim frm As frm_movimientos_entre_pisos = New frm_movimientos_entre_pisos
        frm.cnn = _cnn
        frm.omo_codigo = 0
        frm.eom_codigo = 0
        frm.ShowDialog()
        Call CARGA_GRILLA()
    End Sub
End Class