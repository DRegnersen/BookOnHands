using System.ComponentModel.DataAnnotations;

namespace BookOnHands.Controllers.Books.Models;

public sealed class BookDto
{
    public int Id { get; set; }
    [Required] public required string Name { get; set; }
    public string? Author { get; set; }
    public string? ThumbnailUrl { get; set; }
    [Required] public required string Description { get; set; }
}