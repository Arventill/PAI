using System;
using System.Collections.Generic;
using System.Linq;
using ProgramowanieAplikacjiInternetowych.Enums;
using Task = ProgramowanieAplikacjiInternetowych.Repository.Models.Task;

namespace ProgramowanieAplikacjiInternetowych.Repository.Tasks
{
    public interface ITasksRepository
    {
        int AddNewTask(Task task);

        IQueryable<Task> GetTasksOrdered();

        IEnumerable<Task> GetAllTasksPredicated(Func<Task, bool> predicate);

        public int DeleteTask(Func<Task, bool> predicate);

        int ChangeTaskStatus(int taskId, TaskStatus taskStatus);
    }
}
