Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb

Public Class frmAbmDirSeg

   Private nCodDirectiva As Long
   Private oAdmTablas As New AdmTablas

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      If DatosOK() Then
         If GuardarDirectiva() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
         End If
      End If

   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()

   End Sub

   Private Function DatosOK() As Boolean

      If Trim(txtNombre.Text) = "" Then
         MensajeError("Proporcione el nombre de la directiva")
         txtNombre.Focus()
         Return False
      End If

      If Val(txtDIASRE.Text) < 1 Then
         MensajeError("Proporcione un entero positivo")
         txtDIASRE.Focus()
         Return False
      End If

      If Val(txtDIASVT.Text) < 1 Then
         MensajeError("Proporcione un entero positivo")
         txtDIASVT.Focus()
         Return False
      End If

      If Val(txtCANTPC.Text) < 0 Or _
         Val(txtCANTPC.Text) > 5 Then
         MensajeError("Proporcione un entero entre 0 y 5")
         txtCANTPC.Focus()
         Return False
      End If

      If Val(txtINTBLO.Text) < 0 Then
         MensajeError("Proporcione un entero positivo o bien ingrese cero")
         txtINTBLO.Focus()
         Return False
      End If

      If Val(txtPASCAR.Text) < 0 Then
         MensajeError("Proporcione un entero positivo o bien ingrese cero")
         txtPASCAR.Focus()
         Return False
      End If

      If Val(txtPASNUM.Text) < 0 Then
         MensajeError("Proporcione un entero positivo o bien ingrese cero")
         txtPASNUM.Focus()
         Return False
      End If

      If Val(txtPASESP.Text) < 0 Then
         MensajeError("Proporcione un entero positivo o bien ingrese cero")
         txtPASESP.Focus()
         Return False
      End If

      If Val(txtMININA.Text) < 0 Then
         MensajeError("Proporcione un entero positivo o bien ingrese cero")
         txtMININA.Focus()
         Return False
      End If

      Return True

   End Function

   Private Function GuardarDirectiva() As Boolean

      Dim sSQL As String
      Dim ds As DataSet
      Dim da As OleDbDataAdapter = Nothing
      Dim cb As OleDbCommandBuilder
      Dim row As DataRow

      Try

         If nCodDirectiva = 0 Then
            nCodDirectiva = oAdmTablas.ProximoID("DIRSEG", "DS_CODDIR")
         End If

         sSQL = "SELECT    * " & _
                "FROM      DIRSEG " & _
                "WHERE     DS_CODDIR = " & nCodDirectiva

         ds = oAdmTablas.AbrirDataset(sSQL, da)
         cb = New OleDbCommandBuilder(da)

         With ds.Tables(0)

            If .Rows.Count = 0 Then
               row = .NewRow
            Else
               row = .Rows(0)
            End If

            row("DS_CODDIR") = nCodDirectiva
            row("DS_VIGENT") = 0
            row("DS_DESCRI") = Trim(txtNombre.Text)
            row("DS_DIASRE") = Val(txtDIASRE.Text)
            row("DS_DIASVT") = Val(txtDIASVT.Text)
            row("DS_CANTPC") = Val(txtCANTPC.Text)
            row("DS_INTBLO") = Val(txtINTBLO.Text)
            row("DS_PASCAR") = Val(txtPASCAR.Text)
            row("DS_PASNUM") = Val(txtPASNUM.Text)
            row("DS_PASESP") = Val(txtPASESP.Text)
            row("DS_MININA") = Val(txtMININA.Text)
            row("DS_SEGUNT") = IIf(chkSeguridadNT.Checked, 1, 0)

            If .Rows.Count = 0 Then
               .Rows.Add(row)
            End If

         End With

         da.Update(ds)
         ds.AcceptChanges()

         ds = Nothing

         Return True

      Catch ex As Exception
         TratarError(ex, "GuardarDirectiva")
      End Try

   End Function

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmTablas.ConnectionString = CONN_LOCAL

   End Sub

   Public Sub PasarDatos(ByVal nCodDir As Long)

      nCodDirectiva = nCodDir
      CargarDatosDirectiva()

   End Sub

   Private Sub CargarDatosDirectiva()

      Dim sSQL As String
      Dim ds As DataSet
      Dim row As DataRow

      Try

         sSQL = "SELECT    * " & _
                "FROM      DIRSEG " & _
                "WHERE     DS_CODDIR = " & nCodDirectiva
         ds = oAdmTablas.AbrirDataset(sSQL)

         With ds.tables(0)

            row = .rows(0)

            txtNombre.Text = row("DS_DESCRI")
            txtDIASRE.Text = row("DS_DIASRE")
            txtDIASVT.Text = row("DS_DIASVT")
            txtCANTPC.Text = row("DS_CANTPC")
            txtINTBLO.Text = row("DS_INTBLO")
            txtPASCAR.Text = row("DS_PASCAR")
            txtPASNUM.Text = row("DS_PASNUM")
            txtPASESP.Text = row("DS_PASESP")
            txtMININA.Text = row("DS_MININA")

            chkSeguridadNT.Checked = IIf(row("DS_SEGUNT") <> 0, True, False)

         End With

         row = Nothing
         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "CargarDatosDirectiva")
      End Try


   End Sub

End Class
