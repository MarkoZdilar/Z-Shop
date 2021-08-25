using Blazored.LocalStorage;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZShop.Client.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _http;

        public StatsService(HttpClient http, ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
            _http = http;        }
        public async Task GetVisits()
        {
            int visits = int.Parse(await _http.GetStringAsync("api/Stats"));
            Console.WriteLine($"Visits: {visits}");
        }

        public async Task IncrementVisits()
        {
            DateTime? lastVisit = await _localStorage.GetItemAsync<DateTime?>("lastVisit");
            if (lastVisit == null || ((DateTime)lastVisit).Date != DateTime.Now.Date)
            {
                await _localStorage.SetItemAsync("lastVisit", DateTime.Now);
                await _http.PostAsync("api/Stats", null);
            }
        }
    }
}
