namespace VeridiaAPI.Core.Interfaces
{
	public interface IRacaRepository
	{
		// Método para obter todas as raças
		Task<IEnumerable<Raca>> GetRacasAsync();
	}
}
