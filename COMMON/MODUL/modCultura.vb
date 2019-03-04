Imports DevExpress.XtraBars.Localization
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraPivotGrid.Localization
Imports DevExpress.XtraCharts.Localization
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraReports.Localization
Imports DevExpress.XtraEditors.Controls

Module modCultura

   Public Const IDIOMA_INGLES = 2

   Public Structure CadenaIdioma
      Public CodigoCadena As Cadenas
      Public DescripcionCadena As String
   End Structure

   Public colCadenas As New Collection

   Public Enum Cadenas
      CDN_mnuArchivo = 1
   End Enum

   Public Structure Cultura
      Public IdCultura As String
      Public Origen As String
      Public Objeto As String
      Public Texto As String
      Public Key As String
   End Structure

   Public CulturaTextos As New Collection

   'Public Sub LeerCadenas(ByVal nCodigoIdioma As Integer)

   'Dim sSQL As String
   'Dim ds As DataSet
   'Dim oAdmTablas As New AdmTablas
   'Dim nI As Integer
   'Dim oCadena As CadenaIdioma

   '   sSQL = "SELECT  * " & _
   '          "FROM    [SVR-DOM-F001\SQLPREX].QUALITAS.DBO.IDIOMA " & _
   '          "WHERE   IO_CODIDI = " & nCodigoIdioma

   '      oAdmTablas.ConnectionString = CONN_LOCAL
   '      ds = oAdmTablas.AbrirDataset(sSQL)

   '      colCadenas.Clear()

   '      For nI = 0 To ds.Tables(0).Rows.Count - 1
   '         oCadena = New CadenaIdioma
   '         oCadena.CodigoCadena = ds.Tables(0).Rows(nI)("IO_CODCAD")
   '         oCadena.DescripcionCadena = ds.Tables(0).Rows(nI)("IO_DESCRI")
   '         colCadenas.Add(oCadena, "K" & ds.Tables(0).Rows(nI)("IO_CODCAD") - 1)
   '      Next

   '   End Sub

   Public Sub CulturaCargarTextos(ByVal IdCultura As String)

      Dim sSQL As String
      Dim ds As DataSet
      Dim oAdmTablas As New AdmTablas
      Dim oCultura As Cultura
      Dim oRow As DataRow

      sSQL = "SELECT  * " & _
             "FROM    CULTUR " & _
             "WHERE   CU_CULTUR = '" & IdCultura & "'"

      oAdmTablas.ConnectionString = CONN_LOCAL
      ds = oAdmTablas.AbrirDataset(sSQL)
        If ds Is Nothing Then Exit Sub

        CulturaTextos.Clear()

        For Each oRow In ds.Tables(0).Rows
            oCultura = New Cultura
            oCultura.IdCultura = oRow("CU_CULTUR")
            oCultura.Origen = oRow("CU_ORIGEN")
            oCultura.Objeto = oRow("CU_OBJETO")
            oCultura.Texto = oRow("CU_TEXTO")
            oCultura.Key = oRow("CU_ORIGEN") & "." & oRow("CU_OBJETO")
            CulturaTextos.Add(oCultura, oRow("CU_ORIGEN") & "." & oRow("CU_OBJETO"))
        Next

      ds = Nothing

        'EstablecerLenguaje()

   End Sub

    Public Function CulturaTexto(ByVal sOrigen As String, ByVal sObjeto As String) As String

        On Error Resume Next

        Dim oCultura As Cultura

        oCultura = CulturaTextos(sOrigen & "." & sObjeto)

        If oCultura.Texto Is Nothing Then
            CulturaTexto = "N/A"
        Else
            CulturaTexto = oCultura.Texto
        End If

    End Function

   Public Function DescripcionCadena(ByVal nCodigoCadena As Cadenas) As String

      On Error Resume Next

      Dim oCadena As CadenaIdioma

      oCadena = colCadenas("K" & nCodigoCadena)

      If oCadena.DescripcionCadena Is Nothing Then
         DescripcionCadena = "N/A"
      Else
         DescripcionCadena = oCadena.DescripcionCadena
      End If

   End Function

    'Public Sub EstablecerLenguaje()

    '   BarLocalizer.Active = New cBarsLocalizer()
    '   GridLocalizer.Active = New cGridLocalizer()
    '   PivotGridLocalizer.Active = New cPivotGridLocalizer()
    '   ChartLocalizer.Active = New cChartLocalizer()
    '   PreviewLocalizer.Active = New cPrintingLocalizer()
    '   BarLocalizer.Active = New cBarsLocalizer()
    '   Localizer.Active = New cEditorsLocalizer()
    '   ReportLocalizer.Active = New cReportsLocalizer()

    'End Sub

End Module
