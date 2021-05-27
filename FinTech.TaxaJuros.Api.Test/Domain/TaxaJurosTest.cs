using NUnit.Framework;

namespace FinTech.TaxaJuros.Api.Test.Domain
{
    [TestFixture]
    public class TaxaJurosTest
    {
        [Test]
        public void Deve_Obter_Taxa_De_Juros_De_Um_Porcento()
        {
            var jurosEsperado = 0.01d;
            var jurosAtual = 0d;

            var juros = new Api.Domain.TaxaJuros();
            jurosAtual = juros.ObterTaxaDeJuros();

            Assert.AreEqual(jurosEsperado, jurosAtual);
        }

        [TestCase(0.02d)]
        [TestCase(0.03d)]
        [TestCase(0.04d)]
        [TestCase(0.05d)]
        public void Nao_Deve_Obter_Taxa_De_Juros_Diferente_De_Um_Porcento(decimal jurosEsperado)
        {
            var jurosAtual = 0d;

            var juros = new Api.Domain.TaxaJuros();
            jurosAtual = juros.ObterTaxaDeJuros();

            Assert.AreNotEqual(jurosEsperado, jurosAtual);
        }
    }
}