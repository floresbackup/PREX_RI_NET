Imports System.ComponentModel
Imports System.Windows.Forms
Imports ActiproSoftware.Products.SyntaxEditor
Imports ActiproSoftware.SyntaxEditor
Imports ActiproSoftware.WinUICore

Public Class frmBuscarReemplazar

    Private _options As FindReplaceOptions
    Private _syntaxEditor As SyntaxEditor

    Private sMsgNoMatch As String
    Private sMsgFinishFind As String
    Private sMsgFinishReplace As String
    Private sMsgFindCount As String
    Private sMsgReplaceCount As String

    Public Event StatusChanged As FindReplaceStatusChangeEventHandler

    Protected Overridable Sub OnStatusChanged(ByVal e As FindReplaceStatusChangeEventArgs)
        RaiseEvent StatusChanged(Me, e)
    End Sub    'OnStatusChanged 

    Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
        ' Call the base method
        MyBase.OnVisibleChanged(e)

        If (Me.Visible) Then
            ' Update options
            Me.UpdateUIFromFindReplaceOptions()
        End If
    End Sub    'OnVisibleChanged

    Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
        ' Raise an event
        Me.OnStatusChanged(New FindReplaceStatusChangeEventArgs(FindReplaceStatusChangeType.Ready, Options))

        ' Call the base method
        MyBase.OnClosing(e)

        ' Cancel the close and hide the form instead (for reuse)
        e.Cancel = True
        If Not (Me.Owner Is Nothing) Then
            Me.Owner.Activate()
        End If
        Me.Hide()
    End Sub    'OnClosing

    Public Sub New(ByVal syntaxEditor As SyntaxEditor, ByVal options As FindReplaceOptions)
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        ' Ensure there are options
        If options Is Nothing Then
            Throw New ArgumentNullException("options")
        End If

        ' Initalize parameters
        Me._syntaxEditor = syntaxEditor
        Me._options = options

        ' Load text from resources
        LocalizarFormulario()

        ' Update options
        UpdateUIFromFindReplaceOptions()
    End Sub 'New

    Private Sub UpdateUIFromFindReplaceOptions()
        txtBuscar.Text = Options.FindText
        txtReemplazar.Text = Options.ReplaceText
        chkMayusculas.Checked = Options.MatchCase
        chkPalabraCompleta.Checked = Options.MatchWholeWord
        chkSoloSeleccion.Checked = Options.SearchInSelection
    End Sub    'UpdateUIFromFindReplaceOptions

    Private Sub UpdateFindReplaceOptionsFromUI()
        Options.FindText = txtBuscar.Text
        Options.ReplaceText = txtReemplazar.Text
        Options.MatchCase = chkMayusculas.Checked
        Options.MatchWholeWord = chkPalabraCompleta.Checked
        Options.SearchInSelection = chkSoloSeleccion.Checked
    End Sub    'UpdateFindReplaceOptionsFromUI

    Public Property Options() As FindReplaceOptions
        Get
            Return _options
        End Get
        Set(ByVal value As FindReplaceOptions)
            If value Is Nothing Then
                Throw New ArgumentNullException("Options")
            End If
            _options = value

            Me.UpdateUIFromFindReplaceOptions()
        End Set
    End Property

    Public Property SyntaxEditor() As SyntaxEditor
        Get
            Return _syntaxEditor
        End Get
        Set(ByVal value As SyntaxEditor)
            _syntaxEditor = value
        End Set
    End Property

    Private Sub LocalizarFormulario()

        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionBuscarReemplazar)

        lblBuscar.Text = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_Buscar)
        lblReemplazar.Text = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_ReemplazarCon)
        chkMayusculas.Text = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_Mayusculas)
        chkPalabraCompleta.Text = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_PalabraCompleta)
        chkSoloSeleccion.Text = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_SoloSeleccion)
        cmdBuscarSiguiente.Text = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_BuscarSiguiente)
        cmdReemplazar.Text = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_Reemplazar)
        cmdReemplazarTodo.Text = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_ReemplazarTodo)
        cmdMarcarTodo.Text = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_MarcarTodo)
        cmdCerrar.Text = DescripcionCadena(Cadenas.CDN_GeneralCerrar)

        sMsgNoMatch = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_sMsgNoMatch)
        sMsgFinishFind = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_sMsgFinishFind)
        sMsgFinishReplace = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_sMsgFinishReplace)
        sMsgFindCount = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_sMsgFindCount)
        sMsgReplaceCount = DescripcionCadena(Cadenas.CDN_frmBuscarReemplazar_sMsgReplaceCount)


    End Sub


    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub


    Private Sub cmdBuscarSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarSiguiente.Click
        Me.UpdateFindReplaceOptionsFromUI()

        If SyntaxEditor Is Nothing Then
            Return
        End If
        ' Raise an event
        Me.OnStatusChanged(New FindReplaceStatusChangeEventArgs(FindReplaceStatusChangeType.Find, Options))

        ' Perform a find operation
        Dim resultSet As FindReplaceResultSet

        On Error Resume Next
        resultSet = SyntaxEditor.SelectedView.FindReplace.Find(Options)

        ' Set the status
        If resultSet.PastDocumentEnd Then
            ' Raise an event
            Me.OnStatusChanged(New FindReplaceStatusChangeEventArgs(FindReplaceStatusChangeType.PastDocumentEnd, Options))
        End If

        ' Find if the search went past the starting point
        If resultSet.PastSearchStartOffset Then
            MensajeInformacion(sMsgFinishFind)
            Return
        End If

        ' If no matches were found...			
        If resultSet.Count = 0 Then
            MensajeInformacion(sMsgNoMatch)
        End If

    End Sub

    Private Sub cmdReemplazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReemplazar.Click
        ' Update find/replace options
        Me.UpdateFindReplaceOptionsFromUI()

        If SyntaxEditor Is Nothing Then
            Return
        End If
        ' Raise an event
        Me.OnStatusChanged(New FindReplaceStatusChangeEventArgs(FindReplaceStatusChangeType.Replace, Options))

        ' Perform a find operation
        Dim resultSet As FindReplaceResultSet
        On Error Resume Next
        resultSet = SyntaxEditor.SelectedView.FindReplace.Replace(Options)

        ' Set the status
        If resultSet.PastDocumentEnd Then
            ' Raise an event
            Me.OnStatusChanged(New FindReplaceStatusChangeEventArgs(FindReplaceStatusChangeType.PastDocumentEnd, Options))
        End If

        ' If no matches were found...			
        If resultSet.Count = 0 Then
            If resultSet.PastDocumentEnd AndAlso resultSet.ReplaceOccurred Then
                MensajeInformacion(sMsgFinishReplace)
            Else
                MensajeInformacion(sMsgNoMatch)
            End If
        End If

    End Sub

    Private Sub cmdReemplazarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReemplazarTodo.Click
        ' Update find/replace options
        Me.UpdateFindReplaceOptionsFromUI()

        If SyntaxEditor Is Nothing Then
            Return
        End If
        ' Perform a mark all operation
        Dim resultSet As FindReplaceResultSet
        On Error Resume Next
        resultSet = SyntaxEditor.SelectedView.FindReplace.ReplaceAll(Options)

        ' If no matches were found...
        If resultSet.Count = 0 Then
            MensajeInformacion(sMsgNoMatch)
            Return
        End If

        ' Display the number of replacements
        MensajeInformacion(sMsgReplaceCount.Replace("|n|", resultSet.Count.ToString))

    End Sub

    Private Sub cmdMarcarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMarcarTodo.Click
        ' Update find/replace options
        Me.UpdateFindReplaceOptionsFromUI()

        If SyntaxEditor Is Nothing Then
            Return
        End If
        ' Perform a mark all operation
        Dim resultSet As FindReplaceResultSet
        On Error Resume Next
        resultSet = SyntaxEditor.SelectedView.FindReplace.MarkAll(Options)

        ' If no matches were found
        If resultSet.Count = 0 Then
            MensajeInformacion(sMsgNoMatch)
        End If

    End Sub

    Public Sub SoloBuscar()
        lblReemplazar.Visible = False
        txtReemplazar.Visible = False
        cmdReemplazar.Visible = False
        cmdReemplazarTodo.Visible = False
    End Sub


End Class