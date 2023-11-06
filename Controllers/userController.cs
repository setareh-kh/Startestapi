using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class userController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
    {
        "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    }
}