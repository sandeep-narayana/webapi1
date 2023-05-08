using Microsoft.AspNetCore.Mvc;

namespace webapi1.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    private readonly ILogger<UserController > _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }
}