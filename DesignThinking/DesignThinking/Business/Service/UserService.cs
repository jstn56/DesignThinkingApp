using System;
using System.Collections.Generic;
using DesignThinking.Business.Repository;
using DesignThinking.Interfaces;
using DesignThinking.Models;

namespace DesignThinking.Business.Service
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }

        public bool Delete(User model) => userRepository.Delete(model);

        public User Get(int key) => userRepository.Get(key);

        public IEnumerable<User> GetAll() => userRepository.GetAll();

        public bool Save(User model) => userRepository.Save(model);

        public bool Update(User model, int key) => userRepository.Update(model, key);
    }
}
