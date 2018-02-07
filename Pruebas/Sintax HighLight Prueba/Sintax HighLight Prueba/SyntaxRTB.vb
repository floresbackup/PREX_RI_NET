Public Class SyntaxRTB
   Inherits System.Windows.Forms.RichTextBox

   Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
      (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, _
       ByVal lParam As Integer) As Integer
   Private Declare Function LockWindowUpdate Lib "user32" _
       (ByVal hWnd As Integer) As Integer

   Private _SyntaxHighlight_CaseSensitive As Boolean = False
   Friend Words As New DataTable

   'Contains Windows Messages for the SendMessage API call
   Private Enum EditMessages
      LineIndex = 187
      LineFromChar = 201
      GetFirstVisibleLine = 206
      CharFromPos = 215
      PosFromChar = 1062
   End Enum

   Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
      MyBase.OnTextChanged(e)
      ColorVisibleLines()
   End Sub

   Public Sub New()
      Me.AcceptsTab = True
      AddSQLSyntax()
   End Sub

   Function AddSQLSyntax()
      ClearSyntaxWords()
      AddSyntaxWord("\b(select|text|ntext|date|datetime|order by|" & _
          "group by|smalldatetime|cursor|on|as|for|filename|" & _
          "database|drop|function|delete|insert|update|int|" & _
          "varchar|nvarchar|bit|binary|table|inner|where|from|" & _
          "out|procedure|view|trigger|set)\b", Color.Blue)
      AddSyntaxWord("\b@@identity\b", Color.Pink)
      AddSyntaxWord("\b(in|join|outer|and|or)\b", Color.Gray)
      AddSyntaxWord("\bsp_refreshview\b", Color.Red)
      Return True
   End Function

   Public Function ClearSyntaxWords()
      Words = New DataTable
      ''Load all the keywords and the colors to make them 
      Words.Columns.Add("Word")
      Words.PrimaryKey = New DataColumn() {Words.Columns(0)}
      Words.Columns.Add("Color")
      Return True
   End Function

   Public Function AddSyntaxWord(ByVal strWord As String, ByVal clrColor As Color)
      Dim MyRow As DataRow
      MyRow = Words.NewRow()
      MyRow("Word") = strWord
      MyRow("Color") = clrColor.Name
      Words.Rows.Add(MyRow)
      Return True
   End Function

   Public Sub ColorRtb()
      Dim FirstVisibleChar As Integer
      Dim i As Integer = 0
      While i < Me.Lines.Length
         FirstVisibleChar = GetCharFromLineIndex(i)
         ColorLineNumber(i, FirstVisibleChar)
         i += 1
      End While
   End Sub

   Public Sub ColorVisibleLines()
      Dim FirstLine As Integer = FirstVisibleLine()
      Dim LastLine As Integer = LastVisibleLine()
      Dim FirstVisibleChar As Integer
      If (FirstLine = 0) And (LastLine = 0) Then
         'If there is no text it will error, so exit the sub
         Exit Sub
      Else
         While FirstLine < LastLine
            FirstVisibleChar = GetCharFromLineIndex(FirstLine)
            ColorLineNumber(FirstLine, FirstVisibleChar)
            FirstLine += 1
         End While
      End If
   End Sub

   Public Sub ColorLineNumber(ByVal LineIndex As Integer, ByVal lStart As Integer)
      Dim i As Integer = 0
      Dim SelectionAt As Integer = Me.SelectionStart
      Dim MyRow As DataRow
      Dim MyI As Integer

      ' Lock the update
      LockWindowUpdate(Me.Handle.ToInt32)

      MyI = lStart

      ''Turn the whole link black before applying RegEx Syntax matching.
      Me.SelectionStart = MyI
      Me.SelectionLength = Lines(LineIndex).Length
      Me.SelectionColor = Color.Black

      ''Check for matches in a particular line number
      Dim rm As System.Text.RegularExpressions.MatchCollection
      Dim m As System.Text.RegularExpressions.Match

      For Each MyRow In Words.Rows
         '"( |^)1.*2( |$)"
         rm = System.Text.RegularExpressions.Regex.Matches(Me.Text, MyRow("Word"))
         For Each m In rm
            Me.SelectionStart = m.Index
            Me.SelectionLength = m.Length
            Me.SelectionColor = Color.FromName(MyRow("color"))
         Next
      Next

      ' Restore the selectionstart
      Me.SelectionStart = SelectionAt
      Me.SelectionLength = 0
      Me.SelectionColor = Color.Black

      ' Unlock the update
      LockWindowUpdate(0)
   End Sub

   Public Function GetCharFromLineIndex(ByVal LineIndex As Integer) As Integer
      Return SendMessage(Me.Handle, EditMessages.LineIndex, LineIndex, 0)
   End Function

   Public Function FirstVisibleLine() As Integer
      Return SendMessage(Me.Handle, EditMessages.GetFirstVisibleLine, 0, 0)
   End Function

   Public Function LastVisibleLine() As Integer
      Dim LastLine As Integer = FirstVisibleLine() + (Me.Height / Me.Font.Height)

      If LastLine > Me.Lines.Length Or LastLine = 0 Then
         LastLine = Me.Lines.Length
      End If

      Return LastLine
   End Function

   Public Property CaseSensitive() As Boolean
      Get
         Return _SyntaxHighlight_CaseSensitive
      End Get
      Set(ByVal Value As Boolean)
         _SyntaxHighlight_CaseSensitive = Value
      End Set
   End Property

End Class


