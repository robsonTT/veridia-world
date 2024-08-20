using System.ComponentModel.DataAnnotations;
using VeridiaAPI.Core.Entities;

public class Raca
{
	[Key]
	public int RacasId { get; set; }
	public string Nome { get; set; }
	public string Descricao { get; set; }
	public int MundoID { get; set; }

}
