using Microsoft.AspNetCore.Mvc;
using Summit.API.Handlers;
using Summit.API.Models;
using System.Threading.Tasks;

namespace Summit.API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IRegistrationHandler _registrationHandler;
        
        public UsersController(IRegistrationHandler registrationHandler)
        {
            _registrationHandler = registrationHandler;
        }

        // POST api/users
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegistrationRequest registrationRequest)
        {
            return await _registrationHandler.Handle(registrationRequest);
        }

    }
}
