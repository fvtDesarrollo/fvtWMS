
'
'
'/**
'--------------------------------------------------
' Version .....: 15/03/2009 
'               [dd/mm/aaaa] 
' Original en .: Util
'--------------------------------------------------
'
'
' -------------------------------------------------
' Clase ....: CSV1
' Lenguaje .: (.NET Framework 3.5) - Visual Basic .NET (Version 9.0) - 2009
' Autor ....:  - Aguila - Joaquin Medina Serrano
' Emilio ...: mailto:joaquin@medina.name
'
' DESCRIPCION.:
'    Datos a formato CSV y al contrario
'    
' OBSERVACIONES.:
'    Sin la referecia [Microsoft.VisualBasic] Sin Usar ControlChars
'
'    La clase trabaja con una frase de texto. (OJO) una frase no un documento
'    Cada frase se supone que es una línea de datos en formato CSV
'
'    La clase tiene los siguientes metodos:
'    ----------------------------------------------
'    ToLineaCsv:
'          - Devuelve una cadena creada a partir de la combinación de varias 
'            subcadenas contenidas en una matriz.
'
'    LineaCsvToArray 
'          - Devuelve una matriz que contiene subcadenas, creada separando 
'            la cadena en partes, utilizando para ello carácter Separador  
'            de Campos especificado.
'
'    LineaCsvToDataRow
'          - Carga un DataRow con la información que contiene una cadena en formato CSV
'
'    LineaCsvToXml
'          - Convierte una cadena con formato CSV en un nodo XML
'
'    IsCaracterSeparadorCamposCorrecto 
'          - Comprueba si un carácter vale como carácter separador o no
'
'    AutoTet
'          - El proceso AutoTet, realiza una serie de comprobaciones para  
'            ver si las funciones Join y Split funcionan bien
'
'
'
' COMPORTAMIENTO DEL PROCESO LineaCsvToArray [SPLIT]
'             CSV                     Valor_ 1  Valor_ 2   Valor_3  
' (  1)  --> [a,b,c             ] ==> [a      ] [b      ] [c      ]
' (  2)  --> ["a",b,c           ] ==> [a      ] [b      ] [c      ]
' (  3)  --> ['a',b,c           ] ==> ['a'    ] [b      ] [c      ]
' (  4)  --> [  a  ,  b  ,  c   ] ==> [  a    ] [  b    ] [  c    ]
' (  5)  --> [aa,bb;cc,         ] ==> [aa     ] [bb;cc  ] [       ]
' (  6)  --> [a,,               ] ==> [a      ] [       ] [       ]
' (  7)  --> [,b,               ] ==> [       ] [b      ] [       ]
' (  8)  --> [,,c               ] ==> [       ] [       ] [c      ]
' (  9)  --> [,,                ] ==> [       ] [       ] [       ]
' ( 10)  --> ["",b,             ] ==> [       ] [b      ] [       ]
' ( 10)  --> [" ",b,            ] ==> [       ] [b      ] [       ]
' ( 12)  --> ["a,b",,           ] ==> [a,b    ] [       ] [       ]
' ( 13)  --> ["a,b",c,          ] ==> [a,b    ] [c      ] [       ]
' ( 14)  --> [" a  ,b ",c,      ] ==> [ a  ,b ] [c      ] [       ]
' ( 15)  --> [a b,c,            ] ==> [a b    ] [c      ] [       ]
' ( 16)  --> [a"b,c,            ] ==> [a"b    ] [c      ] [       ]
' ( 17)  --> ["a""b",c,         ] ==> [a"b    ] [c      ] [       ]
' ( 18)  --> [a""b,c,           ] ==> [a""b   ] [c      ] [       ]
' ( 19)  --> [a,b",c            ] ==> [a      ] [b"     ] [c      ]
' ( 20)  --> [a,b"",c           ] ==> [a      ] [b""    ] [c      ]
' ( 21)  --> [C, "Ed ""Ext""","4900,00"] 
'                                 ==> [C     ] [Ed "Ext"] [4900,00]
'
'
' BIBLIOGRAFIA.:
'    http://es.wikipedia.org/wiki/CSV
'    http://en.wikipedia.org/wiki/Comma-separated_values
'    http://tools.ietf.org/html/rfc4180
'    http://www.creativyst.com/Doc/Articles/CSV/CSV01.htm
'    http://xbeat.net/vbspeed/c_ParseCSV.php
'    http://www.creativyst.com/Doc/Std/ctx/ctx.htm
'
' MODIFICACIONES [dd/mm/aaaa] 
' - 08/03/2009 - Creación 
' - 11/03/2009 - Pasado por FxCop 1.36 Beta 2
'
' DERECHOS
'  Copyright (C) 2009 - Joaquin Medina Serrano
'
'  A pesar de las ¿Exhaustivas? , ¿Intesas?, 
'  y ¿cuidadosas? (ja, ja, ja..) pruebas a que he  
'  sometido este codigo, el principio de Murphy siempre 
'  esta trabajando y dice que si algo puede ir mal seguro 
'  que va mal. Por esa razon, Este codigo se porporciona 
'  *Como esta* sin ninguna garantia de ninguna clase 
'
'  Este codigo es BirraWare, es decir, si lo empleas, 
'  estas obligado de forma ineludible a:
'  a) Indicar claramente el autor (o sea mi nombre) 
'     y el sitio Web de donde se lo has copiado 
'     (o sea mi web) 
'  b) Invitar a una cerveza a su creador, (o sea a mi), 
'     si no me localizas, me conformo con que me envies 
'     un *emilio* contandome para que lo has empleado.
'  c) Si haces algo interesante me gustaria verlo 
'
'  NOTA: 
'  Se otorga permiso para copiar, distribuir este 
'  documento bajo los términos de la Licencia de 
'  Documentación libre GNU, versión 1.2. o posterior 
'  publicada por la Free Software Foundation. 
'  Se puede consultar una copia de la licencia en 
'  http://www.gnu.org/copyleft/fdl.html
' -------------------------------------------------
'
'*/
'


' -------------------------------------------------
Option Explicit On
Option Strict On
Option Infer Off
Option Compare Binary


Imports System.Text.RegularExpressions
Imports System.Data

Namespace Util.Cadenas

    ''' -------------------------------------------------
    '''  <summary>
    '''    Permite Manejar lineas de texto con formato CSV. Puede crearlas 
    '''    y /o recuperar su informacion
    '''  </summary>
    ''' -------------------------------------------------
    Public NotInheritable Class Csv


        ''' <summary>
        '''  Constructor privado
        ''' </summary>
        Private Sub New()
            ' no hacer nada
            ' por el [NotInheritable]
        End Sub



#Region "Control de valores del carácter separador"


        ''' <summary>
        '''  Comprueba si un carácter vale como carácter separador o no
        ''' </summary>
        ''' <param name="caracterSeparadorCampos">El carácter que se va a utilizar como separador de campos</param>
        ''' <returns>
        '''    <para>Un valor logico que indica:</para>
        '''    <para>TRUE-- el caracfter sirve como separador</para>
        '''    <para>FALSE - No sirve</para>
        ''' </returns>
        Public Shared Function IsCaracterSeparadorCamposCorrecto(ByVal caracterSeparadorCampos As Char) As Boolean
            Dim salida As Boolean = True ' supongo que el caracter es bueno
            Try
                Call ControlCaracterSeparadorCampos(caracterSeparadorCampos)
            Catch ex As Exception
                salida = False
            End Try
            Return salida
        End Function


        ''' <summary>
        '''   Comprueba que el carácter seleccionado como separador de campos 
        '''   no esté en la lista de caracteres no permitidos
        ''' </summary>
        ''' <param name="caracterSeparadorCampos">El carácter que se va a utilizar como separador de campos</param>
        ''' <remarks>
        ''' Si el carácter es válido, no pasa nada, si el carácter no está permitido se dispara una excepción. </remarks>
        ''' <exception cref="ArgumentNullException">
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >caracterSeparadorCampos</paramref>
        '''           es null (Nothing en Visual Basic</para> 
        ''' </exception>
        ''' <exception cref="ArgumentException">
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >caracterSeparadorCampos</paramref>
        '''           es un valor prohibido. En general cualquier carácter de control (ASCII menor de 32),
        '''           las comillas dobles (ASCII = 34), y el carácter Backspace Delete (ASCII = 127). 
        '''           Sin embargo, el carácter Tabulación Horizontal (ASCII = 8) es un carácter valido</para> 
        ''' </exception>
        Private Shared Sub ControlCaracterSeparadorCampos(ByVal caracterSeparadorCampos As Char)

            '------------------------------------------------------------------
            Dim valorDecimal As Integer = 0
            Dim provider As System.IFormatProvider = Nothing
            '------------------------------------------------------------------
            Try

                '------------------------------------------------------------------
                ' Control de valor NULL
                If caracterSeparadorCampos = Nothing Then
                    Throw New ArgumentNullException(
                    "caracterSeparadorCampos",
                     "El valor del [caracterSeparadorCampos] es null (Nothing en Visual Basic)")
                End If


                ' --------------------------------------
                'Control de los valores CORRECTOS mas frecuentes
                ' una coma(,) un punto y coma(;), un Pipe(|)
                If caracterSeparadorCampos = ","c OrElse
                       caracterSeparadorCampos = ";"c OrElse
                       caracterSeparadorCampos = "|"c Then
                    Exit Sub
                End If



                '------------------------------------------------------------------
                ' No puede ser un caracter numero ni letra
                If Char.IsLetterOrDigit(caracterSeparadorCampos) = True Then
                    Using SW As New System.IO.StringWriter(System.Globalization.CultureInfo.CurrentCulture)
                        SW.WriteLine()
                        SW.WriteLine("El [caracterSeparadorCampos] no puede ser ni una letra ni un número ")
                        SW.WriteLine("-- Valor = [{0}] ", caracterSeparadorCampos)
                        SW.Flush()
                        Throw New ArgumentException(
                         SW.ToString,
                         "caracterSeparadorCampos")
                    End Using
                End If


                '------------------------------------------------------------------
                ' No puede ser un caracter de control
                ' excepto el tabulador horizontal

                '------------------------------------------------------------------
                ' CARACTERES DE CONTROL
                'http://es.wikipedia.org/wiki/ASCII
                ' Binario      Decimal  Hex   Abreviatura    AT     Nombre/Significado} 
                '0000 1001,      9,      09,   HT ,          ^I,    Tabulación horizontal }, _
                '------------------------------------------------------------------


                Dim caracteresProhibidos(,) As String = {
                {"0000 0000", "  0", "  00", " NUL   ", "    ^@", " Carácter Nulo "},
                {"0000 0001", "  1", "  01", " SOH   ", "    ^A", " Inicio de Encabezado "},
                {"0000 0010", "  2", "  02", " STX   ", "    ^B", " Inicio de Texto "},
                {"0000 0011", "  3", "  03", " ETX   ", "    ^C", " Fin de Texto "},
                {"0000 0100", "  4", "  04", " EOT   ", "    ^D", " Fin de Transmisión "},
                {"0000 0101", "  5", "  05", " ENQ   ", "    ^E", " Enquiry "},
                {"0000 0110", "  6", "  06", " ACK   ", "    ^F", " Acknowledgement "},
                {"0000 0111", "  7", "  07", " BEL   ", "    ^G", " Timbre "},
                {"0000 1000", "  8", "  08", " BS    ", "    ^H", " Retroceso "},
                {"0000 1010", " 10", "  0A", " LF    ", "    ^J", " Line feed "},
                {"0000 1011", " 11", "  0B", " VT    ", "    ^K", " Tabulación Vertical "},
                {"0000 1100", " 12", "  0C", " FF    ", "    ^L", " Form feed "},
                {"0000 1101", " 13", "  0D", " CR    ", "    ^M", " Carriage return "},
                {"0000 1110", " 14", "  0E", " SO    ", "    ^N", " Shift Out "},
                {"0000 1111", " 15", "  0F", " SI    ", "    ^O", " Shift In "},
                {"0001 0000", " 16", "  10", " DLE   ", "    ^P", " Data Link Escape "},
                {"0001 0001", " 17", "  11", " DC1   ", "    ^Q", " Device Control 1 — oft. XON "},
                {"0001 0010", " 18", "  12", " DC2   ", "    ^R", " Device Control 2 "},
                {"0001 0011", " 19", "  13", " DC3   ", "    ^S", " Device Control 3 — oft. XOFF "},
                {"0001 0100", " 20", "  14", " DC4   ", "    ^T", " Device Control 4 "},
                {"0001 0101", " 21", "  15", " NAK   ", "    ^U", " Negative Acknowledgement "},
                {"0001 0110", " 22", "  16", " SYN   ", "    ^V", " Synchronous Idle "},
                {"0001 0111", " 23", "  17", " ETB   ", "    ^W", " End of Trans. Block "},
                {"0001 1000", " 24", "  18", " CAN   ", "    ^X", " Cancel "},
                {"0001 1001", " 25", "  19", " EM    ", "    ^Y", " End of Medium "},
                {"0001 1010", " 26", "  1A", " SUB   ", "    ^Z", " Substitute "},
                {"0001 1011", " 27", "  1B", " ESC   ", "    ^[", " or ESC Escape "},
                {"0001 1100", " 28", "  1C", " FS    ", "    ^\", " File Separator "},
                {"0001 1101", " 29", "  1D", " GS    ", "    ^]", " Group Separator "},
                {"0001 1110", " 30", "  1E", " RS    ", "    ^^", " Record Separator "},
                {"0001 1111", " 31", "  1F", " US    ", "    ^_", " Unit Separator "},
                {"0010 0000", " 32", "  20", " No hay", "No hay", " espacio ( ) "},
                {"0010 0010", " 34", "  22", " No hay", "No hay", " comillas dobles "},
                {"0111 1111", "127", "  7F", " DEL   ", "    ^?", " Delete o Backspace Delete "}
                }

                '------------------------------------------------------------------
                valorDecimal = 0
                provider = System.Globalization.CultureInfo.CurrentCulture


                For index As Integer = caracteresProhibidos.GetLowerBound(0) To caracteresProhibidos.GetUpperBound(0)

                    valorDecimal = Integer.Parse(caracteresProhibidos(index, 1), provider)
                    If caracterSeparadorCampos = CType(Char.ConvertFromUtf32(valorDecimal), Char) Then
                        Using SW As New System.IO.StringWriter(System.Globalization.CultureInfo.CurrentCulture)
                            SW.WriteLine()
                            SW.WriteLine("El [caracterSeparadorCampos] no puede tomar ese valor")
                            SW.WriteLine("--Valor Binario .... = [{0}] ", caracteresProhibidos(index, 0))
                            SW.WriteLine("--Valor Decimal .... = [{0}] ", caracteresProhibidos(index, 1))
                            SW.WriteLine("--Valor Hexadecimal. = [{0}] ", caracteresProhibidos(index, 2))
                            SW.WriteLine("--Abreviatura  ..... = [{0}] ", caracteresProhibidos(index, 3))
                            SW.WriteLine("--AT ............... = [{0}] ", caracteresProhibidos(index, 4))
                            SW.WriteLine("--Nombre/Significado = [{0}] ", caracteresProhibidos(index, 5))

                            SW.Flush()
                            Throw New ArgumentException(
                              SW.ToString,
                             "caracterSeparadorCampos")
                        End Using
                    End If
                Next




                ' [123] = [{] --> Bueno 
                ' [124] = [|] --> Bueno 
                ' [125] = [}] --> Bueno 
                ' [126] = [~] --> Bueno 
                ' [128] = [] --> Bueno 
                ' [129] = [] --> Bueno 
                ' [130] = [] --> Bueno 
                ' [131] = [] --> Bueno 
                ' [132] = [] --> Bueno 
                ' [133] = [
                '] --> Bueno 
                ' [134] = [] --> Bueno 
                ' [135] = [] --> Bueno 
                ' [136] = [] --> Bueno 
                ' [137] = [] --> Bueno 
                ' [138] = [] --> Bueno 
                ' [139] = [] --> Bueno 
                ' [140] = [] --> Bueno 
                ' [141] = [] --> Bueno 
                ' [142] = [] --> Bueno 
                ' [143] = [] --> Bueno 
                ' [144] = [] --> Bueno 
                ' [145] = [] --> Bueno 
                ' [146] = [] --> Bueno 
                ' [147] = [] --> Bueno 
                ' [148] = [] --> Bueno 
                ' [149] = [] --> Bueno 
                ' [150] = [] --> Bueno 
                ' [151] = [] --> Bueno 
                ' [152] = [] --> Bueno 
                ' [153] = [] --> Bueno 
                ' [154] = [] --> Bueno 
                ' [155] = [] --> Bueno 
                ' [156] = [] --> Bueno 
                ' [157] = [] --> Bueno 
                ' [158] = [] --> Bueno 
                ' [159] = [] --> Bueno 
                ' [160] = [ ] --> Bueno

                For index As Integer = 128 To 160
                    If caracterSeparadorCampos = CType(Char.ConvertFromUtf32(index), Char) Then
                        Using SW As New System.IO.StringWriter(System.Globalization.CultureInfo.CurrentCulture)
                            SW.WriteLine()
                            SW.WriteLine("El [caracterSeparadorCampos] no puede tomar ese valor")
                            SW.WriteLine("--Valor Decimal .... = [{0}] ", index)
                            SW.WriteLine("--Valor Hexadecimal. = [{H0}] ", index)
                            SW.WriteLine("-- Valor             = [{0}] ", caracterSeparadorCampos)
                            SW.Flush()
                            Throw New ArgumentException(
                             SW.ToString,
                             "caracterSeparadorCampos")
                        End Using
                    End If
                Next


                ' El caracter ASCII = 92 --> [\] tambien esta prohibido
                ' para que sea compatible con el formato CTX
                If caracterSeparadorCampos = CType(Char.ConvertFromUtf32(92), Char) Then
                    Using SW As New System.IO.StringWriter(System.Globalization.CultureInfo.CurrentCulture)
                        SW.WriteLine()
                        SW.WriteLine("El [caracterSeparadorCampos] no puede tomar ese valor")
                        SW.WriteLine("--Valor Decimal .... = [{0}] ", 92)
                        SW.WriteLine("--Valor Hexadecimal. = [{H0}] ", 92)
                        SW.WriteLine("-- Valor             = [{0}] ", caracterSeparadorCampos)
                        SW.Flush()
                        Throw New ArgumentException(
                         SW.ToString,
                         "caracterSeparadorCampos")
                    End Using
                End If

                '------------------------------------------------------------------
            Catch ex As Exception
                Throw
            Finally
                valorDecimal = Nothing
                provider = Nothing
            End Try


        End Sub

#End Region


#Region "ToLineaCsv - Devuelve una cadena creada a partir de la combinación de varias subcadenas contenidas en una matriz."


        ''' ----------------------------------------------------------------------------------
        ''' <summary>
        '''    Devuelve una cadena creada a partir de la combinación de varias subcadenas contenidas en una matriz.
        ''' </summary>
        ''' <param name="matrizElementos">
        ''' una lista de valores separados por una coma o bien 
        ''' una matriz cuyos datos se van a montar como una línea de un documento CSV
        ''' </param>
        ''' <returns>Objeto String formado por los elementos de matrizElementos intercalados con la cadena separador  (coma(,)). </returns>
        ''' <exception cref="ArgumentNullException">
        '''    <para> El valor de <paramref name="matrizElementos" >matrizElementos</paramref> es null (Nothing en Visual Basic</para> 
        ''' </exception>

        Public Overloads Shared Function ToLineaCsv(ByVal ParamArray matrizElementos() As String) As String
            Return ToLineaCsv(","c, matrizElementos)
        End Function


        '---------------------------------------------
        ' Esta es la función que hace el trabajo
        '---------------------------------------------
        '           1         2         3         4         5         6         7   
        ' 01234567890123456789012345678901234567890123456789012345678901234567890

        ''' ---------------------------------------------------------------------
        ''' <summary>
        '''    Devuelve una cadena creada a partir de la combinación de 
        '''   varias subcadenas contenidas en una matriz.
        ''' </summary>
        ''' <param name="caracterSeparadorCampos">
        ''' El carácter que se va a utilizar como separador de campos
        ''' </param>
        ''' <param name="matrizElementos">
        ''' La matriz cuyos datos se van a montar como una línea  
        ''' de un documento CSV
        ''' </param>
        ''' <returns>
        ''' Objeto String formado por los elementos de matrizElementos 
        ''' intercalados con la cadena separador. 
        ''' </returns>
        ''' <remarks>
        '''  <para>Por ejemplo, si <paramref name="caracterSeparadorCampos" >
        '''        caracterSeparadorCampos</paramref> es ", " 
        '''        y los elementos de  <paramref name="matrizElementos" >
        '''        matrizElementos</paramref> son 
        '''        "manzana", "naranja", "uva" y "pera", 
        '''        <c>ToLineaCsv(caracterSeparadorCampos, matrizElementos)</c> 
        '''           devuelve una cadena con la siguiente información 
        '''        [manzana, naranja, uva, pera CRLF]. 
        '''  </para>
        '''  <para>Si <paramref name="caracterSeparadorCampos" >
        '''        caracterSeparadorCampos</paramref> es 
        '''        null  (Nothing en Visual Basic), se dispara una 
        '''        excepción [ArgumentNullException]
        ''' </para>
        ''' <para> Cada elemento puede ir rodeado o no de comillas dobles, 
        '''        pero siempre va rodeado si se cumplen cualquiera de las 
        '''        siguientes condiciones:
        ''' </para>
        ''' <para> Existe un carácter separador dentro del elemento 
        '''        P.E. [52.45]  === . [“52.45”]</para>
        ''' <para> Existe un salto de línea dentro del elemento
        '''        (caracteres CrLf)
        ''' </para>
        ''' <para> Existen (uno o más) espacios en blanco en el elemento 
        '''        P.E:[ciudad lineal] === :[“ciudad lineal”]</para>
        ''' <para> Existen (una o más) comillas dobles dentro del elemento 
        '''        P.E [pegamento “maravilloso”]. En este caso,  cada una de las 
        '''        comillas dobles existentes se duplican, y a continuación, 
        '''        se rodea el elemento con comillas dobles</para>
        ''' <para> Ejemplo:</para>
        ''' <para> Valor inicial = [pegamento "maravilloso"].</para>
        ''' <para> Paso Uno: Duplicando comillas [pegamento ""maravilloso""].</para>
        ''' <para> Paso Dos: Rodeando con comillas ["pegamento ""maravilloso"""].</para>
        '''</remarks>
        ''' <exception cref="ArgumentNullException">
        '''    <para> El valor de <paramref name="matrizElementos" >
        '''           matrizElementos</paramref> </para> 
        '''    <para> o bien</para> 
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >
        '''           caracterSeparadorCampos</paramref></para> 
        '''    <para> es null (Nothing en Visual Basic</para> 
        ''' </exception>
        ''' <exception cref="ArgumentException">
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >
        '''           caracterSeparadorCampos</paramref>
        '''           es uno de los caracteres que no son válidos para actuar 
        '''           como separador de campos
        ''' </para> 
        ''' </exception>
        ''' <Copyright> 
        '''    <para> Copyright: Joaquin Medina Serrano [joaquin@medina.name]</para>
        '''    <para> Version .: [2009/03/15] </para>
        ''' </Copyright>
        Public Overloads Shared Function ToLineaCsv(
                    ByVal caracterSeparadorCampos As Char,
                    ByVal ParamArray matrizElementos() As String) _
                    As String

            '-----------------------------------
            ' Control de parametros
            If matrizElementos Is Nothing Then
                Throw New ArgumentNullException(
                "matrizElementos",
                "El valor de la [matrizElementos()] es null" &
                " (Nothing en Visual Basic)")
            End If
            ' si solo tiene un elemento y tiene el valor Nothing
            ' se devuelve una cadena vacia
            If matrizElementos.Length = 1 Then
                If matrizElementos(0) = Nothing Then
                    Return String.Empty
                End If
            End If

            ' Comprobar el separador de campos
            ' Si es erróneo se dispara una excepción
            Call ControlCaracterSeparadorCampos(caracterSeparadorCampos)



            ' --------------------------------------
            'Control de los valores CORRECTOS mas frecuentes
            ' una coma(,) un punto y coma(;), un Pipe(|)
            If Not (caracterSeparadorCampos = ","c OrElse
                    caracterSeparadorCampos = ";"c OrElse
                    caracterSeparadorCampos = "|"c) Then
                Throw New ArgumentException(
                 "El [caracterSeparadorCampos] no es valido ",
                 "caracterSeparadorCampos")
            End If




            '-----------------------------------
            ' Definiendo variables
            Const QUOTE As Char = """"c
            Dim salida As String = String.Empty
            Dim aux As String = String.Empty
            Dim caracterAux As Char = Nothing
            Dim rodearConComillas As Boolean = False
            '-----------------------------------
            ' Proceso
            Try
                '-----------------------------------
                ' Recorrer la matriz para montar la cadena
                For i As Integer = matrizElementos.GetLowerBound(0) To _
                                   matrizElementos.GetUpperBound(0)
                    '-------
                    ' en principio el texto va tal cual 
                    rodearConComillas = False
                    '-------
                    ' obtener unelemento de la matriz
                    aux = matrizElementos(i)
                    '-----------------------------
                    'MODIFICACIONES DEL TEXTO
                    '-----------------------------
                    ' caso uno 
                    ' El elemento tiene el carácter separador, 
                    ' rodear todo el texto con comillas dobles
                    'ejemplo 5,34 --> "5,34"
                    If aux.IndexOf(caracterSeparadorCampos) <> -1 Then
                        ' poner las comillas
                        rodearConComillas = True
                    End If
                    '-----------------

                    ' caso dos
                    ' Si el elemento tiene dobles comillas hay que 'escaparlas' 
                    ' poniendo otra doble comilla junto a ella, y 
                    ' después rodear todo el texto con comillas dobles
                    ' ejemplo
                    '      Venture "Extended Edition"
                    '     "Venture ""Extended Edition"""
                    If aux.IndexOf(QUOTE) <> -1 Then
                        ' no uso replace porque me da problemas
                        ' aux = aux.Replace(QUOTE, QUOTE & QUOTE)
                        Dim remplaza As String = String.Empty
                        For Each caracter As Char In aux
                            remplaza = remplaza & caracter
                            'doblar las comillas
                            If caracter = QUOTE Then
                                remplaza = remplaza & QUOTE
                            End If
                        Next
                        ' Valor modificado
                        aux = remplaza
                        ' poner las comillas
                        rodearConComillas = True
                    End If

                    '-----------------
                    ' caso tres
                    ' si el elemento contiene roturas de línea 
                    ' rodear todo el texto con comillas dobles
                    ' http://es.wikipedia.org/wiki/ASCII
                    caracterAux = CType(Char.ConvertFromUtf32(10), Char) ' LF
                    If aux.IndexOf(caracterAux) <> -1 Then
                        ' poner las comillas
                        rodearConComillas = True
                    End If
                    caracterAux = CType(Char.ConvertFromUtf32(13), Char) ' CR
                    If aux.IndexOf(caracterAux) <> -1 Then
                        ' poner las comillas
                        rodearConComillas = True
                    End If
                    '-----------------

                    ' caso cuatro
                    ' si el elemento contiene espacios dentro de la cadena
                    ' rodear todo el texto con comillas dobles
                    If aux.IndexOf(" "c) <> -1 Then
                        ' poner las comillas
                        rodearConComillas = True
                    End If

                    '---------------------------------
                    '---------------------------------
                    'Rodear con comillas el texto
                    If rodearConComillas = True Then
                        '-----------------------------
                        ' Si hay comillas rodeando no se hace nada
                        ' en caso contrario se ponen las comillas
                        ' ejemplo  5,34  --> "5,34"
                        ' ejemplo "5,34" --> no se hace nada
                        '-----------------------------

                        If Not (aux.Trim.StartsWith(
                                     QUOTE,
                                     StringComparison.CurrentCulture) AndAlso
                                aux.Trim.EndsWith(
                                     QUOTE,
                                     StringComparison.CurrentCulture)) Then
                            ' poner las comillas
                            ' Observa que no elimino los espacios al poner las comillas
                            ' LOS ESPACIOS DE CADA ELEMENTO HAY QUE MANTENERLOS
                            '
                            ' Sin embargo, y únicamente en la interrogación,
                            ' elimino los espacios inciales y finales de la cadena
                            ' para ver si el elemento está rodeado o no de comillas
                            aux = QUOTE & aux & QUOTE
                        End If
                    End If

                    '-----------------------------
                    ' OJO, el último elemento no lleva una coma (carácter separador)
                    ' si solo hay un elemento  tampoco hay coma (carácter separador)
                    ' El carácter separador de líneas es el salto de línea (CrLf)
                    '-----------------------------
                    If i = matrizElementos.GetUpperBound(0) Then
                        ' es el ultimo , Meter un fin de linea
                        salida = salida & aux & Environment.NewLine
                    Else
                        salida = salida & aux & caracterSeparadorCampos
                    End If
                Next
            Catch ex As Exception
                Throw
            Finally
                aux = Nothing
            End Try
            '-----------------------------------
            ' Devolver resultado obtenido
            Return salida
        End Function

#End Region

#Region "LineaCsvToArray - Devuelve una matriz de cadenas con las subcadenas de la cadena pasada por parámetro "


        ''' <summary> 
        '''   Separa los datos de una cadena codificada en formato CSV y devuelve una matriz de Cadenas con los datos obtenidos (y separados)
        '''   Devuelve una matriz de cadenas con las subcadenas de la cadena pasada por parámetro 
        '''   que están delimitadas por el caracterSeparadorCampos especificado. 
        ''' </summary>
        ''' <param name="lineaConFormatoCsv">cadena a analizar, la cadena  que vamos a partir</param>
        ''' <returns>
        '''    Una matriz cuyos elementos contienen las subcadenas de 
        '''    <paramref name="lineaParaAnalizar" >lineaParaAnalizar</paramref>  
        '''    que están delimitadas por una coma (,) como caracterSeparadorCampos
        ''' </returns>
        ''' <exception cref="ArgumentNullException">
        '''    <para> El valor de <paramref name="lineaParaAnalizar" >lineaParaAnalizar</paramref> es null(Nothing en Visual Basic</para> 
        ''' </exception>
        Public Overloads Shared Function LineaCsvToArray(ByVal lineaConFormatoCsv As String) As String()
            Return LineaCsvToArray(","c, lineaConFormatoCsv)
        End Function


        '---------------------------------------------
        'Esta es la función que hace el trabajo para todas las demas funciones
        '---------------------------------------------
        '           1         2         3         4         5         6         7   
        ' 01234567890123456789012345678901234567890123456789012345678901234567890


        ''' <summary>
        '''   Devuelve una matriz de cadenas con las subcadenas de la 
        '''   cadena pasada por parámetro que están delimitadas por el 
        '''   caracterSeparadorCampos especificado. 
        ''' </summary>
        ''' <param name="caracterSeparadorCampos">
        '''   El carácter que se va a utilizar como separador de campos
        ''' </param>
        ''' <param name="lineaConFormatoCsv">
        '''    Cadena a analizar, la cadena  que vamos a partir
        ''' </param>
        ''' <returns>
        '''    Una matriz cuyos elementos contienen las subcadenas de 
        '''    <paramref name="lineaConFormatoCsv" >
        '''    lineaConFormatoCsv</paramref>  
        '''    que están delimitadas 
        '''    por el <paramref name="caracterSeparadorCampos" >
        '''    caracterSeparadorCampos</paramref>.
        ''' </returns>
        ''' <remarks>
        '''  <para> 
        '''     El [caracterSeparadorCampos] no se incluye en los 
        '''     elementos de la matriz devuelta.
        '''  </para>
        '''  <para> 
        '''     Si la cadena no contiene ningun [caracterSeparadorCampos], 
        '''     la matriz devuelta estará formada por un solo elemento 
        '''     que contiene la cadena. 
        ''' </para>
        '''  <para> 
        '''     Si la [lineaParaAnalizar] esta vacía (empty), 
        '''     la matriz devuelta estará formada por un solo 
        '''     elemento que contiene el valor [Empty]. 
        ''' </para>
        '''  <para> 
        '''     Si dos delimitadores son adyacentes o el delimitador 
        '''     se encuentra al principio o al final de la [lineaParaAnalizar], 
        '''     el elemento de matriz correspondiente contiene Empty. 
        ''' </para>
        '''  <para>
        '''     Si hay comillas rodeando una subcadenas, hay que
        '''     quitarlas. Ejemplo ["5,34"] --> 5,34 
        ''' </para>
        '''  <para>
        '''     Si una subcadenas contiene dos comillas dobles 
        '''     seguidas, se sustituyen por una sola
        ''' </para>
        '''  <para>ejemplo</para>
        '''  <para>  subcadena de entrada ..= Venture ""Extended Edition""</para>
        '''  <para>  salida generada .......= Venture "Extended Edition"</para>
        ''' <example>
        ''' 
        '''   COMPORTAMIENTO DEL PROCESO 
        '''             CSV                     Valor_ 1  Valor_ 2   Valor_3  
        '''    1)  --> [a,b,c          ] ==> [a      ] [b      ] [c      ]
        '''    2)  --> ["a",b,c        ] ==> [a      ] [b      ] [c      ]
        '''    3)  --> ['a',b,c        ] ==> ['a'    ] [b      ] [c      ]
        '''    4)  --> [  a  ,  b  ,  c] ==> [  a    ] [  b    ] [  c    ]
        '''    5)  --> [aa,bb;cc,      ] ==> [aa     ] [bb;cc  ] [       ]
        '''    6)  --> [a,,            ] ==> [a      ] [       ] [       ]
        '''    7)  --> [,b,            ] ==> [       ] [b      ] [       ]
        '''    8)  --> [,,c            ] ==> [       ] [       ] [c      ]
        '''    9)  --> [,,             ] ==> [       ] [       ] [       ]
        '''   10)  --> ["",b,          ] ==> [       ] [b      ] [       ]
        '''   10)  --> [" ",b,         ] ==> [       ] [b      ] [       ]
        '''   12)  --> ["a,b",,        ] ==> [a,b    ] [       ] [       ]
        '''   13)  --> ["a,b",c,       ] ==> [a,b    ] [c      ] [       ]
        '''   14)  --> [" a  ,b ",c,   ] ==> [ a  ,b ] [c      ] [       ]
        '''   15)  --> [a b,c,         ] ==> [a b    ] [c      ] [       ]
        '''   16)  --> [a"b,c,         ] ==> [a"b    ] [c      ] [       ]
        '''   17)  --> ["a""b",c,      ] ==> [a"b    ] [c      ] [       ]
        '''   18)  --> [a""b,c,        ] ==> [a""b   ] [c      ] [       ]
        '''   19)  --> [a,b",c         ] ==> [a      ] [b"     ] [c      ]
        '''   20)  --> [a,b"",c        ] ==> [a      ] [b""    ] [c      ]
        '''
        '''</example>
        ''' <code> 
        '''   Esta función esta inspirada en el código que 
        '''   se encuentra en la página 
        '''   http://xbeat.net/vbspeed/c_ParseCSV.php
        ''' </code>
        '''</remarks>
        ''' <exception cref="ArgumentNullException">
        '''    <para> El valor de <paramref name="lineaConFormatoCsv" >
        '''           lineaConFormatoCsv</paramref> </para> 
        '''    <para> o bien</para> 
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >
        '''           caracterSeparadorCampos</paramref></para> 
        '''    <para> es null (Nothing en Visual Basic</para> 
        ''' </exception>
        ''' <exception cref="ArgumentException">
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >
        '''           caracterSeparadorCampos</paramref>
        '''           es uno de los caracteres que no son válidos para actuar 
        '''           como separador de campos
        ''' </para> 
        ''' </exception>
        ''' <Copyright> 
        '''    <para> Copyright: Joaquin Medina Serrano [joaquin@medina.name]</para>
        '''    <para> Version .: [2009/03/15] </para>
        ''' </Copyright>
        Public Overloads Shared Function LineaCsvToArray(
                   ByVal caracterSeparadorCampos As Char,
                   ByVal lineaConFormatoCsv As String) _
                   As String()

            '-----------------------------------
            ' Control de parámetros
            If lineaConFormatoCsv Is Nothing Then
                Throw New ArgumentNullException(
                "lineaConFormatoCsv",
                "El valor de la [matrizElementos()] " &
                "es null (Nothing en Visual Basic)")
            End If

            If lineaConFormatoCsv.Length = 0 Then
                Dim auxBorrar As String() = {String.Empty}
                Return auxBorrar
            End If

            ' Comprobar el separador de campos
            ' Si es erróneo se dispara una excepción
            Call ControlCaracterSeparadorCampos(caracterSeparadorCampos)

            '-----------------------------------
            ' Definiendo variables
            '-----------------------
            Const QUOTE As Char = """"c
            Dim arrayDatosIndividuales As String() = Nothing
            '-----------------------

            Dim objRegEx As _
                System.Text.RegularExpressions.Regex = Nothing
            Dim objMatchCollection As _
                System.Text.RegularExpressions.MatchCollection = Nothing
            Dim objMatch As _
                System.Text.RegularExpressions.Match = Nothing
            '-----------------------
            Dim indice As Integer = 0
            Dim oc As String = ""
            Dim Aux As String = String.Empty
            '-------------------------------------------------------------
            ' Cadena para separar utilizando la coma como separador
            ' Dim patron As String = "(\s*""[^""]*""\s*,)|(\s*[^,]*\s*,)"
            '-------------------------------------------------------------
            ' Cadena modificada para que acepte cualquier separador
            Dim patron As String =
                     "(\s*""[^""]*""\s*" & caracterSeparadorCampos &
                     ")|(\s*[^" & caracterSeparadorCampos & "]*\s*" &
                     caracterSeparadorCampos & ")"

            '-----------------------------------
            ' Proceso
            Try
                objRegEx = New System.Text.RegularExpressions.Regex(
                           patron,
                           System.Text.RegularExpressions.RegexOptions.IgnoreCase)

                objMatchCollection =
                    objRegEx.Matches(lineaConFormatoCsv & caracterSeparadorCampos)

                '  Definir la matriz para los datos de salida
                ReDim arrayDatosIndividuales(objMatchCollection.Count - 1)
                For Each objMatch In objMatchCollection
                    '-----
                    ' Obtener un elemento
                    Aux = objMatch.Value.Substring(0, objMatch.Length - 1)
                    If indice = 0 Then
                        oc = Aux
                    End If

                    '-----------------------------
                    ' ---> Si hay comillas rodeando el valor hay que quitarlas
                    ' ejemplo ["5,34"] --> 5,34 
                    ' Problema = Que haya un espacio delante o detrás de la comilla
                    ' ejemplo [ " 5,34" ] --> 5,34 
                    '-----------------------------
                    If Aux.Trim.StartsWith(
                           QUOTE,
                           StringComparison.CurrentCulture) AndAlso
                       Aux.Trim.EndsWith(
                           QUOTE,
                           StringComparison.CurrentCulture) Then
                        Aux = Aux.Trim
                        Aux = Aux.Substring(1, Aux.Length - 2)
                        ' ---- >Segundo asunto
                        ' Dos comillas dobles seguidas, sustituirlas por una sola
                        ' ejemplo
                        '     Venture ""Extended Edition""
                        '     Venture "Extended Edition"
                        Aux = Aux.Replace(QUOTE & QUOTE, QUOTE)

                    End If
                    '-----
                    ' Añadirlo a la matriz de salida
                    arrayDatosIndividuales(indice) = Aux
                    indice += 1
                Next objMatch

            Catch ex As Exception
                Throw
            Finally
                If objRegEx IsNot Nothing Then
                    objRegEx = Nothing
                End If
                If objMatchCollection IsNot Nothing Then
                    objMatchCollection = Nothing
                End If
                If objMatch IsNot Nothing Then
                    objMatch = Nothing
                End If
                indice = Nothing
                patron = Nothing
                Aux = Nothing
            End Try
            '-----------------------------------
            ' Devolver resultado obtenido
            Return arrayDatosIndividuales

        End Function

#End Region


#Region "Objeto DataRow"

        ''' <summary>
        '''  La información que contiene un DataRow, se vuelca en una cadena con formato CSV
        ''' </summary>
        ''' <param name="objDataRow">El objeto que contiene la información</param>
        ''' <returns>una cadena codificada en formato CSV</returns>
        Public Overloads Shared Function ToLineaCsv(
                 ByVal objDataRow As System.Data.DataRow) _
                 As String
            Return ToLineaCsv(","c, objDataRow)
        End Function


        '---------------------------------------------
        'Esta es la función que hace el trabajo
        '---------------------------------------------


        ''' <summary>
        '''  La información que contiene un DataRow, se vuelca en una cadena con formato CSV
        ''' </summary>
        ''' <param name="caracterSeparadorCampos">El carácter que se va a utilizar como separador de campos</param>
        ''' <param name="objDataRow">El objeto que contiene la información</param>
        ''' <returns>una cadena codificada en formato CSV</returns>
        ''' <remarks></remarks>
        ''' <exception cref="ArgumentNullException">
        '''    <para> El valor de <paramref name="lineaConFormatoCsv" >lineaConFormatoCsv</paramref> </para> 
        '''    <para> o bien</para> 
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >caracterSeparadorCampos</paramref></para> 
        '''    <para> o bien</para> 
        '''    <para> El valor de <paramref name="objDataRow" >objDataRow</paramref></para> 
        '''    <para> es null (Nothing en Visual Basic</para> 
        ''' </exception>
        ''' <exception cref="ArgumentException">
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >caracterSeparadorCampos</paramref>
        '''           es uno de los caracteres que no son válidos para actuar como separador de campos</para> 
        ''' </exception>
        Public Overloads Shared Function ToLineaCsv(
                              ByVal caracterSeparadorCampos As Char,
                              ByVal objDataRow As System.Data.DataRow) _
                              As String


            ' Control de parámetros
            '-----------------------------------
            ' Comprobar el separador de campos
            ' Si es erróneo se dispara una excepción
            Call ControlCaracterSeparadorCampos(caracterSeparadorCampos)


            If objDataRow Is Nothing Then
                Throw New ArgumentNullException(
                "objDataRow",
                "El valor del  [objDataRow] es null (Nothing en Visual Basic)")
            End If


            Try
                Dim numeroColumnas As Integer = objDataRow.Table.Columns.Count
                If numeroColumnas = 0 Then
                    ' la tabla esta vacia, no tiene ninguna columna definida
                    Return String.Empty
                End If

                Dim matrizCampos(numeroColumnas - 1) As String

                For indice As Integer = 0 To numeroColumnas - 1
                    If objDataRow.Item(indice) IsNot DBNull.Value Then
                        matrizCampos(indice) = Convert.ToString(objDataRow.Item(indice), System.Globalization.CultureInfo.CurrentCulture)
                    Else
                        matrizCampos(indice) = String.Empty
                    End If
                Next

                Return ToLineaCsv(caracterSeparadorCampos, matrizCampos)
            Catch ex As Exception
                Throw
            End Try
        End Function


        ''' <summary>
        '''    Carga un DataRow con la información que contiene una cadena en formato CSV
        ''' </summary>
        ''' <param name="lineaConFormatoCsv">cadena a analizar, la cadena  que vamos a partir</param>
        ''' <param name="objDataTable">
        '''    El Objeto DataTable en el que se colgará la columna DataRow que devuelve esta función. 
        '''    Es necesaria para crear un DataRow Vacio que tenga la misma estructura que 
        '''    el DataTable en el que se va a ‘colgar’</param>
        ''' <returns>Un objeto [System.Data.DataRow] con la información que contiene 
        '''          la cadena CSV recibida por parámetro</returns>
        Public Overloads Shared Function LineaCsvToDataRow(
                      ByVal lineaConFormatoCsv As String,
                      ByVal objDataTable As DataTable) _
                      As System.Data.DataRow
            Return LineaCsvToDataRow(","c, lineaConFormatoCsv, objDataTable)
        End Function



        '---------------------------------------------
        'Esta es la función que hace el trabajo
        '---------------------------------------------

        ''' <summary>
        '''    Carga un DataRow con la información que contiene una cadena en formato CSV
        ''' </summary>
        ''' <param name="caracterSeparadorCampos">El carácter que se va a utilizar como separador de campos</param>
        ''' <param name="lineaConFormatoCsv">cadena a analizar, la cadena  que vamos a partir</param>
        ''' <param name="objDataTable">
        '''    El Objeto DataTable en el que se colgará la columna DataRow que devuelve esta función. 
        '''    Es necesaria para crear un DataRow Vacio que tenga la misma estructura que 
        '''    el DataTable en el que se va a ‘colgar’</param>
        ''' <returns>Un objeto [System.Data.DataRow] con la información que contiene 
        '''          la cadena CSV recibida por parámetro</returns>
        ''' <remarks>
        '''   <para>Si la cadena con el formato CSV esta vacía, 
        '''         se devuelve un objeto DataRow vacio </para>
        ''' </remarks>
        ''' <exception cref="ArgumentNullException">
        '''    <para> El valor de <paramref name="lineaConFormatoCsv" >lineaConFormatoCsv</paramref> </para> 
        '''    <para> o bien</para> 
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >caracterSeparadorCampos</paramref></para> 
        '''    <para> o bien</para> 
        '''    <para> El valor de <paramref name="objDataTable" >objDataTable</paramref></para> 
        '''    <para> es null (Nothing en Visual Basic</para> 
        ''' </exception>
        ''' <exception cref="ArgumentException">
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >caracterSeparadorCampos</paramref>
        '''           es uno de los caracteres que no son válidos para actuar como separador de campos</para> 
        ''' </exception>
        Public Overloads Shared Function LineaCsvToDataRow(
                                 ByVal caracterSeparadorCampos As Char,
                                 ByVal lineaConFormatoCsv As String,
                                 ByVal objDataTable As DataTable) _
                                 As System.Data.DataRow



            ' Control de parámetros
            '-----------------------------------
            ' Comprobar el separador de campos
            ' Si es erróneo se dispara una excepción
            Call ControlCaracterSeparadorCampos(caracterSeparadorCampos)


            If lineaConFormatoCsv Is Nothing Then
                Throw New ArgumentNullException(
                "lineaConFormatoCsv",
                "El valor de la [matrizElementos()] es null (Nothing en Visual Basic)")
            End If

            If lineaConFormatoCsv.Length = 0 Then
                ' devolver un objeto [System.Data.DataRow] vacio
                Return objDataTable.NewRow
            End If

            If objDataTable Is Nothing Then
                Throw New ArgumentNullException(
                "objDataTable",
                "El valor de la [matrizElementos()] es null (Nothing en Visual Basic)")

            End If


            '------------------------------------------------
            Dim matrizCampos() As String
            Dim unaFila As DataRow = Nothing
            '------------------------------------------------
            Try
                '------------------------------------------------
                ' convertir la linea en una matriz
                matrizCampos = LineaCsvToArray(caracterSeparadorCampos, lineaConFormatoCsv)

                '------------------------------------------------
                '  Definir y cargar el DataRow
                unaFila = objDataTable.NewRow
                For index As Integer = matrizCampos.GetLowerBound(0) _
                                   To matrizCampos.GetUpperBound(0)
                    unaFila.Item(index) = matrizCampos(index)
                Next
                '------------------------------------------------
                Return unaFila
            Catch ex As Exception
                Throw
            Finally
                matrizCampos = Nothing
                unaFila = Nothing
            End Try

        End Function


#End Region

#Region " Linea con formato CSV to XML"

        ''' <summary>
        '''  Convierte una cadena con formato CSV en un nodo XML
        ''' </summary>
        ''' <param name="caracterSeparadorCampos">El carácter que se va a utilizar como separador de campos</param>
        ''' <param name="lineaConFormatoCsv">cadena a analizar, la cadena  que vamos a partir</param>
        ''' <returns>devuelve una cadena que contiene la informacion volcada en un nodo XML</returns>
        ''' <remarks>
        ''' <code> 
        ''' La funcion devuelve un nodo con el formato siguiente
        '''     <row> {CrLf}
        '''         <Col0>uno</Col0 >  {CrLf}
        '''         <Col1>dos</Col1 >  {CrLf}
        '''         <Col2>tres</Col2>  {CrLf}
        '''          . . . . . . . . . 
        '''          . . . . . . . . . 
        '''     </row>  {CrLf}
        ''' </code>
        ''' </remarks>
        ''' <exception cref="ArgumentNullException">
        '''    <para> El valor de <paramref name="lineaConFormatoCsv" >lineaConFormatoCsv</paramref> </para> 
        '''    <para> o bien</para> 
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >caracterSeparadorCampos</paramref></para> 
        '''    <para> es null (Nothing en Visual Basic</para> 
        ''' </exception>
        ''' <exception cref="ArgumentException">
        '''    <para> El valor de <paramref name="caracterSeparadorCampos" >caracterSeparadorCampos</paramref>
        '''           es uno de los caracteres que no son válidos para actuar como separador de campos</para> 
        ''' </exception>
        Public Overloads Shared Function LineaCsvToXml(
                                    ByVal caracterSeparadorCampos As Char,
                                    ByVal lineaConFormatoCsv As String) _
                                    As String

            ' Control de parámetros
            '-----------------------------------
            ' Comprobar el separador de campos
            ' Si es erróneo se dispara una excepción
            Call ControlCaracterSeparadorCampos(caracterSeparadorCampos)


            If lineaConFormatoCsv Is Nothing Then
                Throw New ArgumentNullException(
                "lineaConFormatoCsv",
                "El valor de la [matrizElementos()] es null (Nothing en Visual Basic)")
            End If

            '------------------------------------------------
            Dim matrizCampos() As String
            '------------------------------------------------
            Try
                '------------------------------------------------
                ' convertir la linea en una matriz
                matrizCampos = LineaCsvToArray(caracterSeparadorCampos, lineaConFormatoCsv)

                '-----------------------------------
                ' Listado que genera esta funcion
                '-----------------------------------
                ' <row> {CrLf}
                '   <Col0>uno</Col0 > {CrLf}
                '   <Col1>dos</Col1 > {CrLf}
                '   <Col2>tres</Col2> {CrLf}
                ' </row>{CrLf}
                '-----------------------------------
                Dim BLANCOS As String = New String(" "c, 4)

                Using SW As New System.IO.StringWriter(System.Globalization.CultureInfo.CurrentCulture)
                    SW.WriteLine(BLANCOS & "<row>")
                    For index As Integer = matrizCampos.GetLowerBound(0) _
                                        To matrizCampos.GetUpperBound(0)

                        SW.Write(BLANCOS & BLANCOS & "<col" & index.ToString(System.Globalization.CultureInfo.CurrentCulture) & ">")
                        SW.Write(matrizCampos(index))
                        SW.Write("</col" & index.ToString(System.Globalization.CultureInfo.CurrentCulture) & ">")
                        SW.WriteLine()
                    Next
                    SW.WriteLine(BLANCOS & "</row>")

                    SW.Flush()
                    Return SW.ToString
                End Using
            Catch ex As Exception
                Throw
            Finally
                matrizCampos = Nothing
            End Try

        End Function

#End Region


#Region "Test - La función AutoTest tiene que ser Private hasta que se vaya a emplear que entonces se pone como Public y se usa"

        ''' <summary>
        '''  Realiza un AutoTest del funcionamiento de las funciones de la clase
        ''' </summary>
        ''' <returns>Una cadena de texto con las pruebas realizadas y el resultado obtenido </returns>
        Public Shared Function AutoTest() As String
            Dim textoInformativo As String = String.Empty
            Dim textoErrores As String = String.Empty

            Using SW As New System.IO.StringWriter(
                            System.Globalization.CultureInfo.CurrentCulture)
                SW.WriteLine("==========================================")
                SW.WriteLine("Prueba usando la Coma (,) como separador")
                SW.WriteLine(" Es correcto CSV = " & Csv.FuncionaParseCSVBienComa(textoInformativo, textoErrores).ToString)
                SW.WriteLine(textoInformativo)
                SW.WriteLine(textoErrores)
                SW.WriteLine("==========================================")
                SW.WriteLine("Prueba usando el Punto y coma (;) como separador")
                SW.WriteLine(" Es correcto CSV = " & Csv.FuncionaParseCSVBienPuntoYComa(textoInformativo, textoErrores).ToString)
                SW.WriteLine(textoInformativo)
                SW.WriteLine(textoErrores)
                SW.WriteLine("==========================================")
                SW.WriteLine("Prueba con dataRow y coma (,) como separador")
                SW.WriteLine(" Es correcto CSV = " & Csv.FuncionaParseCSVBienDataRow(textoInformativo, textoErrores).ToString)
                SW.WriteLine(textoInformativo)
                SW.WriteLine(textoErrores)
                SW.Flush()
                Return SW.ToString
            End Using


        End Function

        ''' <summary>
        '''   Control de las funciones usando la coma como separador
        ''' </summary>
        ''' <param name="OutputTextoInformativo">Texto que informa de las operaciones realizadas</param>
        ''' <param name="OutputTextoConErrores">Texto que informa de los errores detectados</param>
        ''' <returns>
        ''' Un valor lógico que indica
        ''' True --> Funciona bien, False --> hay alguna función que no hace bien su trabajo
        ''' </returns>
        Private Shared Function FuncionaParseCSVBienComa(
                 ByRef OutputTextoInformativo As String,
                 ByRef OutputTextoConErrores As String) As Boolean

            '    Dim matrizPruebas(filas, columnas) As String
            Dim quote As Char = """"c

            '   COMPORTAMIENTO DEL PROCESO [SPLIT]
            '             CSV                     Valor_ 1  Valor_ 2   Valor_3  
            ' (  1)  --> [a,b,c             ] ==> [a      ] [b      ] [c      ]
            ' (  2)  --> ["a",b,c           ] ==> [a      ] [b      ] [c      ]
            ' (  3)  --> ['a',b,c           ] ==> ['a'    ] [b      ] [c      ]
            ' (  4)  --> [  a  ,  b  ,  c   ] ==> [  a    ] [  b    ] [  c    ]
            ' (  5)  --> [aa,bb;cc,         ] ==> [aa     ] [bb;cc  ] [       ]
            ' (  6)  --> [a,,               ] ==> [a      ] [       ] [       ]
            ' (  7)  --> [,b,               ] ==> [       ] [b      ] [       ]
            ' (  8)  --> [,,c               ] ==> [       ] [       ] [c      ]
            ' (  9)  --> [,,                ] ==> [       ] [       ] [       ]
            ' ( 10)  --> ["",b,             ] ==> [       ] [b      ] [       ]
            ' ( 10)  --> [" ",b,            ] ==> [       ] [b      ] [       ]
            ' ( 12)  --> ["a,b",,           ] ==> [a,b    ] [       ] [       ]
            ' ( 13)  --> ["a,b",c,          ] ==> [a,b    ] [c      ] [       ]
            ' ( 14)  --> [" a  ,b ",c,      ] ==> [ a  ,b ] [c      ] [       ]
            ' ( 15)  --> [a b,c,            ] ==> [a b    ] [c      ] [       ]
            ' ( 16)  --> [a"b,c,            ] ==> [a"b    ] [c      ] [       ]
            ' ( 17)  --> ["a""b",c,         ] ==> [a"b    ] [c      ] [       ]
            ' ( 18)  --> [a""b,c,           ] ==> [a""b   ] [c      ] [       ]
            ' ( 19)  --> [a,b",c            ] ==> [a      ] [b"     ] [c      ]
            ' ( 20)  --> [a,b"",c           ] ==> [a      ] [b""    ] [c      ]
            ' ( 21)  --> [C, "Ed ""Ext""","4900,00"] ==> [C      ] [Ed "Ext"] [4900,00]




            '    {" 6", "", "1", "", "", ""}, _

            Dim matrizPruebas(,) As String = {
                     {" 1", "a,b,c", "3", "a", "b", "c"},
                     {" 2", quote & "a" & quote & ",b,c", "3", "a", "b", "c"},
                     {" 3", "'a',b,c", "3", "'a'", "b", "c"},
                     {" 4", "  a  ,  b  ,  c  ", "3", "  a  ", "  b  ", "  c  "},
                     {" 5", "aa,bb;cc,", "3", "aa", "bb;cc", ""},
                     {" 6", "a,,", "3", "a", "", ""},
                     {" 7", ",b,", "3", "", "b", ""},
                     {" 8", ",,c", "3", "", "", "c"},
                     {" 9", ",,", "3", "", "", ""},
                     {"10", quote & quote & ",b,", "3", "", "b", ""},
                     {"10", quote & " " & quote & ",b,", "3", " ", "b", ""},
                     {"12", quote & "a,b" & quote & ",,", "3", "a,b", "", ""},
                     {"13", quote & "a,b" & quote & ",c,", "3", "a,b", "c", ""},
                     {"14", quote & " a  ,b " & quote & ",c,", "3", " a  ,b ", "c", ""},
                     {"15", "a b,c,", "3", "a b", "c", ""},
                     {"16", "a" & quote & "b,c,", "3", "a" & quote & "b", "c", ""},
                     {"-17", quote & "a" & quote & quote & "b" & quote & ",c,", "3", "a" & quote & "b", "c", ""},
                     {"18", "a" & quote & quote & "b,c,", "3", "a" & quote & quote & "b", "c", ""},
                     {"19", "a,b" & quote & ",c", "3", "a", "b" & quote, "c"},
                     {"20", "a,b" & quote & quote & ",c", "3", "a", "b" & quote & quote, "c"},
                     {"21", "C, " & quote & "Edicion " & quote & quote & "Extendida" & quote & quote & quote & "," & quote & "4900,00" & quote,
                       "3", "C", "Edicion " & quote & "Extendida" & quote, "4900,00"}
                  }

            '1999,Chevy,"Venture ""Extended Edition""","",4900.00
            ' "Chevy, " & quote & "Venture " & quote &  quote & "Extended Edition" & quote &  quote &  quote & ",4900.00"


            '     Chevy,"Venture ""Extended Edition""","",4900.00
            '    "Chevy,"Venture " & quote & " & quote & "Extended Edition"& quote " & quote & ",4900.00"


            Dim esCorrecto As Boolean = True ' supongo que esta todo bien

            Dim cadenaAnalizada As String = String.Empty
            Dim elementosEsperados As Integer = 0
            Dim caracterSeparadorCampos As Char = ","c
            Dim OutputTexto As String = String.Empty
            Dim OutputListaSeparados As String = String.Empty
            Dim contador As String = String.Empty




            Using swErrores As New System.IO.StringWriter(
                               System.Globalization.CultureInfo.CurrentCulture),
                  swInforme As New System.IO.StringWriter(
                               System.Globalization.CultureInfo.CurrentCulture)

                For i As Integer = matrizPruebas.GetLowerBound(0) To matrizPruebas.GetUpperBound(0)

                    '=================================
                    '--------- Valores controlados
                    contador = matrizPruebas(i, 0)
                    cadenaAnalizada = matrizPruebas(i, 1)

                    elementosEsperados = Integer.Parse(matrizPruebas(i, 2),
                                                      System.Globalization.CultureInfo.CurrentCulture)

                    '---- Test
                    'If contador = "21" Then Stop


                    If HacerUnaComprobacionAUXILIAR(contador, cadenaAnalizada, elementosEsperados,
                              caracterSeparadorCampos,
                              matrizPruebas(i, 3), matrizPruebas(i, 4), matrizPruebas(i, 5),
                              OutputTexto, OutputListaSeparados) = False Then
                        swErrores.WriteLine(OutputTexto)
                        esCorrecto = False
                    End If

                    '---- informe
                    swInforme.WriteLine(" ({0,3}) Analizando --> [{1,-18}] ==> [{2,-7}] [{3,-7}] [{4,-7}]",
                                        contador, cadenaAnalizada, matrizPruebas(i, 3), matrizPruebas(i, 4), matrizPruebas(i, 5))
                Next


                ' ------------------------------
                swErrores.Flush()
                OutputTextoInformativo = swInforme.ToString

                If swErrores.ToString.Length > 0 Then
                    OutputTextoConErrores = swErrores.NewLine & " ERRORES ENCONTRADOS " & swErrores.NewLine & swErrores.ToString
                Else
                    OutputTextoConErrores = "No hay errores"

                End If

                OutputTextoConErrores = swErrores.ToString
            End Using

            ' ------------------------------
            Return esCorrecto

        End Function

        ''' <summary>
        '''   Función auxiliar que compara datos e imprime un mensaje con el resultado
        ''' </summary>
        ''' <param name="ordencadena">El numero de orden de la cadena que se analiza (1,2,3, etc) sirve para buscarla más fácilmente</param>
        ''' <param name="cadenaAnalizada">La cadena (en formato CSV) que se analiza </param>
        ''' <param name="elementosEsperados">el número de elementos que se esperan obtener (el numero de subcadenas de la cadena)</param>
        ''' <param name="caracterSeparadorCampos">El carácter que se emplea para separar los campos (por ejemplo una coma (,))</param>
        ''' <param name="separadoUno">El valor del primer elemento que se separa (se emplea para compararlo y ver si coincide</param>
        ''' <param name="separadoDos">El valor del segundo elemento que se separa (se emplea para compararlo y ver si coincide</param>
        ''' <param name="separadoTres">El valor del tercer elemento que se separa (se emplea para compararlo y ver si coincide</param>
        ''' <param name="OutputTexto">Texto con información para un error </param>
        ''' <param name="OutputListaSeparados">
        ''' la lista separada que se calcula vuelta a montar en una cadena (solo para impresión y comprobación visual)
        ''' </param>
        ''' <returns>   
        ''' Un valor lógico que indica
        ''' True --> Funciona bien, 
        ''' False --> hay algún error, las cadenas separadas no coinciden (las recibidas y las calculadas)
        '''</returns>
        Private Shared Function HacerUnaComprobacionAUXILIAR(
                 ByVal ordencadena As String,
                 ByVal cadenaAnalizada As String,
                 ByVal elementosEsperados As Integer,
                 ByVal caracterSeparadorCampos As Char,
                 ByVal separadoUno As String,
                 ByVal separadoDos As String,
                 ByVal separadoTres As String,
                       Optional ByRef OutputTexto As String = "",
                       Optional ByRef OutputListaSeparados As String = "") _
                 As Boolean

            '=================================
            Dim OutputEsCorrecta As Boolean = True
            OutputTexto = String.Empty
            OutputListaSeparados = String.Empty
            '-------------
            Dim contadorElementosSeparados As Integer = 0
            Dim matrizElementosSeparados As String()


            '--------- Calculos
            matrizElementosSeparados = LineaCsvToArray(caracterSeparadorCampos, cadenaAnalizada)
            contadorElementosSeparados = matrizElementosSeparados.GetUpperBound(0) + 1


            '--------- Comprobacion
            If contadorElementosSeparados <> elementosEsperados OrElse
               String.Compare(separadoUno, matrizElementosSeparados(0), StringComparison.CurrentCulture) <> 0 OrElse
               String.Compare(separadoDos, matrizElementosSeparados(1), StringComparison.CurrentCulture) <> 0 OrElse
               String.Compare(separadoTres, matrizElementosSeparados(2), StringComparison.CurrentCulture) <> 0 Then
                OutputEsCorrecta = False
            End If


            '--------------------- (elementos separados calculados
            Using SW As New System.IO.StringWriter(
                            System.Globalization.CultureInfo.CurrentCulture)
                SW.Write("")
                For i As Integer = 0 To matrizElementosSeparados.GetUpperBound(0)
                    SW.Write(" [" & matrizElementosSeparados(i) & "] ")
                Next
                ' SW.WriteLine("")
                SW.Flush()
                OutputListaSeparados = SW.ToString
            End Using

            '--------------Mensaje de error
            Using SW As New System.IO.StringWriter(
                            System.Globalization.CultureInfo.CurrentCulture)
                SW.WriteLine("ERROR ERROR                  = [{0}]", ordencadena)
                SW.WriteLine("Cadena analizada             = [{0}]", cadenaAnalizada)
                SW.WriteLine("Numero elementos Esperados   = [{0}], y Encontrados = [{1}]", elementosEsperados, contadorElementosSeparados)
                SW.WriteLine("Lista de Elementos Esperada  = [{0,-6}]  [{1,-6}]  [{2,-6}] ",
                             separadoUno, separadoDos, separadoTres)
                SW.WriteLine("Lista de Elementos calculada = [{0,-6}]  [{1,-6}]  [{2,-6}] ",
                             matrizElementosSeparados(0), matrizElementosSeparados(1), matrizElementosSeparados(2))
                SW.Flush()
                OutputTexto = SW.ToString
            End Using

            Return OutputEsCorrecta
        End Function

        ''' <summary>
        '''   Control de las funciones usando el Punto y coma (;) como separador
        ''' </summary>
        ''' <param name="OutputTextoInformativo">Texto que informa de las operaciones realizadas</param>
        ''' <param name="OutputTextoConErrores">Texto que informa de los errores detectados</param>
        ''' <returns>
        ''' Un valor lógico que indica
        ''' True --> Funciona bien, False --> hay alguna función que no hace bien su trabajo
        ''' </returns>
        Private Shared Function FuncionaParseCSVBienPuntoYComa(
                ByRef OutputTextoInformativo As String,
                ByRef OutputTextoConErrores As String) As Boolean

            '    Dim matrizPruebas(filas, columnas) As String
            Dim quote As Char = """"c

            '   COMPORTAMIENTO DEL PROCESO [SPLIT]
            '             CSV                     Valor_ 1  Valor_ 2   Valor_3  
            ' (  1)  --> [a;b;c             ] ==> [a      ] [b      ] [c      ]
            ' (  2)  --> ["a";b;c           ] ==> [a      ] [b      ] [c      ]
            ' (  3)  --> ['a';b;c           ] ==> ['a'    ] [b      ] [c      ]
            ' (  4)  --> [  a  ;  b  ;  c   ] ==> [  a    ] [  b    ] [  c    ]
            ' (  5)  --> [aa;bb,cc;         ] ==> [aa     ] [bb,cc  ] [       ]
            ' (  6)  --> [a;;               ] ==> [a      ] [       ] [       ]
            ' (  7)  --> [;b;               ] ==> [       ] [b      ] [       ]
            ' (  8)  --> [;;c               ] ==> [       ] [       ] [c      ]
            ' (  9)  --> [;;                ] ==> [       ] [       ] [       ]
            ' ( 10)  --> ["";b;             ] ==> [       ] [b      ] [       ]
            ' ( 10)  --> [" ";b;            ] ==> [       ] [b      ] [       ]
            ' ( 12)  --> ["a;b";;           ] ==> [a;b    ] [       ] [       ]
            ' ( 13)  --> ["a;b";c;          ] ==> [a;b    ] [c      ] [       ]
            ' ( 14)  --> [" a  ;b ";c;      ] ==> [ a  ;b ] [c      ] [       ]
            ' ( 15)  --> [a b;c;            ] ==> [a b    ] [c      ] [       ]
            ' ( 16)  --> [a"b;c;            ] ==> [a"b    ] [c      ] [       ]
            ' ( 17)  --> ["a""b";c;         ] ==> [a"b    ] [c      ] [       ]
            ' ( 18)  --> [a""b;c;           ] ==> [a""b   ] [c      ] [       ]
            ' ( 19)  --> [a;b";c            ] ==> [a      ] [b"     ] [c      ]
            ' ( 20)  --> [a;b"";c           ] ==> [a      ] [b""    ] [c      ]
            ' ( 21)  --> [C; "Ed ""Ext""";"4900;00"] ==> [C      ] [Ed "Ext"] [4900;00]



            Dim matrizPruebas(,) As String = {
               {" 1", "a;b;c", "3", "a", "b", "c"},
               {" 2", quote & "a" & quote & ";b;c", "3", "a", "b", "c"},
               {" 3", "'a';b;c", "3", "'a'", "b", "c"},
               {" 4", "  a  ;  b  ;  c  ", "3", "  a  ", "  b  ", "  c  "},
               {" 5", "aa;bb,cc;", "3", "aa", "bb,cc", ""},
               {" 6", "a;;", "3", "a", "", ""},
               {" 7", ";b;", "3", "", "b", ""},
               {" 8", ";;c", "3", "", "", "c"},
               {" 9", ";;", "3", "", "", ""},
               {"10", quote & quote & ";b;", "3", "", "b", ""},
               {"10", quote & " " & quote & ";b;", "3", " ", "b", ""},
               {"12", quote & "a;b" & quote & ";;", "3", "a;b", "", ""},
               {"13", quote & "a;b" & quote & ";c;", "3", "a;b", "c", ""},
               {"14", quote & " a  ;b " & quote & ";c;", "3", " a  ;b ", "c", ""},
               {"15", "a b;c;", "3", "a b", "c", ""},
               {"16", "a" & quote & "b;c;", "3", "a" & quote & "b", "c", ""},
               {"-17", quote & "a" & quote & quote & "b" & quote & ";c;", "3", "a" & quote & "b", "c", ""},
               {"18", "a" & quote & quote & "b;c;", "3", "a" & quote & quote & "b", "c", ""},
               {"19", "a;b" & quote & ";c", "3", "a", "b" & quote, "c"},
               {"20", "a;b" & quote & quote & ";c", "3", "a", "b" & quote & quote, "c"},
               {"21", "C; " & quote & "Edicion " & quote & quote & "Extendida" & quote & quote & quote & ";" & quote & "4900,00" & quote,
                 "3", "C", "Edicion " & quote & "Extendida" & quote, "4900,00"}
            }


            Dim esCorrecto As Boolean = True ' supongo que esta todo bien
            Dim cadenaAnalizada As String = String.Empty
            Dim elementosEsperados As Integer = 0
            Dim caracterSeparadorCampos As Char = ";"c
            Dim OutputTexto As String = String.Empty
            Dim OutputListaSeparados As String = String.Empty
            Dim contador As String = String.Empty



            Using swErrores As New System.IO.StringWriter(
                                   System.Globalization.CultureInfo.CurrentCulture),
                  swInforme As New System.IO.StringWriter(
                                   System.Globalization.CultureInfo.CurrentCulture)

                For i As Integer = matrizPruebas.GetLowerBound(0) To matrizPruebas.GetUpperBound(0)

                    '=================================
                    '--------- Valores controlados
                    contador = matrizPruebas(i, 0)
                    cadenaAnalizada = matrizPruebas(i, 1)

                    elementosEsperados = Integer.Parse(matrizPruebas(i, 2),
                                   System.Globalization.CultureInfo.CurrentCulture)

                    '---- Test
                    'If contador = "21" Then Stop
                    If HacerUnaComprobacionAUXILIAR(contador, cadenaAnalizada, elementosEsperados,
                              caracterSeparadorCampos,
                              matrizPruebas(i, 3), matrizPruebas(i, 4), matrizPruebas(i, 5),
                              OutputTexto, OutputListaSeparados) = False Then
                        swErrores.WriteLine(OutputTexto)
                        esCorrecto = False
                    End If

                    '---- informe
                    swInforme.WriteLine(" ({0,3}) Analizando --> [{1,-18}] ==> [{2,-7}] [{3,-7}] [{4,-7}]",
                                        contador, cadenaAnalizada, matrizPruebas(i, 3), matrizPruebas(i, 4), matrizPruebas(i, 5))
                Next

                ' ------------------------------
                swErrores.Flush()
                OutputTextoInformativo = swInforme.ToString

                If swErrores.ToString.Length > 0 Then
                    OutputTextoConErrores = swErrores.NewLine & " ERRORES ENCONTRADOS " & swErrores.NewLine & swErrores.ToString
                Else
                    OutputTextoConErrores = "No hay errores"
                End If

                OutputTextoConErrores = swErrores.ToString
            End Using

            ' ------------------------------
            Return esCorrecto

        End Function


#Region "Autotest Con DataRow"


        ''' <summary>
        '''    Genera un objeto DataTable
        ''' </summary>
        ''' <returns>un objeto DataTable vacio </returns>
        ''' <remarks></remarks>
        Private Shared Function GetDataTableVacio() As DataTable
            '------------------------------------------------
            ' ---- APUNTE TACTICO ---- 
            ' Forma de obtener los datos del esquema de la tabla
            '------------------------------------------------
            'Dim NombreCampo As String = fila("ColumnName").ToString
            'Dim DataType As String = fila("DataType").ToString
            'Dim ColumnOrdinal As String = fila("ColumnOrdinal").ToString
            'Dim IsUnique As String = fila("IsUnique").ToString
            'Dim ColumnSize As String = fila("ColumnSize").ToString
            'Dim AllowDBNull As String = fila("AllowDBNull").ToString
            'Dim DataTypeName As String = fila("DataTypeName").ToString
            '
            'http://msdn.microsoft.com/es-es/library/system.data.datarow.aspx
            '------------------------------------------------
            '
            '
            Dim objDataTable As DataTable = Nothing
            Dim unaColumna As DataColumn = Nothing
            Try
                '------------------------------------------------
                'Proceso de generacion del datatable
                '------------------------------------------------
                ' Crear un nuevo DataTable llamado tb_empresa_DT
                objDataTable = New DataTable("Proveedores")
                objDataTable.Locale = System.Globalization.CultureInfo.CurrentCulture
                objDataTable.MinimumCapacity = 50
                objDataTable.CaseSensitive = False
                '------------------------------------------------
                'Añadir las columnas del dataTable
                '------------------------------------------------
                ' 
                '------------------------------------------------
                '---------------------------------- > una columna
                unaColumna = New DataColumn()
                '' valor de columna autoincrementado
                'unaColumna.AutoIncrement = False
                ' Nombre del campo
                unaColumna.ColumnName = "Id"
                'Tipo de datos
                unaColumna.DataType = System.Type.GetType("System.Int32")
                ' valores nulos permitodos S/N
                unaColumna.AllowDBNull = True
                ' el valor de esta columna es unico
                unaColumna.Unique = False
                ' Añadir las columnas al Data Table
                objDataTable.Columns.Add(unaColumna)
                ' 
                ' 
                '------------------------------------------------
                '---------------------------------- > una columna
                unaColumna = New DataColumn()
                '' valor de columna autoincrementado
                'unaColumna.AutoIncrement = False
                ' Nombre del campo
                unaColumna.ColumnName = "Compañía"
                'Tipo de datos
                unaColumna.DataType = System.Type.GetType("System.String")
                ' valores nulos permitodos S/N
                unaColumna.AllowDBNull = True
                ' el valor de esta columna es unico
                unaColumna.Unique = False
                ' valor por defecto ( no se establece siempre
                unaColumna.DefaultValue = String.Empty
                ' longitud maxima de las cadenas
                unaColumna.MaxLength = 50 ' ColumnSize
                ' Añadir las columnas al Data Table
                objDataTable.Columns.Add(unaColumna)
                ' 
                ' 
                '------------------------------------------------
                '---------------------------------- > una columna
                unaColumna = New DataColumn()
                '' valor de columna autoincrementado
                'unaColumna.AutoIncrement = False
                ' Nombre del campo
                unaColumna.ColumnName = "Apellidos"
                'Tipo de datos
                unaColumna.DataType = System.Type.GetType("System.String")
                ' valores nulos permitodos S/N
                unaColumna.AllowDBNull = True
                ' el valor de esta columna es unico
                unaColumna.Unique = False
                ' valor por defecto ( no se establece siempre
                unaColumna.DefaultValue = String.Empty
                ' longitud maxima de las cadenas
                unaColumna.MaxLength = 50 ' ColumnSize
                ' Añadir las columnas al Data Table
                objDataTable.Columns.Add(unaColumna)
                ' 
                ' 
                '------------------------------------------------
                '---------------------------------- > una columna
                unaColumna = New DataColumn()
                '' valor de columna autoincrementado
                'unaColumna.AutoIncrement = False
                ' Nombre del campo
                unaColumna.ColumnName = "Nombre"
                'Tipo de datos
                unaColumna.DataType = System.Type.GetType("System.String")
                ' valores nulos permitodos S/N
                unaColumna.AllowDBNull = True
                ' el valor de esta columna es unico
                unaColumna.Unique = False
                ' valor por defecto ( no se establece siempre
                unaColumna.DefaultValue = String.Empty
                ' longitud maxima de las cadenas
                unaColumna.MaxLength = 50 ' ColumnSize
                ' Añadir las columnas al Data Table
                objDataTable.Columns.Add(unaColumna)
                ' 


                '----------------------------------------------------
                '' Añadir una columna PrimaryKey al primer campo de la tabla
                'Dim keys(0) As DataColumn
                'keys(0) = unaColumna
                'objDataTable.PrimaryKey = keys
                ''
                '--------------------------------
            Catch ex As Exception
                Throw
            End Try
            '--------------------------------
            Return objDataTable
        End Function

        Private Shared Function CargaDataTable() As DataTable

            Dim objDataTable As DataTable = GetDataTableVacio()
            Dim fila As System.Data.DataRow

            fila = objDataTable.NewRow
            fila.Item("Id") = 10
            fila.Item("Compañía") = "compañia uno"
            fila.Item("Apellidos") = "Apellidos Uno"
            fila.Item("Nombre") = "Nombre uno"
            objDataTable.Rows.Add(fila)

            fila = objDataTable.NewRow
            fila.Item("Id") = 20
            fila.Item("Compañía") = "compañia dos"
            fila.Item("Apellidos") = "Apellidos dos"
            fila.Item("Nombre") = "Nombre dos"
            objDataTable.Rows.Add(fila)

            fila = objDataTable.NewRow
            fila.Item("Id") = 30
            fila.Item("Compañía") = "compañia_tres"
            fila.Item("Apellidos") = "Apellidos_tres"
            fila.Item("Nombre") = "Nombre_tres"
            objDataTable.Rows.Add(fila)

            fila = objDataTable.NewRow
            fila.Item("Id") = 40
            fila.Item("Compañía") = "compañia cuatro"
            fila.Item("Apellidos") = "Apellidos cuatro"
            fila.Item("Nombre") = "Nombre cuatro"
            objDataTable.Rows.Add(fila)

            fila = objDataTable.NewRow
            fila.Item("Id") = 50
            fila.Item("Compañía") = "compañia cinco"
            fila.Item("Apellidos") = "Apellidos cinco"
            fila.Item("Nombre") = "Nombre cinco"
            objDataTable.Rows.Add(fila)

            fila = objDataTable.NewRow
            fila.Item("Id") = 50
            fila.Item("Compañía") = "compañia seis"
            fila.Item("Apellidos") = "Apellidos seis"
            fila.Item("Nombre") = "Nombre seis"
            objDataTable.Rows.Add(fila)

            Return objDataTable

        End Function


        Private Shared Function FuncionaParseCSVBienDataRow(
                ByRef OutputTextoInformativo As String,
                ByRef OutputTextoConErrores As String) As Boolean

            '-------------------------------------------------------------
            OutputTextoInformativo = String.Empty
            OutputTextoConErrores = String.Empty

            Dim esCorrecto As Boolean = True ' supongo que esta todo bien

            Dim objDataTable As DataTable = CargaDataTable()
            Dim fila As System.Data.DataRow
            Dim numeroColumnas As Integer = objDataTable.Columns.Count
            '-------------------------------------------------------------
            For Each fila In objDataTable.Rows
                Dim TextoCsv As String = ToLineaCsv(","c, fila)
                OutputTextoInformativo = OutputTextoInformativo & TextoCsv & Environment.NewLine

                Dim filaPrueba As System.Data.DataRow
                filaPrueba = LineaCsvToDataRow(","c, TextoCsv, objDataTable)

                ' If Object.Equals(fila, filaPrueba) = False Then

                For i As Integer = 0 To numeroColumnas - 1
                    If fila.Item(i) Is filaPrueba.Item(i) Then
                        OutputTextoConErrores = OutputTextoConErrores & "Problema con la fila " & fila.Item(i).ToString & Environment.NewLine
                        esCorrecto = False
                    End If
                Next

                'OutputTextoConErrores = OutputTextoConErrores & "Problema con la fila " & TextoCsv & Environment.NewLine
                'End If

            Next

            Return esCorrecto

        End Function




#End Region


#End Region

    End Class '/CSV

End Namespace