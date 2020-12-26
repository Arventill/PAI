using System.Collections.Generic;
using ProgramowanieAplikacjiInternetowych.Enums;
using ProgramowanieAplikacjiInternetowych.Models.Common;
using ProgramowanieAplikacjiInternetowych.Models.Tasks;
using ProgramowanieAplikacjiInternetowych.Repository.Models;

namespace ProgramowanieAplikacjiInternetowych.Services.Tasks
{
    public interface ITasksDataService
    {
        Response<string> AddNewTask(AddTaskRequest request);

        Response<List<Task>> GetTasksOrdered();

        Response<List<Task>> GetTaskByPredicate(TaskGetDataRequest request);

        bool DeleteTask(Task predicate);

        bool ChangeTaskStatus(int taskId, TaskStatus taskStatus);
    }
}
