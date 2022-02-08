using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        private readonly ILogger<HomeAgainController> logger;

        public HomeAgainController(ILogger<HomeAgainController> logger)
        {
            this.logger = logger;
        }
        
        public IActionResult Index()
        {
            try
            {
                this.logger.LogTrace("traceee {username}", "john");
                this.logger.LogInformation("INfo {bobbob1}", "yes");
                throw new Exception("Poopies");
                return View("Index");
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Something!", null);
                throw;
            }
        }
    }
}