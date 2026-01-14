using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("http://localhost:8080/api/customer");

            if (result.IsSuccessStatusCode)
            {
                return Ok(result.Content);
            }
            else
            {
                return BadRequest(result.StatusCode);
            }
        }
    }
}
