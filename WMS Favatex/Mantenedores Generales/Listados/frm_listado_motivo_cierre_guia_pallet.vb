Public Class frm_listado_motivo_cierre_guia_pallet
    Private _cnn As String

    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Private Sub frm_listado_motivo_cierre_guia_pallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call INICIALIZA()
    End Sub
    Private Sub INICIALIZA()
        Me.WindowState = FormWindowState.Maximized
        lblTotal.Text = "Cantidad de registros encontrados: 0"
        Call CARGA_GRILLA()
    End Sub
    Private Sub CARGA_GRILLA()
        Dim class_motivo_cp As class_motivo_cierre_guia_pallet = New class_motivo_cierre_guia_pallet
        Dim Fila As Integer = 0

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing
            class_motivo_cp.cnn = _cnn
            class_motivo_cp.mcp_codigo = 0

            _msg = ""

            Grilla.Rows.Clear()
            ds = class_motivo_cp.MOTIVO_CIERRE_GUIA_PALLET_LISTADO(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("mcp_codigo") > 0 Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            Grilla.Rows.Add(ds.Tables(0).Rows(Fila)("mcp_codigo"),
                                            ds.Tables(0).Rows(Fila)("mcp_nombre"),
                                            ds.Tables(0).Rows(Fila)("mcp_activo"))
                            Fila = Fila + 1
                        Loop

                    End If
                    lblTotal.Text = "Cantidad de registros encontrados: " + ds.Tables(0).Rows.Count.ToString
                End If

            Else
                MessageBox.Show(_msg + "\carga_grila", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "carga_grila", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call CARGA_GRILLA()
    End Sub

    Private Sub ButtonNueva_Click(sender As Object, e As EventArgs) Handles ButtonNueva.Click
        Dim frm As frm_ingreso_motivo_cierre_guia_pallet = New frm_ingreso_motivo_cierre_guia_pallet
        frm.cnn = _cnn
        frm.mcp_codigo = 0
        frm.ShowDialog()
        Call CARGA_GRILLA()
    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        Try
            If e.ColumnIndex = 3 Then
                Dim frm As frm_ingreso_motivo_cierre_guia_pallet = New frm_ingreso_motivo_cierre_guia_pallet
                frm.cnn = _cnn
                frm.mcp_codigo = Grilla.Rows(e.RowIndex).Cells(0).Value
                frm.ShowDialog()
                Call CARGA_GRILLA()
            ElseIf e.ColumnIndex = 4 Then
                If vbYes = MessageBox.Show("¿Esta seguro(a) de eliminar el registro seleccionado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    Call ELIMINA_REGISTRO(Grilla.Rows(e.RowIndex).Cells(0).Value)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ELIMINA_REGISTRO(ByVal mcp_codigo As Integer)
        Dim class_motivo_cp As class_motivo_cierre_guia_pallet = New class_motivo_cierre_guia_pallet
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim _msg As String = ""

        Try
            ds = Nothing
            class_motivo_cp.cnn = _cnn
            class_motivo_cp.mcp_codigo = mcp_codigo

            ds = class_motivo_cp.MOTIVO_CIERRE_GUIA_PALLET_ELIMINA_REGISTRO(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            MessageBox.Show("El registro fue eliminado en forma excelente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call CARGA_GRILLA()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK)
        End Try
    End Sub
End Class