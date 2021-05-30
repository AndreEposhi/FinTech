using FinTech.CalculaJuros.Api.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FinTech.CalculaJuros.Api.Controllers
{
    /// <summary>
    /// Controlador responsável por calcular os juros compostos
    /// </summary>
    [EnableCors()]
    [Route("api/calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public CalculaJurosController(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        /// <summary>
        /// Calcula os juros compostos com base no valor inicial e quantidade de meses
        /// </summary>
        /// <param name="valorASerCalculado">Valor inicial a ser a calculado</param>
        /// <param name="meses">Quantidade de meses</param>
        /// <returns></returns>
        [HttpGet("CalcularJuros")]
        public ActionResult<double> CalcularJuros(decimal valorASerCalculado, int meses)
            => new Domain.CalculaJuros(_taxaJurosService).CalcularJurosComposto(valorASerCalculado, meses);
    }
}