using BookOnHands.Controllers.Books.Models;

namespace BookOnHands.Controllers.Books;

public interface IBookService
{
    Task<Result<IEnumerable<BookDto>, Error>> GetAllAsync();
    Task<Result<BookDto, Error>> GetAsync(int id);
    Task<Result<BookDto, Error>> CreateAsync(CreateBookDto createDto);
    Task<Result<BookDto, Error>> RemoveAsync(int id);
}