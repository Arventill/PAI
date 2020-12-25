using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgramowanieAplikacjiInternetowych.Services.Users;

namespace ProgramowanieAplikacjiInternetowych.Controllers
{
    [Route("api/client/[action]")]
    public class TaskController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUsersDataService _clientsDataService;

        public TaskController(
            ILogger<TaskController> logger,
            IUsersDataService clientsDataService)
        {
            _logger = logger;
            _clientsDataService = clientsDataService;
        }

        [HttpGet]
        public IActionResult GetClientData()
        {



            return string.IsNullOrWhiteSpace("hash")
                ? (IActionResult)new BadRequestResult()
                : new OkObjectResult(_clientsDataService);
        }
    }
}
