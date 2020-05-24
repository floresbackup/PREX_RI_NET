using System.Data;

namespace Prex.Utils
{
	public class DirectivasSeguridad
	{
		public int Id { get; protected set; }
		public int DIAS_ANTES_RENOVACION  { get; protected set; }
		public int DIAS_VTO_PASSWORD      { get; protected set; }
		public int CANT_PASS_CONTROLADAS  { get; protected set; }
		public int INTENTOS_PARA_BLOQUEAR { get; protected set; }
		public int CANTIDAD_ALFA          { get; protected set; }
		public int CANTIDAD_NUM           { get; protected set; }
		public int CANTIDAD_ESP           { get; protected set; }
		public string Descripcion         { get; protected set; }

		public DirectivasSeguridad()
		{
			Descripcion            = "Directiva Default";
			DIAS_ANTES_RENOVACION  = 10;
			DIAS_VTO_PASSWORD      = 30;
			CANT_PASS_CONTROLADAS  = 3;
			INTENTOS_PARA_BLOQUEAR = 3;
			CANTIDAD_ALFA          = 4;
			CANTIDAD_NUM           = 2;
			CANTIDAD_ESP           = 0;
		}

		public DirectivasSeguridad(IDataRecord record): this()
		{
			Id                     = (int)record["DS_CODDIR"];
			Descripcion            = record["DS_DESCRI"].ToStringOrEmpty();
			DIAS_ANTES_RENOVACION  = (int)record["DS_DIASRE"];
			DIAS_VTO_PASSWORD      = (int)record["DS_DIASVT"];
			CANT_PASS_CONTROLADAS  = (int)record["DS_CANTPC"];
			INTENTOS_PARA_BLOQUEAR = (int)record["DS_INTBLO"];
			CANTIDAD_ALFA          = (int)record["DS_PASCAR"];
			CANTIDAD_NUM           = (int)record["DS_PASNUM"];
			CANTIDAD_ESP           = (int)record["DS_PASESP"];
		}

	}
}
