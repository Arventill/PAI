using System;
using System.ComponentModel.DataAnnotations;

namespace PAIMVC.Models.Requests
{
    public class TaskRegisterRequest
    {
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public DateTime ExpirationDate { get; set; }

        public Enums.TaskType Type { get; set; }

        public Enums.TaskStatus Status { get; set; }

        public string UserHash { get; set; }

        public int Id { get; set; }
    }
}
