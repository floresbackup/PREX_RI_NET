
Namespace Dominio

    Public Class CabSys


        Public isNew As Boolean
        Public CS_CODCON As Long
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

    Public Class VarSys
        Public Nombre As String
        Public Tipo As String
        Public Titulo As String
        Public Help As String
        Public HelQue As String
        Public Orden As Integer
        Public Llave As String
        Public CodCon As Long

        Public Sub New()

        End Sub

        Public Sub New(codCon As Long, orden As Integer, nombre As String, tipo As String, titulo As String, help As String, helpque As String, llave As String)
            Me.Orden = orden
            Me.Nombre = nombre
            Me.Tipo = tipo
            Me.Titulo = titulo
            Me.Help = help
            Me.HelQue = helpque
            Me.Llave = llave
            Me.CodCon = codCon
        End Sub
    End Class
    Public Enum eProcesos
        ConsFechaFinMes = 0
        ConsValidarPeriodo = 1
        ConsActualizar = 2
        ConsFormatoCondicional = 3
        ConsActualizarEx = 4
        ConsActualizar_PNP = 5
    End Enum


    Public Class ProSys
        Public Descripcion As String
        Public Nombre As String
        Public Orden As Integer
        Public Parametros As String
        Public Titulo As String
        Public CodCon As Long
        Public Llave As String

        Public ReadOnly Property Proceso As eProcesos
            Get
                Return [Enum].Parse(GetType(eProcesos), Nombre)
            End Get
        End Property

        Public Sub New()

        End Sub
        Public Sub New(sLlave As String)
            Llave = sLlave
        End Sub

        Public Sub New(codCon As Long, orden As Integer, nombre As String, titulo As String, descri As String, param As String, llave As String)
            Me.CodCon = codCon
            Me.Orden = orden
            Me.Nombre = nombre
            Me.Titulo = titulo
            Me.Descripcion = descri
            Me.Parametros = param
            Me.Llave = llave
        End Sub
    End Class

    Public Class DetSys
        Public Campo As String
        Public Format As String
        Public Formul As String
        Public Habili As Boolean
        Public Help As String
        Public HelQue As String
        Public Largo As Integer?
        Public Orden As Integer
        Public Tipo As Integer
        Public Titulo As String
        Public Visible As Boolean
        Public DrillD As Boolean
        Public DriQue As String
        Public DriPre As String
        Public Llave As Boolean
        Public Reemplazo As Boolean
        Public RutaAyuda As String
        Public MaxLargo As Integer?
        Public VisABM As Boolean

        Public Sub New()

        End Sub

        Public Sub New(codCon As Long, orden As Integer, campo As String, tipo As Integer, largo As Integer?, formato As String, titulo As String, help As String, helque As String, formula As String, habilidato As Boolean, visible As Boolean, visibleABM As Boolean, llave As Boolean, drilldown As Boolean, drique As String, dripe As String, reemplazo As Boolean, ayuda As String, maxLargo As Integer?, key As String)
            Me.Campo = campo
            Me.Format = formato
            Me.Formul = formula
            Me.Habili = habilidato
            Me.Help = help
            Me.HelQue = helque
            Me.Largo = largo
            Me.Orden = orden
            Me.Tipo = tipo
            Me.Titulo = titulo
            Me.Visible = visible
            Me.DrillD = drilldown
            Me.DriQue = drique
            Me.DriPre = drique
            Me.Llave = llave
            Me.Reemplazo = reemplazo
            Me.RutaAyuda = RutaAyuda
            Me.MaxLargo = maxLargo
            Me.VisABM = visibleABM
        End Sub
    End Class

    Public Class SysGra
        Public CamTit As String
        Public CamVal As String
        Public CodCon As Long
        Public Largo As Integer
        Public Orden As Integer
        Public Query As String
        Public Tipo As Long
        Public Titulo As String
        Public PosLeyenda As Integer
        Public TitVisible As Integer

        Public Sub New()

        End Sub

        Public Sub New(codCon As Long, orden As Integer, tipo As Long, largo As Integer, camVal As String, camTit As String, titulo As String, query As String, posLeyenda As Integer, tituloVisible As Integer, sKey As String)
            camTit = camTit
            camVal = camVal
            codCon = codCon
            largo = largo
            orden = orden
            query = query
            tipo = tipo
            titulo = titulo
            posLeyenda = posLeyenda
            TitVisible = tituloVisible
        End Sub
    End Class

End Namespace
