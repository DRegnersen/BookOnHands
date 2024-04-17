using BookOnHands.Controllers.Requests.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookOnHands.Controllers.Requests;

[ApiController]
[Route("api/[controller]")]
public sealed class RequestController : ControllerBase
{
    [HttpGet("all")]
    public ActionResult<IEnumerable<RequestDto>> GetAll() => Unauthorized();
    
    [HttpGet("{id:int}")]
    public ActionResult<RequestDto> Get(int id) => Unauthorized();
    
    [HttpPost("{ownerId:int}/{bookId:int}")]
    public ActionResult<RequestDto> Create(int ownerId, int bookId) => Unauthorized();
    
    [HttpPost("{id:int}/confirm")]
    public ActionResult<RequestDto> Confirm(int id) => Unauthorized();
    
    [HttpDelete("{id:int}/revoke")]
    public ActionResult<RequestDto> Revoke(int id) => Unauthorized();
}