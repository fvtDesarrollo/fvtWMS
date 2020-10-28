Public Class frm_mensaje
    Private _mensaje As String
    Public Property mensaje() As String
        Get
            Return _mensaje
        End Get
        Set(ByVal value As String)
            _mensaje = value
        End Set
    End Property
    Private Sub frm_mensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMensaje.Text = _mensaje
    End Sub
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()
    End Sub
End Class