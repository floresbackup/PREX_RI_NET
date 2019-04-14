using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prex.Satelite.Utils
{
    public static class Extensions
    {
	    public static IList<Tipo> Clone<Tipo>(this IEnumerable<Tipo> list)
        {
            return list.ToList().Clone();
        }
        public static IList<Tipo> Clone<Tipo>(this IList<Tipo> list)
        {

            var NewList = new List<Tipo>();

            NewList.AddRange(list);
            return NewList;
        }

        public static IEnumerable<IEnumerable<TipoObjeto>> Partir<TipoObjeto>(this IEnumerable<TipoObjeto> Lista, int Cantidad)
        {

            var newList = new List<TipoObjeto>();
            //Dim newListaSpliteada As New List(Of IEnumerable(Of TipoObjeto))

            int Cnt = 1;

            foreach (var item in Lista)
            {
                newList.Add(item);
                Cnt++;
			    if (Cnt > Cantidad)
                {
                    yield return newList.Clone();

                    newList.Clear();
                    Cnt = 1;
                }

            }

            if (newList.Count() > 0) yield return newList.Clone();
		    //Return newListaSpliteada

        }
    }
}
