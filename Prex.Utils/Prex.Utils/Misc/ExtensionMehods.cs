using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Utils
{
	public  static class ExtensionMehods
	{

		public static object ValueOrDbNull(this object o) => o ?? DBNull.Value;

		public static object ToStringOrEmpty(this string text) => text ?? string.Empty;

		public static bool IsNullOrEmpty(this object o)
		{
			if (o == null) return true;
			if ((o is string || o is String) && !o.ToString().Trim().Any()) return true;

			return false;
		}
		public static bool IsNullOrEmpty(this string o)
		{
			if (o == null) return true;
			if ((o is string || o is String) && !o.ToString().Trim().Any()) return true;

			return false;
		}
	}
}
