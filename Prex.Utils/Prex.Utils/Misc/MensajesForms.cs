using System.Windows.Forms;

namespace Prex.Utils
{
    public static class MensajesForms
    {

        public static DialogResult MostrarPregunta(string mensaje) =>  MessageBox.Show(mensaje, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        public static void MostrarInformacion(string mensaje) => MessageBox.Show(mensaje, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void MostrarError(string mensaje) => MessageBox.Show(mensaje, "Mensaje del sistema - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        

    }
}
