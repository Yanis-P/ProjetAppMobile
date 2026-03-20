using Microsoft.AspNetCore.Mvc;

namespace API_Biblio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser/{pseudo}/{pass}")]
        public bool Get(string pseudo, string pass)
        {
            if (pseudo == "adam" && pass == "123")
            {
                return true;
            }
            return false;
        }

    }
}
