using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.IRepositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers(int page, int pageLength);
        User GetById(int id);
        User Insert(User obj);
        void Update(User obj);
        void Delete(int id);
        void Save();
    }
}
