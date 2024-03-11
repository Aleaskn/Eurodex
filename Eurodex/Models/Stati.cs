using System;

namespace Eurodex.Models
{
	public class Stati
	{
		private int Id { get; set; }
        private string Nome { get; set; }
        private string Capitale { get; set; }
        private int Popolazione { get; set; }
        private string Valuta { get; set; }
        private string Lingua { get; set; }

		public Stati(int id, string nome, string capitale, int popolazione, string valuta, string lingua)
		{
			Id = id;
			Nome = nome;
			Capitale = capitale;
			Popolazione = popolazione;
			Valuta = valuta;
			Lingua = lingua;
		}


	}
}

