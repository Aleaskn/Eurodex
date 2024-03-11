using System;
namespace Eurodex.Models
{
	public class Economia
	{
		private int Id { get; set; }
        private int StatoId { get; set; }
        private double Disoccupazione { get; set; } // <p>Disoccupazione: @($"{economiaInstance.Disoccupazione:N1}%")</p> per vedere in percentuale
        private double Pil { get; set; }

        public Economia(int id, int statoId, double disoccupazione, double pil)
		{
			Id = id;
			StatoId = statoId;
			Disoccupazione = disoccupazione;
			Pil = pil;
		}
	}
}

