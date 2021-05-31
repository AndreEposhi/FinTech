using FinTech.CalculaJuros.Api.Configurations;
using System.IO;
using System.Net;
using System.Text.Json;

namespace FinTech.CalculaJuros.Api.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly IAppSettings _appSettings;

        public TaxaJurosService(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public double ObterTaxaDeJuros()
        {
            var taxaJuros = 0d;
            var urlTaxaJurosApi = _appSettings.ObterUrlDaApiDaTaxaDeJuros();
            var request = WebRequest.CreateHttp($"{urlTaxaJurosApi}api/taxaJuros/ObterTaxaDeJuros");
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