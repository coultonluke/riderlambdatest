using Microsoft.AspNetCore.Mvc;

namespace riderlambdatest.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok();
        } 
    }

    [Route("/[controller]")]
    public class HomeAgainController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        } 
    }
}