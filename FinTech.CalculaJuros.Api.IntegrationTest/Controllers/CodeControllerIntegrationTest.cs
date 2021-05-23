using FinTech.CalculaJuros.Api.IntegrationTest.Configuration;
using NUnit.Framework;

namespace FinTech.CalculaJuros.Api.IntegrationTest.Controllers
{
    [TestFixture]
    public class CodeControllerIntegrationTest
    {
        private BaseTestFixture _baseTestFixture;

        [Test]
        public void RetornarLinkDoGitHubDoCodigoFonte_IntegrationTest()
        {
            var statusCodeEsperado = 200;
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