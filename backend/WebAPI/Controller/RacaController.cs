using Microsoft.AspNetCore.Mvc;
using VeridiaAPI.Application.Services;

namespace VeridiaAPI.WebAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class RacaController : ControllerBase
	{
		private readonly RacaService _racaService;

		public RacaController(RacaService racaService)
		{
			_racaService = racaService;
		}

		[HttpGet]
		public async Task<IActionResult> GetRacas()
		{
			var racas = await _racaService.GetRacasAsync();
			return Ok(racas);
		}
	}
}
