using Devs2Blu.ProjetosAula.IntegrarAPI.Models;
using System;

namespace Devs2Blu.ProjetosAula.IntegrarAPI.Services
{
    public class FoodApi
    {
        private readonly HttpClient _httpClient;
        private const string URL_API_FOOD = "https://www.themealdb.com/api/json/v1/1/filter.php?c=Beef";
        private const string URL_API_FOOD_SEARCH = "https://www.themealdb.com/api/json/v1/1/search.php?s=";

        public FoodApi()
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

        public async Task<Food> GetFoodByName(string name)
        {
            var urlSearch = $"{URL_API_FOOD_SEARCH}{name}";
            return await Get<Food>(urlSearch);
            
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

