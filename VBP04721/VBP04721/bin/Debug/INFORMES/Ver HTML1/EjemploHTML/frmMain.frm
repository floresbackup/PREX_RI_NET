VERSION 5.00
Object = "{65E121D4-0C60-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCHRT20.OCX"
Begin VB.Form frmMain 
   Caption         =   "Form1"
   ClientHeight    =   6465
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6675
   LinkTopic       =   "Form1"
   ScaleHeight     =   6465
   ScaleWidth      =   6675
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox chkGrafico 
      Caption         =   "Con grafico"
      Height          =   195
      Left            =   4680
      TabIndex        =   9
      Top             =   1020
      Width           =   1695
   End
   Begin VB.TextBox txtObservaciones 
      Height          =   1995
      Left            =   1440
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   8
      Text            =   "frmMain.frx":0000
      Top             =   900
      Width           =   2835
   End
   Begin VB.TextBox txtFecha 
      Height          =   315
      Left            =   1440
      TabIndex        =   7
      Text            =   "29/11/2006"
      Top             =   540
      Width           =   1275
   End
   Begin VB.TextBox txtCliente 
      Height          =   315
      Left            =   1440
      TabIndex        =   6
      Text            =   "PEPE S.A."
      Top             =   180
      Width           =   1275
   End
   Begin VB.CommandButton cmdGenerarReporte 
      Caption         =   "Generar reporte"
      Height          =   435
      Left            =   4740
      TabIndex        =   2
      Top             =   1380
      Width           =   1755
   End
   Begin VB.PictureBox picTemp 
      AutoRedraw      =   -1  'True
      Height          =   2595
      Left            =   60
      ScaleHeight     =   2535
      ScaleWidth      =   4815
      TabIndex        =   1
      Top             =   3780
      Visible         =   0   'False
      Width           =   4875
   End
   Begin MSChart20Lib.MSChart oGrafico 
      Height          =   3135
      Left            =   240
      OleObjectBlob   =   "frmMain.frx":0010
      TabIndex        =   0
      Top             =   3120
      Visible         =   0   'False
      Width           =   4995
   End
   Begin VB.Label lbl 
      Caption         =   "Observaciones"
      Height          =   195
      Index           =   2
      Left            =   60
      TabIndex        =   5
      Top             =   960
      Width           =   1215
   End
   Begin VB.Label lbl 
      Caption         =   "Fecha"
      Height          =   195
      Index           =   1
      Left            =   60
      TabIndex        =   4
      Top             =   600
      Width           =   1215
   End
   Begin VB.Label lbl 
      Caption         =   "Cliente"
      Height          =   195
      Index           =   0
      Left            =   60
      TabIndex        =   3
      Top             =   240
      Width           =   1215
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdGenerarReporte_Click()
   
   Dim sRutaGrafico     As String
   Dim sPlantilla       As String
   Dim sCampos          As String
   Dim sDatos           As String
   
   ''''' EJEMPLOS ''''''
   
   sPlantilla = App.Path & "\HTML\Plantilla.html"
   sCampos = "CLIENTE|FECHA|OBSERVACIONES"
   sDatos = txtCliente & "|" & txtFecha & "|" & txtObservaciones
   
   ''''' FIN EJEMPLOS
   
   If chkGrafico.Value = 1 Then
      sRutaGrafico = App.Path & "\HTML\IMAGES\Grafico.bmp"
      GuardarImagenGrafico sRutaGrafico
   End If
   
   Generar sPlantilla, sCampos, sDatos, sRutaGrafico
   
End Sub

Private Sub GuardarImagenGrafico(ByVal sRuta As String)
   
   On Error GoTo Err_Trap:
   
   oGrafico.EditCopy
   picTemp.Picture = Clipboard.GetData(vbCFBitmap)
   SavePicture picTemp.Picture, sRuta
   
   Exit Sub
   
Err_Trap:
   
   MsgBox Err.Description, vbCritical
   
End Sub

Private Sub Generar(ByVal sPlantilla As String, _
                    ByVal sCampos As String, _
                    ByVal sDatos As String, _
                    Optional ByVal sRutaImagen As String = "")
                    
   On Error GoTo Err_Trap:
                       
   Dim oFSO       As New FileSystemObject
   Dim oTextIN    As TextStream
   Dim sTextIN    As String
   Dim oTextOUT   As TextStream
   Dim sTextOUT   As String
   Dim sCamp()    As String
   Dim sDato()    As String
   Dim i          As Integer
   
   sCamp = Split(sCampos, "|")
   sDato = Split(sDatos, "|")
   
   Set oTextIN = oFSO.OpenTextFile(sPlantilla)
   sTextIN = oTextIN.ReadAll
   sTextOUT = sTextIN
   
   If oFSO.FileExists(App.Path & "\HTML\Temp.html") Then
      oFSO.DeleteFile App.Path & "\HTML\Temp.html", True
   End If
   
   Set oTextOUT = oFSO.CreateTextFile(App.Path & "\HTML\Temp.html")
   
   For i = LBound(sCamp) To UBound(sCamp)
      
      sTextOUT = Replace(sTextOUT, "{" & sCamp(i) & "}", sDato(i))
      
   Next
   
   If sRutaImagen <> "" Then
      sTextOUT = Replace(sTextOUT, "{IMAGEN}", sRutaImagen)
   End If
   
   oTextOUT.Write sTextOUT
   
   Set oTextIN = Nothing
   Set oTextOUT = Nothing
   
   ShellEx App.Path & "\HTML\Temp.html"

   Exit Sub
   
Err_Trap:
   
   MsgBox Err.Description, vbCritical
   
End Sub

