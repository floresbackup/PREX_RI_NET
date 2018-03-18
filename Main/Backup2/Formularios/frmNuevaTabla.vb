Imports System.Windows.Forms

Public Class frmNuevaTabla

   Private oAdmLocal As New AdmTablas

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

      If DatosOK Then

         NOMBRE_NUEVA_TABLA = txtNombreTabla.Text
         DESCRIPCION_NUEVA_TABLA = Trim(txtDescripcion.text)
         FECHA_VIG_NUEVA_TABLA = txtFechaVig.Value

         GuardarTabla()

         Me.DialogResult = System.Windows.Forms.DialogResult.OK
         Me.Close()

      End If

   End Sub

   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub frmNuevaTabla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      txtFechaVig.Value = Date.Now

   End Sub

   Public Sub New()

      ' Llamada necesaria para el Diseñador de Windows Forms.
      InitializeComponent()

      ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
      oAdmLocal.ConnectionString = CONN_LOCAL

   End Sub

   Private Function DatosOK() As Boolean

      If DisenoExiste Then
         MensajeError("El nombre de tabla ingresado ya existe")
         txtNombreTabla.Focus()
         Exit Function
      End If

      DatosOK = True

   End Function

   Private Function DisenoExiste() As Boolean

      Dim sSQL As String
      Dim ds As DataSet

      Try

         sSQL = "SELECT    COUNT(DN_TABLA) AS TABLAS " & _
                "FROM      DISNOM " & _
                "WHERE     DN_TABLA = '" & txtNombreTabla.Text & "' " & _
                "AND       DN_FECHAVIG = " & FechaSQL(txtFechaVig.Value) & " " & _
                "AND       DN_CODENT IN (0, " & CODIGO_ENTIDAD.ToString & ") "
         ds = oAdmLocal.AbrirDataset(sSQL)

         With ds.Tables(0)

            If .Rows(0).Item("TABLAS") > 0 Then
               Return True
            End If

         End With

      Catch ex As Exception
         TratarError(ex, "DisenoExiste")
      End Try

   End Function

   Private Sub GuardarTabla()


      Dim sSQL As String

      sSQL = "INSERT INTO DISNOM (DN_NOMBRE, DN_TABLA, DN_FECHAVIG, DN_INACTIVO, DN_CODENT) " & _
             "VALUES (" & _
             "'" & DESCRIPCION_NUEVA_TABLA & "', " & _
             "'" & NOMBRE_NUEVA_TABLA & " '," & _
             FechaSQL(FECHA_VIG_NUEVA_TABLA) & ",0," & CODIGO_ENTIDAD & ")"
      oAdmLocal.EjecutarComandoSQL(sSQL)

   End Sub

End Class
