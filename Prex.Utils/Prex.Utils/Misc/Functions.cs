using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Prex.Utils.Misc
{


	public static class Functions
	{
		public static string ValidarYCopiarPathDll(string pathDest, AssemblyName[] arrReferencedAssmbNames) => ValidarYCopiarPathDll(pathDest, null, arrReferencedAssmbNames);
		public static string ValidarYCopiarPathDll(string pathDest, Form parent, AssemblyName[] arrReferencedAssmbNames)
		{
			try
			{

				var frm = new Forms.FrmCopyFiles();
				if (parent != null) frm.Parent = parent;

				frm.PathDestino = pathDest;
				if (Directory.Exists(frm.PathDestino)) return frm.PathDestino;
				if (parent != null) frm.Show(parent);
				else frm.Show();

				frm.CopiarDlls();
				return frm.PathDestino; // LeerDllDevExpress(frm.PathDestino, arrReferencedAssmbNames) ;

			}
			catch (Exception ex)
			{
				Prex.Utils.MensajesForms.MostrarAdvertencia("No pudo finalizar ValidarYCopiarPathDll se iniciará el sistema normalmente.");
				return string.Empty;
			}
		}


		public static string LeerDllDevExpress(string pathDll, AssemblyName[] arrReferencedAssmbNames)
		{
			var strTempAssmbPath = new Dictionary<string, string>();

			arrReferencedAssmbNames.ToList().ForEach(strAssmbName =>
			{
				if (strAssmbName.Name.ToLower().Contains("devexpress"))
					strTempAssmbPath.Add(strAssmbName.FullName, $"{pathDll}{Path.DirectorySeparatorChar}{strAssmbName.Name}.dll");
			});
			strTempAssmbPath.ToList().ForEach(ass => {
				if (File.Exists(ass.Value))
				{
					var asm = Assembly.LoadFrom(ass.Value);

				}
			});
			return pathDll;
		}


		public static Assembly LoadFromSameFolder(object sender, ResolveEventArgs args)
		{
			try
			{
				string folderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
				string assemblyPath;
				if (args.Name.ToLower().Contains("devexpress"))
					assemblyPath = Path.Combine(Path.Combine(Configuration.PrexConfig.CARPETA_LOCAL, "LIB"), new AssemblyName(args.Name).Name + ".dll");
				else
					assemblyPath = Path.Combine(folderPath, new AssemblyName(args.Name).Name + ".dll");

				if (!File.Exists(assemblyPath)) return null;

				var ass = Assembly.LoadFrom(assemblyPath);
				return ass;
			}
			catch (Exception ex)
			{
				return null;
			}

		}
	}
}
