using System;
using System.IO;
using System.Linq;
using System.Threading;
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
			set => _pathDestino = (value.EndsWith("\\") ? value : value + "\\") + "Lib";
		}

		public FrmCopyFiles()
		{
			InitializeComponent();
		}



		private void SetProgreso(string fileName, string porcProgreso)
		{
			lblArchivo.Text = _txtArchivo.Replace("[fileName]", fileName);
			lblProgreso.Text = _txtProgreso.Replace("[porcProgeso]", porcProgreso);
			lblArchivo.Refresh();
			lblProgreso.Refresh();
			this.Refresh();
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

				var i = 0;
				foreach (var item in files)
				{
					if (item.ToLower().Contains("devexpress"))
					{
						i++;
						SetProgreso(Path.GetFileName(item), $"{i}/{files.Count()}");
						if (!File.Exists($"{PathDestino}\\{Path.GetFileName(item)}"))
						{
							Thread.Sleep(new TimeSpan(0, 0, 0, 0, 500));

							File.Copy(item, $"{PathDestino}\\{Path.GetFileName(item)}");
						}
					}
				}
				Close();
			}
			catch (Exception ex)
			{
				ManejarErrores.TratarError(ex, "ValidarYCopiarPathDll");
			}
		}
	}
}
