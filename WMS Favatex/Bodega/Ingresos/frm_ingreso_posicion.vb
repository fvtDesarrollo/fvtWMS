﻿Imports System.Transactions
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class frm_ingreso_posicion
    Private _cnn As String
    Private _pos_codigo As Integer

    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Public Property pos_codigo() As Integer
        Get
            Return _pos_codigo
        End Get
        Set(ByVal value As Integer)
            _pos_codigo = value
        End Set
    End Property
    Private Sub frm_ingreso_posicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call INICIALIZA()
        If _pos_codigo > 0 Then
            Call CARGA_REGISTRO()
        End If
    End Sub
    Private Sub INICIALIZA()
        Call CARGA_COMBO_RACK()
        txtNombre.Text = ""

        txtNombre.Focus()
        chkActivo.Checked = True
    End Sub

    Private Sub CARGA_COMBO_RACK()
        Dim _msg As String
        Try
            Dim classRack As class_rack = New class_rack
            Dim ds As DataSet = New DataSet

            ds = Nothing
            classRack.cnn = _cnn
            _msg = ""
            ds = classRack.COMBO_CARGA_RACK(_msg)
            If _msg = "" Then
                Me.cmb_Rack.DataSource = ds.Tables(0)
                Me.cmb_Rack.DisplayMember = "mensaje"
                Me.cmb_Rack.ValueMember = "codigo"
            Else
                MessageBox.Show(_msg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_COMBO_RACK", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CARGA_REGISTRO()
        Dim class_posicion As class_posiciones = New class_posiciones
        Dim SearchChar As String = "-"
        Dim TestPos As Integer = 0
        Dim Fila As Integer = 0

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing
            class_posicion.cnn = _cnn
            class_posicion.pos_codigo = pos_codigo

            _msg = ""
            ds = class_posicion.posicion_listado(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("pos_codigo") > 0 Then
                        txtNombre.Text = ds.Tables(0).Rows(Fila)("pos_nombre")
                        chkActivo.Checked = ds.Tables(0).Rows(Fila)("pos_activo")
                        cmb_Rack.SelectedValue = ds.Tables(0).Rows(Fila)("rac_codigo")
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\CARGA_REGISTRO", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_REGISTRO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub

    Private Sub ButtonGurdar_Click(sender As Object, e As EventArgs) Handles ButtonGurdar.Click
        If valida_form() = False Then
            Exit Sub
        End If
        chkActivo.Focus()
        Call GUARDA_REGISTRO()
    End Sub

    Private Sub GUARDA_REGISTRO()
        Dim class_posicion As class_posiciones = New class_posiciones
        Dim ds As DataSet = New DataSet
        Dim _msgError As String = ""
        Dim conexion As New SqlConnection(_cnn)
        Dim scopeOptions = New TransactionOptions()
        Dim fila As Integer = 0
        Dim _msg As String = ""
        Dim respuesta As Integer = 0

        Try
            Using Transaccion As New TransactionScope(TransactionScopeOption.Required, scopeOptions)
                conexion.Open()
                class_posicion.pos_codigo = _pos_codigo
                class_posicion.pos_nombre = txtNombre.Text
                class_posicion.pos_activo = chkActivo.Checked
                class_posicion.rac_codigo = cmb_Rack.SelectedValue
                ds = class_posicion.posicion_guarda_registro(_msgError, conexion)
                If _msgError <> "" Then
                    If conexion.State = ConnectionState.Open Then
                        conexion.Close()
                    End If
                    ds = Nothing
                    MessageBox.Show(_msgError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    If ds.Tables(0).Rows(0)("codigo") < 0 Then
                        If conexion.State = ConnectionState.Open Then
                            conexion.Close()
                        End If
                        ds = Nothing
                        MessageBox.Show(ds.Tables(0).Rows(0)("mensaje"), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        _pos_codigo = ds.Tables(0).Rows(0)("codigo")
                    End If
                End If

                Transaccion.Complete()
                Transaccion.Dispose()
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
                ds = Nothing

                respuesta = MessageBox.Show("Los datos fueron guardados en forma correcta" _
                                + Chr(10) + "¿Desea ingresar otro registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = vbYes Then
                    _pos_codigo = 0
                    Call INICIALIZA()
                Else
                    Me.Dispose()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function VALIDA_FORM()
        VALIDA_FORM = False
        If Trim(txtNombre.Text) = "" Then
            MessageBox.Show("Debe ingresar nombre de la posicion, favor verificar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Focus()
            Exit Function
        End If
        If cmb_Rack.SelectedValue = 0 Then
            MessageBox.Show("Debe seleccionar rack, favor verificar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmb_Rack.Focus()
            Exit Function
        End If
        VALIDA_FORM = True

    End Function

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Call INICIALIZA()
    End Sub
End Class