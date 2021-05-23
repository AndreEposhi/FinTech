using Microsoft.AspNetCore.Mvc;

namespace FinTech.TaxaJuros.Api.Controllers
{
    /// <summary>
    /// Controlador responsável pela taxa de juros
    /// </summary>
    [Route("api/taxaJuros")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        /// <summary>
        /// Obtem o valor da taxa de juros
        /// </summary>
        /// <returns></returns>
        [HttpGet("ObterTaxaDeJuros")]
        public ActionResult<double> ObterTaxaDeJuros()
            => new Domain.TaxaJuros().ObterTaxaDeJuros();
    }
}