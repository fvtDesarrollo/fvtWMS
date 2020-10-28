Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class frm_mant_picking_devuelve_item
    Dim _cnn As String
    Dim _activaorden As Boolean

    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Public Property activaorden() As Integer
        Get
            Return _activaorden
        End Get
        Set(ByVal value As Integer)
            _activaorden = value
        End Set
    End Property
    Private Sub frm_mant_picking_devuelve_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CARGA_COMBO_MOTIVO()
        GLO_TIPO_DEVOLUCION_PICKING_CODIGO = 0
        GLO_TIPO_DEVOLUCION_PICKING_NOMBRE = ""
    End Sub

    Private Sub CARGA_COMBO_MOTIVO()
        Dim _msg As String
        Try
            Dim classPicking As class_picking = New class_picking
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classPicking.cnn = _cnn
            classPicking.tdp_activaorden = _activaorden
            _msg = ""
            ds = classPicking.PICKING_MOTIVO_DEVOLUCION_CARGA_COMBO(_msg)
            If _msg = "" Then
                Me.cmbMotivo.DataSource = ds.Tables(0)
                Me.cmbMotivo.DisplayMember = "MENSAJE"
                Me.cmbMotivo.ValueMember = "CODIGO"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_TIPO_BOLETA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cmbMotivo.Text = "" Then
            MessageBox.Show("Debe seleccionar un motivo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        GLO_TIPO_DEVOLUCION_PICKING_CODIGO = cmbMotivo.SelectedValue
        GLO_TIPO_DEVOLUCION_PICKING_NOMBRE = cmbMotivo.Text
        GLO_TIPO_DEVOLUCION_PICKING_OBSERVACION = txtObservacion.Text
        Me.Dispose()
    End Sub

    Private Sub btnMarcarTodos_Click(sender As Object, e As EventArgs) Handles btnMarcarTodos.Click
        GLO_TIPO_DEVOLUCION_PICKING_CODIGO = 0
        GLO_TIPO_DEVOLUCION_PICKING_NOMBRE = ""
        GLO_TIPO_DEVOLUCION_PICKING_OBSERVACION = ""
        Me.Dispose()
    End Sub
End Class