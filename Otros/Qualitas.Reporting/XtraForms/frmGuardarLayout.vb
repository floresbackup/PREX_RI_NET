Public Class frmGuardarLayout 

    Public COD_CONSULTA As Long
    Public DATASET_INDEX As Long
    Public XML_FILENAME As String
    Public TIPO_LAYOUT As Integer

    Private oAdmTablas As New AdmTablas

    Public Sub New(ByVal nCodConsulta As Long, _
                   ByVal nDatasetIndex As Long, _
                   ByVal sFileName As String, _
                   ByVal nTipoLayout As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        oAdmTablas.ConnectionString = CONN_LOCAL

        LocalizarFormulario()
        COD_CONSULTA = nCodConsulta
        DATASET_INDEX = nDatasetIndex
        XML_FILENAME = sFileName
        TIPO_LAYOUT = nTipoLayout

        CargarLayouts()

    End Sub

    Private Sub LocalizarFormulario()

        On Error Resume Next

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionGuardarLayout)

        lblNombre.Text = DescripcionCadena(Cadenas.CDN_frmGuardarLayout_Nombre)
        lblDescripcion.Text = DescripcionCadena(Cadenas.CDN_frmGuardarLayout_Descripcion)
        lblOtrosLayouts.Text = DescripcionCadena(Cadenas.CDN_frmGuardarLayout_OtrosTip)
        chkShared.Text = DescripcionCadena(Cadenas.CDN_frmGuardarLayout_Compartido)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

        lvLayouts.Groups(0).Header = DescripcionCadena(Cadenas.CDN_frmGuardarLayout_LVGroup)

    End Sub

    Private Sub CargarLayouts()

        Dim sSQL As String
        Dim itmX As ListViewItem
        Dim ds As DataSet
        Dim i As Long

        sSQL = "SELECT      * " & _
               "FROM        CONLAY " & _
               "WHERE       CL_CODCON = " & COD_CONSULTA & " " & _
               "AND         CL_CODUSU = " & USUARIO_ACTUAL & " " & _
               "AND         CL_RESULT = " & DATASET_INDEX & " " & _
               "AND         CL_TIPLAY = " & TIPO_LAYOUT & " " & _
               "ORDER BY    CL_NOMBRE"

        Try

            ds = oAdmTablas.AbrirDataset(sSQL)
            lvLayouts.Items.Clear()

            With ds.Tables(0)

                For i = 0 To .Rows.Count - 1
                    itmX = New ListViewItem

                    itmX.Text = .Rows(i).Item("CL_NOMBRE").ToString
                    itmX.Name = "K" & .Rows(i).Item("CL_CODLAY").ToString
                    itmX.Tag = .Rows(i).Item("CL_SHARED").ToString

                    itmX.ImageIndex = 0
                    itmX.Group = lvLayouts.Groups(0)
                    itmX.SubItems.Add(.Rows(i).Item("CL_DESCRI"))

                    lvLayouts.Items.Add(itmX)

                Next

            End With

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub lvLayouts_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvLayouts.MouseDoubleClick

        Dim itmX As ListViewItem

        itmX = lvLayouts.FocusedItem


        If Not itmX Is Nothing Then
            If itmX.Selected Then
                txtNombre.Text = itmX.Text
                txtDescripcion.Text = itmX.SubItems(1).Text
                chkShared.Checked = (itmX.Tag = "1")
                cmdAceptar_Click(sender, e)
            End If
        End If

    End Sub

    Private Sub lvLayouts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLayouts.SelectedIndexChanged

        Dim itmX As ListViewItem

        itmX = lvLayouts.FocusedItem


        If Not itmX Is Nothing Then
            If itmX.Selected Then
                txtNombre.Text = itmX.Text
                txtDescripcion.Text = itmX.SubItems(1).Text
                chkShared.Checked = (itmX.Tag = "1")
            End If
        End If

    End Sub

    Private Function DatosOK() As Boolean

        Dim itmX As ListViewItem
        Dim sName As String

        If txtNombre.Text.Trim = vbNullString Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmGuardarLayout_NombreVacio))
            txtNombre.Focus()
            Exit Function
        End If

        sName = txtNombre.Text.Trim.ToUpper

        For Each itmX In lvLayouts.Items
            If itmX.Text.Trim.ToUpper = sName Then
                If Pregunta(DescripcionCadena(Cadenas.CDN_frmGuardarLayout_ConfirmarSobreescribir)) = Windows.Forms.DialogResult.No Then
                    Exit Function
                End If
            End If
        Next

        DatosOK = True

    End Function

    Private Sub Actualizar()

        Dim sSQL As String
        Dim ds As DataSet
        Dim nId As Long
        Dim oRow As DataRow
        Dim da As OleDb.OleDbDataAdapter
        Dim cb As OleDb.OleDbCommandBuilder
        Dim MODO As String
        Dim COD_LAYOUT As Integer
        Dim itmX As ListViewItem
        Dim sName As String

        Dim sXMLText As String

        sName = txtNombre.Text.Trim.ToUpper
        MODO = "A"

        Try

            sXMLText = IO.File.ReadAllText(XML_FILENAME)

            For Each itmX In lvLayouts.Items
                If itmX.Text.Trim.ToUpper = sName Then
                    MODO = "M"
                    COD_LAYOUT = Val(itmX.Name.Substring(1))
                End If
            Next


            If MODO = "A" Then
                nId = oAdmTablas.ProximoID("CONLAY", "CL_CODLAY")
            Else
                nId = COD_LAYOUT
            End If

            sSQL = "SELECT  * " & _
                   "FROM    CONLAY " & _
                   "WHERE   CL_CODLAY = " & nId

            ds = oAdmTablas.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

                If MODO = "A" Then

                    oRow = .NewRow()

                    oRow.Item("CL_CODLAY") = nId
                    oRow.Item("CL_CODCON") = COD_CONSULTA
                    oRow.Item("CL_CODUSU") = USUARIO_ACTUAL
                    oRow.Item("CL_TIPLAY") = TIPO_LAYOUT
                    oRow.Item("CL_RESULT") = DATASET_INDEX
                    oRow.Item("CL_NOMBRE") = txtNombre.Text.Trim
                    oRow.Item("CL_DESCRI") = txtDescripcion.Text.Trim
                    oRow.Item("CL_SHARED") = IIf(chkShared.Checked, 1, 0)
                    oRow.Item("CL_XML") = sXMLText

                    .Rows.Add(oRow)

                Else

                    oRow = .Rows(0)

                    oRow.BeginEdit()

                    oRow.Item("CL_DESCRI") = txtDescripcion.Text.Trim
                    oRow.Item("CL_SHARED") = IIf(chkShared.Checked, 1, 0)
                    oRow.Item("CL_XML") = sXMLText

                    oRow.EndEdit()

                End If

                da.Update(ds)
                ds.AcceptChanges()

            End With

            CANCEL_SAVE_LAYOUT = False
            Me.Close()

        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If DatosOK() Then
            Actualizar()
        End If
    End Sub
End Class

