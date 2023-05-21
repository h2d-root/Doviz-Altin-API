using Source;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DovisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DovizController : ControllerBase
    {
        [HttpGet("ABD Dolar")]
        public IActionResult Dolar()
        {
            var doviz = Hurriyet.Doviz;
            return Ok($"{doviz[0]} - {doviz[1]}");
        }

        [HttpGet("Euro")]
        public IActionResult Euro()
        {
            var doviz = Hurriyet.Doviz;
            return Ok($"{doviz[2]} - {doviz[3]}");
        }

        [HttpGet("İngiliz Sterlin")]
        public IActionResult IngilizSterlin()
        {
            var doviz = Hurriyet.Doviz;
            return Ok($"{doviz[4]} - {doviz[5]}");
        }
        
    }
}
