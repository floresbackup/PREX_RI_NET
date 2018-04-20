Module modConsultasSistema

   Public oColumnas As New Collection
   Public oFormato As New Collection
   Public oVariables As New Collection
   Public oProcesosPrevios As New Collection
   Public oConsulta As New clsConsultasSistema
   Public bFmtEmb As Boolean

   Public Sub AbrirConsulta(ByVal nCodCon As Long)

      Dim oFmt As clsFormatosColumnas
      Dim oCol As clsColumnas
      Dim oVar As clsVariables
      Dim oPro As clsProcesosPrevios
      Dim ad As OleDb.OleDbDataAdapter
      Dim dt As DataTable
      Dim sSQL As String

      'Encabezado de consulta
      sSQL = "SELECT    * " & _
             "FROM      CABSYS " & _
             "WHERE     CS_CODCON = " & nCodCon

      ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
      dt = New DataTable

      ad.Fill(dt)

      For Each dr As DataRow In dt.Rows

         oConsulta.CodCon = dr("CS_CODCON")
         oConsulta.Transaccion = dr("CS_CODTRA")
         oConsulta.Nombre = dr("CS_NOMBRE")
         oConsulta.Descripcion = dr("CS_DESCRI")
         oConsulta.Query = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("CS_QUERY").ToString))
         oConsulta.FechaProceso = dr("CS_FECPRO")
         oConsulta.LayOut = dr("CS_LAYOUT")
         oConsulta.Reporte = dr("CS_REPORT")
         oConsulta.Entidad = dr("CS_CODENT")
         oConsulta.Actualiza = dr("CS_UPDATE")
         oConsulta.DrillDown = dr("CS_DRILLD")
         oConsulta.GroupBy = dr("CS_GROUPB")
         oConsulta.DrillDownQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("CS_DRIQUE").ToString))
         oConsulta.ActualizaQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("CS_TABLA").ToString))
         oConsulta.ActualizaValida = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("CS_UPDQUE").ToString))
         oConsulta.Alta = dr("CS_ALTA")
         oConsulta.Baja = dr("CS_BAJA")
         oConsulta.AltaQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("CS_ALTQUE").ToString))
         oConsulta.BajaQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("CS_BAJQUE").ToString))
         oConsulta.NuevoDesdeQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("CS_NDESDE").ToString))
         oConsulta.NuevoDesdeValida = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("CS_NDEVAL").ToString))
         oConsulta.NuevoDesde = dr("CS_HABNDE")
         oConsulta.DrillDownProceso = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("CS_DRIPRE").ToString))

      Next

      ad = Nothing
      dt = Nothing

      'Detalle de consulta
      sSQL = "SELECT    * " & _
             "FROM      DETSYS " & _
             "WHERE     DS_CODCON = " & nCodCon & " " & _
             "ORDER BY  DS_ORDEN "

      ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
      dt = New DataTable

      ad.Fill(dt)

      For Each dr As DataRow In dt.Rows

         'Columnas
         oCol = New clsColumnas

         oCol.CodCon = nCodCon
         oCol.Orden = Convert.ToInt16(dr("DS_ORDEN").ToString)
         oCol.Campo = dr("DS_CAMPO").ToString
         oCol.Tipo = Convert.ToInt16(dr("DS_TIPO").ToString)
         oCol.Largo = Convert.ToInt16(dr("DS_LARGO").ToString)
         oCol.Formato = dr("DS_FORMAT").ToString
         oCol.Titulo = dr("DS_TITULO").ToString
         oCol.Help = Convert.ToInt16(dr("DS_HELP").ToString)
         oCol.HelpQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("DS_HELQUE").ToString))
         oCol.Formula = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("DS_FORMUL").ToString))
         oCol.Habilitada = Convert.ToBoolean(Convert.ToInt32(dr("DS_HABILI")))
         oCol.Visible = Convert.ToBoolean(Convert.ToInt32(dr("DS_VISIBL")))
         oCol.Clave = Convert.ToBoolean(Convert.ToInt32(dr("DS_LLAVE")))
         oCol.DrillDown = Convert.ToBoolean(Convert.ToInt32(dr("DS_DRILLD")))
         oCol.DrillDownQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("DS_DRIQUE").ToString))
         oCol.Reemplazar = Convert.ToBoolean(Convert.ToInt32(dr("DS_REEMPL")))
         oCol.VisibleABM = Convert.ToBoolean(Convert.ToInt32(dr("DS_VISABM")))
         oCol.DrillDownProceso = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("DS_DRIPRE").ToString))
         oCol.Key = oCol.Campo

         oColumnas.Add(oCol, oCol.Key)

         oCol = Nothing

         'Formatos de Estilo
         oFmt = New clsFormatosColumnas

         Dim sFormat() As String = dr("DS_FORMAT").ToString.Split(";")

         If sFormat.Length > 1 Then

            If sFormat(0).Trim <> "" Then oFmt.Formato = sFormat(0).Trim
            If Val(sFormat(1)) <> -2147483643 Then oFmt.Fondo = Val(sFormat(1))
            If Val(sFormat(2)) <> -2147483630 Then oFmt.Frente = Val(sFormat(2))
            If sFormat(3).Trim <> "Tahoma" Then oFmt.Fuente = sFormat(3).Trim

            If CBool(Val(sFormat(4))) Then oFmt.Negrita = CBool(Val(sFormat(4)))
            If CBool(Val(sFormat(5))) Then oFmt.Subrayado = CBool(Val(sFormat(5)))
            If CBool(Val(sFormat(6))) Then oFmt.Tachado = CBool(Val(sFormat(6)))
            If Val(sFormat(7)) <> 8 Then oFmt.Tamano = Val(sFormat(7))
            If Val(sFormat(8)) <> 0 Then oFmt.Ancho = Convert.ToInt32(Val(sFormat(8)) / 15)

            oFmt.Columna = dr("DS_CAMPO").ToString
            oFmt.Key = oFmt.Columna

            If sFormat.Length > 9 Then
               oFmt.Condicion = sFormat(9).Trim
            End If

                oFormato.Add(oFmt, oFmt.Key)


         End If

         oFmt = Nothing

      Next

      ad = Nothing
      dt = Nothing

      'Variables de consulta
      sSQL = "SELECT    * " & _
             "FROM      VARSYS " & _
             "WHERE     VS_CODCON = " & nCodCon & " " & _
             "ORDER BY  VS_ORDEN "

      ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
      dt = New DataTable

      ad.Fill(dt)

      For Each dr As DataRow In dt.Rows

         'Columnas
         oVar = New clsVariables

         oVar.CodCon = dr("VS_CODCON").ToString
         oVar.Orden = dr("VS_ORDEN").ToString
         oVar.Nombre = dr("VS_NOMBRE").ToString
         oVar.Tipo = dr("VS_TIPO").ToString
         oVar.Titulo = dr("VS_TITULO").ToString
         oVar.Help = dr("VS_HELP").ToString
         oVar.HelpQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("VS_HELQUE").ToString))
         oVar.Key = oVar.Nombre
            oVariables.Add(oVar, oVar.Key)

         oVar = Nothing

      Next

      ad = Nothing
      dt = Nothing

      'Procesos previos
      sSQL = "SELECT    * " & _
             "FROM      PROSYS " & _
             "WHERE     PS_CODCON = " & nCodCon & " " & _
             "ORDER BY  PS_ORDEN "

      ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
      dt = New DataTable

      ad.Fill(dt)

      Dim sNombreFuncion As String

      For Each dr As DataRow In dt.Rows

         'Columnas
         oPro = New clsProcesosPrevios

         sNombreFuncion = dr("PS_NOMBRE").ToString.ToLower.Trim

         If sNombreFuncion = "consformatocondicional" Or _
               sNombreFuncion = "consactualizar" Or _
               sNombreFuncion = "consformatocondicionalex" Or _
               sNombreFuncion = "consactualizarex" Then
            bFmtEmb = True
         End If

         oPro.CodCon = dr("PS_CODCON")
         oPro.Orden = dr("PS_ORDEN")
         oPro.Nombre = dr("PS_NOMBRE")
         oPro.Descripcion = dr("PS_DESCRI")
         oPro.Titulo = dr("PS_TITULO")
         oPro.Parametros = dr("PS_PARAME")
         oPro.Key = oPro.Nombre
         oProcesosPrevios.Add(oPro, oPro.Key)

         oPro = Nothing

      Next

      ad = Nothing
      dt = Nothing

   End Sub

End Module
