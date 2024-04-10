using inventBackend.Data;
using inventBackend.Models;
using Microsoft.AspNetCore.Mvc;


using Microsoft.AspNetCore.Mvc;

using inventBackend.Data;
using inventBackend.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;


[ApiController]
[Route("api/[controller]")]
public class ProfileController : ControllerBase
{

    private readonly ApplicationDbContext _context;

    public ProfileController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost("Insert")]

    public IActionResult InsertProfile([FromBody] ProfileType profile)
    {
        // Create a new User entity
        var existingEmployee = _context.User.FirstOrDefault(u => u.UserId == profile.Id);
        if (existingEmployee != null)
        {
            return Ok("Employee with the same ID already exists.");
        }

        try
        {
            // Create a new User entity
            var user = new User
            {
                Fname = profile.GivenName,
                Lname = profile.Surname,
                Email = profile.UserPrincipalName,
                UserId = profile.Id,
                Position = profile.jobTitle,

            };


            _context.User.Add(user);
            _context.SaveChanges();

            return Ok(user);

        }
        catch (Exception ex)
        {

            return BadRequest($"pls save me: {ex.InnerException?.Message}");
        }
    }


}
public class ProfileType
{
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public string UserPrincipalName { get; set; }
    public string Id { get; set; }

    public string jobTitle { get; set; }


}