using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using ProgramowanieAplikacjiInternetowych.Models.Common;
using ProgramowanieAplikacjiInternetowych.Models.User;
using ProgramowanieAplikacjiInternetowych.Repository.Models;
using ProgramowanieAplikacjiInternetowych.Repository.Users;
using ProgramowanieAplikacjiInternetowych.Utils;

namespace ProgramowanieAplikacjiInternetowych.Services.Users
{
    public class UsersDataService : IUsersDataService
    {
        private readonly ILogger _logger;
        private readonly IUsersRepository _usersRepository;

        public UsersDataService(
            ILogger<UsersDataService> logger,
            IUsersRepository usersRepository)
        {
            _logger = logger;
            _usersRepository = usersRepository;
        }

        public Response<string> AddUser(AddUserRequest request)
        {
            try
            {
                string userHash = Guid.NewGuid().ToString();

                if (IsEmailTaken(request.Email).Data || !Regex.IsMatch(request.Email,AppSettings.EmailExpression) 
                    || request.Password.Length < 4 || string.IsNullOrWhiteSpace(request.Address) 
                    || string.IsNullOrWhiteSpace(request.City) || string.IsNullOrWhiteSpace(request.Country) 
                    || string.IsNullOrWhiteSpace(request.PersonName) || string.IsNullOrWhiteSpace(request.PhoneNumber) 
                    || string.IsNullOrWhiteSpace(request.ZipCode) || string.IsNullOrWhiteSpace(request.Password))
                {
                    return Response<string>.Failed();
                }

                int affectedRows = _usersRepository.AddNewUser(new User
                {
                    Email = request.Email,
                    Password = request.Password,
                    Hash = userHash,
                    UserType = request.UserType,
                    CreateAccountDate = DateTime.Now,
                    Address = request.Address,
                    City = request.City,
                    Country = request.Country,
                    DeleteAccountDate = new DateTime(1900,1,1),
                    Status = false,
                    PersonName = request.PersonName,
                    PhoneNumber = request.PhoneNumber,
                    ZipCode = request.ZipCode,
                    IsVerified = request.IsVerified
                });

                return affectedRows == 1
                    ? Response<string>.Succeeded(userHash)
                    : Response<string>.Failed();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.ToString());
                return Response<string>.Failed();
            }
        }

        public Response<User> GetUserByMailOrHash(string predicate)
        {
            if (string.IsNullOrWhiteSpace(predicate))
            {
                return Response<User>.Failed();
            }

            var response = _usersRepository.GetAllUsers(user =>
                Regex.IsMatch(predicate, AppSettings.EmailExpression)
                    ? user.Email == predicate
                    : user.Hash == predicate);

            return response.Count() == 1 
                ? Response<User>.Succeeded(response.FirstOrDefault()) 
                : Response<User>.Failed();
        }

        public bool DeleteUser(string hash)
        {
            try
            {
                return string.IsNullOrWhiteSpace(hash) 
                       && _usersRepository.GetAllUsers(u => u.Hash == hash).Any() 
                       && _usersRepository.DeleteUser(hash);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.ToString());
                return false;
            }
        }

        public Response<bool> IsEmailTaken(string email)
        {
            try
            {
                return Response<bool>.Succeeded(_usersRepository.IsEmailAlreadyUsed(email));
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.ToString());
                return Response<bool>.Failed();
            }
        }

        public Response<bool> UpdateUser(string hash, Dictionary<string, object> propertiesToUpdate)
        {
            throw new System.NotImplementedException();
        }

        public bool SetNegativeStatus(string hash) => string.IsNullOrWhiteSpace(hash) ? false : _usersRepository.SetNegativeStatus(hash);
    }
}
