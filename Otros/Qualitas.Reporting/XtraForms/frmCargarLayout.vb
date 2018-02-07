Public Class frmCargarLayout

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
        LOAD_LAYOUT_SUCCESS = False

        CargarLayouts()

    End Sub

    Private Sub LocalizarFormulario()

        On Error Resume Next

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionCargarLayout)

        lblOtrosLayouts.Text = DescripcionCadena(Cadenas.CDN_frmCargarLayout_OtrosTip)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

        lvLayouts.Groups(0).Header = DescripcionCadena(Cadenas.CDN_frmCargarLayout_LVGroupPropios)
        lvLayouts.Groups(1).Header = DescripcionCadena(Cadenas.CDN_frmCargarLayout_LVGroupCompartidos)

    End Sub

    Private Sub CargarLayouts()

        Dim sSQL As String
        Dim itmX As ListViewItem
        Dim ds As DataSet
        Dim i As Long

        sSQL = "SELECT      * " & _
               "FROM        CONLAY " & _
               "WHERE       CL_CODCON = " & COD_CONSULTA & " " & _
               "AND        (CL_CODUSU = " & USUARIO_ACTUAL & " OR CL_SHARED = 1) " & _
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
                    itmX.Tag = .Rows(i).Item("CL_XML").ToString

                    itmX.ImageIndex = IIf(.Rows(i).Item("CL_SHARED") = 0 Or .Rows(i).Item("CL_CODUSU") = USUARIO_ACTUAL, 0, 1)
                    itmX.Group = IIf(.Rows(i).Item("CL_SHARED") = 0 Or .Rows(i).Item("CL_CODUSU") = USUARIO_ACTUAL, lvLayouts.Groups(0), lvLayouts.Groups(1))
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
                cmdAceptar_Click(sender, e)
            End If
        End If

    End Sub

    Private Sub lvLayouts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLayouts.SelectedIndexChanged

        Dim itmX As ListViewItem

        cmdEliminar.Enabled = False
        itmX = lvLayouts.FocusedItem

        If Not itmX Is Nothing Then
            If itmX.Selected Then
                If itmX.Group.Name = "lvg001" Then
                    cmdEliminar.Enabled = True
                End If
            End If
        End If

    End Sub

    Private Function DatosOK() As Boolean

        Dim itmX As ListViewItem
        Dim sName As String

        itmX = lvLayouts.FocusedItem

        If Not itmX Is Nothing Then
            If itmX.Selected Then
                DatosOK = True
            End If
        End If

    End Function

    Private Sub Devolver()

        Dim itmX As ListViewItem

        itmX = lvLayouts.FocusedItem

        If Not itmX Is Nothing Then

            Try

                Cursor = Cursors.WaitCursor
                Call IO.File.WriteAllText(XML_FILENAME, itmX.Tag)
                LOAD_LAYOUT_SUCCESS = True
                Cursor = Cursors.Default
                Me.Close()

            Catch ex As Exception
                TratarError(ex)
            End Try

        End If

    End Sub


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If DatosOK() Then
            Devolver()
        End If
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click

        Dim itmX As ListViewItem
        Dim nCodLayout As Long

        itmX = lvLayouts.FocusedItem

        If Not itmX Is Nothing Then
            If itmX.Selected Then
                If Pregunta(DescripcionCadena(Cadenas.CDN_frmCargarLayout_ConfirmarEliminar)) = Windows.Forms.DialogResult.Yes Then
                    nCodLayout = Val(itmX.Name.Substring(1))
                    EliminarConsulta(nCodLayout)
                End If
            End If
        End If
    End Sub

    Private Sub EliminarConsulta(ByVal nCodigo As Long)

        Dim sSQL As String
        Dim bTemp As Boolean

        sSQL = "DELETE FROM CONLAY WHERE CL_CODLAY = " & nCodigo

        Try
            bTemp = oAdmTablas.EjecutarComandoSQL(sSQL)

            If bTemp Then
                CargarLayouts()
            End If

        Catch ex As Exception
            TratarError(ex)
        End Try
    End Sub

End Class

