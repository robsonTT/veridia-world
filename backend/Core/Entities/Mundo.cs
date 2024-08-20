using System.ComponentModel.DataAnnotations;

namespace VeridiaAPI.Core.Entities
{
	public class Mundo
	{
		[Key]
		public int MundoId { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public DateTime DataCriacao { get; set; }
		public string Criadores { get; set; }

	}

}

