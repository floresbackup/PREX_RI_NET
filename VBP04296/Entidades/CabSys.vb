﻿Public Class CabSys


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

    Public Sub New()

    End Sub
End Class

Public Class ProSys
    Public Descripcion As String
    Public Nombre As String
    Public Orden As Integer
    Public Parametros As String
    Public Titulo As String

    Public Sub New()

    End Sub
End Class

Public Class DetSys
    Public Campo As String
    Public Format As String
    Public Formul As String
    Public Habili As Boolean
    Public Help As Integer
    Public HelQue As String
    Public Largo As Integer
    Public Orden As Integer
    Public Tipo As Integer
    Public Titulo As Integer
    Public Visible As Boolean
    Public DrillD As Boolean
    Public DriQue As String
    Public DriPre As String
    Public Llave As Boolean
    Public Reemplazo As Boolean
    Public RutaAyuda As String
    Public MaxLargo As Integer
    Public VisABM As Boolean

    Public Sub New()

    End Sub
End Class