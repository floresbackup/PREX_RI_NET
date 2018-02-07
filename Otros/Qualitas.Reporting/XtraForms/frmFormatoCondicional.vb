Imports DevExpress.XtraPivotGrid

Public Class frmFormatoCondicional

    Private MODO As String
    Private oFCons As frmConsulta
    Private oFmtActual As PivotGridStyleFormatCondition

    Public Sub New(ByRef oFormConsulta As frmConsulta)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        LocalizarFormulario()
        MODO = "A"
        oFCons = oFormConsulta
        'oFCons.pgCubo.FormatConditions.Clear()
        CargarInfo()
        PrepararInsert()

    End Sub

    Private Sub LocalizarFormulario()

        On Error Resume Next

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionFormatoCondicional)

        grpDatosFormato.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_HeaderGrupoDatos)
        grpFormatos.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_HeaderGrupoFormatos)
        lblColumna.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Columna)
        lblCondicion.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Comparador)
        lblValor1.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Valor1)
        lblValor2.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Valor2)
        lblFormato.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Formato)
        lblAplicaA.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_AplicaA)
        chkNegrita.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Negrita)
        chkCursiva.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Cursiva)
        chkSubrayado.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Subrayado)
        chkTachado.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Tachado)
        lblColorFuente.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_ColorFuente)
        lblColorFondo.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_ColorFondo)
        lblColorFondo2.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_ColorFondo2)
        chkCelda.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_AplicaCelda)
        chkSubtotalCelda.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_AplicaCeldaTotal)
        chkGranTotalCelda.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_AplicaCeldaGranTotal)
        chkTotalPersonalizadoCelda.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_AplicaCeldaTotalPersonalizado)

        lvFormatos.Columns(0).Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Formato)
        lvFormatos.Columns(1).Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Comparador)
        lvFormatos.Columns(2).Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Valor1)
        lvFormatos.Columns(3).Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Valor2)

        ' Combo Condicion
        With cboCondicion
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionNinguna))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionIgual))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionDistinto))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionEntre))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionNoEntre))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionMenor))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionMayor))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionMayorIgual))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionMenorIgual))
            .SelectedIndex = 0
        End With

        ' Combo Degradado
        With cboDegradado
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_TipoDegradadoHorizontal))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_TipoDegradadoVertical))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_TipoDegradadoDiagonalAdelante))
            .Properties.Items.Add(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_TipoDegradadoDiagonalAtras))
            .SelectedIndex = 0
        End With

        cmdUpdate.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Agregar)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)
        cmdCerrar.Text = DescripcionCadena(Cadenas.CDN_GeneralCerrar)


    End Sub

    Private Sub CargarInfo()

        Dim oFmt As PivotGridStyleFormatCondition
        Dim oField As PivotGridField
        Dim itmX As ListViewItem
        Dim nTemp As Integer

        cboColorFuente.Color = Color.Black
        cboColorFondo.Color = Color.White
        cboColorFondo2.Color = Color.White

        cboColumna.Properties.Items.Clear()

        For Each oField In oFCons.pgCubo.Fields
            With cboColumna
                If Not .Properties.Items.Contains(oField.FieldName) Then
                    .Properties.Items.Add(oField.FieldName)
                End If
            End With
        Next

        cboColumna.SelectedIndex = 0

        lvFormatos.Items.Clear()
        nTemp = 0

        For Each oFmt In oFCons.pgCubo.FormatConditions

            nTemp = nTemp + 1

            itmX = New ListViewItem

            itmX.Name = "F" & nTemp
            oFmt.Tag = itmX.Name


            itmX.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Formato) & " " & nTemp
            
            itmX.SubItems.Add(DescriptorComparacion(oFmt.Condition))
            itmX.SubItems.Add(oFmt.Value1)
            itmX.SubItems.Add(oFmt.Value2)
            itmX.ImageIndex = 0



            lvFormatos.Items.Add(itmX)

        Next

    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub PrepararUpdate(ByRef itmX As ListViewItem)

        Dim oFmt As PivotGridStyleFormatCondition

        cmdUpdate.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Modificar)
        MODO = "M"
        lvFormatos.Enabled = False
        cmdEliminar.Enabled = False
        cmdCancelar.Enabled = True
        cboColumna.Enabled = False

        oFmt = FormatoDeTAG(itmX.Name)

        With oFmt
            'cboColumna.SelectedItem = .Field.FieldName

            cboCondicion.SelectedIndex = .Condition
            txtValor1.Text = .Value1
            txtValor2.Text = .Value2
            chkNegrita.Checked = .Appearance.Font.Bold
            chkCursiva.Checked = .Appearance.Font.Italic
            chkSubrayado.Checked = .Appearance.Font.Underline
            chkTachado.Checked = .Appearance.Font.Strikeout
            chkCelda.Checked = .ApplyToCell
            chkSubtotalCelda.Checked = .ApplyToTotalCell
            chkGranTotalCelda.Checked = .ApplyToGrandTotalCell
            chkTotalPersonalizadoCelda.Checked = .ApplyToCustomTotalCell
            cboColorFuente.Color = .Appearance.ForeColor
            cboColorFondo.Color = .Appearance.BackColor
            cboColorFondo2.Color = .Appearance.BackColor2
            cboDegradado.SelectedIndex = .Appearance.GradientMode

            oFmtActual = oFmt

        End With

    End Sub

    Private Sub PrepararInsert()

        cmdUpdate.Text = DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_Agregar)
        MODO = "A"
        lvFormatos.Enabled = True
        cmdEliminar.Enabled = True
        cmdCancelar.Enabled = False
        cboColumna.Enabled = True

        cboColumna.SelectedIndex = 0
        cboCondicion.SelectedIndex = 0
        cboDegradado.SelectedIndex = 0
        txtValor1.Text = ""
        txtValor2.Text = ""
        cboColorFuente.Color = System.Drawing.ColorTranslator.FromOle(RGB(0, 0, 0))
        cboColorFondo.Color = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
        cboColorFondo2.Color = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))

        chkCelda.Checked = True
        chkSubtotalCelda.Checked = True
        chkGranTotalCelda.Checked = True
        chkTotalPersonalizadoCelda.Checked = True

    End Sub

    Private Function DescriptorComparacion(ByVal nCodigoComp As Integer) As String

        Dim sTemp As String

        Select Case nCodigoComp
            Case 0 : sTemp = (DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionNinguna))
            Case 1 : sTemp = (DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionIgual))
            Case 2 : sTemp = (DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionDistinto))
            Case 3 : sTemp = (DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionEntre))
            Case 4 : sTemp = (DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionNoEntre))
            Case 5 : sTemp = (DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionMenor))
            Case 6 : sTemp = (DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionMayor))
            Case 7 : sTemp = (DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionMayorIgual))
            Case 8 : sTemp = (DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_CondicionMenorIgual))
        End Select

        DescriptorComparacion = sTemp

    End Function

    Private Function FormatoDeTAG(ByVal sTag As String) As PivotGridStyleFormatCondition

        Dim sTemp As String
        Dim oFmt As PivotGridStyleFormatCondition


        For Each oFmt In oFCons.pgCubo.FormatConditions

            If oFmt.Tag = sTag Then
                FormatoDeTAG = oFmt
                Exit Function
            End If

        Next

        FormatoDeTAG = Nothing

    End Function

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

        If txtValor1.Text.Trim = "" Then

            MensajeError(DescripcionCadena(Cadenas.CDN_frmFormatoCondicional_ErrorValor1))

        Else

            If Not chkCelda.Checked And _
               Not chkSubtotalCelda.Checked And _
               Not chkGranTotalCelda.Checked And _
               Not chkTotalPersonalizadoCelda.Checked Then

                chkCelda.Checked = True
                chkSubtotalCelda.Checked = True
                chkGranTotalCelda.Checked = True
                chkTotalPersonalizadoCelda.Checked = True

            End If

            If MODO = "A" Then
                Agregar()
            Else
                Actualizar()
            End If

        End If
    End Sub

    Private Sub Agregar()

        Dim itmX As ListViewItem

        Dim oFmt As PivotGridStyleFormatCondition

        Try
            Cursor = Cursors.WaitCursor

            oFmt = New PivotGridStyleFormatCondition
            
            With oFmt
                .ApplyToCell = chkCelda.Checked
                .ApplyToTotalCell = chkSubtotalCelda.Checked
                .ApplyToGrandTotalCell = chkGranTotalCelda.Checked
                .ApplyToCustomTotalCell = chkTotalPersonalizadoCelda.Checked

                .Field = oFCons.pgCubo.Fields(cboColumna.SelectedItem)
                .FieldName = .Field.FieldName '
                .Condition = cboCondicion.SelectedIndex
                .Value1 = txtValor1.Text.Trim
                .Value2 = txtValor2.Text.Trim

                With .Appearance
                    .BackColor = cboColorFondo.Color
                    .BackColor2 = cboColorFondo2.Color
                    .ForeColor = cboColorFuente.Color
                    .Font = New Font(.Font, (FontStyle.Bold And chkNegrita.Checked) Or (FontStyle.Italic And chkCursiva.Checked) Or (FontStyle.Underline And chkSubrayado.Checked) Or (FontStyle.Strikeout And chkTachado.Checked))
                    .GradientMode = cboDegradado.SelectedIndex

                    With .Options
                        .UseBackColor = True
                        .UseFont = True
                        .UseForeColor = True
                        .UseTextOptions = True
                    End With

                End With



            End With

            oFCons.pgCubo.FormatConditions.Add(oFmt)
            CargarInfo()
            PrepararInsert()

            Cursor = Cursors.Default


        Catch ex As Exception
            TratarError(ex)
        End Try


    End Sub

    Private Sub Actualizar()

        Dim itmX As ListViewItem

        Dim oFmt As PivotGridStyleFormatCondition

        Try
            Cursor = Cursors.WaitCursor

            oFmt = oFmtActual

            With oFmt
                .ApplyToCell = chkCelda.Checked
                .ApplyToTotalCell = chkSubtotalCelda.Checked
                .ApplyToGrandTotalCell = chkGranTotalCelda.Checked
                .ApplyToCustomTotalCell = chkTotalPersonalizadoCelda.Checked

                '.Field = oFCons.pgCubo.Fields(cboColumna.SelectedItem)
                '.FieldName = .Field.FieldName '
                .Condition = cboCondicion.SelectedIndex
                .Value1 = txtValor1.Text.Trim
                .Value2 = txtValor2.Text.Trim

                With .Appearance
                    .BackColor = cboColorFondo.Color
                    .BackColor2 = cboColorFondo2.Color
                    .ForeColor = cboColorFuente.Color
                    .Font = New Font(.Font, (FontStyle.Bold And chkNegrita.Checked) Or (FontStyle.Italic And chkCursiva.Checked) Or (FontStyle.Underline And chkSubrayado.Checked) Or (FontStyle.Strikeout And chkTachado.Checked))
                    .GradientMode = cboDegradado.SelectedIndex

                    With .Options
                        .UseBackColor = True
                        .UseFont = True
                        .UseForeColor = True
                        .UseTextOptions = True
                    End With

                End With



            End With

            CargarInfo()
            PrepararInsert()

            Cursor = Cursors.Default


        Catch ex As Exception
            TratarError(ex)
        End Try

    End Sub

    Private Sub lvFormatos_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvFormatos.MouseDoubleClick


        Dim itmX As ListViewItem

        If e.Button = Windows.Forms.MouseButtons.Left Then
            itmX = lvFormatos.FocusedItem

            If Not itmX Is Nothing Then
                PrepararUpdate(itmX)
            End If
        End If
    End Sub


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        PrepararInsert()
        CargarInfo()
    End Sub

    Private Sub lvFormatos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvFormatos.SelectedIndexChanged

    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click

        Dim itmX As ListViewItem
        Dim oFmt As PivotGridStyleFormatCondition

        itmX = lvFormatos.FocusedItem

        If Not itmX Is Nothing Then
            oFmt = FormatoDeTAG(itmX.Name)
            oFCons.pgCubo.FormatConditions.Remove(oFmt)
            CargarInfo()
            PrepararInsert()
        End If

    End Sub
End Class