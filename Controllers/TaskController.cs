using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgramowanieAplikacjiInternetowych.Enums;
using ProgramowanieAplikacjiInternetowych.Models.Tasks;
using ProgramowanieAplikacjiInternetowych.Services.Tasks;
using ProgramowanieAplikacjiInternetowych.Models.Common;
using ProgramowanieAplikacjiInternetowych.Repository.Models;

namespace ProgramowanieAplikacjiInternetowych.Controllers
{
    [Route("api/task/[action]")]
    public class TaskController : Controller
    {
        private readonly ILogger _logger;
        private readonly ITasksDataService _tasksDataService;

        public TaskController(
            ILogger<TaskController> logger,
            ITasksDataService tasksDataService)
        {
            _logger = logger;
            _tasksDataService = tasksDataService;
        }

        [HttpPost]
        public IActionResult RegisterTask([FromBody] AddTaskRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            return (!string.IsNullOrWhiteSpace(request.Title)
                   && !string.IsNullOrWhiteSpace(request.Description)
                   && request.ExpirationDate > new DateTime(1900, 1, 1)
                   && !string.IsNullOrWhiteSpace(request.UserHash)
                   && _tasksDataService.AddNewTask(request).IsSuccess)
                ? new OkObjectResult(Response<bool>.Succeeded(true))
                : new OkObjectResult(Response<bool>.Failed());
        }

        [HttpGet]
        public IActionResult GetAllTasks() => new OkObjectResult(_tasksDataService.GetTasksOrdered().Data);

        [HttpPost]
        public IActionResult GetTaskByPredicate(TaskGetDataRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            return new OkObjectResult(_tasksDataService.GetTaskByPredicate(request));
        }

        [HttpPost]
        public IActionResult DeleteTask(Task task) => new OkObjectResult(_tasksDataService.DeleteTask(task));

        [HttpPost]
        public IActionResult ChangeTaskStatus(int taskId, TaskStatus taskStatus)
        {
            if (taskId > 0)
            {
                return new OkObjectResult(_tasksDataService.ChangeTaskStatus(taskId, taskStatus));
            }

            return new OkObjectResult(false);
        }
    }
}
