Public Class CabSys
    Public CS_CODCON As Integer
    Public CS_CODENT As Integer
    Public CS_CODTRA As Integer
    Public CS_DESCRI As String
    Public CS_FECPRO As DateTime
    Public CS_LAYOUT As String
    Public CS_NOMBRE As String
    Public CS_QUERY As String
    Public CS_REPORT As String
    Public CS_UPDATE As Boolean
    Public CS_DRILLD As Boolean
    Public CS_GROUPB As Boolean
    Public CS_DRIQUE As String
    Public CS_DRIPRE As String
    Public CS_TABLA As String
    Public CS_UPDQUE As String
    Public CS_ALTQUE As String
    Public CS_BAJQUE As String
    Public CS_ALTA As Boolean
    Public CS_BAJA As Boolean
    Public CS_NDESDE As String
    Public CS_NDEVAL As String
    Public CS_HABNDE As Boolean
    Public CS_ALTVAL As String
    Public CS_MODVAL As String

    Public Sub New()
        CS_CODCON = 0
        CS_CODTRA = 0
        CS_DESCRI = ""
        CS_FECPRO = DateTime.Now
        CS_LAYOUT = ""
        CS_NOMBRE = "Nueva Consulta"
        CS_QUERY = ""
        CS_REPORT = ""
        CS_UPDATE = False
        CS_DRILLD = False
        CS_GROUPB = False
        CS_DRIQUE = ""
        CS_DRIPRE = ""
        CS_TABLA = ""
        CS_UPDQUE = ""
        CS_ALTQUE = ""
        CS_BAJQUE = ""
        CS_ALTA = False
        CS_BAJA = False
        CS_NDESDE = ""
        CS_NDEVAL = ""
        CS_HABNDE = False
        CS_ALTVAL = ""
        CS_MODVAL = ""

    End Sub

    Public Sub New(codEntidad As Integer)
        Me.New
        CS_CODENT = codEntidad

    End Sub
End Class
