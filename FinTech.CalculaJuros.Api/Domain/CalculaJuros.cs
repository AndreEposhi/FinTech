using FinTech.CalculaJuros.Api.Services;
using System;

namespace FinTech.CalculaJuros.Api.Domain
{
    public class CalculaJuros
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public CalculaJuros(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        public double CalcularJurosComposto(decimal valorASerCalculado, int meses)
        {
            if (valorASerCalculado <= 0)
                throw new ArgumentException("Valor a ser calculado deve ser maior do que zero.");

            if (meses <= 0)
                throw new ArgumentException("Quantidade de meses deve ser maior do que zero.");

            var taxaJuros = _taxaJurosService.ObterTaxaDeJuros();
            return Math.Round(Convert.ToDouble(valorASerCalculado) * Math.Pow(taxaJuros + 1, Convert.ToDouble(meses)), 2);
        }
    }
}