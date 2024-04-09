using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Administrator,
        Housekeeper,
        Client
    }
}

