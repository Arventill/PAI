using PAIMVC.Enums;
using TaskStatus = System.Threading.Tasks.TaskStatus;

namespace PAIMVC.Models.Requests
{
    public class TaskGetDataRequest
    {
        public string? TaskName { get; set; }

        public TaskStatus? Status { get; set; }

        public TaskType? Type { get; set; }
    }
}
