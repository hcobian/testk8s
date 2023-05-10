using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Testk8sDeployment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private IConfiguration configuration;
        public TestController(IConfiguration configuration)
        {
            this.configuration = configuration; 
        }
        // GET: api/<TestController>
        [HttpGet]
        public IActionResult Get()
        {

            return new OkObjectResult(
                new {
                    ASPNETCORE_ENVIRONMENT = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"),
                    ENV_VAR_1 = Environment.GetEnvironmentVariable("ENV_VAR_1"),
                    ENV_VAR_2 = Environment.GetEnvironmentVariable("ENV_VAR_2"),
                    ENV_SECRET_1 = Environment.GetEnvironmentVariable("ENV_SECRET_1"),
                    ENV_SECRET_2 = Environment.GetEnvironmentVariable("ENV_SECRET_2"),
                    ConnectionStrings__postgres = configuration["ConnectionStrings:postgres"],
                });
        }
    }
}

