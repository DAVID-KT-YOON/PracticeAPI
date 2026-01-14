using Core.Contract;
using Core.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Admin")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
        public CustomerController(ICustomerRepositoryAsync customerRepository)
        {
            _customerRepositoryAsync = customerRepository;
        }
        [HttpPost]
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
        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            return Ok(await _customerRepositoryAsync.GetAll());

        }
    }
}
