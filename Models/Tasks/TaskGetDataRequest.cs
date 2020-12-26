using ProgramowanieAplikacjiInternetowych.Enums;
using TaskStatus = System.Threading.Tasks.TaskStatus;

namespace ProgramowanieAplikacjiInternetowych.Models.Tasks
{
    public class TaskGetDataRequest
    {
        public string? TaskName { get; set; }

        public TaskStatus? Status { get; set; }

        public TaskType? Type { get; set; }
    }
}
