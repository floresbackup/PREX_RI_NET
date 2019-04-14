using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Satelite.Utils
{
    public class Configuracion
    {
        public string Servidor         { get; set; }
        public string DB               { get; set; }
        public string Usuario          { get; set; }
        public string Pass             { get; set; }
        public string PathBCP          { get; set; }
        public string PathFMT          { get; set; }
        public string DecimalSeparator { get; set; }
    }
}
