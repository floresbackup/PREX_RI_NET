Imports System.Windows.Forms

Public Class frmTransaccion

   Private oAdmLocal As New AdmTablas
   Private bAlta As Boolean = True

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      If DatosOK() Then
         If actualizar() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
         End If
      End If

   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub CargarPerfiles()

      Dim sSQL As String
      Dim ds As DataSet
      Dim item As ListViewItem

      Try

         sSQL = "SELECT * " & _
                "FROM   CABPER " & _
                "ORDER  BY CP_DESCRI ASC"

         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            For Each row As DataRow In .Rows

               item = lvPerfiles.Items.Add(row("CP_DESCRI"))
               item.Name = row("CP_CODPER")
            Next

         End With

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "CargarPerfiles")
      End Try

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL
      CargarPerfiles()

   End Sub

   Private Sub cmdCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCarpeta.Click

      Dim oCarpeta As New frmArbolMenu

      If oCarpeta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
         txtCarpeta.Text = oCarpeta.NombreMenu
         txtCarpeta.Tag = oCarpeta.NumeroMenu
      End If

   End Sub

   Private Function DatosOK() As Boolean

      If Val(txtCodigo.Text) <= 0 Then
         MensajeError("Código de transacción inválido")
         Exit Function
      End If

      If txtNombre.Text.Trim = "" Then
         MensajeError("Proporcione el nombre de la transacción")
         txtNombre.Focus()
         Exit Function
      End If

      If txtPrograma.Text.Trim = "" Then
         MensajeError("Proporcione el programa de la transacción")
         txtPrograma.Focus()
         Exit Function
      End If

      If txtCarpeta.Text.Trim = "" Then
         MensajeError("Seleccione la carpeta donde debe ser ubicada esta transacción")
         cmdCarpeta.Focus()
         Exit Function
      End If

      If bAlta Then
         If TransaccionExiste(Val(txtCodigo.Text)) Then
            MensajeError("El código que intenta asignar ya pertenece a otra transacción")
            txtCodigo.Focus()
            Exit Function
         End If
      End If

      Return True

   End Function

   Private Function TransaccionExiste(ByVal nCodTra As Long) As Boolean

      Dim nTransa As Long

      nTransa = oAdmLocal.DevolverValor("MENUES", "MU_CODTRA", "MU_CODTRA = " & nCodTra, 0)

      If nTransa <> 0 Then
         Return True
      End If

   End Function

   Private Function actualizar() As Boolean

      Dim sSQL As String
      Dim ds As DataSet
      Dim cb As OleDb.OleDbCommandBuilder
      Dim da As OleDb.OleDbDataAdapter
      Dim row As DataRow
      Dim nProxID As Long
      Dim itmX As ListViewItem

      Try

         'Transaccion
         If bAlta Then
            nProxID = oAdmLocal.ProximoID("MENUES", "MU_NROMEN")
         Else
            nProxID = oAdmLocal.DevolverValor("MENUES", "MU_NROMEN", "MU_CODTRA = " & Val(txtCodigo.Text), 0)
         End If

         sSQL = "SELECT    * " & _
                "FROM      MENUES " & _
                "WHERE     MU_NROMEN = " & nProxID
         ds = oAdmLocal.AbrirDataset(sSQL, da)
         cb = New OleDb.OleDbCommandBuilder(da)

         With ds.Tables(0)

            If bAlta Then
               row = .NewRow()
            Else
               row = .Rows(0)
            End If

            row("MU_NROMEN") = nProxID
            row("MU_CODTRA") = Val(txtCodigo.Text)
            row("MU_TRANSA") = txtNombre.Text.Trim
            row("MU_DESCRI") = txtDescripcion.Text.Trim
            row("MU_COMAND") = txtPrograma.Text.Trim
            row("MU_NIVEL") = 0
            row("MU_RELMEN") = Val(txtCarpeta.Tag)

            If bAlta Then
               .Rows.Add(row)
            End If

         End With

         da.Update(ds)
         ds.AcceptChanges()

         ds = Nothing
         cb = Nothing
         da = Nothing

         'Perfiles
         sSQL = "DELETE    " & _
                "FROM      DETPER " & _
                "WHERE     DP_CODTRA = " & Val(txtCodigo.Text)

         If oAdmLocal.EjecutarComandoSQL(sSQL) Then

            sSQL = "SELECT    * " & _
                   "FROM      DETPER " & _
                   "WHERE     DP_CODTRA = " & Val(txtCodigo.Text)

            ds = oAdmLocal.AbrirDataset(sSQL, da)
            cb = New OleDb.OleDbCommandBuilder(da)

            With ds.Tables(0)

               For Each itmX In lvPerfiles.Items
                  If itmX.Checked Then
                     row = .NewRow()
                     row("DP_CODPER") = Val(itmX.Name)
                     row("DP_CODTRA") = Val(txtCodigo.Text)
                     .Rows.Add(row)
                  End If
               Next

            End With

            da.Update(ds)
            ds.AcceptChanges()

            ds = Nothing
            cb = Nothing
            da = Nothing

         End If

         Return True

      Catch ex As Exception
         TratarError(ex, "actualizar")
      End Try

   End Function

   Public Sub PasarDatos(ByVal nNroMen As Long)

      Dim sSQL As String
      Dim ds As DataSet
      Dim item As ListViewItem
      Dim row As DataRow

      Try

         sSQL = "SELECT * " & _
                "FROM   MENUES " & _
                "WHERE  MU_NROMEN = " & nNroMen.ToString & " "
         ds = oAdmLocal.AbrirDataset(sSQL)

         If ds.Tables(0).Rows.Count > 0 Then

            row = ds.Tables(0).Rows(0)

            txtCodigo.Text = row("MU_CODTRA")
            txtNombre.Text = row("MU_TRANSA")
            txtPrograma.Text = row("MU_COMAND")
            txtDescripcion.Text = row("MU_DESCRI")

            If row("MU_RELMEN") = 0 Then
               txtCarpeta.Text = "Menú"
            Else
               txtCarpeta.Text = oAdmLocal.DevolverValor("MENUES", "MU_TRANSA", "MU_NROMEN=" & row("MU_RELMEN"))
            End If
            txtCarpeta.Tag = row("MU_RELMEN")

         End If

         ds = Nothing

         txtCodigo.Enabled = False

         bAlta = False

         sSQL = "SELECT    * " & _
                "FROM      DETPER " & _
                "WHERE     DP_CODTRA = " & txtCodigo.Text & " " & _
                "ORDER BY  DP_CODPER "
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            For Each row In .Rows

               item = lvPerfiles.Items(row("DP_CODPER").ToString)
               item.Checked = True

            Next

         End With

         ds = Nothing

      Catch ex As Exception
         TratarError(ex, "PasarDatos")
      End Try

   End Sub

End Class
