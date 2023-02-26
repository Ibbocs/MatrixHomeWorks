using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectAndOptionPatter.AutoFac
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageSenderController : ControllerBase
    {
        private IMessageService message;
        public MessageSenderController(IMessageService _message) 
        { 
            message= _message;
        }

        [HttpGet]
        //public IActionResult Get() { }
        public string Get()
        {
           return message.SendMessage("Hello");
        }
    }
}
