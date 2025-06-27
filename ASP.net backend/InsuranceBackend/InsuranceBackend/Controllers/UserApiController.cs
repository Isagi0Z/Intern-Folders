using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/user")]
public class UserApiController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register([FromBody] UserDto user)
    {
        return Ok($"✅ Registered: {user.Name}, {user.Email}");
    }
}

public class UserDto
{
    public string Name { get; set; }
    public string Email { get; set; }
}
