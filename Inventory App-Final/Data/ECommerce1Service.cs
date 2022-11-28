using System.Net.Http.Json;

namespace Inventory_App_Final.ECommerce1
{
    public class ECommerce1Service
    {
        private readonly HttpClient http;

        public ECommerce1Service(HttpClient http)
        {
            this.http = http;
        }

        public async Task<RevenueType[]?> GetRevenue()
        {
            return await this.http.GetFromJsonAsync<RevenueType[]>("https://excel2json.io/api/share/03e74dde-d2e1-4fee-437d-08da496bf5f2");
        }
    }
}