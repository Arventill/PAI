using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using ProgramowanieAplikacjiInternetowych.Enums;
using ProgramowanieAplikacjiInternetowych.Models.Common;
using ProgramowanieAplikacjiInternetowych.Models.Tasks;
using ProgramowanieAplikacjiInternetowych.Repository.Models;
using ProgramowanieAplikacjiInternetowych.Repository.Tasks;
using ProgramowanieAplikacjiInternetowych.Repository.Users;
using ProgramowanieAplikacjiInternetowych.Utils;

namespace ProgramowanieAplikacjiInternetowych.Services.Tasks
{
    public class TasksDataService : ITasksDataService
    {
        private readonly ILogger _logger;
        private readonly ITasksRepository _tasksRepository;
        private readonly IUsersRepository _usersRepository;

        public TasksDataService(
            ILogger<TasksDataService> logger,
            ITasksRepository tasksRepository,
            IUsersRepository usersRepository)
        {
            _logger = logger;
            _tasksRepository = tasksRepository;
            _usersRepository = usersRepository;
        }

        public Response<string> AddNewTask(AddTaskRequest request)
        {
            try
            {
                int affectedRows = _tasksRepository.AddNewTask(new Task
                {
                    Title = request.Title,
                    Description = request.Description,
                    ExpirationDate = request.ExpirationDate,
                    Type = request.Type,
                    CreateDate = DateTime.Now,
                    Status = request.Status,
                    User = _usersRepository.GetAllUsers(u => u.Hash == request.UserHash).FirstOrDefault()
                });

                return affectedRows == 1
                    ? Response<string>.Succeeded("Dodano nowy task dla użytkownika " + request.UserHash)
                    : Response<string>.Failed();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.ToString());
                return Response<string>.Failed();
            }
        }

        public Response<List<Task>> GetTasksOrdered()
        {
            try
            {
                var orderedTasks = _tasksRepository.GetTasksOrdered().ToList();
                return Response<List<Task>>.Succeeded(orderedTasks);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.ToString());
                return new Response<List<Task>>();
            }
        }

        public Response<List<Task>> GetTaskByPredicate(TaskGetDataRequest request)
        {
            if (request.TaskName != null)
            {
                return string.IsNullOrWhiteSpace(request.TaskName)
                    ? new Response<List<Task>>()
                    : Response<List<Task>>.Succeeded(_tasksRepository.GetAllTasksPredicated(t => t.Title == request.TaskName).ToList());
            }
            else if (request.Type != null)
            {
                return Response<List<Task>>.Succeeded(_tasksRepository.GetAllTasksPredicated(t => t.Type == request.Type).ToList());
            }
            else if (request.Status != null)
            {
                return Response<List<Task>>.Succeeded(_tasksRepository.GetAllTasksPredicated(t => t.Status == (TaskStatus) request.Status).ToList());
            }
            else
            {
                return new Response<List<Task>>();
            }
        }

        public bool DeleteTask(Task predicate)
        {
            if (predicate == null)
            {
                _logger.LogCritical("predicate is null");
                return false;
            }

            if (predicate.Id > 0)
            {
                return _tasksRepository.DeleteTask(t => t.Id == predicate.Id) == 1;
            }
            else if (!string.IsNullOrWhiteSpace(predicate.Title))
            {
                return _tasksRepository.DeleteTask(t => t.Title == predicate.Title) == 1;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeTaskStatus(int taskId, TaskStatus taskStatus) => _tasksRepository.ChangeTaskStatus(taskId, taskStatus) == 1;
    }
}
