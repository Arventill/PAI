using System.Collections.Generic;
using ProgramowanieAplikacjiInternetowych.Models.Common;
using ProgramowanieAplikacjiInternetowych.Models.User;
using ProgramowanieAplikacjiInternetowych.Repository.Models;

namespace ProgramowanieAplikacjiInternetowych.Services.Users
{
    public interface IUsersDataService
    {
        /// <summary>
        /// Adds new user (teacher or student) to database.
        /// </summary>
        /// <param name="request">request with new user params.</param>
        /// <returns>String with hash of new user.</returns>
        Response<string> AddUser(AddUserRequest request);

        /// <summary>
        /// Gets a user with mail or hash predicated.
        /// </summary>
        /// <param name="predicate">Mail or Hash as string value.</param>
        /// <returns>Requested user if exist or empty user if not.</returns>
        Response<User> GetUserByMailOrHash(string predicate);

        /// <summary>
        /// Deletes user from database including tasks. 
        /// </summary>
        /// <param name="hash">Guid hash of user.</param>
        /// <returns>True if deleted successfully.</returns>
        bool DeleteUser(string hash);

        /// <summary>
        /// Checks if email is already taken.
        /// </summary>
        /// <param name="email">E-mail to check.</param>
        /// <returns>True if E-mail is taken already.</returns>
        Response<bool> IsEmailTaken(string email);

        /// <summary>
        /// Sets negative value of status in Status entity.
        /// </summary>
        /// <returns>True if successful.</returns>
        bool SetNegativeStatus(string hash);

        //Response<Dictionary<string, object>> GetClientData(string hash);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="propertiesToUpdate"></param>
        /// <returns></returns>
        Response<bool> UpdateUser(string hash, Dictionary<string, object> propertiesToUpdate);
    }
}
