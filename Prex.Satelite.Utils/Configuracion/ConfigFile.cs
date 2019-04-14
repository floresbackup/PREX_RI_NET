using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Satelite.Utils
{
    public static class ConfigFile
    {
        public static void GuardarConfiguracion(string ConfigFilePath, object ConfiguracionProceso)
        {

            if (System.IO.File.Exists(ConfigFilePath))
                System.IO.File.Delete(ConfigFilePath);

            var objWriter = new System.IO.StreamWriter(ConfigFilePath);

            objWriter.Write(Newtonsoft.Json.JsonConvert.SerializeObject(ConfiguracionProceso));

            objWriter.Close();
        }

        public static Configuracion GetConfiguracion(string ConfigFilePath)
        {
            if (!System.IO.File.Exists(ConfigFilePath)) return null;

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Configuracion>(System.IO.File.ReadAllText(ConfigFilePath));
        }
    }
}
