Public Class frm_listado_comunas
    Private _cnn As String

    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Private Sub frm_listado_comunas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call CARGA_COMBO_REGIONES()
        Call CARGA_GRILLA()
    End Sub



    Private Sub CARGA_GRILLA()
        Dim class_comunes As class_comunes = New class_comunes
        Dim Fila As Integer = 0

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing
            class_comunes.cnn = _cnn

            If cmbRegion.Text <> "" Then
                class_comunes.IdRegion = cmbRegion.SelectedValue
            Else
                class_comunes.IdRegion = 0
            End If

            If cmbCiudad.Text <> "" Then
                class_comunes.IdCiudad = cmbCiudad.SelectedValue
            Else
                class_comunes.IdCiudad = 0
            End If

            class_comunes.IdComuna = 0

            _msg = ""

            Grilla.Rows.Clear()
            ds = class_comunes.CARGA_DATOS_COMUNA(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("com_nombre") <> "" Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            Grilla.Rows.Add(ds.Tables(0).Rows(Fila)("com_codigo"),
                                            ds.Tables(0).Rows(Fila)("reg_nombre"),
                                            ds.Tables(0).Rows(Fila)("ciu_nombre"),
                                            ds.Tables(0).Rows(Fila)("com_nombre"),
                                            ds.Tables(0).Rows(Fila)("cod_flete_manager"),
                                            "",
                                            ds.Tables(0).Rows(Fila)("zog_codigo"))
                            Fila = Fila + 1
                        Loop

                    End If
                    lblTotal.Text = "Cantidad de registros encontrados: " + ds.Tables(0).Rows.Count.ToString
                End If

                Grilla.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Grilla.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Grilla.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Grilla.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Grilla.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                Me.Text = "Listado de comunas - [ULTIMA CONSULTA: " + DateTime.Now.ToString() + "]"
            Else
                MessageBox.Show(_msg + "\carga_grila", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "carga_grila", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_COMBO_REGIONES()
        Dim _msg As String
        Try
            Dim classComun As class_comunes = New class_comunes
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classComun.cnn = _cnn
            _msg = ""
            ds = classComun.CARGA_COMBO_REGIONES(_msg)
            If _msg = "" Then
                Me.cmbRegion.DataSource = ds.Tables(0)
                Me.cmbRegion.DisplayMember = "mensaje"
                Me.cmbRegion.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_REGIONES", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbRegion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbRegion.SelectionChangeCommitted
        cmbCiudad.DataSource = Nothing
        cmbCiudad.Items.Clear()

        If cmbRegion.SelectedValue > 0 Then
            Call CARGA_COMBO_CIUDAD()
        End If
    End Sub

    Private Sub CARGA_COMBO_CIUDAD()
        Dim _msg As String
        Try
            Dim classComun As class_comunes = New class_comunes
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classComun.cnn = _cnn
            classComun.IdRegion = cmbRegion.SelectedValue
            _msg = ""
            ds = classComun.CARGA_COMBO_CIUDADES(_msg)
            If _msg = "" Then
                Me.cmbCiudad.DataSource = ds.Tables(0)
                Me.cmbCiudad.DisplayMember = "mensaje"
                Me.cmbCiudad.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_CIUDAD", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call CARGA_GRILLA()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        Try
            If e.ColumnIndex = 5 Then
                Dim frm As frm_ingreso_comunas = New frm_ingreso_comunas
                frm.cnn = _cnn
                frm.com_codigo = Grilla.Rows(e.RowIndex).Cells(0).Value
                frm.reg_nombre = Grilla.Rows(e.RowIndex).Cells(1).Value
                frm.ciu_nombre = Grilla.Rows(e.RowIndex).Cells(2).Value
                frm.com_nombre = Grilla.Rows(e.RowIndex).Cells(3).Value
                frm.cod_flete = Grilla.Rows(e.RowIndex).Cells(4).Value
                frm.zog_codigo = Grilla.Rows(e.RowIndex).Cells(6).Value
                frm.ShowDialog()
                Call CARGA_GRILLA()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class