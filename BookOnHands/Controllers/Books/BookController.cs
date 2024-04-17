using BookOnHands.Controllers.Books.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookOnHands.Controllers.Books;

[ApiController]
[Route("api/[controller]")]
public sealed class BookController : ControllerBase
{
    private readonly IBookService _bookService;
    
    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetAllAsync()
    {
        var result = await _bookService.GetAllAsync();
        return result.IsFail ? StatusCode(result.Error.Code, result.Error.Message) : Ok(result.Value);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BookDto>> GetAsync(int id)
    {
        var result = await _bookService.GetAsync(id);
        return result.IsFail ? StatusCode(result.Error.Code, result.Error.Message) : Ok(result.Value);
    }

    [HttpPost("add")]
    public async Task<ActionResult<BookDto>> CreateAsync(CreateBookDto request)
    {
        var result = await _bookService.CreateAsync(request);
        return result.IsFail ? StatusCode(result.Error.Code, result.Error.Message) : Ok(result.Value);
    }

    [HttpDelete("{id:int}/remove")]
    public async Task<ActionResult<BookDto>> RemoveAsync(int id)
    {
        var result = await _bookService.RemoveAsync(id);
        return result.IsFail ? StatusCode(result.Error.Code, result.Error.Message) : Ok(result.Value);
    }
}