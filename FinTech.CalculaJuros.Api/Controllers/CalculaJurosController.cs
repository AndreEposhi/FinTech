using FinTech.CalculaJuros.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinTech.CalculaJuros.Api.Controllers
{
    [Route("api/calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public CalculaJurosController(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        [HttpGet("CalcularJuros")]
        public ActionResult<double> CalcularJuros(decimal valorASerCalculado, int meses)
            => new Domain.CalculaJuros(_taxaJurosService).CalcularJurosComposto(valorASerCalculado, meses);
    }
}