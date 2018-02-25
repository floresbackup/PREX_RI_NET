Imports System.IO
Imports WebSupergoo.ABCpdf7

Module modAbcPDF

   Public Sub ConvertirHTMLenPDF(ByVal sRutaHTML As String, ByVal sRutaPDF As String, Optional ByVal bVertical As Boolean = True)

      Dim oDoc As New Doc()
      Dim w, h, l, b As Long

      oDoc.Rect.Inset(0, -5)

      If Not bVertical Then

         w = oDoc.MediaBox.Width
         h = oDoc.MediaBox.Height
         l = oDoc.MediaBox.Left
         b = oDoc.MediaBox.Bottom
         oDoc.Transform.Rotate(90, l, b)
         oDoc.Transform.Translate(w, 0)
         oDoc.Rect.Width = h
         oDoc.Rect.Height = w

      End If

      oDoc.AddImageUrl("file:///" & sRutaHTML.Replace("\", "/"), False, 0, True)

      oDoc.Save(sRutaPDF)
      oDoc.Clear()
      oDoc = Nothing

   End Sub

   Public Sub ConvertirRTFenPDF(ByVal sRTF As String, ByVal sRutaPDF As String, Optional ByVal bVertical As Boolean = True)

      Dim oDoc As Object
      Dim oApp As Object
      Dim sArchivoRTF As String
      Dim bAbierto As Boolean

      Try

         oDoc = CreateObject("Word.Application")
         oApp = CreateObject("Word.Document")

         sArchivoRTF = CARPETA_LOCAL & "TEMP\" & Application.ProductName & ".RTF"

         If File.Exists(sArchivoRTF) Then
            File.Delete(sArchivoRTF)
         End If

         File.WriteAllText(sArchivoRTF, sRTF)

         oDoc = oApp.Documents.Open(sArchivoRTF)

         bAbierto = True

         With oApp.ActiveDocument.PageSetup
            .TopMargin = 50
            .LeftMargin = 50
            .RightMargin = 500
            .BottomMargin = 500
         End With

         oDoc.SaveAs(sArchivoRTF & ".HTML", 10)

         oDoc.Close(False)
         bAbierto = False

         ConvertirHTMLenPDF(sArchivoRTF & ".html", sRutaPDF, bVertical)

      Catch ex As Exception

         If bAbierto Then
            oDoc.Close(False)
         End If

         TratarError(ex, "ConvertirRTFenPDF")

      End Try

      oDoc = Nothing
      oApp = Nothing

   End Sub

End Module
