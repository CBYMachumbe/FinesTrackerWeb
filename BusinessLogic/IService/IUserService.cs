using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.IService
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers(int page, int pageLength);

        User FindUserById(int UserID);

        void InsertUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int UserID);
    }
}
