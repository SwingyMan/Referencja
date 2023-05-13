using BlazorApp2.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp2.Server.Controllers
{
    [Route("api")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMembersService _membersService;
        public MembersController(IMembersService membersService) {
            _membersService = membersService;
        }
        [HttpGet("/members")]
        public async Task<IActionResult> Show()
        {
            return Ok(await _membersService.Show());
        }
    }
}
