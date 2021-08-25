using System.Collections.Generic;
using System.Threading.Tasks;
using ZShop.Shared;

namespace ZShop.Server.Services.PlatformService
{
    public interface IPlatformService
    {
        Task<List<Platform>> GetPlatforms();
    }
}
