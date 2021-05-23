namespace FinTech.CalculaJuros.Api.Services
{
    public interface ITaxaJurosService
    {
        /// <summary>
        /// Retorna a porcentagem de taxa de juros
        /// </summary>
        /// <returns></returns>
        double ObterTaxaDeJuros();
    }
}