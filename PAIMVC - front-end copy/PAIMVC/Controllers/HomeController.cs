using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PAIMVC.Models.Requests;

namespace PAIMVC.Controllers
{
    [Route("api/[action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //                                                                          Wyświetlanie widoków:
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserRegister()
        {
            return View("UserRegister");
        }

        public IActionResult UserCheckMail()
        {
            return View("UserEmailCheck");
        }

        public IActionResult GetUser()
        {
            return View("UserGet");
        }

        public IActionResult UserSetNegativeStatus()
        {
            return View("UserSetStatus");
        }

        public IActionResult UserDelete()
        {
            return View("UserDelete");
        }

        public IActionResult TaskRegister()
        {
            return View("TaskRegister");
        }

        public IActionResult TaskGetAll()
        {
            return View("TaskGetAll");
        }

        public IActionResult TaskGet()
        {
            return View("TaskGet");
        }

        public IActionResult TaskDelete()
        {
            return View("TaskDelete");
        }

        public IActionResult TaskStatusChange()
        {
            return View("TaskChangeStatus");
        }

        //                                                              Obsługa requestów i przesyłanie ich do projektu z API:
        [HttpPost]
        public IActionResult PUserRegister(UserRegisterRequest userRegisterRequest)
        {
            WebRequest request = WebRequest.Create("http://localhost:55106/api/user/Register");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;


            // Set the Method property of the request to POST.
            request.Method = "POST";

            // Create POST data and convert it to a byte array.
            byte[] byteArray = Encoding.UTF8.GetBytes(userRegisterRequest.ToString());

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;


            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PUserCheckMail(UserRegisterRequest userRegisterRequest)
        {
            var baseDataR = new BaseDataRequest {Email = userRegisterRequest.Email};

            WebRequest request = WebRequest.Create("http://localhost:55106/api/user/IsEmailTaken");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;


            // Set the Method property of the request to POST.
            request.Method = "POST";

            // Create POST data and convert it to a byte array.
            byte[] byteArray = Encoding.UTF8.GetBytes(baseDataR.ToString());

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;


            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PGetUser(UserRegisterRequest userRegisterRequest)
        {
            WebRequest request;

            if (!string.IsNullOrWhiteSpace(userRegisterRequest.Email))
            {
                request = WebRequest.Create("http://localhost:55106/api/user/GetUserByPredicate" + "?predicate=" + userRegisterRequest.Email);
            }
            else
            {
                request = WebRequest.Create("http://localhost:55106/api/user/GetUserByPredicate" + "?predicate=" + userRegisterRequest.Hash);
            }

            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PUserSetNegativeStatus(UserRegisterRequest userRegisterRequest)
        {
            WebRequest request = WebRequest.Create("http://localhost:55106/api/user/SetNegativeUserStatus" + "?hash=" + userRegisterRequest.Hash);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PUserDelete(UserRegisterRequest userRegisterRequest)
        {
            WebRequest request = WebRequest.Create("http://localhost:55106/api/user/DeleteUser" + "?hash=" + userRegisterRequest.Hash);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PTaskRegister(TaskRegisterRequest taskRegisterRequest)
        {
            WebRequest request = WebRequest.Create("http://localhost:55106/api/user/RegisterTask");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;


            // Set the Method property of the request to POST.
            request.Method = "POST";

            // Create POST data and convert it to a byte array.
            byte[] byteArray = Encoding.UTF8.GetBytes(taskRegisterRequest.ToString());

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;


            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PTaskGetAll(TaskRegisterRequest taskRegisterRequest)
        {
            WebRequest request = WebRequest.Create("http://localhost:55106/api/user/GetAllTasks");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PTaskGet(TaskRegisterRequest taskRegisterRequest)
        {
            var data = new TaskGetDataRequest();
            data.TaskName = taskRegisterRequest.Title;
            data.Status = (TaskStatus?) taskRegisterRequest.Status;
            data.Type = taskRegisterRequest.Type;


            WebRequest request = WebRequest.Create("http://localhost:55106/api/user/GetTaskByPredicate");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;


            // Set the Method property of the request to POST.
            request.Method = "POST";

            // Create POST data and convert it to a byte array.
            byte[] byteArray = Encoding.UTF8.GetBytes(taskRegisterRequest.ToString());

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;


            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PTaskDelete(TaskRegisterRequest taskRegisterRequest)
        {
            WebRequest request = WebRequest.Create("http://localhost:55106/api/user/DeleteTask");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Set the Method property of the request to POST.
            request.Method = "POST";

            // Create POST data and convert it to a byte array.
            byte[] byteArray = Encoding.UTF8.GetBytes(taskRegisterRequest.ToString());

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;

            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PTaskStatusChange(TaskRegisterRequest taskRegisterRequest)
        {
            if (taskRegisterRequest.Id > 0 && (int) taskRegisterRequest.Status > 0 &&
                (int) taskRegisterRequest.Status < 7)
            {
                WebRequest request = WebRequest.Create("http://localhost:55106/api/user/ChangeTaskStatus" 
                                                       + "?taskId" + taskRegisterRequest.Id + "&taskStatus=" + taskRegisterRequest.Status);
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // Get the response.
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                // Display the status.
                Console.WriteLine(response.StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
            }
            

            return View("Index");
        }
    }
}
