using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requsts;

namespace MyRecipeBook.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register([FromBody] RequestRegisterUserAccountJson request)
    {
        return Created();
    }
}
