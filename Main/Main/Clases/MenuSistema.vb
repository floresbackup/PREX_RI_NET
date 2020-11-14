

Imports Prex.Utils

Public Class MenuSistema
	Public ReadOnly Property MU_NROMEN As Integer
	Public ReadOnly Property MU_CODTRA As Long
	Public ReadOnly Property MU_TRANSA As String
	Public ReadOnly Property MU_RELMEN As Integer
	Public ReadOnly Property MU_COMAND As String
	Public ReadOnly Property MU_DESCRI As String
	Public ReadOnly Property MU_NIVEL As Integer

	Public Sub New(ByVal dataRecord As IDataRecord)
		If (dataRecord.ContainsField("MU_NROMEN") AndAlso Not IsDBNull(dataRecord("MU_NROMEN"))) Then MU_NROMEN = Integer.Parse(dataRecord("MU_NROMEN"))
		If (dataRecord.ContainsField("MU_CODTRA") AndAlso Not IsDBNull(dataRecord("MU_CODTRA"))) Then MU_CODTRA = Long.Parse(dataRecord("MU_CODTRA"))
		If (dataRecord.ContainsField("MU_TRANSA") AndAlso Not IsDBNull(dataRecord("MU_TRANSA"))) Then MU_TRANSA = dataRecord("MU_TRANSA").ToString.Trim
		If (dataRecord.ContainsField("MU_RELMEN") AndAlso Not IsDBNull(dataRecord("MU_RELMEN"))) Then MU_RELMEN = Integer.Parse(dataRecord("MU_RELMEN"))
		If (dataRecord.ContainsField("MU_COMAND") AndAlso Not IsDBNull(dataRecord("MU_COMAND"))) Then MU_COMAND = dataRecord("MU_COMAND").ToString.Trim
		If (dataRecord.ContainsField("MU_DESCRI") AndAlso Not IsDBNull(dataRecord("MU_DESCRI"))) Then MU_DESCRI = dataRecord("MU_DESCRI").ToString.Trim
		If (dataRecord.ContainsField("MU_NIVEL") AndAlso Not IsDBNull(dataRecord("MU_NIVEL"))) Then MU_NIVEL = Integer.Parse(dataRecord("MU_NIVEL"))
	End Sub


End Class