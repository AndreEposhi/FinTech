namespace FinTech.TaxaJuros.Api.Domain
{
    public interface ITaxaJuros
    {
        /// <summary>
        /// Retorna a porcentagem de taxa de juros
        /// </summary>
        /// <returns></returns>
        double ObterTaxaDeJuros();
    }
}