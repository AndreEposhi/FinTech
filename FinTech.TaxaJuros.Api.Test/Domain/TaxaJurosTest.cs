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

        [Test]
        public void Nao_Deve_Obter_Taxa_De_Juros_Diferente_De_Um_Porcento()
        {
            var jurosEsperado = 0.02d;
            var jurosAtual = 0d;

            var juros = new Api.Domain.TaxaJuros();
            jurosAtual = juros.ObterTaxaDeJuros();

            Assert.AreNotEqual(jurosEsperado, jurosAtual);
        }
    }
}