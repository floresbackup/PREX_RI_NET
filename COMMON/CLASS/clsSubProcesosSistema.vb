Imports System.Linq

Public Class clsSubProcesosSistema

	Public ReadOnly Property CodPro As Long
	Public ReadOnly Property Orden As Integer
	Public ReadOnly Property Nombre As String
	Public ReadOnly Property Query As String
	Public ReadOnly Property Estado As Integer
	Public ReadOnly Property Key As String

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


	Public Const CodProcesoWebService As Integer = 1000
	Public ReadOnly Property Url As String
	Public ReadOnly Property Parametros As IEnumerable(Of String)
	Public ReadOnly Property NombreSalida As String
	Public ReadOnly Property TipoSalida As TipoSalidaProcesoWeb

	Public ReadOnly Property FullUri As Uri
		Get
			If String.IsNullOrEmpty(Url) Then Return Nothing

			Dim _url = Url

			For i As Integer = 1 To Parametros.Count()
				_url = _url.Replace($"@{i}", Parametros(i))
			Next

			Return New Uri(_url)
		End Get
	End Property

	'QUERY: "url|parametro1,parametro2|NombreSalida|TipoSalida"
	'QUERY: "http://urlservicion.com?@1&@2|parametro1,parametro2|TABLAXXX|Tabla"
	Public Sub New(dr As DataRow)
		MyBase.New(dr)

		If Query.Length > 0 Then
			Dim i = 0

			Dim split As String() = Query.Split("|")
			For i = 0 To split.Length - 1
				Select Case i
					Case 0
						Url = split(i)
					Case 1
						Parametros = split(i).Split(",")
					Case 2
						NombreSalida = split(i)
					Case 3
						TipoSalida = DirectCast([Enum].Parse(GetType(TipoSalidaProcesoWeb), split(i)), TipoSalidaProcesoWeb)
				End Select
			Next
		End If
	End Sub
End Class

Public Enum EstadoProceso
	FinalizadoOK
	EnError
	Cancelado
End Enum

Public Enum TipoSalidaProcesoWeb
	Tabla
	Txt
End Enum