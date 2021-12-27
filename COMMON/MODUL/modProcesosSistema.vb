Module modConsultasSistema

   Public oSubProcesos As New Collection
   Public oProcesosEmb As New Collection
   Public oVariablesProc As New Collection
   Public oProcesosInt As New Collection
   Public oProcesos As New clsProcesosSistema

   Public Sub AbrirProceso(ByVal nCodPro As Long)

      Dim oSub As clsSubProcesosSistema
      Dim oVar As clsVariables
      Dim oPro As clsProcesosPrevios
      Dim ad As OleDb.OleDbDataAdapter
      Dim dt As DataTable
      Dim sSQL As String

        sSQL = "SELECT    * " &
             "FROM      PROCAB " &
             "WHERE     PC_CODPRO = " & nCodPro

        ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
      dt = New DataTable

      ad.Fill(dt)

      For Each dr As DataRow In dt.Rows

         oProcesos.CodPro = dr("PC_CODPRO")
         oProcesos.Transaccion = dr("PC_CODTRA")
         oProcesos.Nombre = dr("PC_NOMBRE")
         oProcesos.Descripcion = dr("PC_DESCRI")
            oProcesos.Query = System.Text.Encoding.GetEncoding(1252).GetString(Convert.FromBase64String(dr("PC_QUERY").ToString))
            oProcesos.FechaProceso = dr("PC_FECPRO")
         oProcesos.Entidad = dr("PC_CODENT")

      Next

      ad = Nothing
      dt = Nothing

      sSQL = "SELECT    * " & _
             "FROM      PRODET " & _
             "WHERE     PD_CODPRO = " & nCodPro & " " & _
             "ORDER BY  PD_ORDEN "

      ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
      dt = New DataTable

      ad.Fill(dt)

        For Each dr As DataRow In dt.Rows
            'If nCodPro > ClsSubProcesosSistemaWebService.CodProcesoWebService Then
            '    oSub = New ClsSubProcesosSistemaWebService(dr)
            'Else
            oSub = New clsSubProcesosSistema(dr)
            'End If

            oSubProcesos.Add(oSub, oSub.Key)
            oSub = Nothing
        Next

        ad = Nothing
      dt = Nothing

      sSQL = "SELECT    * " & _
             "FROM      PROVAR " & _
             "WHERE     PV_CODPRO = " & nCodPro & " " & _
             "ORDER BY  PV_ORDEN "

      ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
      dt = New DataTable

      ad.Fill(dt)

      For Each dr As DataRow In dt.Rows

         oVar = New clsVariables

         oVar.CodCon = dr("PV_CODPRO")
         oVar.Orden = dr("PV_ORDEN")
         oVar.Nombre = dr("PV_NOMBRE")
         oVar.Tipo = dr("PV_TIPO")
         oVar.Titulo = dr("PV_TITULO")
         oVar.Help = dr("PV_HELP")
         oVar.HelpQuery = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(dr("PV_HELQUE").ToString))
         oVar.Key = oVar.Nombre

         oVariablesProc.Add(oVar, oVar.Key)

         oVar = Nothing

      Next

      ad = Nothing
      dt = Nothing

      sSQL = "SELECT    * " & _
             "FROM      PROINT " & _
             "WHERE     PI_CODPRO = " & nCodPro & " " & _
             "ORDER BY  PI_ORDEN "

      ad = New OleDb.OleDbDataAdapter(sSQL, CONN_LOCAL)
      dt = New DataTable

      ad.Fill(dt)

      For Each dr As DataRow In dt.Rows

         oPro = New clsProcesosPrevios

         oPro.CodCon = dr("PI_CODPRO")
         oPro.Orden = dr("PI_ORDEN")
         oPro.Nombre = dr("PI_NOMBRE")
         oPro.Descripcion = dr("PI_DESCRI")
         oPro.Titulo = dr("PI_TITULO")
         oPro.Parametros = dr("PI_PARAME")
         oPro.Key = oPro.Nombre

         oProcesosInt.Add(oPro, oPro.Key)

         oPro = Nothing

      Next

      ad = Nothing
      dt = Nothing

   End Sub

End Module
