using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Utils.Entities
{
	public class clsItem
	{
		public object Valor { get; set; }
		public string Nombre { get; set; }
		public string Periodo { get; set; }
		public bool Format { get; set; }
		public string Tag { get; set; }


		public clsItem(object valor, string nombre)
		{
			Valor = valor;
			Nombre = nombre;
		}

		public clsItem(object valor, string nombre, string periodo, string tag) : this(valor, nombre)
		{
			Periodo = periodo;
			Tag = tag;
		}

		public clsItem(object valor, string nombre, bool format) : this(valor, nombre)
		{
			Format = format;
		}

		public override string ToString()
		{
			if (Format && DateTime.TryParse(Valor.ToString(), out DateTime d)) return d.ToString("dd/MM/yyyy");
			return Nombre;
		}
	}
}
