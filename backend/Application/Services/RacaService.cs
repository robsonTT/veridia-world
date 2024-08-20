using VeridiaAPI.Core.Interfaces;

namespace VeridiaAPI.Application.Services
{
	public class RacaService
	{
		private readonly IRacaRepository _racaRepository;

		public RacaService(IRacaRepository racaRepository)
		{
			_racaRepository = racaRepository;
		}

		public async Task<IEnumerable<Raca>> GetRacasAsync()
		{
			return await _racaRepository.GetRacasAsync();
		}

	}
}
