using Microsoft.AspNetCore.Mvc;

namespace API_Biblio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategorieController : ControllerBase
    {
        private readonly ILogger<CategorieController> _logger;

        public CategorieController(ILogger<CategorieController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCategorie")]
        public List<Categorie> Get()
        {
            List<Categorie> categories = new List<Categorie>();

            categories.Add(new Categorie(1, "Romans", 20, "test", "roman.png"));
            categories.Add(new Categorie(2, "Sciences", 15, "test1", "science.png"));
            categories.Add(new Categorie(3, "Histoire", 12, "test2", "paff.png"));
            categories.Add(new Categorie(4, "Jeunesse", 25, "test3", "paff.png"));
            categories.Add(new Categorie(5, "Biographie", 10, "test4", "paff.png"));

            return categories;
        }
    }
}
