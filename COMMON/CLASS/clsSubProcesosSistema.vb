Imports System.Linq


Public Class clsSubProcesosSistema

	Public ReadOnly Property CodPro As Long
	Public ReadOnly Property Orden As Integer
	Public ReadOnly Property Nombre As String
	Public ReadOnly Property Query As String
	Public ReadOnly Property Estado As Integer
	Public ReadOnly Property Key As String

	Public Sub New()

	End Sub
	Public Sub New(dr As DataRow)
		CodPro = dr("PD_CODPRO")
		Orden = dr("PD_ORDEN")
		Nombre = dr("PD_NOMBRE")
		Query = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("PD_QUERY")))
		Estado = dr("PD_ESTADO")
		Key = dr("PD_ORDEN").ToString
	End Sub
End Class

Public Class ClsSubProcesosSistemaWebService
	Inherits clsSubProcesosSistema

	Public Property Url As String
	Public Property BodyRequest As String
	Public Property HttpMethod As System.Net.Http.HttpMethod
	Public Property NombreSalida As String
	Public Property TipoSalida As TipoSalidaProcesoWeb
	Public Property LiteralFinArchivo As String
	Public Property CantidadCampos As Integer
	Public Property ContentType As String = "application/json"
	Public Property ServiceProtocol As System.Net.SecurityProtocolType = System.Net.SecurityProtocolType.Tls Or System.Net.SecurityProtocolType.Tls11 Or System.Net.SecurityProtocolType.Tls12

	Public ReadOnly Property FullUri As Uri
		Get
			If String.IsNullOrEmpty(Url) Then Return Nothing
			Dim _url = Url
			Return New Uri(_url)
		End Get
	End Property

	Public Sub New(variables As String())
		MyBase.New()

		Dim i = 0
		For i = 0 To variables.Count() - 1
			CargarParametros(variables(i).Trim().Replace("'", String.Empty), CType(i, PosicionesQuery))
		Next

	End Sub

	'QUERY: "httpMthod;url;body;NombreSalida;TipoSalida;LiteralFinArchivo;QtyCampos"
	'QUERY: "POST;http://urlservicion.com?param1=1&param2=2;BODY;TABLAXXX;Tabla;LiteralFinArchivo;CntCampos"
	Public Sub New(dr As DataRow)
		MyBase.New(dr)
		If Query.Length > 0 Then
			Dim i = 0

			Dim split As String() = Query.Split(";")
			If split Is Nothing OrElse split.Count() = 0 Then
				Exit Sub
			End If

			For i = 0 To split.Length - 1
				CargarParametros(split(i).Trim(), CType(i, PosicionesQuery))
			Next
		End If
	End Sub

	Private Sub CargarParametros(valor As String, index As PosicionesQuery)
		Select Case index
			Case PosicionesQuery.HttpMethod '0
				Select Case valor.ToUpper()
					Case "POST"
						HttpMethod = System.Net.Http.HttpMethod.Post
					Case "PUT"
						HttpMethod = System.Net.Http.HttpMethod.Put
					Case "GET"
						HttpMethod = System.Net.Http.HttpMethod.Get
				End Select
			Case PosicionesQuery.Url '1
				Url = valor
			Case PosicionesQuery.Body '2
				BodyRequest = valor
			Case PosicionesQuery.NombreSalida '3
				NombreSalida = valor
			Case PosicionesQuery.TipoSalida
				TipoSalida = DirectCast([Enum].Parse(GetType(TipoSalidaProcesoWeb), valor.ToUpper()), TipoSalidaProcesoWeb)
			Case PosicionesQuery.LiteralFinArchivo
				LiteralFinArchivo = valor
			Case PosicionesQuery.CantidadCampos
				CantidadCampos = Integer.Parse(valor)
		End Select
	End Sub
End Class

Public Enum EstadoProceso
	FinalizadoOK
	EnError
	Cancelado
End Enum

Public Enum TipoSalidaProcesoWeb
	TABLA
	TXT
End Enum

Public Enum PosicionesQuery
	HttpMethod = 0
	Url = 1
	Body = 2
	NombreSalida = 3
	TipoSalida = 4
	LiteralFinArchivo = 5
	CantidadCampos = 6
End Enum