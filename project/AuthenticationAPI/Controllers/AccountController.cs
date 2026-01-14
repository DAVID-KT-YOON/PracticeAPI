using JWTAuthenticationManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JWTTokenHandler _jwtTokenHandler;
        public AccountController(JWTTokenHandler jWTTokenHandler)
        {
            _jwtTokenHandler = jWTTokenHandler;
            
        }
        [HttpPost]
        public ActionResult<AuthenticationResponse> Login(AuthenticationRequest request)
        {
            var authResponse = _jwtTokenHandler.GenerateToken(request);
            if (authResponse == null) { return Unauthorized(); }
            return authResponse;
        }
    }
}
