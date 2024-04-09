using System;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public Location Location { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        [Required]
        public decimal Budget { get; set; }

        [Required]
        public TaskCategory Category { get; set; }

        public TaskStatus Status { get; set; }

        public User AssignedUser { get; set; }

        public DateTime? ReviewDate { get; set; }
    }

    public enum TaskStatus
    {
        Pending,
        Assigned,
        UnderReview,
        Completed,
        Rejected
    }

    public enum TaskCategory
    {
        CleaningAndDisinfection,
        PetAndPlantCare,
        ChildCare,
        ElderlyCare
    }
}
