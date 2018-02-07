Public Class frmEditorExpresion 

    Private SQL_CONSULTA As String
    Private VARIABLE_PARAMETRO As String
    Private CONEXION_ACTUAL As String
    Private TIPO_CONEXION As Integer

    Public Sub New(ByVal sSQL As String, ByVal sNombreVariable As String, ByVal sCadenaConexion As String, ByVal nTipoConexion As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        EXPRESION_DEVUELTA = ""

        SQL_CONSULTA = sSQL
        VARIABLE_PARAMETRO = sNombreVariable
        CONEXION_ACTUAL = sCadenaConexion
        TIPO_CONEXION = nTipoConexion

        LocalizarFormulario()
        LlenarCombos()

    End Sub

    Private Sub LocalizarFormulario()


        On Error Resume Next
        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionConstruirExpresion)

        lblInclusion.Text = DescripcionCadena(Cadenas.CDN_frmEditorExpresion_Inclusion)
        lblColumna.Text = DescripcionCadena(Cadenas.CDN_frmEditorExpresion_Columna)
        lblComparacion.Text = DescripcionCadena(Cadenas.CDN_frmEditorExpresion_Comparacion)
        lblValor.Text = DescripcionCadena(Cadenas.CDN_frmEditorExpresion_Valor)

        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

    End Sub

    Private Sub LlenarCombos()

        Dim nI As Integer
        Dim sTemp As String

        With cboInclusion
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmEditorExpresion_AND))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmEditorExpresion_OR))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmEditorExpresion_AND_NOT))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmEditorExpresion_OR_NOT))
            .SelectedIndex = 0
        End With

        With cboValor

            If VARIABLE_PARAMETRO <> "" Then
                .Properties.Items.Add(VARIABLE_PARAMETRO)
                .SelectedIndex = 0
            End If

            For nI = 1 To 99
                .Properties.Items.Add("|PARAM" & Format(nI, "00") & "|")
            Next

        End With

        CargarColumnas()

    End Sub

    Private Sub CargarColumnas()

        On Error Resume Next

        Dim dt As DataTable
        Dim oCol As DataColumn
        Dim oAdmSchema As New AdmTablas

        oAdmSchema.ConnectionString = CONEXION_ACTUAL

        Cursor = Cursors.WaitCursor

        Select Case TIPO_CONEXION
            Case 0
                dt = oAdmSchema.AbrirSchema(SQL_CONSULTA)
            Case 1
                dt = oAdmSchema.AbrirSchemaNativo(SQL_CONSULTA)
            Case 2
                dt = oAdmSchema.AbrirSchemaOracleNativo(SQL_CONSULTA)
            Case 3
                dt = oAdmSchema.AbrirSchemaODBCNativo(SQL_CONSULTA)
        End Select

        For Each oCol In dt.Columns
            cboColumna.Properties.Items.Add(oCol.ColumnName)
        Next

        Cursor = Cursors.Default

    End Sub

    Private Function DatosOK() As Boolean

        If cboColumna.Text.Trim = "" Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmEditorExpresion_ColumnaVacia))
            cboColumna.Focus()
            Exit Function
        End If

        If cboValor.Text.Trim = "" Then
            MensajeError(DescripcionCadena(Cadenas.CDN_frmEditorExpresion_ValorVacio))
            cboValor.Focus()
            Exit Function
        End If

        DatosOK = True

    End Function

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If DatosOK() Then
            Devolver()
        End If
    End Sub

    Private Sub Devolver()

        Dim sTemp As String

        ' Inclusion

        Select Case cboInclusion.SelectedIndex
            Case 0 : sTemp = "AND ("
            Case 1 : sTemp = "OR ("
            Case 2 : sTemp = "AND NOT ("
            Case 3 : sTemp = "OR NOT ("
        End Select

        ' Columna

        sTemp = sTemp & OBJECT_IDENTIFIER_START & cboColumna.Text.Trim & OBJECT_IDENTIFIER_CLOSE & " "

        ' Comparacion y valor

        If cboComparacion.Text = "IN ( ... )" Then
            sTemp = sTemp & " IN ( " & cboValor.Text.Trim & " )"
        ElseIf cboComparacion.Text = "NOT IN ( ... )" Then
            sTemp = sTemp & " NOT IN ( " & cboValor.Text.Trim & " )"
        Else
            sTemp = sTemp & cboComparacion.Text & " " & cboValor.Text.Trim
        End If


        sTemp = sTemp & ")"

        EXPRESION_DEVUELTA = sTemp
        Me.Close()


    End Sub

End Class