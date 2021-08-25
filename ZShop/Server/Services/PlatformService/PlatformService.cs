using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZShop.Server.Data;
using ZShop.Shared;

namespace ZShop.Server.Services.PlatformService
{
    public class PlatformService : IPlatformService
    {
        private readonly DataContext _context;

        public PlatformService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Platform>> GetPlatforms()
        {
            return await _context.Platforms.ToListAsync();
        }
    }
}
