Public Class frmSeguridad 

    Private oAdmTablas As New AdmTablas

    Private Sub frmConexiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oAdmTablas.ConnectionString = CONN_LOCAL
        LocalizarFormulario()
        CargarUsuarios()
    End Sub


    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionSeguridad)
        lvUsuarios.Groups(0).Header = DescripcionCadena(Cadenas.CDN_frmSeguridad_Usuarios)

        cmdAgregar.Text = DescripcionCadena(Cadenas.CDN_frmSeguridad_Agregar)
        cmdPropiedades.Text = DescripcionCadena(Cadenas.CDN_frmSeguridad_Propiedades)
        cmdEliminar.Text = DescripcionCadena(Cadenas.CDN_frmSeguridad_Eliminar)
        cmdOpcionesSeguridad.Text = DescripcionCadena(Cadenas.CDN_frmSeguridad_OpcionesSeguridad)
        cmdCerrar.Text = DescripcionCadena(Cadenas.CDN_GeneralCerrar)

    End Sub

    Private Sub CargarUsuarios()

        Dim sSQL As String
        Dim itmX As ListViewItem
        Dim ds As DataSet
        Dim sEstado As String
        Dim i As Long

        sSQL = "SELECT      US_CODUSU, US_NOMBRE, US_DESCRI, US_ESTADO, US_LOCKED " & _
               "FROM        USUARI " & _
               "ORDER BY    US_DESCRI"

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)
            lvUsuarios.Items.Clear()

            With ds.Tables(0)

                For i = 0 To .Rows.Count - 1
                    itmX = New ListViewItem

                    itmX.Text = .Rows(i).Item("US_NOMBRE").ToString
                    itmX.Name = "K" & .Rows(i).Item("US_CODUSU").ToString
                    
                    sEstado = ""
                    itmX.ImageIndex = 0

                    If .Rows(i).Item("US_ESTADO") <> 0 Then
                        sEstado = DescripcionCadena(Cadenas.CDN_frmSeguridad_UsuarioSuspendido)
                        itmX.ImageIndex = 1
                    End If

                    If .Rows(i).Item("US_LOCKED") <> 0 Then
                        If sEstado = "" Then
                            sEstado = DescripcionCadena(Cadenas.CDN_frmSeguridad_UsuarioBloqueado)
                        Else
                            sEstado = sEstado & " - " & DescripcionCadena(Cadenas.CDN_frmSeguridad_UsuarioBloqueado)
                        End If
                        itmX.ImageIndex = 1
                    End If

                    itmX.SubItems.Add(.Rows(i).Item("US_DESCRI") & IIf(sEstado = "", "", " (" & sEstado & ")"))

                    itmX.Group = lvUsuarios.Groups(0)
                    lvUsuarios.Items.Add(itmX)

                Next

            End With

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub lvUsuarios_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvUsuarios.ItemSelectionChanged
        cmdPropiedades.Enabled = e.IsSelected
        cmdEliminar.Enabled = e.IsSelected
    End Sub

    Private Sub lvUsuarios_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvUsuarios.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not lvUsuarios.FocusedItem Is Nothing Then
                PropiedadesItem(lvUsuarios.FocusedItem)
            End If
        End If
    End Sub

    Private Sub PropiedadesItem(ByVal oItem As ListViewItem)

        Dim nItemName As Integer
        Dim fUsuario As New frmUsuario

        nItemName = oItem.Index

        fUsuario.PasarUsuario(Val(oItem.Name.Substring(1)))
        fUsuario.ShowDialog()

        CargarUsuarios()
        lvUsuarios.Items(nItemName).Selected = True
        lvUsuarios.Items(nItemName).EnsureVisible()

    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If Not lvUsuarios.FocusedItem Is Nothing Then
            If DatosOK() Then
                If Pregunta(DescripcionCadena(Cadenas.CDN_frmSeguridad_WarningEliminar)) = Windows.Forms.DialogResult.Yes Then
                    If Eliminar() Then
                        CargarUsuarios()
                    End If
                End If
            Else
                MensajeError(DescripcionCadena(Cadenas.CDN_frmSeguridad_ImposibleEliminar))
            End If
        End If
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click

        Dim fUsuario As New frmUsuario
        fUsuario.ShowDialog()

        CargarUsuarios()

    End Sub

    Private Function DatosOK() As Boolean

        'Dim sSQL As String
        'Dim nCodConn As Long
        'Dim ds As DataSet

        'nCodConn = Val(lvConexiones.FocusedItem.Name.Substring(1))

        'sSQL = "SELECT  COUNT(1) AS CANTIDAD " & _
        '       "FROM    CONVAR " & _
        '       "WHERE   CV_CODCAD = " & nCodConn

        'ds = oAdmTablas.AbrirDataset(sSQL)
        'DatosOK = (ds.Tables(0).Rows(0).Item("CANTIDAD") = 0)

        If Not lvUsuarios.FocusedItem Is Nothing Then
            If Val(lvUsuarios.FocusedItem.Name.Substring(1)) = 1 Then
                Return False
                Exit Function
            End If
        End If

        Return True

    End Function

    Private Function Eliminar() As Boolean

        Dim sSQL As String
        Dim nCodConn As Long
        Dim ds As DataSet

        nCodConn = Val(lvUsuarios.FocusedItem.Name.Substring(1))

        sSQL = "UPDATE  USUARI " & _
               "SET     US_ESTADO = 1 " & _
               "WHERE   US_CODUSU = " & nCodConn

        Return oAdmTablas.EjecutarComandoSQL(sSQL)

    End Function

    Private Sub cmdPropiedades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPropiedades.Click
        If Not lvUsuarios.FocusedItem Is Nothing Then
            PropiedadesItem(lvUsuarios.FocusedItem)
        End If
    End Sub


    Private Sub cmdOpcionesSeguridad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpcionesSeguridad.Click

        Dim fOps As New frmOpcionesSeguridad
        fOps.ShowDialog()
        fOps.Dispose()

    End Sub
End Class