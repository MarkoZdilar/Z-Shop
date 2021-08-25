using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZShop.Server.Services.PlatformService;
using ZShop.Shared;

namespace ZShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformService _platformService;
        public PlatformController(IPlatformService platformService)
        {
            _platformService = platformService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Platform>>> GetPlatforms()
        {
            return Ok(await _platformService.GetPlatforms());
        }
    }
}
