using Microsoft.AspNetCore.Mvc;

namespace API_Biblio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogInController : ControllerBase
    {
        private readonly ILogger<LogInController> _logger;

        public LogInController(ILogger<LogInController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser/{pseudo}/{pass}")]
        public bool Get(string pseudo, string pass)
        {
            if (pseudo == "user1" && pass == "123")
            {
                return true;
            }
            return false;
        }

    }
}
