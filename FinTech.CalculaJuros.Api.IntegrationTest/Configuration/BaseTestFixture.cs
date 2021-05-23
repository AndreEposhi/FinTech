using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;

namespace FinTech.CalculaJuros.Api.IntegrationTest.Configuration
{
    public class BaseTestFixture : IDisposable
    {
        public readonly HttpClient Client;
        public readonly TestServer Server;

        public BaseTestFixture()
        {
            Server = new TestServer(WebHost.CreateDefaultBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        public void Dispose()
        {
            Server.Dispose();
            Client.Dispose();
        }
    }
}