using Microsoft.EntityFrameworkCore;
using VeridiaAPI.Core.Interfaces;

namespace VeridiaAPI.Infrastructure.Repositories
{
	public class RacaRepository : IRacaRepository
	{
		private readonly VeridiaContext _context;

		public RacaRepository(VeridiaContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Raca>> GetRacasAsync()
		{
			return await _context.Raca.ToListAsync();
		}
	}
}
