Imports Microsoft.Data.ConnectionUI

Public Class frmConexion

    Private MODO As String
    Private COD_CONEXION As Long
    Private oAdmTablas As New AdmTablas

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LocalizarFormulario()
        oAdmTablas.ConnectionString = CONN_LOCAL

        If COD_CONEXION > 0 Then
            MODO = "M"
        Else
            MODO = "A"
        End If

    End Sub

    Private Sub LocalizarFormulario()
        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionConexion)
        lblNombreConexion.Text = DescripcionCadena(Cadenas.CDN_frmConexion_Nombre)
        lblDesipcrionConexion.Text = DescripcionCadena(Cadenas.CDN_frmConexion_Descripcion)
        lblCadena.Text = DescripcionCadena(Cadenas.CDN_frmConexion_CadenaConexion)
        cmdGenerarCadena.Text = DescripcionCadena(Cadenas.CDN_frmConexion_GenerarCadena)
        cmdDiccionarioDatos.Text = DescripcionCadena(Cadenas.CDN_frmConexion_DiccionarioDatos)
        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

        chkEjecucionAsincrona.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_chkAsincrona)
        lblTipoConexion.Text = DescripcionCadena(Cadenas.CDN_frmConexion_TipoConexion)

        chkOpcionesDefault.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_chkOpcionesDefault)

        lblSimboloDecimal.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblSimboloDecimal)
        lblLiteralCadenas.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblLiteralCadenas)
        lblLiteralFechas.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblLiteralFechas)
        lblFormatoFechas.Text = DescripcionCadena(Cadenas.CDN_frmDisenoConsulta_lblFormatoFechas)


    End Sub

    Public Sub PasarConexion(ByVal nCodConexion As Long)

        oAdmTablas.ConnectionString = CONN_LOCAL
        MODO = "M"
        COD_CONEXION = nCodConexion
        DatosConexion()

    End Sub

    Private Sub DatosConexion()

        Dim sSQL As String
        Dim sSQLConExt As String
        Dim ds As DataSet
        Dim dsConExt As DataSet

        sSQL = "SELECT  * " & _
               "FROM    TABGEN " & _
               "WHERE   TG_CODTAB = 4 " & _
               "AND     TG_CODCON = " & COD_CONEXION

        sSQLConExt = "SELECT  * " & _
                     "FROM    CONEXT " & _
                     "WHERE   CX_CODCON = " & COD_CONEXION

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)
            dsConExt = oAdmTablas.AbrirDataset(sSQLConExt)

            With ds.Tables(0)
                If .Rows.Count > 0 Then
                    txtNombre.Text = .Rows(0).Item("TG_DESCRI").ToString
                    txtDescripcion.Text = .Rows(0).Item("TG_ALFA02").ToString
                    txtCadena.Text = cEncrypt.DecryptString128Bit(.Rows(0).Item("TG_ALFA01").ToString)
                    cboTipoConexion.SelectedIndex = .Rows(0).Item("TG_NUME01")
                    chkEjecucionAsincrona.Checked = .Rows(0).Item("TG_NUME02") = 1

                End If
            End With

            With dsConExt.Tables(0)
                If .Rows.Count > 0 Then

                    chkOpcionesDefault.Checked = .Rows(0)("CX_OPTDEF") = 1

                    If Not chkOpcionesDefault.Checked Then
                        txtSimboloDecimal.Text = .Rows(0)("CX_SIMDEC")
                        txtLiteralCadenas.Text = .Rows(0)("CX_LITSTR")
                        txtLiteralFechas.Text = .Rows(0)("CX_LITFEC")
                        txtFormatoFechas.Text = .Rows(0)("CX_FORFEC")
                    End If

                End If
            End With

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub Actualizar()

        Dim sSQL As String
        Dim sSQLConExt As String
        Dim ds As DataSet
        Dim dsConExt As DataSet
        Dim nId As Long
        Dim oRow As DataRow
        Dim da As OleDb.OleDbDataAdapter
        Dim cb As OleDb.OleDbCommandBuilder
        Dim daConExt As OleDb.OleDbDataAdapter
        Dim cbConExt As OleDb.OleDbCommandBuilder

        If MODO = "A" Then
            nId = oAdmTablas.ProximoID("TABGEN", "TG_CODCON", "TG_CODTAB=4 AND TG_CODCON < 999999")
        Else
            nId = COD_CONEXION
        End If

        sSQL = "SELECT  * " & _
               "FROM    TABGEN " & _
               "WHERE   TG_CODTAB = 4 " & _
               "AND     TG_CODCON = " & nId

        sSQLConExt = "SELECT  * " & _
                     "FROM    CONEXT " & _
                     "WHERE   CX_CODCON = " & nId

        Try

         ds = oAdmTablas.AbrirDataset(sSQL, da)
            dsConExt = oAdmTablas.AbrirDataset(sSQLConExt, daConExt)

            cb = New OleDb.OleDbCommandBuilder(da)
            cbConExt = New OleDb.OleDbCommandBuilder(daConExt)

            With ds.Tables(0)

                If MODO = "A" Then

                    oRow = .NewRow()
                    oRow.Item("TG_CODTAB") = 4
                    oRow.Item("TG_CODCON") = nId
                    oRow.Item("TG_DESCRI") = txtNombre.Text.Trim
                    oRow.Item("TG_NUME01") = cboTipoConexion.SelectedIndex
                    oRow.Item("TG_NUME02") = IIf(chkEjecucionAsincrona.Checked, 1, 0)
                    oRow.Item("TG_ALFA01") = cEncrypt.EncryptString128Bit(txtCadena.Text.Trim)
                    oRow.Item("TG_ALFA02") = txtDescripcion.Text.Trim
                    oRow.Item("TG_FECH01") = CDate("1900-01-01")
                    oRow.Item("TG_FECH02") = CDate("1900-01-01")

                    .Rows.Add(oRow)

                    oRow = dsConExt.Tables(0).NewRow
                    oRow("CX_CODCON") = nId
                    oRow("CX_OPTDEF") = IIf(chkOpcionesDefault.Checked, 1, 0)
                    oRow("CX_SIMDEC") = txtSimboloDecimal.Text.Trim
                    oRow("CX_LITSTR") = txtLiteralCadenas.Text.Trim
                    oRow("CX_LITFEC") = txtLiteralFechas.Text.Trim
                    oRow("CX_FORFEC") = txtFormatoFechas.Text.Trim
                    dsConExt.Tables(0).Rows.Add(oRow)

                Else


                    .Rows(0).BeginEdit()
                    .Rows(0).Item("TG_DESCRI") = txtNombre.Text.Trim
                    .Rows(0).Item("TG_NUME01") = cboTipoConexion.SelectedIndex
                    .Rows(0).Item("TG_NUME02") = IIf(chkEjecucionAsincrona.Checked, 1, 0)
                    .Rows(0).Item("TG_ALFA02") = txtDescripcion.Text.Trim
                    .Rows(0).Item("TG_ALFA01") = cEncrypt.EncryptString128Bit(txtCadena.Text.Trim)
                    .Rows(0).EndEdit()

                    oRow = dsConExt.Tables(0).Rows(0)
                    oRow.BeginEdit()
                    oRow("CX_CODCON") = nId
                    oRow("CX_OPTDEF") = IIf(chkOpcionesDefault.Checked, 1, 0)
                    oRow("CX_SIMDEC") = txtSimboloDecimal.Text.Trim
                    oRow("CX_LITSTR") = txtLiteralCadenas.Text.Trim
                    oRow("CX_LITFEC") = txtLiteralFechas.Text.Trim
                    oRow("CX_FORFEC") = txtFormatoFechas.Text.Trim
                    oRow.EndEdit()

                End If

                da.Update(ds)
                ds.AcceptChanges()

                daConExt.Update(dsConExt)
                dsConExt.AcceptChanges()

            End With

            Me.Close()

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Function DatosOK() As Boolean

        If txtNombre.Text.Trim = vbNullString Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmConexion_ValidarNombre))
            txtNombre.Focus()
            Exit Function
        End If

        If txtCadena.Text.Trim = vbNullString Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmConexion_ValidarCadena))
            txtCadena.Focus()
            Exit Function
        End If

        DatosOK = True

    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If DatosOK() Then
            Actualizar()
        End If
    End Sub

    Private Sub cmdGenerarCadena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerarCadena.Click

        Dim dcd As New DataConnectionDialog
        Dim buf As String

        DataSource.AddStandardDataSources(dcd)

        If DataConnectionDialog.Show(dcd) = Windows.Forms.DialogResult.OK Then
            txtCadena.Text = dcd.ConnectionString
        End If

    End Sub

    Private Sub cboTipoConexion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoConexion.SelectedIndexChanged
        chkEjecucionAsincrona.Enabled = cboTipoConexion.SelectedIndex = 1

        If Not chkEjecucionAsincrona.Enabled Then
            chkEjecucionAsincrona.Checked = False
        End If
    End Sub

    Private Sub chkOpcionesDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOpcionesDefault.CheckedChanged
        txtSimboloDecimal.Enabled = Not chkOpcionesDefault.Checked
        txtLiteralCadenas.Enabled = Not chkOpcionesDefault.Checked
        txtLiteralFechas.Enabled = Not chkOpcionesDefault.Checked
        txtFormatoFechas.Enabled = Not chkOpcionesDefault.Checked
        lblSimboloDecimal.Enabled = Not chkOpcionesDefault.Checked
        lblLiteralCadenas.Enabled = Not chkOpcionesDefault.Checked
        lblLiteralFechas.Enabled = Not chkOpcionesDefault.Checked
        lblFormatoFechas.Enabled = Not chkOpcionesDefault.Checked

        If Not chkOpcionesDefault.Checked Then
            On Error Resume Next
            txtSimboloDecimal.Focus()
        End If
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtSimboloDecimal.Text = SIMBOLO_DECIMAL
        txtLiteralCadenas.Text = LITERAL_CADENAS
        txtLiteralFechas.Text = LITERAL_FECHAS
        txtFormatoFechas.Text = FORMATO_FECHAS

    End Sub
End Class