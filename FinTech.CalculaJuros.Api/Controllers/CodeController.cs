using FinTech.CalculaJuros.Api.Configurations;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FinTech.CalculaJuros.Api.Controllers
{
    /// <summary>
    /// Controlador responsável por demonstar o local onde está o código fonte do projeto no github
    /// </summary>
    [EnableCors()]
    [Route("api/showmethecode")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        private readonly IAppSettings _appSettings;

        public CodeController(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        /// <summary>
        /// Retorna o link do github contendo o repositório do código fonte do projeto
        /// </summary>
        /// <returns></returns>
        [HttpGet("RetornarLinkDoGitHubDoCodigoFonte")]
        public ActionResult<string> RetornarLinkDoGitHubDoCodigoFonte()
            => new Domain.Code(_appSettings).RetornarLinkDoGitHubDoCodigoFonte();
    }
}