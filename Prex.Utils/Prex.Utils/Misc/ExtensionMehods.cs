using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Prex.Utils
{
	public static class ExtensionMehods
    {

        public static object ValueOrDbNull(this object o) => o ?? DBNull.Value;

        public static string ToStringOrEmpty(this string text) => text ?? string.Empty;
		public static string ToStringOrEmpty(this object obj) => obj == null ? string.Empty : obj.ToString();

		public static bool IsNullOrEmpty(this object o)
        {
            if (o == null) return true;
            if ((o is string || o is String) && !o.ToString().Trim().Any()) return true;

            return false;
        }
        public static bool IsNullOrEmpty(this string o)
        {
            if (o == null || !o.Trim().Any()) return true;
			
			return false;
		}


		public static Dictionary<string, int> GetAllNames(this IDataRecord record)
		{
			var result = new Dictionary<string, int>();
			for (int i = 0; i < record.FieldCount; i++)
			{
				result.Add(record.GetName(i), i);
			}
			return result;
		}

		public static bool ContainsField(this IDataRecord record, string name)
		{
			return record.GetAllNames().ContainsKey(name);
		}
	}
}
