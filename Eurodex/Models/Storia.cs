using System;
namespace Eurodex.Models
{
	public class Storia
	{
		private int Id { get; set; }
		private int StatoId { get; set; }
		private DateTime DateImp { get; set; }
        private string EventiStorici { get; set; }

        public Storia(int id, int statoId, DateTime dateImp, string eventiStorici)
		{
			Id = id;
			StatoId = statoId;
			DateImp = dateImp;
			EventiStorici = eventiStorici;
		}
	}
}

