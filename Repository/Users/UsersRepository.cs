using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProgramowanieAplikacjiInternetowych.Repository.Models;

namespace ProgramowanieAplikacjiInternetowych.Repository.Users
{
    public class UsersRepository : IUsersRepository
    {
        private readonly PaiDbContext _dbContext;

        private IQueryable<User> UserEntities => _dbContext.Users.AsNoTracking();

        public bool IsEmailAlreadyUsed(string email) => UserEntities.Any(client => client.Email == email);

        public IEnumerable<User> GetAllUsers(Func<User, bool> predicate) => UserEntities.Where(predicate).ToList();

        public int AddNewUser(User user)
        {
            _dbContext.Users.Add(user);
            return _dbContext.SaveChanges();
        }

        public bool SetNegativeStatus(string hash)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Hash == hash);
            user.Status = !user.Status;

            return _dbContext.SaveChanges() == 1;
        }

        public bool DeleteUser(string hash)
        {
            try
            {
                var user = _dbContext.Users.FirstOrDefault(u => u.Hash == hash);
                var userTasks = _dbContext.Tasks.Where(t => t.User == user).ToList();

                user.DeleteAccountDate = DateTime.Now;
                userTasks.ForEach(task => _dbContext.Tasks.Remove(task));
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
