using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int LocationId { get; set; }
        public Location Location { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Budget { get; set; }

        [Required]
        public Category TaskCategory { get; set; }

        [Required]
        public Status TaskStatus { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string ClientId { get; set; }
        public CustomUser Client { get; set; }

        public string AssignedToId { get; set; }
        public CustomUser AssignedTo { get; set; }

        public DateTime? ReviewDate { get; set; }
        public string ReviewImage { get; set; }
    }

    public enum Status
    {
        Pending,
        Assigned,
        UnderReview,
        Completed,
        Rejected
    }

    public enum Category
    {
        CleaningDisinfection,
        PetPlantCare,
        ChildCare,
        ElderlyCare
    }
}
