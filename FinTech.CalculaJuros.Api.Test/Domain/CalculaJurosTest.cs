using FinTech.CalculaJuros.Api.Services;
using NSubstitute;
using NUnit.Framework;
using System;

namespace FinTech.CalculaJuros.Api.Test.Domain
{
    [TestFixture]
    public class CalculaJurosTest
    {
        private ITaxaJurosService _taxaJurosService;

        [TestCase(100, 5, 105.10d)]
        [TestCase(200, 5, 210.20d)]
        [TestCase(300, 5, 315.30d)]
        public void Deve_Calcular_Juros_Composto(decimal valorASerCalculado, int meses, double valorDoMontanteEsperado)
        {
            var calculaJuros = new Api.Domain.CalculaJuros(_taxaJurosService);
            var valorDoMontante = calculaJuros.CalcularJurosComposto(valorASerCalculado, meses);

            Assert.AreEqual(valorDoMontanteEsperado, valorDoMontante);
        }

        [TestCase(0, 5)]
        public void Nao_Deve_Calcular_Juros_Composto_Quando_Valor_A_Ser_Calculado_Eh_Invalido(decimal valorASerCalculado, int meses)
        {
            var calculaJuros = new Api.Domain.CalculaJuros(_taxaJurosService);

            Assert.Throws<ArgumentException>(() => calculaJuros.CalcularJurosComposto(valorASerCalculado, meses));
        }

        [TestCase(100, 0)]
        public void Nao_Deve_Calcular_Juros_Composto_Quando_Quantidade_De_Meses_Eh_Invalido(decimal valorASerCalculado, int meses)
        {
            var calculaJuros = new Api.Domain.CalculaJuros(_taxaJurosService);

            Assert.Throws<ArgumentException>(() => calculaJuros.CalcularJurosComposto(valorASerCalculado, meses));
        }

        [SetUp]
        public void Setup()
        {
            _taxaJurosService = Substitute.For<ITaxaJurosService>();
            _taxaJurosService.ObterTaxaDeJuros().Returns(0.01d);
        }
    }
}