Public Class frmVariables 

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        VARIABLE_SELECCIONADA = ""
        LocalizarFormulario()
        CargarItems()

    End Sub

    Private Sub CargarItems()

        Dim itmX As ListViewItem

        itmX = New ListViewItem : itmX.Text = "|AYER|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Ayer)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|HOY|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Hoy)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|MES|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Mes)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|DIA|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Dia)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|INICIO_MES|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_InicioMes)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|ULTIMO_FIN_DE_MES|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_UltimoFinMes)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|USUARIO_WINDOWS|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_UsuarioWindows)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|TERMINAL|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Terminal)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|WINVER|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_VersionWindows)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|DIRECTORIO|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_DirectorioApp)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|USUARIO_ACTUAL|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_UsuarioActual)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM01|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro01)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM02|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro02)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM03|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro03)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM04|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro04)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM05|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro05)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM06|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro06)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM07|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro07)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM08|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro08)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM09|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro09)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM10|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro10)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM11|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro11)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM12|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro12)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM13|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro13)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM14|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro14)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM15|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro15)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM16|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro16)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM17|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro17)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM18|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro18)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM19|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro19)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM20|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro20)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM21|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro21)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM22|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro22)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM23|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro23)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM24|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro24)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM25|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro25)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM26|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro26)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM27|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro27)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM28|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro28)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM29|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro29)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM30|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro30)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM31|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro31)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM32|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro32)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM33|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro33)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM34|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro34)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM35|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro35)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM36|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro36)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM37|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro37)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM38|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro38)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM39|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro39)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM40|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro40)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM41|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro41)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM42|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro42)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM43|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro43)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM44|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro44)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM45|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro45)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM46|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro46)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM47|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro47)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM48|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro48)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM49|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro49)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM50|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro50)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM51|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro51)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM52|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro52)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM53|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro53)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM54|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro54)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM55|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro55)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM56|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro56)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM57|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro57)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM58|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro58)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM59|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro59)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM60|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro60)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM61|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro61)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM62|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro62)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM63|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro63)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM64|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro64)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM65|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro65)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM66|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro66)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM67|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro67)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM68|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro68)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM69|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro69)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM70|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro70)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM71|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro71)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM72|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro72)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM73|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro73)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM74|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro74)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM75|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro75)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM76|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro76)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM77|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro77)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM78|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro78)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM79|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro79)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM80|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro80)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM81|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro81)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM82|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro82)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM83|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro83)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM84|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro84)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM85|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro85)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM86|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro86)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM87|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro87)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM88|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro88)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM89|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro89)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM90|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro90)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM91|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro91)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM92|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro92)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM93|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro93)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM94|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro94)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM95|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro95)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM96|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro96)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM97|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro97)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM98|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro98)) : lvVariables.Items.Add(itmX)
        itmX = New ListViewItem : itmX.Text = "|PARAM99|" : itmX.ImageIndex = 0 : itmX.SubItems.Add(DescripcionCadena(Cadenas.CDN_frmVariable_Parametro99)) : lvVariables.Items.Add(itmX)


    End Sub

    Private Sub LocalizarFormulario()


        Me.Text = DescripcionCadena(Cadenas.CDN_WindowCaptionVariables)
        cmdAceptar.Text = DescripcionCadena(Cadenas.CDN_GeneralOK)
        cmdCancelar.Text = DescripcionCadena(Cadenas.CDN_GeneralCancelar)

        lvVariables.Columns(0).Text = DescripcionCadena(Cadenas.CDN_frmVariable_Variable)
        lvVariables.Columns(1).Text = DescripcionCadena(Cadenas.CDN_frmVariable_Descripcion)

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If lvVariables.SelectedItems.Count > 0 Then
            If Not lvVariables.FocusedItem Is Nothing Then
                VARIABLE_SELECCIONADA = lvVariables.FocusedItem.Text
                Me.Close()
            End If
        End If

    End Sub

    Private Sub lvVariables_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvVariables.DoubleClick
        cmdAceptar_Click(sender, e)
    End Sub
End Class