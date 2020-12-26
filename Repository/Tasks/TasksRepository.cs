using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProgramowanieAplikacjiInternetowych.Enums;
using Task = ProgramowanieAplikacjiInternetowych.Repository.Models.Task;

namespace ProgramowanieAplikacjiInternetowych.Repository.Tasks
{
    public class TasksRepository : ITasksRepository
    {
        private readonly PaiDbContext _dbContext;

        private IQueryable<Task> TaskEntities => _dbContext.Tasks.AsNoTracking();

        public int AddNewTask(Task task)
        {
            _dbContext.Tasks.Add(task);
            return _dbContext.SaveChanges();
        }

        public IQueryable<Task> GetTasksOrdered() => TaskEntities.OrderByDescending(t => t.CreateDate);

        public IEnumerable<Task> GetAllTasksPredicated(Func<Task, bool> predicate) => TaskEntities.Where(predicate).ToList();

        public int DeleteTask(Func<Task, bool> predicate)
        {
            var task = _dbContext.Tasks.Where(predicate).ToList();
            if (task.Count == 1)
            {
                _dbContext.Tasks.Remove(task.FirstOrDefault());
                return _dbContext.SaveChanges();
            }

            return 0;
        }

        public int ChangeTaskStatus(int taskId, TaskStatus taskStatus)
        {
            var myTask = _dbContext.Tasks.FirstOrDefault(t => t.Id == taskId);
            myTask.Status = taskStatus;
            return _dbContext.SaveChanges();
        }
    }
}
