namespace Prex.Utils
{
	public enum TipoDatosDAO
	{
		FechaHora,
		Texto,
		Numerico
	}

    public enum EnumTablasGenerales
    { 
        //Sistema propio ******* Control de gestion
        TGL_Entidades                     = 1,
        TGL_Cuadros                       = 2,
        TGL_PARAMETROS_GENERALES          = 3,
        TGL_CODIGOS_CONSOLIDACION         = 4,
        TGL_CAMPO8                        = 5,
        TGL_ESTADOS_FINALES_CUP           = 6,
        TGL_PARAMETROS_AVISOS_CUP         = 7,
        TGL_RANGOS_PARTIDAS               = 8,
        TGL_AJUSTES_DIVERSOS              = 9,
        TGL_RUTAS                         = 10,
        TGL_RECEPTORES_CORREO_ELECTRONICO = 11,
        TGL_TITULOSCOLUMNAS               = 12,
        TGL_CG_TIPOS_INDICADORES          = 20,
        TGL_CG_TIPOS_TASAS                = 21,
        TGL_CG_TIPOS_INFORMACION          = 22,
        TGL_CG_CENTROS_COSTOS             = 23,
        TGL_CG_CUADROS_GESTION            = 24,
        TGL_CG_ENTIDADES_COMPARACION      = 25,
        TGL_RELACION_CUADROS_TABLAS       = 407,
        TGL_CODIGOS_NOTAS                 = 408,
        TGL_CODIGOS_NOTAS_2816            = 409,
        TGL_SECOEXPO_COD_BCRA             = 420,
        TGL_SECOEXPO_TIPOS_OPER           = 421,

        TGL_COD_CONCEP_IMPO               = 500,
        TGL_TIPOS_ESTADO                  = 501,
        TGL_TIPOS_CUMPLIMIENTO            = 502,
        TGL_TIPOS_ESTADO_SI_NO            = 503,
        //TGL_MONEDA_SIN_USO              = 504,

        TGL_ANALISISEXCEL                 = 600,

        TGL_CORRESPONDENCIA_SISCEN        = 1000,
        TGL_CODIGOS_PORTAFOLIOS           = 1001,
        TGL_TIPOS_ESPECIES                = 1002,
        TGL_ZONAS_ESPECIES                = 1003,
        TGL_COD_CON_2813_2816             = 1004,
        TGL_TIPOS_POSICION                = 1005,
        TGL_EXT_PLZ_POS_ARA_A3609         = 1401,
        TGL_EQUIVA_TABLAS                 = 1500,

        TGL_PROCESOS                      = 2500,
        TGL_TIPOS_ACCION_PROCESOS         = 2501,
        TGL_FUNCIONES_PROCESOS            = 2502,


        TGL_MONEDAS                       = 100,

        TGL_CATEGORIAS_CONVAR             = 300,
        TGL_ACCIONES_LOG                  = 301,

        TGL_EQUIVALENCIAS_TABLAS          = 1500

    }

    //Public Sub BuscadorTablaGeneral(ByVal sConnString As String,
    //                                ByVal sSQL As String,
    //                                ByVal oTextResult As TextBox,
    //                                Optional ByVal bMultiSelect As Boolean = True,
    //                                Optional ByVal nCodigoTabla As Double = 0,
    //                                Optional ByVal sDescripcionTabla As String = "",
    //                                Optional ByVal nRowHeight As Long = 0,
    //                                Optional ByVal bDescripcionItem As Boolean = False)
    //
    //    Load frmBuscadorTablaGeneral
    //   frmBuscadorTablaGeneral.PasarInfo oTextResult, bMultiSelect, sConnString, sSQL, nCodigoTabla, sDescripcionTabla, nRowHeight, bDescripcionItem
    //   frmBuscadorTablaGeneral.Show vbModal
    //
    //End Sub

}
