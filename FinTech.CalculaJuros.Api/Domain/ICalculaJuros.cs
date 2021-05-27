namespace FinTech.CalculaJuros.Api.Domain
{
    public interface ICalculaJuros
    {
        /// <summary>
        /// Calcula os juros compostos com base no valor inicial e quantidade de meses
        /// </summary>
        /// <param name="valorASerCalculado">Valor inicial a ser a calculado</param>
        /// <param name="meses">Quantidade de meses</param>
        /// <returns></returns>
        double CalcularJurosComposto(decimal valorASerCalculado, int meses);
    }
}