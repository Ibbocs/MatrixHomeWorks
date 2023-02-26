using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectAndOptionPatter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetController : ControllerBase
    {
        private IGreetingService greetingService;

        public GreetController(IGreetingService _greetingService)
        {
            greetingService = _greetingService;
        }

        [HttpGet]
        public string GreeClient([FromQuery] string name)
        {
            return greetingService.Greet(name);
        }
    }
}
