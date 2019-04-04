using Microsoft.AspNetCore.Mvc;
namespace ProtfolioControllers.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("home");
        }

        [HttpGet]
        [Route("projects")]
        public ViewResult Projects()
        {
            return View("projects");
        }

        [HttpGet]
        [Route("contact")]
        public ViewResult Contact()
        {
            return View("contact");
        }

    }

}