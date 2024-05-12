using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public int LocationId { get; set; }
        public Location Location { get; set; }

        [Required(ErrorMessage = "Deadline is required")]
        public DateTime Deadline { get; set; }

        [Required(ErrorMessage = "Budget is required")]
        public decimal Budget { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; } 

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; } 

        public string ClientId { get; set; }
        public User Client { get; set; }

        public string AssignedToId { get; set; }
        public User AssignedTo { get; set; }

        public DateTime? ReviewDate { get; set; }
        public string ReviewImage { get; set; }
    }
}
