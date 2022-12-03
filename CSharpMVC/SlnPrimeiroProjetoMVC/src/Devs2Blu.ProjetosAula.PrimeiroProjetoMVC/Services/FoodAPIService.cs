using Devs2Blu.ProjetosAula.IntegrarAPI.Models;
using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using System.Net.Http.Headers;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Services
{
    public class FoodAPIService
    {
        private readonly HttpClient _httpClient;
        private const string URL_API_FOOD = "https://www.themealdb.com/api/json/v1/1/filter.php?c=Beef";


        public FoodAPIService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Food> GetFoods()
        {
            return await Get<Food>(URL_API_FOOD);
        }

        public async Task<T> Get<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return (T)(object)url;

            return await listHttp.Content.ReadFromJsonAsync<T>();

        }

        public async Task<List<T>> GetList<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return new List<T>();

            return await listHttp.Content.ReadFromJsonAsync<List<T>>();

        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            var getRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };
            return await _httpClient.SendAsync(getRequest);
        }
    }
}
