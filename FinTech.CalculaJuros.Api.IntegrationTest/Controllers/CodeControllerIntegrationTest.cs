using FinTech.CalculaJuros.Api.IntegrationTest.Configuration;
using NUnit.Framework;

namespace FinTech.CalculaJuros.Api.IntegrationTest.Controllers
{
    [TestFixture]
    public class CodeControllerIntegrationTest
    {
        private BaseTestFixture _baseTestFixture;

        [TestCase(200)]
        public void RetornarLinkDoGitHubDoCodigoFonte_IntegrationTest(int statusCodeEsperado)
        {
            var response = _baseTestFixture.Client.GetAsync("/api/showmethecode/RetornarLinkDoGitHubDoCodigoFonte");

            Assert.AreEqual(statusCodeEsperado, (int)response.Result.StatusCode);
        }

        [SetUp]
        public void Setup()
        {
            _baseTestFixture = new BaseTestFixture();
        }
    }
}