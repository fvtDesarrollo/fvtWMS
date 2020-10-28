Public Class class_estructura_movimiento_rack
    Public filNew As Integer
    Public fila As Integer
    Public pro_codigo As Integer
    Public palletOrigen As String
    Public pallet As String
    Public pro_codigointerno As String
    Public pro_nombre As String
    Public pro_bulto As Integer
    Public bulto As String
    Public cantidad As Integer
    Public ubi_codigo As String
    Public ubi_nombre As String
    Public ubi_codigo2 As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal _filNew As Integer, ByVal _fila As Integer, ByVal _pro_codigo As Integer, ByVal _PalletOrigen As String, ByVal _pallet As String, ByVal _pro_codigointerno As String, ByVal _pro_nombre As String, ByVal _pro_bulto As Integer,
                   ByVal _bulto As String, ByVal _cantidad As Integer, ByVal _ubi_codigo As String, ByVal _ubi_nombre As String, Optional ByVal _ubi_codigo2 As Integer = 0)

        Me.filNew = _filNew
        Me.fila = _fila
        Me.pro_codigo = _pro_codigo
        Me.palletOrigen = _PalletOrigen
        Me.pallet = _pallet
        Me.pro_codigointerno = _pro_codigointerno
        Me.pro_nombre = _pro_nombre
        Me.pro_bulto = _pro_bulto
        Me.bulto = _bulto
        Me.cantidad = _cantidad
        Me.ubi_codigo = _ubi_codigo
        Me.ubi_nombre = _ubi_nombre
        Me.ubi_codigo2 = _ubi_codigo2
    End Sub
End Class
