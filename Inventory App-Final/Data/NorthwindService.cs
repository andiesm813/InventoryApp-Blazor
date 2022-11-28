using System.Net.Http.Json;

namespace Inventory_App_Final.Northwind
{
    public class NorthwindService
    {
        private readonly HttpClient http;

        public NorthwindService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<OrdersType[]?> GetOrders()
        {
            return await http.GetFromJsonAsync<OrdersType[]>("/static-data/northwind-orders.json");
        }
    }
}