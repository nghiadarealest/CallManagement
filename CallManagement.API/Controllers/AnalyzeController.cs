using CallManagement.API.Models;
using CallManagement.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace CallManagement.API.Controllers
{
    [ApiController]
    [Route("api/analyze")]
    public class AnalyzeController : ControllerBase
    {
        private readonly IVoiceAnalyzer _analyzer;

        public AnalyzeController(IVoiceAnalyzer analyzer)
        {
            _analyzer = analyzer;
        }

        [HttpPost]
        public async Task<IActionResult> Analyze([FromForm] AnalyzeRequest request)
        {
            using var stream = request.Audio.OpenReadStream();
            var result = await _analyzer.AnalyzeAsync(stream);
            return Ok(new { text = result.Text, summary = result.Summary });
        }
    }
}
