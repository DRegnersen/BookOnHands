using System.ComponentModel.DataAnnotations;

namespace BookOnHands.Controllers.Owners.Models;

public sealed class OwnerDto
{
    public int Id { get; set; }
    [Required] public required string FirstName { get; set; }
    public string? LastName { get; set; }
    [Required] public required string Address { get; set; }
    [Required] public required string Email { get; set; }
    public string? Phone { get; set; }
}