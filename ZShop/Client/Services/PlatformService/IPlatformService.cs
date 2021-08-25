using System.Collections.Generic;
using System.Threading.Tasks;
using ZShop.Shared;

namespace ZShop.Client.Services.PlatformService
{
    public interface IPlatformService
    {
        List<Platform> Platforms { get; set; }

        Task LoadPlatforms();
    }
}
