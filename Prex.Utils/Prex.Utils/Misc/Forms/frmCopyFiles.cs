using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prex.Utils.Misc.Forms
{
	public partial class FrmCopyFiles : Form
	{
		string _txtArchivo = "Copiando archivo [fileName]";
		string _txtProgreso = "Copiados [porcProgeso] archivos desde servidor. Aguarde un instante por favor...";
		string _pathDestino;
		public string PathDestino {
			get => _pathDestino;
			set => _pathDestino = (value.EndsWith("\\") ? value : value + "\\") + "LIB";
		}

		public FrmCopyFiles()
		{
			InitializeComponent();
		}



		private void SetProgreso(string fileName, string porcProgreso)
		{
            if (this == null) return;
            lblArchivo.Text = _txtArchivo.Replace("[fileName]", fileName);
			lblProgreso.Text = _txtProgreso.Replace("[porcProgeso]", porcProgreso);
			lblArchivo.Refresh();
			lblProgreso.Refresh();
			this.Refresh();
            Application.DoEvents();
		}

		private void FrmCopyFiles_Load(object sender, System.EventArgs e)
		{

		
		}

		public void CopiarDlls()
		{
			try
			{


				if (!System.IO.Directory.Exists(PathDestino)) System.IO.Directory.CreateDirectory(PathDestino);
				var directoryFiles = System.IO.Directory.GetFiles(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "*.dll", System.IO.SearchOption.TopDirectoryOnly);

				var files = directoryFiles.ToList().Where(f => f.ToLower().Contains("devexpress"));

				SetProgreso("...", $"0/{files.Count()}");

					try
					{

						//Thread.Sleep(new TimeSpan(0, 0, 0, 5));


						var i = 0;
						foreach (var item in files)
						{
							if (item.ToLower().Contains("devexpress"))
							{
								i++;
								Invoke((Action)delegate
								{
									SetProgreso(Path.GetFileName(item), $"{i}/{files.Count()}");
								});
								if (!File.Exists($"{PathDestino}\\{Path.GetFileName(item)}"))
								{
									Thread.Sleep(new TimeSpan(0, 0, 0, 0, 100));

									File.Copy(item, $"{PathDestino}\\{Path.GetFileName(item)}");
								}
							}
						}

					}
					catch (Exception ex)
					{
						ManejarErrores.TratarError(ex, "ValidarYCopiarPathDll");
					}

				Close();

			}
			catch (Exception ex)
			{

				throw new Exception("Ocurrió un error en CopiarDlls", ex);
			}
		}
	}
}
