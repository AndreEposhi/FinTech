namespace FinTech.CalculaJuros.Api.Domain
{
    public interface ICode
    {
        /// <summary>
        /// Retorna o link do github contendo o repositório do código fonte do projeto
        /// </summary>
        /// <returns></returns>
        string RetornarLinkDoGitHubDoCodigoFonte();
    }
}