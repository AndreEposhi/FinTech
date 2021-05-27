using Microsoft.Extensions.Configuration;

namespace FinTech.CalculaJuros.Api.Configurations
{
    public class AppSettings : IAppSettings
    {
        private readonly IConfiguration _configuration;

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ObterLinkDoGithubDoCodigoFonte()
            => _configuration["LinkGithubCodigofonte"];

        public string ObterUrlDaApiDaTaxaDeJuros()
            => _configuration["UrlTaxaJurosApi"];
    }
}