using Core.Contract;
using Core.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
        public CustomerController(ICustomerRepositoryAsync customerRepositoryAsync)
        {
            _customerRepositoryAsync = customerRepositoryAsync;
        }
        [HttpGet]
        public async Task<IActionResult> AddCustomer(Customer obj)
        {
            try
            {
                var result = await _customerRepositoryAsync.Insert(obj);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
