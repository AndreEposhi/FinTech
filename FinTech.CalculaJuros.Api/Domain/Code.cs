using System.Threading.Tasks;

namespace FinTech.CalculaJuros.Api.Domain
{
    public class Code
    {
        const string LINK_GITHUB_CODIGOFONTE = "https://github.com/AndreEposhi/FinTech";

        public string RetornarLinkDoGitHubDoCodigoFonte()
            => LINK_GITHUB_CODIGOFONTE;
    }
}