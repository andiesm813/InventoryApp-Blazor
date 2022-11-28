using System.Net.Http.Json;

namespace Inventory_App_Final.InventoryApp
{
    public class InventoryAppService
    {
        private readonly HttpClient http;

        public InventoryAppService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<NewProductsType[]?> GetNewProducts()
        {
            return await this.http.GetFromJsonAsync<NewProductsType[]>("https://excel2json.io/api/share/4b54e7f8-927a-4a38-e690-08dab79fa5b4");
        }

        public async Task<ProductsType[]?> GetProducts()
        {
            return await this.http.GetFromJsonAsync<ProductsType[]>("https://excel2json.io/api/share/22b3aaa8-bba3-43cb-e68f-08dab79fa5b4");
        }
    }
}