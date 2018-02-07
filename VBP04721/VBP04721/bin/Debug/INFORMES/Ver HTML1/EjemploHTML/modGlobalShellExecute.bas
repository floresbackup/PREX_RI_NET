Attribute VB_Name = "modGlobalShellExecute"
Option Explicit

Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Private Declare Function ShellExecuteForExplore Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, lpParameters As Any, lpDirectory As Any, ByVal nShowCmd As Long) As Long
Public Enum EShellShowConstants
     essSW_HIDE = 0
     essSW_MAXIMIZE = 3
     essSW_MINIMIZE = 6
     essSW_SHOWMAXIMIZED = 3
     essSW_SHOWMINIMIZED = 2
     essSW_SHOWNORMAL = 1
     essSW_SHOWNOACTIVATE = 4
     essSW_SHOWNA = 8
     essSW_SHOWMINNOACTIVE = 7
     essSW_SHOWDEFAULT = 10
     essSW_RESTORE = 9
     essSW_SHOW = 5
End Enum
Private Const ERROR_FILE_NOT_FOUND = 2&
Private Const ERROR_PATH_NOT_FOUND = 3&
Private Const ERROR_BAD_FORMAT = 11&
Private Const SE_ERR_ACCESSDENIED = 5            '  access denied
Private Const SE_ERR_ASSOCINCOMPLETE = 27
Private Const SE_ERR_DDEBUSY = 30
Private Const SE_ERR_DDEFAIL = 29
Private Const SE_ERR_DDETIMEOUT = 28
Private Const SE_ERR_DLLNOTFOUND = 32
Private Const SE_ERR_FNF = 2                     '  file not found
Private Const SE_ERR_NOASSOC = 31
Private Const SE_ERR_PNF = 3                     '  path not found
Private Const SE_ERR_OOM = 8                     '  out of memory
Private Const SE_ERR_SHARE = 26

Public Function ShellEx( _
        ByVal sFile As String, _
        Optional ByVal eShowCmd As EShellShowConstants = essSW_SHOWDEFAULT, _
        Optional ByVal sParameters As String = "", _
        Optional ByVal sDefaultDir As String = "", _
        Optional sOperation As String = "open", _
        Optional Owner As Long = 0 _
    ) As Boolean
Dim lR As Long
Dim lErr As Long, sErr As String
    If (InStr(UCase$(sFile), ".EXE") <> 0) Then
        eShowCmd = 0
    End If
    On Error Resume Next
    If (sParameters = "") And (sDefaultDir = "") Then
        lR = ShellExecuteForExplore(Owner, sOperation, sFile, 0, 0, essSW_SHOWNORMAL)
    Else
        lR = ShellExecute(Owner, sOperation, sFile, sParameters, sDefaultDir, eShowCmd)
    End If
    If (lR < 0) Or (lR > 32) Then
        ShellEx = True
    Else
        ' raise an appropriate error:
        lErr = vbObjectError + 1048 + lR
        Select Case lR
        Case 0
            lErr = 7: sErr = "Sin memoria"
        Case ERROR_FILE_NOT_FOUND
            lErr = 53: sErr = "Archivo no encontrado"
        Case ERROR_PATH_NOT_FOUND
            lErr = 76: sErr = "Ruta de acceso no v�lida"
        Case ERROR_BAD_FORMAT
            sErr = "El archivo ejecutable no es v�lido o est� corrupto"
        Case SE_ERR_ACCESSDENIED
            lErr = 75: sErr = "Error de acceso a ruta o archivo"
        Case SE_ERR_ASSOCINCOMPLETE
            sErr = "Este tipo de archivo no tiene una asociaci�n definida"
        Case SE_ERR_DDEBUSY
            lErr = 285: sErr = "Imposible abrir la aplicaci�n en este momento. Int�ntelo m�s tarde."
        Case SE_ERR_DDEFAIL
            lErr = 285: sErr = "Error en el intercambio din�mico de datos. Int�ntelo m�s tarde."
        Case SE_ERR_DDETIMEOUT
            lErr = 286: sErr = "Tiempo de espera agotado. Int�ntelo m�s tarde."
        Case SE_ERR_DLLNOTFOUND
            lErr = 48: sErr = "Una de las librer�as de enlace din�mico no fue encontrada."
        Case SE_ERR_FNF
            lErr = 53: sErr = "Archivo no encontrado"
        Case SE_ERR_NOASSOC
            sErr = "Este tipo de archivo no tiene una asociaci�n definida"
        Case SE_ERR_OOM
            lErr = 7: sErr = "Sin memoria"
        Case SE_ERR_PNF
            lErr = 76: sErr = "Ruta de acceso no v�lida"
        Case SE_ERR_SHARE
            lErr = 75: sErr = "Error al compartir recursos"
        Case Else
            sErr = "Error inesperado"
        End Select
                
        Err.Raise lErr, App.EXEName & ".GShell", sErr
        ShellEx = False
    End If

End Function
