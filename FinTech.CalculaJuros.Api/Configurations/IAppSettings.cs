namespace FinTech.CalculaJuros.Api.Configurations
{
    public interface IAppSettings
    {
        /// <summary>
        /// Obtem o endereço do link do github onde está alocado o código do projeto
        /// </summary>
        /// <returns></returns>
        string ObterLinkDoGithubDoCodigoFonte();

        /// <summary>
        /// Obtem a url para acessar a api de taxa de juros
        /// </summary>
        /// <returns></returns>
        string ObterUrlDaApiDaTaxaDeJuros();
    }
}