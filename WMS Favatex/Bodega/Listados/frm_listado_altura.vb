﻿Public Class frm_listado_altura
    Private _cnn As String
    Dim cargaPrimeraVez As Boolean
    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Private Sub frm_listado_altura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaPrimeraVez = False
        Call INICIALIZA()
        cargaPrimeraVez = True
    End Sub

    Private Sub INICIALIZA()
        Me.WindowState = FormWindowState.Maximized
        lblTotal.Text = "Cantidad de registros encontrados: 0"
        Call CARGA_GRILLA()
    End Sub

    Private Sub CARGA_GRILLA()

        Dim class_altura As class_alturas = New class_alturas

        Dim TestPos As Integer = 0
        Dim Fila As Integer = 0

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing
            class_altura.cnn = _cnn
            class_altura.alt_codigo = 0
            class_altura.todos = chkActivo.Checked

            _msg = ""
            Grilla.Rows.Clear()
            ds = class_altura.ALTURA_LISTADO(_msg)
            If _msg = "" Then
                lblTotal.Text = "Cantidad de registros encontrados: 0"
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("alt_codigo") > 0 Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            Grilla.Rows.Add(ds.Tables(0).Rows(Fila)("alt_codigo"),
                                            ds.Tables(0).Rows(Fila)("alt_nombre"),
                                            ds.Tables(0).Rows(Fila)("alt_activo"),
                                            ds.Tables(0).Rows(Fila)("alt_para_picking"))
                            Fila = Fila + 1
                        Loop
                        lblTotal.Text = "Cantidad de registros encontrados: " + ds.Tables(0).Rows.Count.ToString
                    End If

                End If
            Else
                MessageBox.Show(_msg + "\CARGA_GRILLA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub

    Private Sub ELIMINA_REGISTRO(ByVal codigo As Integer)
        Dim class_altura As class_alturas = New class_alturas
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim _msg As String = ""

        Try
            ds = Nothing
            class_altura.cnn = _cnn
            class_altura.alt_codigo = codigo

            ds = class_altura.ALTURA_ELIMINA_REGISTRO(_msgError)
            If _msgError <> "" Then
                ds = Nothing
                MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If ds.Tables(0).Rows(0)("CODIGO") < 0 Then
                    ds = Nothing
                    MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            MessageBox.Show("El registro fue eliminado en forma excelente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call CARGA_GRILLA()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        Try
            If e.ColumnIndex = 3 Then
                Dim frm As frm_ingreso_altura = New frm_ingreso_altura
                frm.cnn = _cnn
                frm.alt_codigo = Grilla.Rows(e.RowIndex).Cells(0).Value
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

    Private Sub ButtonNueva_Click(sender As Object, e As EventArgs) Handles ButtonNueva.Click
        Dim frm As frm_ingreso_altura = New frm_ingreso_altura
        frm.cnn = _cnn
        frm.ShowDialog()
        Call CARGA_GRILLA()
    End Sub
    Private Sub chkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivo.CheckedChanged
        If cargaPrimeraVez = True Then
            Call CARGA_GRILLA()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Call CARGA_GRILLA()
    End Sub
End Class