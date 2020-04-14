using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Prex.Utils.Misc
{


	public static class Functions
	{
		public static string ValidarYCopiarPathDll(string pathDest, AssemblyName[] arrReferencedAssmbNames)
		{
			var frm = new Forms.FrmCopyFiles();
			frm.PathDestino = pathDest;
			frm.Show();
			frm.CopiarDlls();
			return frm.PathDestino; // LeerDllDevExpress(frm.PathDestino, arrReferencedAssmbNames) ;
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



	}
}
