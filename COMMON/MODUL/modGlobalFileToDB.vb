Imports System.IO

Module modFileToDB
    Private Const nBUFFER As Long = 1024


    Public Function PutFileInField(documentPath As String) As String
        Dim data As Byte()
        data = System.IO.File.ReadAllBytes(documentPath)
        Dim s = Convert.ToChar(data).ToString()
        Return s ' System.Text.Encoding.Unicode.GetString(data)
    End Function

    '//LARGE IMAGES
    '    Public Sub PutFileInField(
    '       f As ADODB.Field,
    '       File As String
    '    )
    '        Dim b() As Byte
    '        Dim ff As Long
    '        Dim i As Long
    '        Dim FileLen As Long
    '        Dim Blocks As Long
    '        Dim LeftOver As Long

    '        On Error GoTo ErrHandler
    '        ff = FreeFile
    '        Open File For Binary Access Read As ff

    '    FileLen = LOF(ff)
    '        Blocks = Int(FileLen / nBUFFER)
    '        LeftOver = FileLen Mod nBUFFER

    '        ReDim b(LeftOver)
    '    Get ff, , b()
    '    f.AppendChunk b()

    '    ReDim b(nBUFFER)
    '        For i = 1 To Blocks
    '        Get ff, , b()
    '        f.AppendChunk b()
    '    Next
    '        Close ff
    '    Exit Sub

    'ErrHandler:
    '        MsgBox "ERROR: " & Err.Description
    'End Sub

    Public Function GetFileFromField(f As Byte(),
            ByVal sFileName As String) As String
        Try

            System.IO.File.WriteAllBytes(sFileName, f)
            Return sFileName
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    '    Public Function RecordLocation(
    '    adoRs As ADODB.Recordset,
    '    Optional Title As String = vbNullString
    '    )
    '        On Error GoTo ErrHandler
    '        With adoRs
    '            If Not (.EOF Or .BOF) Then
    '                RecordLocation = Title & .AbsolutePosition & " of " & .RecordCount
    '            Else
    '                RecordLocation = vbNullString
    '            End If
    '        End With
    '        Exit Function

    'ErrHandler:
    '        RecordLocation = "VOID"
    '    End Function

    Private Sub GetFileName(ByRef File As String, ByVal nID As Long, ByVal sExtension As String)

        If Dir(Environment.CurrentDirectory & "\Temp\", vbDirectory) = "" Then
            MkDir(Environment.CurrentDirectory & "\Temp\")
        End If

        File = Environment.CurrentDirectory & "\Temp\INFORME_" & nID & "." & sExtension

    End Sub



    '    Sub AddFile(f As Field, ByVal FileName As String)
    '        Dim stm As ADODB.Stream

    'Set stm = New ADODB.Stream
    'With stm
    '            .Type = adTypeBinary
    '            .Open
    '            .LoadFromFile FileName

    ' 'Insert the binary object into the table.
    '            f.Value = .Read
    '            .Close

    '        End With
    'Set stm = Nothing

    'End Sub

End Module