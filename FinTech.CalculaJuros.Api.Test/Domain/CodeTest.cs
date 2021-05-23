using NUnit.Framework;

namespace FinTech.CalculaJuros.Api.Test.Domain
{
    [TestFixture]
    public class CodeTest
    {
        [Test]
        public void Deve_Retornar_Link_Do_Github_Do_Codigo_Fonte()
        {
            var resultadoEsperado = "https://github.com/AndreEposhi/FinTech";
            var code = new Api.Domain.Code();
            var resultadoAtual = code.RetornarLinkDoGitHubDoCodigoFonte();

            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
    }
}