
using System;
using System.Collections.Generic;
using NovaKidsControl.Domain.Entities;
using NovaKidsControl.Domain.Interfaces.Repositories;
using NovaKidsControl.Domain.Interfaces.Services;

namespace NovaKidsControl.Domain.Services
{
    public class UserKidsService : ServiceBase<UserKids>, IUserKidsService
    {
        private readonly IUserKidsRepository _userRepository;

        public UserKidsService(IUserKidsRepository repository) : base(repository)
        {
            _userRepository = repository;
        }

        public void Add(UserKids obj)
        {
            _userRepository.Add(obj);
        }

        public new void Delete(UserKids obj)
        {
            _userRepository.Delete(obj);
        }

        public new void Update(UserKids obj)
        {
            _userRepository.Update(obj);
        }

        IEnumerable<UserKids> IServiceBase<UserKids>.GetAll()
        {
            return  _userRepository.GetAll();
        }

        UserKids IServiceBase<UserKids>.GetById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
