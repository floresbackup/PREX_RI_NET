Public Class frmPeriodoActual
    Private oAdmLocal As New AdmTablas
    Private bCerrar As Boolean



    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        oAdmLocal.ConnectionString = CONN_LOCAL

        CargarPeriodos()

    End Sub

    Private Sub CargarPeriodos()

        Dim sSQL As String
        Dim nC As Long

        If cboFECACT.Properties.Items.Count = 0 Then
            Dim itemSel As New clsItem.Item With {
                .Nombre = "<Seleccionar...>",
                .Valor = "K_Seleccionar"
            }

            cboFECACT.Properties.Items.Add(itemSel)

            sSQL = "SELECT    DISTINCT DC_FECVIG " &
                   "FROM      DATCUA " &
                   "WHERE     DC_CODENT = " & CODIGO_ENTIDAD & " " &
                   "AND       DC_ACTIVA = 1 " &
                   "AND       DC_CUADRO BETWEEN 400 AND 498" &
                   "ORDER BY  DC_FECVIG DESC"

            Dim rstAux As DataSet = oAdmLocal.AbrirDataset(sSQL)

            For Each row As DataRow In rstAux.Tables(0).Rows
                Dim sFecha As Date = Nothing

                If DateTime.TryParse(row("DC_FECVIG"), sFecha) Then
                    nC = nC + 1
                    cboFECACT.Properties.Items.Add(New clsItem.Item("K" & row("DC_FECVIG"), row("DC_FECVIG")))
                End If
            Next

            rstAux = Nothing

            If nC = 0 Then
                MensajeError("No existen períodos para sincronizar")
                bCerrar = True
                Me.Close()
            End If

            cboFECACT.SelectedItem = itemSel
        End If

    End Sub

    Private Sub cmdAceptar_Click_1(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If DatosOK Then
            INPUT_GENERAL = cboFECACT.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub


    Private Function DatosOK() As Boolean

        Dim sFecha As Date = Nothing

        If Not DateTime.TryParse(cboFECACT.Text, sFecha) Then
            ' If Not IsDate(FechaSQL( cboFECACT.SelectedItem)) Then
            MensajeError("Debe seleccionar un período")
            Return False
        End If

        Return True

    End Function

    Private Sub Frm_Close() Handles Me.Closed

        If bCerrar Then
            INPUT_GENERAL = ""
        End If

    End Sub

End Class