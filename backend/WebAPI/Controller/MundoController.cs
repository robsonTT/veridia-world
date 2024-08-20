using Microsoft.AspNetCore.Mvc;
using VeridiaAPI.Application.Services;
using VeridiaAPI.Core.Entities;

namespace VeridiaAPI.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MundoController : ControllerBase
	{
		private readonly MundoService _mundoService;

		public MundoController(MundoService mundoService)
		{
			_mundoService = mundoService;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Mundo>>> GetMundos()
		{
			var mundos = await _mundoService.GetMundosAsync();
			return Ok(mundos);
		}
	}
}
