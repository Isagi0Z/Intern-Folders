using Microsoft.AspNetCore.Mvc;
using InsuranceAPI.Data;
using InsuranceAPI.Models;

namespace InsuranceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly InsuranceContext _context;

        public UsersController(InsuranceContext context)
        {
            _context = context;
        }

        // POST api/users
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
    }
}
