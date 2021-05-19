using Domain;
using Persistence.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository()
        {
        }

        public UserRepository(FinesTrackerContext finesTrackerContext) : base(finesTrackerContext)
        {
        }

        public void Delete(int id)
        {
            Delete(id);
        }

        public IEnumerable<User> GetAllUsers(int page, int pageLength)
        {
            return GetAll(page, pageLength);
        }

        public User GetById(int id)
        {
            return GetById(id);
        }
    }
}
