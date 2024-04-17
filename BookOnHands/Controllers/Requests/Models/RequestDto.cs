namespace BookOnHands.Controllers.Requests.Models;

public sealed class RequestDto
{
    public int Id { get; set; }
    public int RequesterId { get; set; }
    public int OwnerId { get; set; }
    public int BookId { get; set; }
}