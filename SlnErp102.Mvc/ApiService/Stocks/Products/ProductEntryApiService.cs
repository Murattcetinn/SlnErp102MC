using Newtonsoft.Json;
using SlnErp102.Api.DTOs.Stocks.Products;

namespace SlnErp102.Mvc.ApiService.Stocks.Products
{
    public class ProductEntryApiService
    {
        private readonly HttpClient _httpClient;

        public ProductEntryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;  
        }
        public async Task<IEnumerable<ProductEntryDistinctDto>?> GetAllAsync()
        {
            IEnumerable<ProductEntryDistinctDto>? pEntryDtos;
            var response= await _httpClient.GetAsync("ProductEntries");
            //http://localhost:44333/api/productentry
            if (response.IsSuccessStatusCode)
            {
                pEntryDtos = JsonConvert.DeserializeObject<IEnumerable<ProductEntryDistinctDto>>(await response.Content.ReadAsStringAsync());

            }
            else
            {
                pEntryDtos = null;
               
            }
            return pEntryDtos;
        }
        public async Task<IEnumerable<ProductEntryDto>?> GetProEntryByIvnoAsync(string ivno)
        {
            IEnumerable<ProductEntryDto>? pEntryDtos;
            var response =await _httpClient.GetAsync($"ProductEntries/a/{ivno}");
            if (response.IsSuccessStatusCode)
            {
                pEntryDtos = JsonConvert.DeserializeObject<IEnumerable<ProductEntryDto>>(await response.Content.ReadAsStringAsync());

            }
            else
            {
                pEntryDtos = null;

            }
            return pEntryDtos;
        }
    }
}
