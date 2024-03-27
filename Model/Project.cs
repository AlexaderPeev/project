using Microsoft.AspNetCore.Identity;

namespace Project.Models
{
    public class CustomUser : IdentityUser
    {
        public string Role { get; set; }
    }
}
