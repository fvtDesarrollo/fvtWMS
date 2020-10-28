Public Class frm_consulta_stock
    Private _cnn As String
    Private _pro_codigo As Integer
    Private _pro_nombre As String = ""

    Const COL_GRI_COD_BODEGA As Integer = 0
    Const COL_GRI_NOM_BODEGA As Integer = 1
    Const COL_GRI_STC_BODEGA As Integer = 2
    Const COL_GRI_BTD_BODEGA As Integer = 3
    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        _pro_codigo = 0
        If txtCodigo.Text = "" Then
            MessageBox.Show("Debe ingresar un código de producto válido", "Consulta de stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Call OBTIENE_PRODUCTO()

        If _pro_codigo > 0 Then
            Call OBTIENE_STOCK()
        Else
            MessageBox.Show("El código ingresado no se encuentra en la base de datos, verifique en el maestro de Prooductos", "Consulta de stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Call OBTIENE_STOCK()

    End Sub

    Private Sub CARGA_GRILLA_BODEGA()
        Dim class_stock As class_stock = New class_stock
        Dim Fila As Integer = 0

        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String

            ds = Nothing
            class_stock.cnn = _cnn
            class_stock.pro_codigo = _pro_codigo
            _msg = ""
            Grilla.Rows.Clear()
            ds = class_stock.CONSULTA_STOCK_BODEGA(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("bod_nombre") <> "" Then
                        Do While Fila < ds.Tables(0).Rows.Count
                            Grilla.Rows.Add(ds.Tables(0).Rows(Fila)("bod_codigo"),
                                            ds.Tables(0).Rows(Fila)("bod_nombre"),
                                            ds.Tables(0).Rows(Fila)("stock"),
                                            "")


                            Fila = Fila + 1
                        Loop
                        Call CONFIGURA_COLUMNAS()
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\CARGA_GRILLA_BODEGA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "CARGA_GRILLA_BODEGA", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub CONFIGURA_COLUMNAS()
        Grilla.Columns(COL_GRI_COD_BODEGA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_NOM_BODEGA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_STC_BODEGA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Grilla.Columns(COL_GRI_BTD_BODEGA).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub OBTIENE_STOCK()
        Dim class_stock As class_stock = New class_stock
        Dim Fila As Integer = 0
        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing
            class_stock.cnn = _cnn
            class_stock.pro_codigo = _pro_codigo

            _msg = ""
            ds = class_stock.CONSULTA_STOCK_PRODUCTO(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    'If ds.Tables(0).Rows(Fila)("fisico") > -1 Then
                    txtStockFisico.Text = ds.Tables(0).Rows(Fila)("fisico")
                    txtStockPendiente.Text = ds.Tables(0).Rows(Fila)("pendiente")
                    txtStockDisponible.Text = ds.Tables(0).Rows(Fila)("disponibleReal")
                    txtStockPorLlegar.Text = ds.Tables(0).Rows(Fila)("pro_llegar")
                    txtStockFuturo.Text = ds.Tables(0).Rows(Fila)("disponible_futuro")

                    Call CARGA_GRILLA_BODEGA()

                    'End If
                End If
            Else
                MessageBox.Show(_msg + "\OBTIENE_STOCK", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "OBTIENE_STOCK", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub OBTIENE_PRODUCTO()
        Dim class_productos As class_producto = New class_producto
        Dim Fila As Integer = 0
        Try
            Dim ds As DataSet = New DataSet
            Dim _msg As String
            ds = Nothing
            class_productos.cnn = _cnn
            class_productos.pro_codigo = 0
            class_productos.todos = 1
            class_productos.codigo_interno = IIf(txtCodigo.Text = "", "-", txtCodigo.Text)
            class_productos.cat_codigo = 0
            class_productos.sub_codigo = 0
            class_productos.pro_config = 0

            _msg = ""
            ds = class_productos.PRODUCTOS_LISTADO(_msg)
            If _msg = "" Then
                If ds.Tables(0).Rows.Count > 0 Then
                    If ds.Tables(0).Rows(Fila)("pro_codigo") > 0 Then
                        _pro_codigo = ds.Tables(0).Rows(Fila)("pro_codigo")
                        Me.Text = "Consulta de stock: " + UCase(ds.Tables(0).Rows(Fila)("pro_nombre"))
                        _pro_nombre = UCase(ds.Tables(0).Rows(Fila)("pro_nombre"))
                    End If
                End If
            Else
                MessageBox.Show(_msg + "\OBTIENE_PRODUCTO", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " " + "OBTIENE_PRODUCTO", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub frm_consulta_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As frm_imprimir = New frm_imprimir
        frm.Origen = "CSD"
        frm.bod_codigo = 0
        frm.pro_codigo = _pro_codigo
        frm.pro_nombre = "CODIGO: " + txtCodigo.Text + " PRODUCTO: " + _pro_nombre
        frm.bod_nombre = "BODEGA: TODAS LAS BODEGAS"
        frm.ShowDialog()
    End Sub

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        Try
            If e.ColumnIndex = 3 Then
                Dim frm As frm_imprimir = New frm_imprimir
                frm.Origen = "CSD"
                frm.bod_codigo = Grilla.Rows(e.RowIndex).Cells(0).Value
                frm.pro_codigo = _pro_codigo
                frm.pro_nombre = "PRODUCTO: " + _pro_nombre
                frm.bod_nombre = "BODEGA: " + Grilla.Rows(e.RowIndex).Cells(1).Value
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class