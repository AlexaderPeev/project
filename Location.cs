using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
