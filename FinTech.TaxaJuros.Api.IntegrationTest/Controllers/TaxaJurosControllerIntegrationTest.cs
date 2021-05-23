using FinTech.TaxaJuros.Api.IntegrationTest.Configuration;
using NUnit.Framework;

namespace FinTech.TaxaJuros.Api.IntegrationTest.Controllers
{
    [TestFixture]
    public class TaxaJurosControllerIntegrationTest
    {
        private BaseTestFixture _baseTestFixture;

        [SetUp]
        public void Setup()
        {
            _baseTestFixture = new BaseTestFixture();
        }

        [Test]
        public void ObterTaxaDeJuros_IntegrationTest()
        {
            var statusCodeEsperado = 200;
            var response = _baseTestFixture.Client.GetAsync("/api/taxaJuros/ObterTaxaDeJuros");

            Assert.AreEqual(statusCodeEsperado, (int)response.Result.StatusCode);
        }
    }
}