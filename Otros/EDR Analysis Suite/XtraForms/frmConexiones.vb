Public Class frmConexiones 

    Private oAdmTablas As New AdmTablas

    Private Sub frmConexiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oAdmTablas.ConnectionString = CONN_LOCAL
        LocalizarFormulario()
        CargarConexiones()
    End Sub


    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionConexiones)
        lvConexiones.Groups(0).Header = DescripcionCadena(Cadenas.CDN_WindowCaptionConexiones)
        cmdAgregar.Text = DescripcionCadena(Cadenas.CDN_frmConexiones_Agregar)
        cmdPropiedades.Text = DescripcionCadena(Cadenas.CDN_frmConexiones_Propiedades)
        cmdEliminar.Text = DescripcionCadena(Cadenas.CDN_frmConexiones_Eliminar)
        cmdCerrar.Text = DescripcionCadena(Cadenas.CDN_GeneralCerrar)

    End Sub

    Private Sub CargarConexiones()

        Dim sSQL As String
        Dim itmX As ListViewItem
        Dim ds As DataSet
        Dim i As Long

        sSQL = "SELECT      TG_CODCON, TG_DESCRI, TG_ALFA01, TG_ALFA02 " & _
               "FROM        TABGEN " & _
               "WHERE       TG_CODTAB = 4 " & _
               "AND         TG_CODCON <> 999999 " & _
               "ORDER BY    TG_DESCRI"

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)
            lvConexiones.Items.Clear()

            With ds.Tables(0)

                For i = 0 To .Rows.Count - 1
                    itmX = New ListViewItem

                    itmX.Text = .Rows(i).Item("TG_DESCRI").ToString
                    itmX.Name = "K" & .Rows(i).Item("TG_CODCON").ToString
                    itmX.Tag = .Rows(i).Item("TG_ALFA01").ToString

                    itmX.ImageIndex = 0
                    itmX.Group = lvConexiones.Groups(0)
                    itmX.SubItems.Add(.Rows(i).Item("TG_ALFA02"))

                    lvConexiones.Items.Add(itmX)

                Next

            End With

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub lvConexiones_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvConexiones.ItemSelectionChanged
        cmdPropiedades.Enabled = e.IsSelected
        cmdEliminar.Enabled = e.IsSelected
    End Sub

    Private Sub lvConexiones_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvConexiones.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not lvConexiones.FocusedItem Is Nothing Then
                PropiedadesItem(lvConexiones.FocusedItem)
            End If
        End If
    End Sub

    Private Sub PropiedadesItem(ByVal oItem As ListViewItem)

        Dim nItemName As Integer
        Dim fConn As New frmConexion

        nItemName = oItem.Index

        fConn.PasarConexion(Val(oItem.Name.Substring(1)))
        fConn.ShowDialog()
        
        CargarConexiones()
        lvConexiones.Items(nItemName).Selected = True
        lvConexiones.Items(nItemName).EnsureVisible()

    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If Not lvConexiones.FocusedItem Is Nothing Then
            If DatosOK() Then
                If Pregunta(DescripcionCadena(Cadenas.CDN_frmConexion_WarningEliminar)) = Windows.Forms.DialogResult.Yes Then
                    If Eliminar() Then
                        CargarConexiones()
                    End If
                End If
            Else
                MensajeError(DescripcionCadena(Cadenas.CDN_frmConexion_ImposibleEliminar))
            End If
        End If
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click

        Dim fConn As New frmConexion
        fConn.ShowDialog()

        CargarConexiones()

    End Sub

    Private Function DatosOK() As Boolean

        Dim sSQL As String
        Dim nCodConn As Long
        Dim ds As DataSet

        nCodConn = Val(lvConexiones.FocusedItem.Name.Substring(1))

        sSQL = "SELECT  COUNT(1) AS CANTIDAD " & _
               "FROM    CONVAR " & _
               "WHERE   CV_CODCAD = " & nCodConn

        ds = oAdmTablas.AbrirDataset(sSQL)
        DatosOK = (ds.Tables(0).Rows(0).Item("CANTIDAD") = 0)

    End Function

    Private Function Eliminar() As Boolean

        Dim sSQL As String
        Dim nCodConn As Long
        Dim ds As DataSet

        nCodConn = Val(lvConexiones.FocusedItem.Name.Substring(1))

        sSQL = "DELETE " & _
               "FROM    TABGEN " & _
               "WHERE   TG_CODTAB = 4 AND TG_CODCON = " & nCodConn & " " & vbCrLf & _
               "DELETE " & _
               "FROM    CONEXT " & _
               "WHERE   CX_CODCON = " & nCodConn

        Return oAdmTablas.EjecutarComandoSQL(sSQL)

    End Function

    Private Sub cmdPropiedades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPropiedades.Click
        If Not lvConexiones.FocusedItem Is Nothing Then
            PropiedadesItem(lvConexiones.FocusedItem)
        End If
    End Sub

End Class