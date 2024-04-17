using System.ComponentModel.DataAnnotations;

namespace BookOnHands.Controllers.Owners.Models;

public sealed class CreateOwnerDto
{
    [Required] public required string FirstName { get; set; }
    public string? LastName { get; set; }
    [Required] public required string Address { get; set; }
    [Required] public required string Email { get; set; }
    public string? Phone { get; set; }
}