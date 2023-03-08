using Microsoft.AspNetCore.Mvc;

namespace Identity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public string Hello() => "Hello , Welcome to User Api";
    }
}
