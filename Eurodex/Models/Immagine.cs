using System;
namespace Eurodex.Models
{
	public class Immagine
	{
		private int Id { get; set; }
        private int StatoId { get; set; }
        private byte[] Foto { get; set; }

        private Immagine(int id, int statoId, byte[] foto)
		{
			Id = id;
			StatoId = statoId;
			Foto = foto;
		}
	}
}

