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
        decimal valorASerCalculado = 100m;
        int meses = 5;
        double valorDoMontanteEsperado = 105.10d;
        double taxaJuros = 0.01d;

        [Test]
        public void Deve_Calcular_Juros_Composto_Sobre_Cem_Reais_Em_Cinco_Meses_Com_Um_Porcento()
        {
            var calculaJuros = new Api.Domain.CalculaJuros(_taxaJurosService);
            var valorDoMontante = calculaJuros.CalcularJurosComposto(valorASerCalculado, meses);

            Assert.AreEqual(valorDoMontanteEsperado, valorDoMontante);
        }

        [Test]
        public void Nao_Deve_Calcular_Juros_Composto_Quando_Valor_A_Ser_Calculado_Eh_Invalido() 
        {
            valorASerCalculado = 0m;

            var calculaJuros = new Api.Domain.CalculaJuros(_taxaJurosService);

            Assert.Throws<ArgumentException>(() => calculaJuros.CalcularJurosComposto(valorASerCalculado, meses));
        }

        [Test]
        public void Nao_Deve_Calcular_Juros_Composto_Quando_Quantidade_De_Meses_Eh_Invalido()
        {
            meses = 0;

            var calculaJuros = new Api.Domain.CalculaJuros(_taxaJurosService);

            Assert.Throws<ArgumentException>(() => calculaJuros.CalcularJurosComposto(valorASerCalculado, meses));
        }

        [SetUp]
        public void Setup()
        {
            _taxaJurosService = Substitute.For<ITaxaJurosService>();
            _taxaJurosService.ObterTaxaDeJuros().Returns(taxaJuros);
        }
    }
}