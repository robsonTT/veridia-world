using VeridiaAPI.Core.Entities;
using VeridiaAPI.Core.Interfaces;

namespace VeridiaAPI.Application.Services
{
	public class MundoService
	{
		private readonly IMundoRepository _mundoRepository;

		public MundoService(IMundoRepository mundoRepository)
		{
			_mundoRepository = mundoRepository;
		}

		public async Task<IEnumerable<Mundo>> GetMundosAsync()
		{
			return await _mundoRepository.GetMundosAsync();
		}
	}
}
