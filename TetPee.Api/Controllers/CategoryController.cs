using Microsoft.AspNetCore.Mvc;
using TetPee.Repository;
using TetPee.Repository.Entity;
using TetPee.service.User;

namespace TetPee.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly AppDbContext _dbContext;
    //cái này nâng cao lúc sau sẽ giải thích
    public CategoryController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
   
    [HttpGet(template:"")]
    public IActionResult GetUsers([FromQuery] string? searchTerm)
    {
        var users = _dbContext.Users.ToList();
        return Ok(users);
    }
    
    [HttpGet(template:"{id}")]
    public IActionResult GetUsersByid(Guid id)
    {
        // var users = _dbContext.Users.ToList();
        return Ok("Get all users");
    }
    
    [HttpPost(template:"")]
    public IActionResult CreateUsers([FromBody] Request.CreateUserRequest request)
    {
        // var users = _dbContext.Users.ToList();
        var user = new User()
        {
            Email = request.Email,
            FirstName = request.Firstname,
            LastName = request.Lastname,
            HashedPassword = request.Password //chuaw hash, chir demo
        };
        
        _dbContext.Users.Add(user);
        
        _dbContext.SaveChanges();
        
        Console.WriteLine(request);
        return Ok("Get all users");
    }
    
    [HttpPut(template:"{id}")]
    public IActionResult UpdateUser(Guid id,  [FromBody] Request.UpdateUserRequest request)
    {
        // var users = _dbContext.Users.ToList();
        return Ok("Create user");
    }
    
    [HttpDelete(template:"{id}")]
    public IActionResult DeleteUser(Guid id)
    {
        // var users = _dbContext.Users.ToList();
        return Ok("Delete user");
    }
}