using VeridiaAPI.Core.Entities;

namespace VeridiaAPI.Core.Interfaces
{
	public interface IMundoRepository
	{
		Task<IEnumerable<Mundo>> GetMundosAsync();
	}
}
