namespace Prex.Utils.Entities
{
	public class IdCodigoNombre
	{
		public int? Id { get; set; }
		public string Codigo { get; set; }
		public string Nombre { get; set; }

		public IdCodigoNombre()
		{ }

		public IdCodigoNombre(int? id, string codigo, string nombre): this()
		{
			Id = id;
			Nombre = nombre;
			Codigo = codigo;
		}
	}
}
