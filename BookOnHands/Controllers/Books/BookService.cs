using BookOnHands.Controllers.Books.Models;

namespace BookOnHands.Controllers.Books;

public sealed class BookService : IBookService
{
    private static Error DefaultError => new(500, "Something went wrong");
    
    public async Task<Result<IEnumerable<BookDto>, Error>> GetAllAsync()
    {
        return await Task.FromResult(new Result<IEnumerable<BookDto>, Error>(DefaultError));
    }

    public async Task<Result<BookDto, Error>> GetAsync(int id)
    {
        return await Task.FromResult(new Result<BookDto, Error>(DefaultError));
    }

    public async Task<Result<BookDto, Error>> CreateAsync(CreateBookDto createDto)
    {
        return await Task.FromResult(new Result<BookDto, Error>(DefaultError));
    }

    public async Task<Result<BookDto, Error>> RemoveAsync(int id)
    {
        return await Task.FromResult(new Result<BookDto, Error>(DefaultError));
    }
}