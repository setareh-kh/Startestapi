using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class userController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
    {
        "Love", "My", "Master", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    }
}