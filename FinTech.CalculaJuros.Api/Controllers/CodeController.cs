using Microsoft.AspNetCore.Mvc;

namespace FinTech.CalculaJuros.Api.Controllers
{
    [Route("api/showmethecode")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        [HttpGet("RetornarLinkDoGitHubDoCodigoFonte")]
        public ActionResult<string> RetornarLinkDoGitHubDoCodigoFonte()
            => new Domain.Code().RetornarLinkDoGitHubDoCodigoFonte();
    }
}