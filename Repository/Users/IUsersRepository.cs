using System;
using System.Collections.Generic;
using ProgramowanieAplikacjiInternetowych.Repository.Models;

namespace ProgramowanieAplikacjiInternetowych.Repository.Users
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAllUsers(Func<User, bool> predicate);

        int AddNewUser(User user);

        bool IsEmailAlreadyUsed(string email);

        bool SetNegativeStatus(string hash);

        bool DeleteUser(string hash);
    }
}
