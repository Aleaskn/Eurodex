using System;
namespace Eurodex.Models
{
	public class Cultura
	{
		private int Id { get; set; }
        private int StatoId { get; set; }
        private string Tradizioni { get; set; }
        private string Eventi { get; set; }
        private string CibiTipici { get; set; }

        public Cultura(int id, int statoId, string tradizioni, string eventi, string cibiTipici)
		{
			Id = id;
			StatoId = statoId;
			Tradizioni = tradizioni;
			Eventi = eventi;
			CibiTipici = cibiTipici;
		}
	}
}

