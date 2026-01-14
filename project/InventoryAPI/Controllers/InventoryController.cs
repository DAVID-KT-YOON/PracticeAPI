using InventoryAPI.helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        RabbitMqQueue queue;
        public InventoryController()
        {
            queue = new RabbitMqQueue();
        }
        [HttpGet]
        public IActionResult GetMessage()
        {
            queue.ReadMessage();
            return Ok();
        }
  
    }
}
