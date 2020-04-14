using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Satelite.Utils
{
	public enum ModoDestino
	{
		SQL = 1,
		TXT = 2
	}

    public class Configuracion
    {
        public string Servidor         { get; set; }
        public string DB               { get; set; }
        public string Usuario          { get; set; }
        public string Pass             { get; set; }
        public string PathBCP          { get; set; }
        public string PathFMT          { get; set; }
        public string DecimalSeparator { get; set; }
        public string PrefijoTabla     { get; set; }

		public string PrefijoArchivo   { get; set; }
		public string PathDestino      { get; set; }
		public ModoDestino ModoDestino { get; set; }
    }
}
