using BookOnHands.Controllers.Owners.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookOnHands.Controllers.Owners;

[ApiController]
[Route("api/[controller]")]
public sealed class OwnerController : ControllerBase
{
    [HttpPost("login")]
    public ActionResult<OwnerDto> Login() => BadRequest();

    [HttpPost("signup")]
    public ActionResult<OwnerDto> Signup() => BadRequest();
    
    [HttpGet("all")]
    public ActionResult<IEnumerable<OwnerDto>> GetAll() => Unauthorized();

    [HttpPost("{id:int}/{bookId:int}/add")]
    public ActionResult<AddBookResponseDto> AddBook(int id, int bookId) => Unauthorized();
    
    [HttpDelete("{id:int}/{bookId:int}/remove")]
    public ActionResult<AddBookResponseDto> RemoveBook(int id, int bookId) => Unauthorized();
}