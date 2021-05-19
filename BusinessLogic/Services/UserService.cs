using BusinessLogic.IService;
using Domain;
using Persistence.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository _userRepository)
        {
            this._userRepository = _userRepository;
        }
        public void DeleteUser(int UserID)
        {
            _userRepository.Delete(UserID);
        }

        public User FindUserById(int UserID)
        {
            return _userRepository.GetById(UserID);
        }

        public IEnumerable<User> GetUsers(int page, int pageLength)
        {
            return _userRepository.GetAllUsers(page, pageLength);
        }

        public void InsertUser(User user)
        {
            _userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }
    }
}
