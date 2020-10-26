using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Utils.Security
{
	public static class Encrypt
	{
        public static void GuardarArchivoEncriptado(string pathArchivo, string usuario, string contrasenia)
        {
            if (File.Exists(pathArchivo))
                File.Delete(pathArchivo);

            var file = File.CreateText(pathArchivo);
            file.WriteLine(Misc.Encoding.Base64Encode(usuario));
            file.WriteLine(Misc.Encoding.Base64Encode(contrasenia));
            file.Close();
		}
	}
}
