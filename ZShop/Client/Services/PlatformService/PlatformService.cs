using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ZShop.Shared;

namespace ZShop.Client.Services.PlatformService
{
    public class PlatformService : IPlatformService
    {
        private readonly HttpClient _http;

        public List<Platform> Platforms { get; set; } = new();

        public PlatformService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadPlatforms()
        {
            Platforms = await _http.GetFromJsonAsync<List<Platform>>("api/Platform");
        }
    }
}
