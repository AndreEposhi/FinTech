using FinTech.CalculaJuros.Api.Configurations;
using NSubstitute;
using NUnit.Framework;

namespace FinTech.CalculaJuros.Api.Test.Domain
{
    [TestFixture]
    public class CodeTest
    {
        private IAppSettings _appSettings;

        [TestCase("https://github.com/AndreEposhi/FinTech")]
        public void Deve_Retornar_Link_Do_Github_Do_Codigo_Fonte(string resultadoEsperado)
        {
            var code = new Api.Domain.Code(_appSettings);
            var resultadoAtual = code.RetornarLinkDoGitHubDoCodigoFonte();

            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [SetUp]
        public void Setup()
        {
            _appSettings = Substitute.For<IAppSettings>();
            _appSettings.ObterLinkDoGithubDoCodigoFonte().Returns("https://github.com/AndreEposhi/FinTech");
        }
    }
}