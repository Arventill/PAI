using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgramowanieAplikacjiInternetowych.Models.Common;
using ProgramowanieAplikacjiInternetowych.Models.Requests;
using ProgramowanieAplikacjiInternetowych.Models.User;
using ProgramowanieAplikacjiInternetowych.Repository.Models;
using ProgramowanieAplikacjiInternetowych.Services.Users;
using ProgramowanieAplikacjiInternetowych.Utils;

namespace ProgramowanieAplikacjiInternetowych.Controllers
{
    [Route("api/client/[action]")]
    public class UserController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUsersDataService _usersDataService;

        public UserController(
            ILogger<UserController> logger,
            IUsersDataService usersDataService)
        {
            _logger = logger;
            _usersDataService = usersDataService;
        }

        [HttpPost]
        public IActionResult Register([FromBody] AddUserRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var isEmailTaken = _usersDataService.IsEmailTaken(request.Email);

            if (!isEmailTaken.IsSuccess)
            {
                return new OkObjectResult(Models.Common.Response.Failed());
            }

            if (isEmailTaken.Data)
            {
                return new OkObjectResult(Response<bool>.Succeeded(false));
            }

            var registerResult = _usersDataService.AddUser(request);

            if (!registerResult.IsSuccess)
            {
                return new OkObjectResult(Models.Common.Response.Failed());
            }

            return new OkObjectResult(Response<bool>.Succeeded(true));
        }

        [HttpPost]
        public IActionResult IsEmailTaken([FromBody] BaseDataRequest request) =>
            request == null ||
            string.IsNullOrWhiteSpace(request.Email) ||
            !Regex.IsMatch(request.Email, AppSettings.EmailExpression)
                ? (IActionResult)BadRequest()
                : new OkObjectResult(_usersDataService.IsEmailTaken(request.Email));

        public IActionResult GetUserByPredicate(string predicate)
        {
            var user = _usersDataService.GetUserByMailOrHash(predicate);

            return user == new Response<User>() 
                ? new OkObjectResult(user) 
                : new OkObjectResult(Models.Common.Response.Failed());
        }

        public IActionResult SetNegativeUserStatus(string hash) => new OkObjectResult(_usersDataService.SetNegativeStatus(hash));

        public IActionResult DeleteUser(string hash) => new OkObjectResult(_usersDataService.DeleteUser(hash));

        //TODO: README
        //Metoda do zwracania wszystkich użytkowników w UsersRepository.
        //Nie ma kontrolera do niej ponieważ nie widzę żadnego, bezpiecznego
        //i praktycznego zastosowania tej metody w kontrolerze z dostępem publicznym.
    }
}
