namespace PowerfullyPunchyPayPacketApp.Controllers
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;

    public class SetupNetworking
    {
        public HttpClient NetworkSetup(HttpClient client)
        {
            return PortAndURISetup(client);
        }
        private HttpClient PortAndURISetup(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:44375/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
