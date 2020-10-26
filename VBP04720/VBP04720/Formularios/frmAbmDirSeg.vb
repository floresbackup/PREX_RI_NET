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
        Try

            If nCodDirectiva = 0 Then
                nCodDirectiva = oAdmTablas.ProximoID("DIRSEG", "DS_CODDIR")
            End If

            Dim rows = Prex.Utils.DataAccess.GetScalar($"Select TOP 1 1 from DIRSEG WHERE  DS_CODDIR = {nCodDirectiva}")
            Dim cmd As SqlClient.SqlCommand
            If rows = 1 Then
                cmd = New SqlClient.SqlCommand("update DIRSEG set " +
                                                " DS_VIGENT = @DS_VIGENT, " +
                                                " DS_DESCRI = @DS_DESCRI, " +
                                                " DS_DIASRE = @DS_DIASRE, " +
                                                " DS_DIASVT = @DS_DIASVT, " +
                                                " DS_CANTPC = @DS_CANTPC, " +
                                                " DS_INTBLO = @DS_INTBLO, " +
                                                " DS_PASCAR = @DS_PASCAR, " +
                                                " DS_PASNUM = @DS_PASNUM, " +
                                                " DS_PASESP = @DS_PASESP, " +
                                                " DS_MININA = @DS_MININA, " +
                                                " DS_SEGUNT = @DS_SEGUNT  " +
                                                " where DS_CODDIR = @DS_CODDIR ")
            Else
                cmd = New SqlClient.SqlCommand("insert into DIRSEG (DS_VIGENT, DS_DESCRI, DS_DIASRE, DS_DIASVT, DS_CANTPC, DS_INTBLO, " +
                                "DS_PASCAR, DS_PASNUM, DS_PASESP, DS_MININA, DS_SEGUNT, DS_CODDIR) " +
                                " values (@DS_VIGENT, @DS_DESCRI, @DS_DIASRE, @DS_DIASVT, @DS_CANTPC, @DS_INTBLO, @DS_PASCAR, @DS_PASNUM, " +
                                " @DS_PASESP, @DS_MININA, @DS_SEGUNT, @DS_CODDIR) ")
            End If

            cmd.Parameters.Add("DS_CODDIR", SqlDbType.Int).Value = nCodDirectiva
            cmd.Parameters.Add("DS_VIGENT", SqlDbType.Int).Value = 0
            cmd.Parameters.Add("DS_DESCRI", SqlDbType.VarChar, 50).Value = txtNombre.Text.Trim
            cmd.Parameters.Add("DS_DIASRE", SqlDbType.Int).Value = Val(txtDIASRE.Text)
            cmd.Parameters.Add("DS_DIASVT", SqlDbType.Int).Value = Val(txtDIASVT.Text)
            cmd.Parameters.Add("DS_CANTPC", SqlDbType.Int).Value = Val(txtCANTPC.Text)
            cmd.Parameters.Add("DS_INTBLO", SqlDbType.Int).Value = Val(txtINTBLO.Text)
            cmd.Parameters.Add("DS_PASCAR", SqlDbType.Int).Value = Val(txtPASCAR.Text)
            cmd.Parameters.Add("DS_PASNUM", SqlDbType.Int).Value = Val(txtPASNUM.Text)
            cmd.Parameters.Add("DS_PASESP", SqlDbType.Int).Value = Val(txtPASESP.Text)
            cmd.Parameters.Add("DS_MININA", SqlDbType.Int).Value = Val(txtMININA.Text)
            cmd.Parameters.Add("DS_SEGUNT", SqlDbType.Int).Value = IIf(chkSeguridadNT.Checked, 1, 0)

            Prex.Utils.DataAccess.Execute(cmd)

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
