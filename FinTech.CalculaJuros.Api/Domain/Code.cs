using FinTech.CalculaJuros.Api.Configurations;

namespace FinTech.CalculaJuros.Api.Domain
{
    public class Code : ICode
    {
        private readonly IAppSettings _appSettings;

        public Code(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public string RetornarLinkDoGitHubDoCodigoFonte()
            => _appSettings.ObterLinkDoGithubDoCodigoFonte();
    }
}