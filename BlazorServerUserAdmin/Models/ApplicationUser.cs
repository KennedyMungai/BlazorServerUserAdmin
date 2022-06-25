using Microsoft.AspNetCore.Identity;

namespace BlazorServerUserAdmin.Models;

public class ApplicationUser : IdentityUser
{
    public string? Name { get; set; }
    public string? PayrollNumber { get; set; }
    public string? Region { get; set; }
    public string? Branch { get; set; }
    public DateTime CreatedDateAndTime { get; set; }
}