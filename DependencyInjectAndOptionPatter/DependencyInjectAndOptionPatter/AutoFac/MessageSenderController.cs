using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectAndOptionPatter.AutoFac
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageSenderController : ControllerBase
    {
        private IMessageService message;
        private GreetingService GreetingService;
        public MessageSenderController(IMessageService _message) 
        {
            message = _message;
            GreetingService = new GreetingService();
        }

        [HttpGet]
        //public IActionResult Get() { }
        public string Get()
        {
           return message.SendMessage("Hello");
        }
    }
}
