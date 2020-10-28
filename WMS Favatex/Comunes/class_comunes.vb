Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail

Public Class class_comunes
    Private _cnn As String
    Private _per_codigo As Integer
    Private _IdRegion As Integer
    Private _IdCiudad As Integer
    Private _IdComuna As Integer
    Private _cor_codigo As Integer
    Private _cor_numeroactual As Integer
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Private _cod_flete As String
    Private _zog_codigo As Integer

    Public Property cor_numeroactual() As Integer
        Get
            Return _cor_numeroactual
        End Get
        Set(ByVal value As Integer)
            _cor_numeroactual = value
        End Set
    End Property
    Public Property cor_codigo() As Integer
        Get
            Return _cor_codigo
        End Get
        Set(ByVal value As Integer)
            _cor_codigo = value
        End Set
    End Property
    Public Property cnn() As String
        Get
            Return _cnn
        End Get
        Set(ByVal value As String)
            _cnn = value
        End Set
    End Property
    Public Property per_codigo() As Integer
        Get
            Return _per_codigo
        End Get
        Set(ByVal value As Integer)
            _per_codigo = value
        End Set
    End Property
    Public Property IdRegion() As Integer
        Get
            Return _IdRegion
        End Get
        Set(ByVal value As Integer)
            _IdRegion = value
        End Set
    End Property
    Public Property IdCiudad() As Integer
        Get
            Return _IdCiudad
        End Get
        Set(ByVal value As Integer)
            _IdCiudad = value
        End Set
    End Property
    Public Property IdComuna() As Integer
        Get
            Return _IdComuna
        End Get
        Set(ByVal value As Integer)
            _IdComuna = value
        End Set
    End Property
    Public Property cod_flete() As String
        Get
            Return _cod_flete
        End Get
        Set(ByVal value As String)
            _cod_flete = value
        End Set
    End Property
    Public Property zog_codigo() As Integer
        Get
            Return _zog_codigo
        End Get
        Set(ByVal value As Integer)
            _zog_codigo = value
        End Set
    End Property

    Public Function OBTIENE_FECHA(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_obtiene_fecha", conexion)

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CRGA_COMBO_ESTADO_PICKING(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_estado_picking_carga_combo", conexion)

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CARGA_COMBO_ESTADO_PENDIENTE_PICKING(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_estado_pendientes_picking_carga_combo", conexion)

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CRGA_COMBO_PERSONAS(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_personas_carga_combo", conexion)

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CARGA_COMBO_PICKEADORES(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_pikeadores_carga_combo", conexion)

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CARGA_DATOS_PERONA(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            'Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_persona_busca", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@per_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _per_codigo

            'command.ExecuteNonQuery()

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function CARGA_DATOS_COMUNA(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_comuna_listado", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@reg_codigo", SqlDbType.Int)
            command.Parameters.Add("@ciu_codigo", SqlDbType.Int)
            command.Parameters.Add("@com_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _IdRegion
            command.Parameters(1).Value = _IdCiudad
            command.Parameters(2).Value = _IdComuna

            'command.ExecuteNonQuery()

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function comuna_guarda_registro(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        Try
            Dim command As New SqlCommand("sp_comuna_actualiza", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@com_codigo", SqlDbType.Int)
            command.Parameters.Add("@cod_flete", SqlDbType.NVarChar)
            command.Parameters.Add("@zog_codigo", SqlDbType.Int)

            command.Parameters(0).Value = _IdComuna
            command.Parameters(1).Value = _cod_flete
            command.Parameters(2).Value = _zog_codigo

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function OPERARIOS_BODEGA_BUSCAR(ByRef Mensaje As String) As DataSet
        Dim conexion As New SqlConnection(_cnn)
        Try
            conexion.Open()
            Dim command As New SqlCommand("sp_carga_operario_bodega", conexion)
            command.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds
            conexion.Close()
        Catch ex As Exception
            Mensaje = ex.Message
            conexion.Close()
            Return Nothing
        End Try
    End Function


    Public Function validarRut(rut As String) As Boolean
        'Dim rut As Integer
        Dim digito As String
        Dim contarnumerodeauno As Integer
        Dim contar As Integer
        Dim acumulador As Integer
        Dim division As Integer
        Dim dig As Integer
        Dim dig2 As String



        contar = 2
        'rut = TextBox1.Text
        'digito = TextBox2.Text

        digito = Mid(rut.ToUpper(), rut.Length(), 1)

        rut = Mid(rut, 1, rut.Length() - 2)


        Do While rut <> 0
            contarnumerodeauno = (rut Mod 10) * contar

            acumulador = acumulador + contarnumerodeauno
            rut = rut \ 10
            contar = contar + 1

            If contar = 8 Then
                contar = 2
            End If

        Loop
        division = acumulador Mod 11
        If division = 0 Then
            division = 11
        End If
        dig = 11 - division
        dig2 = CStr(dig)

        If dig2 = 10 Then
            dig2 = "k"

        End If

        If UCase(dig2) = UCase(digito) Then
            validarRut = True
        Else
            validarRut = False
        End If
    End Function
    Public Function CARGA_COMBO_REGIONES(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_regiones_carga_combo", conexion)

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CARGA_COMBO_CIUDADES(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_ciudades_carga_combo", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@Id_Region", SqlDbType.Int)
            command.Parameters(0).Value = _IdRegion

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CARGA_COMBO_COMUNAS(ByRef Mensaje As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_comuna_carga_combo", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@Id_Ciudad", SqlDbType.Int)
            command.Parameters(0).Value = _IdCiudad

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CARGA_COMBO_ESTADO_FACTURA(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_estado_factura_carga_combo", conexion)

            command.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function CARGA_COMBO_PROVEEDOR(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_proveedores_carga_combo", conexion)
            command.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            conexion.Open()
            da.Fill(ds)
            conexion.Close()
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Sub ExportarExcel(ByVal grilla As DataGridView)
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet '= Nothing.worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        For i As Integer = 1 To grilla.Columns.Count
            worksheet.Cells(1, i) = grilla.Columns(i - 1).HeaderText
        Next
        For i As Integer = 0 To grilla.Rows.Count - 1
            For j As Integer = 0 To grilla.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = grilla.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        worksheet.PageSetup.Zoom = 85
        worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape
        worksheet.PageSetup.LeftMargin = 0
        worksheet.PageSetup.RightMargin = 0
        worksheet.Cells.Font.Size = 9
        worksheet.Rows.Item(1).Font.Bold = 1
        worksheet.Columns.AutoFit()
        worksheet.Columns.HorizontalAlignment = 2
        worksheet.PageSetup.CenterHeader = "Pendientes Mensajero:FECHA " & Date.Today & " "
        worksheet.PageSetup.CenterFooter = "Pendientes = "
        worksheet.PageSetup.PrintTitleRows = "$1:$1"
        worksheet.PageSetup.PrintTitleColumns = "$A:$H"
        app.Visible = True
        GC.Collect()
        'txt_cod_pend.Text = ""
        'cmb_mensa_pend.Text = ""
        grilla.Rows.Clear()
    End Sub
    Public Function OpenSubFormModal(ByVal form As Form, ByVal Mdi As Form) As Boolean
        'Chequeo si ya está abierto.
        For Each f As Form In Application.OpenForms
            'Si está abierto devuelvo False (no se puede abrir).
            If f.Name = form.Name Then
                Return False
            End If
        Next

        'Si se llega a este punto es porque no está abierto.
        'Abro el formulario.
        form.MdiParent = Mdi
        form.Show()

        'Indico apertura exitosa.
        Return True
    End Function

    Public Function OpenSubForm(ByVal form As Form) As Boolean
        'Chequeo si ya está abierto.
        For Each f As Form In Application.OpenForms
            'Si está abierto devuelvo False (no se puede abrir).
            If f.Name = form.Name Then
                Return False
            End If
        Next

        'Si se llega a este punto es porque no está abierto.
        'Abro el formulario.
        form.ShowDialog()

        'Indico apertura exitosa.
        Return True
    End Function

    Public Function OBTIENE_ULTIMO_CORRELATIVO_DOCUMETO(ByRef Msg As String) As DataSet
        Try
            Dim conexion As New SqlConnection(_cnn)
            Dim command As New SqlCommand("sp_carga_ultimo_correlativo_documento", conexion)

            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@cor_codigo", _cor_codigo))
            conexion.Open()
            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Msg = ex.Message
            Return Nothing
        End Try
    End Function
    Public Function ACTUALIZA_CORRELATIVO_DOCUMETO(ByRef Mensaje As String, ByVal conexion As SqlConnection) As DataSet
        'Dim conexion As New SqlConnection(_cnn)
        Try
            Dim command As New SqlCommand("[sp_actualiza_ultimo_correlativo_documento]", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("@cor_codigo", SqlDbType.Int)
            command.Parameters.Add("@cor_numeroactual", SqlDbType.Int)

            command.Parameters(0).Value = _cor_codigo
            command.Parameters(1).Value = _cor_numeroactual

            Dim da As New SqlDataAdapter(command)
            Dim ds As New DataSet

            da.Fill(ds)

            Return ds
        Catch ex As Exception
            Mensaje = ex.Message
            Return Nothing
        End Try
    End Function

    Public Function SUMA_DIAS_FECHA_COMPROMISO(ByVal Fecha As Date, ByVal Dias As Integer) As Date
        Dim FechaCompromiso As Date
        FechaCompromiso = CDate(Fecha.AddDays(Dias))
        If FechaCompromiso.DayOfWeek = DayOfWeek.Saturday Then
            FechaCompromiso = CDate(FechaCompromiso.AddDays(2))
        ElseIf FechaCompromiso.DayOfWeek = DayOfWeek.Sunday Then
            FechaCompromiso = CDate(FechaCompromiso.AddDays(1))
        End If

        Return FechaCompromiso
    End Function

    Public Function enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal ruta As String) As Boolean
        Try
            enviarCorreo = False
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))
            correos.Attachments.Clear()

            If ruta <> "" Then
                Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(ruta)
                correos.Attachments.Add(archivo)
            End If

            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            'MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
            enviarCorreo = True
        Catch ex As Exception
            enviarCorreo = False
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



End Class
