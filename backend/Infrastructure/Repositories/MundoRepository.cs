using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VeridiaAPI.Core.Entities;
using VeridiaAPI.Core.Interfaces;

namespace VeridiaAPI.Infrastructure.Repositories
{
	public class MundoRepository : IMundoRepository
	{
		private readonly VeridiaContext _context;

		public MundoRepository(VeridiaContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Mundo>> GetMundosAsync()
		{
			return await _context.Mundo.ToListAsync();
		}

	}
}
