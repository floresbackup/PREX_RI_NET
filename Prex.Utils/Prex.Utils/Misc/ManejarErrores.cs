using Prex.Utils.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Utils
{
    public static class ManejarErrores
    {
        public static void TratarError(Exception ex) => TratarError(ex, string.Empty);
        public static void TratarError(Exception ex, string funcion) => TratarError(ex, funcion, string.Empty, true, false);
        public static void TratarError(Exception ex, string funcion, string customError, bool guardaLog, bool getFullTextStack)
        {
            var frm = new frmError();
            frm.CargarFormulario(ex, funcion, customError, getFullTextStack);
            if (guardaLog)
                Log.GuardarLog(AccionesLOG.AL_ERROR_SISTEMA, 
                    frm.txtDescripcion.Text + Environment.NewLine + 
                    "Función/Proc.: " + funcion, 
                    Configuration.PrexConfig.CODIGO_TRANSACCION);


            frm.ShowDialog();
        }

    
    }
}
