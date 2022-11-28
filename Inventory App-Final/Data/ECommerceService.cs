using System.Net.Http.Json;

namespace Inventory_App_Final.ECommerce
{
    public class ECommerceService
    {
        private readonly HttpClient http;

        public ECommerceService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<SalesType[]?> GetSales()
        {
            return await this.http.GetFromJsonAsync<SalesType[]>("https://excel2json.io/api/share/f9942c71-b172-4060-4381-08da496bf5f2");
        }
    }
}