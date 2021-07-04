namespace PowerfullyPunchyPayPacketApp.Controllers
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using PowerfullyPunchyPayPacketApp.Models;

    public class PostRequest
    {
        public async Task<SalaryItems> CreateProductAsync(SalaryItems salary, HttpClient client)
        {
            Console.WriteLine("Please wait... Calculating...");

            HttpResponseMessage response = await client.PostAsJsonAsync("/api/SalaryItems", salary);
            response.EnsureSuccessStatusCode();

            if(response.IsSuccessStatusCode)
            {
                salary = await response.Content.ReadAsAsync<SalaryItems>();
            }

            // Returns our response
            return salary;
        }
    }
}
