using Microsoft.AspNetCore.Mvc;

namespace API_Biblio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivresController : ControllerBase
    {
        private readonly ILogger<LivresController> _logger;

        public LivresController(ILogger<LivresController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetLivres")]
        public IEnumerable<Livre> Get()
        {
            Livre[] livres =
            {
                new Livre(1, "livre1", "desc1", 1),
                new Livre(2, "livre2", "desc2", 1),
                new Livre(3, "livre3", "desc3", 2),
                new Livre(4, "livre4", "desc4", 3),
                new Livre(5, "livre5", "desc5", 4),
                new Livre(6, "livre6", "desc6", 4),

            };

            return livres;
        }
    }
}
