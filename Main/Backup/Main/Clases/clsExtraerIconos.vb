Imports System.Runtime.InteropServices
Imports System.IO

Public Class ExtraerIconos

#Region " Declares: Extract_BEST "

   Private Structure SHFILEINFO
      Public hIcon As IntPtr          'Icon
      Public iIcon As Integer         'Icon Index
      Public dwAttributes As Integer  'Flags
      <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
          Public szDisplayName As String
      <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
          Public szTypeName As String
   End Structure

   Private Declare Auto Function SHGetFileInfo Lib "shell32.dll" ( _
       ByVal pszPath As String, _
       ByVal dwFileAttributes As Integer, _
       ByRef psfi As SHFILEINFO, _
       ByVal cbFileInfo As Integer, _
       ByVal uFlags As Integer) As IntPtr

   Private Const SHGFI_ICON = &H100
   Private Const SHGFI_SMALLICON = &H1   ' Small Icon
   Private Const SHGFI_LARGEICON = &H0   ' Large Icon

#End Region

#Region " Declares: Extract_DLL_EXE "

   Private Declare Auto Function ExtractIcon Lib "shell32.dll" ( _
       ByVal hIcon As IntPtr, _
       ByVal lpszExeFileName As String, _
       ByVal nIconIndex As Integer) As IntPtr

#End Region

#Region " REAL Extracting Code "
   'returns index of icon in imagelist, 
   'supports icons 16x16 & 32x32, depending on imagelist pic-size
   Public Function Extract(ByVal ImgList As ImageList, ByVal Path As String) As Long ', ByVal IconSize As IconSize
      Dim rImg As IntPtr
      Dim shInfo As New SHFILEINFO

      shInfo.szDisplayName = New String(Chr(0), 260) 'Setup Null Strings
      shInfo.szTypeName = New String(Chr(0), 80)

      Select Case ImgList.ImageSize.Width
         Case 16
            rImg = SHGetFileInfo(Path, 0, shInfo, Marshal.SizeOf(shInfo), SHGFI_ICON Or SHGFI_SMALLICON)
         Case 32
            rImg = SHGetFileInfo(Path, 0, shInfo, Marshal.SizeOf(shInfo), SHGFI_ICON Or SHGFI_LARGEICON)
      End Select

      'Get Icon And Add It To Small ImageList
      Dim eI As System.Drawing.Icon = System.Drawing.Icon.FromHandle(shInfo.hIcon)
      ImgList.Images.Add(eI)          'Add icon to imageList.

      Return ImgList.Images.Count - 1 'Return It's Index

   End Function

   'Extract Icons from DLL's Or EXE's
   Public Function Extract_DLL(ByVal ImgList As ImageList, Optional ByVal IconIdx As Integer = 0, Optional ByVal Path As String = "Shell32.dll") As Long

      Dim eIcon As IntPtr = ExtractIcon(IntPtr.Zero, Path, IconIdx)

      'Get Default(Ugly) Icon If Path Is Not Found
      If Dir(Path) = "" Then _
          If eIcon.ToInt32 <= 1 Then eIcon = ExtractIcon(IntPtr.Zero, "Shell32.dll", 0)

      'Get Icon And Add It To Small ImageList
      Try
         Dim eI As Icon = Icon.FromHandle(eIcon)
         ImgList.Images.Add(eI)
      Catch
         Return -1
         Exit Function
      End Try

      Return ImgList.Images.Count - 1 'Return It's Index

   End Function
#End Region

End Class
