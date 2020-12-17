using System;
using System.ComponentModel.DataAnnotations;

namespace ProgramowanieAplikacjiInternetowych.Repository.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime CreateDate { get; set; }

        public Enums.TaskType Type { get; set; }

        public Enums.TaskStatus Status { get; set; }

        public User User { get; set; }
    }
}
