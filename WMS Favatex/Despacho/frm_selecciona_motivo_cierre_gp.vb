Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class frm_selecciona_motivo_cierre_gp
    Private _cnn As String
    Private _dep_num_guia As Long
    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Public Property dep_num_guia() As Long
        Get
            Return _dep_num_guia
        End Get
        Set(ByVal value As Long)
            _dep_num_guia = value
        End Set
    End Property
    Private Sub frm_selecciona_motivo_cierre_gp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CARGA_COMBO_MOTIVO_CIERRE()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub CARGA_COMBO_MOTIVO_CIERRE()
        Dim _msg As String
        Try
            Dim classMotivo As class_motivo_cierre_guia_pallet = New class_motivo_cierre_guia_pallet
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classMotivo.cnn = _cnn
            _msg = ""
            ds = classMotivo.CARGA_COMBO_MOTIVO_CIERRE_GUIA_PALLET(_msg)
            If _msg = "" Then
                Me.cmbMotivoCierre.DataSource = ds.Tables(0)
                Me.cmbMotivoCierre.DisplayMember = "MENSAJE"
                Me.cmbMotivoCierre.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_MOTIVO_CIERRE", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CERRADO_MANUAL()
        Dim classMotivo As class_motivo_cierre_guia_pallet = New class_motivo_cierre_guia_pallet
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""

        Try
            ds = Nothing
            classMotivo.cnn = _cnn
            classMotivo.dep_num_guia = _dep_num_guia
            classMotivo.mcp_codigo = cmbMotivoCierre.SelectedValue

            ds = classMotivo.CIERRA_GUIA_PALLET(_msgError)
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

            MessageBox.Show("Guia de pallet cerrada en forma correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cmbMotivoCierre.Text = "" Then
            MessageBox.Show("Debe seleccionar un motivo de cierre", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Call CERRADO_MANUAL()
        Me.Dispose()
    End Sub
End Class