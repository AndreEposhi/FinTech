using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net;
using System.Text.Json;

namespace FinTech.CalculaJuros.Api.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly IConfiguration _configuration;

        public TaxaJurosService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public double ObterTaxaDeJuros()
        {
            var taxaJuros = 0d;
            var request = WebRequest.CreateHttp($"{_configuration["UrlTaxaJurosApi"]}api/taxaJuros/ObterTaxaDeJuros");
            request.Method = "GET";

            using (var response = request.GetResponse())
            {
                var stream = response.GetResponseStream();
                var reader = new StreamReader(stream);
                object result = reader.ReadToEnd();
                taxaJuros = JsonSerializer.Deserialize<double>(result.ToString());
            }

            return taxaJuros;
        }
    }
}