using Source;
using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DovisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AltinController : ControllerBase
    {
        [HttpGet("Ceyrek Altin")]
        public IActionResult Ceyrek()
        {
            var altin = Hurriyet.Altin();
            return Ok($"{altin[2]} - {altin[3]}");
            
        }
        [HttpGet("Gram Altin")]
        public IActionResult GramGet()
        {
            var altin = Hurriyet.Altin();
            return Ok($"{altin[0]} - {altin[1]}");
        }
    }
}
